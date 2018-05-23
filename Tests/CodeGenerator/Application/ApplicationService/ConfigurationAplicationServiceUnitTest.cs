// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigurationAplicationServiceUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Application.ApplicationService
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     Summary description for ConfigurationAplicationServiceUnitTest
    /// </summary>
    [TestClass]
    public class ConfigurationAplicationServiceUnitTest
    {
        #region Other Methods

        /// <summary>
        /// Create test values.
        /// </summary>
        /// <param name="applicationService">
        /// The application Service.
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

            Template template = new Template
                                    {
                                        ConfigLocation = ConfigLocation.Data,
                                        DataType = Guid.Empty,
                                        Id = Guid.NewGuid(),
                                        Name = "Template",
                                        Version = 1,
                                        TemplatePath = "Test.t4",
                                        LanguageOutputId =
                                            new Guid(
                                                ScaffoldConfig.LanguageOutputs[0].Metadata["ValueMetaData"]
                                                    .ToString()),
                                        GeneratorTypeId = new Guid(
                                            ScaffoldConfig.OutputGenerators[0].Metadata["ValueMetaData"]
                                                .ToString())
                                    };

            applicationService.ApplicationSettings.Templates.Add(template);
        }

        /// <summary>
        /// The test project definition.
        /// </summary>
        /// <param name="applicationService">
        /// The application service.
        /// </param>
        protected void TestProjectDefinition(IConfigurationApplicationService applicationService)
        {
            Assert.IsNotNull(applicationService.ApplicationSettings.DataTypes, "DataTypes should not be empty");
            Assert.AreEqual(5, applicationService.ApplicationSettings.DataTypes.Count, "There should be 5 DataTypes");
        }

        #endregion
    }
}