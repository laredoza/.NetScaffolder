// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Relationship.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Usings

    using System;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Enum;

    #endregion

    /// <summary>
    /// The relationship.
    /// </summary>
    [Serializable]
    public class Relationship
    {
        #region Properties

        /// <summary>
        /// Gets or sets the column name.
        /// </summary>
        [XmlAttribute("ColumnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the dependency relation ship.
        /// </summary>
        [XmlAttribute("RelationShip")]
        public RelationshipType DependencyRelationShip { get; set; }

        /// <summary>
        /// Gets or sets the foreign column name.
        /// </summary>
        [XmlAttribute("ForeignColumnName")]
        public string ForeignColumnName { get; set; }

        /// <summary>
        /// Gets or sets the related table.
        /// </summary>
        [XmlIgnore]
        public Table RelatedTable { get; set; }

        /// <summary>
        /// Gets the related table qualified name.
        /// </summary>
        public string RelatedTableQualifiedName
        {
            get
            {
                return RelatedTable != null ? RelatedTable.QualifiedTableName : null;
            }
        }

        /// <summary>
        /// Gets the relationship type string.
        /// </summary>
        public string RelationshipTypeString
        {
            get
            {
                return DependencyRelationShip.ToString();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether render.
        /// </summary>
        [XmlAttribute("Render")]
        public bool Render { get; set; } = true;

        /// <summary>
        /// Gets or sets the schema name.
        /// </summary>
        [XmlAttribute("SchemaName")]
        public string SchemaName { get; set; }

        // [XmlIgnore]
        // public AutomationDomain Domain
        // {
        // get { return Table == null ? null : (Table.TableCollection == null) ? null : Table.TableCollection.Domain; }
        // }

        /// <summary>
        /// Gets or sets the table.
        /// </summary>
        [XmlIgnore]
        public Table Table { get; set; }

        /// <summary>
        /// Gets or sets the table name.
        /// </summary>
        [XmlAttribute("TableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether user relationship.
        /// </summary>
        [XmlAttribute("UserRelationship")]
        public bool UserRelationship { get; set; }

        #endregion

        // private string InterfaceCollectionTypeInDeclaration
        // {
        // get
        // {
        // var collectionOption = Domain == null ? CollectionOptionType.IListAndList : Domain.CollectionOption;
        // switch (collectionOption)
        // {
        // case CollectionOptionType.IListAndList:
        // return "IList";
        // break;
        // default:
        // return "ICollection";
        // break;
        // }
        // }
        // }

        // private string CollectionTypeInDeclaration
        // {
        // get
        // {
        // var collectionOption = Domain == null ? CollectionOptionType.IListAndList : Domain.CollectionOption;
        // switch (collectionOption)
        // {
        // case CollectionOptionType.ObservableCollection:
        // return "ObservableCollection";
        // break;
        // case CollectionOptionType.IListAndList:
        // return "IList";
        // break;
        // default:
        // return "ICollection";
        // break;
        // }
        // }
        // }

        // private string CollectionTypeInAssignment
        // {
        // get
        // {
        // var collectionOption = Domain == null ? CollectionOptionType.IListAndList : Domain.CollectionOption;
        // switch (collectionOption)
        // {
        // case CollectionOptionType.ObservableCollection:
        // return "ObservableCollection";
        // break;
        // case CollectionOptionType.IListAndList:
        // return "List";
        // break;
        // default:
        // return "HashSet";
        // break;
        // }
        // }
        // }
    }
}