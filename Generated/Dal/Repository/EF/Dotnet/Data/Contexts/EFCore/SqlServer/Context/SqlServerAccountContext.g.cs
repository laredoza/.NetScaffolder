﻿
// <copyright file="AccountContext.g.cs" company="MIT">
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

namespace Banking.Models.Accounts.Core
{
	public partial class SqlServerAccountContext : BaseContext
	{	
		#region CTOR

	    public SqlServerAccountContext(string connectionName)
	        : base(connectionName)
	    {
			SetupContext();
	    }

	    public SqlServerAccountContext(DbContextOptions<SqlServerAccountContext> options) 
			: base(options) 
		{
			SetupContext();
		}
		
		public SqlServerAccountContext()
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
			
			modelBuilder.Entity<BankAccount>().ToTable("BankAccount", "dbo");
			modelBuilder.Entity<BankTransfers>().ToTable("BankTransfers", "dbo");

			#endregion
			
			#region Primary keys
			
			modelBuilder.Entity<BankAccount>().HasKey(t => t.BankAccountId);
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountId).ValueGeneratedOnAdd();
			modelBuilder.Entity<BankTransfers>().HasKey(t => t.BankTransferId);
			modelBuilder.Entity<BankTransfers>().Property(t => t.BankTransferId).ValueGeneratedOnAdd();

			#endregion
			
			#region Included Relationships
			
			modelBuilder.Entity<BankAccount>().HasMany<BankTransfers>(s => s.BankTransfersFrom).WithOne(s => s.BankAccountFrom).HasForeignKey(s => s.FromBankAccountId).OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<BankAccount>().HasMany<BankTransfers>(s => s.BankTransfersTo).WithOne(s => s.BankAccountTo).HasForeignKey(s => s.ToBankAccountId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			
			modelBuilder.Ignore<Customer>();

			#endregion
			
			#region Constraints
			
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountId).IsRequired();
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountNumber).HasMaxLength(10);
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountNumber).IsRequired();
			modelBuilder.Entity<BankAccount>().Property(t => t.Balance).IsRequired();
			modelBuilder.Entity<BankAccount>().Property(t => t.Balance).HasColumnType("decimal(19, 0)");
			modelBuilder.Entity<BankAccount>().Property(t => t.CustomerId).IsRequired(false);
			modelBuilder.Entity<BankAccount>().Property(t => t.Locked).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.BankTransferId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.FromBankAccountId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.ToBankAccountId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.Amount).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.Amount).HasColumnType("decimal(18, 0)");
			modelBuilder.Entity<BankTransfers>().Property(t => t.TransferDate).IsRequired();
			
			#endregion

			
        }
		
		#region Db Sets
		
		public virtual DbSet<BankAccount> BankAccount { get; set; }
		public virtual DbSet<BankTransfers> BankTransfers { get; set; }

		#endregion
		
		#region Setup
        
		protected override void SetupContext()
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.AutoDetectChangesEnabled = false;
			
			//Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerAccountContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqlServerAccountContext, Configuration>());
        }
		
		#endregion
	}
}