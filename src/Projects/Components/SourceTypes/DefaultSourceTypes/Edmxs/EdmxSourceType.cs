// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxSourceType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using global::Common.Logging;

    using TiraggoEdmx_v3;

    #endregion

    /// <summary>
    ///     This datasource uses the default Microsoft edmx file to return the data structure.
    /// </summary>
    [Export(typeof(ISourceType))]
    [ExportMetadata("NameMetaData", "EDMX")]
    [ExportMetadata("ValueMetaData", "3BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class EdmxSourceType : ISourceType
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EdmxSourceType"/> class.
        /// </summary>
        public EdmxSourceType()
        {
            this.Schemas = new List<string>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the schemas.
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
        public object AddConfigUI(object parameters)
        {
            Logger.Trace("Started AddConfigUI()");

            Control parent = parameters as Control;
            EdmxUserControl newControl = new EdmxUserControl { Visible = true, Dock = DockStyle.Fill };
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

            foreach (Table modelTable in tables)
            {
                foreach (var relationship in modelTable.Relationships)
                {
                    relationship.Table = modelTable;

                    if (relationship.RelatedTable != null && relationship.RelatedTable != modelTable)
                    {
                        relationship.RelatedTable =
                        tables.FirstOrDefault(t => t.TableName == relationship.ReferencedTableName);
                    }
                    relationship.SchemaName = relationship.RelatedTable?.SchemaName;
                }

                FormatNavigationPropertiesToBeUnique(modelTable);
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
            FileSourceOptions fileOption = options as FileSourceOptions;

            var edmx = Edmx.Load(fileOption.Path);
            var entityTableNames = new HashSet<string>(
                edmx.Runtime.ConceptualModels.Schema.EntityTypes.Select(tbl => tbl.Name.ToUpper()));

            foreach (var table in edmx.Runtime.ConceptualModels.Schema.EntityTypes)
            {
                var tbl = new Table
                {
                    TableName = table.Name,
                    SchemaName = new TiraggoEntityInfo(
                                          edmx,
                                          $"{edmx.Runtime.ConceptualModels.Schema.Namespace}.{table.Name}")
                                      .StorageInfo.Schema
                };

                result.Tables.Add(tbl);

                foreach (var col in table.Properties)
                {
                    var column = new Column
                    {
                        ColumnName = col.Name,
                        DomainDataType = this.MapDatabaseType(col.Type, null),
                        IsPrimaryKey = table.Key.Any(pk => pk.Name == col.Name),
                        IsRequired =
                                             (col.NullableSpecified && !col.Nullable)
                                             || table.Key.Any(pk => pk.Name == col.Name),
                        ColumnOrder = table.Properties.ToList().IndexOf(col) + 1,
                        Precision = (col.Precision > 0 && col.Scale > 0) ? col.Precision : 0,
                        Scale = (col.Precision > 0 && col.Scale > 0) ? col.Scale : 0,
                        Length = string.IsNullOrEmpty(col.MaxLength)
                                                      ? 0
                                                      : Convert.ToInt32(col.MaxLength)
                    };

                    if (column.IsPrimaryKey)
                    {
                        tbl.DatabaseGeneratedKeyType = this.MapDatabaseGeneratedKey(col.StoreGeneratedPattern);
                    }

                    tbl.Columns.Add(column);
                }

                // var relationships = edmx.Runtime.StorageModels.Schemas.Associations.Where(ass => (ass.ReferentialConstraint.Dependent.Role == table.Name || ass.ReferentialConstraint.Principal.Role == table.Name) &&
                // (entityTableNames.Contains(ass.ReferentialConstraint.Dependent.Role.ToUpper()) &&
                // entityTableNames.Contains(ass.ReferentialConstraint.Principal.Role.ToUpper())));

                // Todo: Work in progress
                var relationships = edmx.Runtime.StorageModels.Schema.Associations.Where(
                    ass => (ass.ReferentialConstraint.Dependent.Role == table.Name
                            || ass.ReferentialConstraint.Principal.Role == table.Name)
                           && entityTableNames.Contains(ass.ReferentialConstraint.Principal.Role.ToUpper()));

                foreach (var rel in relationships)
                {


                    var ass = new Relationship
                    {
                        ReferencedTableName =
                                          (rel.ReferentialConstraint.Dependent.Role == table.Name)
                                              ? rel.ReferentialConstraint.Principal.Role
                                              : rel.ReferentialConstraint.Dependent.Role,
                        ColumnName =
                                          (rel.ReferentialConstraint.Dependent.Role == table.Name)
                                              ? rel.ReferentialConstraint.Dependent.PropertyRef.Name
                                              : rel.ReferentialConstraint.Principal.PropertyRef.Name,
                        ReferencedColumnName =
                                          (rel.ReferentialConstraint.Principal.Role == table.Name)
                                              ? rel.ReferentialConstraint.Dependent.PropertyRef.Name
                                              : rel.ReferentialConstraint.Principal.PropertyRef.Name,
                        DependencyRelationShip =
                                          (rel.ReferentialConstraint.Dependent.Role == table.Name)
                                              ? RelationshipType.ForeignKey
                                              : RelationshipType.ForeignKeyChild,
                        RelationshipName = rel.Name
                    };

                    if (rel.Ends.Count() != 2)
                    {
                        throw new Exception("Error in association multiplicity");
                    }

                    var tblMp = rel.Ends.First(o => o.Role == table.Name);
                    var refTblMp = rel.Ends.First(o => o.Role == ass.ReferencedTableName);

                    ass.Multiplicity = this.MapMultiplicity(tblMp.Multiplicity);
                    ass.ReferencedMultiplicity = this.MapMultiplicity(refTblMp.Multiplicity);


                    // check For Recursive Reference:
                    var checker = rel.Ends.First().Type;
                    bool isSelfRef = true;

                    foreach (var item in rel.Ends)
                    {
                        if (checker != item.Type)
                            isSelfRef = false;
                    }

                    Relationship assClone = null;
                    if (isSelfRef)
                    {
                        ass.RelatedTable = tbl;
                        ass.ReferencedTableName = table.Name;
                        ass.Table = tbl;
                        ass.RelationshipAlias = table.Name + "_1";

                        assClone = ass.Clone() as Relationship;
                        assClone.RelationshipAlias = table.Name + "_2";
                        assClone.ColumnName = ass.ReferencedColumnName;
                        assClone.ReferencedColumnName = ass.ColumnName;
                        assClone.DependencyRelationShip = RelationshipType.ForeignKey;
                        assClone.Multiplicity = ass.ReferencedMultiplicity;
                        assClone.ReferencedMultiplicity = ass.Multiplicity;


                    }


                    tbl.Relationships.Add(ass);
                    if (assClone != null)
                        tbl.Relationships.Add(assClone);
                }

                FormatNavigationPropertiesToBeUnique(tbl);

            }



            this.Fix(result);

            Logger.Trace("Completed Import()");
            return result;
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

                string alias = Common.RelationshipNameFormatting.FormatName(
                    rel.ReferencedTableName,
                    rel.RelationshipAlias,
                    null,
                    test);
                // only change alias if it is null. 
                if (!string.Equals(rel.ReferencedTableName, alias) && string.IsNullOrEmpty(alias))
                {
                    rel.RelationshipAlias = alias;
                }

                if (!string.Equals(rel.RelationshipAlias, alias) && !string.Equals(rel.ReferencedTableName, alias) && !string.Equals(rel.RelationshipAlias, rel.ReferencedTableName) && string.IsNullOrEmpty(rel.RelationshipAlias))
                {
                    rel.RelationshipAlias = alias;
                }

            }
        }




        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="parameters">
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Load(object parameters)
        {
            Logger.Trace("Started Import()");

            string path = this.ReturnFilePath(parameters as string);
            Logger.Debug($"Path: {path}");
            FileSourceOptions result = null;

            if (File.Exists(path))
            {
                Logger.Trace("Path Exists");
                result = ObjectXMLSerializer<FileSourceOptions>.Load(path);
            }
            else
            {
                result = new FileSourceOptions();

                Logger.Trace("Path Doesn't Exist");
            }

            Logger.Trace("Completed Import()");

            return result;
        }

        /// <summary>
        /// The map database generated key.
        /// </summary>
        /// <param name="storeGeneratedPattern">
        /// The store generated pattern.
        /// </param>
        /// <returns>
        /// The <see cref="DatabaseGeneratedKeyType"/>.
        /// </returns>
        public DatabaseGeneratedKeyType MapDatabaseGeneratedKey(string storeGeneratedPattern)
        {
            if (string.IsNullOrEmpty(storeGeneratedPattern))
            {
                return DatabaseGeneratedKeyType.None;
            }

            if (storeGeneratedPattern.Equals("Identity", StringComparison.InvariantCultureIgnoreCase))
            {
                return DatabaseGeneratedKeyType.Identity;
            }

            if (storeGeneratedPattern.Equals("Computed", StringComparison.InvariantCultureIgnoreCase))
            {
                return DatabaseGeneratedKeyType.Computed;
            }

            return DatabaseGeneratedKeyType.None;
        }

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        /// The database type.
        /// </param>
        /// <param name="extraInfo">
        /// </param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        public DomainDataType MapDatabaseType(string databaseType, object extraInfo)
        {
            Logger.Trace("Started MapDatabaseType()");

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
                    return DomainDataType.DateTime;
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
            return basePath + @"\EdmxSourceType.xml";
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

            // AdoSourceOptions adoOptions = options as AdoSourceOptions;
            // var databaseReader = new DatabaseReader(adoOptions.ConnectionString, adoOptions.ProviderName);

            // IList<DatabaseTable> tables = databaseReader.TableList();

            // foreach (var table in tables)
            // {
            // this.Schemas.Add(table.Name);
            // }

            // this.Schemas = this.Schemas.OrderBy(s => s).ToList();
            return this.Schemas;
        }

        /// <summary>
        /// Saves
        /// </summary>
        /// <param name="parameters">
        /// </param>
        public void Save(object parameters)
        {
            Logger.Trace("Started Save()");

            List<object> saveParameters = parameters as List<object>;
            string path = this.ReturnFilePath(saveParameters[0] as string);
            Logger.Debug($"Path: {path}");

            FileSourceOptions options = saveParameters[1] as FileSourceOptions;

            if (options == null)
            {
                options = new FileSourceOptions();
            }

            ObjectXMLSerializer<FileSourceOptions>.Save(options, path, SerializedFormat.Document);

            Logger.Trace("Completed Save()");
        }

        /// <summary>
        /// Tests Data Source
        /// </summary>
        /// <param name="parameters">
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Test(object parameters)
        {
            Logger.Trace("Started Test()");

            FileSourceOptions options = parameters as FileSourceOptions;
            bool result = File.Exists(options.Path);

            Logger.Trace("Completed Test()");

            return result;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The map multiplicity.
        /// </summary>
        /// <param name="mp">
        /// The mp.
        /// </param>
        /// <returns>
        /// The <see cref="RelationshipMultiplicity"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        private RelationshipMultiplicity MapMultiplicity(string mp)
        {
            switch (mp)
            {
                case "0..1":
                    {
                        return RelationshipMultiplicity.ZeroToOne;
                    }

                case "1":
                    {
                        return RelationshipMultiplicity.One;
                    }

                case "*":
                    {
                        return RelationshipMultiplicity.Many;
                    }

                default:
                    {
                        throw new Exception("Specified multiplicity coudl not be determined");
                    }
            }
        }

        #endregion
    }
}