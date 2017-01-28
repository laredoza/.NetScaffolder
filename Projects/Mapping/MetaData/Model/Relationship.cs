using MetaData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MetaData.Model
{
    public class Relationship
    {
        #region Privates

        private bool _render = true;

        #endregion // Privates

        #region Serializable Properties

        [XmlAttribute("SchemaName")]
        public string SchemaName { get; set; }
        [XmlAttribute("TableName")]
        public string TableName { get; set; }
        [XmlAttribute("ForeignColumnName")]
        public string ForeignColumnName { get; set; }
        [XmlAttribute("ColumnName")]
        public string ColumnName { get; set; }
        [XmlAttribute("RelationShip")]
        public RelationshipType RelationShip { get; set; }
        [XmlAttribute("Render")]
        public bool Render
        {
            get { return _render; }
            set { _render = value; }
        }
        [XmlAttribute("UserRelationship")]
        public bool UserRelationship { get; set; }

        #endregion // Serializable Properties

        #region Non-serializable Properties

        #region EF Collection Type transformations

        //private string InterfaceCollectionTypeInDeclaration
        //{
        //    get
        //    {
        //        var collectionOption = Domain == null ? CollectionOptionType.IListAndList : Domain.CollectionOption;
        //        switch (collectionOption)
        //        {
        //            case CollectionOptionType.IListAndList:
        //                return "IList";
        //                break;
        //            default:
        //                return "ICollection";
        //                break;
        //        }
        //    }
        //}

        //private string CollectionTypeInDeclaration
        //{
        //    get
        //    {
        //        var collectionOption = Domain == null ? CollectionOptionType.IListAndList : Domain.CollectionOption;
        //        switch (collectionOption)
        //        {
        //            case CollectionOptionType.ObservableCollection:
        //                return "ObservableCollection";
        //                break;
        //            case CollectionOptionType.IListAndList:
        //                return "IList";
        //                break;
        //            default:
        //                return "ICollection";
        //                break;
        //        }
        //    }
        //}

        //private string CollectionTypeInAssignment
        //{
        //    get
        //    {
        //        var collectionOption = Domain == null ? CollectionOptionType.IListAndList : Domain.CollectionOption;
        //        switch (collectionOption)
        //        {
        //            case CollectionOptionType.ObservableCollection:
        //                return "ObservableCollection";
        //                break;
        //            case CollectionOptionType.IListAndList:
        //                return "List";
        //                break;
        //            default:
        //                return "HashSet";
        //                break;
        //        }
        //    }
        //}

        #endregion // EF Collection Type transformations

        #region Relational in class structure

        public string RelationshipTypeString { get { return RelationShip.ToString(); } }

        public string RelatedTableQualifiedName { get { return RelatedTable != null ? RelatedTable.QualifiedTableName : null; } }

        [XmlIgnore]
        public Table RelatedTable { get; set; }

        //[XmlIgnore]
        //public AutomationDomain Domain
        //{
        //    get { return Table == null ? null : (Table.TableCollection == null) ? null : Table.TableCollection.Domain; }
        //}

        [XmlIgnore]
        public Table Table { get; set; }

        #endregion // Relational in class structure

        #region Text Transformation

        #endregion // Text Transformation

        #endregion // Non-serializable Properties

    }
}
