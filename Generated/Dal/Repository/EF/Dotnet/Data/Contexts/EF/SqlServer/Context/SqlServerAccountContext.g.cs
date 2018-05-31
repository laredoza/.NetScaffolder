
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
using System.Data.Entity.ModelConfiguration;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using Banking.Models.Mappings.EF;
using System.Data.Common;


namespace Banking.Models.Accounts
{
	public partial class SqlServerAccountContext : BaseContext
	{	
		#region CTOR
		
		public SqlServerAccountContext(DbConnection dbCon, bool contextOwnsConnection = true) 
			: base(dbCon, contextOwnsConnection) 
		{
		}
		
		public SqlServerAccountContext(string connectionOrName) 
			: base($"name={connectionOrName}") 
		{
		}
		
		public SqlServerAccountContext()
			: base("name=RepoTest") 
		{
		}
		
		#endregion
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Mappings
			
			modelBuilder.Configurations.Add(new BankAccountMap());
			modelBuilder.Configurations.Add(new BankTransfersMap());

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
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
			
        }
		
		#endregion
	}
}
