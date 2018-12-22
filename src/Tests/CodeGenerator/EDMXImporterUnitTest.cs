// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EDMXImporterUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test
{
    #region Usings

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The edmx importer.
    /// </summary>
    [TestClass]
    public class EdmxImporter
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The load edmx.
        /// </summary>
        [TestMethod]
        public void LoadEdmx()
        {
            // var dataSource = new EdmxMetadataSource();
            // string filePAth = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\DataSource\model.edmx");
            // MetadataTableCollection data = dataSource.LoadSource(filePAth);
            // Assert.AreEqual(9, data.Tables.Count, "Nine tables were expected");
            // Assert.IsNotNull(
            // data.Tables.First(t => t.ApplicationServiceName == "BankAccount"), 
            // "The BankAccount table does not exist");
            // Assert.AreEqual(
            // 5, 
            // data.Tables.First(t => t.ApplicationServiceName == "BankAccount").Columns.Count, 
            // "Bank Account should have 5 columns");
            // Assert.AreEqual(
            // 3, 
            // data.Tables.First(t => t.ApplicationServiceName == "BankAccount").Relationships.Count, 
            // "Bank Account should have 3 Relationships");
        }

        #endregion
    }
}