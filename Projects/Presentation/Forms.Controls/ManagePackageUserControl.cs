// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManagePackageUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;
    using FormControls.TreeView;

    #endregion

    /// <summary>
    /// The manage package user control.
    /// </summary>
    public partial class ManagePackageUserControl : UserControl
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePackageUserControl"/> class.
        /// </summary>
        public ManagePackageUserControl()
        {
            InitializeComponent();

            ManageCollectionsTreeViewUserControl1.AfterSelect += AfterSelect;
            ManageCollectionsTreeViewUserControl1.BtnAddItemClick += BtnAddItemClick;
            ManageCollectionsTreeViewUserControl1.BtnDeleteClick += BtnDeleteClick;
            ManageCollectionsTreeViewUserControl1.BtnUpClick += BtnUpClick;
            ManageCollectionsTreeViewUserControl1.BtnDownClick += BtnDownClick;
            ManageCollectionsTreeViewUserControl1.BtnAddGroupClick += BtnAddGroupClick;
            Templates = new List<Template>();
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
                return ManageCollectionsTreeViewUserControl1.DataSource;
            }

            set
            {
                if (ManageCollectionsTreeViewUserControl1.DataSource != value)
                {
                    ManageCollectionsTreeViewUserControl1.DataSource = value;
                    ManageCollectionsTreeViewUserControl1.SelectFirstNode();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<Template> Templates { get; set; }

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
            return PackageDetailsUserControl1.Validation();
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
            PackageDetailsUserControl1.TreeNode = e.Node;
            PackageDetailsUserControl1.DataSource = e.Node.Tag as Package;

            if (Templates.Count > 0)
            {
                PackageDetailsUserControl1.AvailableTemplates = Templates[0].ReturnTemplateItems();
            }
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
            Package currentPackage = PackageDetailsUserControl1.TreeNode.Tag as Package;
            Package parentPackage;

            if (currentPackage.HierarchyType == HierarchyType.Item)
            {
                parentPackage = PackageDetailsUserControl1.TreeNode.Parent.Tag as Package;
            }
            else
            {
                parentPackage = currentPackage;
            }

            Package newPackage = new Package
                                     {
                                         Id = Guid.NewGuid(),

                                         // ConfigLocation = parentPackage.ConfigLocation,
                                         // DataType = parentPackage.DataType,
                                         Enabled = true,

                                         // LanguageOutputId = parentPackage.LanguageOutputId,
                                         // GeneratorTypeId = parentPackage.GeneratorTypeId,
                                         HierarchyType = HierarchyType.Group,
                                         Name = "Group 1",
                                         Version = 1
                                     };

            parentPackage.Children.Add(newPackage);
            TreeNode newTreeNode = new TreeNode { Text = newPackage.Name, Tag = newPackage };
            PackageDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            PackageDetailsUserControl1.TreeNode = newTreeNode;
            PackageDetailsUserControl1.DataSource = newPackage;
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
            Package currentPackage = PackageDetailsUserControl1.TreeNode.Tag as Package;
            Package parentPackage;

            if (currentPackage.HierarchyType == HierarchyType.Item)
            {
                parentPackage = PackageDetailsUserControl1.TreeNode.Parent.Tag as Package;
            }
            else
            {
                parentPackage = currentPackage;
            }

            Package newPackage = new Package
                                     {
                                         Id = Guid.NewGuid(),

                                         // ConfigLocation = parentPackage.ConfigLocation,
                                         // DataType = parentPackage.DataType,
                                         Enabled = true,

                                         // LanguageOutputId = parentPackage.LanguageOutputId,
                                         // GeneratorTypeId = parentPackage.GeneratorTypeId,
                                         HierarchyType = HierarchyType.Item,
                                         Name = "Package1",
                                         Version = 1
                                     };

            parentPackage.Children.Add(newPackage);
            TreeNode newTreeNode = new TreeNode { Text = newPackage.Name, Tag = newPackage };

            if (currentPackage.HierarchyType == HierarchyType.Item)
            {
                PackageDetailsUserControl1.TreeNode.Parent.Nodes.Add(newTreeNode);
            }
            else
            {
                PackageDetailsUserControl1.TreeNode.Nodes.Add(newTreeNode);
            }

            PackageDetailsUserControl1.TreeNode = newTreeNode;
            PackageDetailsUserControl1.DataSource = newPackage;
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
            Package currentTemplate = PackageDetailsUserControl1.TreeNode.Tag as Package;
            Package parentTemplate = PackageDetailsUserControl1.TreeNode.Parent.Tag as Package;

            parentTemplate.Children.Remove(currentTemplate);
            PackageDetailsUserControl1.TreeNode.Remove();
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
            ManageCollectionsTreeViewUserControl1.MoveDown(PackageDetailsUserControl1.TreeNode);
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
            ManageCollectionsTreeViewUserControl1.MoveUp(PackageDetailsUserControl1.TreeNode);
        }

        #endregion
    }
}