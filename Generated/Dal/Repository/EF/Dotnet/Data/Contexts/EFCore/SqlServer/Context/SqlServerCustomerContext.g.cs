
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RepositoryEFDotnet.Contexts.EFCore;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;

namespace Banking.Models.Customers.Core
{
	public partial class SqlServerCustomerContext : BaseContext
	{	
		#region CTOR

	    public SqlServerCustomerContext(string connectionName)
	        : base(connectionName)
	    {
			SetupContext();
	    }

	    public SqlServerCustomerContext(DbContextOptions<SqlServerCustomerContext> options) 
			: base(options) 
		{
			SetupContext();
		}
		
		public SqlServerCustomerContext()
			: base("name=RepoTest") 
		{
			SetupContext();
		}
		
		#endregion
		
	    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	    {
	        if (!string.IsNullOrEmpty(ConnectionName) && !optionsBuilder.IsConfigured)
	        {
				optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString);
	        }
	    }
		
        protected override void OnModelCreating(ModelBuilder modelBuilder)
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
			modelBuilder.Entity<Book>().Property(t => t.ProductId).ValueGeneratedNever();
			modelBuilder.Entity<Country>().HasKey(t => t.CountryId);
			modelBuilder.Entity<Country>().Property(t => t.CountryId).ValueGeneratedOnAdd();
			modelBuilder.Entity<Customer>().HasKey(t => t.CustomerId);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).ValueGeneratedOnAdd();
			modelBuilder.Entity<Order>().HasKey(t => t.OrderId);
			modelBuilder.Entity<Order>().Property(t => t.OrderId).ValueGeneratedOnAdd();
			modelBuilder.Entity<OrderDetails>().HasKey(t => t.OrderDetailsId);
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).ValueGeneratedOnAdd();
			modelBuilder.Entity<Product>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Product>().Property(t => t.ProductId).ValueGeneratedOnAdd();
			modelBuilder.Entity<Software>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Software>().Property(t => t.ProductId).ValueGeneratedNever();

			#endregion
			
			#region Included Relationships
			
			modelBuilder.Entity<Country>().HasMany<Customer>(s => s.Customer).WithOne(s => s.Country).HasForeignKey(s => s.CountryId).OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Customer>().HasMany<Order>(s => s.Order).WithOne(s => s.Customer).HasForeignKey(s => s.CustomerId).OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Order>().HasMany<OrderDetails>(s => s.OrderDetails).WithOne(s => s.Order).HasForeignKey(s => s.OrderId).OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Product>().HasOne<Book>(s => s.Book).WithOne(s => s.Product).OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Product>().HasMany<OrderDetails>(s => s.OrderDetails).WithOne(s => s.Product).HasForeignKey(s => s.ProductId).OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Product>().HasOne<Software>(s => s.Software).WithOne(s => s.Product).OnDelete(DeleteBehavior.Restrict);
			
			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			
			modelBuilder.Ignore<BankAccount>();

			#endregion
			
			#region Constraints
			
			modelBuilder.Entity<Book>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Book>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Book>().Property(t => t.Publisher).IsRequired();
			modelBuilder.Entity<Country>().Property(t => t.CountryId).IsRequired();
			modelBuilder.Entity<Country>().Property(t => t.CountryName).HasMaxLength(100);
			modelBuilder.Entity<Country>().Property(t => t.CountryName).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).HasMaxLength(5);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.Address).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Address).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.City).HasMaxLength(20);
			modelBuilder.Entity<Customer>().Property(t => t.City).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).HasMaxLength(10);
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.Fax).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Fax).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.CountryId).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.Photo).HasMaxLength(2147483647);
			modelBuilder.Entity<Customer>().Property(t => t.Photo).IsRequired(false);
			modelBuilder.Entity<Customer>().Property(t => t.IsEnabled).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.CustomerId).IsRequired(false);
			modelBuilder.Entity<Order>().Property(t => t.OrderDate).IsRequired(false);
			modelBuilder.Entity<Order>().Property(t => t.DeliveryDate).IsRequired(false);
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).IsRequired(false);
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).IsRequired(false);
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).IsRequired(false);
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).IsRequired(false);
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).IsRequired(false);
			// TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).HasPrecision(19, 4);
			modelBuilder.Entity<OrderDetails>().Property(t => t.Amount).IsRequired(false);
			modelBuilder.Entity<OrderDetails>().Property(t => t.Discount).IsRequired(false);
			modelBuilder.Entity<Product>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).HasMaxLength(100);
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).IsRequired(false);
			modelBuilder.Entity<Product>().Property(t => t.UnitPrice).IsRequired(false);
			// TODO: modelBuilder.Entity<Product>().Property(t => t.UnitPrice).HasPrecision(19, 4);
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).HasMaxLength(50);
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).IsRequired(false);
			modelBuilder.Entity<Product>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Product>().Property(t => t.Publisher).IsRequired(false);
			modelBuilder.Entity<Product>().Property(t => t.AmountInStock).IsRequired(false);
			modelBuilder.Entity<Software>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Software>().Property(t => t.LicenseCode).HasMaxLength(200);
			modelBuilder.Entity<Software>().Property(t => t.LicenseCode).IsRequired();
			
			#endregion

			#region Column Order
			
			//TODO: modelBuilder.Entity<Book>().Property(t => t.ProductId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<Book>().Property(t => t.Publisher).HasColumnOrder(2);
			//TODO: modelBuilder.Entity<Country>().Property(t => t.CountryId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<Country>().Property(t => t.CountryName).HasColumnOrder(2);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.CustomerId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).HasColumnOrder(2);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.CompanyName).HasColumnOrder(3);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.ContactName).HasColumnOrder(4);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).HasColumnOrder(5);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.Address).HasColumnOrder(6);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.City).HasColumnOrder(7);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.PostalCode).HasColumnOrder(8);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.Telephone).HasColumnOrder(9);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.Fax).HasColumnOrder(10);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.CountryId).HasColumnOrder(11);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.Photo).HasColumnOrder(12);
			//TODO: modelBuilder.Entity<Customer>().Property(t => t.IsEnabled).HasColumnOrder(13);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.OrderId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.CustomerId).HasColumnOrder(2);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.OrderDate).HasColumnOrder(3);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.DeliveryDate).HasColumnOrder(4);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.ShippingName).HasColumnOrder(5);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).HasColumnOrder(6);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.ShippingCity).HasColumnOrder(7);
			//TODO: modelBuilder.Entity<Order>().Property(t => t.ShippingZip).HasColumnOrder(8);
			//TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.OrderId).HasColumnOrder(2);
			//TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.ProductId).HasColumnOrder(3);
			//TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).HasColumnOrder(4);
			//TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.Amount).HasColumnOrder(5);
			//TODO: modelBuilder.Entity<OrderDetails>().Property(t => t.Discount).HasColumnOrder(6);
			//TODO: modelBuilder.Entity<Product>().Property(t => t.ProductId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<Product>().Property(t => t.ProductDescription).HasColumnOrder(2);
			//TODO: modelBuilder.Entity<Product>().Property(t => t.UnitPrice).HasColumnOrder(3);
			//TODO: modelBuilder.Entity<Product>().Property(t => t.UnitAmount).HasColumnOrder(4);
			//TODO: modelBuilder.Entity<Product>().Property(t => t.Publisher).HasColumnOrder(5);
			//TODO: modelBuilder.Entity<Product>().Property(t => t.AmountInStock).HasColumnOrder(6);
			//TODO: modelBuilder.Entity<Software>().Property(t => t.ProductId).HasColumnOrder(1);
			//TODO: modelBuilder.Entity<Software>().Property(t => t.LicenseCode).HasColumnOrder(2);

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
		
		#region Setup
        
		protected override void SetupContext()
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.AutoDetectChangesEnabled = false;
			
			//Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerCustomerContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqlServerCustomerContext, Configuration>());
			//Database.Log = this.Log;
        }
		
		#endregion
	}
}
