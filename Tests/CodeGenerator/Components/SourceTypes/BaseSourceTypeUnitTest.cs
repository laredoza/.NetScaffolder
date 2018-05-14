// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseSourceTypeUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test.Components.SourceTypes
{
    #region Usings

    using System.Linq;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.MySql;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The base source type unit test.
    /// </summary>
    [TestClass]
    public class BaseSourceTypeUnitTest
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The base source type unit test_ bank account relationship.
        /// </summary>
        /// <param name="bankAccountTable">
        /// The bank account table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_BankAccountRelationship(Table bankAccountTable)
        {
            Assert.IsNotNull(
                bankAccountTable.Relationships,
                "The Relationships should not be null in the BankAccounts table.");
            Assert.AreEqual(
                3,
                bankAccountTable.Relationships.Count,
                "There should be 3 Relationships in the BankAccounts table.");

            Relationship relationship =
                bankAccountTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "Customer");
            Assert.IsNotNull(relationship, "The Customer Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The Customer DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual(
                "CustomerId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be CustomerId.");
            Assert.AreEqual(
                "Customer",
                relationship.ReferencedTableName,
                "The relationship table name should be Customer");

            // Assert.AreEqual("FK_BankAccount_Customer", relationship.RelationshipName, "The relationship table name should be FK_BankAccount_Customer.");
            relationship = bankAccountTable.Relationships.FirstOrDefault(
                r => r.ReferencedTableName == "BankTransfers" && r.ReferencedColumnName == "ToBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers1 Relationship should not be null.");
            Assert.AreEqual("BankAccountId", relationship.ColumnName, "The ColumnName should be ToBankAccountId.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual(
                "ToBankAccountId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be ToBankAccountId.");
            Assert.AreEqual(
                "BankTransfers",
                relationship.ReferencedTableName,
                "The relationship table name should be BankTransfers.");

            // Assert.AreEqual("FK_BankTransfers_BankAccount1", relationship.RelationshipName, "The relationship table name should be FK_BankTransfers_BankAccount1.");
            relationship = bankAccountTable.Relationships.FirstOrDefault(
                r => r.ReferencedTableName == "BankTransfers" && r.ReferencedColumnName == "FromBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers Relationship should not be null.");
            Assert.AreEqual("BankAccountId", relationship.ColumnName, "The ColumnName should be FromBankAccountId.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual(
                "FromBankAccountId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be FromBankAccountId.");
            Assert.AreEqual(
                "BankTransfers",
                relationship.ReferencedTableName,
                "The relationship table name should be BankTransfers.");

            // Assert.AreEqual("FK_BankTransfers_BankAccount", relationship.RelationshipName, "The relationship table name should be FK_BankTransfers_BankAccount.");
        }

        /// <summary>
        /// The base source type unit test_ bank account table.
        /// </summary>
        /// <param name="bankAccountTable">
        /// The bank account table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_BankAccountTable(Table bankAccountTable)
        {
            Assert.IsNotNull(bankAccountTable, "The table should not be null");
            Assert.AreEqual(5, bankAccountTable.Columns.Count, "There should be 5 Columns in the Order table.");

            Column column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "BankAccountId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "BankAccountId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "BankAccountNumber");
            Assert.AreEqual(10, column.Length, "The ShippingName should have a length of 10 in the BankAccount table.");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "BankAccountNumber",
                        DomainDataType = DomainDataType.String,
                        IsRequired = true,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 10,
                        IsPrimaryKey = false
                    });

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "Balance");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Balance",
                        DomainDataType = DomainDataType.Decimal,
                        IsRequired = true,
                        ColumnOrder = 3,
                        Precision = 19,
                        Scale = 4,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CustomerId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = false,
                        ColumnOrder = 4,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = bankAccountTable.Columns.FirstOrDefault(c => c.ColumnName == "Locked");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Locked",
                        DomainDataType = DomainDataType.Boolean,
                        IsRequired = true,
                        ColumnOrder = 5,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ bank transfers relationship.
        /// </summary>
        /// <param name="bankTransfersTable">
        /// The bank transfers table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_BankTransfersRelationship(Table bankTransfersTable)
        {
            Assert.IsNotNull(
                bankTransfersTable.Relationships,
                "The Relationships should not be null in the bankTransfersTable table.");
            Assert.AreEqual(
                2,
                bankTransfersTable.Relationships.Count,
                "There should be 2 Relationships in the bankTransfersTable table.");

            Relationship relationship = bankTransfersTable.Relationships.FirstOrDefault(
                r => r.ReferencedTableName == "BankAccount" && r.ColumnName == "ToBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers1 Relationship should not be null.");
            Assert.AreEqual("ToBankAccountId", relationship.ColumnName, "The ColumnName should be ToBankAccountId.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual(
                "BankAccountId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be BankAccountId.");
            Assert.AreEqual(
                "BankAccount",
                relationship.ReferencedTableName,
                "The relationship table name should be BankTransfers.");

            // Assert.AreEqual("FK_BankTransfers_BankAccount1", relationship.RelationshipName, "The relationship table name should be FK_BankTransfers_BankAccount1.");
            relationship = bankTransfersTable.Relationships.FirstOrDefault(
                r => r.ReferencedTableName == "BankAccount" && r.ColumnName == "FromBankAccountId");
            Assert.IsNotNull(relationship, "The BankTransfers Relationship should not be null.");
            Assert.AreEqual(
                "FromBankAccountId",
                relationship.ColumnName,
                "The ColumnName should be FromBankAccountId.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual(
                "BankAccountId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be BankAccountId.");
            Assert.AreEqual(
                "BankAccount",
                relationship.ReferencedTableName,
                "The relationship table name should be BankTransfers.");
            Assert.AreEqual(
                "FK_BankTransfers_BankAccount",
                relationship.RelationshipName,
                "The relationship table name should be FK_BankTransfers_BankAccount.");
        }

        /// <summary>
        /// The base source type unit test_ bank transfers table.
        /// </summary>
        /// <param name="bankTransfersTable">
        /// The bank transfers table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_BankTransfersTable(Table bankTransfersTable)
        {
            Assert.IsNotNull(bankTransfersTable, "The table should not be null");
            Assert.AreEqual(
                5,
                bankTransfersTable.Columns.Count,
                "There should be 5 Columns in the BankTransfers table.");

            Column column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "BankTransferId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "BankTransferId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "FromBankAccountId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "FromBankAccountId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "ToBankAccountId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ToBankAccountId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 3,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "Amount");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Amount",
                        DomainDataType = DomainDataType.Decimal,
                        IsRequired = true,
                        ColumnOrder = 4,
                        Precision = 18,
                        Scale = 2,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = bankTransfersTable.Columns.FirstOrDefault(c => c.ColumnName == "TransferDate");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "TransferDate",
                        DomainDataType = DomainDataType.DateTime,
                        IsRequired = true,
                        ColumnOrder = 5,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ columns.
        /// </summary>
        /// <param name="column">
        /// The column.
        /// </param>
        /// <param name="expectedColumn">
        /// The expected column.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_Columns(Column column, Column expectedColumn)
        {
            Assert.AreEqual(expectedColumn.ColumnName, column.ColumnName, $"Invalid column name");
            Assert.AreEqual(expectedColumn.DomainDataType, column.DomainDataType, $"Invalid column DomainDataType");
            Assert.AreEqual(expectedColumn.IsRequired, column.IsRequired, $"Invalid column IsRequired Value");
            Assert.AreEqual(expectedColumn.ColumnOrder, column.ColumnOrder, $"Invalid column ColumnOrder");
            Assert.AreEqual(expectedColumn.Precision, column.Precision, $"Invalid column Precision");
            Assert.AreEqual(expectedColumn.Scale, column.Scale, $"Invalid column Scale");
            Assert.AreEqual(expectedColumn.Length, column.Length, $"Invalid column Length");
            Assert.AreEqual(expectedColumn.IsPrimaryKey, column.IsPrimaryKey, $"Invalid column IsPrimaryKey");
        }

        /// <summary>
        /// The base source type unit test_ country relationship.
        /// </summary>
        /// <param name="customerTable">
        /// The customer table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_CountryRelationship(Table customerTable)
        {
            Assert.IsNotNull(
                customerTable.Relationships,
                "The Relationships should not be null in the Customer table.");
            Assert.AreEqual(
                1,
                customerTable.Relationships.Count,
                "There should be 1 Relationships in the Customer table.");

            Relationship relationship =
                customerTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "Customer");
            Assert.IsNotNull(relationship, "The Country Relationship should not be null.");
            Assert.AreEqual("CountryId", relationship.ColumnName, "The ColumnName should be CountryId.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The Country DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual(
                "CountryId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be CountryId.");
            Assert.AreEqual(
                "Customer",
                relationship.ReferencedTableName,
                "The relationship table name should be Customer");

            // Assert.AreEqual("FK_Customer_Country", relationship.RelationshipName, "The relationship table name should be FK_Customer_Country.");
        }

        /// <summary>
        /// The base source type unit test_ country table.
        /// </summary>
        /// <param name="countryTable">
        /// The country table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_CountryTable(Table countryTable)
        {
            Assert.IsNotNull(countryTable, "The table should not be null");
            Assert.AreEqual(2, countryTable.Columns.Count, "There should be 2 Columns in the Country table.");

            Column column = countryTable.Columns.FirstOrDefault(c => c.ColumnName == "CountryId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CountryId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = countryTable.Columns.FirstOrDefault(c => c.ColumnName == "CountryName");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CountryName",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 100,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ customer relationship.
        /// </summary>
        /// <param name="softwareTable">
        /// The software table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_CustomerRelationship(Table softwareTable)
        {
            Assert.IsNotNull(
                softwareTable.Relationships,
                "The Relationships should not be null in the Customer table.");
            Assert.AreEqual(
                3,
                softwareTable.Relationships.Count,
                "There should be 3 Relationships in the Customer table.");

            Relationship relationship =
                softwareTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "BankAccount");
            Assert.IsNotNull(relationship, "The BankAccount Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The OrderDetails DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual(
                "CustomerId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be CustomerId.");
            Assert.AreEqual(
                "BankAccount",
                relationship.ReferencedTableName,
                "The relationship table name should be BankAccount");

            // Assert.AreEqual("FK_BankAccount_Customer", relationship.RelationshipName, "The relationship table name should be FK_BankAccount_Customer.");
            relationship = softwareTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "Country");
            Assert.IsNotNull(relationship, "The Country Relationship should not be null.");
            Assert.AreEqual("CountryId", relationship.ColumnName, "The ColumnName should be CountryId.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual(
                "CountryId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be CountryId.");
            Assert.AreEqual(
                "Country",
                relationship.ReferencedTableName,
                "The relationship table name should be Country.");

            // Assert.AreEqual("FK_Customer_Country", relationship.RelationshipName, "The relationship table name should be FK_Customer_Country.");
            relationship = softwareTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "Order");
            Assert.IsNotNull(relationship, "The Order Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The OrderDetails DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual(
                "CustomerId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be CustomerId.");
            Assert.AreEqual("Order", relationship.ReferencedTableName, "The relationship table name should be Order");

            // Assert.AreEqual("FK_Order_Customer", relationship.RelationshipName, "The relationship table name should be FK_Order_Customer.");
        }

        /// <summary>
        /// The base source type unit test_ customer table.
        /// </summary>
        /// <param name="customerTable">
        /// The customer table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_CustomerTable(Table customerTable)
        {
            Assert.IsNotNull(customerTable, "The table should not be null");
            Assert.AreEqual(13, customerTable.Columns.Count, "There should be 13 Columns in the Software table.");

            Column column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CustomerId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerCode");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CustomerCode",
                        DomainDataType = DomainDataType.String,
                        IsRequired = true,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 5,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CompanyName");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CompanyName",
                        DomainDataType = DomainDataType.String,
                        IsRequired = true,
                        ColumnOrder = 3,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "ContactName");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ContactName",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 4,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "ContactTitle");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ContactTitle",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 5,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Address");

            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Address",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 6,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "City");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "City",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 7,
                        Precision = 0,
                        Scale = 0,
                        Length = 20,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "PostalCode");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "PostalCode",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 8,
                        Precision = 0,
                        Scale = 0,
                        Length = 10,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Telephone");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Telephone",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 9,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Fax");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Fax",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 10,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "CountryId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CountryId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = false,
                        ColumnOrder = 11,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            // Todo: Change to correct type
            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "Photo");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Photo",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 12,
                        Precision = 0,
                        Scale = 0,
                        Length = 2147483647,
                        IsPrimaryKey = false
                    });

            column = customerTable.Columns.FirstOrDefault(c => c.ColumnName == "IsEnabled");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "IsEnabled",
                        DomainDataType = DomainDataType.Boolean,
                        IsRequired = true,
                        ColumnOrder = 13,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ order details book.
        /// </summary>
        /// <param name="orderDetailsTable">
        /// The order details table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_OrderDetailsBook(Table orderDetailsTable)
        {
            Assert.IsNotNull(
                orderDetailsTable.Relationships,
                "The Relationships should not be null in the OrderDetails table.");
            Assert.AreEqual(
                2,
                orderDetailsTable.Relationships.Count,
                "There should be 2 Relationships in the OrderDetails table.");

            Relationship relationship =
                orderDetailsTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "product");
            Assert.IsNotNull(relationship, "The Product Relationship should not be null in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ColumnName,
                "The ColumnName should be ProductId in the OrderDetails table.");

            // Assert.AreEqual("FK_OrderDetails_Product", relationship.RelationshipName, "The relationship table name should be FK_OrderDetails_Product.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The OrderDetails DependencyRelationShip should be Child in the Product table.");

            Assert.AreEqual(
                "ProductId",
                relationship.ReferencedColumnName,
                "The OrderDetails ReferencedColumnName should be ProductId in the Product table.");
            Assert.AreEqual(
                "product",
                relationship.ReferencedTableName.ToLower(),
                "The relationship table name should be Product");

            relationship = orderDetailsTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "order");
            Assert.IsNotNull(relationship, "The Order Relationship should not be null in the OrderDetails table.");
            Assert.AreEqual(
                "OrderId",
                relationship.ColumnName,
                "The ColumnName should be OrderId in the OrderDetails table.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The OrderDetails DependencyRelationShip should be Child in the Order table.");
            Assert.AreEqual(
                "OrderId",
                relationship.ReferencedColumnName,
                "The Order ReferencedColumnName should be OrderId in the Order table.");
            Assert.AreEqual("order", relationship.ReferencedTableName.ToLower(), "The relationship table name should be Order");

            // Assert.AreEqual("FK_OrdeDetails_Order", relationship.RelationshipName, "The relationship table name should be FK_OrdeDetails_Order.");
        }

        /// <summary>
        /// The base source type unit test_ order relationship.
        /// </summary>
        /// <param name="ordersTable">
        /// The orders table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_OrderRelationship(Table ordersTable)
        {
            Assert.IsNotNull(ordersTable.Relationships, "The Relationships should not be null in the Orders table.");
            Assert.AreEqual(2, ordersTable.Relationships.Count, "There should be 2 Relationships in the Orders table.");

            Relationship relationship =
                ordersTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "Customer");
            Assert.IsNotNull(relationship, "The Customer Relationship should not be null.");
            Assert.AreEqual("CustomerId", relationship.ColumnName, "The ColumnName should be CustomerId.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The Customer DependencyRelationShip should be ForeignKey.");
            Assert.AreEqual(
                "CustomerId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be CustomerId.");
            Assert.AreEqual(
                "Customer",
                relationship.ReferencedTableName,
                "The relationship table name should be Customer");

            // Assert.AreEqual("FK_Order_Customer", relationship.RelationshipName, "The relationship table name should be FK_Order_Customer.");
            relationship = ordersTable.Relationships.FirstOrDefault(r => r.ReferencedTableName == "OrderDetails");
            Assert.IsNotNull(relationship, "The OrderDetails Relationship should not be null.");
            Assert.AreEqual("OrderId", relationship.ColumnName, "The ColumnName should be OrderId.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The DependencyRelationShip should be ForeignKeyChild.");
            Assert.AreEqual(
                "OrderId",
                relationship.ReferencedColumnName,
                "The ReferencedColumnName should be OrderId.");
            Assert.AreEqual(
                "OrderDetails",
                relationship.ReferencedTableName,
                "The relationship table name should be OrderDetails.");

            // Assert.AreEqual("FK_OrdeDetails_Order", relationship.RelationshipName, "The relationship table name should be FK_OrdeDetails_Order.");
        }

        /// <summary>
        /// The base source type unit test_ order table.
        /// </summary>
        /// <param name="orderTable">
        /// The order table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_OrderTable(Table orderTable)
        {
            Assert.IsNotNull(orderTable, "The table should not be null");
            Assert.AreEqual(8, orderTable.Columns.Count, "There should be 8 Columns in the Order table.");

            Column column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "OrderId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "OrderId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "CustomerId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "CustomerId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = false,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "OrderDate");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "OrderDate",
                        DomainDataType = DomainDataType.DateTime,
                        IsRequired = false,
                        ColumnOrder = 3,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "DeliveryDate");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "DeliveryDate",
                        DomainDataType = DomainDataType.DateTime,
                        IsRequired = false,
                        ColumnOrder = 4,
                        Precision = 0,
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingName");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ShippingName",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 5,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingAddress");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ShippingAddress",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 6,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingCity");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ShippingCity",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 7,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });

            column = orderTable.Columns.FirstOrDefault(c => c.ColumnName == "ShippingZip");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ShippingZip",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 8,
                        Precision = 0,
                        Scale = 0,
                        Length = 50,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ software.
        /// </summary>
        /// <param name="softwareTable">
        /// The software table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_Software(Table softwareTable)
        {
            Assert.IsNotNull(
                softwareTable.Relationships,
                "The Relationships should not be null in the Software table.");
            Assert.AreEqual(
                1,
                softwareTable.Relationships.Count,
                "There should be 1 Relationships in the Software table.");

            Relationship relationship =
                softwareTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "product");
            Assert.IsNotNull(relationship, "The Product Relationship should not be null in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ColumnName,
                "The ColumnName should be ProductId in the OrderDetails table.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The OrderDetails DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ReferencedColumnName,
                "The OrderDetails ReferencedColumnName should be ProductId in the Product table.");
            Assert.AreEqual(
                "product",
                relationship.ReferencedTableName.ToLower(),
                "The relationship table name should be Product");

            // Assert.AreEqual("FK_Software_Product", relationship.RelationshipName, "The relationship table name should be FK_Software_Product.");
        }

        /// <summary>
        /// The base source type unit test_ software table.
        /// </summary>
        /// <param name="softwareTable">
        /// The software table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_SoftwareTable(Table softwareTable)
        {
            Assert.IsNotNull(softwareTable, "The table should not be null");
            Assert.AreEqual(2, softwareTable.Columns.Count, "There should be 2 Columns in the Software table.");

            Column column = softwareTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ProductId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = softwareTable.Columns.FirstOrDefault(c => c.ColumnName == "LicenseCode");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "LicenseCode",
                        DomainDataType = DomainDataType.String,
                        IsRequired = true,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 200,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ test book.
        /// </summary>
        /// <param name="bookTable">
        /// The book table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestBook(Table bookTable)
        {
            Assert.IsNotNull(bookTable, "The table should not be null");
            Assert.AreEqual(2, bookTable.Columns.Count, "There should be 2 Columns in the Product table.");

            Column column = bookTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ProductId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = bookTable.Columns.FirstOrDefault(c => c.ColumnName == "Publisher");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Publisher",
                        DomainDataType = DomainDataType.String,
                        IsRequired = true,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 200,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ test book Relationships.
        /// </summary>
        /// <param name="orderDetailsTable">
        /// The order details table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestBookRelationships(Table orderDetailsTable)
        {
            Assert.IsNotNull(
                orderDetailsTable.Relationships,
                "The Relationships should not be null in the    Book table.");
            Assert.AreEqual(
                1,
                orderDetailsTable.Relationships.Count,
                "There should be 1 Relationships in the Book table.");

            Relationship relationship =
                orderDetailsTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "product");
            Assert.IsNotNull(relationship, "The Product Relationship should not be null in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ColumnName,
                "The ColumnName should be ProductId in the Book table.");
            Assert.AreEqual(
                RelationshipType.ForeignKey,
                relationship.DependencyRelationShip,
                "The Book DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ReferencedColumnName,
                "The Book ReferencedColumnName should be ProductId in the Product table.");
            Assert.AreEqual(
                "product",
                relationship.ReferencedTableName.ToLower(),
                "The relationship table name should be Product");

            // Assert.AreEqual("FK_Book_Product", relationship.RelationshipName, "The relationship table name should be FK_Book_Product.");
        }

        /// <summary>
        /// The base source type unit test_ test order details table.
        /// </summary>
        /// <param name="orderDetailsTable">
        /// The order details table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestOrderDetailsTable(Table orderDetailsTable)
        {
            Assert.IsNotNull(orderDetailsTable, "The table should not be null");
            Assert.AreEqual(6, orderDetailsTable.Columns.Count, "There should be 6 Columns in the Product table.");

            Column column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "OrderDetailsId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "OrderDetailsId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ProductId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 3,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "UnitPrice");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "UnitPrice",
                        DomainDataType = DomainDataType.Decimal,
                        IsRequired = false,
                        ColumnOrder = 4,
                        Precision = 19,
                        Scale = 4,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "Amount");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Amount",
                        DomainDataType = DomainDataType.Int16,
                        IsRequired = false,
                        ColumnOrder = 5,
                        Precision = this.ReturnDefaultInt16Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = orderDetailsTable.Columns.FirstOrDefault(c => c.ColumnName == "Discount");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Discount",
                        DomainDataType = DomainDataType.Single,
                        IsRequired = false,
                        ColumnOrder = 6,
                        Precision = this.ReturnDefaultSinglePrecision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ test product Relationships.
        /// </summary>
        /// <param name="productTable">
        /// The product table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestProductRelationships(Table productTable)
        {
            Assert.IsNotNull(productTable.Relationships, "The Relationships should not be null in the Product table.");
            Assert.AreEqual(
                3,
                productTable.Relationships.Count,
                "There should be 3 Relationships in the Product table.");

            Relationship relationship = productTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "book");
            Assert.IsNotNull(relationship, "The Book Relationship should not be null in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ColumnName,
                "The ColumnName should be ProductId in the Product table.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The Book DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ReferencedColumnName,
                "The Book ReferencedColumnName should be ProductId in the Product table.");
            Assert.AreEqual("book", relationship.ReferencedTableName.ToLower(), "The relationship table name should be Book.");

            // Assert.AreEqual("FK_Book_Product", relationship.RelationshipName, "The relationship table name should be FK_Book_Product.");
            relationship = productTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "orderdetails");
            Assert.AreEqual(
                "ProductId",
                relationship.ColumnName,
                "The OrderDetails ColumnName should be ProductId in the Product table.");
            Assert.IsNotNull(relationship, "The OrderDetails Relationship should not be null in the Product table.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The OrderDetails DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ReferencedColumnName,
                "The OrderDetails ReferencedColumnName should be ProductId in the Product table.");
            Assert.AreEqual(
                "orderdetails",
                relationship.ReferencedTableName.ToLower(),
                "The relationship table name should be OrderDetails.");

            // Assert.AreEqual("FK_OrderDetails_Product", relationship.RelationshipName, "The relationship table name should be FK_OrderDetails_Product.");
            relationship = productTable.Relationships.FirstOrDefault(r => r.ReferencedTableName.ToLower() == "software");
            Assert.AreEqual(
                "ProductId",
                relationship.ColumnName,
                "The Software ColumnName should be ProductId in the Product table.");
            Assert.IsNotNull(relationship, "The Software Relationship should not be null in the Product table.");
            Assert.AreEqual(
                RelationshipType.ForeignKeyChild,
                relationship.DependencyRelationShip,
                "The ProductId DependencyRelationShip should be Child in the Product table.");
            Assert.AreEqual(
                "ProductId",
                relationship.ReferencedColumnName,
                "The ProductId ReferencedColumnName should be ProductId in the Product table.");
            Assert.AreEqual(
                "software",
                relationship.ReferencedTableName.ToLower(),
                "The relationship table name should be Software.");

            // Assert.AreEqual("FK_Software_Product", relationship.RelationshipName, "The relationship table name should be FK_Software_Product.");
        }

        public int ReturnDefaultInt32Precision()
        {
            int precision = 0;

            if (this.SourceType is EdmxImporter)
            {
                precision = 0;
            }
            else if (this.SourceType is AdoSource)
            {
                precision = 10;
            }

            return precision;
        }

        public int ReturnDefaultInt16Precision()
        {
            int precision = 0;

            if (this.SourceType is EdmxImporter)
            {
                precision = 0;
            }
            else if (this.SourceType is AdoSource)
            {
                precision = 5;
            }

            return precision;
        }

        public int ReturnDefaultSinglePrecision()
        {
            int precision = 0;

            if (this.SourceType is EdmxImporter)
            {
                precision = 0;
            }
            else if (this.SourceType is AdoSource)
            {
                precision = 12;
            }

            return precision;
        }

        /// <summary>
        /// The base source type unit test_ test product table.
        /// </summary>
        /// <param name="productTable">
        /// The product table.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestProductTable(Table productTable)
        {
            Assert.IsNotNull(productTable, "The table should not be null");
            Assert.AreEqual(6, productTable.Columns.Count, "There should be 6 Columns in the Product table.");

            Column column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductId");

            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ProductId",
                        DomainDataType = DomainDataType.Int32,
                        IsRequired = true,
                        ColumnOrder = 1,
                        Precision = this.ReturnDefaultInt32Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = true
                    });

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "ProductDescription");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "ProductDescription",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 2,
                        Precision = 0,
                        Scale = 0,
                        Length = 100,
                        IsPrimaryKey = false
                    });

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "UnitPrice");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "UnitPrice",
                        DomainDataType = DomainDataType.Decimal,
                        IsRequired = false,
                        ColumnOrder = 3,
                        Precision = 19,
                        Scale = 4,
                        Length = 0,
                        IsPrimaryKey = false
                    });

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "Publisher");
            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "Publisher",
                        DomainDataType = DomainDataType.String,
                        IsRequired = false,
                        ColumnOrder = 5,
                        Precision = 0,
                        Scale = 0,
                        Length = 200,
                        IsPrimaryKey = false
                    });

            column = productTable.Columns.FirstOrDefault(c => c.ColumnName == "AmountInStock");

            this.BaseSourceTypeUnitTest_Columns(
                column,
                new Column
                    {
                        ColumnName = "AmountInStock",
                        DomainDataType = DomainDataType.Int16,
                        IsRequired = false,
                        ColumnOrder = 6,
                        Precision = this.ReturnDefaultInt16Precision(),
                        Scale = 0,
                        Length = 0,
                        IsPrimaryKey = false
                    });
        }

        /// <summary>
        /// The base source type unit test_ test values.
        /// </summary>
        /// <param name="databaseModel">
        /// The database model.
        /// </param>
        [TestMethod]
        public void BaseSourceTypeUnitTest_TestValues(DatabaseModel databaseModel)
        {
            Assert.IsNotNull(databaseModel, "The database should not be null");
            Assert.IsNotNull(databaseModel.Tables, "Tables should not be null");
            Assert.AreEqual(9, databaseModel.Tables.Count, "There should be 9 Tables.");
            this.BaseSourceTypeUnitTest_TestProductTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "product"));
            this.BaseSourceTypeUnitTest_TestProductRelationships(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "product"));
            this.BaseSourceTypeUnitTest_TestBook(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "book"));
            this.BaseSourceTypeUnitTest_TestBookRelationships(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "book"));

            this.BaseSourceTypeUnitTest_TestOrderDetailsTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "orderdetails"));
            this.BaseSourceTypeUnitTest_OrderDetailsBook(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "orderdetails"));

            this.BaseSourceTypeUnitTest_SoftwareTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "software"));
            this.BaseSourceTypeUnitTest_Software(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "software"));

            this.BaseSourceTypeUnitTest_CustomerTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "customer"));
            this.BaseSourceTypeUnitTest_CustomerRelationship(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "customer"));

            this.BaseSourceTypeUnitTest_OrderTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "order"));
            this.BaseSourceTypeUnitTest_OrderRelationship(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "order"));

            this.BaseSourceTypeUnitTest_CountryTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "country"));
            this.BaseSourceTypeUnitTest_CountryRelationship(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "country"));

            this.BaseSourceTypeUnitTest_BankAccountTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "bankaccount"));
            this.BaseSourceTypeUnitTest_BankAccountRelationship(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "bankaccount"));

            this.BaseSourceTypeUnitTest_BankTransfersTable(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "banktransfers"));
            this.BaseSourceTypeUnitTest_BankTransfersRelationship(
                databaseModel.Tables.FirstOrDefault(t => t.TableName.ToLower() == "banktransfers"));
        }

        #endregion
    }
}