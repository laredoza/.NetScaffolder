// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    public partial class EntityUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityUserControl" /> class.
        /// </summary>
        public EntityUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Events

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

        #endregion

        #region Properties

        private EntityDataType dataType;
        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public EntityDataType DataType
        {
            get
            {
                return dataType;
            }
            set
            {
                dataType = value;
                UpdateUI();
            }
        }

        public DomainDefinition DataSource { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            DataType.Load(parameters);

            UpdateUI();
        }

        private void UpdateUI()
        {
            if (DataType == null) return;

            txtInheritFrom.Text = DataType.InheritFrom;
            txtNamespace.Text = DataType.Namespace;
            txtOutputFolder.Text = DataType.OutputFolder;
            tstOutputPath.Text = DataType.OutputPath;
            chkAddInjectConstructor.Checked = DataType.AddInjectConstructor;
            chkUseInterface.Checked = DataType.UseInterface;
        }

        private void UpdateDataType()
        {
            if (DataType == null) return;

            DataType.InheritFrom = txtInheritFrom.Text;
            DataType.Namespace = txtNamespace.Text;
            DataType.OutputFolder = txtOutputFolder.Text;
            DataType.OutputPath = tstOutputPath.Text;
            DataType.AddInjectConstructor = chkAddInjectConstructor.Checked;
            DataType.UseInterface = chkUseInterface.Checked;
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            UpdateDataType();
            DataType.Save(parameters);
        }

        #endregion

        #region Other Methods

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

        #endregion

        private void chkUseInterface_CheckedChanged(object sender, EventArgs e)
        {
            chkAddInjectConstructor.Enabled = chkUseInterface.Checked;
            if (!chkUseInterface.Checked)
            {
                chkAddInjectConstructor.Checked = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }
    }
}