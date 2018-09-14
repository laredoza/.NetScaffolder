// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainDefinition.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Domain
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

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
            this.Id = Guid.NewGuid();
            this.ValidationResult = new List<Validation>();
            this.DriverIdList = new List<Guid>();
            this.Package = new Package();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the collection option. At the moment this specifies the collection parent but could be extended at a
        ///     later stage.
        /// </summary>
        public Guid CollectionOptionId { get; set; }

        /// <summary>
        /// Gets or sets the driver id list.
        /// </summary>
        public List<Guid> DriverIdList { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the name of the domain.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the naming convention Id.
        /// </summary>
        public Guid NamingConventionId { get; set; }

        /// <summary>
        ///     Gets or sets the package.
        /// </summary>
        public Package Package { get; set; }

        /// <summary>
        ///     Gets or sets the source type. This specifies if it should be loaded from an edmx file,
        ///     sql metadata, etc.
        /// </summary>
        public Guid SourceTypeId { get; set; }

        /// <summary>
        ///     Gets or sets the tables belonging to the domain
        /// </summary>
        public List<Table> Tables { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List{T}" />
        ///     Errors returned
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validate()");

            this.ValidationResult.Clear();

            if (string.IsNullOrEmpty(this.Name))
            {
                this.ValidationResult.Add(new Validation(ValidationType.DomainName, "Name cannot be empty"));
            }

            if (this.Id == Guid.Empty)
            {
                this.ValidationResult.Add(new Validation(ValidationType.DomainId, "Id cannot be empty"));
            }

            if (this.NamingConventionId == Guid.Empty)
            {
                this.ValidationResult.Add(
                    new Validation(ValidationType.NamingConventionId, "NamingConventionId cannot be empty"));
            }

            if (this.SourceTypeId == Guid.Empty)
            {
                this.ValidationResult.Add(new Validation(ValidationType.SourceTypeId, "SourceTypeId cannot be empty"));
            }

            if (this.DriverIdList.Count == 0)
            {
                this.ValidationResult.Add(new Validation(ValidationType.DriverTypeId, "DriverIdList cannot be empty"));
            }

            if (this.CollectionOptionId == Guid.Empty)
            {
                this.ValidationResult.Add(
                    new Validation(ValidationType.CollectionOptionId, "CollectionOptionId cannot be empty"));
            }

            Logger.Debug($"Number of Validation errors: {this.ValidationResult.Count}");
            Logger.Trace($"Validation errors: {this.ValidationResult}");
            Logger.Trace("Completed Validate()");
            return this.ValidationResult;
        }

        #endregion
    }
}