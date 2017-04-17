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
            //foreach (var table in schema.Tables.Where(t => t.Name == "Product"))
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
                }


                foreach (var foreignKey in table.ForeignKeys)
                {
                    newTable.RelationShips.Add(new Relationship
                    {
                        TableName = foreignKey.RefersToTable,
                        ColumnName = foreignKey.Columns[0],
                        ForeignColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
                        RelationShip = RelationshipType.ForeignKey
                    });
                }

                foreach (var foreignKeyChildren in table.ForeignKeyChildren)
                {
                    foreach (var foreignKey in foreignKeyChildren.ForeignKeys)
                    {
                        if (foreignKey.RefersToTable == table.Name)
                        {
                            newTable.RelationShips.Add(
                                new Relationship
                                {
                                    TableName = foreignKey.TableName,
                                    ColumnName = foreignKey.Columns[0],
                                    ForeignColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
                                    RelationShip = RelationshipType.ForeignKeyChild
                                });
                        }
                    }
                }
            }

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
