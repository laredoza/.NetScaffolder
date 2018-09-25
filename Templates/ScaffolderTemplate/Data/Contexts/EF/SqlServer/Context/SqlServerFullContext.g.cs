
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;
using Banking.Models.Context.Mappings.EF.SqlServer;
using System.Data.Common;
using RepositoryEFDotnet.Contexts.EF;

namespace Banking.Models.Context.EF
{
	public partial class SqlServerFullContext : BaseContext
	{	
		#region CTOR
		
		public SqlServerFullContext(DbConnection dbCon, bool contextOwnsConnection = true) 
			: base(dbCon, contextOwnsConnection) 
		{
		}
		
		public SqlServerFullContext(string connectionOrName) 
			: base($"name={connectionOrName}") 
		{
		}
		
		public SqlServerFullContext()
			: base("name=RepoTest") 
		{
		}
		
		#endregion
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Mappings
			
			modelBuilder.Configurations.Add(new BankAccountMap());
			modelBuilder.Configurations.Add(new BookMap());
			modelBuilder.Configurations.Add(new CountryMap());
			modelBuilder.Configurations.Add(new CustomerMap());
			modelBuilder.Configurations.Add(new OrderMap());
			modelBuilder.Configurations.Add(new ProductMap());
			modelBuilder.Configurations.Add(new SoftwareMap());
			modelBuilder.Configurations.Add(new softwareproviderMap());
			modelBuilder.Configurations.Add(new burgerTableMap());
			modelBuilder.Configurations.Add(new BankTransfersMap());
			modelBuilder.Configurations.Add(new OrderDetailsMap());
			modelBuilder.Configurations.Add(new SelfRefTAbleMap());

            #endregion

            #region Excluded Relationships

            // Exclude entities not part of this context


            #endregion

            #region Conventions

            this.AddCustomConventions(modelBuilder);

            #endregion
        }

        #region Db Sets

        public virtual DbSet<BankAccount> BankAccount { get; set; }
		public virtual DbSet<Book> Book { get; set; }
		public virtual DbSet<Country> Country { get; set; }
		public virtual DbSet<Customer> Customer { get; set; }
		public virtual DbSet<Order> Order { get; set; }
		public virtual DbSet<Product> Product { get; set; }
		public virtual DbSet<Software> Software { get; set; }
		public virtual DbSet<softwareprovider> softwareprovider { get; set; }
		public virtual DbSet<burgerTable> burgerTable { get; set; }
		public virtual DbSet<BankTransfers> BankTransfers { get; set; }
		public virtual DbSet<OrderDetails> OrderDetails { get; set; }
		public virtual DbSet<SelfRefTAble> SelfRefTAble { get; set; }

		#endregion
		
		#region Setup
        
		protected override void SetupContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
			
			Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerFullContext>());
			Database.Log = this.Log;
        }
		
		#endregion
	}
}
