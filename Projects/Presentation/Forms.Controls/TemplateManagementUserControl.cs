// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateManagementUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Windows.Forms;

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
            InitializeComponent();
            ManageTemplateTreeViewUserControl1.AfterSelect += AfterSelect;
            ManageTemplateTreeViewUserControl1.BtnAddItemClick += BtnAddItemClick;
            ManageTemplateTreeViewUserControl1.BtnDeleteClick += BtnDeleteClick;
            ManageTemplateTreeViewUserControl1.BtnUpClick += BtnUpClick;
            ManageTemplateTreeViewUserControl1.BtnDownClick += BtnDownClick;
            ManageTemplateTreeViewUserControl1.BtnAddGroupClick += BtnAddGroupClick;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public IHierarchy DataSource
        {
            get
            {
                return ManageTemplateTreeViewUserControl1.DataSource;
            }

            set
            {
                if (ManageTemplateTreeViewUserControl1.DataSource != value)
                {
                    ManageTemplateTreeViewUserControl1.DataSource = value;
                    ManageTemplateTreeViewUserControl1.SelectFirstNode();
                }
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     The validation.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Validation()
        {
            return TemplateDetailsUserControl1.Validation();
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
            TemplateDetailsUserControl1.TreeNode = e.Node;
            TemplateDetailsUserControl1.Data = e.Node.Tag as Template;
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
            Template currentTemplate = TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate;

            if (currentTemplate.HierarchyType == HierarchyType.Item)
            {
                parentTemplate = TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;
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
            TemplateDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            TemplateDetailsUserControl1.TreeNode = newTreeNode;
            TemplateDetailsUserControl1.Data = newTemplate;
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
            Template currentTemplate = TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate;

            if (currentTemplate.HierarchyType == HierarchyType.Item)
            {
                parentTemplate = TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;
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
            TreeNode newTreeNode = new TreeNode { Text = newTemplate.Name, Tag = newTemplate };

            if (currentTemplate.HierarchyType == HierarchyType.Item)
            {
                TemplateDetailsUserControl1.TreeNode.Parent.Nodes.Add(newTreeNode);
            }
            else
            {
                TemplateDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            }

            TemplateDetailsUserControl1.TreeNode = newTreeNode;
            TemplateDetailsUserControl1.Data = newTemplate;
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
            Template currentTemplate = TemplateDetailsUserControl1.TreeNode.Tag as Template;
            Template parentTemplate = TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;

            parentTemplate.Children.Remove(currentTemplate);
            TemplateDetailsUserControl1.TreeNode.Remove();
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
            ManageTemplateTreeViewUserControl1.MoveDown(TemplateDetailsUserControl1.TreeNode);
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
            ManageTemplateTreeViewUserControl1.MoveUp(TemplateDetailsUserControl1.TreeNode);
        }

        #endregion
    }
}