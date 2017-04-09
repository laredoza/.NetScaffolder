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
    using System.Collections.Generic;
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
                                                                               FilePersistenceOptions = configOptions
                                                                           };

            applicationConfiguration.Load();

            //Package package = new Package { Id = Guid.NewGuid(), Name = "Packages", HierarchyType = HierarchyType.Group};
            //package.Children.Add(new Package { Id = Guid.NewGuid(), Name = "Data", HierarchyType = HierarchyType.Group });
            //package.Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Entity Framework Microsoft", HierarchyType = HierarchyType.Group });
            //package.Children[0].Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Entity Framework 6 (Standard)", HierarchyType = HierarchyType.Item });
            //package.Children[0].Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Entity Framework 6 (Repository)", HierarchyType = HierarchyType.Item });
            //package.Children[0].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Mongo Official", HierarchyType = HierarchyType.Group });
            //package.Children[0].Children[1].Children.Add(new Package { Id = Guid.NewGuid(), Name = "Mongo Official (Standard)", HierarchyType = HierarchyType.Item });
            //this.applicationConfiguration.ApplicationSettings.Packages.Add(package);
            //applicationConfiguration.Save();

            this.TemplateManagementUserControl1.DataSource = this.applicationConfiguration.ApplicationSettings.Templates[0];
            this.ManagePackageUserControl1.DataSource = this.applicationConfiguration.ApplicationSettings.Packages[0];

            if (applicationConfiguration.ApplicationSettings.Templates.Count > 0)
            {
                this.ManagePackageUserControl1.Templates =
                    applicationConfiguration.ApplicationSettings.Templates[0].ReturnTemplateItems();
            }

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