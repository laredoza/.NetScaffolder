// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Table.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Enum;

    #endregion

    /// <summary>
    /// The table.
    /// </summary>
    [Serializable]
    public class Table
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        public Table()
        {
            DatabaseGeneratedKeyType = DatabaseGeneratedKeyType.None;
            Columns = new List<Column>();
            RelationShips = new List<Relationship>();
        }

        #endregion

        #region Properties

        // [XmlIgnore]
        // public MetadataTableCollection TableCollection { get; set; }

        // [XmlIgnore]
        // public AutomationDomain Domain { get { return TableCollection == null ? null : TableCollection.Domain; } }

        /// <summary>
        /// Gets the child relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> ChildRelationships
        {
            get
            {
                return RelationShips.Where(u => u.DependencyRelationShip == RelationshipType.ForeignKeyChild && u.Render).ToList();
            }
        }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        [XmlArray("Columns")]
        [XmlArrayItem("Column")]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// Gets the columns to render.
        /// </summary>
        [XmlIgnore]
        public List<Column> ColumnsToRender
        {
            get
            {
                return Columns.Where(u => u.RenderToEntity).ToList();
            }
        }

        /// <summary>
        /// Gets the columns to render to view.
        /// </summary>
        [XmlIgnore]
        public List<Column> ColumnsToRenderToView
        {
            get
            {
                return Columns.Where(u => u.RenderToView).OrderBy(u => u.RenderToViewOrder).ToList();
            }
        }

        /// <summary>
        /// Gets or sets the database generated key type.
        /// </summary>
        public DatabaseGeneratedKeyType DatabaseGeneratedKeyType { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [XmlAttribute("Description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets the distinct child relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> DistinctChildRelationships
        {
            get
            {
                var retval = new List<Relationship>();
                foreach (var rel in RelationShips.Where(u => u.DependencyRelationShip == RelationshipType.ForeignKeyChild && u.Render))
                {
                    var exists = retval.FirstOrDefault(u => u.RelatedTable == rel.RelatedTable);
                    if (exists == null) retval.Add(rel);
                }

                return retval;
            }
        }

        /// <summary>
        /// Gets the parent relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> ParentRelationships
        {
            get
            {
                return RelationShips.Where(u => u.DependencyRelationShip == RelationshipType.ForeignKey && u.Render).ToList();
            }
        }

        /// <summary>
        /// Gets the qualified table name.
        /// </summary>
        [XmlIgnore]
        public string QualifiedTableName
        {
            get
            {
                return string.IsNullOrEmpty(SchemaName) ? TableName : string.Format("{0}.{1}", SchemaName, TableName);
            }
        }

        /// <summary>
        /// Gets or sets the relation ships.
        /// </summary>
        [XmlArray("RelationShips")]
        [XmlArrayItem("RelationShip")]
        public List<Relationship> RelationShips { get; set; }

        /// <summary>
        /// Gets or sets the schema name.
        /// </summary>
        [XmlAttribute("SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the table name.
        /// </summary>
        [XmlAttribute("TableName")]
        public string TableName { get; set; }

        #endregion

        // [XmlIgnore]
        // public EntityAutomation EntityDefinition
        // {
        // get { return TableCollection.Domain.EntityDefinition; }
        // }

        // [XmlIgnore]
        // public DtoAutomation DtoDefinition
        // {
        // get { return TableCollection.Domain.DtoDefinition; }
        // }

        // [XmlIgnore]
        // public ViewModelAutomation CurrentViewModelDefinition { get; set; }

        // [XmlIgnore]
        // public ViewAutomation CurrentViewDefinition { get; set; }

        // [XmlIgnore]
        // public string FluentPrimaryKey
        // {
        // get
        // {
        // var pks = Columns.Where(u => u.IsPrimaryKey).ToList();
        // if (pks.Count <= 0)
        // throw new Exception(string.Format("Table {0} has no primary key field", QualifiedTableName));

        // return string.Format("modelBuilder.Entity<{0}>().HasKey(t => {1});", TransformTableName,
        // pks.Count == 1 ?
        // string.Format("t.{0}", pks[0].TransformPublicPropertyName) :
        // string.Format("new {{ {0} }}", string.Join(", ", pks.Select(u => string.Format("t.{0}", u.TransformPublicPropertyName)))));

        // }
        // }

        // [XmlIgnore]
        // public List<string> FluentDatabaseGeneratedOptions
        // {
        // get
        // {
        // var pks = Columns.Where(u => u.IsPrimaryKey).ToList();
        // if (pks.Count <= 0)
        // throw new Exception(string.Format("Table {0} has no primary key field", QualifiedTableName));

        // return pks.Select(pk => string.Format("modelBuilder.Entity<{0}>().Property(t => t.{1}).HasDatabaseGeneratedOption({2});", TransformTableName, pk.TransformPublicPropertyName, TransformDatabaseGeneratedKeyType)).ToList();
        // }
        // }

        // public void RepairObjectParents(MetadataTableCollection tableCollection)
        // {

        // TableCollection = tableCollection;

        // foreach (var column in Columns)
        // column.Table = this;
        // foreach (var rel in RelationShips)
        // {
        // rel.Table = this;
        // var rtbl = TableCollection.Tables.FirstOrDefault(t => (rel.SchemaName == null || (t.SchemaName.ToUpper() == rel.SchemaName.ToUpper())) && t.TableName.ToUpper() == rel.TableName.ToUpper());
        // if (rtbl != null)
        // rel.RelatedTable = rtbl;
        // }
        // }
    }
}