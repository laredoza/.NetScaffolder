﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Relationship.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Enum;

    #endregion

    /// <summary>
    ///     The relationship.
    /// </summary>
    [Serializable]
    public class Relationship : ICloneable
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the column name.
        /// </summary>
        [XmlAttribute("ColumnName")]
        public string ColumnName { get; set; }

        public bool ColumnRequired
        {
            get
            {
                return Multiplicity == RelationshipMultiplicity.One ? true : false;
            }
        }

        public bool ReferencedColumnRequired
        {
            get
            {
                return ReferencedMultiplicity == RelationshipMultiplicity.One ? true : false;
            }
        }

        /// <summary>
        ///     Gets or sets the dependency relation ship.
        /// </summary>
        [XmlAttribute("RelationShip")]
        public RelationshipType DependencyRelationShip { get; set; }

        /// <summary>
        ///     Gets or sets the foreign column name.
        /// </summary>
        [XmlAttribute("ReferencedColumnName")]
        public string ReferencedColumnName { get; set; }

        [XmlAttribute("RelationshipAlias")]
        public string RelationshipAlias { get; set; }

        /// <summary>
        ///     Gets or sets the related table.
        /// </summary>
        [XmlIgnore]
        public Table RelatedTable { get; set; }

        /// <summary>
        ///     Gets the related table qualified name.
        /// </summary>
        public string RelatedTableQualifiedName
        {
            get
            {
                return this.RelatedTable != null ? this.RelatedTable.QualifiedTableName : null;
            }
        }

        /// <summary>
        ///     Gets the relationship type string.
        /// </summary>
        public string RelationshipTypeString
        {
            get
            {
                return this.DependencyRelationShip.ToString();
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether render.
        /// </summary>
        [XmlAttribute("Render")]
        public bool Render { get; set; } = true;

        /// <summary>
        ///     Gets or sets the schema name.
        /// </summary>
        [XmlAttribute("SchemaName")]
        public string SchemaName { get; set; }

        // [XmlIgnore]
        // public AutomationDomain Domain
        // {
        // get { return Table == null ? null : (Table.TableCollection == null) ? null : Table.TableCollection.Domain; }
        // }

        /// <summary>
        ///     Gets or sets the table.
        /// </summary>
        [XmlIgnore]
        public Table Table { get; set; }

        /// <summary>
        ///     Gets or sets the table name.
        /// </summary>
        [XmlAttribute("ReferencedTableName")]
        public string ReferencedTableName { get; set; }

        public string ReferencedTableNamePlural
        {
            get
            {
                if(ReferencedTableName.EndsWith("s"))
                {
                    return ReferencedTableName;
                }
                return ReferencedTableName + "s";
            }
        }

        [XmlAttribute("Multiplicity")]
        public RelationshipMultiplicity Multiplicity
        {
            get;set;
        }

        [XmlAttribute("ReferencedMultiplicity")]
        public RelationshipMultiplicity ReferencedMultiplicity
        {
            get; set;
        }

        /// <summary>
        ///     Gets or sets a value indicating whether user relationship.
        /// </summary>
        [XmlAttribute("UserRelationship")]
        public bool UserRelationship { get; set; }

        /// <summary>
        /// Gets or sets the relationship name.
        /// </summary>
        public string RelationshipName { get; set; }

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
            Relationship result = new Relationship();

            result.ColumnName = this.ColumnName;
            result.DependencyRelationShip = this.DependencyRelationShip;
            result.ReferencedColumnName = this.ReferencedColumnName;
            result.ReferencedTableName = this.ReferencedTableName;
            result.Multiplicity = this.Multiplicity;
            result.ReferencedMultiplicity = this.ReferencedMultiplicity;
            result.RelationshipAlias = this.RelationshipAlias;

            if (this.RelatedTable != null)
            {
                result.RelatedTable = this.RelatedTable;
            }

            result.Render = this.Render;
            result.SchemaName = this.SchemaName;

            if (this.Table != null)
            {
                result.Table = this.Table;
            }

            result.UserRelationship = this.UserRelationship;
            result.RelationshipName = this.RelationshipName;

            return result;
        }

        #endregion
    }

    /// <summary>
    /// IEqualityComparer for Relationship where the Relationship Name did now change
    /// </summary>
    public class RelationshipAliasComparer : IEqualityComparer<Relationship>
    {
        public bool Equals(Relationship x, Relationship y)
        {
            if (Object.ReferenceEquals(x, y)) return true; //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null)) //Check whether any of the compared objects is null.
                return false;

            //Check whether the Relationships' properties are equal.
            return x.RelationshipName == y.RelationshipName && x.RelationshipAlias == y.RelationshipAlias;
        }

        // If Equals() returns true for a pair of objects then GetHashCode() must return the same value for these objects.
        public int GetHashCode(Relationship relationship)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(relationship, null)) return 0;

            //Get hash code for the RelationshipName field if it is not null.
            int hashRelationshipName = relationship.RelationshipName == null ? 0 : relationship.RelationshipName.GetHashCode();

            //Get hash code for the RelationshipAlias field.
            int hashRelationshipAlias = relationship.RelationshipAlias == null ? 0 : relationship.RelationshipAlias.GetHashCode();

            //Calculate the hash code for the Relationship.
            return hashRelationshipName ^ hashRelationshipAlias;
        }
    }

    /// <summary>
    /// IEqualityComparer for Relationship where the Relationship Name did now change
    /// </summary>
    public class RelationshipAliasComparerForNewName : IEqualityComparer<Relationship>
    {
        public bool Equals(Relationship x, Relationship y)
        {
            if (Object.ReferenceEquals(x, y)) return true; //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null)) //Check whether any of the compared objects is null.
                return false;

            //Check whether the Relationships' properties are equal.
            return x.RelationshipName != y.RelationshipName && x.ColumnName == y.ColumnName && x.ReferencedColumnName == y.ReferencedColumnName && x.ReferencedTableName == y.ReferencedTableName && x.RelationshipAlias == y.RelationshipAlias;
        }

        // If Equals() returns true for a pair of objects then GetHashCode() must return the same value for these objects.
        public int GetHashCode(Relationship relationship)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(relationship, null)) return 0;

            //Get hash code for the RelationshipName field if it is not null.
            int hashRelationshipName = relationship.RelationshipName == null ? 0 : relationship.RelationshipName.GetHashCode();


            //Get hash code for the ColumnName field if it is not null.
            int hashColumnName = relationship.ColumnName == null ? 0 : relationship.ColumnName.GetHashCode();

            //Get hash code for the ReferencedColumnName field if it is not null.
            int hashReferencedColumnName = relationship.ReferencedColumnName == null ? 0 : relationship.ReferencedColumnName.GetHashCode();

            //Get hash code for the ReferencedTableName field if it is not null.
            int hashReferencedTableName = relationship.ReferencedTableName == null ? 0 : relationship.ReferencedTableName.GetHashCode();

            //Get hash code for the RelationshipAlias field.
            int hashRelationshipAlias = relationship.RelationshipAlias == null ? 0 : relationship.RelationshipAlias.GetHashCode();

            //Calculate the hash code for the Relationship.
            return   hashColumnName ^ hashReferencedColumnName ^ hashReferencedTableName ^ hashRelationshipAlias;
        }
    }


}