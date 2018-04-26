
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Primary keys
			
			modelBuilder.Entity<Book>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Book>().Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<Country>().HasKey(t => t.CountryId);
			modelBuilder.Entity<Country>().Property(t => t.CountryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<Customer>().HasKey(t => t.CustomerId);
			modelBuilder.Entity<Customer>().Property(t => t.CustomerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<Order>().HasKey(t => t.OrderId);
			modelBuilder.Entity<Order>().Property(t => t.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<OrderDetails>().HasKey(t => t.OrderDetailsId);
			modelBuilder.Entity<OrderDetails>().Property(t => t.OrderDetailsId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<Product>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Product>().Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<Software>().HasKey(t => t.ProductId);
			modelBuilder.Entity<Software>().Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion
			
			#region Relationships
			
			modelBuilder.Entity<Country>().HasRequired(t => t.Customer).WithMany(t => t.Customer);
			modelBuilder.Entity<Customer>().HasRequired(t => t.BankAccount).WithMany(t => t.BankAccount);
			modelBuilder.Entity<Order>().HasRequired(t => t.OrderDetails).WithMany(t => t.OrderDetails);
			modelBuilder.Entity<Product>().HasRequired(t => t.Book).WithMany(t => t.Book);
			
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
