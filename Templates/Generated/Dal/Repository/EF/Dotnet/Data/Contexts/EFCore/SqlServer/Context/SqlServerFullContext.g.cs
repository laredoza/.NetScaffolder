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

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using RepositoryEFDotnet.Contexts.EFCore.Base.Context;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Data.Context.Mappings.EFCore.SqlServer;
using RepositoryEFDotnet.Data.Entity;
using System;

namespace RepositoryEFDotnet.Data.Context.EFCore
{
	public partial class SqlServerFullContext : BaseContext
	{	
		#region CTOR

	    public SqlServerFullContext(string connectionString, IServiceProvider provider = null)
	        : base(connectionString, provider)
	    {
	    }

	    public SqlServerFullContext(DbContextOptions<SqlServerFullContext> options, IServiceProvider provider = null) 
			: base(options, provider) 
		{
		}
		
		#endregion
		
	    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	    {
	        if (!string.IsNullOrEmpty(ConnectionString) && !optionsBuilder.IsConfigured)
	        {
				optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConnectionString);
	        }
	    }
		
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Mappings
			
			modelBuilder.ApplyConfiguration(new FullContextBankAccountMap());
			modelBuilder.ApplyConfiguration(new FullContextBankTransfersMap());
			modelBuilder.ApplyConfiguration(new FullContextBookMap());
			modelBuilder.ApplyConfiguration(new FullContextCountryMap());
			modelBuilder.ApplyConfiguration(new FullContextCustomerMap());
			modelBuilder.ApplyConfiguration(new FullContextOrderMap());
			modelBuilder.ApplyConfiguration(new FullContextOrderDetailsMap());
			modelBuilder.ApplyConfiguration(new FullContextProductMap());
			modelBuilder.ApplyConfiguration(new FullContextSoftwareMap());

			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			

			#endregion
			
			this.Seed(modelBuilder);
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
            //Configuration.LazyLoadingEnabled = true;
            //Configuration.ProxyCreationEnabled = true;
            //Configuration.AutoDetectChangesEnabled = false;
			
			//Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerFullContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqlServerFullContext, Configuration>());
			//Database.Log = this.Log;
        }
		
		#endregion
	}
}
