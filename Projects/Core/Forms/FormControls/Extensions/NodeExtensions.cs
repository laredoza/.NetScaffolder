// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NodeExtensions.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Extensions
{
    #region Usings

    using System.Windows.Forms;

    using global::Common.Logging;

    #endregion

    /// <summary>
    ///     The node extensions.
    /// </summary>
    public static class NodeExtensions
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// Moves node down.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        public static void MoveDown(this TreeNode node)
        {
            Logger.Trace($"Started MoveDown() for {node.Tag}");

            TreeNode parent = node.Parent;
            TreeView view = node.TreeView;
            if (parent != null)
            {
                int index = node.Index;
                if (index < parent.Nodes.Count - 1)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index + 1, node);
                    Logger.Trace($"New index for tag {node.Tag} is {index + 1}");
                }
            }
            else if (view != null && view.Nodes.Contains(node))
            {
                // root node
                int index = node.Index;
                if (index < view.Nodes.Count - 1)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index + 1, node);
                    Logger.Trace($"New index for tag {node.Tag} is {index + 1}");
                }
            }

            Logger.Trace($"Completed MoveDown() for {node.Tag}");
        }

        /// <summary>
        /// Moves node up.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        public static void MoveUp(this TreeNode node)
        {
            Logger.Trace($"Started MoveUp() for {node.Tag}");

            TreeNode parent = node.Parent;
            TreeView view = node.TreeView;
            if (parent != null)
            {
                int index = node.Index;
                if (index > 0)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index - 1, node);
                    node.TreeView.SelectedNode = node;
                    Logger.Trace($"New index for tag {node.Tag} is {index - 1}");
                }
            }
            else if (node.TreeView.Nodes.Contains(node))
            {
                // root node
                int index = node.Index;
                if (index > 0)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index - 1, node);
                    node.TreeView.SelectedNode = node;
                    Logger.Trace($"New index for tag {node.Tag} is {index - 1}");
                }
            }

            Logger.Trace($"Completed MoveUp() for {node.Tag}");
        }

        #endregion
    }
}