
// <copyright file="CustomerContext.g.cs" company="MIT">
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


// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System.Data.Entity;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;

namespace Banking.Models.Customers
{
	public partial class CustomerContext : BaseContext
	{	
		#region CTOR
		
		public CustomerContext(string connectionOrName) : base($"name={connectionOrName}") 
		{
			Database.SetInitializer(new CreateDatabaseIfNotExists<CustomerContext>());
			Database.Log = this.Log;
		}
		
		public CustomerContext() 
		{
			Database.SetInitializer(new CreateDatabaseIfNotExists<CustomerContext>());
			Database.Log = this.Log;
		}
		
		#endregion
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Tables
			
			modelBuilder.Entity<Book>().ToTable("Book", "dbo");
			modelBuilder.Entity<Country>().ToTable("Country", "dbo");
			modelBuilder.Entity<Customer>().ToTable("Customer", "dbo");
			modelBuilder.Entity<Order>().ToTable("Order", "dbo");
			modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails", "dbo");
			modelBuilder.Entity<Product>().ToTable("Product", "dbo");
			modelBuilder.Entity<Software>().ToTable("Software", "dbo");

			#endregion
			
			#region Primary keys
			
			modelBuilder.Entity<Book>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Book>().Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<Country>().HasKey(t => t.CountryId);
			modelBuilder.Entity<Country>().Property(t => t.CountryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Customer>().HasKey(t => t.CustomerId);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Order>().HasKey(t => t.OrderId);
			modelBuilder.Entity<Order>().Property(t => t.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<OrderDetails>().HasKey(t => t.OrderDetailsId);
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Product>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Product>().Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Software>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Software>().Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion
			
			#region Relationships
			
			modelBuilder.Entity<Country>().HasMany(t => t.Customers).WithRequired(t => (Country)t.Country);
			modelBuilder.Entity<Customer>().HasMany(t => t.BankAccounts).WithRequired(t => (Customer)t.Customer);
			modelBuilder.Entity<Order>().HasMany(t => t.OrderDetails).WithRequired(t => (Order)t.Order);
			modelBuilder.Entity<Product>().HasMany(t => t.Books).WithRequired(t => (Product)t.Product);
			
			#endregion
			
			#region Constraints
			
			modelBuilder.Entity<Book>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Book>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Book>().Property(t => t.Publisher).IsRequired();
			modelBuilder.Entity<Country>().Property(t => t.CountryId).IsRequired();
			modelBuilder.Entity<Country>().Property(t => t.CountryName).HasMaxLength(100);
			modelBuilder.Entity<Country>().Property(t => t.CountryName).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).HasMaxLength(5);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.Address).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Address).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.City).HasMaxLength(20);
			modelBuilder.Entity<Customer>().Property(t => t.City).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).HasMaxLength(10);
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.Fax).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Fax).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CountryId).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.Photo).HasMaxLength(2147483647);
			modelBuilder.Entity<Customer>().Property(t => t.Photo).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.IsEnabled).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.CustomerId).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.OrderDate).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.DeliveryDate).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.Amount).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.Discount).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).HasMaxLength(100);
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.UnitPrice).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).HasMaxLength(50);
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Product>().Property(t => t.Publisher).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.AmountInStock).IsRequired();
			modelBuilder.Entity<Software>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Software>().Property(t => t.LicenseCode).HasMaxLength(200);
			modelBuilder.Entity<Software>().Property(t => t.LicenseCode).IsRequired();
			
			#endregion
        }
		
		#region Db Sets
		
		public virtual DbSet<Book> Book { get; set; }
		public virtual DbSet<Country> Country { get; set; }
		public virtual DbSet<Customer> Customer { get; set; }
		public virtual DbSet<Order> Order { get; set; }
		public virtual DbSet<OrderDetails> OrderDetails { get; set; }
		public virtual DbSet<Product> Product { get; set; }
		public virtual DbSet<Software> Software { get; set; }

		#endregion
	}
}
