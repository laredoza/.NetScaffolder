// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using FormControls.TreeView;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    #endregion

    /// <summary>
    ///     The dto data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Dto")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4490")]
    public class DtoDataType : BaseDataType
    {
        #region Fields

        /// <summary>
        ///     The table control.
        /// </summary>
        private Control tableControl;

        #endregion

        public DtoDataType() : base("Dto.xml") { }

        #region Properties

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Dto";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Dto";

        public string OutputPath { get; set; }

        public bool AddInjectConstructor { get; set; }

        public string InheritFrom { get; set; }

        public bool UseInterface { get; set; }

        public string PostFix { get; set; } = "Dto";

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

                if (!string.IsNullOrEmpty(InheritFrom))
                {
                    inherit = $": {InheritFrom}";
                }

                if (AddInjectConstructor || UseInterface)
                {
                    inherit += !string.IsNullOrEmpty(InheritFrom) ? ", " : ": ";
                    inherit += $"I{DtoName}";
                }

                return inherit;
            }
        }

        [XmlIgnore]
        public string DtoName
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

        [XmlIgnore]
        public string DtoNameFull
        {
            get
            {
                return $"{DtoName}{PostFix}";
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
            var newControl = new DtoUserControl
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
            var filePath = Path.Combine(parameters["basePath"], FileName);

            if (File.Exists(filePath))
            {
                var dto = ObjectXMLSerializer<DtoDataType>.Load(filePath);
                if (dto != null)
                {
                    this.Namespace = dto.Namespace;
                    this.OutputFolder = dto.OutputFolder;
                    this.OutputPath = dto.OutputPath;
                    this.InheritFrom = dto.InheritFrom;
                    this.AddInjectConstructor = dto.AddInjectConstructor;
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4490"), Name = "Dto" };
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
            var filePath = Path.Combine(parameters["basePath"], FileName);
            ObjectXMLSerializer<DtoDataType>.Save(this, filePath);
            return true;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The configure control.
        /// </summary>
        /// <param name="control">
        /// The control.
        /// </param>
        /// <param name="parent">
        /// The parent.
        /// </param>
        private void ConfigureControl(Control control, Control parent)
        {
            control.Visible = true;
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            parent.Controls.Add(control);
        }

        #endregion
    }
}