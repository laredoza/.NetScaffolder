// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    public partial class DtoUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        /// <summary>
        ///     The data type.
        /// </summary>
        private DtoDataType dataType;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DtoUserControl" /> class.
        ///     Initializes a new instance of the <see cref="EntityUserControl" /> class.
        /// </summary>
        public DtoUserControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public DtoDataType DataType
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

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (this.DataType == null) return;

            this.DataType.Load(parameters);

            this.UpdateUI();
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (this.DataType == null) return;

            this.UpdateDataType();
            this.DataType.Save(parameters);
        }

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
        /// The entity user control 1_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EntityUserControl1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     The update data type.
        /// </summary>
        private void UpdateDataType()
        {
            if (this.DataType == null) return;

            this.DataType.InheritFrom = this.txtInheritFrom.Text;
            this.DataType.Namespace = this.txtNamespace.Text;
            this.DataType.OutputFolder = this.txtOutputFolder.Text;
            this.DataType.OutputPath = this.txtOutputPath.Text;
            this.DataType.AddInjectConstructor = this.chkAddInjectConstructor.Checked;
            this.DataType.UseInterface = this.chkUseInterface.Checked;
            this.DataType.PostFix = this.txtPostFix.Text;
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (this.DataType == null) return;

            this.txtInheritFrom.Text = this.DataType.InheritFrom;
            this.txtNamespace.Text = this.DataType.Namespace;
            this.txtOutputFolder.Text = this.DataType.OutputFolder;
            this.txtOutputPath.Text = this.DataType.OutputPath;
            this.txtPostFix.Text = this.DataType.PostFix;
            this.chkAddInjectConstructor.Checked = this.DataType.AddInjectConstructor;
            this.chkUseInterface.Checked = this.DataType.UseInterface;
        }
    }
}