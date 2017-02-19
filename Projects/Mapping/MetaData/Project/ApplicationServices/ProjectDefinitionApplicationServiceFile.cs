// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinitionApplicationServiceFile.cs" company="">
//   
// </copyright>
// <summary>
//   The file project definition.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using System.Xml.Serialization;
    #endregion

    /// <summary>
    ///     The file project definition.
    /// </summary>
    public class ProjectDefinitionApplicationServiceFile : IProjectDefinitionApplicationService
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDefinitionApplicationServiceFile" /> class.
        /// </summary>
        public ProjectDefinitionApplicationServiceFile()
        {
            Logger.Trace($"Started ProjectDefinitionApplicationServiceFile()");
            this.ProjectDefinition = new ProjectDefinition();
            this.FilePersistenceOptions = new FilePersistenceOptions();
            Logger.Trace($"Completed ProjectDefinitionApplicationServiceFile()");
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the file persistence options.
        /// </summary>
        public FilePersistenceOptions FilePersistenceOptions { get; set; }

        /// <summary>
        ///     Gets or sets the project definition.
        /// </summary>
        public ProjectDefinition ProjectDefinition { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public Dictionary<ValidationType, string> ValidationResult { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Load ProjectDefinition.
        /// </summary>
        public void Load()
        {
            Logger.Trace($"Started Load() - Path: {this.FilePersistenceOptions.Path}");
            this.ProjectDefinition = ObjectXMLSerializer<ProjectDefinition>.Load(this.FilePersistenceOptions.Path);
            Logger.Trace($"Completed Load() - Path: {this.FilePersistenceOptions.Path}");
        }

        public void UpdateLookups()
        {
            
        }

        /// <summary>
        ///     Save ProjectDefinition.
        /// </summary>
        public void Save()
        {
            Logger.Trace($"Started Save() - Path: {this.FilePersistenceOptions.Path}");

            this.ValidationResult = this.ProjectDefinition.Validate();

            if (this.Validate().Count == 0)
            {
                ObjectXMLSerializer<ProjectDefinition>.Save(
                    this.ProjectDefinition,
                    this.FilePersistenceOptions.Path,
                    SerializedFormat.Document);
            }
            else
            {
                Logger.Error($"Validation error: {this.ValidationResult.ToString()}");
                throw new ApplicationException($"Validation error: {this.ValidationResult.ToString()}");
            }

            Logger.Trace($"Completed Save() - Path: {this.FilePersistenceOptions.Path}");
        }

        /// <summary>
        /// The add domain.
        /// </summary>
        /// <returns>
        /// The <see cref="DomainDefinition"/>.
        /// </returns>
        public DomainDefinition AddDomain()
        {
            Logger.Trace($"Started AddDomain()");
            DomainDefinition result = new DomainDefinition();

            int index = 1;

            while (this.ProjectDefinition.Domains.Exists(d => d.Name == $"Domain{index}"))
            {
                index++;
            }

            result.Name = $"Domain{index}";
            Logger.Trace($"Domain name: {result.Name}");
            this.ProjectDefinition.Domains.Add(result);
            Logger.Trace($"Completed AddDomain()");

            return result;
        }

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public void Delete(Guid id)
        {
            Logger.Trace($"Started Delete() - id: {id}");

            if (this.ProjectDefinition.Domains.Exists(d => d.Id == id))
            {
                this.ProjectDefinition.Domains.Remove(
                    this.ProjectDefinition.Domains.Where(d => d.Id == id).FirstOrDefault());
            }

            Logger.Trace($"Completed Delete() - id: {id}");
        }

        #endregion

        #region Implementation of IValidate

        /// <summary>
        /// Validate class.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>
        /// Errors returned
        /// </returns>
        public Dictionary<ValidationType, string> Validate()
        {
            Logger.Trace($"Started Validate()");
            this.ValidationResult = this.ProjectDefinition.Validate();
            Logger.Trace($"Completed Validate()");
            return this.ValidationResult;
        }

        #endregion
    }
}