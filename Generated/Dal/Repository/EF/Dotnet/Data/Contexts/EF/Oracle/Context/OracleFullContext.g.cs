
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
using Oracle.ManagedDataAccess.Client;
using Oracle.Config;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;


namespace Banking.Models.Context
{
    [DbConfigurationType(typeof(OracleDbConfiguration))]
	public partial class OracleFullContext : BaseContext
	{	
		#region CTOR
		
		public OracleFullContext(DbConnection dbCon, bool contextOwnsConnection = true) 
			: base(dbCon, contextOwnsConnection) 
		{
		}
		
		public OracleFullContext(string connectionOrName) 
			: base($"name={connectionOrName}") 
		{
		}
		
		public OracleFullContext()
			: base("name=RepoTest") 
		{
		}
		
		#endregion
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Tables
			


			modelBuilder.Entity<BankAccount>().ToTable("BankAccount", "DBO");


			modelBuilder.Entity<BankTransfers>().ToTable("BankTransfers", "DBO");


			modelBuilder.Entity<Book>().ToTable("Book", "DBO");


			modelBuilder.Entity<Country>().ToTable("Country", "DBO");


			modelBuilder.Entity<Customer>().ToTable("Customer", "DBO");


			modelBuilder.Entity<Order>().ToTable("Order", "DBO");


			modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails", "DBO");


			modelBuilder.Entity<Product>().ToTable("Product", "DBO");


			modelBuilder.Entity<Software>().ToTable("Software", "DBO");

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
			
			modelBuilder.Entity<BankAccount>().HasMany<BankTransfers>(s => s.BankTransfersFrom).WithRequired(s => s.BankAccountFrom).WillCascadeOnDelete(false);
			modelBuilder.Entity<BankAccount>().HasMany<BankTransfers>(s => s.BankTransfersTo).WithRequired(s => s.BankAccountTo).WillCascadeOnDelete(false);
			modelBuilder.Entity<Country>().HasMany<Customer>(s => s.Customer).WithOptional(s => s.Country).WillCascadeOnDelete(false);
			modelBuilder.Entity<Customer>().HasMany<BankAccount>(s => s.BankAccount).WithOptional(s => s.Customer).WillCascadeOnDelete(false);
			modelBuilder.Entity<Customer>().HasMany<Order>(s => s.Order).WithOptional(s => s.Customer).WillCascadeOnDelete(false);
			modelBuilder.Entity<Order>().HasMany<OrderDetails>(s => s.OrderDetails).WithRequired(s => s.Order).WillCascadeOnDelete(false);
			modelBuilder.Entity<Product>().HasOptional<Book>(s => s.Book).WithRequired(s => s.Product).WillCascadeOnDelete(false);
			modelBuilder.Entity<Product>().HasMany<OrderDetails>(s => s.OrderDetails).WithRequired(s => s.Product).WillCascadeOnDelete(false);
			modelBuilder.Entity<Product>().HasOptional<Software>(s => s.Software).WithRequired(s => s.Product).WillCascadeOnDelete(false);
			
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
			modelBuilder.Entity<BankAccount>().Property(t => t.CustomerId).IsOptional();
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
			modelBuilder.Entity<Country>().Property(t => t.CountryName).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).HasMaxLength(5);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerCode).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.CompanyName).IsRequired();
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactName).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.ContactTitle).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.Address).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Address).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.City).HasMaxLength(20);
			modelBuilder.Entity<Customer>().Property(t => t.City).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).HasMaxLength(10);
			modelBuilder.Entity<Customer>().Property(t => t.PostalCode).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Telephone).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.Fax).HasMaxLength(50);
			modelBuilder.Entity<Customer>().Property(t => t.Fax).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.CountryId).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.Photo).HasMaxLength(2147483647);
			modelBuilder.Entity<Customer>().Property(t => t.Photo).IsOptional();
			modelBuilder.Entity<Customer>().Property(t => t.IsEnabled).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<Order>().Property(t => t.CustomerId).IsOptional();
			modelBuilder.Entity<Order>().Property(t => t.OrderDate).IsOptional();
			modelBuilder.Entity<Order>().Property(t => t.DeliveryDate).IsOptional();
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingName).IsOptional();
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingAddress).IsOptional();
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingCity).IsOptional();
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).HasMaxLength(50);
			modelBuilder.Entity<Order>().Property(t => t.ShippingZip).IsOptional();
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).IsOptional();
			modelBuilder.Entity<OrderDetails>().Property(t => t.UnitPrice).HasPrecision(19, 4);
			modelBuilder.Entity<OrderDetails>().Property(t => t.Amount).IsOptional();
			modelBuilder.Entity<OrderDetails>().Property(t => t.Discount).IsOptional();
			modelBuilder.Entity<Product>().Property(t => t.ProductId).IsRequired();
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).HasMaxLength(100);
			modelBuilder.Entity<Product>().Property(t => t.ProductDescription).IsOptional();
			modelBuilder.Entity<Product>().Property(t => t.UnitPrice).IsOptional();
			modelBuilder.Entity<Product>().Property(t => t.UnitPrice).HasPrecision(19, 4);
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).HasMaxLength(50);
			modelBuilder.Entity<Product>().Property(t => t.UnitAmount).IsOptional();
			modelBuilder.Entity<Product>().Property(t => t.Publisher).HasMaxLength(200);
			modelBuilder.Entity<Product>().Property(t => t.Publisher).IsOptional();
			modelBuilder.Entity<Product>().Property(t => t.AmountInStock).IsOptional();
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
			
			Database.SetInitializer(new CreateDatabaseIfNotExists<OracleFullContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<OracleFullContext, Configuration>());
        }
		
		#endregion
	}
}
