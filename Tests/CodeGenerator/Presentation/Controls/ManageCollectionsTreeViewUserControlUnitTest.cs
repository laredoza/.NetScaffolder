using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Presentation.Controls
{
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls;

    using FormControls.TreeView;

    /// <summary>
    /// Summary description for ManageCollectionsTreeViewUserControlUnitTest
    /// </summary>
    [TestClass]
    public class ManageCollectionsTreeViewUserControlUnitTest
    {
        [TestMethod]
        public void ManageCollectionsTreeViewUserControlUnitTest_TestMethod()
        {
            ManageCollectionsTreeViewUserControl treeView = new ManageCollectionsTreeViewUserControl();

            Hierarchy hierarchy = new Hierarchy { Name = "Template" };
            treeView.DataSource = hierarchy;
        }
    }
}
