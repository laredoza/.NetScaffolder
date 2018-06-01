// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultDrivers.Forms
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;
    using DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    /// The ef core user control.
    /// </summary>
    [Export(typeof(IDriverTypeUI))]
    [ExportMetadata("NameMetaData", "NHibernateDriverUI")]
    [ExportMetadata("ValueMetaData", "BB7460EE-5C1D-4E64-8515-C0DFD3752CB6")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DriverType", "BB7460EE-5C1D-4E64-8515-C0DFD3752CB6")]
    public partial class NHibernateUserControl : UserControl, IDriverTypeUI
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EFCoreUserControl"/> class.
        /// </summary>
        public NHibernateUserControl()
        {
            this.InitializeComponent();
            this.DriverType = new EFCoreDriverType("NHibernateDriverType.xml");
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        /// The driver type.
        /// </summary>
        public IDriverType DriverType { get; set;  }
        
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
            this.DriverType.LoadConfig(parameters);
            this.CreateDb.Checked = this.DriverType.CreateDb;
            this.LazyLoading.Checked = this.DriverType.LazyLoadingEnabled;
            this.LoggingEnabled.Checked = this.DriverType.LoggingEnabled;
            this.ProxyCreation.Checked = this.DriverType.ProxyCreationEnabled;
            this.chkColumnOrder.Checked = this.DriverType.IncludeColumnOrder;
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

        public void Dispose()
        {

        }

        #endregion
    }
}