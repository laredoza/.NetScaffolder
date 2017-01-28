// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComponentImporterUnitTest.cs" company="">
//   
// </copyright>
// <summary>
//   The component importer unit test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components
{
    #region Using

    using DotNetScaffolder.Components.Common;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// The component importer unit test.
    /// </summary>
    [TestClass]
    public class ComponentImporterUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// Tests the Component Importer
        /// </summary>
        [TestMethod]
        public void ComponentImporterUnitTest_Import()
        {
            ComponentImporter importer = new ComponentImporter();

            importer.Import();
            Assert.IsNotNull(importer.NamingConventions, "NamingConventions should not be null");
            Assert.AreEqual(2, importer.NamingConventions.Length, "There should be 2 NamingConventions");
            Assert.IsNotNull(importer.SourceTypes, "SourceTypes should not be null");
            Assert.AreEqual(1, importer.SourceTypes.Length, "There should be 1 SourceType");
            Assert.IsNotNull(importer.DriverTypes, "DriverTypes should not be null");
            Assert.AreEqual(1, importer.DriverTypes.Length, "There should be 1 DriverType");
        }

        #endregion
    }
}