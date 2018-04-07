// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDomainUserControl.cs" company="">
//   
// </copyright>
// <summary>
//   The project domain user control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Using

    using System;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.ApplicationServices;

    #endregion

    /// <summary>
    ///     The project domain user control.
    /// </summary>
    public partial class ProjectDomainUserControl : UserControl
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

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDomainUserControl" /> class.
        /// </summary>
        public ProjectDomainUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Events

        /// <summary>
        /// The selected index changed.
        /// </summary>
        public event EventHandler<SelectedEventArgs> SelectedIndexChanged;

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
                this.DomainsListBox_SelectedIndexChanged(this, new EventArgs());
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether changed.
        /// </summary>
        public bool Changed { get; set; }

        /// <summary>
        ///     Gets a value indicating whether enable delete button.
        /// </summary>
        public bool EnableDeleteButton
        {
            get
            {
                bool result = false;

                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null)
                {
                    result = this.ApplicationService.ProjectDefinition.Domains.Count > 0;
                }

                return result;
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     The add domain.
        /// </summary>
        /// <returns>
        ///     The <see cref="DomainDefinition" />.
        /// </returns>
        public DomainDefinition AddDomain()
        {
            Logger.Trace("Started AddDomain()");

            DomainDefinition result = this.ApplicationService.AddDomain();
            this.UpdateDataSource();
            this.Changed = true;

            this.DomainsListBox.SelectedItem = result;
            Logger.Trace("Completed AddDomain()");

            return result;
        }

        /// <summary>
        /// The delete domain.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public void DeleteDomain(Guid id)
        {
            Logger.Trace($"Started DeleteDomain() - id: {id}");

            this.ApplicationService.Delete(id);
            this.UpdateDataSource();

            if (this.DomainsListBox.Items.Count > 0)
            {
                this.DomainsListBox.SelectedItem = this.DomainsListBox.Items[this.DomainsListBox.Items.Count - 1];
            }

            this.Changed = true;
            Logger.Trace($"Completed DeleteDomain() - id: {id}");
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The on selected index changed.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected virtual void OnSelectedIndexChanged(SelectedEventArgs e)
        {
            Logger.Trace($"Started OnSelectedIndexChanged() - Id:{e.Id}");

            EventHandler<SelectedEventArgs> handler = this.SelectedIndexChanged;

            if (handler != null)
            {
                handler(this, e);
            }

            Logger.Trace($"Completed OnSelectedIndexChanged() - Id:{e.Id}");
        }

        /// <summary>
        /// The button add_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Logger.Trace($"Started ButtonAdd_Click()");
            this.AddDomain();
            Logger.Trace($"Completed ButtonAdd_Click()");
        }

        /// <summary>
        /// The button delete_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started ButtonDelete_Click()");

            DomainDefinition definition = this.DomainsListBox.SelectedItem as DomainDefinition;

            if (definition != null)
            {
                this.DeleteDomain(definition.Id);
            }

            Logger.Trace($"Completed ButtonDelete_Click()");
        }

        /// <summary>
        /// The domains list box_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DomainsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Trace("Started DomainsListBox_SelectedIndexChanged event.");
            if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null
                && this.DomainsListBox.SelectedItem != null)
            {
                SelectedEventArgs eventArgs = new SelectedEventArgs
                {
                    Id =
                                                          (this.DomainsListBox.SelectedItem as
                                                           DomainDefinition).Id
                };
                this.OnSelectedIndexChanged(eventArgs);
            }

            Logger.Trace("Completed DomainsListBox_SelectedIndexChanged event.");
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            this.DomainsListBox.DataSource = null;
            {
                // if (!this.Changed)
                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null
                    && this.ApplicationService.ProjectDefinition.Domains != null)
                {
                    this.DomainsListBox.DataSource = this.ApplicationService.ProjectDefinition.Domains;
                    this.DomainsListBox.DisplayMember = "Name";
                    this.DomainsListBox.ValueMember = "Id";
                }
            }

            this.ButtonDelete.Enabled = this.EnableDeleteButton;

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion

        private void BtnTables_Click(object sender, EventArgs e)
        {
            DomainTableForm domainTableform = new DomainTableForm();

            if (this.DomainsListBox.SelectedItem != null)
            {
                domainTableform.DataSource = this.DomainsListBox.SelectedItem as DomainDefinition;
                domainTableform.ShowDialog();
            }
        }
    }
}