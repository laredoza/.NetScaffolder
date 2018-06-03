// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.MetaData;
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
            this.LanguageOutputDetails = new List<LanguageOutputDetails>(); 
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the additional namespaces.
        /// </summary>
        public List<string> AdditionalNamespaces { get; set; } = new List<string>();

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
        ///     Gets or sets the domain definition.
        /// </summary>
        [XmlIgnore]
        public DomainDefinition DomainDefinition { get; set; }

        /// <summary>
        ///     Gets or sets the driver types.
        /// </summary>
        [XmlIgnore]
        public List<IDriver> Drivers { get; set; }

        /// <summary>
        ///     Gets or sets the meta data.
        /// </summary>
        public Table MetaData { get; set; }

        /// <summary>
        ///     Gets or sets the naming convention.
        /// </summary>
        [XmlIgnore]
        public INamingConvention NamingConvention { get; set; }

        public List<LanguageOutputDetails> LanguageOutputDetails { get; set; } 

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

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

        /// <summary>
        /// The transform as parameter.
        /// </summary>
        /// <param name="columns">
        /// The columns.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformAsParameter(IEnumerable<Column> columns)
        {
            string pk = string.Empty;

            foreach (var col in columns)
            {
                pk = $"{pk} {this.TransformAsParameter(col)}, ";
            }

            return pk.TrimEnd(' ').TrimEnd(',');
        }

        /// <summary>
        /// The transform as parameter.
        /// </summary>
        /// <param name="col">
        /// The col.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformAsParameter(Column col)
        {
            return $"{CSharpOutputMapper.MapToOutput(col)} {this.TransformParameterName(col.ColumnName)}";
        }

        /// <summary>
        /// The transform as query.
        /// </summary>
        /// <param name="col">
        /// The col.
        /// </param>
        /// <param name="entityName">
        /// The entity name.
        /// </param>
        /// <param name="caseSensitive">
        /// The case sensitive.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformAsQuery(Column col, string entityName = "", bool caseSensitive = false)
        {
            if (col.DomainDataType != DomainDataType.String)
            {
                if (!string.IsNullOrEmpty(entityName))
                {
                    return $"o.{col.ColumnName} == {entityName}.{col.ColumnName}";
                }

                return $"o.{col.ColumnName} == {this.TransformParameterName(col.ColumnName)}";
            }

            string searchCase = !caseSensitive ? ".ToLower()" : string.Empty;

            if (!string.IsNullOrEmpty(entityName))
            {
                return $"o.{col.ColumnName}{searchCase}.Contains({entityName}.{col.ColumnName}{searchCase})";
            }

            return
                $"o.{col.ColumnName}{searchCase}.Contains({this.TransformParameterName(col.ColumnName)}{searchCase})";
        }

        /// <summary>
        /// The transform as query.
        /// </summary>
        /// <param name="columns">
        /// The columns.
        /// </param>
        /// <param name="entityName">
        /// The entity name.
        /// </param>
        /// <param name="caseSensitive">
        /// The case sensitive.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformAsQuery(IEnumerable<Column> columns, string entityName = "", bool caseSensitive = false)
        {
            string query = string.Empty;

            foreach (var col in columns)
            {
                query = $"{query} {this.TransformAsQuery(col, entityName, caseSensitive)} && ";
            }

            return $"{query.TrimEnd(' ').TrimEnd('&')}";
        }

        /// <summary>
        /// The transform parameter name.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformParameterName(string name)
        {
            string formattedName =
                this.NamingConvention != null ? this.NamingConvention.ApplyNamingConvention(name) : name;
            return char.ToLowerInvariant(formattedName[0]) + formattedName.Substring(1);
        }

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