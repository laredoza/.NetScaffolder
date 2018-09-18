﻿
// <copyright file="CountryMap.g.cs" company="MIT">
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
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EFCore.MySql
{
	public partial class CountryMap : IEntityTypeConfiguration<Country>
	{	
	    public virtual void Configure(EntityTypeBuilder<Country> builder)
	    {
			builder.ToTable("`Country`");
			
			#region Primary keys
			
			builder.HasKey(t => t.CountryId);
			builder.Property(t => t.CountryId).HasColumnName("CountryId").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.CountryId).HasColumnName("CountryId").IsRequired();
			builder.Property(t => t.CountryName).HasMaxLength(100);
			builder.Property(t => t.CountryName).HasColumnName("CountryName").IsRequired(false);
			
			#endregion

			#region Indexes
			builder.HasIndex(i => new {i.CountryId}).HasName("UQ__Country__10D1609E8CC26505").IsUnique(true);
			#endregion
			
			#region Relationships
			
			builder.HasMany<Customer>(s => s.Customer).WithOne(s => s.Country).HasForeignKey(s => s.CountryId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.CountryId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.CountryName).HasColumnOrder(2);

			#endregion	
	    }
	}
}
