#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.Common.Contract.UI;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;
using DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate;
using DotNetScaffolder.Core.Common;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Core.Configuration;
using DotNetScaffolder.Mapping.MetaData.Domain;

#endregion

namespace DefaultDrivers.Forms
{
    #region Usings

    #endregion

    /// <summary>
    ///     The ef core user control.
    /// </summary>
    [Export(typeof(IDriverTypeUI))]
    [ExportMetadata("NameMetaData", "NHibernateDriverUI")]
    [ExportMetadata("ValueMetaData", "BB7460EE-5C1D-4E64-8515-C0DFD3752CB6")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DriverType", "BB7460EE-5C1D-4E64-8515-C0DFD3752CB6")]
    public partial class NHibernateUserControl : UserControl, IDriverTypeUI
    {
        #region Fields

        private bool loading;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="NHibernateUserControl" /> class.
        /// </summary>
        public NHibernateUserControl()
        {
            InitializeComponent();
            DriverType = new NhibernateDriverType("NHibernateDriverType.xml");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource { get; set; }

        /// <summary>
        ///     The driver type.
        /// </summary>
        public IDriverType DriverType { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        public void Dispose()
        {
        }

        /// <summary>
        ///     The load config.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        public void LoadConfig(object parameters)
        {
            loading = true;
            comboBoxCaching.DisplayMember = "Text";
            comboBoxCaching.ValueMember = "Value";
            comboBoxCaching.DataSource = ReturnDriverTypes();

            DriverType.LoadConfig(parameters);
            CreateDb.Checked = DriverType.CreateDb;
            LazyLoading.Checked = DriverType.LazyLoadingEnabled;
            LoggingEnabled.Checked = DriverType.LoggingEnabled;
            ProxyCreation.Checked = DriverType.ProxyCreationEnabled;
            chkColumnOrder.Checked = DriverType.IncludeColumnOrder;
            chkUseAlias.Checked = DriverType.UseAlias;

            comboBoxCaching.SelectedValue = DriverType.Cache;
            checkCaching.Checked = DriverType.EnableCache;
            groupBoxCaching.Enabled = checkCaching.Checked;
            loading = false;
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
                if (driverType.Metadata["DriverType"].ToString().ToLower() == DriverType.Id.ToString().ToLower())
                {
                    items.Add(
                        new ComboboxItem
                        {
                            Text = (string) driverType.Metadata["NameMetaData"],
                            Value = new Guid(driverType.Metadata["ValueMetaData"].ToString())
                        });
                }
            }

            return items.ToArray();
        }

        /// <summary>
        ///     The save config.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        public void SaveConfig(object parameters)
        {
            DriverType.CreateDb = CreateDb.Checked;
            DriverType.LazyLoadingEnabled = LazyLoading.Checked;
            DriverType.LoggingEnabled = LoggingEnabled.Checked;
            DriverType.ProxyCreationEnabled = ProxyCreation.Checked;
            DriverType.IncludeColumnOrder = chkColumnOrder.Checked;
            DriverType.UseAlias = chkUseAlias.Checked;
            DriverType.SaveConfig(parameters);

            DriverType.EnableCache = checkCaching.Checked;
            DriverType.SaveConfig(parameters);
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            ValidationResult = DriverType.Validate();
            return ValidationResult;
        }

        #endregion

        #region Other Methods

        private void checkCaching_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCaching.Enabled = checkCaching.Checked;
        }

        private void comboBoxCaching_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                DriverType.Cache = new Guid(comboBoxCaching.SelectedValue.ToString());
            }
        }

        #endregion
    }
}