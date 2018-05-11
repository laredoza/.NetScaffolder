using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    using System.IO;

    using DatabaseSchemaReader;
    using DatabaseSchemaReader.DataSchema;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using global::Common.Logging;

    public abstract class AdoSource : ISourceType
    {
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        public abstract object AddConfigUI(object parameters);

        public DatabaseModel Import(object options)
        {
            Logger.Trace("Started Import()");
            DatabaseModel result = new DatabaseModel();

            AdoSourceOptions adoOptions = options as AdoSourceOptions;
            var databaseReader = new DatabaseReader(adoOptions.ConnectionString, adoOptions.ProviderName);
            databaseReader.Owner = "Test";
            var schema = databaseReader.ReadAll();

            // schema.Tables[0].CheckConstraints[0].RefersToConstraint
            Table newTable;
            Column newColumn;

            foreach (var table in schema.Tables.Where(t => t.Name != "sysdiagrams" && t.Name != "__migrationhistory"))
            {
                // foreach (var table in schema.Tables.Where(t => t.Name == "BankAccount"))
                // Debug.WriteLine("Table " + table.Name);
                newTable = new Table { TableName = table.Name, SchemaName = table.SchemaOwner };
                result.Tables.Add(newTable);
                string dataType;

                foreach (var column in table.Columns)
                {
                    if (column.DataType != null)
                    {
                        dataType = column.DataType.TypeName;
                    }
                    else
                    {
                        dataType = string.Empty;
                    }

                    newColumn = new Column
                    {
                        ColumnName = column.Name,
                        DomainDataType =
                        this.MapDatabaseType(dataType, column),
                        IsRequired = !column.Nullable || column.IsPrimaryKey,
                        ColumnOrder = table.Columns.IndexOf(column) + 1,
                        Precision = column.Precision.HasValue ? column.Precision.Value : 0,
                        Scale = column.Scale.HasValue ? column.Scale.Value : 0,
                        Length = column.Length.HasValue ? column.Length.Value : 0,
                        IsPrimaryKey = column.IsPrimaryKey
                    };

                    if (column.IsPrimaryKey)
                    {
                        newTable.DatabaseGeneratedKeyType = this.MapDatabaseGeneratedKey(column);
                    }

                    newTable.Columns.Add(newColumn);
                }

                foreach (var foreignKey in table.ForeignKeys)
                {
                    newTable.Relationships.Add(
                        new Relationship
                        {
                            ReferencedTableName = foreignKey.RefersToTable,
                            ColumnName = foreignKey.Columns[0],
                            ReferencedColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
                            DependencyRelationShip = RelationshipType.ForeignKey,
                            RelationshipName = foreignKey.Name
                        });
                }

                foreach (var foreignKeyChildren in table.ForeignKeyChildren)
                {
                    foreach (var foreignKey in foreignKeyChildren.ForeignKeys)
                    {
                        if (foreignKey.RefersToTable == table.Name)
                        {
                            newTable.Relationships.Add(
                                new Relationship
                                {
                                    ReferencedTableName = foreignKey.TableName,
                                    ColumnName = foreignKey.Columns[0],
                                    ReferencedColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
                                    DependencyRelationShip = RelationshipType.ForeignKeyChild,
                                    RelationshipName = foreignKey.Name
                                });
                        }
                    }
                }
            }

            this.Fix(result);
            Logger.Trace("Completed Import()");
            return result;
        }

        /// <summary>
        /// The map database generated key.
        /// </summary>
        /// <param name="computedDefinition">
        /// The computed definition.
        /// </param>
        /// <returns>
        /// The <see cref="DatabaseGeneratedKeyType"/>.
        /// </returns>
        public DatabaseGeneratedKeyType MapDatabaseGeneratedKey(DatabaseColumn computedDefinition)
        {
            if (computedDefinition.IsAutoNumber)
            {
                return DatabaseGeneratedKeyType.Identity;
            }

            if (computedDefinition.IsComputed)
            {
                return DatabaseGeneratedKeyType.Computed;
            }

            return DatabaseGeneratedKeyType.None;
        }

        public abstract object Load(object parameters);
        
        public abstract DomainDataType MapDatabaseType(string databaseType, object extraInfo);
        
        public void Save(object parameters)
        {
            Logger.Trace("Started Save()");

            List<object> saveParameters = parameters as List<object>;
            string path = this.ReturnFilePath(saveParameters[0] as string);
            Logger.Debug($"Path: {path}");

            AdoSourceOptions options = saveParameters[1] as AdoSourceOptions;

            if (options == null)
            {
                options = new AdoSourceOptions();
            }

            ObjectXMLSerializer<AdoSourceOptions>.Save(options, path, SerializedFormat.Document);

            Logger.Trace("Completed Save()");
        }

        public abstract bool Test(object parameters);

        public void Fix(DatabaseModel model)
        {
            Logger.Trace("Started Fix()");

            this.Fix(model.Tables);

            Logger.Trace("Completed Fix()");
        }

        public void Fix(List<Table> tables)
        {
            Logger.Trace("Started Fix()");

            List<Relationship> RelationshipsToDelete = new List<Relationship>();

            foreach (Table modelTable in tables)
            {
                RelationshipsToDelete = new List<Relationship>();

                foreach (var relationship in modelTable.Relationships)
                {
                    relationship.Table = modelTable;
                    relationship.RelatedTable = tables.FirstOrDefault(t => t.TableName == relationship.ReferencedTableName);
                    if (relationship.RelatedTable == null)
                    {
                        RelationshipsToDelete.Add(relationship);
                    }
                    else
                    {
                        relationship.SchemaName = relationship.RelatedTable.SchemaName;
                    }
                }

                foreach (var relationship in RelationshipsToDelete)
                {
                    modelTable.Relationships.Remove(relationship);
                }
            }

            Logger.Trace("Completed Fix()");
        }

        public abstract string ReturnFilePath(string basePath);
    }
}
