﻿// --------------------------------------------------------------------------------------------------------------------
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

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Serializer;

    using global::MetaData.Project;

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
        public List<string> ValidationResult { get; set; }

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

        #endregion

        #region Implementation of IValidate

        /// <summary>
        /// Validate class.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>
        /// Errors returned
        /// </returns>
        public List<string> Validate()
        {
            Logger.Trace($"Started Validate()");
            this.ValidationResult = this.ProjectDefinition.Validate();
            Logger.Trace($"Completed Validate()");
            return this.ValidationResult;
        }

        #endregion
    }
}