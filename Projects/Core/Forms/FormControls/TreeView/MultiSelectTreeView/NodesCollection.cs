// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NodesCollection.cs" company="">
//  Copyright 2004, Coder's Lab
//  All rights reserved. The software and associated documentation 
//  supplied hereunder are the proprietary information of Coder's Lab
//  and are supplied subject to licence terms.
//  
//
//  You can use this control freely in your projects, but let me know if you
//  are using it so I can add you to a list of references. 
//
//  Email: ludwig.stuyck@coders-lab.be
//  Home page: http://www.coders-lab.be
// </copyright>
// <summary>
//   Collection of selected nodes.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView.MultiSelectTreeView
{
    #region Using

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
                return (TreeNode)this.List[index];
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
            if (this.TreeNodeAdded != null) this.TreeNodeAdded(treeNode);

            return this.List.Add(treeNode);
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
            return this.List.Contains(treeNode);
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
            return this.List.IndexOf(treeNode);
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
            if (this.TreeNodeInserted != null) this.TreeNodeInserted(treeNode);

            this.List.Add(treeNode);
        }

        /// <summary>
        /// Removed a tree node from the collection.
        /// </summary>
        /// <param name="treeNode">
        /// Tree node to remove.
        /// </param>
        public void Remove(TreeNode treeNode)
        {
            if (this.TreeNodeRemoved != null) this.TreeNodeRemoved(treeNode);

            this.List.Remove(treeNode);
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     Occurs when collection is being cleared.
        /// </summary>
        protected override void OnClear()
        {
            if (this.SelectedNodesCleared != null) this.SelectedNodesCleared(this, EventArgs.Empty);

            base.OnClear();
        }

        #endregion
    }
}