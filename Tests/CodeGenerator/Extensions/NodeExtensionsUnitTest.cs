namespace DotNetScaffolder.Test.Extensions
{
    using System.Windows.Forms;

    using DotNetScaffolder.Core.Extensions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NodeExtensionsUnitTest
    {
        /// <summary>
        /// Tests moving a child item up or down. It also tests moving the top child up, or moving the bottom item down
        /// </summary>
        [TestMethod]
        public void NodeExtensionsUnitTest_Test()
        {
            TreeView treeView = new TreeView();
            TreeNode parent1 = new TreeNode { Text = "Parent 1", Tag = "Parent1" };
            parent1.Nodes.Add(new TreeNode { Text = "a", Tag = "1a" });
            parent1.Nodes.Add(new TreeNode { Text = "b", Tag = "1b" });
            treeView.Nodes.Add(parent1);

            TreeNode parent2 = new TreeNode { Text = "Parent 2", Tag = "Parent1" };
            parent2.Nodes.Add(new TreeNode { Text = "a", Tag = "2a" });
            parent2.Nodes.Add(new TreeNode { Text = "b", Tag = "2b" });
            treeView.Nodes.Add(parent2);

            // Moving 2nd item above first
            parent2.Nodes[1].MoveUp();
            Assert.AreEqual("2b", parent2.Nodes[0].Tag, "Invalid node after MoveUp()");
            Assert.AreEqual("2a", parent2.Nodes[1].Tag, "Invalid node after MoveUp()");
            Assert.AreEqual("2b", treeView.SelectedNode.Tag, "Invalid node after MoveUp()");

            // Move first item up, nothing should happen
            parent2.Nodes[0].MoveUp();
            Assert.AreEqual("2b", parent2.Nodes[0].Tag, "Invalid node after MoveUp()");
            Assert.AreEqual("2a", parent2.Nodes[1].Tag, "Invalid node after MoveUp()");
            Assert.AreEqual("2b", treeView.SelectedNode.Tag, "Invalid node after MoveUp()");

            // Move first item down
            parent2.Nodes[0].MoveDown();
            Assert.AreEqual("2a", parent2.Nodes[0].Tag, "Invalid node after MoveDown()");
            Assert.AreEqual("2b", parent2.Nodes[1].Tag, "Invalid node after MoveDown()");
            Assert.AreEqual("2b", treeView.SelectedNode.Tag, "Invalid node after MoveDown()");

            // Move last item down, nothing should happen
            parent2.Nodes[1].MoveDown();
            Assert.AreEqual("2a", parent2.Nodes[0].Tag, "Invalid node after MoveDown()");
            Assert.AreEqual("2b", parent2.Nodes[1].Tag, "Invalid node after MoveDown()");
            Assert.AreEqual("2b", treeView.SelectedNode.Tag, "Invalid node after MoveDown()");
        }
    }
}
