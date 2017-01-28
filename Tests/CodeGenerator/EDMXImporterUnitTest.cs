namespace CodeGenerator.Test
{
    using System.IO;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The edmx importer.
    /// </summary>
    [TestClass]
    public class EdmxImporter
    {
        #region Public Methods and Operators

        /// <summary>
        /// The load edmx.
        /// </summary>
        [TestMethod]
        public void LoadEdmx()
        {
            //var dataSource = new EdmxMetadataSource();
            //string filePAth = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\DataSource\model.edmx");
            //MetadataTableCollection data = dataSource.LoadSource(filePAth);
            //Assert.AreEqual(9, data.Tables.Count, "Nine tables were expected");
            //Assert.IsNotNull(
            //    data.Tables.First(t => t.TableName == "BankAccount"), 
            //    "The BankAccount table does not exist");
            //Assert.AreEqual(
            //    5, 
            //    data.Tables.First(t => t.TableName == "BankAccount").Columns.Count, 
            //    "Bank Account should have 5 columns");
            //Assert.AreEqual(
            //    3, 
            //    data.Tables.First(t => t.TableName == "BankAccount").RelationShips.Count, 
            //    "Bank Account should have 3 relationships");
        }

        #endregion
    }
}