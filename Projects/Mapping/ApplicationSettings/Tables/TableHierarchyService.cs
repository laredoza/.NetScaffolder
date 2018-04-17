// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableHierarchyService.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Tables
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The tempate hierarchy service.
    /// </summary>
    public class TempateHierarchyService : ITableHierarchyService
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
        public List<TreeNode> ConvertHierarchyToNodes(List<Hierarchy> items)
        {
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (Hierarchy item in items)
            {
                var node = new TreeNode { Tag = item.Item, Text = item.Name, Name = item.Id.ToString() };
                nodes.Add(node);

                node.Nodes.AddRange(this.ConvertHierarchyToNodes(item.Children).ToArray());
            }

            return nodes;
        }

        /// <summary>
        /// The new node.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <returns>
        /// The <see cref="Hierarchy"/>.
        /// </returns>
        public Hierarchy NewNode(Table table)
        {
            return new Hierarchy { Name = table.TableName, Item = table };
        }

        /// <summary>
        /// The return hierarchy from list.
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public List<Hierarchy> ReturnHierarchyFromList(
            List<Table> tables,
            bool includeFields,
            bool includeRelationships)
        {
            List<Hierarchy> result = new List<Hierarchy>();
            Hierarchy newTable = null;
            Hierarchy schema = null;
            foreach (Table table in tables)
            {
                newTable = this.NewNode(table);

                if (includeFields)
                {
                    newTable.Children.Add(new Hierarchy { Name = "Fields", Item = null });
                }

                if (includeRelationships)
                {
                    newTable.Children.Add(new Hierarchy { Name = "Relationships", Item = null });
                }

                if (result.Exists(h => h.Name == table.SchemaName))
                {
                    schema = result.First(h => h.Name == table.SchemaName);
                    schema.Children.Add(newTable);
                }
                else
                {
                    // Add new Schema
                    schema = new Hierarchy { Name = table.SchemaName, Id = Guid.NewGuid(), Enabled = true };
                    result.Add(schema);
                    schema.Children.Add(newTable);
                }
            }

            return result;
        }

        #endregion


//        MainViewModel.cs

//private void DoTableCollectionDiff(List<MetadataTable> originalTableList, List<MetadataTable> sourceTableList, MetadataTableCollectionDiff comparison)
//        {
//            var popupWindowViewModel = this.container.Resolve<IComparisonViewModel>();
//            popupWindowViewModel.CurrentTableList = originalTableList;
//            popupWindowViewModel.SourceTableList = sourceTableList;
//            popupWindowViewModel.TableCollectionDiff = comparison;

//            var popupWindow = new PopupWindow();
//            popupWindowViewModel.Popup = popupWindow;
//            popupWindow.Title = "Table Collection Comparison Results";
//            popupWindow.Content = popupWindowViewModel.View;
//            popupWindow.Owner = Application.Current.MainWindow;
//            popupWindow.ShowDialog();

//            if (popupWindowViewModel.AcceptedNewTableCollection)
//            {
//                PreserveCustomMetadata(popupWindowViewModel.SourceTableList, this.Tables.ToList());

//                this.Tables = new ObservableCollection<MetadataTable>(popupWindowViewModel.SourceTableList);
//                this.currentDomain.TableCollection.Tables = popupWindowViewModel.SourceTableList;
//            }
//        }

//        private static void PreserveCustomMetadata(List<MetadataTable> newTableList, List<MetadataTable> oldTableList)
//        {
//            // Do our best to preserve table, column and relationship metadata
//            foreach (var newTable in newTableList)
//            {
//                var oldTable = oldTableList.FirstOrDefault(u => (u.SchemaName == newTable.SchemaName) && (u.TableName == newTable.TableName));
//                if (oldTable != null)
//                {
//                    newTable.Description = oldTable.Description;

//                    // Attempt to preserve column metadata
//                    foreach (var newColumn in newTable.Columns)
//                    {
//                        var oldColumn = oldTable.Columns.FirstOrDefault(u => u.ColumnName == newColumn.ColumnName);
//                        if (oldColumn != null)
//                        {
//                            newColumn.RenderToEntity = oldColumn.RenderToEntity;
//                            newColumn.RenderToView = oldColumn.RenderToView;
//                            newColumn.DefaultFieldValue = oldColumn.DefaultFieldValue;
//                            newColumn.Description = oldColumn.Description;
//                            newColumn.GridColumnWidth = oldColumn.GridColumnWidth;
//                            newColumn.GridViewControlType = oldColumn.GridViewControlType;
//                            newColumn.LookupClassName = oldColumn.LookupClassName;
//                            newColumn.RenderToViewOrder = oldColumn.RenderToViewOrder;
//                            if (oldColumn.CustomNumberTypeMapping != CustomTypeMapping.None)
//                            {
//                                newColumn.CustomNumberTypeMapping = oldColumn.CustomNumberTypeMapping;
//                                if (oldColumn.CustomNumberTypeMapping == CustomTypeMapping.Decimal)
//                                {
//                                    newColumn.Precision = oldColumn.Precision;
//                                    newColumn.Scale = oldColumn.Scale;
//                                }
//                            }
//                        }
//                    }

//                    // Attempt to preserve relationship metadata
//                    if (oldTable.RelationShips != null)
//                    {
//                        // Attempt to preserve User created relationships
//                        newTable.RelationShips.AddRange(oldTable.RelationShips.Where(u => u.UserRelationship));
//                    }
//                }
//            }
//        }
    }
}