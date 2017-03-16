using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.TreeView;

    public partial class ManagePackageUserControl : UserControl
    {
        public ManagePackageUserControl()
        {
            InitializeComponent();

            this.ManageCollectionsTreeViewUserControl1.AfterSelect += this.AfterSelect;
            this.ManageCollectionsTreeViewUserControl1.BtnAddItemClick += this.BtnAddItemClick;
            this.ManageCollectionsTreeViewUserControl1.BtnDeleteClick += this.BtnDeleteClick;
            this.ManageCollectionsTreeViewUserControl1.BtnUpClick += this.BtnUpClick;
            this.ManageCollectionsTreeViewUserControl1.BtnDownClick += this.BtnDownClick;
            this.ManageCollectionsTreeViewUserControl1.BtnAddGroupClick += this.BtnAddGroupClick;

        }

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public IHierarchy DataSource
        {
            get
            {
                return this.ManageCollectionsTreeViewUserControl1.DataSource;
            }

            set
            {
                if (this.ManageCollectionsTreeViewUserControl1.DataSource != value)
                {
                    this.ManageCollectionsTreeViewUserControl1.DataSource = value;
                    this.ManageCollectionsTreeViewUserControl1.SelectFirstNode();
                }
            }
        }

        #region Public methods and operators

        /// <summary>
        /// The validation.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Validation()
        {
            return this.PackageDetailsUserControl1.Validation();
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
            this.PackageDetailsUserControl1.TreeNode = e.Node;
            this.PackageDetailsUserControl1.DataSource = e.Node.Tag as Package;
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
            //Template currentTemplate = this.TemplateDetailsUserControl1.TreeNode.Tag as Template;
            //Template parentTemplate;

            //if (currentTemplate.HierarchyType == HierarchyType.Item)
            //{
            //    parentTemplate = this.TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;
            //}
            //else
            //{
            //    parentTemplate = currentTemplate;
            //}

            //Template newTemplate = new Template
            //{
            //    Id = Guid.NewGuid(),
            //    ConfigLocation = parentTemplate.ConfigLocation,
            //    DataType = parentTemplate.DataType,
            //    Enabled = true,
            //    LanguageOutputId = parentTemplate.LanguageOutputId,
            //    GeneratorTypeId = parentTemplate.GeneratorTypeId,
            //    HierarchyType = HierarchyType.Group,
            //    Name = "Group 1",
            //    Version = 1
            //};

            //parentTemplate.Children.Add(newTemplate);
            //TreeNode newTreeNode = new TreeNode { Text = newTemplate.Name, Tag = newTemplate };
            //this.TemplateDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            //this.TemplateDetailsUserControl1.TreeNode = newTreeNode;
            //this.TemplateDetailsUserControl1.Data = newTemplate;
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
            //Template currentTemplate = this.TemplateDetailsUserControl1.TreeNode.Tag as Template;
            //Template parentTemplate;

            //if (currentTemplate.HierarchyType == HierarchyType.Item)
            //{
            //    parentTemplate = this.TemplateDetailsUserControl1.TreeNode.Parent.Tag as Template;
            //}
            //else
            //{
            //    parentTemplate = currentTemplate;
            //}

            //Template newTemplate = new Template
            //{
            //    Id = Guid.NewGuid(),
            //    ConfigLocation = parentTemplate.ConfigLocation,
            //    DataType = parentTemplate.DataType,
            //    Enabled = true,
            //    LanguageOutputId = parentTemplate.LanguageOutputId,
            //    GeneratorTypeId = parentTemplate.GeneratorTypeId,
            //    HierarchyType = HierarchyType.Item,
            //    Name = "Template1",
            //    Version = 1
            //};

            //parentTemplate.Children.Add(newTemplate);
            //TreeNode newTreeNode = new TreeNode { Text = newTemplate.Name, Tag = newTemplate };

            //if (currentTemplate.HierarchyType == HierarchyType.Item)
            //{
            //    this.TemplateDetailsUserControl1.TreeNode.Parent.Nodes.Add(newTreeNode);
            //}
            //else
            //{
            //    this.TemplateDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            //}

            //this.TemplateDetailsUserControl1.TreeNode = newTreeNode;
            //this.TemplateDetailsUserControl1.Data = newTemplate;
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
            Package currentTemplate = this.PackageDetailsUserControl1.TreeNode.Tag as Package;
            Package parentTemplate = this.PackageDetailsUserControl1.TreeNode.Parent.Tag as Package;

            parentTemplate.Children.Remove(currentTemplate);
            this.PackageDetailsUserControl1.TreeNode.Remove();
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
            this.ManageCollectionsTreeViewUserControl1.MoveDown(this.PackageDetailsUserControl1.TreeNode);
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
            this.ManageCollectionsTreeViewUserControl1.MoveUp(this.PackageDetailsUserControl1.TreeNode);
        }

        #endregion

    }
}
