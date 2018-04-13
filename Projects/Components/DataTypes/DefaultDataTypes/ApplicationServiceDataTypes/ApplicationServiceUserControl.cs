// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationServiceUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The application service user control.
    /// </summary>
    public partial class ApplicationServiceUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationServiceUserControl" /> class.
        /// </summary>
        public ApplicationServiceUserControl()
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

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public ApplicationServiceDataType DataType { get; set; }

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

            AppServiceEnabled.Checked = DataType.Enabled;
            AppServiceNamespace.Text = DataType.Namespace;
            AppServiceOutputFolder.Text = DataType.OutputFolder;
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

            DataType.Enabled = AppServiceEnabled.Checked;
            DataType.Namespace = AppServiceNamespace.Text;
            DataType.OutputFolder = AppServiceOutputFolder.Text;
            DataType.Save(parameters);
        }

        #endregion
    }
}