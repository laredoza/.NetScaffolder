// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableHierarchyService.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Templates
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.ApplicationServices.Tables;

    using FormControls.TreeView;

    using Table = DotNetScaffolder.Mapping.MetaData.Model.Table;

    #endregion

    /// <summary>
    ///     The tempate hierarchy service.
    /// </summary>
    public class TempateHierarchyService : ITableHierarchyService
    {
        #region Public Methods And Operators

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
                var node = new TreeNode
                               {
                                   Tag = item.Item,
                                   Text = item.Name,
                                   Name = item.Id.ToString() 
                               };
                nodes.Add(node);

                node.Nodes.AddRange(this.ConvertHierarchyToNodes(item.Children).ToArray());
            }

            return nodes;
        }

        #endregion
    }
}