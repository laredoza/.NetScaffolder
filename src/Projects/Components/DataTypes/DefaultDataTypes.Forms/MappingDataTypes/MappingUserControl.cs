﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.RepositoryDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.MappingDataTypes;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "MappingUI")]
    [ExportMetadata("ValueMetaData", "361AC82C-8F2A-4D7C-B455-AE5EFFBA9D4A")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "361AC82C-8F2A-4D7C-B455-AE5EFFBA9D4A")]
    public partial class MappingUserControl : UserControl, IDataTypeUI
    {
        #region Fields

        /// <summary>
        ///     The data type.
        /// </summary>
        private IDataType dataType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RepositoryUserControl" /> class.
        /// </summary>
        public MappingUserControl()
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

        public bool Loaded { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
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
            this.Loaded = true;
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

            (this.DataType as MappingDataType).Namespace = this.txtNamespace.Text;
            (this.DataType as MappingDataType).OutputFolder = this.txtOutputFolder.Text;
            (this.DataType as MappingDataType).PostFix = this.txtPostfix.Text;

            this.DataType.AdditionalNamespaces.Clear();
            this.DataType.AdditionalNamespaces.AddRange(this.txtNamespaces.Lines);
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (this.DataType == null) return;

            this.txtNamespace.Text = (this.DataType as MappingDataType).Namespace;
            this.txtOutputFolder.Text = (this.DataType as MappingDataType).OutputFolder;
            this.txtPostfix.Text = (this.DataType as MappingDataType).PostFix;

            this.txtNamespaces.Lines = this.DataType.AdditionalNamespaces.ToArray();
        }

        #endregion
    }
}