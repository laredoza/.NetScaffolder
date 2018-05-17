// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base
{
    using System;
    #region Usings

    using System.Collections.Generic;
    using System.Xml.Serialization;
    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The base data type.
    /// </summary>
    public abstract class BaseDataType : IDataType
    {
        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDataType"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        protected BaseDataType(string fileName) => this.FileName = fileName;

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

        public string TransformAsParameter(IEnumerable<Column> columns)
        {
            string pk = string.Empty;

            foreach (var col in columns)
            {
                pk = $"{pk} {TransformAsParameter(col)}, ";
            }

            return pk.TrimEnd(' ').TrimEnd(',');
        }

        public string TransformAsParameter(Column col)
        {
            return $"{CSharpOutputMapper.MapToOutput(col)} {TransformParameterName(col.ColumnName)}";
        }

        public string TransformAsQuery(Column col, string entityName = "", bool caseSensitive = false)
        {
            if (col.DomainDataType != DomainDataType.String)
            {
                if (!string.IsNullOrEmpty(entityName))
                {
                    return $"o.{col.ColumnName} == {entityName}.{col.ColumnName}";
                }
                return $"o.{col.ColumnName} == {TransformParameterName(col.ColumnName)}";
            }
            else
            {
                string searchCase = !caseSensitive ? ".ToLower()" : "";

                if (!string.IsNullOrEmpty(entityName))
                {
                    return $"o.{col.ColumnName}{searchCase}.Contains({entityName}.{col.ColumnName}{searchCase})";
                }

                return $"o.{col.ColumnName}{searchCase}.Contains({TransformParameterName(col.ColumnName)}{searchCase})";
            }
        }

        public string TransformAsQuery(IEnumerable<Column> columns, string entityName = "", bool caseSensitive = false)
        {
            string query = string.Empty;

            foreach (var col in columns)
            {
                query = $"{query} {TransformAsQuery(col, entityName, caseSensitive)} && ";
            }

            return $"{query.TrimEnd(' ').TrimEnd('&')}";
        }

        public string TransformParameterName(string name)
        {
            string formattedName = NamingConvention != null ? NamingConvention.ApplyNamingConvention(name) : name;
            return Char.ToLowerInvariant(formattedName[0]) + formattedName.Substring(1);
        }
    }
}