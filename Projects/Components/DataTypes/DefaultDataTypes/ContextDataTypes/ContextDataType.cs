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
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;
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
        /// <summary>
        ///     Initializes a new instance of the <see cref="ContextDataType" /> class.
        /// </summary>
        public ContextDataType()
            : base("Context.xml")
        {
            this.Contexts = new List<ContextData>();
        }

        /// <summary>
        ///     Gets the contexts.
        /// </summary>
        public List<ContextData> Contexts { get; private set; }

        /// <summary>
        /// The create ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="IDataTypeUI"/>.
        /// </returns>
        public override IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters)
        {
            string savePath = string.Empty;

            if (parameters != null && parameters.ContainsKey("basePath"))
            {
                savePath = parameters["basePath"];
            }

            var newControl = new ContextUserControl
                                 {
                                     Visible = true,
                                     Dock = DockStyle.Fill,
                                     DataType = this,
                                     SavePath = savePath
                                 };
            return newControl;
        }

        /// <summary>
        ///     The create ui.
        /// </summary>
        /// <returns>
        ///     The <see cref="IDataTypeUI" />.
        /// </returns>
        public override IDataTypeUI<IDictionary<string, string>> CreateUI()
        {
            return this.CreateUI(null);
        }

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
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="IHierarchy" />.
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
    }

    /// <summary>
    ///     The context data.
    /// </summary>
    public class ContextData
    {
        /// <summary>
        /// The exluded relationships.
        /// </summary>
        private List<Relationship> exludedRelationships;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextData"/> class.
        /// </summary>
        public ContextData()
        {
            this.Models = new List<Table>();
            this.ExcludedRelationships = new List<Relationship>();
            this.OutputFolder = "Context";
            this.ContextName = "NewContext";
            this.CustomConnectionName = string.Empty;
            this.Namespace = "Context";
            this.LoggingEnabled = false;
            this.LazyLoadingEnabled = false;
            this.ProxyCreationEnabled = false;
            this.InheritFrom = string.Empty;
            this.Id = Guid.NewGuid();
            this.CreateDb = false;
            this.OutputPath = string.Empty;
        }

        public bool HasModel(Relationship rel)
        {
            if (this.Models == null || !this.Models.Any())
            {
                return false;
            }

            return this.Models.Any(o => o.SchemaName == rel.SchemaName && o.TableName == rel.ReferencedTableName);
        }

        /// <summary>
        ///     Gets or sets the context name.
        /// </summary>
        public string ContextName { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether create db.
        /// </summary>
        public bool CreateDb { get; set; }

        /// <summary>
        /// Gets or sets the custom connection name.
        /// </summary>
        public string CustomConnectionName { get; set; }

        /// <summary>
        /// Gets the excluded relationships.
        /// </summary>
        [XmlIgnore]
        public List<Relationship> ExcludedRelationships
        {
            get
            {
                if (!this.exludedRelationships.Any())
                {
                    foreach (var model in this.Models)
                    {
                        foreach (var rel in model.Relationships.Where(o => o.Render))
                        {
                            if (!this.exludedRelationships.Any(
                                    o => o.SchemaName == rel.SchemaName
                                         && o.ReferencedTableName == rel.ReferencedTableName) && !this.Models.Any(
                                    o => o.SchemaName == rel.SchemaName && o.TableName == rel.ReferencedTableName))
                            {
                                this.exludedRelationships.Add(rel);
                            }
                        }
                    }
                }

                return this.exludedRelationships;
            }

            private set
            {
                this.exludedRelationships = value;
            }
        }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the inherit from.
        /// </summary>
        public string InheritFrom { get; set; } = "BaseContext";

        /// <summary>
        /// Gets or sets a value indicating whether lazy loading enabled.
        /// </summary>
        public bool LazyLoadingEnabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether logging enabled.
        /// </summary>
        public bool LoggingEnabled { get; set; }

        /// <summary>
        /// Gets the models.
        /// </summary>
        public List<Table> Models { get; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether proxy creation enabled.
        /// </summary>
        public bool ProxyCreationEnabled { get; set; }

        /// <summary>
        /// Gets the transform inherit from.
        /// </summary>
        [XmlIgnore]
        public string TransformInheritFrom
        {
            get
            {
                if (string.IsNullOrEmpty(this.InheritFrom))
                {
                    return string.Empty;
                }

                return $": {this.InheritFrom}";
            }
        }

        /// <summary>
        /// The transform fullnamespace.
        /// </summary>
        /// <param name="baseNs">
        /// The base ns.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformFullnamespace(string baseNs)
        {
            return $"{baseNs}.{this.Namespace}";
        }
    }
}