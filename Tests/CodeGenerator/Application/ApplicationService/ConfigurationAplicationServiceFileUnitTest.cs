// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigurationAplicationServiceFileUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Application.ApplicationService
{
    #region Usings

    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Project;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     Summary description for ConfigurationAplicationServiceFileUnitTest
    /// </summary>
    [TestClass]
    public class ConfigurationAplicationServiceFileUnitTest : ConfigurationAplicationServiceUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// The configuration aplication service file unit test_ test method 1.
        /// </summary>
        [TestMethod]
        public void ConfigurationAplicationServiceFileUnitTest_TestMethod1()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Config.xml" };

            IConfigurationApplicationService applicationService = new ConfigurationApplicationServiceFile
                                                                      {
                                                                          FilePersistenceOptions = options
                                                                      };

            CreateTestValues(applicationService);
            applicationService.Save();
            applicationService.Load();
            TestProjectDefinition(applicationService);
        }

        #endregion
    }
}