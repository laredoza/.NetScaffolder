// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataTypeUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Project
{
    #region Usings

    using System;

    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// The data type unit test.
    /// </summary>
    [TestClass]
    public class DataTypeUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// The data type unit test_ test.
        /// </summary>
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

        #endregion
    }
}