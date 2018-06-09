// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdoSource.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DatabaseSchemaReader;
    using DatabaseSchemaReader.DataSchema;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Multiplicity;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using global::Common.Logging;

    #endregion

    /// <summary>
    ///     The ado source.
    /// </summary>
    public abstract class AdoSource : ISourceType
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdoSource" /> class.
        /// </summary>
        public AdoSource()
        {
            this.Schemas = new List<string>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the schemas.
        /// </summary>
        public List<string> Schemas { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The add config ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public abstract object AddConfigUI(object parameters);

        /// <summary>
        /// The fix.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        public void Fix(DatabaseModel model)
        {
            Logger.Trace("Started Fix()");

            this.Fix(model.Tables);

            Logger.Trace("Completed Fix()");
        }

        /// <summary>
        /// The fix.
        /// </summary>
        /// <param name="tables">
        /// The tables.
        /// </param>
        public void Fix(List<Table> tables)
        {
            Logger.Trace("Started Fix()");

            List<Relationship> relationshipsToDelete = new List<Relationship>();

            foreach (Table modelTable in tables)
            {
                relationshipsToDelete = new List<Relationship>();

                foreach (var relationship in modelTable.Relationships)
                {
                    relationship.Table = modelTable;
                    relationship.RelatedTable =
                        tables.FirstOrDefault(t => t.TableName == relationship.ReferencedTableName);
                    if (relationship.RelatedTable == null)
                    {
                        relationshipsToDelete.Add(relationship);
                    }
                    else
                    {
                        relationship.SchemaName = relationship.RelatedTable.SchemaName;
                    }
                }

                foreach (var relationship in relationshipsToDelete)
                {
                    modelTable.Relationships.Remove(relationship);
                }
            }

            Logger.Trace("Completed Fix()");
        }

        /// <summary>
        /// The import.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="DatabaseModel"/>.
        /// </returns>
        public DatabaseModel Import(object options)
        {
            Logger.Trace("Started Import()");
            DatabaseModel result = new DatabaseModel();

            AdoSourceOptions adoOptions = options as AdoSourceOptions;
            var databaseReader = new DatabaseReader(adoOptions.ConnectionString, adoOptions.ProviderName);

            databaseReader.AllTables();
            databaseReader.AllViews();

            // databaseReader.AllStoredProcedures(); //but not this one!
            // var schemaMetaData = databaseReader.ReadAll();
            var schemaMetaData = databaseReader.DatabaseSchema;

            List<DatabaseTable> tables = schemaMetaData.Tables.Where(
                    t => t.Name != "sysdiagrams" && t.Name != "__migrationhistory" && t.Name != "__MigrationHistory")
                .ToList();

            foreach (var table in tables)
            {
                if (adoOptions.Schemas.Any(s => s == table.SchemaOwner))
                {
                    DatabaseSchemaFixer.UpdateReferences(schemaMetaData);

                    var newTable = new Table { TableName = table.Name, SchemaName = table.SchemaOwner };
                    result.Tables.Add(newTable);

                    this.AddColumns(table, newTable);

                    this.AddforeignKeys(table, schemaMetaData, newTable);

                    this.AddforeignKeyChildren(table, schemaMetaData, newTable);

                    FormatNavigationPropertiesToBeUnique(newTable);

                    AddIndexes(table, newTable);
                }
            }

            this.Fix(result);
            Logger.Trace("Completed Import()");
            return result;
        }

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public abstract object Load(object parameters);

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

        /// <summary>
        /// The map database type.
        /// </summary>
        /// <param name="databaseType">
        /// The database type.
        /// </param>
        /// <param name="extraInfo">
        /// The extra info.
        /// </param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        public abstract DomainDataType MapDatabaseType(string databaseType, object extraInfo);

        /// <summary>
        /// The return file path.
        /// </summary>
        /// <param name="basePath">
        /// The base path.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public abstract string ReturnFilePath(string basePath);

        /// <summary>
        /// The return multiplicity.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="columnName">
        /// The column name.
        /// </param>
        /// <param name="referencedTable">
        /// The referenced table.
        /// </param>
        /// <param name="referencedColumnName">
        /// The referenced column name.
        /// </param>
        /// <param name="relationshipType">
        /// The relationship type.
        /// </param>
        /// <returns>
        /// The <see cref="MultiplicityResult"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public MultiplicityResult ReturnMultiplicity(
            DatabaseTable table,
            string columnName,
            DatabaseTable referencedTable,
            string referencedColumnName,
            RelationshipType relationshipType)
        {
            DatabaseColumn column = table.Columns.FirstOrDefault(c => c.Name.ToLower() == columnName.ToLower());
            DatabaseColumn foreignColumn =
                referencedTable.Columns.FirstOrDefault(c => c.Name.ToLower() == referencedColumnName.ToLower());

            return MultiplicityCalculator.Calculate(
                relationshipType,
                column.IsPrimaryKey,
                foreignColumn.IsPrimaryKey,
                column.IsForeignKey,
                column.Nullable,
                foreignColumn.Nullable,
                foreignColumn.IsForeignKey);
        }

        /// <summary>
        /// The return schemas.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<string> ReturnSchemas(object options)
        {
            this.Schemas.Clear();
            AdoSourceOptions adoOptions = options as AdoSourceOptions;
            var databaseReader = new DatabaseReader(adoOptions.ConnectionString, adoOptions.ProviderName);

            this.Schemas.Clear();
            IList<DatabaseTable> tables = databaseReader.TableList();

            foreach (var table in tables)
            {
                if (!this.Schemas.Any(s => s == table.SchemaOwner))
                {
                    this.Schemas.Add(table.SchemaOwner);
                }
            }

            this.Schemas = this.Schemas.OrderBy(s => s).ToList();

            return this.Schemas;
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
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

        /// <summary>
        /// The test.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public abstract bool Test(object parameters);

        #endregion

        #region Other Methods

        /// <summary>
        /// The add indexes.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="newTable">
        /// The new table.
        /// </param>
        private static void AddIndexes(DatabaseTable table, Table newTable)
        {
            foreach (DatabaseIndex index in table.Indexes)
            {
                Index newIndex = new Index
                                     {
                                         IndexType = index.IndexType,
                                         IsUnique = index.IsUnique,
                                         Name = index.Name
                                     };

                foreach (DatabaseColumn column in index.Columns)
                {
                    newIndex.Columns.Add(
                        newTable.Columns.FirstOrDefault(c => c.ColumnName.ToLower() == column.Name.ToLower())
                            .ColumnName);
                }

                newTable.Indexes.Add(newIndex);
            }
        }

        /// <summary>
        /// The format navigation properties to be unique.
        /// </summary>
        /// <param name="newTable">
        /// The new table.
        /// </param>
        private static void FormatNavigationPropertiesToBeUnique(Table newTable)
        {
            // Format navigation property names to be unique and not equal to main table
            foreach (var rel in newTable.Relationships.OrderBy(o => o.ColumnName).ThenBy(o => o.ReferencedColumnName))
            {
                var test = (from relItem in newTable.Relationships
                            orderby rel.ReferencedColumnName
                            select string.IsNullOrEmpty(relItem.RelationshipAlias)
                                       ? relItem.ReferencedTableName
                                       : relItem.RelationshipAlias).ToList();

                test.AddRange(newTable.Columns.Select(o => o.ColumnName));
                test.Add(newTable.TableName); // Add table name as properties cannot have same name as main table

                string alias = RelationshipNameFormatting.FormatName(
                    rel.ReferencedTableName,
                    rel.RelationshipAlias,
                    null,
                    test);

                if (!string.Equals(rel.ReferencedTableName, alias))
                {
                    rel.RelationshipAlias = alias;
                }
            }
        }

        /// <summary>
        /// The add columns.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="newTable">
        /// The new table.
        /// </param>
        private void AddColumns(DatabaseTable table, Table newTable)
        {
            foreach (var column in table.Columns)
            {
                string dataType;
                if (column.DataType != null)
                {
                    dataType = column.DataType.TypeName;
                }
                else
                {
                    dataType = string.Empty;
                }

                Column newColumn = new Column
                                       {
                                           ColumnName = column.Name,
                                           DomainDataType = this.MapDatabaseType(dataType, column),
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
        }

        /// <summary>
        /// The addforeign key children.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="schemaMetaData">
        /// The schema meta data.
        /// </param>
        /// <param name="newTable">
        /// The new table.
        /// </param>
        private void AddforeignKeyChildren(DatabaseTable table, DatabaseSchema schemaMetaData, Table newTable)
        {
            foreach (var foreignKeyChildren in table.ForeignKeyChildren)
            {
                foreach (var foreignKey in foreignKeyChildren.ForeignKeys)
                {
                    var referencedForeignColumn = foreignKey.ReferencedColumns(schemaMetaData).ToList();
                    if (foreignKey.RefersToTable == table.Name && referencedForeignColumn.Count > 0)
                    {
                        var referencedForeignColumnString = referencedForeignColumn[0];

                        var multiplicityResult = this.ReturnMultiplicity(
                            table,
                            referencedForeignColumnString,
                            table.ForeignKeyChildren.FirstOrDefault(t => t.Name == foreignKey.TableName),
                            foreignKey.Columns[0],
                            RelationshipType.ForeignKeyChild);

                        newTable.Relationships.Add(
                            new Relationship
                                {
                                    ReferencedTableName = foreignKey.TableName,
                                    ColumnName = referencedForeignColumnString,
                                    ReferencedColumnName = foreignKey.Columns[0],
                                    DependencyRelationShip = RelationshipType.ForeignKeyChild,
                                    RelationshipName = foreignKey.Name,
                                    SchemaName = foreignKey.SchemaOwner,
                                    Multiplicity = multiplicityResult.Multiplicity,
                                    ReferencedMultiplicity = multiplicityResult.ReferencedMultiplicity
                                });
                    }
                }
            }
        }

        /// <summary>
        /// The addforeign keys.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="schemaMetaData">
        /// The schema meta data.
        /// </param>
        /// <param name="newTable">
        /// The new table.
        /// </param>
        private void AddforeignKeys(DatabaseTable table, DatabaseSchema schemaMetaData, Table newTable)
        {
            foreach (var foreignKey in table.ForeignKeys)
            {
                var referencedForeignColumn = foreignKey.ReferencedColumns(schemaMetaData);

                if (referencedForeignColumn != null)
                {
                    var referencedForeignColumnName = referencedForeignColumn.ToList()[0];

                    var multiplicityResult = this.ReturnMultiplicity(
                        table,
                        foreignKey.Columns[0],
                        foreignKey.ReferencedTable(schemaMetaData),
                        referencedForeignColumnName,
                        RelationshipType.ForeignKey);

                    newTable.Relationships.Add(
                        new Relationship
                            {
                                ReferencedTableName = foreignKey.RefersToTable,
                                ColumnName = foreignKey.Columns[0],
                                ReferencedColumnName = referencedForeignColumnName,
                                DependencyRelationShip = RelationshipType.ForeignKey,
                                RelationshipName = foreignKey.Name,
                                SchemaName = foreignKey.SchemaOwner,
                                Multiplicity = multiplicityResult.Multiplicity,
                                ReferencedMultiplicity = multiplicityResult.ReferencedMultiplicity
                            });
                }
            }
        }

        /// <summary>
        /// The create child alias.
        /// </summary>
        /// <param name="parentTable">
        /// The parent table.
        /// </param>
        /// <param name="childTable">
        /// The child table.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string CreateChildAlias(string parentTable, string childTable)
        {
            if (string.Equals(parentTable, childTable))
            {
                return childTable + "Childrent";
            }

            return string.Empty;
        }

        /// <summary>
        /// The import.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        /// <param name="schemas">
        /// The schemas.
        /// </param>
        /// <param name="databaseReader">
        /// The database reader.
        /// </param>
        private void Import(object options, DatabaseModel result, List<string> schemas, DatabaseReader databaseReader)
        {
            AdoSourceOptions adoOptions = options as AdoSourceOptions;
        }

        #endregion
    }
}