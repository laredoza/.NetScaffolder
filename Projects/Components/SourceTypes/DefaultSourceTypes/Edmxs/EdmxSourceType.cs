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
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

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

            var edmx = TiraggoEdmx_v3.Edmx.Load(fileOption.Path);
            var entityTableNames = new HashSet<string>(
                edmx.Runtime.ConceptualModels.Schema.EntityTypes.Select(tbl => tbl.Name.ToUpper()));

            //foreach (var tgConceptualEntityType in edmx.Runtime.ConceptualModels.Schema.EntityTypes)
            //{
            //    //TiraggoEntityInfo info = new TiraggoEntityInfo(edmx, "NModel" + tgConceptualEntityType.Name);
            //    TiraggoEntityInfo info = new TiraggoEntityInfo(edmx, $"{edmx.Runtime.ConceptualModels.Schema.Namespace}.BankAccount");
                
            //    var a = info.StorageInfo.Schema;
            //}

            result.Tables = edmx.Runtime.ConceptualModels.Schema.EntityTypes.Select(
                tbl => new Table
                           {
                               TableName = tbl.Name,
                               SchemaName = new TiraggoEntityInfo(edmx, $"{edmx.Runtime.ConceptualModels.Schema.Namespace}.BankAccount").StorageInfo.Schema,
                               Columns =
                                   tbl.Properties.Select(
                                       col => new Column
                                                  {
                                                      ColumnName = col.Name,
                                                      CSharpDataType =
                                                          this.MapDatabaseTypeToCSharp(col.Type),
                                                      IsRequired = col.Nullable,
                                                      ColumnOrder =
                                                          tbl.Properties.ToList().IndexOf(col) + 1,
                                                      Precision =
                                                          (col.Precision > 0 && col.Scale > 0)
                                                              ? col.Precision
                                                              : 0,
                                                      Scale =
                                                          (col.Precision > 0 && col.Scale > 0)
                                                              ? col.Scale
                                                              : 0,
                                                      Length =
                                                          string.IsNullOrEmpty(col.MaxLength)
                                                              ? 0
                                                              : Convert.ToInt32(col.MaxLength),
                                                      IsPrimaryKey = tbl.Key.Any(pk => pk.Name == col.Name)
                                                  }).ToList(),
                               RelationShips = edmx.Runtime.StorageModels.Schema.Associations
                                   .Where(
                                       ass =>
                                           (ass.ReferentialConstraint.Dependent.Role == tbl.Name
                                            || ass.ReferentialConstraint.Principal.Role == tbl.Name)
                                           && (entityTableNames.Contains(
                                                   ass.ReferentialConstraint.Dependent.Role.ToUpper())
                                               && entityTableNames.Contains(
                                                   ass.ReferentialConstraint.Principal.Role.ToUpper()))).Select(
                                       rel => new Relationship
                                                  {
                                                      TableName =
                                                          (rel.ReferentialConstraint.Dependent.Role
                                                           == tbl.Name)
                                                              ? rel.ReferentialConstraint.Principal
                                                                  .Role
                                                              : rel.ReferentialConstraint.Dependent
                                                                  .Role,
                                                      ColumnName =
                                                          (rel.ReferentialConstraint.Dependent.Role
                                                           == tbl.Name)
                                                              ? rel.ReferentialConstraint.Dependent
                                                                  .PropertyRef.Name
                                                              : rel.ReferentialConstraint.Principal
                                                                  .PropertyRef.Name,
                                                      ForeignColumnName =
                                                          (rel.ReferentialConstraint.Principal.Role
                                                           == tbl.Name)
                                                              ? rel.ReferentialConstraint.Dependent
                                                                  .PropertyRef.Name
                                                              : rel.ReferentialConstraint.Principal
                                                                  .PropertyRef.Name,
                                                      DependencyRelationShip =
                                                          (rel.ReferentialConstraint.Dependent.Role
                                                           == tbl.Name)
                                                              ? RelationshipType.ForeignKey
                                                              : RelationshipType.ForeignKeyChild
                                                  }).ToList()
                           }).ToList();

            Logger.Trace("Completed Import()"); 
            return result;
        }

        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="parameters">
        /// </param>
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
                Logger.Trace("Path Doesn't Exist");
            }

            Logger.Trace("Completed Import()");

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
            Logger.Trace("Started MapDatabaseTypeToCSharp()"); 
            
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
            bool result = false;

            if (File.Exists(options.Path))
            {
                result = true;
            }

            Logger.Trace("Completed Test()"); 
            
            return result;
        }

        #endregion

        /// <summary>
        ///     The return file path.
        /// </summary>
        /// <param name="basePath">
        ///     The base path.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string ReturnFilePath(string basePath)
        {
            Logger.Trace($"Started ReturnFilePath({basePath}");
            Logger.Trace($"Completed ReturnFilePath({basePath}");
            return basePath + @"\EdmxSourceType.xml";
        }
    }
}