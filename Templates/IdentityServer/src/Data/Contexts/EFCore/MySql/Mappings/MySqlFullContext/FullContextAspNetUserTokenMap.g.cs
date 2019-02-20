﻿
// <copyright file="AspNetUserTokenMap.g.cs" company="MIT">
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

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.MySql.Mappings.MySqlFullContext
{
	public partial class FullContextAspNetUserTokenMap : IEntityTypeConfiguration<AspNetUserToken>
	{	
	    public virtual void Configure(EntityTypeBuilder<AspNetUserToken> builder)
	    {
			builder.ToTable("AspNetUserToken");
			
			#region Primary keys
			
			builder.HasKey(t => new {t.UserId, t.LoginProvider, t.Name});
			builder.Property(t => t.UserId).HasColumnName("UserId").ValueGeneratedNever();
			builder.Property(t => t.LoginProvider).HasColumnName("LoginProvider").ValueGeneratedNever();
			builder.Property(t => t.Name).HasColumnName("Name").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.UserId).HasColumnName("UserId").IsRequired();
			builder.Property(t => t.LoginProvider).HasMaxLength(128);
			builder.Property(t => t.LoginProvider).HasColumnName("LoginProvider").IsRequired();
			builder.Property(t => t.Name).HasMaxLength(128);
			builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
			builder.Property(t => t.Value).HasColumnName("Value").IsRequired(false);
			
			#endregion

			#region Indexes
			#endregion
			
			#region Relationships
			
			builder.HasOne<AspNetUser>(s => s.AspNetUser).WithMany(s => s.AspNetUserToken).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	

			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.UserId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.LoginProvider).HasColumnOrder(2);
			//TODO: builder.Property(t => t.Name).HasColumnOrder(3);
			//TODO: builder.Property(t => t.Value).HasColumnOrder(4);

			#endregion	
	    }
	}
}
