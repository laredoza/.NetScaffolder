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

    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    #region Usings

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
                var node = new TreeNode { Tag = item.Item, Text = item.Name, Name = item.Id.ToString(), Checked = item.Selected };
                nodes.Add(node);

                node.Nodes.AddRange(this.ConvertHierarchyToNodes(item.Children).ToArray());
            }

            return nodes;
        }

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
        /// <param name="comparison">
        /// The comparison.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Table> DoTableCollectionDiff(
            List<Table> originalTableList,
            List<Table> addedTables,
            List<Table> removedTables,
            ApplicationTableCollectionDifference comparison)
        {
            List<Table> newList = new List<Table>();
            foreach (Table table in originalTableList)
            {
                newList.Add(table.Clone() as Table);
            }

            foreach (Table table in addedTables)
            {
                newList.Add(table.Clone() as Table);
            }

            Table tableToRemove;
            foreach (Table table in removedTables)
            {
                tableToRemove = newList.FirstOrDefault(
                    t => t.SchemaName == table.SchemaName && t.TableName == table.TableName);
                if (tableToRemove != null)
                {
                    newList.Remove(tableToRemove);
                }
            }

            return newList;
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
        /// The preserve custom metadata.
        /// </summary>
        /// <param name="newTableList">
        /// The new table list.
        /// </param>
        /// <param name="oldTableList">
        /// The old table list.
        /// </param>
        public void PreserveCustomMetadata(List<Table> newTableList, List<Table> oldTableList)
        {
            // Do our best to preserve table, column and relationship metadata
            foreach (var newTable in newTableList)
            {
                var oldTable = oldTableList.FirstOrDefault(
                    u => (u.SchemaName.ToUpper() == newTable.SchemaName.ToUpper())
                         && (u.TableName.ToUpper() == newTable.TableName.ToUpper()));
                if (oldTable != null)
                {
                    newTable.Description = oldTable.Description;

                    // Attempt to preserve column metadata
                    foreach (var newColumn in newTable.Columns)
                    {
                        var oldColumn = oldTable.Columns.FirstOrDefault(
                            u => u.ColumnName.ToUpper() == newColumn.ColumnName.ToUpper());
                        if (oldColumn != null)
                        {
                            // Todo: Review missing values
                            newColumn.RenderToEntity = oldColumn.RenderToEntity;
                            newColumn.RenderToView = oldColumn.RenderToView;
                            newColumn.DefaultFieldValue = oldColumn.DefaultFieldValue;
                            newColumn.Description = oldColumn.Description;
                            newColumn.GridColumnWidth = oldColumn.GridColumnWidth;

                            // newColumn.GridViewControlType = oldColumn.GridViewControlType;
                            newColumn.LookupClassName = oldColumn.LookupClassName;
                            newColumn.RenderToViewOrder = oldColumn.RenderToViewOrder;

                            // if (oldColumn.CustomNumberTypeMapping != CustomTypeMapping.None)
                            // {
                            // newColumn.CustomNumberTypeMapping = oldColumn.CustomNumberTypeMapping;
                            // if (oldColumn.CustomNumberTypeMapping == CustomTypeMapping.Decimal)
                            // {
                            // newColumn.Precision = oldColumn.Precision;
                            // newColumn.Scale = oldColumn.Scale;
                            // }
                            // }
                        }
                    }

                    // Attempt to preserve relationship metadata
                    if (oldTable.RelationShips != null)
                    {
                        // Attempt to preserve User created relationships
                        newTable.RelationShips.AddRange(oldTable.RelationShips.Where(u => u.UserRelationship));
                    }
                }
            }
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
            Hierarchy fieldNode = null;
            Hierarchy relationshipNode = null;
            
            foreach (Table table in tables)
            {
                newTable = this.NewNode(table);

                if (includeFields)
                {
                    fieldNode = new Hierarchy { Name = "Fields", Item = null };
                    newTable.Children.Add(fieldNode);

                    foreach (Column column in table.Columns)
                    {
                        fieldNode.Children.Add(new Hierarchy { Name = column.ColumnName, Item = column});
                    }
                }

                if (includeRelationships)
                {
                    relationshipNode = new Hierarchy { Name = "Relationships", Item = null };
                    newTable.Children.Add(relationshipNode);

                    foreach (Relationship relationShip in table.RelationShips)
                    {
                        relationshipNode.Children.Add(
                            new Hierarchy { Name = relationShip.RelationshipName, Item = relationShip });
                    }
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

        public List<Hierarchy> ReturnSelectedHierarchyFromList(List<Table> sourceTables, List<Table> selectedTables, bool includeFields, bool includeRelationships)
        {
            List<Hierarchy> result = new List<Hierarchy>();
            Hierarchy newTable = null;
            Hierarchy schema = null;
            Hierarchy fieldNode = null;
            Hierarchy relationshipNode = null;

            foreach (Table table in sourceTables)
            {
                bool isChecked = false;

                if (selectedTables != null && selectedTables.Any(o=> o.SchemaName == table.SchemaName && o.TableName == table.TableName))
                {
                    isChecked = true;
                }

                newTable = this.NewNode(table);
                newTable.Selected = isChecked;

                if (includeFields)
                {
                    fieldNode = new Hierarchy { Name = "Fields", Item = null };
                    newTable.Children.Add(fieldNode);

                    foreach (Column column in table.Columns)
                    {
                        fieldNode.Children.Add(new Hierarchy { Name = column.ColumnName, Item = column });
                    }
                }

                if (includeRelationships)
                {
                    relationshipNode = new Hierarchy { Name = "Relationships", Item = null };
                    newTable.Children.Add(relationshipNode);

                    foreach (Relationship relationShip in table.RelationShips)
                    {
                        relationshipNode.Children.Add(
                            new Hierarchy { Name = relationShip.RelationshipName, Item = relationShip });
                    }
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

        /// <summary>
        /// The return tables.
        /// </summary>
        /// <param name="parentNode">
        /// The parent node.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Table> ReturnTables(TreeNode parentNode, bool all = false)
        {
            List<Table> result = new List<Table>();

            foreach (TreeNode node in parentNode.Nodes)
            {
                foreach (TreeNode child in node.Nodes)
                {
                    if(all)
                    {
                        result.Add(child.Tag as Table);
                    }
                    else if (child.Checked)
                    {
                        result.Add(child.Tag as Table);
                    }
                }
            }

            return result;
        }

        #endregion

        // MainViewModel.cs

        // private static void PreserveCustomMetadata(List<MetadataTable> newTableList, List<MetadataTable> oldTableList)
        // {
        // }
    }
}