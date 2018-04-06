using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetScaffolder.Mapping.ApplicationServices;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;
using DotNetScaffolder.Mapping.MetaData.Enum;
using Configuration;

namespace DotNetScaffolder.Test.Application.ApplicationService
{
    /// <summary>
    /// Summary description for ConfigurationAplicationServiceUnitTest
    /// </summary>
    [TestClass]
    public class ConfigurationAplicationServiceUnitTest
    {
        /// <summary>
        /// Create test values.
        /// </summary>
        /// <param name="projectDefinition">
        /// The project definition.
        /// </param>
        protected void CreateTestValues(IConfigurationApplicationService applicationService)
        {
            List<DataType> dataTypes = new List<DataType>();
            dataTypes.Add(new DataType { Id = Guid.NewGuid(), Name = "Context" });
            dataTypes.Add(new DataType { Id = Guid.NewGuid(), Name = "Entity" });
            dataTypes.Add(new DataType { Id = Guid.NewGuid(), Name = "Repository" });
            dataTypes.Add(new DataType { Id = Guid.NewGuid(), Name = "Application Service" });
            dataTypes.Add(new DataType { Id = Guid.NewGuid(), Name = "ViewModel" });
            applicationService.ApplicationSettings.DataTypes = dataTypes;

            ScaffoldConfig.Load();

            Template template = new Template {
                ConfigLocation = ConfigLocation.Data,
                DataType = dataTypes[0],
                Id = Guid.NewGuid(),
                Name = "Template",
                Version =1,
                TemplatePath = "Test.t4",
                LanguageOutputId = new Guid(ScaffoldConfig.LanguageOutputs[0].Metadata["ValueMetaData"].ToString()),
                GeneratorTypeId = new Guid(ScaffoldConfig.OutputGenerators[0].Metadata["ValueMetaData"].ToString()),
            };

            applicationService.ApplicationSettings.Templates.Add(template);
        }

        protected void TestProjectDefinition(IConfigurationApplicationService applicationService)
        {
            Assert.IsNotNull(applicationService.ApplicationSettings.DataTypes, "DataTypes should not be empty");
            Assert.AreEqual(5, applicationService.ApplicationSettings.DataTypes.Count, "There should be 5 DataTypes");
        }

    }
}
