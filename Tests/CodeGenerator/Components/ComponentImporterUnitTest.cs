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
            Assert.AreEqual(3, importer.NamingConventions.Length, "There should be 3 NamingConventions");
            Assert.IsNotNull(importer.SourceTypes, "SourceTypes should not be null");
            Assert.AreEqual(1, importer.SourceTypes.Length, "There should be 1 SourceType");
            Assert.IsNotNull(importer.Drivers, "DriverTypes should not be null");
            Assert.AreEqual(1, importer.Drivers.Length, "There should be 1 DriverType");
            Assert.AreEqual(1, importer.LanguageOutputs.Length, "There should be 1 LanguageOutput");
            Assert.AreEqual(1, importer.OutputGenerators.Length, "There should be 1 OutputGenerator");
        }

        #endregion
    }
}