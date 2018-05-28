// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFDriverTypeUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultDrivers.Forms
{
    #region Usings

    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;
    using DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6;
    using DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    #endregion

    /// <summary>
    /// The ef driver type user control.
    /// </summary>
    [Export(typeof(IDriverTypeUI))]
    [ExportMetadata("NameMetaData", "EFDriverUI")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4410")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DriverType", "2BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public partial class EFDriverTypeUserControl : UserControl, IDriverTypeUI
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EFDriverTypeUserControl" /> class.
        /// </summary>
        public EFDriverTypeUserControl()
        {
            this.InitializeComponent();
            this.DriverType = new EFDriverType("EFDriverType.xml");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        public IDriverType DriverType { get; set; }

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
            this.DriverType.LoadConfig(parameters);
            this.CreateDb.Checked = this.DriverType.CreateDb;
            this.LazyLoading.Checked = this.DriverType.LazyLoadingEnabled;
            this.LoggingEnabled.Checked = this.DriverType.LoggingEnabled;
            this.ProxyCreation.Checked = this.DriverType.ProxyCreationEnabled;
            this.chkColumnOrder.Checked = this.DriverType.IncludeColumnOrder;
            this.chkUseConfigClasses.Checked = this.DriverType.UseSeperateConfigClasses;
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(object parameters)
        {
            this.DriverType.CreateDb = this.CreateDb.Checked;
            this.DriverType.LazyLoadingEnabled = this.LazyLoading.Checked;
            this.DriverType.LoggingEnabled = this.LoggingEnabled.Checked;
            this.DriverType.ProxyCreationEnabled = this.ProxyCreation.Checked;
            this.DriverType.IncludeColumnOrder = this.chkColumnOrder.Checked;
            this.DriverType.UseSeperateConfigClasses = this.chkUseConfigClasses.Checked;

            this.DriverType.SaveConfig(parameters);
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            this.ValidationResult = this.DriverType.Validate();
            return this.ValidationResult;
        }

        #endregion
    }
}