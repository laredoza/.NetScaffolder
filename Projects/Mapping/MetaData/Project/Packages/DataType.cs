// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;

    #endregion

    /// <summary>
    ///     This class is used to represent the base data types used by
    ///     the generator.
    /// </summary>
    /// <example>
    ///     Context, Entity, Repository
    /// </example>
    public class DataType : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DataType" /> class.
        /// </summary>
        public DataType()
        {
            Logger.Trace("Started DataType()");
            ValidationResult = new List<Validation>();
            Logger.Trace("Completed DataType()");
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validate()");
            ValidationResult.Clear();

            if (Id == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.DomainId, "DomainId should not be empty"));
            }

            if (string.IsNullOrEmpty(Name))
            {
                ValidationResult.Add(new Validation(ValidationType.DomainName, "DomainName should not be empty"));
            }

            Logger.Trace("Completed Validate()");
            return ValidationResult;
        }

        #endregion
    }
}