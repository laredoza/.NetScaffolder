// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationServiceUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.ApplicationServiceDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;

    #endregion

    /// <summary>
    ///     The application service user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "ContextUI")]
    [ExportMetadata("ValueMetaData", "1BC1B0C41BC1B0C4-1E41-9146-82CF-599181CE4420")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "1BC1B0C4-1E41-9146-82CF-599181CE4420")]
    public partial class ApplicationServiceUserControl : UserControl, IDataTypeUI
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
        /// The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType> OnNavigationChanged;

        #region Public Properties

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public IDataType DataType { get; set; }

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
        public void LoadConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;

            if (this.DataType == null) return;

            this.DataType.Load(parameterList);

            //this.AppServiceEnabled.Checked = (this.DataType as ApplicationServiceDataType).Enabled;
            //this.AppServiceNamespace.Text = (this.DataType as ApplicationServiceDataType).Namespace;
            //this.AppServiceOutputFolder.Text = (this.DataType as ApplicationServiceDataType).OutputFolder;

            this.txtNamespaces.Lines = this.DataType.AdditionalNamespaces.ToArray();
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(object parameters)
        {
            if (this.DataType == null) return;

            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;

            //(this.DataType as ApplicationServiceDataType).Enabled = this.AppServiceEnabled.Checked;
            //(this.DataType as ApplicationServiceDataType).Namespace = this.AppServiceNamespace.Text;
            //(this.DataType as ApplicationServiceDataType).OutputFolder = this.AppServiceOutputFolder.Text;

            this.DataType.AdditionalNamespaces.Clear();
            this.DataType.AdditionalNamespaces.AddRange(this.txtNamespaces.Lines);

            this.DataType.Save(parameterList);
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
    }
}