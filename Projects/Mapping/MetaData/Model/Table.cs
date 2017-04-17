namespace DotNetScaffolder.Mapping.MetaData.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Enum;

    public class Table
    {
        public DatabaseGeneratedKeyType DatabaseGeneratedKeyType { get; set; }

        private string _description = string.Empty;

        #region Serializable Properties

        [XmlAttribute("TableName")]
        public string TableName { get; set; }

        [XmlAttribute("SchemaName")]
        public string SchemaName { get; set; }

        [XmlArray("Columns")]
        [XmlArrayItem("Column")]
        public List<Column> Columns { get; set; }

        [XmlArray("RelationShips")]
        [XmlArrayItem("RelationShip")]
        public List<Relationship> RelationShips { get; set; }

        [XmlAttribute("Description")]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        #endregion // Serializable Properties

        #region Non-serializable Properties

        [XmlIgnore]
        public List<Column> ColumnsToRender
        {
            get { return this.Columns.Where(u => u.RenderToEntity).ToList(); }
        }

        [XmlIgnore]
        public List<Column> ColumnsToRenderToView
        {
            get { return this.Columns.Where(u => u.RenderToView).OrderBy(u => u.RenderToViewOrder).ToList(); }
        }

        [XmlIgnore]
        public string QualifiedTableName
        {
            get { return string.IsNullOrEmpty(this.SchemaName) ? this.TableName : string.Format("{0}.{1}", this.SchemaName, this.TableName); }
        }

        #region Relational in class structure

        //[XmlIgnore]
        //public MetadataTableCollection TableCollection { get; set; }

        //[XmlIgnore]
        //public AutomationDomain Domain { get { return TableCollection == null ? null : TableCollection.Domain; } }

        [XmlIgnore]
        public List<Relationship> ChildRelationships
        {
            get { return this.RelationShips.Where(u => u.RelationShip == RelationshipType.ForeignKeyChild && u.Render).ToList(); }
        }

        [XmlIgnore]
        public List<Relationship> DistinctChildRelationships
        {
            get
            {
                var retval = new List<Relationship>();
                foreach (var rel in this.RelationShips.Where(u => u.RelationShip == RelationshipType.ForeignKeyChild && u.Render))
                {
                    var exists = retval.FirstOrDefault(u => u.RelatedTable == rel.RelatedTable);
                    if (exists == null)
                        retval.Add(rel);
                }
                return retval;
            }
        }

        [XmlIgnore]
        public List<Relationship> ParentRelationships
        {
            get { return this.RelationShips.Where(u => u.RelationShip == RelationshipType.ForeignKey && u.Render).ToList(); }
        }

        //[XmlIgnore]
        //public EntityAutomation EntityDefinition
        //{
        //    get { return TableCollection.Domain.EntityDefinition; }
        //}

        //[XmlIgnore]
        //public DtoAutomation DtoDefinition
        //{
        //    get { return TableCollection.Domain.DtoDefinition; }
        //}

        //[XmlIgnore]
        //public ViewModelAutomation CurrentViewModelDefinition { get; set; }

        //[XmlIgnore]
        //public ViewAutomation CurrentViewDefinition { get; set; }

        #endregion // Relational in class structure

        #region Text Transformation

        #region Entity

        //[XmlIgnore]
        //public string FluentPrimaryKey
        //{
        //    get
        //    {
        //        var pks = Columns.Where(u => u.IsPrimaryKey).ToList();
        //        if (pks.Count <= 0)
        //            throw new Exception(string.Format("Table {0} has no primary key field", QualifiedTableName));

        //        return string.Format("modelBuilder.Entity<{0}>().HasKey(t => {1});", TransformTableName,
        //                pks.Count == 1 ?
        //                string.Format("t.{0}", pks[0].TransformPublicPropertyName) :
        //                string.Format("new {{ {0} }}", string.Join(", ", pks.Select(u => string.Format("t.{0}", u.TransformPublicPropertyName)))));

        //    }
        //}

        //[XmlIgnore]
        //public List<string> FluentDatabaseGeneratedOptions
        //{
        //    get
        //    {
        //        var pks = Columns.Where(u => u.IsPrimaryKey).ToList();
        //        if (pks.Count <= 0)
        //            throw new Exception(string.Format("Table {0} has no primary key field", QualifiedTableName));

        //        return pks.Select(pk => string.Format("modelBuilder.Entity<{0}>().Property(t => t.{1}).HasDatabaseGeneratedOption({2});", TransformTableName, pk.TransformPublicPropertyName, TransformDatabaseGeneratedKeyType)).ToList();
        //    }
        //}

        #endregion // Entity

        #region ViewModel

        #endregion // ViewModel

        #region View


        #endregion // View

        #endregion // Text Transformation

        #endregion // Non-serializable Properties

        #region Public Methods

        //public void RepairObjectParents(MetadataTableCollection tableCollection)
        //{

        //    TableCollection = tableCollection;

        //    foreach (var column in Columns)
        //        column.Table = this;
        //    foreach (var rel in RelationShips)
        //    {
        //        rel.Table = this;
        //        var rtbl = TableCollection.Tables.FirstOrDefault(t => (rel.SchemaName == null || (t.SchemaName.ToUpper() == rel.SchemaName.ToUpper())) && t.TableName.ToUpper() == rel.TableName.ToUpper());
        //        if (rtbl != null)
        //            rel.RelatedTable = rtbl;
        //    }
        //}

        #endregion // Public Methods

        public Table()
        {
            this.DatabaseGeneratedKeyType = DatabaseGeneratedKeyType.None;
            this.Columns = new List<Column>();
            this.RelationShips = new List<Relationship>();
        }
    }
}
