namespace FormControls.TreeView
{
    using System.Windows.Forms;

    /// <summary>
    /// The hierarchy tree view.
    /// </summary>
    public class HierarchyTreeView : TreeView
    {
        /// <summary>
        /// The data.
        /// </summary>
        private IHierarchy data;

        /// <summary>
        /// Gets or sets the data.
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
        /// Update nodes.
        /// </summary>
        private void UpdateNodes()
        {
            this.Nodes.Clear();
            this.Nodes.Add(this.AddNode(this.Data));
        }

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
            TreeNode node = new TreeNode(hierarchyItem.Name)
                                {
                                    Tag = hierarchyItem,
                                    Name = this.Data.Id.ToString()
                                };

            foreach (var child in hierarchyItem.Children)
            {
                node.Nodes.Add(this.AddNode(child));
            }

            return node;
        }
    }
}
