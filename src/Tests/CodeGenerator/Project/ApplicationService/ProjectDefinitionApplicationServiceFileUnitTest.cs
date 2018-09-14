// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinitionApplicationServiceFileUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Project.ApplicationService
{
    #region Usings

    using DotNetScaffolder.Mapping.ApplicationServices;

    #region Using

    using DotNetScaffolder.Mapping.MetaData.Project;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    #endregion

    /// <summary>
    ///     The project definition application service file unit test.
    ///     Tests Loading and saving project details in xml
    /// </summary>
    [TestClass]
    public class ProjectDefinitionApplicationServiceFileUnitTest : ProjectDefinitionApplicationServiceUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The project definition application service file unit test_ add domain.
        /// </summary>
        [TestMethod]
        public void ProjectDefinitionApplicationServiceFileUnitTest_AddDomain()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Test.mdl" };
            IProjectDefinitionApplicationService applicationService =
                new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };

            this.TestAddDomain(applicationService);
        }

        /// <summary>
        ///     The project definition application service file unit test_ delete domain.
        /// </summary>
        [TestMethod]
        public void ProjectDefinitionApplicationServiceFileUnitTest_DeleteDomain()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Test.mdl" };
            IProjectDefinitionApplicationService applicationService =
                new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };

            this.TestDeleteDomain(applicationService);
        }

        /// <summary>
        ///     Tests Loading and saving project details in xml
        /// </summary>
        [TestMethod]
        public void ProjectDefinitionApplicationServiceFileUnitTest_Test()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Test.mdl" };
            IProjectDefinitionApplicationService applicationService =
                new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };
            this.CreateTestValues(applicationService.ProjectDefinition);
            applicationService.Save();
            applicationService.Load();
            this.TestProjectDefinition(applicationService.ProjectDefinition);
        }

        /// <summary>
        ///     Tests validation
        /// </summary>
        [TestMethod]
        public void ProjectDefinitionApplicationServiceFileUnitTest_Validation()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Test.mdl" };
            IProjectDefinitionApplicationService applicationService =
                new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };

            this.TestValidation(applicationService);
        }

        #endregion
    }
}