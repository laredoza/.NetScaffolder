// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityDataType.cs" company="DotnetScaffolder">
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
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The entity data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Entity")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4440")]
    public class EntityDataType : BaseDataType
    {
        public EntityDataType() :base("Entity.xml")
        {

        }

        #region Properties

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Entity";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Entity";

        public string OutputPath { get; set; }

        public bool AddInjectConstructor { get; set; }

        public string InheritFrom { get; set; }

        public bool UseInterface { get; set; }

        [XmlIgnore]
        public string FullNamespace
        {
            get
            {
                return $"{BaseNamespace}.{Namespace}";
            }
        }

        [XmlIgnore]
        public string TransformInheritFrom
        {
            get
            {
                string inherit = string.Empty;

                if(!string.IsNullOrEmpty(InheritFrom))
                {
                    inherit = $": {InheritFrom}";
                }

                if(AddInjectConstructor || UseInterface)
                {
                    inherit += !string.IsNullOrEmpty(InheritFrom) ? ", " : ": ";
                    inherit += $"I{EntityName}";
                }

                return inherit;
            }
        }

        [XmlIgnore]
        public string EntityName
        {
            get
            {
                if(MetaData == null)
                {
                    return string.Empty;
                }

                if(NamingConvention == null)
                {
                    return MetaData.TableName;
                }

                return NamingConvention.ApplyNamingConvention(MetaData.TableName);
            }
        }

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
            var newControl = new EntityUserControl
                                 {
                                     Visible = true,
                                     Dock = DockStyle.Fill,
                                     DataType = this
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
                var entity = ObjectXMLSerializer<EntityDataType>.Load(filePath);

                if (entity != null)
                {
                    this.Namespace = entity.Namespace;
                    this.OutputFolder = entity.OutputFolder;
                    this.OutputPath = entity.OutputPath;
                    this.InheritFrom = entity.InheritFrom;
                    this.AddInjectConstructor = entity.AddInjectConstructor;
                }
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4440"), Name = "Entity" };
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
            ObjectXMLSerializer<EntityDataType>.Save(this, filePath);
            return true;
        }

        #endregion
    }
}