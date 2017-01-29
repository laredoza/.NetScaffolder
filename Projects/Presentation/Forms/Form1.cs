﻿namespace DotNetScaffolder.Presentation.Forms
{
    using System;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices;
    using DotNetScaffolder.Presentation.Forms.Controls;

    public partial class Form1 : Form
    {
        private IProjectDefinitionApplicationService applicationService;

        public Form1()
        {
            this.InitializeComponent();

            FilePersistenceOptions options = new FilePersistenceOptions { Path = @"Config\Banking.mdl" };

            applicationService = new ProjectDefinitionApplicationServiceFile
            {
                FilePersistenceOptions = options
            };
            
            applicationService.Load();

            this.ProjectDetailsUserControl1.Project = applicationService.ProjectDefinition;
            this.ProjectDomainUserControl1.ApplicationService = this.applicationService;
            this.ProjectDomainUserControl1.SelectedIndexChanged += ProjectDomainUserControl1_SelectedIndexChanged;
        }

        private void ProjectDomainUserControl1_SelectedIndexChanged(object sender, SelectedEventArgs e)
        {
            Guid a = e.Id;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.ProjectDetailsUserControl1.Validation() == 0)
            {
                // Save
                applicationService.Save();
            }
        }
    }
}
