
// <copyright file="FullContext.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Contexts.EF.Base.Context;
using DotNetScaffolder.Domain.Core.Interfaces;
using DotNetScaffolder.Domain.Data.Contexts.EF.Oracle.Mappings.OracleFullContext;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EF.Oracle.Context
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
			
			#region Mappings
			
			modelBuilder.Configurations.Add(new FullContextAspNetRoleMap());
			modelBuilder.Configurations.Add(new FullContextAspNetRoleClaimMap());
			modelBuilder.Configurations.Add(new FullContextAspNetUserMap());
			modelBuilder.Configurations.Add(new FullContextAspNetUserClaimMap());
			modelBuilder.Configurations.Add(new FullContextAspNetUserLoginMap());
			modelBuilder.Configurations.Add(new FullContextAspNetUserRoleMap());
			modelBuilder.Configurations.Add(new FullContextAspNetUserTokenMap());

			#endregion
			
			#region Excluded Relationships
			
			// Exclude entities not part of this context
			

			#endregion		
        }
		
		#region Db Sets
		
		public virtual DbSet<AspNetRole> AspNetRole { get; set; }
		public virtual DbSet<AspNetRoleClaim> AspNetRoleClaim { get; set; }
		public virtual DbSet<AspNetUser> AspNetUser { get; set; }
		public virtual DbSet<AspNetUserClaim> AspNetUserClaim { get; set; }
		public virtual DbSet<AspNetUserLogin> AspNetUserLogin { get; set; }
		public virtual DbSet<AspNetUserRole> AspNetUserRole { get; set; }
		public virtual DbSet<AspNetUserToken> AspNetUserToken { get; set; }

		#endregion
		
		#region Setup
        
		protected override void SetupContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
			
			System.Data.Entity.Database.SetInitializer(new CreateDatabaseIfNotExists<OracleFullContext>());
			Database.Log = this.Log;
        }
		
		#endregion
	}
}
