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
    [ExportMetadata("NameMetaData", "DtoInterface")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4441")]
    public class DtoInterfaceDataType : BaseDataType
    {
        public DtoInterfaceDataType() :base("DtoInterface.xml")
        {

        }

        #region Properties

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Interfaces";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Interfaces";

        public string OutputPath { get; set; }

        public string InheritFrom { get; set; }

        public string TransformInheritFrom
        {
            get
            {
                if(string.IsNullOrEmpty(InheritFrom))
                {
                    return string.Empty;
                }

                return $": {InheritFrom}";
            }
        }

        [XmlIgnore]
        public string FullNamespace
        {
            get
            {
                return $"{BaseNamespace}.{Namespace}";
            }
        }

        [XmlIgnore]
        public string InterfaceName
        {
            get
            {
                if (MetaData == null)
                {
                    return string.Empty;
                }

                if (NamingConvention == null)
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
            var newControl = new DtoInterfaceUserControl
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
                DtoInterfaceDataType entity = ObjectXMLSerializer<DtoInterfaceDataType>.Load(filePath);

                if (entity != null)
                {
                    this.Namespace = entity.Namespace;
                    this.OutputFolder = entity.OutputFolder;
                    this.OutputPath = entity.OutputPath;
                    this.InheritFrom = entity.InheritFrom;
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4441"), Name = "Dto Interface" };
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
            ObjectXMLSerializer<DtoInterfaceDataType>.Save(this, filePath);
            return true;
        }

        #endregion
    }
}