using System;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using Microsoft.EntityFrameworkCore;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Seed
{
    public static class MigrationHelper
    {
        public  static void AddCountries(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Country>().HasData(
            //    new Country
            //    {
            //        CountryId = 1,
            //        CountryName = "US"
            //    });

            //modelBuilder.Entity<Country>().HasData(
            //    new Country
            //    {
            //        CountryId = 2,
            //        CountryName = "UK"
            //    });
        }

        public static void AddProducts(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().HasData(
            //    new Book
            //    {
            //        ProductId = 1,
            //        Publisher = "Best Book Publisher Ever",
            //    });

            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        ProductId = 1,
            //        ProductDescription = "A Book",
            //        UnitPrice = 100,
            //        AmountInStock = 100
            //    });

            //modelBuilder.Entity<Software>().HasData(
            //    new Software
            //    {
            //        ProductId = 2,
            //        LicenseCode = "#1234567890"
            //    });

            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        ProductId = 2,
            //        ProductDescription = "Software",
            //        UnitPrice = 200,
            //        AmountInStock = 100
            //    });
        }

        public static void AddCustomers(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().HasData(
            //    new Customer
            //    {
            //        CustomerId = 1,
            //        CustomerCode = "001",
            //        CompanyName = "New York Books",
            //        ContactName = "Bob",
            //        ContactTitle = "Mr",
            //        Address = "1st Road",
            //        City = "New York",
            //        PostalCode = "001",
            //        Telephone = "123456789",
            //        Fax = "123456789",
            //        CountryId = 1,
            //        Photo = "",
            //        IsEnabled = true
            //    });

            //modelBuilder.Entity<Customer>().HasData(
            //    new Customer
            //    {
            //        CustomerId = 2,
            //        CustomerCode = "002",
            //        CompanyName = "London Software",
            //        ContactName = "Mary",
            //        ContactTitle = "Miss",
            //        Address = "2nd Road",
            //        City = "London",
            //        PostalCode = "002",
            //        Telephone = "0123456789",
            //        Fax = "0123456789",
            //        CountryId = 2,
            //        Photo = "",
            //        IsEnabled = true
            //    });
        }

        public static void AddBanking(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BankAccount>().HasData(
            //    new BankAccount
            //    {
            //        BankAccountId = 1,
            //        BankAccountNumber = "001",
            //        Balance = 10000,
            //        CustomerId = 1,
            //        Locked = false
            //    });

            //modelBuilder.Entity<BankAccount>().HasData(
            //    new BankAccount
            //    {
            //        BankAccountId = 2,
            //        BankAccountNumber = "002",
            //        Balance = 20000,
            //        CustomerId = 2,
            //        Locked = false
            //    });

            //modelBuilder.Entity<BankTransfers>().HasData(
            //    new BankTransfers
            //    {
            //        BankTransferId = 1,
            //        FromBankAccountId = 1,
            //        ToBankAccountId = 2,
            //        Amount = 100,
            //        TransferDate = DateTime.Now
            //    });


        }

        public static void AddOrders(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Order>().HasData(
            //    new Order
            //    {
            //        OrderId = 1,
            //        CustomerId = 2,
            //        OrderDate = DateTime.Now,
            //        DeliveryDate = DateTime.Now,
            //        ShippingName = "Mary",
            //        ShippingAddress = "2nd road",
            //        ShippingCity = "London",
            //        ShippingZip = "123"
            //    });

            //modelBuilder.Entity<OrderDetails>().HasData(
            //    new OrderDetails
            //    {
            //        OrderDetailsId = 1,
            //        OrderId = 1,
            //        ProductId = 1,
            //        UnitPrice = 100,
            //        Amount = 100,
            //        Discount = 0
            //    });
        }
    }
}
