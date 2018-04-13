// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigurationApplicationServiceFile.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Application;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;

    #endregion

    /// <summary>
    /// The configuration application service file.
    /// </summary>
    public class ConfigurationApplicationServiceFile : IConfigurationApplicationService
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApplicationServiceFile"/> class.
        /// </summary>
        public ConfigurationApplicationServiceFile()
        {
            Logger.Trace($"Started ConfigurationAplicationServiceFile()");
            ApplicationSettings = new ApplicationSettings();
            FilePersistenceOptions = new FilePersistenceOptions();
            Logger.Trace($"Completed ConfigurationAplicationServiceFile()");
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the application settings.
        /// </summary>
        public ApplicationSettings ApplicationSettings { get; set; }

        /// <summary>
        ///     Gets or sets the file persistence options.
        /// </summary>
        public FilePersistenceOptions FilePersistenceOptions { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The load.
        /// </summary>
        public void Load()
        {
            Logger.Trace($"Started Load() - Path: {FilePersistenceOptions.Path}");
            ApplicationSettings = ObjectXMLSerializer<ApplicationSettings>.Load(FilePersistenceOptions.Path);

            string dataTypeName = string.Empty;
            Guid dataTypeId;
            bool sort = false;
            IDataType<Dictionary<string, string>> dataTypeInterface;

            foreach (var dataType in ScaffoldConfig.DataTypes)
            {
                dataTypeName = (string)dataType.Metadata["NameMetaData"];
                dataTypeId = new Guid(dataType.Metadata["ValueMetaData"].ToString());

                if (ApplicationSettings.Templates[0].Children.All(t => t.Id.ToString().ToLower() != dataTypeId.ToString().ToLower()))
                {
                    ApplicationSettings.Templates[0].Children.Add(new Template
                                                                      {
                                                                          Id = dataTypeId,
                                                                          Name = dataTypeName,
                                                                          HierarchyType = HierarchyType.Group,
                                                                          Version = 1,
                                                                          Enabled = true,
                                                                          DataType = dataTypeId
                                                                      });
                    sort = true;
                }
            }

            if (sort)
            {
                ApplicationSettings.Templates[0].Children =
                    ApplicationSettings.Templates[0].Children.OrderBy(t => t.Name).ToList();
            }

            Logger.Trace($"Completed Load() - Path: {FilePersistenceOptions.Path}");
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <exception cref="ApplicationException">
        /// </exception>
        public void Save()
        {
            Logger.Trace($"Started Save() - Path: {FilePersistenceOptions.Path}");

            ValidationResult = ApplicationSettings.Validate();

            if (ValidationResult.Count == 0)
            {
                ObjectXMLSerializer<ApplicationSettings>.Save(
                    ApplicationSettings,
                    FilePersistenceOptions.Path,
                    SerializedFormat.Document);
            }
            else
            {
                Logger.Error($"Validation error: {ValidationResult}");
                throw new ApplicationException($"Validation error: {ValidationResult}");
            }

            Logger.Trace($"Completed Save() - Path: {FilePersistenceOptions.Path}");
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace($"Started Validate()");
            ValidationResult.Clear();

            ApplicationSettings.Validate();

            foreach (var validation in ApplicationSettings.ValidationResult)
            {
                ValidationResult.Add(validation);
            }

            Logger.Trace($"Completed Validate()");
            return ValidationResult;
        }

        #endregion
    }
}