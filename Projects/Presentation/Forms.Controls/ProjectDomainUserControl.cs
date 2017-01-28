namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices;

    public partial class ProjectDomainUserControl : UserControl
    {
        /// <summary>
        /// Gets or sets a value indicating whether changed.
        /// </summary>
        public bool Changed { get; set; }

        /// <summary>
        /// The application service.
        /// </summary>
        private IProjectDefinitionApplicationService applicationService;

        /// <summary>
        /// Gets or sets the application service.
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
        /// The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            this.DomainsListBox.DataSource = null;

            if (!this.Changed)
            {
                if (this.ApplicationService != null && this.ApplicationService.ProjectDefinition != null && this.ApplicationService.ProjectDefinition.Domains != null)
                {
                    this.DomainsListBox.DataSource = this.ApplicationService.ProjectDefinition.Domains;
                    this.DomainsListBox.DisplayMember = "Name";
                    this.DomainsListBox.ValueMember = "Id";
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDomainUserControl"/> class.
        /// </summary>
        public ProjectDomainUserControl()
        {
            this.InitializeComponent();
        }
    }
}
