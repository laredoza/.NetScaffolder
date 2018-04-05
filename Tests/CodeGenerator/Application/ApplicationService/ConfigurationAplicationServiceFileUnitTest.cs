using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetScaffolder.Mapping.MetaData.Project;
using DotNetScaffolder.Mapping.ApplicationServices;

namespace DotNetScaffolder.Test.Application.ApplicationService
{
    /// <summary>
    /// Summary description for ConfigurationAplicationServiceFileUnitTest
    /// </summary>
    [TestClass]
    public class ConfigurationAplicationServiceFileUnitTest : ConfigurationAplicationServiceUnitTest
    {
        [TestMethod]
        public void ConfigurationAplicationServiceFileUnitTest_TestMethod1()
        {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = "Config.xml" };

            IConfigurationAplicationService applicationService = new ConfigurationAplicationServiceFile
            {
                FilePersistenceOptions = options
            };

            this.CreateTestValues(applicationService);
            applicationService.Save();
            applicationService.Load();
            this.TestProjectDefinition(applicationService);
        }
    }
}
