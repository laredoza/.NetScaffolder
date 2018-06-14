// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The ef driver type.
    /// </summary>
    [Export(typeof(IDriverType))]
    public class EFDriverType : IDriverType
    {
        #region Fields

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EFDriverType"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public EFDriverType(string fileName)
        {
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EFDriverType"/> class.
        /// </summary>
        public EFDriverType()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether create db.
        /// </summary>
        public bool CreateDb { get; set; }

        /// <summary>
        ///     The id.
        /// </summary>
        public Guid Id => new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4410");

        /// <summary>
        ///     Gets or sets a value indicating whether include column order.
        /// </summary>
        public bool IncludeColumnOrder { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether lazy loading enabled.
        /// </summary>
        public bool LazyLoadingEnabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether logging enabled.
        /// </summary>
        public bool LoggingEnabled { get; set; }

        /// <summary>
        ///     The name.
        /// </summary>
        public string Name => "Entity Framework 6";

        /// <summary>
        ///     Gets or sets a value indicating whether proxy creation enabled.
        /// </summary>
        public bool ProxyCreationEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether use seperate config classes.
        /// </summary>
        public bool UseSeperateConfigClasses { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The transform index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string TransformIndex(Index index)
        {
            var idxs = new StringBuilder(".HasColumnAnnotation(\"" + index.Name + "\", new IndexAnnotation(new [] { ");
            bool isClustered = index.IndexType == IndexType.Clustered;

            if (index.Columns != null && index.Columns.Any())
            {
                for (int i = 0; i < index.Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        idxs.Append(", ");
                    }

                    idxs.Append(
                        "new IndexAttribute(\"" + index.Name + "\"){ IsClustered = " + isClustered.ToString().ToLower()
                        + ", IsUnique = " + index.IsUnique.ToString().ToLower() + ", Order = " + i + "}");
                }
            }

            return idxs.Append("}))").ToString();
        }

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void LoadConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;

            var filePath = Path.Combine(parameterList["basePath"], this.FileName);

            if (File.Exists(filePath))
            {
                var loadedDriverType = ObjectXMLSerializer<EFDriverType>.Load(filePath);
                if (loadedDriverType != null)
                {
                    this.CreateDb = loadedDriverType.CreateDb;
                    this.IncludeColumnOrder = loadedDriverType.IncludeColumnOrder;
                    this.LazyLoadingEnabled = loadedDriverType.LazyLoadingEnabled;
                    this.LoggingEnabled = loadedDriverType.LoggingEnabled;
                    this.ProxyCreationEnabled = loadedDriverType.ProxyCreationEnabled;
                    this.UseSeperateConfigClasses = loadedDriverType.UseSeperateConfigClasses;
                }
            }
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool SaveConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;
            var filePath = Path.Combine(parameterList["basePath"], this.FileName);
            ObjectXMLSerializer<EFDriverType>.Save(this, filePath);
            return true;
        }

        /// <summary>
        /// The transform column precision.
        /// </summary>
        /// <param name="col">
        /// The col.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformColumnPrecision(Column col)
        {
            if (!col.InValidPrecisionGeneration && (col.Precision > 0 || col.Scale > 0))
            {
                return $".HasPrecision({col.Precision}, {col.Scale})";
            }

            return string.Empty;
        }

        /// <summary>
        /// The transform db generated key.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformDbGeneratedKey(Table table)
        {
            return $".HasDatabaseGeneratedOption({table.TransformDatabaseGeneratedKeyType})";
        }

        /// <summary>
        /// The transform model name.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="nc">
        /// The nc.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformModelName(string name, INamingConvention nc = null)
        {
            if (nc == null)
            {
                return name;
            }

            return nc.ApplyNamingConvention(name);
        }

        /// <summary>
        /// The transform relationship.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="rel">
        /// The rel.
        /// </param>
        /// <param name="models">
        /// The models.
        /// </param>
        /// <param name="relationships">
        /// The relationships.
        /// </param>
        /// <param name="nc">
        /// The nc.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformRelationship(
            string table,
            Relationship rel,
            IEnumerable<Table> models,
            IEnumerable<Relationship> relationships = null,
            INamingConvention nc = null)
        {
            var sb = new StringBuilder();

            string refTableName = RelationshipNameFormatting.FormatName(
                rel.ReferencedTableName,
                rel.RelationshipAlias,
                nc);

            if (rel.ReferencedMultiplicity == RelationshipMultiplicity.Many)
            {
                sb.Append($"HasMany<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})");
            }
            else if (rel.ReferencedMultiplicity == RelationshipMultiplicity.One)
            {
                sb.Append(
                    $"HasRequired<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})");
            }
            else
            {
                sb.Append(
                    $"HasOptional<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})");
            }

            string parentTableName = table;

            if (relationships != null && relationships.Any())
            {
                var parentRels =
                    (from tbl in models
                     select tbl.Relationships.FirstOrDefault(
                         o => o.ReferencedTableName == table && o.SchemaName == rel.SchemaName
                                                             && o.ColumnName == rel.ReferencedColumnName
                                                             && o.ReferencedColumnName == rel.ColumnName)).Where(x => x != null);

                var parentRel = parentRels.FirstOrDefault();

                if (parentRel != null)
                {
                    parentTableName = RelationshipNameFormatting.FormatName(
                        parentRel.ReferencedTableName,
                        parentRel.RelationshipAlias,
                        nc);
                }
            }

            if (rel.Multiplicity == RelationshipMultiplicity.Many)
            {
                sb.Append(
                    $".WithMany(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ColumnName}).WillCascadeOnDelete(false);");
            }
            else if (rel.Multiplicity == RelationshipMultiplicity.One)
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $".WithRequired(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).WillCascadeOnDelete(false);"
                        : $".WithRequired(s => s.{parentTableName}).WillCascadeOnDelete(false);");
            }
            else
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $".WithOptional(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).WillCascadeOnDelete(false);"
                        : $".WithOptional(s => s.{parentTableName}).WillCascadeOnDelete(false);");
            }

            return sb.ToString();
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Validation> Validate()
        {
            return this.ValidationResult;
        }

        #endregion
    }
}