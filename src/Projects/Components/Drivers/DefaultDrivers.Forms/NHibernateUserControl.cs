// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using DotNetScaffolder.Core.Common;
using DotNetScaffolder.Core.Configuration;

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
    using DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate;
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
        private bool loading;

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NHibernateUserControl"/> class.
        /// </summary>
        public NHibernateUserControl()
        {
            this.InitializeComponent();
            this.DriverType = new NhibernateDriverType("NHibernateDriverType.xml");
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
            this.loading = true;
            comboBoxCaching.DisplayMember = "Text";
            comboBoxCaching.ValueMember = "Value";
            comboBoxCaching.DataSource = this.ReturnDriverTypes();

            this.DriverType.LoadConfig(parameters);
            this.CreateDb.Checked = this.DriverType.CreateDb;
            this.LazyLoading.Checked = this.DriverType.LazyLoadingEnabled;
            this.LoggingEnabled.Checked = this.DriverType.LoggingEnabled;
            this.ProxyCreation.Checked = this.DriverType.ProxyCreationEnabled;
            this.chkColumnOrder.Checked = this.DriverType.IncludeColumnOrder;
            this.chkUseAlias.Checked = this.DriverType.UseAlias;

            comboBoxCaching.SelectedValue = this.DriverType.Cache;
            this.checkCaching.Checked = this.DriverType.EnableCache;
            this.groupBoxCaching.Enabled = this.checkCaching.Checked;
            this.loading = false;
        }

        /// <summary>
        ///     Return naming conventions.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnDriverTypes()
        {
            var items = new List<ComboboxItem>
            {
                new ComboboxItem {Text = "None", Value = Guid.Empty}
            };
            foreach (var driverType in ScaffoldConfig.DriverTypeCache)
            {
                if (driverType.Metadata["ValueMetaData"].ToString().ToLower() == this.DriverType.Id.ToString().ToLower())
                {
                    items.Add(
                        new ComboboxItem
                        {
                            Text = (string)driverType.Metadata["NameMetaData"],
                            Value = new Guid(driverType.Metadata["ValueMetaData"].ToString())
                        });
                }
            }

            return items.ToArray();
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
            this.DriverType.UseAlias = this.chkUseAlias.Checked;
            this.DriverType.SaveConfig(parameters);

            DriverType.EnableCache = this.checkCaching.Checked;
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

        private void checkCaching_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxCaching.Enabled = this.checkCaching.Checked;
        }

        private void comboBoxCaching_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                this.DriverType.Cache = new Guid(comboBoxCaching.SelectedValue.ToString());
            }
        }
    }
}