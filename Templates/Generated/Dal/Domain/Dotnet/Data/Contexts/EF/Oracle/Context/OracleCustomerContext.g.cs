﻿
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
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using Oracle.ManagedDataAccess.Client;
using Oracle.Config;
using System.ComponentModel.DataAnnotations.Schema;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Contexts.EF.Base.Context;
using RepositoryEFDotnet.Data.Customers.Mappings.EF.Oracle;
using RepositoryEFDotnet.Data.Entity;
using System.Data.Common;

namespace RepositoryEFDotnet.Data.Customers.EF
{
    [DbConfigurationType(typeof(OracleDbConfiguration))]
	public partial class OracleCustomerContext : BaseContext
	{	
		#region CTOR
		
		public OracleCustomerContext(DbConnection dbCon, bool contextOwnsConnection = true) 
			: base(dbCon, contextOwnsConnection) 
		{
		}
		
		public OracleCustomerContext(string connectionOrName) 
			: base($"name={connectionOrName}") 
		{
		}
		
		public OracleCustomerContext()
			: base("name=RepoTest") 
		{
		}
		
		#endregion
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			#region Mappings
			
			modelBuilder.Configurations.Add(new CustomerContextBookMap());
			modelBuilder.Configurations.Add(new CustomerContextCountryMap());
			modelBuilder.Configurations.Add(new CustomerContextCustomerMap());
			modelBuilder.Configurations.Add(new CustomerContextOrderMap());
			modelBuilder.Configurations.Add(new CustomerContextOrderDetailsMap());
			modelBuilder.Configurations.Add(new CustomerContextProductMap());
			modelBuilder.Configurations.Add(new CustomerContextSoftwareMap());

			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			
			modelBuilder.Ignore<BankAccount>();

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
		
		#region Setup
        
		protected override void SetupContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
			
			Database.SetInitializer(new CreateDatabaseIfNotExists<OracleCustomerContext>());
			Database.Log = this.Log;
        }
		
		#endregion
	}
}