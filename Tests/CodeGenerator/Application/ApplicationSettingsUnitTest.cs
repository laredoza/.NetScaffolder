using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetScaffolder.Mapping.MetaData.Application;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;

namespace DotNetScaffolder.Test.Application
{
    [TestClass]
    public class ApplicationSettingsUnitTest
    {
        [TestMethod]
        public void ApplicationSettingsUnitTest_Test()
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
            applicationSettings.DataTypes.Add(new DataType());
            applicationSettings.Templates.Add(new Template());

            applicationSettings.Validate();
            Assert.IsNotNull(applicationSettings.ValidationResult);
            Assert.AreEqual(6, applicationSettings.ValidationResult.Count);
        }
    }
}
