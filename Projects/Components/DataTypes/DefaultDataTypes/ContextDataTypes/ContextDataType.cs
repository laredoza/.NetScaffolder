// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
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
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes;
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
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContextDataType" /> class.
        /// </summary>
        public ContextDataType() : base("Context.xml")
        {
            Contexts = new List<ContextData>();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the contexts.
        /// </summary>
        public List<ContextData> Contexts { get; private set; }

        #endregion

        #region Public methods and operators

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
            return CreateUI(null);
        }

        public string TransformModelName(string name)
        {
            if(NamingConvention == null)
            {
                return name;
            }

            return NamingConvention.ApplyNamingConvention(name);
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

            var filePath = Path.Combine(parameters["basePath"], FileName);

            if (File.Exists(filePath))
            {
                Contexts = ObjectXMLSerializer<List<ContextData>>.Load(filePath);
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

            if (Contexts.Any())
            {
                foreach (var context in Contexts)
                {
                    parent.Children.Add(new Hierarchy
                    {
                        ParentId = parent.Id,
                        Id = context.Id,
                        Name = context.ContextName
                    });
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

            var filePath = Path.Combine(parameters["basePath"], FileName);
            ObjectXMLSerializer<List<ContextData>>.Save(Contexts, filePath);
            return true;
        }

        #endregion
    }

    /// <summary>
    ///     The context data.
    /// </summary>
    public class ContextData
    {
        public ContextData()
        {
            Models = new List<Table>();
            OutputFolder = "Context";
            ContextName = "NewContext";
            Enabled = true;
            Namespace = "Context";
            LoggingEnabled = false;
            InheritFrom = string.Empty;
            Id = Guid.NewGuid();
            GenerateInterface = false;
            CreateDb = false;
            OutputPath = string.Empty;
            ConstructionOptions = string.Empty;
        }

        #region Properties

        /// <summary>
        ///     Gets or sets the construction options.
        /// </summary>
        public string ConstructionOptions { get; set; }

        /// <summary>
        ///     Gets or sets the context name.
        /// </summary>
        public string ContextName { get; set; }

        public string OutputPath { get; set; }

        public string TransformFullnamespace(string baseNs)
        {
            return $"{baseNs}.{Namespace}";
        }

        /// <summary>
        ///     Gets or sets a value indicating whether create db.
        /// </summary>
        public bool CreateDb { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether generate interface.
        /// </summary>
        public bool GenerateInterface { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the inherit from.
        /// </summary>
        public string InheritFrom { get; set; } = "BaseContext";

        [XmlIgnore]
        public string TransformInheritFrom
        {
            get
            {
                if (string.IsNullOrEmpty(InheritFrom))
                {
                    return string.Empty;
                }

                return $": {InheritFrom}";
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether logging enabled.
        /// </summary>
        public bool LoggingEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; }

        public List<Table> Models { get; private set; }

        #endregion
    }
}