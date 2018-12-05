#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Core.Common;
using DotNetScaffolder.Core.Configuration;
using DotNetScaffolder.Mapping.ApplicationServices;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;
using DotNetScaffolder.Presentation.Forms.Controls.Model;
using DotNetScaffolder.Presentation.Forms.Controls.Project.Drivers;
using DotNetScaffolder.Presentation.Forms.Controls.Sources;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
    #region Usings

    #endregion

    /// <summary>
    ///     The project domain details user control.
    /// </summary>
    public partial class ProjectDomainDetailsUserControl : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The manage data source form.
        /// </summary>
        private readonly ManageDataSourceForm manageDataSourceForm;

        /// <summary>
        ///     The model form.
        /// </summary>
        private readonly ModelForm modelForm;

        /// <summary>
        ///     The table form.
        /// </summary>
        private readonly UpdateModelsFromSourceForm tableForm;

        /// <summary>
        ///     The application service.
        /// </summary>
        private IProjectDefinitionApplicationService applicationService;

        /// <summary>
        ///     The driver form.
        /// </summary>
        private DriverForm driverForm;

        /// <summary>
        ///     The save path.
        /// </summary>
        private string savePath;

        /// <summary>
        ///     The selected domain.
        /// </summary>
        private DomainDefinition selectedDomain;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDomainDetailsUserControl" /> class.
        /// </summary>
        public ProjectDomainDetailsUserControl()
        {
            InitializeComponent();

            ComboBoxNamingConvention.DisplayMember = "Text";
            ComboBoxNamingConvention.ValueMember = "Value";
            ComboBoxNamingConvention.DataSource = ReturnNamingConventions();

            ComboBoxSourceType.DisplayMember = "Text";
            ComboBoxSourceType.ValueMember = "Value";
            ComboBoxSourceType.DataSource = ReturnSourceTypes();

            ListViewDrivers.Items.Clear();
            var drivers = ReturnDrivers();
            ListViewDrivers.Items.AddRange(drivers);

            ComboBoxCollectionOption.DisplayMember = "Text";
            ComboBoxCollectionOption.ValueMember = "Value";
            ComboBoxCollectionOption.DataSource = ReturnCollectionOptions();

            manageDataSourceForm = new ManageDataSourceForm();
            modelForm = new ModelForm();
            tableForm = new UpdateModelsFromSourceForm();

            driverForm = new DriverForm();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the application service.
        /// </summary>
        public IProjectDefinitionApplicationService ApplicationService
        {
            get => applicationService;

            set
            {
                applicationService = value;

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null)
                {
                    UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the config package.
        /// </summary>
        public Package ConfigPackage { get; set; }

        /// <summary>
        ///     Gets or sets the domain name.
        /// </summary>
        public string DomainName
        {
            get
            {
                var result = string.Empty;

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.Name;
                    Logger.Trace($"DomainName set to {SelectedDomain.Name}.");
                }
                else
                {
                    result = string.Empty;
                    Logger.Trace("Empty DomainName is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null) SelectedDomain.Name = value;
                else Logger.Trace("DomainName is not set as SelectedDomain is null.");
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether loaded.
        /// </summary>
        public bool Loading { get; set; }

        /// <summary>
        ///     Gets or sets the packages.
        /// </summary>
        public List<Package> Packages { get; set; }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath
        {
            get => savePath;

            set
            {
                if (savePath != value)
                {
                    savePath = value;
                    manageDataSourceForm.SavePath = savePath;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected collection option.
        /// </summary>
        public Guid SelectedCollectionOptionId
        {
            get
            {
                var result = Guid.Empty;

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.CollectionOptionId;
                    Logger.Trace($"CollectionOptionId set to {SelectedDomain.CollectionOptionId}.");
                }
                else
                {
                    Logger.Trace("Empty CollectionOptionId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null)
                {
                    SelectedDomain.CollectionOptionId = value;
                }
                else
                {
                    Logger.Trace("Empty CollectionOptionId is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected domain.
        /// </summary>
        public DomainDefinition SelectedDomain
        {
            get => selectedDomain;

            set
            {
                selectedDomain = value;
                UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the selected driver types.
        /// </summary>
        public List<Guid> SelectedDriverTypes
        {
            get
            {
                var result = new List<Guid>();

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.DriverIdList;
                    Logger.Trace($"DriverIdList set to {SelectedDomain.SourceTypeId}.");
                }
                else
                {
                    Logger.Trace("Empty DriverIdList is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null)
                {
                    SelectedDomain.DriverIdList = value;
                }
                else
                {
                    Logger.Trace("Empty DriverIdList is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected naming convention.
        /// </summary>
        public Guid SelectedNamingConvention
        {
            get
            {
                var result = Guid.Empty;

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.NamingConventionId;
                    Logger.Trace($"NamingConventionId set to {SelectedDomain.NamingConventionId}.");
                }
                else
                {
                    Logger.Trace("Empty NamingConventionId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null && SelectedDomain.NamingConventionId != value)
                {
                    SelectedDomain.NamingConventionId = value;
                }
                else
                {
                    Logger.Trace("Empty NamingConventionId is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected package.
        /// </summary>
        public Package SelectedPackage
        {
            get
            {
                Package result = null;

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.Package;
                    Logger.Trace($"PackageId set to {SelectedDomain.Package.Id}.");
                }
                else
                {
                    Logger.Trace("Empty PackageId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null)
                {
                    SelectedDomain.Package = value;
                }
                else
                {
                    Logger.Trace("Empty PackageId is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected source type.
        /// </summary>
        public Guid SelectedSourceType
        {
            get
            {
                var result = Guid.Empty;

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.SourceTypeId;
                    Logger.Trace($"SourceTypeId set to {SelectedDomain.SourceTypeId}.");
                }
                else
                {
                    Logger.Trace("Empty SourceTypeId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null)
                {
                    SelectedDomain.SourceTypeId = value;
                }
                else
                {
                    Logger.Trace("Empty SourceTypeId is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether update package visible.
        /// </summary>
        public bool UpdatePackageVisible
        {
            get { return BtnUpdate.Enabled; }

            set
            {
                if (BtnUpdate.Enabled != value)
                {
                    BtnUpdate.Enabled = value;
                }
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The return collection options.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnCollectionOptions()
        {
            var items = new List<ComboboxItem>();

            if (ScaffoldConfig.CollectionOptions != null)
            {
                foreach (var collectionOption in ScaffoldConfig.CollectionOptions)
                {
                    items.Add(
                        new ComboboxItem
                        {
                            Text = (string) collectionOption.Metadata["NameMetaData"],
                            Value = new Guid(collectionOption.Metadata["ValueMetaData"].ToString())
                        });
                }
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        /// <summary>
        ///     The return driver types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public ListViewItem[] ReturnDrivers()
        {
            var items = new List<ListViewItem>();
            Guid value;
            ListViewItem item;
            IDriver driverObject;

            foreach (var driver in ScaffoldConfig.Drivers)
            {
                driverObject = driver.Value;
                value = new Guid(driver.Metadata["ValueMetaData"].ToString());
                item = new ListViewItem {Text = (string) driver.Metadata["NameMetaData"], Tag = value};

                item.SubItems.Add(
                    new ListViewItem.ListViewSubItem {Text = driverObject.DriverType.Name, Tag = value});

                items.Add(item);
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        /// <summary>
        ///     Return naming conventions.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnNamingConventions()
        {
            var items = new List<ComboboxItem>();

            foreach (var namingConvention in ScaffoldConfig.NamingConventions)
            {
                items.Add(
                    new ComboboxItem
                    {
                        Text = (string) namingConvention.Metadata["NameMetaData"],
                        Value = new Guid(namingConvention.Metadata["ValueMetaData"].ToString())
                    });
            }

            return items.ToArray();
        }

        /// <summary>
        ///     The return source types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnSourceTypes()
        {
            var items = new List<ComboboxItem>();

            foreach (var sourceType in ScaffoldConfig.SourceTypes)
            {
                items.Add(
                    new ComboboxItem
                    {
                        Text = (string) sourceType.Metadata["NameMetaData"],
                        Value = new Guid(sourceType.Metadata["ValueMetaData"].ToString())
                    });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        /// <summary>
        ///     The update domain packages.
        /// </summary>
        public void UpdateDomainPackages()
        {
            if (Packages != null && Packages.Count > 0)
            {
                var currentSelectedPackage = ComboBoxPackages.SelectedValue;

                ComboBoxPackages.DisplayMember = "Name";
                ComboBoxPackages.ValueMember = "Id";
                ComboBoxPackages.DataSource = ReturnPackages();

                // ddb Change  (keep state of select combo)
                

                // this.ComboBoxPackages.SelectedValue = this.SelectedDomain.Package.Id;
                if (SelectedDomain.Package != null)
                {
                    if (currentSelectedPackage != null)
                    {
                        ComboBoxPackages.SelectedValue = currentSelectedPackage;
                        SelectedDomain.Package.Id = Guid.Parse(currentSelectedPackage.ToString());
                    }
                    else
                        ComboBoxPackages.SelectedValue = SelectedDomain.Package.Id;
                }

                this.Loading = true;
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The btn drivers_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            driverForm = new DriverForm
            {
                SavePath = SavePath,
                DataSource = SelectedDomain,
                StartPosition = FormStartPosition.CenterParent
            };

            driverForm.Show(ParentForm);
        }

        /// <summary>
        ///     The btn manage source_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnManageSource_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Manage Source Clicked");
            manageDataSourceForm.DataSource = SelectedDomain;

            manageDataSourceForm.Visible = false;
            manageDataSourceForm.ShowDialog();
            Logger.Trace("Completed Manage Source Clicked");
        }

        /// <summary>
        ///     The btn model_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnModel_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Model Clicked");
            modelForm.SavePath = SavePath;
            modelForm.DataSource = SelectedDomain;
            modelForm.ShowDialog();
            Logger.Trace("Completed Model Clicked");
        }

        /// <summary>
        ///     The btn refresh_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Refresh Clicked");
            tableForm.SavePath = SavePath;
            tableForm.DataSource = SelectedDomain;

            if (tableForm.Valid)
            {
                tableForm.ShowDialog();
            }

            Logger.Trace("Completed Refresh Clicked");
        }

        /// <summary>
        ///     The btn update_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // ddb change:
            if(ConfigPackage == null)
            {
                ConfigPackage = this.SelectedPackage;
            }
            SelectedDomain.Package.Templates = ConfigPackage.Templates;
        }

        /// <summary>
        ///     The combo box collection option_ selected index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ComboBoxCollectionOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.Loading)
            {
                SelectedCollectionOptionId =
                    (Guid) (ComboBoxCollectionOption.SelectedItem as ComboboxItem).Value;
            }
        }

        /// <summary>
        ///     The combo box naming convention_ selected index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ComboBoxNamingConvention_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.Loading)
            {
                SelectedNamingConvention = (Guid) (ComboBoxNamingConvention.SelectedItem as ComboboxItem).Value;
            }
        }

        /// <summary>
        ///     The combo box packages_ selected index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ComboBoxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.Loading)
            {
                SelectedPackage = ComboBoxPackages.SelectedItem as Package;
                if (this.SelectedPackage.Templates.Count == 0)
                {
                    this.ProjectDomainUserControl.ManageDataTypesEnabled = false;
                }
                else
                {
                    this.ProjectDomainUserControl.ManageDataTypesEnabled = true;
                }
            }
        }

        /// <summary>
        ///     The combo box source type_ selected index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ComboBoxSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.Loading)
            {
                SelectedSourceType = (Guid) (ComboBoxSourceType.SelectedItem as ComboboxItem).Value;
            }
        }

        /// <summary>
        ///     The list view drivers_ item checked.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ListViewDrivers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!Loading)
            {
                SelectedDriverTypes.Clear();

                foreach (ListViewItem item in ListViewDrivers.Items)
                {
                    if (item != null && item.Checked)
                    {
                        SelectedDriverTypes.Add(new Guid(item.Tag.ToString()));
                    }
                }
            }
        }

        /// <summary>
        ///     The return packages.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        private List<Package> ReturnPackages()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            var packages = Packages[0].ReturnPackageItems(Packages);
            packages.Insert(0, new Package {Name = "Please Select"});
            return packages;
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (SelectedDomain != null)
            {
                Loading = true;
                UpdateDomainPackages();

                TextBoxName.Text = SelectedDomain.Name;
                if (SelectedNamingConvention != Guid.Empty)
                {
                    ComboBoxNamingConvention.SelectedValue = SelectedNamingConvention;
                }

                if (SelectedSourceType != Guid.Empty)
                {
                    ComboBoxSourceType.SelectedValue = SelectedSourceType;
                }

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null)
                {
                    ComboBoxCollectionOption.SelectedValue = SelectedCollectionOptionId;
                }

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null)
                {
                    foreach (var driverType in SelectedDriverTypes)
                    {
                        foreach (ListViewItem item in ListViewDrivers.Items)
                        {
                            if (new Guid(item.Tag.ToString()) == driverType)
                            {
                                item.Checked = true;
                                break;
                            }
                        }
                    }
                }

                Loading = false;
            }


            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!this.Loading)
            {
                this.DomainName = this.TextBoxName.Text.Trim();

                if (this.ProjectDomainUserControl != null)
                {
                    this.ProjectDomainUserControl.UpdateselectedDomainName(this.DomainName);
                }
            }
        }

        public ProjectDomainUserControl ProjectDomainUserControl { get; set; }

        private void ListViewDrivers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //btnDriver.Enabled = e.IsSelected;
        }
    }
}