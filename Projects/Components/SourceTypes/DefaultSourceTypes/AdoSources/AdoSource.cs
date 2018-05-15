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
    /// The ado source.
    /// </summary>
    public abstract class AdoSource : ISourceType
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

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

            List<Relationship> RelationshipsToDelete = new List<Relationship>();

            foreach (Table modelTable in tables)
            {
                RelationshipsToDelete = new List<Relationship>();

                foreach (var relationship in modelTable.Relationships)
                {
                    relationship.Table = modelTable;
                    relationship.RelatedTable =
                        tables.FirstOrDefault(t => t.TableName == relationship.ReferencedTableName);
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
        public MultiplicityResult ReturnMultiplicity(DatabaseTable table, string columnName, DatabaseTable referencedTable, string referencedColumnName, RelationshipType relationshipType)
        {
            DatabaseColumn column = table.Columns.FirstOrDefault(c => c.Name == columnName);
            DatabaseColumn foreignColumn = referencedTable.Columns.FirstOrDefault(c => c.Name == referencedColumnName);

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

            if (!string.IsNullOrEmpty(adoOptions.Schema))
            {
                // Todo: Handle multiple Schema's
                databaseReader.Owner = adoOptions.Schema;
            }

            var schema = databaseReader.ReadAll();

            // schema.Tables[0].CheckConstraints[0].RefersToConstraint
            Table newTable;
            Column newColumn;

            foreach (var table in schema.Tables.Where(
                t => t.Name != "sysdiagrams" && t.Name != "__migrationhistory" && t.Name != "__MigrationHistory"))
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

                string referencedForeignColumnName = string.Empty;
                MultiplicityResult multiplicityResult;
                
                foreach (var foreignKey in table.ForeignKeys)
                {
                    referencedForeignColumnName = foreignKey.ReferencedColumns(schema).ToList()[0];
                    multiplicityResult = this.ReturnMultiplicity(
                        table,
                        foreignKey.Columns[0],
                        foreignKey.ReferencedTable(schema),
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

                foreach (var foreignKeyChildren in table.ForeignKeyChildren)
                {
                    foreach (var foreignKey in foreignKeyChildren.ForeignKeys)
                    {
                        if (foreignKey.RefersToTable == table.Name)
                        {
                            multiplicityResult = this.ReturnMultiplicity(
                                table,
                                foreignKey.ReferencedColumns(schema).ToList()[0],
                                table.ForeignKeyChildren.FirstOrDefault(t => t.Name == foreignKey.TableName),
                                foreignKey.Columns[0],
                                RelationshipType.ForeignKeyChild);

                            newTable.Relationships.Add(
                                new Relationship
                                    {
                                        ReferencedTableName = foreignKey.TableName,
                                        ColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
                                        ReferencedColumnName = foreignKey.Columns[0],
                                        DependencyRelationShip = RelationshipType.ForeignKeyChild,
                                        RelationshipName = foreignKey.Name,
                                        SchemaName = foreignKey.SchemaOwner,
                                        Multiplicity = multiplicityResult.Multiplicity,
                                        ReferencedMultiplicity = multiplicityResult.ReferencedMultiplicity
                                });
                        }
                    }

                    foreach (var rel in newTable.Relationships)
                    {
                        string alias = string.Empty;

                        if (rel.DependencyRelationShip == RelationshipType.ForeignKey)
                        {
                            alias = rel.ReferencedTableName + "Parent";
                        }
                        else
                        {
                            alias = rel.ReferencedTableName + "Children";
                        }

                        alias = RelationshipNameFormatting.FormatName(rel.ReferencedTableName, alias, "", null, newTable.Relationships, false);
                        if(!string.Equals(rel.ReferencedTableName, alias))
                        {
                            rel.RelationshipAlias = alias;
                        }
                    }
                }
            }

            this.Fix(result);
            Logger.Trace("Completed Import()");
            return result;
        }

        private string CreateChildAlias(string parentTable, string childTable)
        {
            if(string.Equals(parentTable, childTable))
            {
                return childTable + "Childrent";
            }
            return string.Empty;
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
    }
}