// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinition.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Enum;

    #endregion

    /// <summary>
    ///     The project definition. This is used to define the metadata required to
    ///     generate layers.
    /// </summary>
    [Serializable]
    public class ProjectDefinition : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDefinition" /> class.
        /// </summary>
        public ProjectDefinition()
        {
            this.Domains = new List<DomainDefinition>();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the base name space.
        ///     i.e) Cars.Models
        /// </summary>
        public string BaseNameSpace { get; set; }

        /// <summary>
        ///     Gets or sets the domains.
        /// </summary>
        public List<DomainDefinition> Domains { get; set; }

        /// <summary>
        ///     Gets or sets how layers are generated
        /// </summary>
        public GenerationType GroupBy { get; set; }

        /// <summary>
        ///     Gets or sets the model path.
        /// </summary>
        public string ModelPath { get; set; }

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        ///     Gets or sets the version of the project definition.
        /// </summary>
        public double Version { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List{T}" />
        ///     Errors returned
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace($"Started Validate()");

            ValidationResult = new List<Validation>();

            if (string.IsNullOrEmpty(BaseNameSpace))
            {
                ValidationResult.Add(new Validation(ValidationType.ProjectBaseNameSpace, "BaseNameSpace may not be empty"));
            }

            if (string.IsNullOrEmpty(OutputFolder))
            {
                ValidationResult.Add(new Validation(ValidationType.ProjectOutputFolder, "OutputFolder may not be empty"));
            }

            if (Version == 0)
            {
                ValidationResult.Add(new Validation(ValidationType.ProjectVersion, "Version may not be 0"));
            }

            if (string.IsNullOrEmpty(ModelPath))
            {
                ValidationResult.Add(new Validation(ValidationType.ProjectModelPath, "ModelPath may not be empty"));
            }

            Logger.Debug($"Number of validation errors: {ValidationResult.Count}");
            Logger.Trace($"Validation errors: {ValidationResult}");
            Logger.Trace($"Completed Validate()");

            foreach (DomainDefinition domainDefinition in Domains)
            {
                domainDefinition.Validate();
                if (domainDefinition.ValidationResult.Count > 0)
                {
                    foreach (var domainResult in domainDefinition.ValidationResult)
                    {
                        ValidationResult.Add(domainResult);
                    }
                }
            }

            return ValidationResult;
        }

        #endregion
    }
}