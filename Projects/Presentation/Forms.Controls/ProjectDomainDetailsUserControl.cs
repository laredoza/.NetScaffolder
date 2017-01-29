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
    /// The project domain details user control.
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
        /// The selected domain.
        /// </summary>
        private DomainDefinition selectedDomain;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDomainDetailsUserControl"/> class.
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
        /// Gets or sets the domain name.
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
            this.ComboBoxDriverType.Items.Clear();
            ComboboxItem item = this.ComboBoxDriver.SelectedItem as ComboboxItem;
            this.ComboBoxDriverType.Items.AddRange(this.ReturnDriverTypes(item));
        }

        /// <summary>
        /// The return driver types.
        /// </summary>
        /// <returns>
        /// The <see cref="object[]"/>.
        /// </returns>
        private object[] ReturnDriverTypes()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (var driverType in ScaffoldConfig.DriverTypes)
            {
                items.Add(
                    new ComboboxItem
                        {
                            Text = (string)driverType.Metadata["TypeMetaData"],
                            Value = new Guid(driverType.Metadata["ValueMetaData"].ToString())
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
        private object[] ReturnDriverTypes(ComboboxItem driver)
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (var driverType in ScaffoldConfig.DriverTypes)
            {
                if (driverType.Metadata["ValueMetaData"].ToString() == driver.Value.ToString().ToUpper())
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
        private object[] ReturnNamingConventions()
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
        /// The return source types.
        /// </summary>
        /// <returns>
        /// The <see cref="object[]"/>.
        /// </returns>
        private object[] ReturnSourceTypes()
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

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.SelectedDomain != null)
            {
                this.TextBoxName.Text = this.SelectedDomain.Name;
            }

            this.ComboBoxNamingConvention.Items.Clear();
            this.ComboBoxNamingConvention.Items.AddRange(this.ReturnNamingConventions());

            this.ComboBoxSourceType.Items.Clear();
            this.ComboBoxSourceType.Items.AddRange(this.ReturnSourceTypes());

            this.ComboBoxDriver.Items.Clear();
            this.ComboBoxDriver.Items.AddRange(this.ReturnDriverTypes());
            
            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}