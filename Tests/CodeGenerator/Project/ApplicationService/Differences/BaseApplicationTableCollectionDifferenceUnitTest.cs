using System;
using DotNetScaffolder.Mapping.ApplicationServices.Differences;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Project.ApplicationService.Differences
{
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    /// <summary>
    /// The base application table collection difference unit test.
    /// </summary>
    [TestClass]
    public class BaseApplicationTableCollectionDifferenceUnitTest
    {
        /// <summary>
        /// Gets or sets the difference.
        /// </summary>
        public IApplicationTableCollectionDifference Differences { get; set; }

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        [TestMethod]
        public void BaseApplicationTableCollectionDifferenceUnitTest_RunTests(DatabaseModel originalDatabaseModel, DatabaseModel changedDatabaseModel)
        {
            this.BaseApplicationTableCollectionDifferenceUnitTest_TestNodifferencea(originalDatabaseModel, changedDatabaseModel);
        }

        private void BaseApplicationTableCollectionDifferenceUnitTest_TestNodifference
            (DatabaseModel originalDatabaseModel, DatabaseModel changedDatabaseModel)
        {
            ApplicationTableCollectionDifference differences = this.Differences.CompareTables(
                originalDatabaseModel.Tables,
                changedDatabaseModel.Tables);
            Assert.AreEqual(0, differences.FirstExtraTables.Count, "There Should be 0 Extra tables");
            Assert.AreEqual(0, differences.FirstMissingTables.Count, "There Should be 0 missing tables");
            Assert.AreEqual(0, differences.ProblemTables.Count, "There Should be 0 problem tables");
            Assert.AreEqual(0, differences.RefreshTable.Count, "There Should be 0 refresh tables");
        }
    }
}
