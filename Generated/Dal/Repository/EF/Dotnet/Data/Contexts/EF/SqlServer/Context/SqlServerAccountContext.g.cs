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

using System.Data.Entity;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;


namespace Banking.Models.Accounts
{
	public partial class AccountContext : BaseContext
	{	
		#region CTOR
		
		public AccountContext(string connectionOrName) 
			: base($"name={connectionOrName}") 
		{
		}
		
		public AccountContext()
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

			#endregion
			
			#region Primary keys
			
			modelBuilder.Entity<BankAccount>().HasKey(t => t.BankAccountId);
			modelBuilder.Entity<BankAccount>().Property(t => t.BankAccountId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<BankTransfers>().HasKey(t => t.BankTransferId);
			modelBuilder.Entity<BankTransfers>().Property(t => t.BankTransferId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			#endregion
			
			#region Included Relationships
			
			modelBuilder.Entity<BankTransfers>().HasRequired<BankAccount>(s => s.BankAccount).WithMany(s => s.BankTransfers).HasForeignKey(s => s.FromBankAccountId).WillCascadeOnDelete(false);
			modelBuilder.Entity<BankTransfers>().HasRequired<BankAccount>(s => s.BankAccount).WithMany(s => s.BankTransfers).HasForeignKey(s => s.ToBankAccountId).WillCascadeOnDelete(false);
			
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
			modelBuilder.Entity<BankAccount>().Property(t => t.Balance).HasPrecision(19, 4);
			modelBuilder.Entity<BankAccount>().Property(t => t.CustomerId).IsOptional();
			modelBuilder.Entity<BankAccount>().Property(t => t.Locked).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.BankTransferId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.FromBankAccountId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.ToBankAccountId).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.Amount).IsRequired();
			modelBuilder.Entity<BankTransfers>().Property(t => t.Amount).HasPrecision(18, 2);
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
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
			
			Database.SetInitializer(new CreateDatabaseIfNotExists<AccountContext>());
			// Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccountContext, Configuration>());
        }
		
		#endregion
	}
}
