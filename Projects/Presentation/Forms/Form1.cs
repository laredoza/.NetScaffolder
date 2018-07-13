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
        #region Fields

        /// <summary>
        ///     The application configuration.
        /// </summary>
        private IConfigurationApplicationService applicationConfiguration;

        /// <summary>
        ///     The application service.
        /// </summary>
        private IProjectDefinitionApplicationService projectApplicationService;

        /// <summary>
        ///     The model path.
        /// </summary>
        private string modelPath;

        #endregion

        #region Constructors and Destructors

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

        #endregion

        #region Public Properties

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

        #endregion

        #region Other Methods

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
                try
                {
                    this.projectApplicationService.Save();

                    if (this.TemplateManagementUserControl1.Validation() == 0)
                    {
                        try
                        {
                            this.applicationConfiguration.Save();

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

        /// <summary>
        ///     ProjectDefinition
        ///     The load data.
        /// </summary>
        private void LoadData()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.ModelPath) && !string.IsNullOrEmpty(this.ConfigPath))
                {
                    FilePersistenceOptions options = new FilePersistenceOptions { Path = this.ModelPath };

                    this.projectApplicationService =
                        new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };
                    this.projectApplicationService.Load();
                    this.projectApplicationService.ProjectDefinition.ModelPath = options.Path;
                    this.projectApplicationService.ProjectDefinition.Version = 1;

                    FilePersistenceOptions configOptions = new FilePersistenceOptions { Path = this.ConfigPath };
                    this.applicationConfiguration =
                        new ConfigurationApplicationServiceFile { FilePersistenceOptions = configOptions };

                    this.applicationConfiguration.Load();

                    this.TemplateManagementUserControl1.DataSource =
                        this.applicationConfiguration.ApplicationSettings.Templates[0];

                    if (this.projectApplicationService.ProjectDefinition.Domains.Count > 0)
                    {
                        // By default use the first domain
                        this.packageUserControl1.SelectedPackage =
                            this.projectApplicationService.ProjectDefinition.Domains[0].Package;
                        this.packageUserControl1.DataSource =
                            this.applicationConfiguration.ApplicationSettings.Packages[0];
                        this.packageUserControl1.DomainDefinition =
                            this.projectApplicationService.ProjectDefinition.Domains[0];
                    }

                    if (this.applicationConfiguration.ApplicationSettings.Templates.Count > 0)
                    {
                        this.packageUserControl1.Templates =
                            this.applicationConfiguration.ApplicationSettings.Templates;
                    }

                    this.TemplateManagementUserControl1.ProjectDefinition = this.projectApplicationService.ProjectDefinition;
                    this.TemplateManagementUserControl1.Packages = this.applicationConfiguration.ApplicationSettings
                        .Packages[0].ReturnPackageItems();

                    this.ProjectDetailsUserControl1.Project = this.projectApplicationService.ProjectDefinition;
                    this.ProjectDomainUserControl1.SelectedIndexChanged +=
                        this.ProjectDomainUserControl1_SelectedIndexChanged;
                    this.ProjectDomainUserControl1.ApplicationService = this.projectApplicationService;
                    this.projectDomainDetailsUserControl1.Packages =
                        this.applicationConfiguration.ApplicationSettings.Packages;
                    this.projectDomainDetailsUserControl1.ApplicationService = this.projectApplicationService;
                    this.projectDomainDetailsUserControl1.ProjectDomainUserControl = this.ProjectDomainUserControl1;

                    this.tabControl1.Enabled = true;
                    this.BtnSave.Enabled = true;
                    this.LblPath.Text = this.ModelPath;
                }
                else
                {
                    this.tabControl1.Enabled = false;
                    this.BtnSave.Enabled = false;
                    this.LblPath.Text = "No Model File Loading";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (this.projectApplicationService.ProjectDefinition.Domains.Exists(d => d.Id == e.Id))
            {
                this.projectDomainDetailsUserControl1.SelectedDomain =
                    this.projectApplicationService.ProjectDefinition.Domains.FirstOrDefault(d => d.Id == e.Id);

                // Update Domain info for packages
                this.packageUserControl1.DomainDefinition = this.projectDomainDetailsUserControl1.SelectedDomain;
                this.packageUserControl1.SelectedPackage = this.projectDomainDetailsUserControl1.SelectedDomain.Package;

                this.TemplateManagementUserControl1.SelectedPackage = this.projectDomainDetailsUserControl1.SelectedDomain.Package;

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

        /// <summary>
        /// The tab control 1_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            if (tabControl.SelectedIndex == 0)
            {
                this.projectDomainDetailsUserControl1.Loading = false;
                this.projectDomainDetailsUserControl1.UpdateDomainPackages();
            }
        }

        #endregion
    }
}