// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxSourceType.cs" company="">
//   
// </copyright>
// <summary>
//   The edmx source type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    /// This datasource uses the default Microsoft edmx file to return the data structure.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "Edmx")]
    [ExportMetadata("ValueMetaData", "3BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class EdmxSourceType : ISourceType
    {
        #region Public methods and operators

        /// <summary>
        /// Import data structure.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="DatabaseModel"/>.
        /// </returns>
        public DatabaseModel Import(object options)
        {
            DatabaseModel result = new DatabaseModel();

            FileSourceOptions fileOption = options as FileSourceOptions;
            var edmx = TiraggoEdmx_v3.Edmx.Load(fileOption.Path);
            var entityTableNames = new HashSet<string>(edmx.Runtime.ConceptualModels.Schema.EntityTypes.Select(tbl => tbl.Name.ToUpper()));

            result.Tables = edmx.Runtime.ConceptualModels.Schema.EntityTypes.Select(tbl => new Table()
            {
                TableName = tbl.Name,
                Columns = tbl.Properties.Select(col => new Column()
                {
                    ColumnName = col.Name,
                    CSharpDataType = this.MapDatabaseTypeToCSharp(col.Type),
                    IsRequired = col.Nullable,
                    ColumnOrder = tbl.Properties.ToList().IndexOf(col) + 1,
                    Precision = (col.Precision > 0 && col.Scale > 0) ? col.Precision : 0,
                    Scale = (col.Precision > 0 && col.Scale > 0) ? col.Scale : 0,
                    Length = (string.IsNullOrEmpty(col.MaxLength)) ? 0 : Convert.ToInt32(col.MaxLength),
                    IsPrimaryKey = tbl.Key.Any(pk => pk.Name == col.Name),
                }).ToList(),
                RelationShips = edmx.Runtime.StorageModels.Schema.Associations.Where(ass => (ass.ReferentialConstraint.Dependent.Role == tbl.Name || ass.ReferentialConstraint.Principal.Role == tbl.Name) &&
                    (entityTableNames.Contains(ass.ReferentialConstraint.Dependent.Role.ToUpper()) && entityTableNames.Contains(ass.ReferentialConstraint.Principal.Role.ToUpper()))).
                    Select(rel => new Relationship()
                    {
                        TableName = (rel.ReferentialConstraint.Dependent.Role == tbl.Name) ? rel.ReferentialConstraint.Principal.Role : rel.ReferentialConstraint.Dependent.Role,
                        ColumnName = (rel.ReferentialConstraint.Dependent.Role == tbl.Name) ? rel.ReferentialConstraint.Dependent.PropertyRef.Name : rel.ReferentialConstraint.Principal.PropertyRef.Name,
                        ForeignColumnName = (rel.ReferentialConstraint.Principal.Role == tbl.Name) ? rel.ReferentialConstraint.Dependent.PropertyRef.Name : rel.ReferentialConstraint.Principal.PropertyRef.Name,
                        DependencyRelationShip = (rel.ReferentialConstraint.Dependent.Role == tbl.Name) ? RelationshipType.ForeignKey : RelationshipType.ForeignKeyChild,
                    }).ToList(),
                    }).ToList();

            return result;
        }

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        /// The database type.
        /// </param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        public DomainDataType MapDatabaseTypeToCSharp(string databaseType)
        {
            switch (databaseType.ToUpper())
            {
                case "INT16":
                    return DomainDataType.Int16;
                case "INT32":
                    return DomainDataType.Int32;
                case "INT64":
                    return DomainDataType.Int64;
                case "BOOLEAN":
                    return DomainDataType.Boolean;
                case "BYTE":
                    return DomainDataType.Short;
                case "STRING":
                    return DomainDataType.String;
                case "DECIMAL":
                    return DomainDataType.Decimal;
                case "DATETIME":
                    return DomainDataType.String;
                case "INT[]":
                    // Todo: Do something valid with this
                    return DomainDataType.String;
                case "SINGLE":
                    // Todo: Do something valid with this
                    return DomainDataType.Single;
                default:
                    throw new NotImplementedException($"Invalid data type {databaseType}");
            }
        }

        #endregion
    }
}