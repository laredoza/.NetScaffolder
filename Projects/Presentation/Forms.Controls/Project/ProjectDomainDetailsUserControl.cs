// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDomainDetailsUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
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
            this.InitializeComponent();

            this.ComboBoxNamingConvention.DisplayMember = "Text";
            this.ComboBoxNamingConvention.ValueMember = "Value";
            this.ComboBoxNamingConvention.DataSource = this.ReturnNamingConventions();

            this.ComboBoxSourceType.DisplayMember = "Text";
            this.ComboBoxSourceType.ValueMember = "Value";
            this.ComboBoxSourceType.DataSource = this.ReturnSourceTypes();

            this.ListViewDrivers.Items.Clear();
            var drivers = this.ReturnDrivers();
            this.ListViewDrivers.Items.AddRange(drivers);

            this.ComboBoxCollectionOption.DisplayMember = "Text";
            this.ComboBoxCollectionOption.ValueMember = "Value";
            this.ComboBoxCollectionOption.DataSource = this.ReturnCollectionOptions();

            this.manageDataSourceForm = new ManageDataSourceForm();
            this.modelForm = new ModelForm();
            this.tableForm = new UpdateModelsFromSourceForm();

            this.driverForm = new DriverForm();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the application service.
        /// </summary>
        public IProjectDefinitionApplicationService ApplicationService
        {
            get => this.applicationService;

            set
            {
                this.applicationService = value;

                if (this.Packages != null && this.Packages.Count > 0)
                {
                    var selectedPackage = this.SelectedPackage;

                    this.ComboBoxPackages.DisplayMember = "Name";
                    this.ComboBoxPackages.ValueMember = "Id";
                    this.ComboBoxPackages.DataSource = this.Packages[0].ReturnPackageItems(this.Packages);
                    this.SelectedPackage = selectedPackage;
                }

                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
                    this.UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the domain name.
        /// </summary>
        public string DomainName
        {
            get
            {
                var result = string.Empty;

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.Name;
                    Logger.Trace($"DomainName set to {this.SelectedDomain.Name}.");
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
                if (this.SelectedDomain != null) this.SelectedDomain.Name = value;
                else Logger.Trace("DomainName is not set as SelectedDomain is null.");
            }
        }

        /// <summary>
        ///     Gets or sets the packages.
        /// </summary>
        public List<Package> Packages { get; set; }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath
        {
            get => this.savePath;

            set
            {
                if (this.savePath != value)
                {
                    this.savePath = value;
                    this.manageDataSourceForm.SavePath = this.savePath;
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

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.CollectionOptionId;
                    Logger.Trace($"CollectionOptionId set to {this.SelectedDomain.CollectionOptionId}.");
                }
                else
                {
                    Logger.Trace("Empty CollectionOptionId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null) this.SelectedDomain.CollectionOptionId = value;
                else Logger.Trace("Empty CollectionOptionId is returned as SelectedDomain is null.");
            }
        }

        /// <summary>
        ///     Gets or sets the selected domain.
        /// </summary>
        public DomainDefinition SelectedDomain
        {
            get => this.selectedDomain;

            set
            {
                this.selectedDomain = value;
                this.UpdateDataSource();
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

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.DriverIdList;
                    Logger.Trace($"DriverIdList set to {this.SelectedDomain.SourceTypeId}.");
                }
                else
                {
                    Logger.Trace("Empty DriverIdList is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null) this.SelectedDomain.DriverIdList = value;
                else Logger.Trace("Empty DriverIdList is returned as SelectedDomain is null.");
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

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.NamingConventionId;
                    Logger.Trace($"NamingConventionId set to {this.SelectedDomain.NamingConventionId}.");
                }
                else
                {
                    Logger.Trace("Empty NamingConventionId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null && this.SelectedDomain.NamingConventionId != value)
                    this.SelectedDomain.NamingConventionId = value;
                else Logger.Trace("Empty NamingConventionId is returned as SelectedDomain is null.");
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

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.Package;
                    Logger.Trace($"PackageId set to {this.SelectedDomain.Package.Id}.");
                }
                else
                {
                    Logger.Trace("Empty PackageId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null) this.SelectedDomain.Package = value;
                else Logger.Trace("Empty PackageId is returned as SelectedDomain is null.");
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

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.SourceTypeId;
                    Logger.Trace($"SourceTypeId set to {this.SelectedDomain.SourceTypeId}.");
                }
                else
                {
                    Logger.Trace("Empty SourceTypeId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null) this.SelectedDomain.SourceTypeId = value;
                else Logger.Trace("Empty SourceTypeId is returned as SelectedDomain is null.");
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
                foreach (var collectionOption in ScaffoldConfig.CollectionOptions)
                    items.Add(
                        new ComboboxItem
                            {
                                Text = (string)collectionOption.Metadata["NameMetaData"],
                                Value = new Guid(collectionOption.Metadata["ValueMetaData"].ToString())
                            });

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
                item = new ListViewItem { Text = (string)driver.Metadata["NameMetaData"], Tag = value };

                item.SubItems.Add(
                    new ListViewItem.ListViewSubItem { Text = driverObject.DriverType.Name, Tag = value });

                items.Add(item);
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        /// <summary>
        ///     The return driver types.
        /// </summary>
        /// <param name="driver">
        ///     The driver.
        /// </param>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        /// <summary>
        ///     Return naming conventions.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public object[] ReturnNamingConventions()
        {
            var items = new List<ComboboxItem>();

            foreach (var namingConvention in ScaffoldConfig.NamingConventions)
                items.Add(
                    new ComboboxItem
                        {
                            Text = (string)namingConvention.Metadata["NameMetaData"],
                            Value = new Guid(namingConvention.Metadata["ValueMetaData"].ToString())
                        });

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
                items.Add(
                    new ComboboxItem
                        {
                            Text = (string)sourceType.Metadata["NameMetaData"],
                            Value = new Guid(sourceType.Metadata["ValueMetaData"].ToString())
                        });

            return items.OrderBy(i => i.Text).ToArray();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The btn drivers_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            this.driverForm = new DriverForm
                                  {
                                      SavePath = this.SavePath,
                                      DataSource = this.SelectedDomain,
                                      StartPosition = FormStartPosition.CenterParent
                                  };

            this.driverForm.Show(this.ParentForm);
        }

        /// <summary>
        /// The btn manage source_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnManageSource_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Manage Source Clicked");
            this.manageDataSourceForm.DataSource = this.SelectedDomain;
            this.manageDataSourceForm.ShowDialog();
            Logger.Trace("Completed Manage Source Clicked");
        }

        /// <summary>
        /// The btn model_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnModel_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Model Clicked");
            this.modelForm.SavePath = this.SavePath;
            this.modelForm.DataSource = this.SelectedDomain;
            this.modelForm.ShowDialog();
            Logger.Trace("Completed Model Clicked");
        }

        /// <summary>
        /// The btn refresh_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Refresh Clicked");
            this.tableForm.SavePath = this.SavePath;
            this.tableForm.DataSource = this.SelectedDomain;
            if (this.tableForm.Valid) this.tableForm.ShowDialog();
            Logger.Trace("Completed Refresh Clicked");
        }

        /// <summary>
        /// The combo box collection option_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxCollectionOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxCollectionOption.SelectedItem != null)
                this.SelectedCollectionOptionId =
                    (Guid)(this.ComboBoxCollectionOption.SelectedItem as ComboboxItem).Value;
        }

        /// <summary>
        /// The combo box naming convention_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxNamingConvention_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedNamingConvention = (Guid)(this.ComboBoxNamingConvention.SelectedItem as ComboboxItem).Value;
        }

        /// <summary>
        /// The combo box packages_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedPackage = this.ComboBoxPackages.SelectedItem as Package;
        }

        /// <summary>
        /// The combo box source type_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedSourceType = (Guid)(this.ComboBoxSourceType.SelectedItem as ComboboxItem).Value;
        }

        /// <summary>
        /// The list view drivers_ item checked.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ListViewDrivers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this.SelectedDriverTypes.Clear();

            foreach (ListViewItem item in this.ListViewDrivers.Items)
                if (item != null && item.Checked)
                    this.SelectedDriverTypes.Add(new Guid(item.Tag.ToString()));
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.SelectedDomain != null)
            {
                this.TextBoxName.Text = this.SelectedDomain.Name;
                if (this.SelectedNamingConvention != Guid.Empty)
                    this.ComboBoxNamingConvention.SelectedValue = this.SelectedNamingConvention;

                if (this.SelectedSourceType != Guid.Empty)
                    this.ComboBoxSourceType.SelectedValue = this.SelectedSourceType;

                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
                    this.ComboBoxCollectionOption.SelectedValue = this.SelectedCollectionOptionId;

                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
                    foreach (var driverType in this.SelectedDriverTypes)
                    foreach (ListViewItem item in this.ListViewDrivers.Items)
                        if (new Guid(item.Tag.ToString()) == driverType)
                        {
                            item.Checked = true;
                            break;
                        }

                this.ComboBoxPackages.SelectedValue = this.SelectedDomain.Package.Id;
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}