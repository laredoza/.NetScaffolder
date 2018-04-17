﻿// --------------------------------------------------------------------------------------------------------------------
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
    public class Table : ICloneable
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

        public object Clone()
        {
            Table result = new Table();
            foreach (var column in this.Columns)
            {
                result.Columns.Add(column.Clone() as Column);
            }
            result.DatabaseGeneratedKeyType = this.DatabaseGeneratedKeyType;
            result.Description = this.Description;

            foreach (Relationship rationship in this.RelationShips)
            {
                result.RelationShips.Add(rationship.Clone() as Relationship);
            }

            result.SchemaName = this.SchemaName;
            result.TableName = this.TableName;

            return result;
        }

        #endregion
    }
}