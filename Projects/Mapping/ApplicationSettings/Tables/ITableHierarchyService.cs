// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITableHierarchyService.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Tables
{
    #region Usings

    using System.Collections.Generic;
    using System.Windows.Forms;

    using FormControls.TreeView;

    using Table = DotNetScaffolder.Mapping.MetaData.Model.Table;

    #endregion

    /// <summary>
    /// The TableHierarchService interface.
    /// </summary>
    public interface ITableHierarchyService
    {
        #region Public Methods And Operators

        /// <summary>
        /// Return hierarchy from list.
        /// </summary>
        /// <param name="tables">
        /// The tables.
        /// </param>
        /// <param name="includeFields">
        /// The include fields.
        /// </param>
        /// <param name="includeRelationships">
        /// The include relationships.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Hierarchy> ReturnHierarchyFromList(List<Table> tables, bool includeFields, bool includeRelationships);

        /// <summary>
        /// The convert hierarchy to nodes.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<TreeNode> ConvertHierarchyToNodes(List<Hierarchy> items);

        #endregion
    }
}