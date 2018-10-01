// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationSettings.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Application
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    #endregion

    /// <summary>
    ///     The application settings.
    /// </summary>
    public class ApplicationSettings : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationSettings" /> class.
        /// </summary>
        public ApplicationSettings()
        {
            Logger.Trace("Started ApplicationSettings()");
            this.Templates = new List<Template>();
            this.Packages = new List<Package>();
            this.ValidationResult = new List<Validation>();
            this.DataTypes = new List<DataType>();
            Logger.Trace("Completed ApplicationSettings()");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data types.
        /// </summary>
        public List<DataType> DataTypes { get; set; }

        /// <summary>
        ///     Gets or sets the packages.
        /// </summary>
        public List<Package> Packages { get; set; }

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<Template> Templates { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validate()");
            this.ValidationResult.Clear();

            foreach (var dataType in this.DataTypes)
            {
                dataType.Validate();

                foreach (var tempResult in dataType.ValidationResult)
                {
                    this.ValidationResult.Add(tempResult);
                }
            }

            foreach (var template in this.Templates)
            {
                template.Validate();

                foreach (var validationResult in template.ValidationResult)
                {
                    this.ValidationResult.Add(validationResult);
                }
            }

            Logger.Trace("Completed Validate()");
            return this.ValidationResult;
        }

        #endregion
    }
}