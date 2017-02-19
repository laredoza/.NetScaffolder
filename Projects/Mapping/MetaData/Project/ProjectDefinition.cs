// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinition.cs" company="">
//   
// </copyright>
// <summary>
//   The project definition. This is used to define the metadata required to
//   generate layers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project
{
    #region Using

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using Core.Common.Validation;
    #endregion

    /// <summary>
    ///     The project definition. This is used to define the metadata required to
    ///     generate layers.
    /// </summary>
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
        /// Initializes a new instance of the <see cref="ProjectDefinition"/> class.
        /// </summary>
        public ProjectDefinition()
        {
            this.Domains = new List<DomainDefinition>();
            this.CollectionOptions = new List<CollectionOption>();
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

        /// <summary>
        /// Gets or sets the collection options.
        /// </summary>
        public List<CollectionOption> CollectionOptions { get; set; }

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

            this.ValidationResult = new List<Validation>();

            if (string.IsNullOrEmpty(this.BaseNameSpace))
            {
                this.ValidationResult.Add(new Validation(ValidationType.ProjectBaseNameSpace, "BaseNameSpace may not be empty"));
            }

            if (string.IsNullOrEmpty(this.OutputFolder))
            {
                this.ValidationResult.Add(new Validation(ValidationType.ProjectOutputFolder, "OutputFolder may not be empty"));
            }

            if (this.Version == 0)
            {
                this.ValidationResult.Add(new Validation(ValidationType.ProjectVersion, "Version may not be 0"));
            }

            if (string.IsNullOrEmpty(this.ModelPath))
            {
                this.ValidationResult.Add(new Validation(ValidationType.ProjectModelPath, "ModelPath may not be empty"));
            }

            Logger.Debug($"Number of validation errors: {this.ValidationResult.Count}");
            Logger.Trace($"Validation errors: {this.ValidationResult.ToString()}");
            Logger.Trace($"Completed Validate()");

            foreach (DomainDefinition domainDefinition in this.Domains)
            {
                domainDefinition.Validate();
                if (domainDefinition.ValidationResult.Count > 0)
                {
                    foreach (var domainResult in domainDefinition.ValidationResult)
                    {
                        this.ValidationResult.Add(domainResult);
                    }
                }
            }

            return this.ValidationResult;
        }

        #endregion
    }
}