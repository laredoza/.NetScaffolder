using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Presentation.Controls
{
    using Configuration;

    using DotNetScaffolder.Mapping.MetaData.Project.ApplicationServices;
    using DotNetScaffolder.Presentation.Forms.Controls;

    [TestClass]
    public class ProjectDomainDetailsUserControlUnitTest
    {
        [TestMethod]
        public void ProjectDomainDetailsUserControlUnitTest_Test()
        {
            ScaffoldConfig.Load();

            ProjectDomainDetailsUserControl control = new ProjectDomainDetailsUserControl
                                                          {
                                                              ApplicationService =
                                                                  new ProjectDefinitionApplicationServiceFile
                                                                  ()
                                                          };

            control.ApplicationService.AddDomain();
            control.SelectedDomain = control.ApplicationService.ProjectDefinition.Domains[0];

            Assert.AreEqual(1, control.ReturnDriverTypes().Length, "There should 1 DriverType");
            Assert.AreEqual(3, control.ReturnNamingConventions().Length, "Three should 3 NamingConventionId");
            Assert.AreEqual(1, control.ReturnSourceTypes().Length, "There should 1 Sourcetype");
        }
    }
}
