// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHierarchy.cs" company="">
//   
// </copyright>
// <summary>
//   The Hierarchy interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView
{
    #region Using

    using System;
    using System.Collections.Generic;

    using FormControls.Enum;

    #endregion

    /// <summary>
    /// The Hierarchy interface.
    /// </summary>
    public interface IHierarchy
    {
        #region Properties

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        List<Hierarchy> Children { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether enabled.
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        object Item { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the parent id.
        /// </summary>
        Guid ParentId { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy type.
        /// </summary>
        HierarchyType HierarchyType { get; set; }

        #endregion
    }
}