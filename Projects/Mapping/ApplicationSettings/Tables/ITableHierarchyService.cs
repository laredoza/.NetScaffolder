#region Usings

using System.Collections.Generic;
using System.Windows.Forms;
using DotNetScaffolder.Mapping.ApplicationServices.Differences;
using DotNetScaffolder.Mapping.MetaData.Model;
using FormControls.TreeView;

#endregion

namespace DotNetScaffolder.Mapping.ApplicationServices.Tables
{
    #region Usings

    #endregion

    /// <summary>
    ///     The TableHierarchService interface.
    /// </summary>
    public interface ITableHierarchyService
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The convert hierarchy to nodes.
        /// </summary>
        /// <param name="items">
        ///     The items.
        /// </param>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        List<TreeNode> ConvertHierarchyToNodes(List<Hierarchy> items);

        /// <summary>
        ///     Return hierarchy from list.
        /// </summary>
        /// <param name="tables">
        ///     The tables.
        /// </param>
        /// <param name="includeFields">
        ///     The include fields.
        /// </param>
        /// <param name="includeRelationships">
        ///     The include relationships.
        /// </param>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        List<Hierarchy> ReturnHierarchyFromList(List<Table> tables, bool includeFields, bool includeRelationships);

        List<Table> DoTableCollectionDiff(List<Table> originalTableList, List<Table> addedTables, List<Table> removedTables,
            ApplicationTableCollectionDifference comparison);

        /// <summary>
        /// Return Tables
        /// </summary>
        /// <param name="parentNode"></param>
        /// <returns></returns>
        List<Table> ReturnTables(TreeNode parentNode);

        void PreserveCustomMetadata(List<Table> newTableList, List<Table> oldTableList);

        #endregion
    }
}