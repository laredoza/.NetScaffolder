#region Usings

using System;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Mapping.ApplicationServices;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Presentation.Forms.Controls.Project.DataType;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
    #region Usings

    #endregion

    /// <inheritdoc />
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

        private bool loading;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDomainUserControl" /> class.
        /// </summary>
        public ProjectDomainUserControl()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        ///     The selected index changed.
        /// </summary>
        public event EventHandler<SelectedEventArgs> SelectedIndexChanged;

        #region Public Properties

        /// <summary>
        ///     Gets or sets the application service.
        /// </summary>
        public IProjectDefinitionApplicationService ApplicationService
        {
            get { return applicationService; }

            set
            {
                applicationService = value;
                UpdateDataSource();
                DomainsListBox_SelectedIndexChanged(this, new EventArgs());
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

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null)
                {
                    result = ApplicationService.ProjectDefinition.Domains.Count > 0;
                }

                return result;
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The add domain.
        /// </summary>
        /// <returns>
        ///     The <see cref="DomainDefinition" />.
        /// </returns>
        public DomainDefinition AddDomain()
        {
            Logger.Trace("Started AddDomain()");

            DomainDefinition result = ApplicationService.AddDomain();
            UpdateDataSource();
            Changed = true;

            DomainsListBox.SelectedItem = result;
            Logger.Trace("Completed AddDomain()");

            return result;
        }

        /// <summary>
        ///     The delete domain.
        /// </summary>
        /// <param name="id">
        ///     The id.
        /// </param>
        public void DeleteDomain(Guid id)
        {
            Logger.Trace($"Started DeleteDomain() - id: {id}");

            ApplicationService.Delete(id);
            UpdateDataSource();

            if (DomainsListBox.Items.Count > 0)
            {
                DomainsListBox.SelectedItem = DomainsListBox.Items[DomainsListBox.Items.Count - 1];
            }

            Changed = true;
            Logger.Trace($"Completed DeleteDomain() - id: {id}");
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The on selected index changed.
        /// </summary>
        /// <param name="e">
        ///     The e.
        /// </param>
        protected virtual void OnSelectedIndexChanged(SelectedEventArgs e)
        {
            if (!loading)
            {
                EventHandler<SelectedEventArgs> handler = SelectedIndexChanged;

                if (handler != null)
                {
                    handler(this, e);
                }
            }
        }

        /// <summary>
        ///     The btn tables_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>

        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnTables_Click(object sender, EventArgs e)
        {
            DomainModelForm domainTableform = new DomainModelForm();

            if (DomainsListBox.SelectedItem != null)
            {
                domainTableform.OutputFolder = ApplicationService.ProjectDefinition.OutputPath;
                domainTableform.DataSource = DomainsListBox.SelectedItem as DomainDefinition;
                domainTableform.ShowDialog();
            }
        }

        /// <summary>
        ///     The button add_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Logger.Trace($"Started ButtonAdd_Click()");
            AddDomain();
            Logger.Trace($"Completed ButtonAdd_Click()");
        }

        /// <summary>
        ///     The button delete_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started ButtonDelete_Click()");

            DomainDefinition definition = DomainsListBox.SelectedItem as DomainDefinition;

            if (definition != null)
            {
                DeleteDomain(definition.Id);
            }

            Logger.Trace($"Completed ButtonDelete_Click()");
        }

        /// <summary>
        ///     The domains list box_ selected index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void DomainsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                if (ApplicationService != null && ApplicationService.ProjectDefinition != null
                                               && DomainsListBox.SelectedItem != null)
                {
                    SelectedEventArgs eventArgs =
                        new SelectedEventArgs {Id = (DomainsListBox.SelectedItem as DomainDefinition).Id};
                    OnSelectedIndexChanged(eventArgs);
                }
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            DomainsListBox.DataSource = null;
            {
                loading = true;

                if (ApplicationService != null && ApplicationService.ProjectDefinition != null
                                               && ApplicationService.ProjectDefinition.Domains != null)
                {
                    DomainsListBox.DataSource = ApplicationService.ProjectDefinition.Domains;
                    DomainsListBox.DisplayMember = "Name";
                    DomainsListBox.ValueMember = "Id";
                }

                loading = false;
            }

            ButtonDelete.Enabled = EnableDeleteButton;

            Logger.Trace("Completed UpdateDataSource()");
        }

        public void UpdateselectedDomainName(string name)
        {
            DomainDefinition definition = this.DomainsListBox.SelectedItem as DomainDefinition;

            DomainsListBox.DataSource = null;

            DomainsListBox.DataSource = ApplicationService.ProjectDefinition.Domains;
            DomainsListBox.DisplayMember = "Name";
            DomainsListBox.ValueMember = "Id";

            this.DomainsListBox.SelectedItem = definition;
            //definition.Name = name;
        }

        #endregion
    }
}