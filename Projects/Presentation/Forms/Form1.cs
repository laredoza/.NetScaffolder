// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms
{
    #region Usings

    using System;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Presentation.Forms.Controls;

    #endregion

    /// <summary>
    ///     The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Fields

        /// <summary>
        ///     The application service.
        /// </summary>
        private readonly IProjectDefinitionApplicationService applicationService;

        /// <summary>
        /// The application configuration.
        /// </summary>
        private readonly IConfigurationApplicationService applicationConfiguration;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Form1" /> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            FilePersistenceOptions options = new FilePersistenceOptions { Path = @"Models\Banking.mdl" };

            applicationService = new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };
            applicationService.Load();
            applicationService.ProjectDefinition.ModelPath = options.Path;
            applicationService.ProjectDefinition.Version = 1;

            FilePersistenceOptions configOptions = new FilePersistenceOptions { Path = @"Config\Settings.xml" };
            applicationConfiguration = new ConfigurationApplicationServiceFile
                                           {
                                               FilePersistenceOptions = configOptions
                                           };

            applicationConfiguration.Load();

            // Package package = new Package { Id = Guid.NewGuid(), Name = "Packages", HierarchyType = HierarchyType.Group};
            // package.Children.Add(new Package { Id = Guid.NewGuid(), Name = "Data", HierarchyType = HierarchyType.Group });
            // package.Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Entity Framework Microsoft", HierarchyType = HierarchyType.Group });
            // package.Children[0].Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Entity Framework 6 (Standard)", HierarchyType = HierarchyType.Item });
            // package.Children[0].Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Entity Framework 6 (Repository)", HierarchyType = HierarchyType.Item });
            // package.Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Mongo Official", HierarchyType = HierarchyType.Group });
            // package.Children[0].Children[1].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Mongo Official (Standard)", HierarchyType = HierarchyType.Item });
            // this.applicationConfiguration.ApplicationSettings.Packages.Add(package);
            // applicationConfiguration.Save();
            TemplateManagementUserControl1.DataSource = applicationConfiguration.ApplicationSettings.Templates[0];
            ManagePackageUserControl1.DataSource = applicationConfiguration.ApplicationSettings.Packages[0];

            if (applicationConfiguration.ApplicationSettings.Templates.Count > 0)
            {
                ManagePackageUserControl1.Templates = applicationConfiguration.ApplicationSettings.Templates;
            }

            ProjectDetailsUserControl1.Project = applicationService.ProjectDefinition;
            ProjectDomainUserControl1.SelectedIndexChanged += ProjectDomainUserControl1_SelectedIndexChanged;
            ProjectDomainUserControl1.ApplicationService = applicationService;
            projectDomainDetailsUserControl1.Packages = applicationConfiguration.ApplicationSettings.Packages;
            projectDomainDetailsUserControl1.ApplicationService = applicationService;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The button 1_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, $"Are you sure you want to close the application?{Environment.NewLine}Any unsaved changes will be lost...", "Are you sure?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

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
            if (ProjectDetailsUserControl1.Validation() == 0)
            {
                // Save
                applicationService.Save();
            }

            if (TemplateManagementUserControl1.Validation() == 0)
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
            if (applicationService.ProjectDefinition.Domains.Exists(d => d.Id == e.Id))
            {
                projectDomainDetailsUserControl1.SelectedDomain =
                    applicationService.ProjectDefinition.Domains.FirstOrDefault(d => d.Id == e.Id);
            }
        }

        #endregion
    }
}