
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Postgres.Mappings.PostgresFullContext
{
	public partial class FullContextAspNetUserMap : IEntityTypeConfiguration<AspNetUser>
	{	
	    public virtual void Configure(EntityTypeBuilder<AspNetUser> builder)
	    {
			builder.ToTable("AspNetUser");
			
			#region Primary keys
			
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.Id).HasMaxLength(450);
			builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
			builder.Property(t => t.UserName).HasMaxLength(256);
			builder.Property(t => t.UserName).HasColumnName("UserName").IsRequired(false);
			builder.Property(t => t.NormalizedUserName).HasMaxLength(256);
			builder.Property(t => t.NormalizedUserName).HasColumnName("NormalizedUserName").IsRequired(false);
			builder.Property(t => t.Email).HasMaxLength(256);
			builder.Property(t => t.Email).HasColumnName("Email").IsRequired(false);
			builder.Property(t => t.NormalizedEmail).HasMaxLength(256);
			builder.Property(t => t.NormalizedEmail).HasColumnName("NormalizedEmail").IsRequired(false);
			builder.Property(t => t.EmailConfirmed).HasColumnName("EmailConfirmed").IsRequired();
			builder.Property(t => t.PasswordHash).HasColumnName("PasswordHash").IsRequired(false);
			builder.Property(t => t.SecurityStamp).HasColumnName("SecurityStamp").IsRequired(false);
			builder.Property(t => t.ConcurrencyStamp).HasColumnName("ConcurrencyStamp").IsRequired(false);
			builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired(false);
			builder.Property(t => t.PhoneNumberConfirmed).HasColumnName("PhoneNumberConfirmed").IsRequired();
			builder.Property(t => t.TwoFactorEnabled).HasColumnName("TwoFactorEnabled").IsRequired();
			builder.Property(t => t.LockoutEnd).HasColumnName("LockoutEnd").IsRequired(false);
			builder.Property(t => t.LockoutEnabled).HasColumnName("LockoutEnabled").IsRequired();
			builder.Property(t => t.AccessFailedCount).HasColumnName("AccessFailedCount").IsRequired();
			
			#endregion

			#region Indexes
			builder.HasIndex(i => new {i.NormalizedUserName}).HasName("UserNameIndex").IsUnique(true);
			builder.HasIndex(i => new {i.NormalizedEmail}).HasName("EmailIndex").IsUnique(false);
			#endregion
			
			#region Relationships
			
			builder.HasMany<AspNetUserClaim>(s => s.AspNetUserClaim).WithOne(s => s.AspNetUser).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<AspNetUserLogin>(s => s.AspNetUserLogin).WithOne(s => s.AspNetUser).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<AspNetUserRole>(s => s.AspNetUserRole).WithOne(s => s.AspNetUser).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<AspNetUserToken>(s => s.AspNetUserToken).WithOne(s => s.AspNetUser).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	

			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.Id).HasColumnOrder(1);
			//TODO: builder.Property(t => t.UserName).HasColumnOrder(2);
			//TODO: builder.Property(t => t.NormalizedUserName).HasColumnOrder(3);
			//TODO: builder.Property(t => t.Email).HasColumnOrder(4);
			//TODO: builder.Property(t => t.NormalizedEmail).HasColumnOrder(5);
			//TODO: builder.Property(t => t.EmailConfirmed).HasColumnOrder(6);
			//TODO: builder.Property(t => t.PasswordHash).HasColumnOrder(7);
			//TODO: builder.Property(t => t.SecurityStamp).HasColumnOrder(8);
			//TODO: builder.Property(t => t.ConcurrencyStamp).HasColumnOrder(9);
			//TODO: builder.Property(t => t.PhoneNumber).HasColumnOrder(10);
			//TODO: builder.Property(t => t.PhoneNumberConfirmed).HasColumnOrder(11);
			//TODO: builder.Property(t => t.TwoFactorEnabled).HasColumnOrder(12);
			//TODO: builder.Property(t => t.LockoutEnd).HasColumnOrder(13);
			//TODO: builder.Property(t => t.LockoutEnabled).HasColumnOrder(14);
			//TODO: builder.Property(t => t.AccessFailedCount).HasColumnOrder(15);

			#endregion	
	    }
	}
}
