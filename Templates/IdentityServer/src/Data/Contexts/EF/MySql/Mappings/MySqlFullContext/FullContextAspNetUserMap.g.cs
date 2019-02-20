
// <copyright file="AspNetUserMap.g.cs" company="MIT">
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
using MySql.Data.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EF.MySql.Mappings.MySqlFullContext
{
	public partial class FullContextAspNetUserMap : EntityTypeConfiguration<AspNetUser>
	{	
		public FullContextAspNetUserMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("AspNetUser");
			
			#region Primary Keys
			
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.Id).IsRequired();
			Property(t => t.UserName).HasMaxLength(256);
			Property(t => t.UserName).IsOptional();
			Property(t => t.NormalizedUserName).HasMaxLength(256);
			Property(t => t.NormalizedUserName).IsOptional();
			Property(t => t.Email).HasMaxLength(256);
			Property(t => t.Email).IsOptional();
			Property(t => t.NormalizedEmail).HasMaxLength(256);
			Property(t => t.NormalizedEmail).IsOptional();
			Property(t => t.EmailConfirmed).IsRequired();
			Property(t => t.PasswordHash).IsOptional();
			Property(t => t.SecurityStamp).IsOptional();
			Property(t => t.ConcurrencyStamp).IsOptional();
			Property(t => t.PhoneNumber).IsOptional();
			Property(t => t.PhoneNumberConfirmed).IsRequired();
			Property(t => t.TwoFactorEnabled).IsRequired();
			Property(t => t.LockoutEnd).IsOptional();
			Property(t => t.LockoutEnabled).IsRequired();
			Property(t => t.AccessFailedCount).IsRequired();
			
			#endregion
			
			#region Indexes
			Property(t => t.NormalizedUserName).HasColumnAnnotation("UserNameIndex", new IndexAnnotation(new [] { new IndexAttribute("UserNameIndex"){ IsClustered = false, IsUnique = true, Order = 0}}));
			Property(t => t.NormalizedEmail).HasColumnAnnotation("EmailIndex", new IndexAnnotation(new [] { new IndexAttribute("EmailIndex"){ IsClustered = false, IsUnique = false, Order = 0}}));
			#endregion

			#region Relationships
			
			HasMany<AspNetUserClaim>(s => s.AspNetUserClaim).WithRequired(s => s.AspNetUser).HasForeignKey(s => s.UserId).WillCascadeOnDelete(false);
			HasMany<AspNetUserLogin>(s => s.AspNetUserLogin).WithRequired(s => s.AspNetUser).HasForeignKey(s => s.UserId).WillCascadeOnDelete(false);
			HasMany<AspNetUserRole>(s => s.AspNetUserRole).WithRequired(s => s.AspNetUser).HasForeignKey(s => s.UserId).WillCascadeOnDelete(false);
			HasMany<AspNetUserToken>(s => s.AspNetUserToken).WithRequired(s => s.AspNetUser).HasForeignKey(s => s.UserId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.Id).HasColumnOrder(1);
			Property(t => t.UserName).HasColumnOrder(2);
			Property(t => t.NormalizedUserName).HasColumnOrder(3);
			Property(t => t.Email).HasColumnOrder(4);
			Property(t => t.NormalizedEmail).HasColumnOrder(5);
			Property(t => t.EmailConfirmed).HasColumnOrder(6);
			Property(t => t.PasswordHash).HasColumnOrder(7);
			Property(t => t.SecurityStamp).HasColumnOrder(8);
			Property(t => t.ConcurrencyStamp).HasColumnOrder(9);
			Property(t => t.PhoneNumber).HasColumnOrder(10);
			Property(t => t.PhoneNumberConfirmed).HasColumnOrder(11);
			Property(t => t.TwoFactorEnabled).HasColumnOrder(12);
			Property(t => t.LockoutEnd).HasColumnOrder(13);
			Property(t => t.LockoutEnabled).HasColumnOrder(14);
			Property(t => t.AccessFailedCount).HasColumnOrder(15);

			#endregion
	
		}
	}
}
