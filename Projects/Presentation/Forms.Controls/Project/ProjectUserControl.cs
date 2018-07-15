#region Usings

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DotNetScaffolder.Core.Configuration;
using DotNetScaffolder.Mapping.ApplicationServices;
using DotNetScaffolder.Mapping.MetaData.Project;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;
using DotNetScaffolder.Presentation.Forms.Controls.Packages;
using DotNetScaffolder.Presentation.Forms.Controls.Templates;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
    public partial class ProjectUserControl : UserControl
    {
        #region Fields

        /// <summary>
        ///     The application configuration.
        /// </summary>
        private IConfigurationApplicationService applicationConfiguration;

        /// <summary>
        ///     The model path.
        /// </summary>
        private string modelPath;

        /// <summary>
        ///     The application service.
        /// </summary>
        private IProjectDefinitionApplicationService projectApplicationService;

        #endregion

        #region Constructors and Destructors

        public ProjectUserControl()
        {
            InitializeComponent();

            ModelPath = ScaffoldConfig.ModelPath;
            ConfigPath = ScaffoldConfig.ConfigPath;
            //LoadProjects();
        }

        #endregion

        #region Public Properties

        public Button BtnSave { get; set; }

        /// <summary>
        ///     Gets or sets the config path.
        /// </summary>
        public string ConfigPath { get; set; }

        public Label LabelPath { get; set; }

        /// <summary>
        ///     Gets or sets the model path.
        /// </summary>
        public string ModelPath
        {
            get { return modelPath; }

            set
            {
                if (modelPath != value)
                {
                    modelPath = value;
                    projectDomainDetailsUserControl1.SavePath = Path.GetDirectoryName(ModelPath);
                }
            }
        }

        public PackageUserControl PackageUserControl { get; set; }

        public ProjectDomainDetailsUserControl ProjectDomainDetailsUserControl
        {
            get { return projectDomainDetailsUserControl1; }
        }

        public TabControl TabControl { get; set; }

        public TemplateManagementUserControl TemplateManagementUserControl { get; set; }

        #endregion

        #region Public Methods And Operators

        public void LoadProjects()
        {
            try
            {
                if (!string.IsNullOrEmpty(ModelPath) && !string.IsNullOrEmpty(ConfigPath))
                {
                    FilePersistenceOptions options = new FilePersistenceOptions {Path = ModelPath};

                    projectApplicationService =
                        new ProjectDefinitionApplicationServiceFile {FilePersistenceOptions = options};
                    projectApplicationService.Load();
                    projectApplicationService.ProjectDefinition.ModelPath = options.Path;
                    projectApplicationService.ProjectDefinition.Version = 1;

                    FilePersistenceOptions configOptions = new FilePersistenceOptions {Path = ConfigPath};
                    applicationConfiguration =
                        new ConfigurationApplicationServiceFile {FilePersistenceOptions = configOptions};

                    applicationConfiguration.Load();

                    TemplateManagementUserControl.DataSource =
                        applicationConfiguration.ApplicationSettings.Templates[0];

                    if (projectApplicationService.ProjectDefinition.Domains.Count > 0)
                    {
                        // By default use the first domain
                        PackageUserControl.SelectedPackage =
                            projectApplicationService.ProjectDefinition.Domains[0].Package;
                        PackageUserControl.DataSource =
                            applicationConfiguration.ApplicationSettings.Packages[0];
                        PackageUserControl.DomainDefinition =
                            projectApplicationService.ProjectDefinition.Domains[0];
                    }

                    if (applicationConfiguration.ApplicationSettings.Templates.Count > 0)
                    {
                        PackageUserControl.Templates =
                            applicationConfiguration.ApplicationSettings.Templates;
                    }

                    TemplateManagementUserControl.ProjectDefinition = projectApplicationService.ProjectDefinition;
                    TemplateManagementUserControl.Packages = applicationConfiguration.ApplicationSettings
                        .Packages[0].ReturnPackageItems();

                    ProjectDetailsUserControl1.Project = projectApplicationService.ProjectDefinition;
                    ProjectDomainUserControl1.SelectedIndexChanged +=
                        ProjectDomainUserControl1_SelectedIndexChanged;
                    ProjectDomainUserControl1.ApplicationService = projectApplicationService;
                    projectDomainDetailsUserControl1.Packages =
                        applicationConfiguration.ApplicationSettings.Packages;
                    projectDomainDetailsUserControl1.ApplicationService = projectApplicationService;
                    projectDomainDetailsUserControl1.ProjectDomainUserControl = ProjectDomainUserControl1;

                    TabControl.Enabled = true;
                    BtnSave.Enabled = true;
                    LabelPath.Text = ModelPath;
                }
                else
                {
                    TabControl.Enabled = false;
                    BtnSave.Enabled = false;
                    LabelPath.Text = "No Model File Loading";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabControl.Enabled = false;
                BtnSave.Enabled = false;
                LabelPath.Text = "Model file does not exist!";
            }
        }

        public void SaveProjects()
        {
            if (ProjectDetailsUserControl1.Validation() == 0)
            {
                // Save
                try
                {
                    projectApplicationService.Save();

                    if (TemplateManagementUserControl.Validation() == 0)
                    {
                        try
                        {
                            applicationConfiguration.Save();

                            MessageBox.Show(
                                $"Saved Data",
                                "Failed Saving Application Settings",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(
                                $"Error Details:{exception.Message}",
                                "Failed Saving Application Settings",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "There are failed validation errors",
                            "Failed Saving Application Settings",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Error Details:{exception.Message}",
                        "Failed Saving Project Settings",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "There are failed validation errors",
                    "Failed Saving Project Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The project domain index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ProjectDomainUserControl1_SelectedIndexChanged(object sender, SelectedEventArgs e)
        {
            // Todo: Check Changed Status before changing 
            if (projectApplicationService.ProjectDefinition.Domains.Exists(d => d.Id == e.Id))
            {
                projectDomainDetailsUserControl1.SelectedDomain =
                    projectApplicationService.ProjectDefinition.Domains.FirstOrDefault(d => d.Id == e.Id);

                // Update Domain info for packages
                PackageUserControl.DomainDefinition = projectDomainDetailsUserControl1.SelectedDomain;
                PackageUserControl.SelectedPackage = projectDomainDetailsUserControl1.SelectedDomain.Package;

                TemplateManagementUserControl.SelectedPackage = projectDomainDetailsUserControl1.SelectedDomain.Package;

                if (projectDomainDetailsUserControl1.SelectedDomain.Package != null)
                {
                    var settingsPackageHierarchy = applicationConfiguration.ApplicationSettings.Packages[0]
                        .Find(projectDomainDetailsUserControl1.SelectedDomain.Package.Id);

                    var settingsPackage = settingsPackageHierarchy as Package;

                    if (settingsPackage != null)
                    {
                        projectDomainDetailsUserControl1.ConfigPackage = settingsPackage;

                        if (settingsPackage.Templates.Count != projectDomainDetailsUserControl1.SelectedDomain
                                .Package.Templates.Count)
                        {
                            // Todo: Better comparison
                            projectDomainDetailsUserControl1.UpdatePackageVisible = true;
                        }
                        else
                        {
                            projectDomainDetailsUserControl1.UpdatePackageVisible = false;
                        }
                    }
                    else
                    {
                        projectDomainDetailsUserControl1.UpdatePackageVisible = false;
                    }
                }
            }
        }

        #endregion
    }
}