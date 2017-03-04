// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HierarchyTreeView.cs" company="">
//   
// </copyright>
// <summary>
//   The hierarchy tree view.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView
{
    #region Using

    using System.Windows.Forms;

    using DotNetScaffolder.Presentation.Forms.Controls.Enum;

    using FormControls.Enum;

    #endregion

    /// <summary>
    ///     The hierarchy tree view.
    /// </summary>
    public class HierarchyTreeView : TreeView
    {
        #region Fields

        /// <summary>
        ///     The data.
        /// </summary>
        private IHierarchy data;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchyTreeView"/> class.
        /// </summary>
        public HierarchyTreeView()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether add group enabled.
        /// </summary>
        public bool AddGroupEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether add item enabled.
        /// </summary>
        public bool AddItemEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public IHierarchy Data
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
        /// Gets or sets a value indicating whether delete enabled.
        /// </summary>
        public bool DeleteEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether down enabled.
        /// </summary>
        public bool DownEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        //public TreeViewType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether up enabled.
        /// </summary>
        public bool UpEnabled { get; set; }

        #endregion

        #region Public methods and operators

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
        private TreeNode AddNode(IHierarchy hierarchyItem)
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