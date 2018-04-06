using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Core.Common.Forms
{
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;
    using FormControls.TreeView;

    /// <summary>
    /// Summary description for HierarchyTreeViewUnitTest
    /// </summary>
    [TestClass]
    public class HierarchyTreeViewUnitTest
    {
        [TestMethod]
        public void HierarchyTreeViewUnitTest_TestMethod1()
        {
            HierarchyTreeView treeView = new HierarchyTreeView();
            Hierarchy data = new Hierarchy { Name = "Parent" };
            data.Children.Add(new Hierarchy { Name = "Child 1" });
            data.Children.Add(new Hierarchy { Name = "Child 2" });
            data.Children[0].Children.Add(new Hierarchy { Name = "Child Child 1" });
            treeView.Data = data;
            Assert.IsNotNull(treeView.Nodes);
            Assert.AreEqual(1, treeView.Nodes.Count);
            Assert.AreEqual("Parent", treeView.Nodes[0].Text);
            Assert.AreEqual(data.Id.ToString(), treeView.Nodes[0].Name);
            Assert.IsNotNull(treeView.Nodes[0].Tag);
            Assert.AreEqual(data, treeView.Nodes[0].Tag as Hierarchy);
            Assert.IsNotNull(treeView.Nodes[0].Nodes);
            Assert.AreEqual(2, treeView.Nodes[0].Nodes.Count);
            Assert.AreEqual("Child 1", treeView.Nodes[0].Nodes[0].Text);
            Assert.AreEqual(1, treeView.Nodes[0].Nodes[0].Nodes.Count);
            Assert.AreEqual("Child Child 1", treeView.Nodes[0].Nodes[0].Nodes[0].Text);
        }

        [TestMethod]
        public void HierarchyTreeViewUnitTest_TestEnabledButtonsWhenTemplateNodeIsSelected()
        {
            HierarchyTreeView treeView = new HierarchyTreeView();
            Hierarchy data = new Hierarchy { Name = "Templates" };
            data.Children.Add(new Hierarchy { Name = "Context" });
            var template = new Template { DataType = Guid.Empty };
            //template.

            data.Children.Add(new Hierarchy { Name = "Entity", Item = template});
            data.Children[0].Children.Add(new Hierarchy { Name = "Entity FrameWork Context", HierarchyType = HierarchyType.Item});
            data.Children[1].Children.Add(new Hierarchy { Name = "Test 1", HierarchyType = HierarchyType.Item });
            data.Children[1].Children.Add(new Hierarchy { Name = "Test 1", HierarchyType = HierarchyType.Item });

            treeView.Data = data;

            // Test Level 1 (Template)
            treeView.SelectNode(treeView.Nodes[0]);
            Assert.AreEqual(false, treeView.UpEnabled);
            Assert.AreEqual(false, treeView.DownEnabled);
            Assert.AreEqual(false, treeView.DeleteEnabled);
            Assert.AreEqual(false, treeView.AddGroupEnabled);
            Assert.AreEqual(false, treeView.AddItemEnabled);

            // Test Level 2 (Context)
            treeView.SelectNode(treeView.Nodes[0].Nodes[0]);
            Assert.AreEqual(false, treeView.UpEnabled);
            Assert.AreEqual(false, treeView.DownEnabled);
            Assert.AreEqual(false, treeView.DeleteEnabled);
            Assert.AreEqual(true, treeView.AddGroupEnabled);
            Assert.AreEqual(true, treeView.AddItemEnabled);

            // Test Single Item (Entity FrameWork Context(v6))
            treeView.SelectNode(treeView.Nodes[0].Nodes[0].Nodes[0]);
            Assert.AreEqual(false, treeView.UpEnabled);
            Assert.AreEqual(false, treeView.DownEnabled);
            Assert.AreEqual(true, treeView.DeleteEnabled);
            Assert.AreEqual(false, treeView.AddGroupEnabled);
            Assert.AreEqual(true, treeView.AddItemEnabled);

            // Test Multiple Children Item 1 (Test 1)
            treeView.SelectNode(treeView.Nodes[0].Nodes[1].Nodes[0]);
            Assert.AreEqual(false, treeView.UpEnabled);
            Assert.AreEqual(true, treeView.DownEnabled);
            Assert.AreEqual(true, treeView.DeleteEnabled);
            Assert.AreEqual(false, treeView.AddGroupEnabled);
            Assert.AreEqual(true, treeView.AddItemEnabled);

            // Test Multiple Children Item 2 (Test 2)
            treeView.SelectNode(treeView.Nodes[0].Nodes[1].Nodes[1]);
            Assert.AreEqual(true, treeView.UpEnabled);
            Assert.AreEqual(false, treeView.DownEnabled);
            Assert.AreEqual(true, treeView.DeleteEnabled);
            Assert.AreEqual(false, treeView.AddGroupEnabled);
            Assert.AreEqual(true, treeView.AddItemEnabled);
        }
    }
}
