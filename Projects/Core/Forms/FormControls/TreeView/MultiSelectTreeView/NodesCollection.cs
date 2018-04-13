// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NodesCollection.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView.MultiSelectTreeView
{
    #region Usings

    using System;
    using System.Collections;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    ///     Collection of selected nodes.
    /// </summary>
    public class NodesCollection : CollectionBase
    {
        #region Other Events

        /// <summary>
        ///     Event fired the collection has been cleared.
        /// </summary>
        internal event EventHandler SelectedNodesCleared;

        /// <summary>
        ///     Event fired when a tree node has been added to the collection.
        /// </summary>
        internal event TreeNodeEventHandler TreeNodeAdded;

        /// <summary>
        ///     Event fired when a tree node has been inserted to the collection.
        /// </summary>
        internal event TreeNodeEventHandler TreeNodeInserted;

        /// <summary>
        ///     Event fired when a tree node has been removed to the collection.
        /// </summary>
        internal event TreeNodeEventHandler TreeNodeRemoved;

        #endregion

        #region Indexers

        /// <summary>
        /// Gets tree node at specified index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="TreeNode"/>.
        /// </returns>
        public TreeNode this[int index]
        {
            get
            {
                return (TreeNode)List[index];
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// Adds a tree node to the collection.
        /// </summary>
        /// <param name="treeNode">
        /// Tree node to add.
        /// </param>
        /// <returns>
        /// The position into which the new element was inserted.
        /// </returns>
        public int Add(TreeNode treeNode)
        {
            if (TreeNodeAdded != null) TreeNodeAdded(treeNode);

            return List.Add(treeNode);
        }

        /// <summary>
        /// Determines whether treenode belongs to the collection.
        /// </summary>
        /// <param name="treeNode">
        /// Tree node to check.
        /// </param>
        /// <returns>
        /// True if tree node belongs to the collection, false if not.
        /// </returns>
        public bool Contains(TreeNode treeNode)
        {
            return List.Contains(treeNode);
        }

        /// <summary>
        /// Gets index of tree node in the collection.
        /// </summary>
        /// <param name="treeNode">
        /// Tree node to get index of.
        /// </param>
        /// <returns>
        /// Index of tree node in the collection.
        /// </returns>
        public int IndexOf(TreeNode treeNode)
        {
            return List.IndexOf(treeNode);
        }

        /// <summary>
        /// Inserts a tree node at specified index.
        /// </summary>
        /// <param name="index">
        /// The position into which the new element has to be inserted.
        /// </param>
        /// <param name="treeNode">
        /// Tree node to insert.
        /// </param>
        public void Insert(int index, TreeNode treeNode)
        {
            if (TreeNodeInserted != null) TreeNodeInserted(treeNode);

            List.Add(treeNode);
        }

        /// <summary>
        /// Removed a tree node from the collection.
        /// </summary>
        /// <param name="treeNode">
        /// Tree node to remove.
        /// </param>
        public void Remove(TreeNode treeNode)
        {
            if (TreeNodeRemoved != null) TreeNodeRemoved(treeNode);

            List.Remove(treeNode);
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     Occurs when collection is being cleared.
        /// </summary>
        protected override void OnClear()
        {
            if (SelectedNodesCleared != null) SelectedNodesCleared(this, EventArgs.Empty);

            base.OnClear();
        }

        #endregion
    }
}