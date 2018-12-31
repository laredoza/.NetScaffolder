using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryEFDotnet.Contexts.EFCore.SqlServer.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "CountryId", "CustomerCode", "Fax", "IsEnabled", "Photo", "PostalCode", "Telephone" },
                values: new object[] { 1, "1st Road", "New York", "New York Books", "Bob", "Mr", 1, "001", "123456789", true, "", "001", "123456789" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "CountryId", "CustomerCode", "Fax", "IsEnabled", "Photo", "PostalCode", "Telephone" },
                values: new object[] { 2, "2nd Road", "London", "London Software", "Mary", "Miss", 2, "002", "0123456789", true, "", "002", "0123456789" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BankAccount",
                columns: new[] { "BankAccountId", "Balance", "BankAccountNumber", "CustomerId", "Locked" },
                values: new object[] { 1, 10000m, "001", 1, false });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BankAccount",
                columns: new[] { "BankAccountId", "Balance", "BankAccountNumber", "CustomerId", "Locked" },
                values: new object[] { 2, 20000m, "002", 2, false });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "DeliveryDate", "OrderDate", "ShippingAddress", "ShippingCity", "ShippingName", "ShippingZip" },
                values: new object[] { 1, 2, new DateTime(2018, 12, 28, 17, 52, 24, 488, DateTimeKind.Local).AddTicks(7501), new DateTime(2018, 12, 28, 17, 52, 24, 488, DateTimeKind.Local).AddTicks(6535), "2nd road", "London", "Mary", "123" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BankTransfers",
                columns: new[] { "BankTransferId", "Amount", "FromBankAccountId", "ToBankAccountId", "TransferDate" },
                values: new object[] { 1, 100m, 1, 2, new DateTime(2018, 12, 28, 17, 52, 24, 486, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "OrderDetails",
                columns: new[] { "OrderDetailsId", "Amount", "Discount", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { 1, (short)100, 0f, 1, 1, 100m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BankTransfers",
                keyColumn: "BankTransferId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderDetails",
                keyColumn: "OrderDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
