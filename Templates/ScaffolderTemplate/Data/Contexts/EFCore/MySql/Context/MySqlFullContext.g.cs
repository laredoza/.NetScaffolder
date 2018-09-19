
// <copyright file="FullContext.g.cs" company="Dot Net Scaffolder">
//  Copyright (c) 2018 MIT License
// </copyright>  

 // Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in th
// e Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subj
// ect to the following conditions: The above copyright notice and this permission 
// notice shall be included in all copies or substantial portions of the Software. 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLI
// ED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR 
// A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYR
// IGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WIT
// H THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using RepositoryEFDotnet.Core.Base;
using Banking.Models.Context.Mappings.EFCore.MySql;
using Banking.Models.Entity;
using RepositoryEFDotnet.Contexts.EFCore;

namespace Banking.Models.Context.EFCore
{
	public partial class MySqlFullContext : BaseContext
	{	
		#region CTOR

	    public MySqlFullContext(string connectionString)
	        : base(connectionString)
	    {
	    }

	    public MySqlFullContext(DbContextOptions<MySqlFullContext> options) 
			: base(options) 
		{
		}
		
		#endregion
		
	    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	    {
	        if (!string.IsNullOrEmpty(ConnectionString) && !optionsBuilder.IsConfigured)
	        {
				optionsBuilder.UseMySql(ConnectionString);
	        }
	    }
		
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Mappings
			
			modelBuilder.ApplyConfiguration(new BankAccountMap());
			modelBuilder.ApplyConfiguration(new BankTransfersMap());
			modelBuilder.ApplyConfiguration(new BookMap());
			modelBuilder.ApplyConfiguration(new CountryMap());
			modelBuilder.ApplyConfiguration(new CustomerMap());
			modelBuilder.ApplyConfiguration(new OrderMap());
			modelBuilder.ApplyConfiguration(new OrderDetailsMap());
			modelBuilder.ApplyConfiguration(new ProductMap());
			modelBuilder.ApplyConfiguration(new SoftwareMap());
			modelBuilder.ApplyConfiguration(new softwareproviderMap());
			modelBuilder.ApplyConfiguration(new burgerTableMap());

			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			

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
		public virtual DbSet<softwareprovider> softwareprovider { get; set; }
		public virtual DbSet<burgerTable> burgerTable { get; set; }

		#endregion
		
		#region Setup
        
		protected override void SetupContext()
        {
            //Configuration.LazyLoadingEnabled = true;
            //Configuration.ProxyCreationEnabled = true;
            //Configuration.AutoDetectChangesEnabled = false;
			
			//Database.SetInitializer(new CreateDatabaseIfNotExists<MySqlFullContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<MySqlFullContext, Configuration>());
			//Database.Log = this.Log;
        }
		
		#endregion
	}
}
