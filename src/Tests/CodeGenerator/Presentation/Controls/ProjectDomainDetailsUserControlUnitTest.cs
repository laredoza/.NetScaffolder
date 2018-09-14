// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDomainDetailsUserControlUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Presentation.Controls
{
    #region Usings

    using System;

    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Presentation.Forms.Controls;
    using DotNetScaffolder.Presentation.Forms.Controls.Project;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The project domain details user control unit test.
    /// </summary>
    [TestClass]
    public class ProjectDomainDetailsUserControlUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The project domain details user control unit test_ test.
        /// </summary>
        [TestMethod]
        public void ProjectDomainDetailsUserControlUnitTest_Test()
        {
            ScaffoldConfig.Load();

            ProjectDomainDetailsUserControl control =
                new ProjectDomainDetailsUserControl
                    {
                        ApplicationService =
                            new ProjectDefinitionApplicationServiceFile()
                    };

            control.ApplicationService.AddDomain();

            // control.ApplicationService.ProjectDefinition.Domains[0].DriverTypeId;
            // new Guid(ScaffoldConfig.LanguageOutputs[0].Metadata["ValueMetaData"].ToString())
            control.SelectedDomain = control.ApplicationService.ProjectDefinition.Domains[0];

            Assert.AreEqual(1, control.ReturnDrivers().Length, "There should 1 DriverType");
            Assert.AreEqual(3, control.ReturnNamingConventions().Length, "Three should 3 NamingConventionId");
            Assert.AreEqual(1, control.ReturnSourceTypes().Length, "There should 1 Sourcetype");
        }

        #endregion
    }
}