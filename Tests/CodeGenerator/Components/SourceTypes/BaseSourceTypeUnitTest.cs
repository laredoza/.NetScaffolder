﻿using System;
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
            Assert.AreEqual(9, databaseModel.Tables.Count, "There should be 9 Tables.");
            this.BaseSourceTypeUnitTest_TestProductTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName == "Product"));
            this.BaseSourceTypeUnitTest_TestProductRelationships(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Product"));
            this.BaseSourceTypeUnitTest_TestBook(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Book"));
            this.BaseSourceTypeUnitTest_TestBookRelationships(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Book"));

            this.BaseSourceTypeUnitTest_TestOrderDetailsTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "OrderDetails"));
            this.BaseSourceTypeUnitTest_OrderDetailsBook(databaseModel.Tables.FirstOrDefault(t => t.TableName == "OrderDetails"));

            this.BaseSourceTypeUnitTest_SoftwareTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Software"));
            this.BaseSourceTypeUnitTest_Software(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Software"));
        }


        [TestMethod]
        public void BaseSourceTypeUnitTest_TestProductTable(Table productTable)
        {
            Assert.IsNotNull(productTable, "The table should not be null");
            Assert.AreEqual(6, productTable.Columns.Count, "There should be 6 Columns in the Product table.");

            Column column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            Assert.IsTrue(column.IsPrimaryKey, "The ProductId should be a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType,"The ProductId should be a int32 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductDescription");
            Assert.IsFalse(column.IsPrimaryKey, "The ProductDescription is not a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ProductDescription should be a string in the Product table.");
            Assert.AreEqual(100, column.Length,"The ProductDescription should have a length of 100 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "UnitPrice");
            Assert.IsFalse(column.IsPrimaryKey, "The UnitPrice is not a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.Decimal, column.CSharpDataType, "The ProductId should be a decimal in the Product table.");
            Assert.AreEqual(19, column.Precision,"The UnitPrecision should have a precision of 19 in the Product table.");
            Assert.AreEqual(4, column.Scale, "The UnitPrecision should have a scale of 4 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "Publisher");
            Assert.IsFalse(column.IsPrimaryKey, "The Publisher is not a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType,"The Publisher should be a string in the Product table.");
            Assert.AreEqual(200, column.Length, "The Publisher should have a length of 200 in the Product table.");

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "AmountInStock");
            Assert.IsFalse(column.IsPrimaryKey, "The AmountInStock is not a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.Int16, column.CSharpDataType,"The AmountInStock should be a integer in the Product table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_TestProductRelationships(Table productTable)
        {
            Assert.IsNotNull(productTable.RelationShips, "The Relationships should not be null in the Product table.");
            Assert.AreEqual(3, productTable.RelationShips.Count, "There should be 3 relationships in the Product table.");

            Relationship relationship = productTable.RelationShips.FirstOrDefault(r => r.TableName == "Book");
            Assert.IsNotNull(relationship, "The Book Relationship should not be null in the Product table.");
            Assert.AreEqual("ProductId", relationship.ColumnName,"The ColumnName should be ProductId in the Product table.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip,"The Book DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual("ProductId", relationship.ForeignColumnName, "The Book ForeignColumnName should be ProductId in the Product table.");
            Assert.AreEqual("Book", relationship.TableName, "The relationship table name should be Book.");

            relationship = productTable.RelationShips.FirstOrDefault(r => r.TableName == "OrderDetails");
            Assert.AreEqual("ProductId", relationship.ColumnName, "The OrderDetails ColumnName should be ProductId in the Product table.");
            Assert.IsNotNull(relationship, "The OrderDetails Relationship should not be null in the Product table.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The OrderDetails DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual("ProductId", relationship.ForeignColumnName, "The OrderDetails ForeignColumnName should be ProductId in the Product table.");
            Assert.AreEqual("OrderDetails", relationship.TableName, "The relationship table name should be OrderDetails.");

            relationship = productTable.RelationShips.FirstOrDefault(r => r.TableName == "Software");
            Assert.AreEqual("ProductId", relationship.ColumnName, "The Software ColumnName should be ProductId in the Product table.");
            Assert.IsNotNull(relationship, "The Software Relationship should not be null in the Product table.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The ProductId DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual("ProductId", relationship.ForeignColumnName, "The ProductId ForeignColumnName should be ProductId in the Product table.");
            Assert.AreEqual("Software", relationship.TableName, "The relationship table name should be Software.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_TestBook(Table bookTable)
        {
            Assert.IsNotNull(bookTable, "The table should not be null");
            Assert.AreEqual(2, bookTable.Columns.Count, "There should be 2 Columns in the Product table.");

            Column column = bookTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            Assert.IsTrue(column.IsPrimaryKey, "The ProductId should be a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType,"The ProductId should be a int32 in the Product table.");

            column = bookTable.Columns.FirstOrDefault(c => c.ColumnName == "Publisher");
            Assert.IsFalse(column.IsPrimaryKey, "The Publisher is not a primary key in the Product table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType,"The Publisher should be a string in the Product table.");
            Assert.AreEqual(200, column.Length, "The Publisher should have a length of 100 in the Product table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_TestBookRelationships(Table orderDetailsTable)
        {
            Assert.IsNotNull(orderDetailsTable.RelationShips, "The Relationships should not be null in the    Book table.");
            Assert.AreEqual(1, orderDetailsTable.RelationShips.Count, "There should be 1 relationships in the Book table.");

            Relationship relationship = orderDetailsTable.RelationShips.FirstOrDefault(r => r.TableName == "Product");
            Assert.IsNotNull(relationship, "The Product Relationship should not be null in the Product table.");
            Assert.AreEqual("ProductId", relationship.ColumnName, "The ColumnName should be ProductId in the Book table.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The Book DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual("ProductId", relationship.ForeignColumnName, "The Book ForeignColumnName should be ProductId in the Product table.");
            Assert.AreEqual("Product", relationship.TableName, "The relationship table name should be Product");
        }


        [TestMethod]
        public void BaseSourceTypeUnitTest_TestOrderDetailsTable(Table orderDetailsTable)
        {
            Assert.IsNotNull(orderDetailsTable, "The table should not be null");
            Assert.AreEqual(6, orderDetailsTable.Columns.Count, "There should be 6 Columns in the Product table.");

            Column column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "OrderDetailsId");
            Assert.IsTrue(column.IsPrimaryKey, "The OrderDetailsId should be a primary key in the OrderDetails table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The OrderDetailsId should be a int32 in the Product table.");

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            Assert.IsFalse(column.IsPrimaryKey, "The ProductId is not a primary key in the OrderDetails table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The ProductId should be a string in the OrderDetails table.");

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "UnitPrice");
            Assert.IsFalse(column.IsPrimaryKey, "The UnitPrice is not a primary key in the OrderDetails table.");
            Assert.AreEqual(DomainDataType.Decimal, column.CSharpDataType, "The ProductId should be a decimal in the OrderDetails table.");
            Assert.AreEqual(19, column.Precision, "The UnitPrice should have a precision of 19 in the OrderDetails table.");
            Assert.AreEqual(4, column.Scale, "The UnitPrice should have a scale of 4 in the OrderDetails table.");

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "Amount");
            Assert.IsFalse(column.IsPrimaryKey, "The Amount is not a primary key in the OrderDetails table.");
            Assert.AreEqual(DomainDataType.Int16, column.CSharpDataType, "The Amount should be a int16 in the OrderDetails table.");

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "Discount");
            Assert.IsFalse(column.IsPrimaryKey, "The Discount is not a primary key in the OrderDetails table.");
            Assert.AreEqual(DomainDataType.Single, column.CSharpDataType, "The Discount should be a single in the OrderDetails table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_OrderDetailsBook(Table orderDetailsTable)
        {
            Assert.IsNotNull(orderDetailsTable.RelationShips, "The Relationships should not be null in the OrderDetails table.");
            Assert.AreEqual(2, orderDetailsTable.RelationShips.Count, "There should be 2 relationships in the OrderDetails table.");

            Relationship relationship = orderDetailsTable.RelationShips.FirstOrDefault(r => r.TableName == "Product");
            Assert.IsNotNull(relationship, "The Product Relationship should not be null in the Product table.");
            Assert.AreEqual("ProductId", relationship.ColumnName, "The ColumnName should be ProductId in the OrderDetails table.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The OrderDetails DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual("ProductId", relationship.ForeignColumnName, "The OrderDetails ForeignColumnName should be ProductId in the Product table.");
            Assert.AreEqual("Product", relationship.TableName, "The relationship table name should be Product");

            relationship = orderDetailsTable.RelationShips.FirstOrDefault(r => r.TableName == "Order");
            Assert.IsNotNull(relationship, "The Order Relationship should not be null in the OrderDetails table.");
            Assert.AreEqual("OrderId", relationship.ColumnName, "The ColumnName should be OrderId in the OrderDetails table.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The OrderDetails DependencyRelationShip should be Child in the Order table.");
            Assert.AreEqual("OrderId", relationship.ForeignColumnName, "The Order ForeignColumnName should be OrderId in the Order table.");
            Assert.AreEqual("Order", relationship.TableName, "The relationship table name should be Order");
        }


        [TestMethod]
        public void BaseSourceTypeUnitTest_SoftwareTable(Table softwareTable)
        {
            Assert.IsNotNull(softwareTable, "The table should not be null");
            Assert.AreEqual(2, softwareTable.Columns.Count, "There should be 2 Columns in the Software table.");

            Column column = softwareTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            Assert.IsTrue(column.IsPrimaryKey, "The ProductId should be a primary key in the Software table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The ProductId should be a int32 in the Software table.");

            column = softwareTable.Columns.FirstOrDefault(c => c.ColumnName == "LicenseCode");
            Assert.IsFalse(column.IsPrimaryKey, "The LicenseCode is not a primary key in the Software table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The LicenseCode should be a string in the Software table.");
            Assert.AreEqual(200, column.Length, "The LicenseCode should be a string in the Software table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_Software(Table softwareTable)
        {
            Assert.IsNotNull(softwareTable.RelationShips, "The Relationships should not be null in the Software table.");
            Assert.AreEqual(1, softwareTable.RelationShips.Count, "There should be 1 relationships in the Software table.");

            Relationship relationship = softwareTable.RelationShips.FirstOrDefault(r => r.TableName == "Product");
            Assert.IsNotNull(relationship, "The Product Relationship should not be null in the Product table.");
            Assert.AreEqual("ProductId", relationship.ColumnName, "The ColumnName should be ProductId in the OrderDetails table.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The OrderDetails DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual("ProductId", relationship.ForeignColumnName, "The OrderDetails ForeignColumnName should be ProductId in the Product table.");
            Assert.AreEqual("Product", relationship.TableName, "The relationship table name should be Product");
        }

    }
}
