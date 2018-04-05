using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Presentation.Controls
{
    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Presentation.Forms.Controls;

    [TestClass]
    public class ProjectDomainUserControlUnitTest
    {
        [TestMethod]
        public void ProjectDomainUserControlUnitTest_Test()
        {
            ProjectDomainUserControl domainControl = new ProjectDomainUserControl();
            domainControl.ApplicationService = new ProjectDefinitionApplicationServiceFile();
            
            Assert.AreEqual(0, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 0 domains");
            Assert.AreEqual(false, domainControl.EnableDeleteButton, "EnableDeleteButton should be false");

            domainControl.AddDomain();
            Assert.AreEqual(1, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 1 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.AddDomain();
            Assert.AreEqual(2, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 2 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.AddDomain();
            Assert.AreEqual(3, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 3 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.DeleteDomain(domainControl.ApplicationService.ProjectDefinition.Domains[1].Id);
            Assert.AreEqual(2, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 2 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.DeleteDomain(domainControl.ApplicationService.ProjectDefinition.Domains[0].Id);
            Assert.AreEqual(1, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 1 domain");
            Assert.AreEqual(true, domainControl.EnableDeleteButton, "EnableDeleteButton should be true");

            domainControl.DeleteDomain(domainControl.ApplicationService.ProjectDefinition.Domains[0].Id);
            Assert.AreEqual(0, domainControl.ApplicationService.ProjectDefinition.Domains.Count, "There should be 0 domains");
            Assert.AreEqual(false, domainControl.EnableDeleteButton, "EnableDeleteButton should be false");
        }
    }
}
