// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore
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
    ///     The ef core driver type.
    /// </summary>
    [Export(typeof(IDriverType))]
    public class EFCoreDriverType : IDriverType
    {
        #region Fields

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EFCoreDriverType"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public EFCoreDriverType(string fileName)
        {
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EFCoreDriverType"/> class.
        /// </summary>
        public EFCoreDriverType()
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
        public Guid Id => new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4411");

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
        public string Name => "Entity Framework Core";

        /// <summary>
        ///     Gets or sets a value indicating whether proxy creation enabled.
        /// </summary>
        public bool ProxyCreationEnabled { get; set; }

        public bool UseAlias { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether use seperate config classes.
        /// </summary>
        public bool UseSeperateConfigClasses { get; set; }

        public bool EnableCache { get; set; }
        public Guid Cache { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
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
        public static string TransformIndex(Index index, INamingConvention nc = null)
        {
            var idxs = new StringBuilder("HasIndex(i => new {");
            bool isClustered = index.IndexType == IndexType.Clustered;

            if (index.Columns != null && index.Columns.Any())
            {
                for (int i = 0; i < index.Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        idxs.Append(", ");
                    }

                    string colName = nc != null ? nc.ApplyNamingConvention(index.Columns[i]) : index.Columns[i];

                    idxs.Append($"i.{colName}");
                }
            }

            idxs.Append("})");
            idxs.Append($".HasName(\"{index.Name}\").IsUnique({index.IsUnique.ToString().ToLower()})");

            return idxs.ToString();
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
                var loadedDriverType = ObjectXMLSerializer<EFCoreDriverType>.Load(filePath);
                if (loadedDriverType != null)
                {
                    this.CreateDb = loadedDriverType.CreateDb;
                    this.IncludeColumnOrder = loadedDriverType.IncludeColumnOrder;
                    this.LazyLoadingEnabled = loadedDriverType.LazyLoadingEnabled;
                    this.LoggingEnabled = loadedDriverType.LoggingEnabled;
                    this.ProxyCreationEnabled = loadedDriverType.ProxyCreationEnabled;
                    this.UseSeperateConfigClasses = loadedDriverType.UseSeperateConfigClasses;
                    this.UseAlias = loadedDriverType.UseAlias;
                    this.Cache = loadedDriverType.Cache;
                    this.EnableCache = loadedDriverType.EnableCache;
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
            ObjectXMLSerializer<EFCoreDriverType>.Save(this, filePath);
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string TransformColumnPrecision(Column col, IDriver driver = null)
        {
            if (!col.InValidPrecisionGeneration && (col.Precision > 0 || col.Scale > 0))
            {
                return $".HasColumnType(\"{CSharpOutputMapper.MapToConstraint(col)}\")";
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
            if (table.DatabaseGeneratedKeyType == DatabaseGeneratedKeyType.None
                || table.DatabaseGeneratedKeyType == DatabaseGeneratedKeyType.Ignore)
            {
                return ".ValueGeneratedNever()";
            }
            else
            {
                return ".ValueGeneratedOnAdd()";
            }
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

            string parentTableName = nc != null ? nc.ApplyNamingConvention(table) : table;

            if (relationships != null && relationships.Any())
            {
                var parentRels = (from tbl in models
                                  select tbl.Relationships.FirstOrDefault(
                                      o => o.ReferencedTableName == table && o.Table.TableName == rel.ReferencedTableName && o.SchemaName == rel.SchemaName && o.ColumnName == rel.ReferencedColumnName
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

            sb.Append(
                rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                    ? $"builder.HasMany<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})"
                    : $"builder.HasOne<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})");

            if (rel.Multiplicity == RelationshipMultiplicity.Many)
            {
                sb.Append(
                    $".WithMany(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ColumnName}).OnDelete(DeleteBehavior.Restrict);");
            }
            else if (rel.Multiplicity == RelationshipMultiplicity.One)
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $".WithOne(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).OnDelete(DeleteBehavior.Restrict);"
                        : $".WithOne(s => s.{parentTableName}).HasForeignKey<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{rel.ReferencedColumnName}).OnDelete(DeleteBehavior.Restrict);");
            }
            else
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $".WithOne(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).OnDelete(DeleteBehavior.Restrict);"
                        : $".WithOne(s => s.{parentTableName}).OnDelete(DeleteBehavior.Restrict);");
            }

            return sb.ToString();
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public List<Validation> Validate()
        {
            return this.ValidationResult;
        }

        #endregion
    }
}