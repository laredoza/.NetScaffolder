﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDomainUserControlUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Presentation.Controls
{
    #region Usings

    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Presentation.Forms.Controls;
    using DotNetScaffolder.Presentation.Forms.Controls.Project;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The project domain user control unit test.
    /// </summary>
    [TestClass]
    public class ProjectDomainUserControlUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The project domain user control unit test_ test.
        /// </summary>
        [TestMethod]
        public void ProjectDomainUserControlUnitTest_Test()
        {
            ProjectDomainUserControl domainControl = new ProjectDomainUserControl();
            domainControl.ApplicationService = new ProjectDefinitionApplicationServiceFile();

            Assert.AreEqual(
                0,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 0 domains");
            Assert.AreEqual(false, domainControl.EnableDeleteButton, "EnableDeleteButton should be false");

            domainControl.AddDomain();
            Assert.AreEqual(
                1,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 1 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.AddDomain();
            Assert.AreEqual(
                2,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 2 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.AddDomain();
            Assert.AreEqual(
                3,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 3 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.DeleteDomain(domainControl.ApplicationService.ProjectDefinition.Domains[1].Id);
            Assert.AreEqual(
                2,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 2 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.DeleteDomain(domainControl.ApplicationService.ProjectDefinition.Domains[0].Id);
            Assert.AreEqual(
                1,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 1 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.DeleteDomain(domainControl.ApplicationService.ProjectDefinition.Domains[0].Id);
            Assert.AreEqual(
                0,
                domainControl.ApplicationService.ProjectDefinition.Domains.Count,
                "There should be 0 domains");
            Assert.AreEqual(false, domainControl.EnableDeleteButton, "EnableDeleteButton should be false");
        }

        #endregion
    }
}