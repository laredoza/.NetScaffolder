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
            this.Enabled = true;
            this.Children = new List<Hierarchy>();
            this.HierarchyType = HierarchyType.Group;
        }

        #endregion

        #region Public Properties

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

        /// <summary>
        /// Gets or sets a value indicating whether selected.
        /// </summary>
        public bool Selected { get; set; }

        #endregion

        public Hierarchy Find(Guid id)
        {
            return this.Find(id, this.Children);
        }

        /// <summary>
        /// Find.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="children">
        /// The children.
        /// </param>
        /// <returns>
        /// The <see cref="Hierarchy"/>.
        /// </returns>
        public Hierarchy Find(Guid id, List<Hierarchy> children)
        {
            Hierarchy result = null; 

            foreach (var child in children)
            {
                if (child.Id == id)
                {
                    return child;
                }
                else
                {
                    result = this.Find(id, child.Children);

                    if (result != null)
                    {
                        return result;
                    }
                }
            }

            return result;
        }
    }
}