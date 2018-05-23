// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The context data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Context")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4430")]
    public class ContextDataType : BaseDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContextDataType" /> class.
        /// </summary>
        public ContextDataType()
            : base("Context.xml")
        {
            this.Contexts = new List<ContextData>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the contexts.
        /// </summary>
        public List<ContextData> Contexts { get; private set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public override void Load(IDictionary<string, string> parameters)
        {
            if (parameters == null) return;

            if (!parameters.ContainsKey("basePath"))
            {
                return;
            }

            var filePath = Path.Combine(parameters["basePath"], this.FileName);

            if (File.Exists(filePath))
            {
                this.Contexts = ObjectXMLSerializer<List<ContextData>>.Load(filePath);
            }
        }

        /// <summary>
        /// The return navigation.
        /// </summary>
        /// <returns>
        /// The <see cref="Hierarchy"/>.
        /// </returns>
        public override Hierarchy ReturnNavigation()
        {
            var parent = new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4430"), Name = "Context" };

            if (this.Contexts.Any())
            {
                foreach (var context in this.Contexts)
                {
                    parent.Children.Add(
                        new Hierarchy { ParentId = parent.Id, Id = context.Id, Name = context.ContextName });
                }
            }

            return parent;
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Save(IDictionary<string, string> parameters)
        {
            if (parameters == null) return false;

            if (!parameters.ContainsKey("basePath"))
            {
                return false;
            }

            var filePath = Path.Combine(parameters["basePath"], this.FileName);
            ObjectXMLSerializer<List<ContextData>>.Save(this.Contexts, filePath);
            return true;
        }

        /// <summary>
        /// The transform model name.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformModelName(string name)
        {
            if (this.NamingConvention == null)
            {
                return name;
            }

            return this.NamingConvention.ApplyNamingConvention(name);
        }

        public string TransformCompositeKeys(IEnumerable<Column> pks, string prefix)
        {
            string mapping = string.Empty;

            foreach(var col in pks)
            {
                mapping = $"{mapping}{prefix}.{col.ColumnName}, ";
            }

            return mapping.TrimEnd(' ').TrimEnd(',');
        }

        /// <summary>
        /// The transform relationship.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="rel">
        /// The rel.
        /// </param>
        /// <param name="models">
        /// The models.
        /// </param>
        /// <param name="relationships">
        /// The relationships.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformRelationship(string table, Relationship rel, IEnumerable<Table> models, IEnumerable<Relationship> relationships = null)
        {
            var sb = new StringBuilder();

            string refTableName = RelationshipNameFormatting.FormatName(
                rel.ReferencedTableName,
                rel.RelationshipAlias,
                this.NamingConvention);

            if (rel.ReferencedMultiplicity == RelationshipMultiplicity.Many)
            {
                sb.Append(
                    $"modelBuilder.Entity<{this.TransformModelName(table)}>().HasMany<{this.TransformModelName(rel.ReferencedTableName)}>(s => s.{refTableName})");
            }
            else if (rel.ReferencedMultiplicity == RelationshipMultiplicity.One)
            {
                sb.Append(
                    $"modelBuilder.Entity<{this.TransformModelName(table)}>().HasRequired<{this.TransformModelName(rel.ReferencedTableName)}>(s => s.{refTableName})");
            }
            else
            {
                sb.Append(
                    $"modelBuilder.Entity<{this.TransformModelName(table)}>().HasOptional<{this.TransformModelName(rel.ReferencedTableName)}>(s => s.{refTableName})");
            }

            string parentTableName = table;

            if (relationships != null && relationships.Any())
            {
                var parentRels =
                    (from tbl in models
                     select tbl.Relationships.FirstOrDefault(
                         o => o.ReferencedTableName == table && o.SchemaName == rel.SchemaName
                                                             && o.ColumnName == rel.ReferencedColumnName))
                    .Where(x => x != null);

                var parentRel = parentRels.FirstOrDefault();

                if (parentRel != null)
                {
                    parentTableName = RelationshipNameFormatting.FormatName(
                        parentRel.ReferencedTableName,
                        parentRel.RelationshipAlias,
                        this.NamingConvention);
                }
            }

            if (rel.Multiplicity == RelationshipMultiplicity.Many)
            {
                sb.Append(
                    $".WithMany(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ColumnName}).WillCascadeOnDelete(false);");
            }
            else if (rel.Multiplicity == RelationshipMultiplicity.One)
            {
                if (rel.ReferencedMultiplicity == RelationshipMultiplicity.Many)
                {
                    sb.Append(
                        $".WithRequired(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).WillCascadeOnDelete(false);");
                }
                else
                {
                    sb.Append($".WithRequired(s => s.{parentTableName}).WillCascadeOnDelete(false);");
                }
            }
            else
            {
                if (rel.ReferencedMultiplicity == RelationshipMultiplicity.Many)
                {
                    sb.Append(
                        $".WithOptional(s => s.{parentTableName}).HasForeignKey(s => s.{rel.ReferencedColumnName}).WillCascadeOnDelete(false);");
                }
                else
                {
                    sb.Append($".WithOptional(s => s.{parentTableName}).WillCascadeOnDelete(false);");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public override List<Validation> Validate()
        {
            this.ValidationResult = new List<Validation>();

            foreach (var contextData in this.Contexts)
            {
                foreach (Table model in contextData.Models)
                {
                    if (!this.DomainDefinition.Tables.Exists(t => t.TableName == model.TableName))
                    {
                        this.ValidationResult.Add(new Validation(ValidationType.ContextMissingModels, $"Context {contextData.ContextName} is missing Model {model.TableName}"));
                    }
                }
            }

            foreach (ContextData context in this.Contexts)
            {
                if (string.IsNullOrEmpty(context.ContextName))
                {
                    this.ValidationResult.Add(new Validation(ValidationType.ContextNameEmpty, "Contexts must have a name"));
                }
                
            }

            return this.ValidationResult;
        }

        #endregion
    }
}