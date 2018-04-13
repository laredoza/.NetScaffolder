// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDetailsUserControlUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Presentation.Controls
{
    #region Usings

    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Presentation.Forms.Controls;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The project details user control unit test.
    /// </summary>
    [TestClass]
    public class ProjectDetailsUserControlUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The project details user control unit test_ test method.
        /// </summary>
        [TestMethod]
        public void ProjectDetailsUserControlUnitTest_TestMethod()
        {
            ProjectDetailsUserControl projectDetails = new ProjectDetailsUserControl();
            projectDetails.Project = new ProjectDefinition();

            Assert.AreEqual(2, projectDetails.Validation(), "There should be 2 errors.");
            projectDetails.Project.BaseNameSpace = "a";
            Assert.AreEqual(1, projectDetails.Validation(), "There should be 1 error.");
            projectDetails.Project.OutputFolder = "b";
            Assert.AreEqual(0, projectDetails.Validation(), "There should be 0 errors.");
        }

        #endregion
    }
}