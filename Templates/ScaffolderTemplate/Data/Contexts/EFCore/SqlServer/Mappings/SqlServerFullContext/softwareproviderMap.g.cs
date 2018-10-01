
// <copyright file="softwareproviderMap.g.cs" company="Dot Net Scaffolder">
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EFCore.SqlServer
{
	public partial class softwareproviderMap : IEntityTypeConfiguration<softwareprovider>
	{	
	    public virtual void Configure(EntityTypeBuilder<softwareprovider> builder)
	    {
			builder.ToTable("[softwareprovider]", "[dbo]");
			
			#region Primary keys
			
			builder.HasKey(t => t.id);
			builder.Property(t => t.id).HasColumnName("id").ValueGeneratedOnAdd();

			#endregion

			#region Constraints
			
			builder.Property(t => t.id).HasColumnName("id").IsRequired();
			builder.Property(t => t.ProductIdDDB).HasColumnName("ProductIdDDB").IsRequired();
			builder.Property(t => t.name).HasMaxLength(50);
			builder.Property(t => t.name).HasColumnName("name").IsRequired(false);
			builder.Property(t => t.x1).HasMaxLength(10);
			builder.Property(t => t.x1).HasColumnName("x1").IsRequired(false);
			
			#endregion

			#region Indexes
			#endregion
			
			#region Relationships
			
			builder.HasOne<Order>(s => s.somealies).WithMany(s => s.softwareprovider).HasForeignKey(s => s.ProductIdDDB).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.id).HasColumnOrder(1);
			//TODO: builder.Property(t => t.ProductIdDDB).HasColumnOrder(2);
			//TODO: builder.Property(t => t.name).HasColumnOrder(3);
			//TODO: builder.Property(t => t.x1).HasColumnOrder(4);

			#endregion	
	    }
	}
}
