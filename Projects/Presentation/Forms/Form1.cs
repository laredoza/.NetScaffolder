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

            this.ManageTemplateTreeViewUserControl1.DataSource =
                applicationConfiguration.ApplicationSettings.Templates[0];

            this.ProjectDetailsUserControl1.Project = this.applicationService.ProjectDefinition;
            this.ProjectDomainUserControl1.SelectedIndexChanged += this.ProjectDomainUserControl1_SelectedIndexChanged;
            this.ProjectDomainUserControl1.ApplicationService = this.applicationService;
            this.projectDomainDetailsUserControl1.ApplicationService = this.applicationService;
            this.ManageTemplateTreeViewUserControl1.AfterSelect += this.AfterSelect;
            this.ManageTemplateTreeViewUserControl1.BtnAddItemClick += this.BtnAddItemClick;
            this.ManageTemplateTreeViewUserControl1.BtnDeleteClick += this.BtnDeleteClick;
            this.ManageTemplateTreeViewUserControl1.BtnUpClick += this.BtnUpClick;
            this.ManageTemplateTreeViewUserControl1.BtnDownClick += this.BtnDownClick;
            this.ManageTemplateTreeViewUserControl1.BtnAddGroupClick += BtnAddGroupClick;
            this.ManageTemplateTreeViewUserControl1.SelectFirstNode();
        }

        private void BtnAddGroupClick(object sender, EventArgs eventArgs)
        {
            Template currentTemplate = this.TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate;

            if (currentTemplate.HierarchyType == HierarchyType.Item)
            {
                parentTemplate = this.TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;
            }
            else
            {
                parentTemplate = currentTemplate;
            }

            Template newTemplate = new Template
            {
                Id = Guid.NewGuid(),
                ConfigLocation = parentTemplate.ConfigLocation,
                DataType = parentTemplate.DataType,
                Enabled = true,
                LanguageOutputId = parentTemplate.LanguageOutputId,
                GeneratorTypeId = parentTemplate.GeneratorTypeId,
                HierarchyType = HierarchyType.Group,
                Name = "Group 1",
                Version = 1
            };

            parentTemplate.Children.Add(newTemplate);
            TreeNode newTreeNode = new TreeNode { Text = newTemplate.Name, Tag = newTemplate };
            this.TemplateDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            this.TemplateDetailsUserControl1.TreeNode = newTreeNode;
            this.TemplateDetailsUserControl1.Data = newTemplate;
        }

        private void BtnDownClick(object sender, EventArgs eventArgs)
        {
            this.ManageTemplateTreeViewUserControl1.MoveDown(this.TemplateDetailsUserControl1.TreeNode);
        }

        private void BtnUpClick(object sender, EventArgs e)
        {
            this.ManageTemplateTreeViewUserControl1.MoveUp(this.TemplateDetailsUserControl1.TreeNode);
        }

        private void BtnDeleteClick(object sender, EventArgs eventArgs)
        {
            Template currentTemplate = this.TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate = this.TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;

            parentTemplate.Children.Remove(currentTemplate);
            this.TemplateDetailsUserControl1.TreeNode.Remove();
        }

        private void BtnAddItemClick(object sender, EventArgs eventArgs)
        {
            Template currentTemplate = this.TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate;

            if (currentTemplate.HierarchyType == HierarchyType.Item)
            {
                parentTemplate = this.TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;
            }
            else
            {
                parentTemplate = currentTemplate;
            }

            Template newTemplate = new Template
                                       {
                                           Id = Guid.NewGuid(),
                                           ConfigLocation = parentTemplate.ConfigLocation,
                                           DataType = parentTemplate.DataType,
                                           Enabled = true,
                                           LanguageOutputId = parentTemplate.LanguageOutputId,
                                           GeneratorTypeId = parentTemplate.GeneratorTypeId,
                                           HierarchyType = HierarchyType.Item,
                                           Name = "Template1",
                                           Version = 1
                                       };

            parentTemplate.Children.Add(newTemplate);
            TreeNode newTreeNode = new TreeNode { Text = newTemplate.Name, Tag = newTemplate};

            if (currentTemplate.HierarchyType == HierarchyType.Item)
            {
                this.TemplateDetailsUserControl1.TreeNode.Parent.Nodes.Add(newTreeNode);
            }
            else
            {
                this.TemplateDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            }

            this.TemplateDetailsUserControl1.TreeNode = newTreeNode;
            this.TemplateDetailsUserControl1.Data = newTemplate;
        }

        private void AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.TemplateDetailsUserControl1.TreeNode = e.Node;
            this.TemplateDetailsUserControl1.Data = e.Node.Tag as Template;
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

            applicationConfiguration.Save();
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