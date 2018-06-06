// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateManagementUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Templates
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;
    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The template management user control.
    /// </summary>
    public partial class TemplateManagementUserControl : UserControl
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TemplateManagementUserControl" /> class.
        /// </summary>
        public TemplateManagementUserControl()
        {
            this.InitializeComponent();
            this.ManageTemplateTreeViewUserControl1.AfterSelect += this.AfterSelect;
            this.ManageTemplateTreeViewUserControl1.BtnAddItemClick += this.BtnAddItemClick;
            this.ManageTemplateTreeViewUserControl1.BtnDeleteClick += this.BtnDeleteClick;
            this.ManageTemplateTreeViewUserControl1.BtnUpClick += this.BtnUpClick;
            this.ManageTemplateTreeViewUserControl1.BtnDownClick += this.BtnDownClick;
            this.ManageTemplateTreeViewUserControl1.BtnAddGroupClick += this.BtnAddGroupClick;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Hierarchy DataSource
        {
            get
            {
                return this.ManageTemplateTreeViewUserControl1.DataSource;
            }

            set
            {
                if (this.ManageTemplateTreeViewUserControl1.DataSource != value)
                {
                    this.ManageTemplateTreeViewUserControl1.DataSource = value;
                    this.ManageTemplateTreeViewUserControl1.SelectFirstNode();
                }
            }
        }

        /// <summary>
        /// Gets or sets the project definition.
        /// </summary>
        public ProjectDefinition ProjectDefinition
        {
            get
            {
                return this.TemplateDetailsUserControl1.ProjectDefinition;
            }
            set
            {
                if (this.TemplateDetailsUserControl1.ProjectDefinition != value)
                {
                    this.TemplateDetailsUserControl1.ProjectDefinition = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the selected package.
        /// </summary>
        public Package SelectedPackage { get; set; }

        /// <summary>
        /// Gets or sets the packages.
        /// </summary>
        public List<Package> Packages
        {
            get
            {
                return this.TemplateDetailsUserControl1.Packages;
            }
            set
            {
                if (this.TemplateDetailsUserControl1.Packages != value)
                {
                    this.TemplateDetailsUserControl1.Packages = value;
                }
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The validation.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Validation()
        {
            return this.TemplateDetailsUserControl1.Validation();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// After select event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.TemplateDetailsUserControl1.TreeNode = e.Node;
            this.TemplateDetailsUserControl1.Data = e.Node.Tag as Template;
        }

        /// <summary>
        /// Add group event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
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

        /// <summary>
        /// Add Item
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
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
                                           DataType = parentTemplate.DataType,
                                           Enabled = true,
                                           LanguageOutputId = parentTemplate.LanguageOutputId,
                                           GeneratorTypeId = parentTemplate.GeneratorTypeId,
                                           HierarchyType = HierarchyType.Item,
                                           Name = "Template1",
                                           Version = 1
                                       };

            parentTemplate.Children.Add(newTemplate);
            TreeNode newTreeNode = new TreeNode { Text = newTemplate.Name, Tag = newTemplate };

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

        /// <summary>
        /// Delete Event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
        private void BtnDeleteClick(object sender, EventArgs eventArgs)
        {
            Template currentTemplate = this.TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate = this.TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;

            parentTemplate.Children.Remove(currentTemplate);
            this.TemplateDetailsUserControl1.TreeNode.Remove();
        }

        /// <summary>
        /// Move Item Down Event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
        private void BtnDownClick(object sender, EventArgs eventArgs)
        {
            this.ManageTemplateTreeViewUserControl1.MoveDown(this.TemplateDetailsUserControl1.TreeNode);
        }

        /// <summary>
        /// Move Item Up Event
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnUpClick(object sender, EventArgs e)
        {
            this.ManageTemplateTreeViewUserControl1.MoveUp(this.TemplateDetailsUserControl1.TreeNode);
        }

        #endregion
    }
}