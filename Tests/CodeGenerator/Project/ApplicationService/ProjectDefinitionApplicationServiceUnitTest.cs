// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinitionApplicationServiceUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Project.ApplicationService
{
    #region Usings

    using System;

    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The base project definition application service unit test.
    ///     It is used to create test values, as well as test those values once it's been loaded
    ///     by the ApplicationService implementation
    /// </summary>
    [TestClass]
    public class ProjectDefinitionApplicationServiceUnitTest
    {
        #region Other Methods

        /// <summary>
        /// Create test values.
        /// </summary>
        /// <param name="projectDefinition">
        /// The project definition.
        /// </param>
        protected void CreateTestValues(ProjectDefinition projectDefinition)
        {
            projectDefinition.OutputFolder = "Out";
            projectDefinition.BaseNameSpace = "Test";
            projectDefinition.GroupBy = GenerationType.Domain;
            projectDefinition.ModelPath = "test.mdl";
            projectDefinition.Version = 0.1;
            projectDefinition.Domains.Add(new DomainDefinition
                                              {
                                                  Name = "Security"
                                              });
            projectDefinition.Domains[0].NamingConventionId = Guid.NewGuid();
            projectDefinition.Domains[0].SourceTypeId = Guid.NewGuid();
            projectDefinition.Domains[0].DriverId = Guid.NewGuid();
            projectDefinition.Domains[0].DriverTypeId = Guid.NewGuid();
        }

        /// <summary>
        /// Test AddDomain.
        /// </summary>
        /// <param name="applicationService">
        /// The application service.
        /// </param>
        protected void TestAddDomain(IProjectDefinitionApplicationService applicationService)
        {
            DomainDefinition domain = applicationService.AddDomain();
            Assert.AreEqual(1, applicationService.ProjectDefinition.Domains.Count, "There should be 1 domain");
            Assert.AreEqual("Domain1", domain.Name, "The domain name should be Domain1");
            domain = applicationService.AddDomain();
            Assert.AreEqual(2, applicationService.ProjectDefinition.Domains.Count, "There should be 2 domains");
            Assert.AreEqual("Domain2", domain.Name, "The domain name should be Domain2");
            domain = applicationService.AddDomain();
            Assert.AreEqual(3, applicationService.ProjectDefinition.Domains.Count, "There should be 3 domains");
            Assert.AreEqual("Domain3", domain.Name, "The domain name should be Domain3");
            applicationService.ProjectDefinition.Domains[0].Name = "A";
            domain = applicationService.AddDomain();
            Assert.AreEqual(4, applicationService.ProjectDefinition.Domains.Count, "There should be 4 domains");
            Assert.AreEqual("Domain1", domain.Name, "The domain name should be Domain1");
        }

        /// <summary>
        /// Test TestDeleteDomain.
        /// </summary>
        /// <param name="applicationService">
        /// The application service.
        /// </param>
        protected void TestDeleteDomain(IProjectDefinitionApplicationService applicationService)
        {
            DomainDefinition domain = applicationService.AddDomain();
            Assert.AreEqual(1, applicationService.ProjectDefinition.Domains.Count, "There should be 1 domain");
            domain = applicationService.AddDomain();
            Assert.AreEqual(2, applicationService.ProjectDefinition.Domains.Count, "There should be 2 domains");

            Guid id = applicationService.ProjectDefinition.Domains[0].Id;
            applicationService.Delete(id);
            Assert.AreEqual(1, applicationService.ProjectDefinition.Domains.Count, "There should be 1 domain");

            id = applicationService.ProjectDefinition.Domains[0].Id;
            applicationService.Delete(id);
            Assert.AreEqual(0, applicationService.ProjectDefinition.Domains.Count, "There should be 0 domains");
        }

        /// <summary>
        /// Tests project definition values.
        /// </summary>
        /// <param name="projectDefinition">
        /// The project definition.
        /// </param>
        protected void TestProjectDefinition(ProjectDefinition projectDefinition)
        {
            Assert.AreEqual("Out", projectDefinition.OutputFolder, "OutputFolder should have a value of Out");
            Assert.AreEqual("Test", projectDefinition.BaseNameSpace, "BaseNameSpace should have a value of Test");
            Assert.AreEqual(GenerationType.Domain, projectDefinition.GroupBy, "GroupBy should have a value of Domain");
            Assert.AreEqual("test.mdl", projectDefinition.ModelPath, "ModelPath should have a value of test.mdl");
            Assert.AreEqual(0.1, projectDefinition.Version, "Version should have a value of 0.1");
            Assert.IsNotNull(projectDefinition.Domains);
            Assert.AreEqual(1, projectDefinition.Domains.Count, "There should be 1 domain");
            Assert.AreEqual("Security", projectDefinition.Domains[0].Name, "Domain name should be Security");
        }

        /// <summary>
        /// The test validation.
        /// </summary>
        /// <param name="applicationService">
        /// The application service.
        /// </param>
        protected void TestValidation(IProjectDefinitionApplicationService applicationService)
        {
            DomainDefinition domain = new DomainDefinition();
            domain.Id = Guid.Empty;

            applicationService.ProjectDefinition.Domains.Add(domain);
            applicationService.Validate();
            Assert.AreEqual(10, applicationService.ValidationResult.Count, "There should be 10 validation errors");

            applicationService.ProjectDefinition.BaseNameSpace = "a";
            applicationService.ProjectDefinition.OutputFolder = "b";
            applicationService.ProjectDefinition.Version = 0.1;
            applicationService.ProjectDefinition.ModelPath = "c";
            applicationService.ProjectDefinition.Domains[0].NamingConventionId = Guid.NewGuid();
            applicationService.ProjectDefinition.Domains[0].SourceTypeId = Guid.NewGuid();
            applicationService.ProjectDefinition.Domains[0].DriverId = Guid.NewGuid();
            applicationService.ProjectDefinition.Domains[0].DriverTypeId = Guid.NewGuid();

            domain.Name = "Test Domain";
            domain.Id = Guid.NewGuid();
            applicationService.Validate();

            Assert.AreEqual(0, applicationService.ValidationResult.Count, "There should be 0 validation errors");
        }

        #endregion
    }
}