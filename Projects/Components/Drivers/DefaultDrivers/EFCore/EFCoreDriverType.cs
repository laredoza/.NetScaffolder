﻿// --------------------------------------------------------------------------------------------------------------------
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

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

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

        public string TransformModelName(string name, INamingConvention nc = null)
        {
            if (nc == null)
            {
                return name;
            }

            return nc.ApplyNamingConvention(name);
        }

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
                sb.Append(
                    $"modelBuilder.Entity<{this.TransformModelName(table, nc)}>().HasMany<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})");
            }
            else
            {
                sb.Append(
                    $"modelBuilder.Entity<{this.TransformModelName(table, nc)}>().HasOne<{this.TransformModelName(rel.ReferencedTableName, nc)}>(s => s.{refTableName})");
            }

            string parentTableName = table;

            if (relationships != null && relationships.Any())
            {
                var parentRels =
                    (from tbl in models
                     select tbl.Relationships.FirstOrDefault(
                         o => o.ReferencedTableName == table && o.SchemaName == rel.SchemaName
                                                             && o.ColumnName == rel.ReferencedColumnName))
                    .Where(x => x != null);

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
                sb.Append($".WithMany(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ColumnName}).OnDelete(DeleteBehavior.Restrict);");
            }
            else
            {
                if (rel.ReferencedMultiplicity == RelationshipMultiplicity.Many)
                {
                    sb.Append($".WithOne(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).OnDelete(DeleteBehavior.Restrict);");
                }
                else
                {
                    sb.Append($".WithOne(s => s.{parentTableName}).OnDelete(DeleteBehavior.Restrict);");
                }
            }

            return sb.ToString();
        }

        public string TransformDbGeneratedKey(Table table)
        {
            if (table.DatabaseGeneratedKeyType == DatabaseGeneratedKeyType.None || 
                table.DatabaseGeneratedKeyType == DatabaseGeneratedKeyType.Ignore)
            {
                return ".ValueGeneratedNever()";
            }
            else
            {
                return ".ValueGeneratedOnAdd()";
            }
        }

        #endregion
    }
}