using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Project.ApplicationService.Differences
{
    using System.IO;

    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.MetaData.Model;

    [TestClass]
    public class ApplicationTableCollectionDifferenceUnitTest : BaseApplicationTableCollectionDifferenceUnitTest
    {
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
    }
}
