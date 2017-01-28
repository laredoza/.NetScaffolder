// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinition.cs" company="">
//   
// </copyright>
// <summary>
//   The project definition. This is used to define the metadata required to
//   generate layers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MetaData.Project
{
    #region Using

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using MetaData.Domain;
    using MetaData.Enum;

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
        public List<string> ValidationResult { get; set; }

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
        public List<string> Validate()
        {
            Logger.Trace($"Started Validate()");

            this.ValidationResult = new List<string>();

            if (string.IsNullOrEmpty(this.BaseNameSpace))
            {
                this.ValidationResult.Add("BaseNameSpace may not be empty");
            }

            if (string.IsNullOrEmpty(this.OutputFolder))
            {
                this.ValidationResult.Add("OutputFolder may not be empty");
            }

            if (this.Version == 0)
            {
                this.ValidationResult.Add("Version may not be 0");
            }

            if (string.IsNullOrEmpty(this.ModelPath))
            {
                this.ValidationResult.Add("ModelPath may not be empty");
            }

            Logger.Debug($"Number of validation errors: {this.ValidationResult.Count}");
            Logger.Trace($"Validation errors: {this.ValidationResult.ToString()}");
            Logger.Trace($"Completed Validate()");

            foreach (DomainDefinition domainDefinition in this.Domains)
            {
                if (domainDefinition.Validate().Count > 0)
                {
                    this.ValidationResult.AddRange(domainDefinition.ValidationResult);
                }
            }

            return this.ValidationResult;
        }

        #endregion
    }
}