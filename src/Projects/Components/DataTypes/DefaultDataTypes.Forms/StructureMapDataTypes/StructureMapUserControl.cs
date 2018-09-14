// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.DtoDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoDataTypes;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.StructureMapDataTypes;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "StructureMapUI")]
    [ExportMetadata("ValueMetaData", "CB2445E3-5F8D-4BEC-ADDC-0D1430E15CAA")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "CB2445E3-5F8D-4BEC-ADDC-0D1430E15CAA")]
    public partial class StructureMapUserControl : UserControl, IDataTypeUI
    {
        #region Fields

        /// <summary>
        ///     The data type.
        /// </summary>
        private IDataType dataType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StructureMapUserControl"/> class.
        /// </summary>
        public StructureMapUserControl()
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
        /// Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

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

            (this.DataType as StructureMapDataType).Namespace = this.txtNamespace.Text;
            (this.DataType as StructureMapDataType).OutputFolder = this.txtOutputFolder.Text;
            (this.DataType as StructureMapDataType).OutputPath = this.txtOutputPath.Text;

            this.DataType.AdditionalNamespaces.Clear();
            this.DataType.AdditionalNamespaces.AddRange(this.txtNamespaces.Lines);
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (this.DataType == null) return;

            this.txtNamespace.Text = (this.DataType as StructureMapDataType).Namespace;
            this.txtOutputFolder.Text = (this.DataType as StructureMapDataType).OutputFolder;
            this.txtOutputPath.Text = (this.DataType as StructureMapDataType).OutputPath;

            this.txtNamespaces.Lines = this.DataType.AdditionalNamespaces.ToArray();
        }

        #endregion
    }
}