// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//   
// </copyright>
// <summary>
//   The form 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms
{
    #region Using

    using System;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Application.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls;

    using FormControls.Enum;
    using FormControls.TreeView;

    #endregion

    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Fields

        /// <summary>
        /// The application service.
        /// </summary>
        private readonly IProjectDefinitionApplicationService applicationService;

        private IConfigurationAplicationService applicationConfiguration;

        /// <summary>
        /// The configuration service.
        /// </summary>
        private IConfigurationAplicationService configurationService;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            FilePersistenceOptions options = new FilePersistenceOptions { Path = @"Models\Banking.mdl" };

            this.applicationService = new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };

            this.applicationService.Load();

            FilePersistenceOptions configOptions = new FilePersistenceOptions { Path = @"Config\Settings.xml" };

            applicationConfiguration = new ConfigurationAplicationServiceFile
                                                                           {
                                                                               FilePersistenceOptions
                                                                                   =
                                                                                   configOptions
                                                                           };

            applicationConfiguration.Load();

            this.TemplateManagementUserControl1.DataSource =
                applicationConfiguration.ApplicationSettings.Templates[0];

            this.ProjectDetailsUserControl1.Project = this.applicationService.ProjectDefinition;
            this.ProjectDomainUserControl1.SelectedIndexChanged += this.ProjectDomainUserControl1_SelectedIndexChanged;
            this.ProjectDomainUserControl1.ApplicationService = this.applicationService;
            this.projectDomainDetailsUserControl1.ApplicationService = this.applicationService;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The button 6_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.ProjectDetailsUserControl1.Validation() == 0)
            {
                // Save
                this.applicationService.Save();
            }

            if (this.TemplateManagementUserControl1.Validation() == 0)
            {
                applicationConfiguration.Save();
            }
        }

        /// <summary>
        /// The project domain user control 1_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ProjectDomainUserControl1_SelectedIndexChanged(object sender, SelectedEventArgs e)
        {
            // Todo: Check Changed Status before changing 
            if (this.applicationService.ProjectDefinition.Domains.Exists(d => d.Id == e.Id))
            {
                this.projectDomainDetailsUserControl1.SelectedDomain =
                    this.applicationService.ProjectDefinition.Domains.FirstOrDefault(d => d.Id == e.Id);
            }
        }

        #endregion
    }
}