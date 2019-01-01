using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.MySql.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false),
                    CountryName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 100, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19, 4)", nullable: true),
                    AmountInStock = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    CustomerCode = table.Column<string>(maxLength: 5, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    ContactName = table.Column<string>(maxLength: 50, nullable: true),
                    ContactTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Telephone = table.Column<string>(maxLength: 50, nullable: true),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    Photo = table.Column<string>(maxLength: 255, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    Publisher = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Book_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    LicenseCode = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Software_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankAccount",
                columns: table => new
                {
                    BankAccountId = table.Column<int>(nullable: false),
                    BankAccountNumber = table.Column<string>(maxLength: 10, nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(19, 4)", nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    Locked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccount", x => x.BankAccountId);
                    table.ForeignKey(
                        name: "FK_BankAccount_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    ShippingName = table.Column<string>(maxLength: 50, nullable: true),
                    ShippingAddress = table.Column<string>(maxLength: 50, nullable: true),
                    ShippingCity = table.Column<string>(maxLength: 50, nullable: true),
                    ShippingZip = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankTransfers",
                columns: table => new
                {
                    BankTransferId = table.Column<int>(nullable: false),
                    FromBankAccountId = table.Column<int>(nullable: false),
                    ToBankAccountId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TransferDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransfers", x => x.BankTransferId);
                    table.ForeignKey(
                        name: "FK_BankTransfers_BankAccount_ToBankAccountId",
                        column: x => x.ToBankAccountId,
                        principalTable: "BankAccount",
                        principalColumn: "BankAccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(19, 4)", nullable: true),
                    Amount = table.Column<short>(nullable: true),
                    Discount = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 1, "US" },
                    { 2, "UK" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "AmountInStock", "ProductDescription", "UnitPrice" },
                values: new object[,]
                {
                    { 1, (short)100, "A Book", 100m },
                    { 2, (short)100, "Software", 200m }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "ProductId", "Publisher" },
                values: new object[] { 1, "Best Book Publisher Ever" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "CountryId", "CustomerCode", "Fax", "IsEnabled", "Photo", "PostalCode", "Telephone" },
                values: new object[,]
                {
                    { 1, "1st Road", "New York", "New York Books", "Bob", "Mr", 1, "001", "123456789", true, "", "001", "123456789" },
                    { 2, "2nd Road", "London", "London Software", "Mary", "Miss", 2, "002", "0123456789", true, "", "002", "0123456789" }
                });

            migrationBuilder.InsertData(
                table: "Software",
                columns: new[] { "ProductId", "LicenseCode" },
                values: new object[] { 2, "#1234567890" });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "Balance", "BankAccountNumber", "CustomerId", "Locked" },
                values: new object[] { 1, 10000m, "001", 1, false });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "Balance", "BankAccountNumber", "CustomerId", "Locked" },
                values: new object[] { 2, 20000m, "002", 2, false });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "DeliveryDate", "OrderDate", "ShippingAddress", "ShippingCity", "ShippingName", "ShippingZip" },
                values: new object[] { 1, 2, new DateTime(2019, 1, 1, 18, 53, 10, 885, DateTimeKind.Local).AddTicks(869), new DateTime(2019, 1, 1, 18, 53, 10, 884, DateTimeKind.Local).AddTicks(9920), "2nd road", "London", "Mary", "123" });

            migrationBuilder.InsertData(
                table: "BankTransfers",
                columns: new[] { "BankTransferId", "Amount", "FromBankAccountId", "ToBankAccountId", "TransferDate" },
                values: new object[] { 1, 100m, 1, 2, new DateTime(2019, 1, 1, 18, 53, 10, 882, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailsId", "Amount", "Discount", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { 1, (short)100, 0f, 1, 1, 100m });

            migrationBuilder.CreateIndex(
                name: "UQ__BankAcco__4FC8E4A0C45281C8",
                table: "BankAccount",
                column: "BankAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerId",
                table: "BankAccount",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "UQ__BankTran__2E82727AB11DB584",
                table: "BankTransfers",
                column: "BankTransferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToBankAccountId",
                table: "BankTransfers",
                column: "ToBankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductId",
                table: "Book",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "UQ__Country__10D1609E8CC26505",
                table: "Country",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CountryId",
                table: "Customer",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "UQ__Customer__A4AE64D98B60CE6B",
                table: "Customer",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "UQ__Order__C3905BCE3C614174",
                table: "Order",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__OrderDet__9DD74DBC8AA17DA0",
                table: "OrderDetails",
                column: "OrderDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "UQ__Product__B40CC6CC5F2A0195",
                table: "Product",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductId",
                table: "Software",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankTransfers");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
