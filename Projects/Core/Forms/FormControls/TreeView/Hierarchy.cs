// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hierarchy.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using FormControls.Enum;

    #endregion

    /// <summary>
    ///     The hierarchy.
    /// </summary>
    [Serializable]
    public class Hierarchy  
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Hierarchy" /> class.
        /// </summary>
        public Hierarchy()
        {
            Enabled = true;
            Children = new List<Hierarchy>();
            HierarchyType = HierarchyType.Group;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the children.
        /// </summary>
        public List<Hierarchy> Children { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        ///     Gets or sets the hierarchy type.
        /// </summary>
        public HierarchyType HierarchyType { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the item.
        /// </summary>
        public object Item { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the parent id.
        /// </summary>
        public Guid ParentId { get; set; }

        #endregion
    }
}