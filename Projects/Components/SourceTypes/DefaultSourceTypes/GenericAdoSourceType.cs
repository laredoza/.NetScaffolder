using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes
{
    using DatabaseSchemaReader;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    public class GenericAdoSourceType : ISourceType
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

            AdoSourceOptions adoOptions = options as AdoSourceOptions;
            var dbReader = new DatabaseReader(adoOptions.ConnectionString, adoOptions.ProviderName);
            var schema = dbReader.ReadAll();

            //schema.Tables[0].CheckConstraints[0].RefersToConstraint

            Table newTable = new Table();
            Column newColumn = new Column();

            foreach (var table in schema.Tables.Where(t => t.Name != "sysdiagrams"))
            {
                //Debug.WriteLine("Table " + table.Name);

                newTable = new Table { TableName = table.Name };
                result.Tables.Add(newTable);

                foreach (var column in table.Columns)
                {
                    newColumn = new Column
                                    {
                        ColumnName = column.Name,
                        CSharpDataType = this.MapDatabaseTypeToCSharp(column.DataType.TypeName),
                        IsRequired = column.IsPrimaryKey,
                        ColumnOrder = table.Columns.IndexOf(column) + 1,
                        Precision = column.Precision.HasValue ? column.Precision.Value : 0,
                        Scale = column.Scale.HasValue ? column.Scale.Value : 0,
                        Length = column.Length.HasValue ? column.Length.Value : 0,
                        IsPrimaryKey = column.IsPrimaryKey
                    };

                    newTable.Columns.Add(newColumn);

                    //Debug.Write("\tColumn " + column.Name + "\t" + column.DataType.TypeName);
                    //if (column.DataType.IsString) Debug.Write("(" + column.Length + ")");
                    //if (column.IsPrimaryKey) Debug.Write("\tPrimary key");
                    //if (column.IsForeignKey) Debug.Write("\tForeign key to " + column.ForeignKeyTable.Name);
                    //Debug.WriteLine("");
                }
            }

            //result.Tables = edmx.Runtime.ConceptualModels.Schema.EntityTypes.Select(tbl => new Table()
            //{
            //    TableName = tbl.Name,
            //    Columns = tbl.Properties.Select(col => new Column()
            //    {
            //        ColumnName = col.Name,
            //        CSharpDataType = this.MapDatabaseTypeToCSharp(col.Type),
            //        IsRequired = col.Nullable,
            //        ColumnOrder = tbl.Properties.ToList().IndexOf(col) + 1,
            //        Precision = (col.Precision > 0 && col.Scale > 0) ? col.Precision : 0,
            //        Scale = (col.Precision > 0 && col.Scale > 0) ? col.Scale : 0,
            //        Length = (string.IsNullOrEmpty(col.MaxLength)) ? 0 : Convert.ToInt32(col.MaxLength),
            //        IsPrimaryKey = tbl.Key.Any(pk => pk.Name == col.Name),
            //    }).ToList(),
            //    RelationShips = edmx.Runtime.StorageModels.Schema.Associations.Where(ass => (ass.ReferentialConstraint.Dependent.Role == tbl.Name || ass.ReferentialConstraint.Principal.Role == tbl.Name) &&
            //        (entityTableNames.Contains(ass.ReferentialConstraint.Dependent.Role.ToUpper()) && entityTableNames.Contains(ass.ReferentialConstraint.Principal.Role.ToUpper()))).
            //        Select(rel => new Relationship()
            //        {
            //            TableName = (rel.ReferentialConstraint.Dependent.Role == tbl.Name) ? rel.ReferentialConstraint.Principal.Role : rel.ReferentialConstraint.Dependent.Role,
            //            ColumnName = (rel.ReferentialConstraint.Dependent.Role == tbl.Name) ? rel.ReferentialConstraint.Dependent.PropertyRef.Name : rel.ReferentialConstraint.Principal.PropertyRef.Name,
            //            ForeignColumnName = (rel.ReferentialConstraint.Principal.Role == tbl.Name) ? rel.ReferentialConstraint.Dependent.PropertyRef.Name : rel.ReferentialConstraint.Principal.PropertyRef.Name,
            //            RelationShip = (rel.ReferentialConstraint.Dependent.Role == tbl.Name) ? RelationshipType.Parent : RelationshipType.Child,
            //        }).ToList(),
            //}).ToList();

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
                case "SMALLINT":
                    return DomainDataType.Int16;
                case "INT":
                    return DomainDataType.Int32;
                case "INT32":
                    return DomainDataType.Int32;
                case "INT64":
                    return DomainDataType.Int64;
                case "BIT":
                    return DomainDataType.Boolean;
                case "BYTE":
                    return DomainDataType.Short;
                case "NVARCHAR":
                    return DomainDataType.String;
                case "MONEY":
                    return DomainDataType.Decimal;
                case "NUMERIC":
                    return DomainDataType.Decimal;
                case "DATETIME":
                    return DomainDataType.String;
                case "IMAGE":
                    // Todo: Do something valid with this
                    return DomainDataType.String;
                case "REAL":
                    // Todo: Do something valid with this
                    return DomainDataType.Single;
                default:
                    throw new NotImplementedException($"Invalid data type {databaseType}");
            }
        }

        #endregion
    }
}
