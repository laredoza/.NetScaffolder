// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComponentImporterUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components
{
    #region Usings

    using DotNetScaffolder.Components.Common;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The component importer unit test.
    /// </summary>
    [TestClass]
    public class ComponentImporterUnitTest
    {
        #region Public Methods And Operators

        /// <summary>
        ///     Tests the Component Importer
        /// </summary>
        [TestMethod]
        public void ComponentImporterUnitTest_Import()
        {
            ComponentImporter importer = new ComponentImporter();

            importer.Import();
            Assert.IsNotNull(importer.NamingConventions, "NamingConventions should not be null");
            Assert.AreEqual(4, importer.NamingConventions.Length, "There should be 4 NamingConventions");
            Assert.IsNotNull(importer.SourceTypes, "SourceTypes should not be null");
            Assert.AreEqual(4, importer.SourceTypes.Length, "There should be 4 SourceTypes");
            Assert.IsNotNull(importer.Drivers, "DriverTypes should not be null");
            Assert.AreEqual(9, importer.Drivers.Length, "There should be 9 DriverType");
            Assert.AreEqual(2, importer.LanguageOutputs.Length, "There should be 2 LanguageOutput");
            Assert.AreEqual(1, importer.OutputGenerators.Length, "There should be 1 OutputGenerator");
            Assert.AreEqual(9, importer.DataTypes.Length, "There should be 9 DataTypes");
        }

        #endregion
    }
}