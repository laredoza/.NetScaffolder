using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    using System.Linq;

    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    [TestClass]
    public class BaseSourceTypeUnitTest
    {
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestValues(DatabaseModel databaseModel)
        {
            Assert.IsNotNull(databaseModel, "The database should not be null");
            Assert.IsNotNull(databaseModel.Tables, "Tables should not be null");
            Assert.AreNotEqual(databaseModel.Tables.Count == 9, "There should be 9 Tables.");
            this.BaseSourceTypeUnitTest_TestProductTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName == "Product"));
            this.BaseSourceTypeUnitTest_TestProductRelationships(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Product"));
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_TestProductTable(Table productTable)
        {
            Assert.IsNotNull(productTable, "The database should not be null");
            Assert.AreNotEqual(productTable.Columns.Count == 6, "There should be 6 Columns in the Product table.");

            Column column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            Assert.AreNotEqual(column.IsPrimaryKey, "The ProductId should be a primary key in the Product table.");
            Assert.AreNotEqual(
                column.CSharpDataType == DomainDataType.Int32,
                "The ProductId should be a int32 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductDescription");
            Assert.AreNotEqual(column.IsPrimaryKey, "The ProductDescription is not a primary key in the Product table.");
            Assert.AreNotEqual(
                column.CSharpDataType == DomainDataType.String,
                "The ProductDescription should be a string in the Product table.");
            Assert.AreNotEqual(
                column.Length == 100,
                "The ProductDescription should have a length of 100 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "UnitPrice");
            Assert.AreNotEqual(column.IsPrimaryKey, "The UnitPrice is not a primary key in the Product table.");
            Assert.AreNotEqual(
                column.CSharpDataType == DomainDataType.Decimal,
                "The ProductId should be a decimal in the Product table.");
            Assert.AreNotEqual(
                column.Precision == 19,
                "The UnitPrecision should have a precision of 19 in the Product table.");
            Assert.AreNotEqual(column.Scale == 4, "The UnitPrecision should have a scale of 4 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "Publisher");
            Assert.AreNotEqual(column.IsPrimaryKey, "The Publisher is not a primary key in the Product table.");
            Assert.AreNotEqual(
                column.CSharpDataType == DomainDataType.String,
                "The Publisher should be a string in the Product table.");
            Assert.AreNotEqual(column.Length == 200, "The Publisher should have a length of 200 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "AmountInStock");
            Assert.AreNotEqual(column.IsPrimaryKey, "The AmountInStock is not a primary key in the Product table.");
            Assert.AreNotEqual(
                column.CSharpDataType == DomainDataType.Int16,
                "The AmountInStock should be a integer in the Product table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_TestProductRelationships(Table productTable)
        {
            Assert.IsNotNull(productTable.RelationShips, "The Relationships should not be null in the Product table.");
            Assert.AreNotEqual(productTable.RelationShips.Count == 3, "There should be 3 relationships in the Product table.");

            Relationship relationship = productTable.RelationShips.FirstOrDefault(r => r.TableName == "Book");
            Assert.IsNotNull(relationship, "The Book Relationship should not be null in the Product table.");
            Assert.AreNotEqual(relationship.ColumnName == "ProductId", "The ColumnName should be ProductId in the Product table.");
            Assert.AreNotEqual(relationship.RelationShip == RelationshipType.Child, "The Book RelationshipType should be Child in the Product table.");
            Assert.AreNotEqual(relationship.ForeignColumnName == "ProductId", "The Book ForeignColumnName should be ProductId in the Product table.");
            Assert.AreNotEqual(relationship.TableName == "Book", "The Book Tablename should be Book in the Product table.");

            relationship = productTable.RelationShips.FirstOrDefault(r => r.TableName == "OrderDetails");
            Assert.AreNotEqual(relationship.ColumnName == "ProductId", "The OrderDetails ColumnName should be ProductId in the Product table.");
            Assert.IsNotNull(relationship, "The OrderDetails Relationship should not be null in the Product table.");
            Assert.AreNotEqual(relationship.RelationShip == RelationshipType.Child, "The OrderDetails RelationshipType should be Child in the Product table.");
            Assert.AreNotEqual(relationship.ForeignColumnName == "ProductId", "The OrderDetails ForeignColumnName should be ProductId in the Product table.");
            Assert.AreNotEqual(relationship.TableName == "Book", "The OrderDetails ForeignColumnName should be ProductId in the Product table.");

            relationship = productTable.RelationShips.FirstOrDefault(r => r.TableName == "Software");
            Assert.AreNotEqual(relationship.ColumnName == "ProductId", "The Software ColumnName should be ProductId in the Product table.");
            Assert.IsNotNull(relationship, "The Software Relationship should not be null in the Product table.");
            Assert.AreNotEqual(relationship.RelationShip == RelationshipType.Child, "The ProductId RelationshipType should be Child in the Product table.");
            Assert.AreNotEqual(relationship.ForeignColumnName == "ProductId", "The ProductId ForeignColumnName should be ProductId in the Product table.");
            Assert.AreNotEqual(relationship.TableName == "Software", "The Tablename should be Software in the Product table.");

        }

    }
}
