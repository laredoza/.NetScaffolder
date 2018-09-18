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
    ///     The table.
    /// </summary>
    [Serializable]
    public class Table : ICloneable
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        public Table()
        {
            this.DatabaseGeneratedKeyType = DatabaseGeneratedKeyType.None;
            this.Columns = new List<Column>();
            this.Relationships = new List<Relationship>();
            this.Indexes = new List<Index>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the child relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> ChildRelationships
        {
            get
            {
                return this.Relationships
                    .Where(u => u.DependencyRelationShip == RelationshipType.ForeignKeyChild && u.Render).ToList();
            }
        }

        /// <summary>
        ///     Gets or sets the columns.
        /// </summary>
        [XmlArray("Columns")]
        [XmlArrayItem("Column")]
        public List<Column> Columns { get; set; }

        /// <summary>
        ///     Gets the columns to render.
        /// </summary>
        [XmlIgnore]
        public List<Column> ColumnsToRender
        {
            get
            {
                return this.Columns.Where(u => u.RenderToEntity).ToList();
            }
        }

        /// <summary>
        ///     Gets the columns to render to view.
        /// </summary>
        [XmlIgnore]
        public List<Column> ColumnsToRenderToView
        {
            get
            {
                return this.Columns.Where(u => u.RenderToView).OrderBy(u => u.RenderToViewOrder).ToList();
            }
        }

        /// <summary>
        ///     Gets or sets the database generated key type.
        /// </summary>
        public DatabaseGeneratedKeyType DatabaseGeneratedKeyType { get; set; }

        public string TransformDatabaseGeneratedKeyType
        {
            get
            {
                switch (this.DatabaseGeneratedKeyType)
                {
                    case DatabaseGeneratedKeyType.Computed:
                        {
                            return "DatabaseGeneratedOption.Computed";
                        }
                    case DatabaseGeneratedKeyType.Identity:
                        {
                            return "DatabaseGeneratedOption.Identity";
                        }
                    default: return "DatabaseGeneratedOption.None";
                }
            }
        }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        [XmlAttribute("Description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        ///     Gets the distinct child relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> DistinctChildRelationships
        {
            get
            {
                var retval = new List<Relationship>();
                foreach (var rel in this.Relationships.Where(
                    u => u.DependencyRelationShip == RelationshipType.ForeignKeyChild && u.Render))
                {
                    if (!retval.Any(u => u.ReferencedTableName == rel.ReferencedTableName &&
                     u.SchemaName == rel.SchemaName &&
                     u.ReferencedColumnName == rel.ReferencedColumnName))
                    {
                        retval.Add(rel);
                    }
                }

                return retval;
            }
        }

        [XmlIgnore]
        public List<Relationship> DistinctParentRelationships
        {
            get
            {
                var retval = new List<Relationship>();
                foreach (var rel in this.Relationships.Where(
                    u => u.DependencyRelationShip == RelationshipType.ForeignKey && u.Render))
                {
                    if (!retval.Any(u => u.ReferencedTableName == rel.ReferencedTableName &&
                     u.SchemaName == rel.SchemaName &&
                     u.ReferencedColumnName == rel.ReferencedColumnName &&
                     u.ColumnName == rel.ColumnName))
                    {
                        retval.Add(rel);
                    }
                }

                return retval;
            }
        }

        /// <summary>
        ///     Gets the parent relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> ParentRelationships
        {
            get
            {
                return this.Relationships
                    .Where(u => u.DependencyRelationShip == RelationshipType.ForeignKey && u.Render).ToList();
            }
        }

        /// <summary>
        ///     Gets the qualified table name.
        /// </summary>
        [XmlIgnore]
        public string QualifiedTableName
        {
            get
            {
                return string.IsNullOrEmpty(this.SchemaName)
                           ? this.TableName
                           : string.Format("{0}.{1}", this.SchemaName, this.TableName);
            }
        }

        /// <summary>
        ///     Gets or sets the relation ships.
        /// </summary>
        [XmlArray("RelationShips")]
        [XmlArrayItem("RelationShip")]
        public List<Relationship> Relationships { get; set; }

        /// <summary>
        ///     Gets or sets the schema name.
        /// </summary>
        [XmlAttribute("SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        ///     Gets or sets the table name.
        /// </summary>
        [XmlAttribute("TableName")]
        public string TableName { get; set; }

        [XmlIgnore]
        public int PrimaryKeyCount
        {
            get
            {
                int count = 0;

                if (Columns != null)
                {
                    count = Columns.Count(o => o.IsPrimaryKey);
                }

                return count;
            }
        }

        /// <summary>
        /// Gets or sets the indexes.
        /// </summary>
        public List<Index> Indexes { get; set; }


        [XmlAttribute("EnabledForCodeGeneration")]
        public bool EnabledForCodeGeneration { get; set; } = true;


        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Clone()
        {
            Table result = new Table();
            foreach (var column in this.Columns)
            {
                result.Columns.Add(column.Clone() as Column);
            }

            result.DatabaseGeneratedKeyType = this.DatabaseGeneratedKeyType;
            result.Description = this.Description;

            foreach (Relationship retionship in this.Relationships)
            {
                result.Relationships.Add(retionship.Clone() as Relationship);
            }

            result.SchemaName = this.SchemaName;
            result.TableName = this.TableName;
            result.DatabaseGeneratedKeyType = this.DatabaseGeneratedKeyType;

            foreach (var index in this.Indexes)
            {
                result.Indexes.Add(index.Clone() as Index);
            }

            return result;
        }

        #endregion
    }
}