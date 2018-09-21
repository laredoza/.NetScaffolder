
// <copyright file="ProductMap.g.cs" company="Dot Net Scaffolder">
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
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EFCore.MySql
{
	public partial class ProductMap : IEntityTypeConfiguration<Product>
	{	
	    public virtual void Configure(EntityTypeBuilder<Product> builder)
	    {
			builder.ToTable("`Product`");
			
			#region Primary keys
			
			builder.HasKey(t => t.ProductId);
			builder.Property(t => t.ProductId).HasColumnName("ProductId").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.ProductId).HasColumnName("ProductId").IsRequired();
			builder.Property(t => t.ProductDescription).HasMaxLength(100);
			builder.Property(t => t.ProductDescription).HasColumnName("ProductDescription").IsRequired(false);
			builder.Property(t => t.UnitPrice).HasColumnName("UnitPrice").IsRequired(false);
			builder.Property(t => t.UnitPrice).HasColumnType("decimal(19, 4)");
			builder.Property(t => t.UnitAmount).HasMaxLength(50);
			builder.Property(t => t.UnitAmount).HasColumnName("UnitAmount").IsRequired(false);
			builder.Property(t => t.Publisher).HasMaxLength(200);
			builder.Property(t => t.Publisher).HasColumnName("Publisher").IsRequired(false);
			builder.Property(t => t.AmountInStock).HasColumnName("AmountInStock").IsRequired(false);
			
			#endregion

			#region Indexes
			#endregion
			
			#region Relationships
			
			builder.HasMany<OrderDetails>(s => s.OrderDetails).WithOne(s => s.Product).HasForeignKey(s => s.ProductId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.ProductId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.ProductDescription).HasColumnOrder(2);
			//TODO: builder.Property(t => t.UnitPrice).HasColumnOrder(3);
			//TODO: builder.Property(t => t.UnitAmount).HasColumnOrder(4);
			//TODO: builder.Property(t => t.Publisher).HasColumnOrder(5);
			//TODO: builder.Property(t => t.AmountInStock).HasColumnOrder(6);

			#endregion	
	    }
	}
}
