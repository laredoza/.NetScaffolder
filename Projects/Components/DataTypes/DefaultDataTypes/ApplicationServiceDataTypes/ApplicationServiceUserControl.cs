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
    using DotNetScaffolder.Mapping.MetaData.Domain;

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
            this.InitializeComponent();
        }

        #endregion

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

        #region Public Properties

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public ApplicationServiceDataType DataType { get; set; }

        #endregion

        #region Public Methods And Operators

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

            this.AppServiceEnabled.Checked = this.DataType.Enabled;
            this.AppServiceNamespace.Text = this.DataType.Namespace;
            this.AppServiceOutputFolder.Text = this.DataType.OutputFolder;
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

            this.DataType.Enabled = this.AppServiceEnabled.Checked;
            this.DataType.Namespace = this.AppServiceNamespace.Text;
            this.DataType.OutputFolder = this.AppServiceOutputFolder.Text;
            this.DataType.Save(parameters);
        }

        #endregion
    }
}