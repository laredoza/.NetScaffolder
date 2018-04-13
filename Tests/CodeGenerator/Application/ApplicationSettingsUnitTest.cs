// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationSettingsUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Application
{
    #region Usings

    using DotNetScaffolder.Mapping.MetaData.Application;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// The application settings unit test.
    /// </summary>
    [TestClass]
    public class ApplicationSettingsUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// The application settings unit test_ test.
        /// </summary>
        [TestMethod]
        public void ApplicationSettingsUnitTest_Test()
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
            applicationSettings.DataTypes.Add(new DataType());
            applicationSettings.Templates.Add(new Template());

            applicationSettings.Validate();
            Assert.IsNotNull(applicationSettings.ValidationResult);
            Assert.AreEqual(10, applicationSettings.ValidationResult.Count);
        }

        #endregion
    }
}