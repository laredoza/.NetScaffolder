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

            this.BaseSourceTypeUnitTest_CustomerTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Customer"));
            this.BaseSourceTypeUnitTest_CustomerRelationship(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Customer"));

            this.BaseSourceTypeUnitTest_OrderTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Order"));
            this.BaseSourceTypeUnitTest_OrderRelationship(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Order"));

            this.BaseSourceTypeUnitTest_CountryTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Country"));
            this.BaseSourceTypeUnitTest_CountryRelationship(databaseModel.Tables.FirstOrDefault(t => t.TableName == "Country"));

            this.BaseSourceTypeUnitTest_BankAccountTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "BankAccount"));
            this.BaseSourceTypeUnitTest_BankAccountRelationship(databaseModel.Tables.FirstOrDefault(t => t.TableName == "BankAccount"));

            this.BaseSourceTypeUnitTest_BankTransfersTable(databaseModel.Tables.FirstOrDefault(t => t.TableName == "BankTransfers"));
            this.BaseSourceTypeUnitTest_BankTransfersRelationship(databaseModel.Tables.FirstOrDefault(t => t.TableName == "BankTransfers"));
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

        [TestMethod]
        public void BaseSourceTypeUnitTest_CustomerTable(Table customerTable)
        {
            Assert.IsNotNull(customerTable, "The table should not be null");
            Assert.AreEqual(13, customerTable.Columns.Count, "There should be 13 Columns in the Software table.");

            Column column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerId");
            Assert.IsTrue(column.IsPrimaryKey, "The CustomerId should be a primary key in the CustomerTable table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The CustomerId should be a int32 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerCode");
            Assert.IsFalse(column.IsPrimaryKey, "The CustomerCode is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The LicenseCode should be a string in the Customer table.");
            Assert.AreEqual(5, column.Length, "The CustomerCode should have a length of 5 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CompanyName");
            Assert.IsFalse(column.IsPrimaryKey, "The CompanyName is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The CompanyName should be a string in the Customer table.");
            Assert.AreEqual(50, column.Length, "The CompanyName should have a length of 50 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "ContactName");
            Assert.IsFalse(column.IsPrimaryKey, "The ContactName is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ContactName should be a string in the Customer table.");
            Assert.AreEqual(50, column.Length, "The ContactName should have a length of 50 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "ContactTitle");
            Assert.IsFalse(column.IsPrimaryKey, "The ContactTitle is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ContactTitle should be a string in the Customer table.");
            Assert.AreEqual(50, column.Length, "The ContactTitle should have a length of 50 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Address");
            Assert.IsFalse(column.IsPrimaryKey, "The Address is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The Address should be a string in the Customer table.");
            Assert.AreEqual(50, column.Length, "The Address should have a length of 50 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "City");
            Assert.IsFalse(column.IsPrimaryKey, "The City is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The City should be a string in the Customer table.");
            Assert.AreEqual(20, column.Length, "The City should have a length of 20 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "PostalCode");
            Assert.IsFalse(column.IsPrimaryKey, "The PostalCode is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The PostalCode should be a string in the Customer table.");
            Assert.AreEqual(10, column.Length, "The PostalCode should have a length of 10 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Telephone");
            Assert.IsFalse(column.IsPrimaryKey, "The Telephone is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The Telephone should be a string in the Customer table.");
            Assert.AreEqual(50, column.Length, "The Telephone should have a length of 50 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Fax");
            Assert.IsFalse(column.IsPrimaryKey, "The Fax is not a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The Fax should be a string in the Customer table.");
            Assert.AreEqual(50, column.Length, "The Fax should have a length of 50 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CountryId");
            Assert.IsFalse(column.IsPrimaryKey, "The CountryId should be a primary key in the CustomerTable table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The CountryId should be a int32 in the Customer table.");

            // Todo: Change to correct type
            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Photo");
            Assert.IsFalse(column.IsPrimaryKey, "The Photo should be a primary key in the Customer table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The Photo should be a int32 in the Customer table.");

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "IsEnabled");
            Assert.IsFalse(column.IsPrimaryKey, "The IsEnabled should be a primary key in the CustomerTable table.");
            Assert.AreEqual(DomainDataType.Boolean, column.CSharpDataType, "The IsEnabled should be a boolean in the Customer table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_CustomerRelationship(Table softwareTable)
        {
            Assert.IsNotNull(softwareTable.RelationShips, "The Relationships should not be null in the Customer table.");
            Assert.AreEqual(3, softwareTable.RelationShips.Count, "There should be 3 relationships in the Customer table.");

            Relationship relationship = softwareTable.RelationShips.FirstOrDefault(r => r.TableName == "BankAccount");
            Assert.IsNotNull(relationship, "The BankAccount Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The OrderDetails DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual("CustomerId", relationship.ForeignColumnName, "The ForeignColumnName should be CustomerId.");
            Assert.AreEqual("BankAccount", relationship.TableName, "The relationship table name should be BankAccount");

            relationship = softwareTable.RelationShips.FirstOrDefault(r => r.TableName == "Country");
            Assert.IsNotNull(relationship, "The Country Relationship should not be null.");
            Assert.AreEqual("CountryId", relationship.ColumnName, "The ColumnName should be CountryId.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual("CountryId", relationship.ForeignColumnName, "The ForeignColumnName should be CountryId.");
            Assert.AreEqual("Country", relationship.TableName, "The relationship table name should be Country.");

            relationship = softwareTable.RelationShips.FirstOrDefault(r => r.TableName == "Order");
            Assert.IsNotNull(relationship, "The Order Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The OrderDetails DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual("CustomerId", relationship.ForeignColumnName, "The ForeignColumnName should be CustomerId.");
            Assert.AreEqual("Order", relationship.TableName, "The relationship table name should be Order");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_OrderTable(Table orderTable)
        {
            Assert.IsNotNull(orderTable, "The table should not be null");
            Assert.AreEqual(8, orderTable.Columns.Count, "There should be 8 Columns in the Order table.");

            Column column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "OrderId");
            Assert.IsTrue(column.IsPrimaryKey, "The OrderId should be a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The OrderId should be a int32 in the Order table.");

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerId");
            Assert.IsFalse(column.IsPrimaryKey, "The CustomerId is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The CustomerId should be a int32 in the Order table.");
            
            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "OrderDate");
            Assert.IsFalse(column.IsPrimaryKey, "The OrderDate is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.DateTime, column.CSharpDataType, "The OrderDate should be a Date in the Order table.");

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "DeliveryDate");
            Assert.IsFalse(column.IsPrimaryKey, "The DeliveryDate is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.DateTime, column.CSharpDataType, "The DeliveryDate should be a Date in the Order table.");

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingName");
            Assert.IsFalse(column.IsPrimaryKey, "The ShippingName is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ShippingName should be a string in the Order table.");
            Assert.AreEqual(50, column.Length, "The ShippingName should have a length of 50 in the Order table.");

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingAddress");
            Assert.IsFalse(column.IsPrimaryKey, "The ShippingAddress is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ShippingAddress should be a string in the Order table.");
            Assert.AreEqual(50, column.Length, "The ShippingAddress should have a length of 50 in the Order table.");

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingCity");
            Assert.IsFalse(column.IsPrimaryKey, "The ShippingCity is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ShippingCity should be a string in the Order table.");
            Assert.AreEqual(50, column.Length, "The ShippingCity should have a length of 50 in the Order table.");

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingZip");
            Assert.IsFalse(column.IsPrimaryKey, "The ShippingZip is not a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The ShippingZip should be a string in the Order table.");
            Assert.AreEqual(50, column.Length, "The ShippingZip should have a length of 50 in the Order table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_OrderRelationship(Table ordersTable)
        {
            Assert.IsNotNull(ordersTable.RelationShips, "The Relationships should not be null in the Orders table.");
            Assert.AreEqual(2, ordersTable.RelationShips.Count, "There should be 2 relationships in the Orders table.");

            Relationship relationship = ordersTable.RelationShips.FirstOrDefault(r => r.TableName == "Customer");
            Assert.IsNotNull(relationship, "The Customer Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The Customer DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual("CustomerId", relationship.ForeignColumnName, "The ForeignColumnName should be CustomerId.");
            Assert.AreEqual("Customer", relationship.TableName, "The relationship table name should be Customer");

            relationship = ordersTable.RelationShips.FirstOrDefault(r => r.TableName == "OrderDetails");
            Assert.IsNotNull(relationship, "The OrderDetails Relationship should not be null.");
            Assert.AreEqual("OrderId", relationship.ColumnName, "The ColumnName should be OrderId.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual("OrderId", relationship.ForeignColumnName, "The ForeignColumnName should be OrderId.");
            Assert.AreEqual("OrderDetails", relationship.TableName, "The relationship table name should be OrderDetails.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_CountryTable(Table countryTable)
        {
            Assert.IsNotNull(countryTable, "The table should not be null");
            Assert.AreEqual(2, countryTable.Columns.Count, "There should be 2 Columns in the Country table.");

            Column column = countryTable.Columns.FirstOrDefault(c => c.ColumnName == "CountryId");
            Assert.IsTrue(column.IsPrimaryKey, "The CountryId should be a primary key in the Country table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The CountryId should be a int32 in the Country table.");
            
            column = countryTable.Columns.FirstOrDefault(c => c.ColumnName == "CountryName");
            Assert.IsFalse(column.IsPrimaryKey, "The CountryName is not a primary key in the Country table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The CountryName should be a string in the Country table.");
            Assert.AreEqual(100, column.Length, "The CountryName should have a length of 100 in the Country table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_CountryRelationship(Table customerTable)
        {
            Assert.IsNotNull(customerTable.RelationShips, "The Relationships should not be null in the Customer table.");
            Assert.AreEqual(1, customerTable.RelationShips.Count, "There should be 1 relationships in the Customer table.");

            Relationship relationship = customerTable.RelationShips.FirstOrDefault(r => r.TableName == "Customer");
            Assert.IsNotNull(relationship, "The Country Relationship should not be null.");
            Assert.AreEqual("CountryId", relationship.ColumnName, "The ColumnName should be CountryId.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The Country DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual("CountryId", relationship.ForeignColumnName, "The ForeignColumnName should be CountryId.");
            Assert.AreEqual("Customer", relationship.TableName, "The relationship table name should be Customer");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_BankAccountTable(Table bankAccountTable)
        {
            Assert.IsNotNull(bankAccountTable, "The table should not be null");
            Assert.AreEqual(5, bankAccountTable.Columns.Count, "There should be 5 Columns in the Order table.");

            Column column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "BankAccountId");
            Assert.IsTrue(column.IsPrimaryKey, "The BankAccountId should be a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The BankAccountId should be a int32 in the BankAccount table.");

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "BankAccountNumber");
            Assert.IsFalse(column.IsPrimaryKey, "The BankAccountNumber is not a primary key in the BankAccount table.");
            Assert.AreEqual(DomainDataType.String, column.CSharpDataType, "The BankAccountNumber should be a string in the BankAccount table.");
            Assert.AreEqual(10, column.Length, "The ShippingName should have a length of 10 in the BankAccount table.");

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "Balance");
            Assert.IsFalse(column.IsPrimaryKey, "The Balance is not a primary key in the BankAccount table.");
            Assert.AreEqual(DomainDataType.Decimal, column.CSharpDataType, "The Balance should be a decimal in the BankAccount table.");
            Assert.AreEqual(19, column.Precision, "The Balance should have a precision of 19 in the BankAccount table.");
            Assert.AreEqual(4, column.Scale, "The Balance should have a scale of 4 in the BankAccount table.");

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerId");
            Assert.IsFalse(column.IsPrimaryKey, "The CustomerId should be a primary key in the Order table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The CustomerId should be a int32 in the BankAccount table.");

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "Locked");
            Assert.IsFalse(column.IsPrimaryKey, "The Locked is not a primary key in the BankAccount table.");
            Assert.AreEqual(DomainDataType.Boolean, column.CSharpDataType, "The Locked field should be a boolean in the BankAccount table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_BankAccountRelationship(Table bankAccountTable)
        {
            Assert.IsNotNull(bankAccountTable.RelationShips, "The Relationships should not be null in the BankAccounts table.");
            Assert.AreEqual(3, bankAccountTable.RelationShips.Count, "There should be 3 relationships in the BankAccounts table.");

            Relationship relationship = bankAccountTable.RelationShips.FirstOrDefault(r => r.TableName == "Customer");
            Assert.IsNotNull(relationship, "The Customer Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The Customer DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual("CustomerId", relationship.ForeignColumnName, "The ForeignColumnName should be CustomerId.");
            Assert.AreEqual("Customer", relationship.TableName, "The relationship table name should be Customer");

            relationship = bankAccountTable.RelationShips.FirstOrDefault(r => r.TableName == "BankTransfers" && r.ForeignColumnName == "ToBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers1 Relationship should not be null.");
            Assert.AreEqual("BankAccountId", relationship.ColumnName, "The ColumnName should be ToBankAccountId.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual("ToBankAccountId", relationship.ForeignColumnName, "The ForeignColumnName should be ToBankAccountId.");
            Assert.AreEqual("BankTransfers", relationship.TableName, "The relationship table name should be BankTransfers.");

            relationship = bankAccountTable.RelationShips.FirstOrDefault(r => r.TableName == "BankTransfers" && r.ForeignColumnName == "FromBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers Relationship should not be null.");
            Assert.AreEqual("BankAccountId", relationship.ColumnName, "The ColumnName should be FromBankAccountId.");
            Assert.AreEqual(RelationshipType.ForeignKeyChild, relationship.DependencyRelationShip, "The DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual("FromBankAccountId", relationship.ForeignColumnName, "The ForeignColumnName should be FromBankAccountId.");
            Assert.AreEqual("BankTransfers", relationship.TableName, "The relationship table name should be BankTransfers.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_BankTransfersTable(Table bankTransfersTable)
        {
            Assert.IsNotNull(bankTransfersTable, "The table should not be null");
            Assert.AreEqual(5, bankTransfersTable.Columns.Count, "There should be 5 Columns in the BankTransfers table.");

            Column column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "BankTransferId");
            Assert.IsTrue(column.IsPrimaryKey, "The BankTransferId should be a primary key in the BankTransfers table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The BankTransferId should be a int32 in the BankTransfers table.");

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "FromBankAccountId");
            Assert.IsFalse(column.IsPrimaryKey, "The FromBankAccountId should not be a primary key in the BankTransfers table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The FromBankAccountId should be a int32 in the BankTransfers table.");

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "ToBankAccountId");
            Assert.IsFalse(column.IsPrimaryKey, "The ToBankAccountId should not be a primary key in the BankTransfers table.");
            Assert.AreEqual(DomainDataType.Int32, column.CSharpDataType, "The ToBankAccountId should be a int32 in the BankTransfers table.");
            
            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "Amount");
            Assert.IsFalse(column.IsPrimaryKey, "The Amount is not a primary key in the BankTransfers table.");
            Assert.AreEqual(DomainDataType.Decimal, column.CSharpDataType, "The Amount should be a decimal in the BankTransfers table.");
            Assert.AreEqual(18, column.Precision, "The Balance should have a precision of 18 in the BankAccount table.");
            Assert.AreEqual(2, column.Scale, "The Balance should have a scale of 2 in the BankAccount table.");

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "TransferDate");
            Assert.IsFalse(column.IsPrimaryKey, "The TransferDate is not a primary key in the BankTransfers table.");
            Assert.AreEqual(DomainDataType.DateTime, column.CSharpDataType, "The Locked field should be a DateTime in the BankTransfers table.");
        }

        [TestMethod]
        public void BaseSourceTypeUnitTest_BankTransfersRelationship(Table bankTransfersTable)
        {
            Assert.IsNotNull(bankTransfersTable.RelationShips, "The Relationships should not be null in the bankTransfersTable table.");
            Assert.AreEqual(2, bankTransfersTable.RelationShips.Count, "There should be 2 relationships in the bankTransfersTable table.");

            Relationship relationship = bankTransfersTable.RelationShips.FirstOrDefault(r => r.TableName == "BankAccount" && r.ColumnName == "ToBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers1 Relationship should not be null.");
            Assert.AreEqual("ToBankAccountId", relationship.ColumnName, "The ColumnName should be ToBankAccountId.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual("BankAccountId", relationship.ForeignColumnName, "The ForeignColumnName should be BankAccountId.");
            Assert.AreEqual("BankAccount", relationship.TableName, "The relationship table name should be BankTransfers.");

            relationship = bankTransfersTable.RelationShips.FirstOrDefault(r => r.TableName == "BankAccount" && r.ColumnName == "FromBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers Relationship should not be null.");
            Assert.AreEqual("FromBankAccountId", relationship.ColumnName, "The ColumnName should be FromBankAccountId.");
            Assert.AreEqual(RelationshipType.ForeignKey, relationship.DependencyRelationShip, "The DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual("BankAccountId", relationship.ForeignColumnName, "The ForeignColumnName should be BankAccountId.");
            Assert.AreEqual("BankAccount", relationship.TableName, "The relationship table name should be BankTransfers.");
        }
    }
}
