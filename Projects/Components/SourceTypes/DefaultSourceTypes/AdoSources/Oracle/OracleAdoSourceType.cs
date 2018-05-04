// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericAdoSourceType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.Oracle
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    //using System.Data.OracleClient
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using DatabaseSchemaReader;
    using DatabaseSchemaReader.DataSchema;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using global::Common.Logging;

    using global::Oracle.ManagedDataAccess.Client;

    #endregion

    /// <summary>
    ///     The generic ado source type.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "Oracle ADO.NET")]
    [ExportMetadata("ValueMetaData", "4BC1B0C4-1E41-9146-82CF-699181CE4410")]
    public class OracleAdoSourceType : ISourceType
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
        public object AddConfigUI(object parameters)
        {
            Logger.Trace("Started AddConfigUI()");

            Control parent = parameters as Control;
            OracleAdoUserControl newControl = new OracleAdoUserControl { Visible = true, Dock = DockStyle.Fill };
            newControl.BringToFront();
            parent.Controls.Add(newControl);

            Logger.Trace("Completed AddConfigUI()");
            return newControl;
        }

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
                    relationship.RelatedTable = tables.FirstOrDefault(t => t.TableName == relationship.TableName);
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
            Logger.Trace("Started Import()");
            DatabaseModel result = new DatabaseModel();

            AdoSourceOptions adoOptions = options as AdoSourceOptions;
            var databaseReader = new DatabaseReader(adoOptions.ConnectionString, adoOptions.ProviderName);
            var schema = databaseReader.ReadAll();

            // schema.Tables[0].CheckConstraints[0].RefersToConstraint
            Table newTable;
            Column newColumn;

            foreach (var table in schema.Tables.Where(t => t.Name != "sysdiagrams"))
            {
                // foreach (var table in schema.Tables.Where(t => t.Name == "BankAccount"))
                // Debug.WriteLine("Table " + table.Name);
                newTable = new Table { TableName = table.Name, SchemaName = table.SchemaOwner };
                result.Tables.Add(newTable);

                foreach (var column in table.Columns)
                {
                    newColumn = new Column
                    {
                        ColumnName = column.Name,
                        DomainDataType = this.MapDatabaseType(column.DataType.TypeName, column),
                        IsRequired = column.IsPrimaryKey,
                        ColumnOrder = table.Columns.IndexOf(column) + 1,
                        Precision = column.Precision.HasValue ? column.Precision.Value : 0,
                        Scale = column.Scale.HasValue ? column.Scale.Value : 0,
                        Length = column.Length.HasValue ? column.Length.Value : 0,
                        IsPrimaryKey = column.IsPrimaryKey
                    };

                    if(column.IsPrimaryKey)
                    {
                        newTable.DatabaseGeneratedKeyType = MapDatabaseGeneratedKey(column.ComputedDefinition);
                    }

                    newTable.Columns.Add(newColumn);
                }

                foreach (var foreignKey in table.ForeignKeys)
                {
                    newTable.Relationships.Add(
                        new Relationship
                        {
                            TableName = foreignKey.RefersToTable,
                            ColumnName = foreignKey.Columns[0],
                            ForeignColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
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
                                    TableName = foreignKey.TableName,
                                    ColumnName = foreignKey.ReferencedColumns(schema).ToList()[0],
                                    ForeignColumnName = foreignKey.Columns[0],
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

        public DatabaseGeneratedKeyType MapDatabaseGeneratedKey(string computedDefinition)
        {
            if (string.IsNullOrEmpty(computedDefinition))
            {
                return DatabaseGeneratedKeyType.None;
            }

            if (computedDefinition.Equals("Identity", StringComparison.InvariantCultureIgnoreCase))
            {
                return DatabaseGeneratedKeyType.Identity;
            }
            if (computedDefinition.Equals("Computed", StringComparison.InvariantCultureIgnoreCase))
            {
                return DatabaseGeneratedKeyType.Computed;
            }

            return DatabaseGeneratedKeyType.None;
        }

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Load(object parameters)
        {
            Logger.Trace("Started Import()");

            string path = this.ReturnFilePath(parameters as string);
            Logger.Debug($"Path: {path}");
            AdoSourceOptions result = null;

            if (File.Exists(path))
            {
                Logger.Trace("Path Exists");
                result = ObjectXMLSerializer<AdoSourceOptions>.Load(path);
            }
            else
            {
                Logger.Trace("Path Doesn't Exist");
                result = new AdoSourceOptions
                {
                    ProviderName = "Oracle.ManagedDataAccess.Client",
                    ConnectionString = @"DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID=test;PASSWORD=Test"
                };
            }

            Logger.Trace("Completed Import()");

            return result;
        }

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        ///     The database type.
        /// </param>
        /// <param name="extraInfo"></param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        public DomainDataType MapDatabaseType(string databaseType, object extraInfo)
        {
            DatabaseColumn  column = extraInfo as DatabaseColumn;
            // Temp workaround for issues with getting dataTypes for Oracle
            Type cSharpName = NetDataType(column);

            switch (cSharpName.Name.ToUpper())
            {
                case "DECIMAL":
                    return DomainDataType.Decimal;
                case "STRING":
                    return DomainDataType.String;
                case "DATETIME":
                    return DomainDataType.DateTime;
                case "SYSTEM.BYTE[]":
                    return DomainDataType.VarBinary;
                case "INT16":
                    return DomainDataType.Int32;
                case "INT32":
                    return DomainDataType.Int32;
                case "BYTE[]":
                    return DomainDataType.VarBinary;
                case "INT64":
                    return DomainDataType.Int64;
                default:
                    throw new NotImplementedException($"Invalid data type {databaseType}");
            }
        }

        /// <summary>
        /// Returns the .NET type of the column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <returns>The .NET type of the column</returns>
        /// <remarks>
        /// For numeric Db data types uses column.Precision and column.Scale to determine the correct .NET data type.
        /// </remarks>
        public static Type NetDataType(DatabaseColumn column)
        {
            if (column == null) return null;
            if (column.DataType == null) return null;

            if (!column.DataType.IsNumeric || column.DataType.IsInt) return column.DataType.GetNetType();
            var precision = column.Precision.GetValueOrDefault();
            var scale = column.Scale.GetValueOrDefault();
            return NetTypeForIntegers(column, scale, precision);
        }

        private static Type NetTypeForIntegers(DatabaseColumn column, int scale, int precision)
        {
            if (scale != 0 || precision >= 19) return column.DataType.GetNetType();

            //could be a short, int or long...
            //VARCHAR2(10) is common for Oracle integers, but it can overflow an int
            //int.MaxValue is 2147483647 so +1 is allowable in the database
            if (precision > 10) //up to long.MaxValue
            {
                return typeof(long);
            }
            if (precision > 4) //2147483647
            {
                return typeof(int);
            }
            if (precision > 1)
            {
                return typeof(short);
            }
            return column.DataType.GetNetType();
        }

        /// <summary>
        /// The map domain data type to output type.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string MapDomainDataTypeToOutputType(DomainDataType type)
        {
            Logger.Trace("Started MapDomainDataTypeToOutputType()");

            switch (type)
            {
                case DomainDataType.Int16:
                    return "short";
                case DomainDataType.Int32:
                    return "int";
                case DomainDataType.Int64:
                    return "long";
                case DomainDataType.Boolean:
                    return "bool";
                case DomainDataType.Short:
                    return "byte";
                case DomainDataType.String:
                    return "string";
                case DomainDataType.Decimal:
                    return "decimal";
                case DomainDataType.DateTime:
                    return "DateTime";
                case DomainDataType.Single:
                    return "float";
                case DomainDataType.Guid:
                    return "Guid";
                case DomainDataType.VarBinary:
                    return "byte[]";
                case DomainDataType.Date:
                    return "DateTime";
                case DomainDataType.Time:
                    return "DateTime";
                default:
                    throw new NotImplementedException($"Invalid data type {type}");
            }
        }

        /// <summary>
        /// The return file path.
        /// </summary>
        /// <param name="basePath">
        /// The base path.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ReturnFilePath(string basePath)
        {
            Logger.Trace($"Started ReturnFilePath({basePath}");
            Logger.Trace($"Completed ReturnFilePath({basePath}");
            return basePath + @"\OracleAdoSourceType.xml";
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool Test(object parameters)
        {
            Logger.Trace("Started Test()");
            bool result = false;

            AdoSourceOptions adoOptions = parameters as AdoSourceOptions;
            using (OracleConnection connection =
                new OracleConnection(adoOptions.ConnectionString))
            {
                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();

                    result = true;
                }
                catch (Exception ex)
                {
                    Logger.Error($"Unable to connect to database:{ex.Message}");
                }
            }

            Logger.Trace("Complete Test()");

            return result;
        }

        #endregion
    }
}