namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Project;

    public partial class ProjectDomainUserControl : UserControl
    {
        /// <summary>
        /// Gets or sets a value indicating whether changed.
        /// </summary>
        public bool Changed { get; set; }

        /// <summary>
        /// The project.
        /// </summary>
        private ProjectDefinition project;

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        public ProjectDefinition Project
        {
            get
            {
                return this.project;
            }
            set
            {
                this.project = value;

                if (!this.Changed)
                {
                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        /// The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (this.Project != null && this.Project.Domains != null)
            {
                this.DomainsListBox.DataSource = null;
                this.DomainsListBox.DataSource = this.project.Domains;
                this.DomainsListBox.DisplayMember = "Name";
                this.DomainsListBox.ValueMember = "Id";
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
