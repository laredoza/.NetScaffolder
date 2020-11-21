// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HierarchyTreeView.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView
{
    #region Usings

    using System;

    using DotNetScaffolder.Core.Extensions;

    using FormControls.Enum;

    #endregion

    /// <summary>
    ///     The hierarchy tree view.
    /// </summary>
    [Serializable]
    public class HierarchyTreeView : TreeView
    {
        #region Fields

        /// <summary>
        ///     The data.
        /// </summary>
        private Hierarchy data;

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether add group enabled.
        /// </summary>
        public bool AddGroupEnabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether add item enabled.
        /// </summary>
        public bool AddItemEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public Hierarchy Data
        {
            get
            {
                return this.data;
            }

            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.UpdateNodes();
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether delete enabled.
        /// </summary>
        public bool DeleteEnabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether down enabled.
        /// </summary>
        public bool DownEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <summary>
        ///     Gets or sets a value indicating whether up enabled.
        /// </summary>
        public bool UpEnabled { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// Move down.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void MoveDown(TreeNode selectedNode)
        {
            if (selectedNode.Parent != null && selectedNode.Index < selectedNode.Parent.Nodes.Count - 1)
            {
                Hierarchy currentNode = selectedNode.Tag as Hierarchy;
                Hierarchy parentNode = selectedNode.Parent.Tag as Hierarchy;
                selectedNode.MoveDown();
                int index = parentNode.Children.IndexOf(currentNode);
                parentNode.Children.MoveItem(index, index + 1);
            }
        }

        /// <summary>
        /// Move up.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void MoveUp(TreeNode selectedNode)
        {
            if (selectedNode.Index > 0)
            {
                Hierarchy currentNode = selectedNode.Tag as Hierarchy;
                Hierarchy parentNode = selectedNode.Parent.Tag as Hierarchy;
                selectedNode.MoveUp();

                int index = parentNode.Children.IndexOf(currentNode);
                parentNode.Children.MoveItem(index, index - 1);
            }
        }

        /// <summary>
        /// The search.
        /// </summary>
        /// <param name="itemId">
        /// The item id.
        /// </param>
        /// <param name="rootNode">
        /// The root node.
        /// </param>
        /// <returns>
        /// The <see cref="TreeNode"/>.
        /// </returns>
        public TreeNode Search(string itemId, TreeNode rootNode)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (node.Tag.Equals(itemId))
                {
                    return node;
                }

                TreeNode next = this.Search(itemId, node);

                if (next != null)
                {
                    return next;
                }
            }

            return null;
        }

        /// <summary>
        /// The select node.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void SelectNode(TreeNode selectedNode)
        {
            if (selectedNode.Level == 0)
            {
                this.UpEnabled = false;
                this.DownEnabled = false;
                this.DeleteEnabled = false;
                this.AddGroupEnabled = false;
                this.AddItemEnabled = false;
            }
            else if (selectedNode.Level == 1)
            {
                this.UpEnabled = false;
                this.DownEnabled = false;
                this.DeleteEnabled = false;
                this.AddGroupEnabled = true;
                this.AddItemEnabled = true;
            }
            else
            {
                if ((selectedNode.Tag as Hierarchy).HierarchyType == HierarchyType.Item)
                {
                    if (selectedNode.Parent.Nodes.Count == 1)
                    {
                        this.UpEnabled = false;
                        this.DownEnabled = false;
                    }
                    else if (selectedNode.Index == 0)
                    {
                        this.UpEnabled = false;
                        this.DownEnabled = true;
                    }
                    else if (selectedNode.Index == selectedNode.Parent.Nodes.Count - 1)
                    {
                        this.UpEnabled = true;
                        this.DownEnabled = false;
                    }

                    this.DeleteEnabled = true;
                    this.AddGroupEnabled = false;
                    this.AddItemEnabled = true;
                }
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// Add node.
        /// </summary>
        /// <param name="hierarchyItem">
        /// The hierarchy item.
        /// </param>
        /// <returns>
        /// The <see cref="TreeNode"/>.
        /// </returns>
        private TreeNode AddNode(Hierarchy hierarchyItem)
        {
            TreeNode node = new TreeNode(hierarchyItem.Name) { Tag = hierarchyItem, Name = this.Data.Id.ToString() };

            foreach (var child in hierarchyItem.Children)
            {
                node.Nodes.Add(this.AddNode(child));
            }

            return node;
        }

        /// <summary>
        ///     Update nodes.
        /// </summary>
        private void UpdateNodes()
        {
            this.Nodes.Clear();
            this.Nodes.Add(this.AddNode(this.Data));
        }

        #endregion
    }
}