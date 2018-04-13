// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDomainDetailsUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

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
            InitializeComponent();

            ComboBoxNamingConvention.DisplayMember = "Text";
            ComboBoxNamingConvention.ValueMember = "Value";
            ComboBoxNamingConvention.DataSource = ReturnNamingConventions();

            ComboBoxSourceType.DisplayMember = "Text";
            ComboBoxSourceType.ValueMember = "Value";
            ComboBoxSourceType.DataSource = ReturnSourceTypes();

            ComboBoxDriver.DisplayMember = "Text";
            ComboBoxDriver.ValueMember = "Value";
            ComboBoxDriver.DataSource = ReturnDriverTypes();

            ComboBoxCollectionOption.DisplayMember = "Text";
            ComboBoxCollectionOption.ValueMember = "Value";
            ComboBoxCollectionOption.DataSource = ReturnCollectionOptions();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the application service.
        /// </summary>
        public IProjectDefinitionApplicationService ApplicationService
        {
            get
            {
                return applicationService;
            }

            set
            {
                applicationService = value;

                if (Packages != null && Packages.Count > 0)
                {
                    Package selectedPackage = SelectedPackage;

                    ComboBoxPackages.DisplayMember = "Name";
                    ComboBoxPackages.ValueMember = "Id";
                    ComboBoxPackages.DataSource = Packages[0].ReturnPackageItems(Packages);
                    SelectedPackage = selectedPackage;
                }

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null)
                {
                    UpdateDataSource();
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
                if (SelectedDomain != null)
                {
                    SelectedDomain.Name = value;
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
        ///     Gets or sets the selected collection option.
        /// </summary>
        public Guid SelectedCollectionOptionId
        {
            get
            {
                Guid result = Guid.Empty;

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
            get
            {
                return selectedDomain;
            }

            set
            {
                selectedDomain = value;
                UpdateDataSource();
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

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.DriverId;
                    Logger.Trace($"DriverId set to {SelectedDomain.DriverId}.");
                }
                else
                {
                    Logger.Trace("Empty DriverId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null)
                {
                    SelectedDomain.DriverId = value;
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

                if (SelectedDomain != null)
                {
                    result = SelectedDomain.DriverTypeId;
                    Logger.Trace($"DriverTypeId set to {SelectedDomain.DriverTypeId}.");
                }
                else
                {
                    Logger.Trace("Empty DriverTypeId is returned as SelectedDomain is null.");
                }

                return result;
            }

            set
            {
                if (SelectedDomain != null)
                {
                    SelectedDomain.DriverTypeId = value;
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
                Guid result = Guid.Empty;

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

        #endregion

        #region Public methods and operators

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
                            Text = (string)collectionOption.Metadata["NameMetaData"],
                            Value = new Guid(collectionOption.Metadata["ValueMetaData"].ToString())
                        });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

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
                            Text = (string)driverType.Metadata["TypeMetaData"],
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
                                Text = (string)driverType.Metadata["NameMetaData"],
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
                            Text = (string)namingConvention.Metadata["NameMetaData"],
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
                            Text = (string)sourceType.Metadata["NameMetaData"],
                            Value = new Guid(sourceType.Metadata["ValueMetaData"].ToString())
                        });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        #endregion

        #region Other Methods

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
            ManageDataSourceForm manageDataSourceForm = new ManageDataSourceForm();
            manageDataSourceForm.DataSource = SelectedDomain;
            manageDataSourceForm.ShowDialog();
            Logger.Trace("Completed Manage Source Clicked");
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
            if (ComboBoxCollectionOption.SelectedItem != null)
            {
                SelectedCollectionOptionId =
                    (Guid)(ComboBoxCollectionOption.SelectedItem as ComboboxItem).Value;
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
            SelectedDriver = (Guid)(ComboBoxDriver.SelectedItem as ComboboxItem).Value;

            ComboboxItem item = ComboBoxDriver.SelectedItem as ComboboxItem;
            ComboBoxDriverType.DataSource = ReturnDriverTypes(item);
            ComboBoxDriverType.DisplayMember = "Text";
            ComboBoxDriverType.ValueMember = "Value";
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
            SelectedDriverType = (Guid)(ComboBoxDriverType.SelectedItem as ComboboxItem).Value;
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
            SelectedNamingConvention = (Guid)(ComboBoxNamingConvention.SelectedItem as ComboboxItem).Value;
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
            SelectedPackage = ComboBoxPackages.SelectedItem as Package;
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
            SelectedSourceType = (Guid)(ComboBoxSourceType.SelectedItem as ComboboxItem).Value;
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (SelectedDomain != null)
            {
                TextBoxName.Text = SelectedDomain.Name;
                if (SelectedNamingConvention != Guid.Empty)
                {
                    ComboBoxNamingConvention.SelectedValue = SelectedNamingConvention;
                }

                if (SelectedSourceType != Guid.Empty)
                {
                    ComboBoxSourceType.SelectedValue = SelectedSourceType;
                }

                if (SelectedDriver != Guid.Empty)
                {
                    ComboBoxDriver.SelectedValue = SelectedDriver;
                }

                if (SelectedDriverType != Guid.Empty)
                {
                    ComboBoxDriverType.SelectedValue = SelectedDriverType;
                }

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null)
                {
                    ComboBoxCollectionOption.SelectedValue = SelectedCollectionOptionId;
                }

                ComboBoxPackages.SelectedValue = SelectedDomain.Package.Id;
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}