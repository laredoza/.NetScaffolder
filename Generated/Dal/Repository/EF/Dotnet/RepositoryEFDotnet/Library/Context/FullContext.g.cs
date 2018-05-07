﻿
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


// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System.Data.Entity;
using MySql.Data.Entity;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;


namespace Banking.Models.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
	public partial class FullContext : BaseContext
	{	
		#region CTOR
		
		public FullContext(string connectionOrName) 
			: base($"name={connectionOrName}") 
		{
		}
		
		public FullContext()
			: base("name=RepoTest") 
		{
		}
		
		#endregion
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Tables
			
			modelBuilder.Entity<BankAccount>().ToTable("BankAccount", "dbo");
			modelBuilder.Entity<BankTransfers>().ToTable("BankTransfers", "dbo");
			modelBuilder.Entity<Book>().ToTable("Book", "dbo");
			modelBuilder.Entity<Country>().ToTable("Country", "dbo");
			modelBuilder.Entity<Customer>().ToTable("Customer", "dbo");
			modelBuilder.Entity<Order>().ToTable("Order", "dbo");
			modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails", "dbo");
			modelBuilder.Entity<Product>().ToTable("Product", "dbo");
			modelBuilder.Entity<Software>().ToTable("Software", "dbo");

			#endregion
			
			#region Primary keys
			
			modelBuilder.Entity<BankAccount>().HasKey(t => t.BankAccountId);
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<BankTransfers>().HasKey(t => t.BankTransferId);
			modelBuilder.Entity<BankTransfers>().Property(t => t.BankTransferId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
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
			
			#region Included Relationships
			
			modelBuilder.Entity<BankTransfers>().HasRequired<BankAccount>(s => s.BankAccount).WithMany(s => s.BankTransfers).HasForeignKey(s => s.FromBankAccountId).WillCascadeOnDelete(false);
			modelBuilder.Entity<BankTransfers>().HasRequired<BankAccount>(s => s.BankAccount).WithMany(s => s.BankTransfers).HasForeignKey(s => s.ToBankAccountId).WillCascadeOnDelete(false);
			modelBuilder.Entity<Customer>().HasRequired<Country>(s => s.Country).WithMany(s => s.Customers).HasForeignKey(s => s.CountryId).WillCascadeOnDelete(false);
			modelBuilder.Entity<BankAccount>().HasRequired<Customer>(s => s.Customer).WithMany(s => s.BankAccounts).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			modelBuilder.Entity<Order>().HasRequired<Customer>(s => s.Customer).WithMany(s => s.Orders).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			modelBuilder.Entity<OrderDetails>().HasRequired<Order>(s => s.Order).WithMany(s => s.OrderDetails).HasForeignKey(s => s.OrderId).WillCascadeOnDelete(false);
			modelBuilder.Entity<Book>().HasRequired<Product>(s => s.Product).WithMany(s => s.Books).HasForeignKey(s => s.ProductId).WillCascadeOnDelete(false);
			modelBuilder.Entity<OrderDetails>().HasRequired<Product>(s => s.Product).WithMany(s => s.OrderDetails).HasForeignKey(s => s.ProductId).WillCascadeOnDelete(false);
			modelBuilder.Entity<Software>().HasRequired<Product>(s => s.Product).WithMany(s => s.Softwares).HasForeignKey(s => s.ProductId).WillCascadeOnDelete(false);
			
			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			

			#endregion
			
			#region Constraints
			
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountId).IsRequired();
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountNumber).HasMaxLength(10);
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountNumber).IsRequired();
			modelBuilder.Entity<BankAccount>().Property(t => t.Balance).IsRequired();
			modelBuilder.Entity<BankAccount>().Property(t => t.Balance).HasPrecision(19, 4);
			modelBuilder.Entity<BankAccount>().Property(t => t.Locked).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.BankTransferId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.FromBankAccountId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.ToBankAccountId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.Amount).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.Amount).HasPrecision(18, 2);
			modelBuilder.Entity<BankTransfers>().Property(t => t.TransferDate).IsRequired();
			modelBuilder.Entity<Book>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Book>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Book>().Property(t => t.Publisher).IsRequired();
			modelBuilder.Entity<Country>().Property(t => t.CountryId).IsRequired();
			modelBuilder.Entity<Country>().Property(t => t.CountryName).HasMaxLength(100);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).HasMaxLength(5);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Address).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.City).HasMaxLength(20);
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).HasMaxLength(10);
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Fax).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Photo).HasMaxLength(2147483647);
			modelBuilder.Entity<Customer>().Property(t => t.IsEnabled).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).HasMaxLength(50);
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).HasPrecision(19, 4);
			modelBuilder.Entity<Product>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).HasMaxLength(100);
			modelBuilder.Entity<Product>().Property(t => t.UnitPrice).HasPrecision(19, 4);
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).HasMaxLength(50);
			modelBuilder.Entity<Product>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Software>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Software>().Property(t => t.LicenseCode).HasMaxLength(200);
			modelBuilder.Entity<Software>().Property(t => t.LicenseCode).IsRequired();
			
			#endregion
        }
		
		#region Db Sets
		
		public virtual DbSet<BankAccount> BankAccount { get; set; }
		public virtual DbSet<BankTransfers> BankTransfers { get; set; }
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
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
			
			Database.SetInitializer(new CreateDatabaseIfNotExists<FullContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<FullContext, Configuration>());
        }
		
		#endregion
	}
}
