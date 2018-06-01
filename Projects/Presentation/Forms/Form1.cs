﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms
{
    #region Usings

    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls;

    #endregion

    /// <summary>
    ///     The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        ///     The application configuration.
        /// </summary>
        private IConfigurationApplicationService applicationConfiguration;

        /// <summary>
        ///     The application service.
        /// </summary>
        private IProjectDefinitionApplicationService applicationService;

        /// <summary>
        ///     The model path.
        /// </summary>
        private string modelPath;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Form1" /> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();

            this.ModelPath = ScaffoldConfig.ModelPath;
            this.ConfigPath = ScaffoldConfig.ConfigPath;
            this.LoadData();
        }

        /// <summary>
        ///     Gets or sets the config path.
        /// </summary>
        public string ConfigPath { get; set; }

        /// <summary>
        ///     Gets or sets the model path.
        /// </summary>
        public string ModelPath
        {
            get
            {
                return this.modelPath;
            }

            set
            {
                if (this.modelPath != value)
                {
                    this.modelPath = value;
                    this.projectDomainDetailsUserControl1.SavePath = Path.GetDirectoryName(this.ModelPath);
                }
            }
        }

        /// <summary>
        /// The btn close_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                this,
                $"Are you sure you want to close the application?{Environment.NewLine}Any unsaved changes will be lost...",
                "Are you sure?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// The btn save_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.ProjectDetailsUserControl1.Validation() == 0)
            {
                // Save
                this.applicationService.Save();
            }

            if (this.TemplateManagementUserControl1.Validation() == 0)
            {
                this.applicationConfiguration.Save();
            }
        }

        /// <summary>
        ///     The load data.
        /// </summary>
        private void LoadData()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.ModelPath) && !string.IsNullOrEmpty(this.ConfigPath))
                {
                    FilePersistenceOptions options = new FilePersistenceOptions { Path = this.ModelPath };

                    this.applicationService =
                        new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };
                    this.applicationService.Load();
                    this.applicationService.ProjectDefinition.ModelPath = options.Path;
                    this.applicationService.ProjectDefinition.Version = 1;

                    FilePersistenceOptions configOptions = new FilePersistenceOptions { Path = this.ConfigPath };
                    this.applicationConfiguration =
                        new ConfigurationApplicationServiceFile { FilePersistenceOptions = configOptions };

                    this.applicationConfiguration.Load();

                    this.TemplateManagementUserControl1.DataSource =
                        this.applicationConfiguration.ApplicationSettings.Templates[0];

                    if (this.applicationService.ProjectDefinition.Domains.Count > 0)
                    {
                        this.packageUserControl1.SelectedPackage =
                            this.applicationService.ProjectDefinition.Domains[0].Package;
                        this.packageUserControl1.DataSource =
                            this.applicationConfiguration.ApplicationSettings.Packages[0];
                    }

                    if (this.applicationConfiguration.ApplicationSettings.Templates.Count > 0)
                    {
                        this.packageUserControl1.Templates =
                            this.applicationConfiguration.ApplicationSettings.Templates;
                    }

                    this.ProjectDetailsUserControl1.Project = this.applicationService.ProjectDefinition;
                    this.ProjectDomainUserControl1.SelectedIndexChanged +=
                        this.ProjectDomainUserControl1_SelectedIndexChanged;
                    this.ProjectDomainUserControl1.ApplicationService = this.applicationService;
                    this.projectDomainDetailsUserControl1.Packages =
                        this.applicationConfiguration.ApplicationSettings.Packages;
                    this.projectDomainDetailsUserControl1.ApplicationService = this.applicationService;
                    this.tabControl1.Enabled = true;
                    this.BtnSave.Enabled = true;
                    this.LblPath.Text = this.ModelPath;
                }
                else
                {
                    this.tabControl1.Enabled = false;
                    this.BtnSave.Enabled = false;
                    this.LblPath.Text = "No Model File Loaded";
                }
            }
            catch (Exception ex)
            {
                this.tabControl1.Enabled = false;
                this.BtnSave.Enabled = false;
                this.LblPath.Text = "Model file does not exist!";
            }
        }

        /// <summary>
        /// The open tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool displayDialog = false;

            if (!string.IsNullOrEmpty(this.ModelPath))
            {
                var result = MessageBox.Show(
                    this,
                    $"Are you sure you want to open a new model file?{Environment.NewLine}Any unsaved changes will be lost...",
                    "Are you sure?",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    displayDialog = true;
                }
            }
            else
            {
                displayDialog = true;
            }

            if (displayDialog && this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ModelPath = this.openFileDialog1.FileName;
                this.LoadData();
            }
        }

        /// <summary>
        /// The project domain index changed.
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

                this.packageUserControl1.SelectedPackage = this.projectDomainDetailsUserControl1.SelectedDomain.Package;

                if (this.projectDomainDetailsUserControl1.SelectedDomain.Package != null)
                {
                    var settingsPackageHierarchy = this.applicationConfiguration.ApplicationSettings.Packages[0]
                        .Find(this.projectDomainDetailsUserControl1.SelectedDomain.Package.Id);

                    var settingsPackage = settingsPackageHierarchy as Package;

                    if (settingsPackage != null)
                    {
                        this.projectDomainDetailsUserControl1.ConfigPackage = settingsPackage;

                        if (settingsPackage.Templates.Count != this.projectDomainDetailsUserControl1.SelectedDomain
                                .Package.Templates.Count)
                        {
                            // Todo: Better comparison
                            this.projectDomainDetailsUserControl1.UpdatePackageVisible = true;
                        }
                        else
                        {
                            this.projectDomainDetailsUserControl1.UpdatePackageVisible = false;
                        }
                    }
                    else
                    {
                        this.projectDomainDetailsUserControl1.UpdatePackageVisible = false;
                    }
                }
            }
        }
    }
}