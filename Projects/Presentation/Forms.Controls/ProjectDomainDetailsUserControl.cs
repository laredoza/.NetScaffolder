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
    using DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices;

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
                return this.applicationService;
            }

            set
            {
                this.applicationService = value;
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
        ///     Gets or sets the selected domain.
        /// </summary>
        public DomainDefinition SelectedDomain
        {
            get
            {
                return this.selectedDomain;
            }

            set
            {
                this.selectedDomain = value;
                this.UpdateDataSource();
            }
        }

        /// <summary>
        /// Gets or sets the selected driver.
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
        /// Gets or sets the selected driver type.
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
                if (this.SelectedDomain != null)
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
        /// Gets or sets the selected source type.
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

            return items.ToArray();
        }

        #endregion

        #region Other Methods

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
            this.SelectedDriver = (Guid)(this.ComboBoxDriver.SelectedItem as ComboboxItem).Value;

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
            this.SelectedDriverType = (Guid)(this.ComboBoxDriverType.SelectedItem as ComboboxItem).Value;
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
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            this.ComboBoxNamingConvention.DataSource = this.ReturnNamingConventions();
            this.ComboBoxNamingConvention.DisplayMember = "Text";
            this.ComboBoxNamingConvention.ValueMember = "Value";

            this.ComboBoxSourceType.DataSource = this.ReturnSourceTypes();
            this.ComboBoxSourceType.DisplayMember = "Text";
            this.ComboBoxSourceType.ValueMember = "Value";

            this.ComboBoxDriver.DataSource = this.ReturnDriverTypes();
            this.ComboBoxDriver.DisplayMember = "Text";
            this.ComboBoxDriver.ValueMember = "Value";

            if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
            {
                this.ComboBoxCollectionOption.DataSource = this.ApplicationService.ProjectDefinition.CollectionOptions;
                this.ComboBoxCollectionOption.DisplayMember = "Name";
                this.ComboBoxCollectionOption.ValueMember = "Name";
            }

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
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}