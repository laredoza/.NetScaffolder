// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainDefinition.cs" company="">
//   
// </copyright>
// <summary>
//   The domain definition. Domains are used to group
//   tables together. i.e) Security
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Domain
{
    #region Using

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using global::MetaData;
    using global::MetaData.Project;

    #endregion

    /// <summary>
    ///     The domain definition. Domains are used to group
    ///     tables together. i.e) Security
    /// </summary>
    public class DomainDefinition : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DomainDefinition" /> class.
        /// </summary>
        public DomainDefinition()
        {
            this.Tables = new List<Table>();
            this.Package = new Package();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the collection option. At the moment this specifies the collection parent but could be extended at a
        ///     later stage.
        /// </summary>
        public CollectionOption CollectionOption { get; set; }

        /// <summary>
        ///     Gets or sets the driver type (Oracle Default). Should be loaded from MEF
        /// </summary>
        public DriverType DriverType { get; set; }

        /// <summary>
        ///     Gets or sets the name of the domain.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the naming convention. Should be loaded from MEF
        /// </summary>
        public NamingConvention NamingConvention { get; set; }

        /// <summary>
        ///     Gets or sets the package.
        /// </summary>
        public Package Package { get; set; }

        /// <summary>
        ///     Gets or sets the source type. This specifies if it should be loaded from an edmx file,
        ///     sql metadata, etc. Should be loaded from MEF
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        ///     Gets or sets the tables belonging to the domain
        /// </summary>
        public List<Table> Tables { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<string> ValidationResult { get; set; }

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
            Logger.Trace("Started Validate()");

            this.ValidationResult = new List<string>();

            if (string.IsNullOrEmpty(this.Name))
            {
                this.ValidationResult.Add("Name cannot be empty");
            }

            Logger.Debug($"Number of Validation errors: {this.ValidationResult.Count}");
            Logger.Trace($"Validation errors: {this.ValidationResult.ToString()}");
            Logger.Trace("Completed Validate()");
            return this.ValidationResult;
        }

        #endregion
    }
}