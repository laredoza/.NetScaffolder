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
    public partial class DtoInterfaceUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityUserControl" /> class.
        /// </summary>
        public DtoInterfaceUserControl()
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

        private DtoInterfaceDataType dataType;
        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public DtoInterfaceDataType DataType
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
            txtOutputPath.Text = DataType.OutputPath;
        }

        private void UpdateDataType()
        {
            if (DataType == null) return;

            DataType.InheritFrom = txtInheritFrom.Text;
            DataType.Namespace = txtNamespace.Text;
            DataType.OutputFolder = txtOutputFolder.Text;
            DataType.OutputPath = txtOutputPath.Text;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    txtOutputPath.Text = dialog.SelectedPath;
                }
            }
        }
    }
}