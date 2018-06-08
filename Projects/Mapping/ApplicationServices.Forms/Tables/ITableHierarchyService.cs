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
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The TableHierarchService interface.
    /// </summary>
    public interface ITableHierarchyService
    {
        #region Public Methods And Operators

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

        /// <summary>
        /// The do table collection diff.
        /// </summary>
        /// <param name="originalTableList">
        /// The original table list.
        /// </param>
        /// <param name="addedTables">
        /// The added tables.
        /// </param>
        /// <param name="removedTables">
        /// The removed tables.
        /// </param>
        /// <param name="refreshedTables">
        /// The refreshed tables.
        /// </param>
        /// <param name="comparison">
        /// The comparison.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Table> DoTableCollectionDiff(
            List<Table> originalTableList,
            List<Table> addedTables,
            List<Table> removedTables,
            List<Table> refreshedTables,
            ApplicationTableCollectionDifference comparison);

        /// <summary>
        /// The preserve custom metadata.
        /// </summary>
        /// <param name="newTableList">
        /// The new table list.
        /// </param>
        /// <param name="oldTableList">
        /// The old table list.
        /// </param>
        /// <param name="sourceType">
        /// The source Type.
        /// </param>
        void PreserveCustomMetadata(List<Table> newTableList, List<Table> oldTableList, ISourceType sourceType);

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
        /// The include Relationships.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Hierarchy> ReturnHierarchyFromList(List<Table> tables, bool includeFields, bool includeRelationships);

        /// <summary>
        /// The return selected hierarchy from list.
        /// </summary>
        /// <param name="sourceTables">
        /// The source tables.
        /// </param>
        /// <param name="selectedTables">
        /// The selected tables.
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
        List<Hierarchy> ReturnSelectedHierarchyFromList(
            List<Table> sourceTables,
            List<Table> selectedTables,
            bool includeFields,
            bool includeRelationships);

        /// <summary>
        /// Return Tables
        /// </summary>
        /// <param name="parentNode">
        /// </param>
        /// <param name="all">
        /// The all.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<Table> ReturnTables(TreeNode parentNode, bool all = false);

        #endregion
    }
}