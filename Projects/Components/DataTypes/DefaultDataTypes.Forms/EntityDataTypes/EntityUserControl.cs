// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.EntityDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "ContextUI")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4440")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "1BC1B0C4-1E41-9146-82CF-599181CE4440")]
    public partial class EntityUserControl : UserControl, IDataTypeUI
    {
        #region Fields

        /// <summary>
        ///     The data type.
        /// </summary>
        private IDataType dataType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityUserControl" /> class.
        /// </summary>
        public EntityUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType> OnNavigationChanged;

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }
        
        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public IDataType DataType
        {
            get
            {
                return this.dataType;
            }

            set
            {
                this.dataType = value;
                this.UpdateUI();
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void LoadConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;
            if (this.DataType == null) return;

            this.DataType.Load(parameterList);

            this.UpdateUI();
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;
            if (this.DataType == null) return;

            this.UpdateDataType();
            this.DataType.Save(parameterList);
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public virtual List<Validation> Validate()
        {
            this.ValidationResult = this.DataType.Validate();
            return this.ValidationResult;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The chk use interface_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void chkUseInterface_CheckedChanged(object sender, EventArgs e)
        {
            this.chkAddInjectConstructor.Enabled = this.chkUseInterface.Checked;
            if (!this.chkUseInterface.Checked)
            {
                this.chkAddInjectConstructor.Checked = false;
            }
        }

        /// <summary>
        ///     The update data type.
        /// </summary>
        private void UpdateDataType()
        {
            if (this.DataType == null) return;

            (this.DataType as EntityDataType).InheritFrom = this.txtInheritFrom.Text;
            (this.DataType as EntityDataType).Namespace = this.txtNamespace.Text;
            (this.DataType as EntityDataType).OutputFolder = this.txtOutputFolder.Text;
            (this.DataType as EntityDataType).OutputPath = this.txtOutputPath.Text;
            (this.DataType as EntityDataType).AddInjectConstructor = this.chkAddInjectConstructor.Checked;
            (this.DataType as EntityDataType).UseInterface = this.chkUseInterface.Checked;
            (this.DataType as EntityDataType).UseGenerics = this.chkUseGenerics.Checked;

            this.DataType.AdditionalNamespaces.Clear();
            this.DataType.AdditionalNamespaces.AddRange(this.txtNamespaces.Lines);
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (this.DataType == null) return;

            this.txtInheritFrom.Text = (this.DataType as EntityDataType).InheritFrom;
            this.txtNamespace.Text = (this.DataType as EntityDataType).Namespace;
            this.txtOutputFolder.Text = (this.DataType as EntityDataType).OutputFolder;
            this.txtOutputPath.Text = (this.DataType as EntityDataType).OutputPath;
            this.chkAddInjectConstructor.Checked = (this.DataType as EntityDataType).AddInjectConstructor;
            this.chkUseInterface.Checked = (this.DataType as EntityDataType).UseInterface;
            this.chkUseGenerics.Checked = (this.DataType as EntityDataType).UseGenerics;

            this.txtNamespaces.Lines = this.DataType.AdditionalNamespaces.ToArray();
        }

        #endregion
    }
}