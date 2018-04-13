// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManageCollectionsTreeViewUserControlUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Presentation.Controls
{
    #region Usings

    using DotNetScaffolder.Presentation.Forms.Controls;

    using FormControls.TreeView;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     Summary description for ManageCollectionsTreeViewUserControlUnitTest
    /// </summary>
    [TestClass]
    public class ManageCollectionsTreeViewUserControlUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// The manage collections tree view user control unit test_ test method.
        /// </summary>
        [TestMethod]
        public void ManageCollectionsTreeViewUserControlUnitTest_TestMethod()
        {
            ManageCollectionsTreeViewUserControl treeView = new ManageCollectionsTreeViewUserControl();

            Hierarchy hierarchy = new Hierarchy { Name = "Template" };
            treeView.DataSource = hierarchy;
        }

        #endregion
    }
}