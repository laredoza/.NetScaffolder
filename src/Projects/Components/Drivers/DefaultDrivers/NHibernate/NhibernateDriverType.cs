// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NhibernateDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate
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
    public class NhibernateDriverType : IDriverType
    {
        #region Fields

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NhibernateDriverType"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public NhibernateDriverType(string fileName)
        {
            this.FileName = fileName;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NhibernateDriverType" /> class.
        /// </summary>
        public NhibernateDriverType()
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
        public Guid Id => new Guid("BB7460EE-5C1D-4E64-8515-C0DFD3752CB6");

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
        public string Name => "NHibernate";

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
            bool isClustered = index.IndexType == IndexType.Clustered;
            var idxs = new StringBuilder();

            if (index.IsUnique)
            {
                idxs.Append($".UniqueKey(\"{index.Name}\")");
            }
            else
            {
                idxs.Append($".Index(\"{index.Name}\")");
            }

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
                var loadedDriverType = ObjectXMLSerializer<NhibernateDriverType>.Load(filePath);
                if (loadedDriverType != null)
                {
                    this.CreateDb = loadedDriverType.CreateDb;
                    this.IncludeColumnOrder = loadedDriverType.IncludeColumnOrder;
                    this.LazyLoadingEnabled = loadedDriverType.LazyLoadingEnabled;
                    this.LoggingEnabled = loadedDriverType.LoggingEnabled;
                    this.ProxyCreationEnabled = loadedDriverType.ProxyCreationEnabled;
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
            ObjectXMLSerializer<NhibernateDriverType>.Save(this, filePath);
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
            if (!col.InValidPrecisionGeneration)
            {
                string precisionString = string.Empty;

                if (col.Precision > 0)
                {
                    precisionString = $".Precision({col.Precision})";
                }

                if (col.Scale > 0)
                {
                    precisionString = $"{precisionString}.Scale({col.Scale})";
                }

                return precisionString;
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string TransformDbGeneratedKey(Table table)
        {
            if (table.DatabaseGeneratedKeyType == DatabaseGeneratedKeyType.None
                || table.DatabaseGeneratedKeyType == DatabaseGeneratedKeyType.Ignore)
            {
                return ".GeneratedBy.Assigned()";
            }
            else
            {
                return ".GeneratedBy.Increment().Unique()";
            }
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

            if (rel.Multiplicity == RelationshipMultiplicity.Many)
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $"HasManyToMany(o => o.{refTableName});"
                        : $"References(o => o.{refTableName}).Column(\"{rel.ReferencedColumnName}\").Unique().Not.Insert().Not.Update();");
            }
            else if (rel.Multiplicity == RelationshipMultiplicity.One)
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $"HasMany(s => s.{refTableName}).KeyColumn(\"{rel.ReferencedColumnName}\");"
                        : $"HasOne(s => s.{refTableName}).PropertyRef(o => o.{parentTableName});");
            }
            else
            {
                sb.Append(
                    rel.ReferencedMultiplicity == RelationshipMultiplicity.Many
                        ? $"HasMany(s => s.{refTableName}).KeyColumn(\"{rel.ReferencedColumnName}\");"
                        : $"HasOne(s => s.{refTableName});");
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