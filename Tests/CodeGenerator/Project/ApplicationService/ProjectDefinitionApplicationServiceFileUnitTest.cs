// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinitionApplicationServiceFileUnitTest.cs" company="">
//   
// </copyright>
// <summary>
//   The project definition application service file unit test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeGenerator.Test.Project.ApplicationService
{
    #region Using

    using MetaData.Project;
    using MetaData.Project.ApplicationServices;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// The project definition application service file unit test.
    /// Tests Loading and saving project details in xml
    /// </summary>
    [TestClass]
    public class ProjectDefinitionApplicationServiceFileUnitTest : ProjectDefinitionApplicationServiceUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// Tests Loading and saving project details in xml
        /// </summary>
        [TestMethod]
        public void ProjectDefinitionApplicationServiceFileUnitTest_Test()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Test.mdl" };
            IProjectDefinitionApplicationService applicationService = new ProjectDefinitionApplicationServiceFile
                                                                          {
                                                                              FilePersistenceOptions
                                                                                  =
                                                                                  options
                                                                          };
            this.CreateTestValues(applicationService.ProjectDefinition);
            applicationService.Save();
            applicationService.Load();
            this.TestProjectDefinition(applicationService.ProjectDefinition);
        }

        /// <summary>
        /// Tests validation
        /// </summary>
        [TestMethod]
        public void ProjectDefinitionApplicationServiceFileUnitTest_Validation()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Test.mdl" };
            IProjectDefinitionApplicationService applicationService = new ProjectDefinitionApplicationServiceFile
            {
                FilePersistenceOptions = options
            };

            this.TestValidation(applicationService);
        }

        #endregion
    }
}