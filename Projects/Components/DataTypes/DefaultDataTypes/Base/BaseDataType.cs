// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base
{
    #region Usings

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The base data type.
    /// </summary>
    public abstract class BaseDataType : IDataType 
    {
        #region Fields

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDataType"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        protected BaseDataType(string fileName)
        {
            this.FileName = fileName;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the base namespace.
        /// </summary>
        [XmlIgnore]
        public string BaseNamespace { get; set; }

        /// <summary>
        ///     Gets or sets the collection option.
        /// </summary>
        [XmlIgnore]
        public ICollectionOption CollectionOption { get; set; }

        /// <summary>
        ///     Gets or sets the driver types.
        /// </summary>
        [XmlIgnore]
        public List<IDriver> DriverTypes { get; set; }

        /// <summary>
        ///     Gets or sets the meta data.
        /// </summary>
        public Table MetaData { get; set; }

        /// <summary>
        ///     Gets or sets the naming convention.
        /// </summary>
        [XmlIgnore]
        public INamingConvention NamingConvention { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        /// Gets or sets the domain definition.
        /// </summary>
        [XmlIgnore]
        public DomainDefinition DomainDefinition { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The create ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="IDataTypeUI"/>.
        /// </returns>
        public abstract IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters);

        /// <summary>
        ///     The create ui.
        /// </summary>
        /// <returns>
        ///     The <see cref="IDataTypeUI" />.
        /// </returns>
        public abstract IDataTypeUI<IDictionary<string, string>> CreateUI();

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public abstract void Load(IDictionary<string, string> parameters);

        /// <summary>
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="Hierarchy" />.
        /// </returns>
        public abstract Hierarchy ReturnNavigation();

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public abstract bool Save(IDictionary<string, string> parameters);

        /// <inheritdoc />
        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.Collections.Generic.List`1" />.
        /// </returns>
        public abstract List<Validation> Validate();

        #endregion
    }
}