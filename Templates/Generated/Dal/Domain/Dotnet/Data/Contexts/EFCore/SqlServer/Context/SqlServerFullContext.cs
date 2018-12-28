
// <copyright file="FullContext.g.cs" company="MIT">
//  Copyright (c) 2018 MIT
// </copyright>  

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
// IN THE SOFTWARE.


using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using RepositoryEFDotnet.Contexts.EFCore.Base;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Contexts.EFCore.Base.Context;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Data.Context.Mappings.EFCore.SqlServer;
using RepositoryEFDotnet.Data.Entity;
using System;

namespace RepositoryEFDotnet.Data.Context.EFCore
{
	public partial class SqlServerFullContext 
	{	
        #region Public Methods And Operators

        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        public void Seed(ModelBuilder modelBuilder)
        {
            AddCountries(modelBuilder);
            AddProducts(modelBuilder);
            AddCustomers(modelBuilder);
            AddBanking(modelBuilder);
            AddOrders(modelBuilder);
        }

	    private static void AddCountries(ModelBuilder modelBuilder)
	    {
	        modelBuilder.Entity<Country>().HasData(
	            new Country
	            {
	                CountryId = 1,
	                CountryName = "US"
	            });

	        modelBuilder.Entity<Country>().HasData(
	            new Country
	            {
	                CountryId = 2,
	                CountryName = "UK"
	            });
	    }

	    private static void AddProducts(ModelBuilder modelBuilder)
	    {
	        modelBuilder.Entity<Book>().HasData(
	            new Book
	            {
	                ProductId = 1,
	                Publisher = "Best Book Publisher Ever",
	            });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductDescription = "A Book",
                    UnitPrice = 100,
                    AmountInStock = 100
                });

	        modelBuilder.Entity<Software>().HasData(
	            new Software
	            {
	                ProductId = 2,
	                LicenseCode = "#1234567890"
	            });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 2,
                    ProductDescription = "Software",
                    UnitPrice = 200,
                    AmountInStock = 100
                });
        }

	    private static void AddCustomers(ModelBuilder modelBuilder)
	    {
	        modelBuilder.Entity<Customer>().HasData(
	            new Customer 
	            {
	                CustomerId = 1,
	                CustomerCode = "001",
	                CompanyName = "New York Books",
                    ContactName = "Bob",
                    ContactTitle = "Mr",
                    Address = "1st Road",
                    City = "New York",
                    PostalCode = "001",
                    Telephone = "123456789",
                    Fax = "123456789",
                    CountryId = 1,
                    Photo = "",
                    IsEnabled = true 
	            });

	        modelBuilder.Entity<Customer>().HasData(
	            new Customer 
	            {
	                CustomerId = 2,
	                CustomerCode = "002",
	                CompanyName = "London Software",
                    ContactName = "Mary",
                    ContactTitle = "Miss",
                    Address = "2nd Road",
                    City = "London",
                    PostalCode = "002",
                    Telephone = "0123456789",
                    Fax = "0123456789",
                    CountryId = 2,
                    Photo = "",
                    IsEnabled = true 
	            });
	    }

	    private static void AddBanking(ModelBuilder modelBuilder)
	    {
	        modelBuilder.Entity<BankAccount>().HasData(
	            new BankAccount 
	            {
                    BankAccountId = 1,
                    BankAccountNumber = "001",
                    Balance = 10000,
                    CustomerId = 1,
                    Locked = false
	            });

	        modelBuilder.Entity<BankAccount>().HasData(
	            new BankAccount 
	            {
                    BankAccountId = 2,
                    BankAccountNumber = "002",
                    Balance = 20000,
                    CustomerId = 2,
                    Locked = false
	            });

	        modelBuilder.Entity<BankTransfers>().HasData(
	            new BankTransfers 
	            {
                    BankTransferId = 1,
                    FromBankAccountId = 1,
                    ToBankAccountId = 2,
                    Amount = 100,
                    TransferDate = DateTime.Now
	            });


	    }

	    private static void AddOrders(ModelBuilder modelBuilder)
	    {
	        modelBuilder.Entity<Order>().HasData(
	            new Order
	            {
                    OrderId = 1,
                    CustomerId = 2,
                    OrderDate = DateTime.Now,
                    DeliveryDate = DateTime.Now,
                    ShippingName = "Mary",
                    ShippingAddress = "2nd road",
                    ShippingCity = "London",
                    ShippingZip =  "123"
	            });

	        modelBuilder.Entity<OrderDetails>().HasData(
	            new OrderDetails 
	            {
	                OrderDetailsId = 1,
	                OrderId = 1,
	                ProductId = 1,
	                UnitPrice = 100,
                    Amount = 100,
                    Discount = 0
	            });
	    }

	    #endregion
        }
}
