// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeViewSelectionMode.cs" company="">
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
//  Home page: http://www.coders-lab.be// </copyright>
// <summary>
//   Selection mode for the treeview.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView.MultiSelectTreeView
{
    /// <summary>
    ///     Selection mode for the treeview.
    /// </summary>
    /// <remarks>
    ///     The Selection mode determines how treeview nodes can be selected.
    /// </remarks>
    public enum TreeViewSelectionMode
    {
        /// <summary>
        ///     Only one node can be selected at a time.
        /// </summary>
        SingleSelect,

        /// <summary>
        ///     Multiple nodes can be selected at the same time without restriction.
        /// </summary>
        MultiSelect,

        /// <summary>
        ///     Multiple nodes that belong to the same root branch can be selected at the same time.
        /// </summary>
        MultiSelectSameRootBranch,

        /// <summary>
        ///     Multiple nodes that belong to the same level can be selected at the same time.
        /// </summary>
        MultiSelectSameLevel,

        /// <summary>
        ///     Multiple nodes that belong to the same level and same root branch can be selected at the same time.
        /// </summary>
        MultiSelectSameLevelAndRootBranch,

        /// <summary>
        ///     Only nodes that belong to the same direct parent can be selected at the same time.
        /// </summary>
        MultiSelectSameParent
    }
}