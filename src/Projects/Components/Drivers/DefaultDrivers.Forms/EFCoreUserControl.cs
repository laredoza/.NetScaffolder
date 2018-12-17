#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.Common.Contract.UI;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;
using DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore;
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
    [ExportMetadata("NameMetaData", "EFDriverUI")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4411")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DriverType", "2BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public partial class EFCoreUserControl : UserControl, IDriverTypeUI
    {
        #region Fields

        private bool loading;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EFCoreUserControl" /> class.
        /// </summary>
        public EFCoreUserControl()
        {
            InitializeComponent();
            DriverType = new EFCoreDriverType("EFCoreDriverType.xml");
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

            checkCaching.Checked = DriverType.EnableCache;
            comboBoxCaching.SelectedValue = DriverType.Cache;
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

        private void groupBoxCaching_Enter(object sender, EventArgs e)
        {
        }

        #endregion
    }
}