
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
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryEFDotnet.Contexts.EFCore;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Accounts.Mappings;
using Banking.Models.Entity;

namespace Banking.Models.Accounts.EFCore
{
	public partial class SqlServerAccountContext : BaseContext
	{	
		#region CTOR

	    public SqlServerAccountContext(string connectionName)
	        : base(connectionName)
	    {
	    }

	    public SqlServerAccountContext(DbContextOptions<SqlServerAccountContext> options) 
			: base(options) 
		{
		}
		
		public SqlServerAccountContext()
			: base("name=RepoTest") 
		{
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
			
			#region Mappings
			
			modelBuilder.ApplyConfiguration(new BankAccountMap());
			modelBuilder.ApplyConfiguration(new BankTransfersMap());

			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			
			modelBuilder.Ignore<Customer>();

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
			
        }
		
		#endregion
	}
}
