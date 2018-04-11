// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDomainDetailsUserControl.cs" company="">
//   
// </copyright>
// <summary>
//   The project domain details user control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Common.Logging;
    using Configuration;
    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using System.Linq;
    using DotNetScaffolder.Mapping.ApplicationServices;

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
        ///     The application service.
        /// </summary>
        private IProjectDefinitionApplicationService applicationService;

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

            this.ComboBoxDriver.DisplayMember = "Text";
            this.ComboBoxDriver.ValueMember = "Value";
            this.ComboBoxDriver.DataSource = this.ReturnDriverTypes();

            this.ComboBoxCollectionOption.DisplayMember = "Text";
            this.ComboBoxCollectionOption.ValueMember = "Value";
            this.ComboBoxCollectionOption.DataSource = this.ReturnCollectionOptions();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the application service.
        /// </summary>
        public IProjectDefinitionApplicationService ApplicationService
        {
            get { return this.applicationService; }

            set
            {
                this.applicationService = value;

                if (this.Packages != null && this.Packages.Count > 0)
                {
                    Package selectedPackage = this.SelectedPackage;

                    this.ComboBoxPackages.DisplayMember = "Name";
                    this.ComboBoxPackages.ValueMember = "Id";
                    this.ComboBoxPackages.DataSource = this.Packages[0].ReturnPackageItems(this.Packages);
                    this.SelectedPackage = selectedPackage;
                }

                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
                {
                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the domain name.
        /// </summary>
        public string DomainName
        {
            get
            {
                string result = string.Empty;

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
                if (this.SelectedDomain != null)
                {
                    this.SelectedDomain.Name = value;
                }
                else
                {
                    Logger.Trace("DomainName is not set as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the packages.
        /// </summary>
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Gets or sets the selected collection option.
        /// </summary>
        public Guid SelectedCollectionOptionId
        {
            get
            {
                Guid result = Guid.Empty;

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
                if (this.SelectedDomain != null)
                {
                    this.SelectedDomain.CollectionOptionId = value;
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
            get { return this.selectedDomain; }

            set
            {
                this.selectedDomain = value;
                this.UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the selected driver.
        /// </summary>
        public Guid SelectedDriver
        {
            get
            {
                Guid result = Guid.Empty;

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.DriverId;
                    Logger.Trace($"DriverId set to {this.SelectedDomain.DriverId}.");
                }
                else
                {
                    Logger.Trace("Empty DriverId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null)
                {
                    this.SelectedDomain.DriverId = value;
                }
                else
                {
                    Logger.Trace("Empty DriverId is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected driver type.
        /// </summary>
        public Guid SelectedDriverType
        {
            get
            {
                Guid result = Guid.Empty;

                if (this.SelectedDomain != null)
                {
                    result = this.SelectedDomain.DriverTypeId;
                    Logger.Trace($"DriverTypeId set to {this.SelectedDomain.DriverTypeId}.");
                }
                else
                {
                    Logger.Trace("Empty DriverTypeId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (this.SelectedDomain != null)
                {
                    this.SelectedDomain.DriverTypeId = value;
                }
                else
                {
                    Logger.Trace("Empty DriverTypeId is returned as SelectedDomain is null.");
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
                Guid result = Guid.Empty;

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
                {
                    this.SelectedDomain.NamingConventionId = value;
                }
                else
                {
                    Logger.Trace("Empty NamingConventionId is returned as SelectedDomain is null.");
                }
            }
        }

        /// <summary>
        /// Gets or sets the selected package.
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
                if (this.SelectedDomain != null)
                {
                    this.SelectedDomain.Package = value;
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
                Guid result = Guid.Empty;

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
                if (this.SelectedDomain != null)
                {
                    this.SelectedDomain.SourceTypeId = value;
                }
                else
                {
                    Logger.Trace("Empty SourceTypeId is returned as SelectedDomain is null.");
                }
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     The return driver types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnDriverTypes()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (var driverType in ScaffoldConfig.Drivers)
            {
                items.Add(
                    new ComboboxItem
                    {
                        Text = (string) driverType.Metadata["TypeMetaData"],
                        Value = new Guid(driverType.Metadata["TypeIdMetaData"].ToString())
                    });
            }

            return items.ToArray();
        }

        /// <summary>
        /// The return driver types.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        /// <returns>
        /// The <see cref="object[]"/>.
        /// </returns>
        public object[] ReturnDriverTypes(ComboboxItem driver)
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (var driverType in ScaffoldConfig.Drivers)
            {
                if (driverType.Metadata["TypeIdMetaData"].ToString() == driver.Value.ToString().ToUpper())
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
        ///     Return naming conventions.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public object[] ReturnNamingConventions()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

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
            List<ComboboxItem> items = new List<ComboboxItem>();

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
        ///     The return collection options.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnCollectionOptions()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (var collectionOption in ScaffoldConfig.CollectionOptions)
            {
                items.Add(
                    new ComboboxItem
                    {
                        Text = (string) collectionOption.Metadata["NameMetaData"],
                        Value = new Guid(collectionOption.Metadata["ValueMetaData"].ToString())
                    });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        #endregion

        #region Other Methods

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
            {
                this.SelectedCollectionOptionId =
                    (Guid) (this.ComboBoxCollectionOption.SelectedItem as ComboboxItem).Value;
            }
        }

        /// <summary>
        /// The combo box driver_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedDriver = (Guid) (this.ComboBoxDriver.SelectedItem as ComboboxItem).Value;

            ComboboxItem item = this.ComboBoxDriver.SelectedItem as ComboboxItem;
            this.ComboBoxDriverType.DataSource = this.ReturnDriverTypes(item);
            this.ComboBoxDriverType.DisplayMember = "Text";
            this.ComboBoxDriverType.ValueMember = "Value";
        }

        /// <summary>
        /// The combo box driver type_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxDriverType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedDriverType = (Guid) (this.ComboBoxDriverType.SelectedItem as ComboboxItem).Value;
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
            this.SelectedNamingConvention = (Guid) (this.ComboBoxNamingConvention.SelectedItem as ComboboxItem).Value;
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
            this.SelectedSourceType = (Guid) (this.ComboBoxSourceType.SelectedItem as ComboboxItem).Value;
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
                {
                    this.ComboBoxNamingConvention.SelectedValue = this.SelectedNamingConvention;
                }

                if (this.SelectedSourceType != Guid.Empty)
                {
                    this.ComboBoxSourceType.SelectedValue = this.SelectedSourceType;
                }

                if (this.SelectedDriver != Guid.Empty)
                {
                    this.ComboBoxDriver.SelectedValue = this.SelectedDriver;
                }

                if (this.SelectedDriverType != Guid.Empty)
                {
                    this.ComboBoxDriverType.SelectedValue = this.SelectedDriverType;
                }

                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
                {
                    this.ComboBoxCollectionOption.SelectedValue = this.SelectedCollectionOptionId;
                }

                this.ComboBoxPackages.SelectedValue = this.SelectedDomain.Package.Id;
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        private void BtnManageSource_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Manage Source Clicked");
            ManageDataSourceForm manageDataSourceForm = new ManageDataSourceForm();
            manageDataSourceForm.DataSource = this.SelectedDomain;
            manageDataSourceForm.ShowDialog();
            Logger.Trace("Completed Manage Source Clicked");
        }

        #endregion
    }
}