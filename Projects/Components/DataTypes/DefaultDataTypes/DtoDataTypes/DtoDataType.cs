// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoDataType.cs" company="DotnetScaffolder">
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

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.TableDataTypes;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The dto data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Dto")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4490")]
    public class DtoDataType : IDataType
    {
        #region Constants

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        private const string FILE_NAME = "Dto.mdl";

        #endregion

        #region Fields

        /// <summary>
        ///     The fields control.
        /// </summary>
        private Control fieldsControl;

        /// <summary>
        ///     The relationship controls.
        /// </summary>
        private Control relationshipControls;

        /// <summary>
        ///     The table control.
        /// </summary>
        private Control tableControl;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether enabled.
        /// </summary>
        public bool Enabled { get; set; } = false;

        /// <summary>
        ///     Gets or sets the meta data.
        /// </summary>
        public Table MetaData { get; set; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Dto";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Dto";

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
        public IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters)
        {
            var parentControl = new Control();
            var tableControl = new TableUserControl();
            ConfigureControl(tableControl, parentControl);
            var fieldUsercontrol = new FieldUserControl();
            ConfigureControl(fieldUsercontrol, parentControl);
            return tableControl;
        }

        /// <summary>
        ///     The create ui.
        /// </summary>
        /// <returns>
        ///     The <see cref="IDataTypeUI" />.
        /// </returns>
        public IDataTypeUI<IDictionary<string, string>> CreateUI()
        {
            return CreateUI(null);
        }

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void Load(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<DtoDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        /// <summary>
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="IHierarchy" />.
        /// </returns>
        public Hierarchy ReturnNavigation()
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
        public bool Save(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
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