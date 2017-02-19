using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;

namespace DotNetScaffolder.Test.Project
{
    [TestClass]
    public class DataTypeUnitTest
    {
        [TestMethod]
        public void DataTypeUnitTest_Test()
        {
            DataType dataType = new DataType();
            dataType.Validate();

            Assert.IsNotNull(dataType.ValidationResult, "Validation result should not be null");
            Assert.AreEqual(2, dataType.ValidationResult.Count, "There should be 2 errors");

            dataType.Name = "Test";
            dataType.Validate();
            Assert.AreEqual(1, dataType.ValidationResult.Count, "There should be 1 error");

            dataType.Id = Guid.NewGuid();

            dataType.Validate();
            Assert.AreEqual(0, dataType.ValidationResult.Count, "There should be 0 errors");
        }
    }
}
