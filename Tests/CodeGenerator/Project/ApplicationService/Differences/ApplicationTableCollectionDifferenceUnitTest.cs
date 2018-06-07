// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationTableCollectionDifferenceUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Project.ApplicationService.Differences
{
    #region Usings

    using System.IO;

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// The application table collection difference unit test.
    /// </summary>
    [TestClass]
    public class ApplicationTableCollectionDifferenceUnitTest : BaseApplicationTableCollectionDifferenceUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        /// The test method 1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            EdmxSourceType import = new EdmxSourceType();
            this.SourceType = import;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\DataSource\model.edmx");
            DatabaseModel originalDatabaseModel = import.Import(new FileSourceOptions { Path = filePath });
            DatabaseModel changedDatabaseModel = import.Import(new FileSourceOptions { Path = filePath });

            this.Differences = new ApplicationTableCollectionDifference(new ApplicationTableDifference());
            this.BaseApplicationTableCollectionDifferenceUnitTest_RunTests(originalDatabaseModel, changedDatabaseModel);
        }

        #endregion
    }
}