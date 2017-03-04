namespace DotNetScaffolder.Presentation.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Configuration;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices;
    using DotNetScaffolder.Presentation.Forms.Controls;
    using DotNetScaffolder.Mapping.MetaData.Application.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.TreeView;

    public partial class Form1 : Form
    {
        private IProjectDefinitionApplicationService applicationService;
        private IConfigurationAplicationService configurationService;

        public Form1()
        {
            this.InitializeComponent();
            FilePersistenceOptions options = new FilePersistenceOptions { Path = @"Models\Banking.mdl" };

            applicationService = new ProjectDefinitionApplicationServiceFile
            {
                FilePersistenceOptions = options
            };
            
            applicationService.Load();

            FilePersistenceOptions configOptions = new FilePersistenceOptions { Path = @"Config\Settings.xml" };

            IConfigurationAplicationService applicationConfiguration = new ConfigurationAplicationServiceFile
            {
                FilePersistenceOptions = configOptions
            };

            Template baseTemplate = new Template
                                        {
                                            Name = "Templates",
                                            GeneratorTypeId = Guid.NewGuid(),
                                            LanguageOutputId = Guid.NewGuid(),
                                            Id = Guid.NewGuid(),
                                            TemplatePath = "Bogus.T4",
                                            Version = 1,
                                            DataType = { Id = Guid.NewGuid(), Name = "Test" }
                                        };

            applicationConfiguration.ApplicationSettings.Templates.Add(baseTemplate);

            applicationConfiguration.ApplicationSettings.Templates[0].Children.Add(
                new Template
                    {
                        Name = "Context",
                        GeneratorTypeId = Guid.NewGuid(),
                        LanguageOutputId = Guid.NewGuid(),
                        Id = Guid.NewGuid(),
                        TemplatePath = "Bogus.T4",
                        Version = 1,
                        DataType = { Id = Guid.NewGuid(), Name = "Test" }
                    });

            applicationConfiguration.ApplicationSettings.Templates[0].Children[0].Children.Add(
                new Template
                {
                    Name = "Entity Framework Context (v6)",
                    GeneratorTypeId = Guid.NewGuid(),
                    LanguageOutputId = Guid.NewGuid(),
                    Id = Guid.NewGuid(),
                    TemplatePath = "Bogus.T4",
                    Version = 1,
                    DataType = { Id = Guid.NewGuid(), Name = "Test" }
                });

            applicationConfiguration.ApplicationSettings.Templates[0].Children.Add(
                new Template
                {
                    Name = "Entity",
                    GeneratorTypeId = Guid.NewGuid(),
                    LanguageOutputId = Guid.NewGuid(),
                    Id = Guid.NewGuid(),
                    TemplatePath = "Bogus.T4",
                    Version = 1,
                    DataType = { Id = Guid.NewGuid(), Name = "Test" }
                });

            applicationConfiguration.ApplicationSettings.Templates[0].Children[1].Children.Add(
                new Template
                {
                    Name = "Entity Framework Entity (v6)",
                    GeneratorTypeId = Guid.NewGuid(),
                    LanguageOutputId = Guid.NewGuid(),
                    Id = Guid.NewGuid(),
                    TemplatePath = "Bogus.T4",
                    Version = 1,
                    DataType = { Id = Guid.NewGuid(), Name = "Test" }
                });

            //manageCollectionsTreeViewUserControl1.DataSource = baseTemplate;

            //applicationConfiguration.Save();
            applicationConfiguration.Load();

            manageCollectionsTreeViewUserControl1.DataSource = applicationConfiguration.ApplicationSettings.Templates[0];

            this.ProjectDetailsUserControl1.Project = this.applicationService.ProjectDefinition;
            this.ProjectDomainUserControl1.SelectedIndexChanged += this.ProjectDomainUserControl1_SelectedIndexChanged;
            this.ProjectDomainUserControl1.ApplicationService = this.applicationService;
            this.projectDomainDetailsUserControl1.ApplicationService = this.applicationService;
        }

        private void ProjectDomainUserControl1_SelectedIndexChanged(object sender, SelectedEventArgs e)
        {
            // Todo: Check Changed Status before changing 
            if (this.applicationService.ProjectDefinition.Domains.Exists(d => d.Id == e.Id))
            {
                this.projectDomainDetailsUserControl1.SelectedDomain =
                    this.applicationService.ProjectDefinition.Domains.FirstOrDefault(d => d.Id == e.Id);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.ProjectDetailsUserControl1.Validation() == 0)
            {
                // Save
                this.applicationService.Save();
            }
        }
    }
}
