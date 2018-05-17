// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoInterfaceUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataType
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoInterfaceDataTypes;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    public partial class DtoInterfaceUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Fields

        /// <summary>
        ///     The data type.
        /// </summary>
        private DtoInterfaceDataType dataType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DtoInterfaceUserControl" /> class.
        ///     Initializes a new instance of the <see cref="EntityUserControl" /> class.
        /// </summary>
        public DtoInterfaceUserControl()
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
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public DtoInterfaceDataType DataType
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
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

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
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public virtual List<Validation> Validate()
        {
            this.ValidationResult = this.DataType.Validate();
            return this.ValidationResult;
        }

        #endregion

        #region Other Methods

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
        }

        #endregion
    }
}