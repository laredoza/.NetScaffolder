
// <copyright file="AspNetUserRoleMap.g.cs" company="MIT">
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

using Npgsql;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EF.Postgres.Mappings.PostgresFullContext
{
	public partial class FullContextAspNetUserRoleMap : EntityTypeConfiguration<AspNetUserRole>
	{	
		public FullContextAspNetUserRoleMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("AspNetUserRole", "dbo");
			
			#region Primary Keys
			
			HasKey(t => new {t.UserId, t.RoleId});
			Property(t => t.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			Property(t => t.RoleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.UserId).IsRequired();
			Property(t => t.RoleId).IsRequired();
			
			#endregion
			
			#region Indexes
			Property(t => t.RoleId).HasColumnAnnotation("IX_AspNetUserRoles_RoleId", new IndexAnnotation(new [] { new IndexAttribute("IX_AspNetUserRoles_RoleId"){ IsClustered = false, IsUnique = false, Order = 0}}));
			#endregion

			#region Relationships
			
			HasRequired<AspNetRole>(s => s.AspNetRole).WithMany(s => s.AspNetUserRole).HasForeignKey(s => s.RoleId).WillCascadeOnDelete(false);
			HasRequired<AspNetUser>(s => s.AspNetUser).WithMany(s => s.AspNetUserRole).HasForeignKey(s => s.UserId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.UserId).HasColumnOrder(1);
			Property(t => t.RoleId).HasColumnOrder(2);

			#endregion
	
		}
	}
}
