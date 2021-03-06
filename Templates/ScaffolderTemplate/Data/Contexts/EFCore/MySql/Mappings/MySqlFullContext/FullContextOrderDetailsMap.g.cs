﻿
// <copyright file="OrderDetailsMap.g.cs" company="MIT">
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
	public partial class FullContextOrderDetailsMap : IEntityTypeConfiguration<OrderDetails>
	{	
	    public virtual void Configure(EntityTypeBuilder<OrderDetails> builder)
	    {
			builder.ToTable("OrderDetails");
			
			#region Primary keys
			
			builder.HasKey(t => t.OrderDetailsId);
			builder.Property(t => t.OrderDetailsId).HasColumnName("OrderDetailsId").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.OrderDetailsId).HasColumnName("OrderDetailsId").IsRequired();
			builder.Property(t => t.OrderId).HasColumnName("OrderId").IsRequired();
			builder.Property(t => t.ProductId).HasColumnName("ProductId").IsRequired();
			builder.Property(t => t.UnitPrice).HasColumnName("UnitPrice").IsRequired(false);
			builder.Property(t => t.UnitPrice).HasColumnType("decimal(19, 4)");
			builder.Property(t => t.Amount).HasColumnName("Amount").IsRequired(false);
			builder.Property(t => t.Discount).HasColumnName("Discount").IsRequired(false);
			
			#endregion

			#region Indexes
			builder.HasIndex(i => new {i.OrderDetailsId}).HasName("UQ__OrderDet__9DD74DBC8AA17DA0").IsUnique(true);
			builder.HasIndex(i => new {i.OrderId}).HasName("IX_OrderId1").IsUnique(false);
			builder.HasIndex(i => new {i.ProductId}).HasName("IX_ProductId2").IsUnique(false);
			#endregion
			
			#region Relationships
			
			builder.HasOne<Order>(s => s.Order).WithMany(s => s.OrderDetails).HasForeignKey(s => s.OrderId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne<Product>(s => s.Product).WithMany(s => s.OrderDetails).HasForeignKey(s => s.ProductId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	

			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.OrderDetailsId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.OrderId).HasColumnOrder(2);
			//TODO: builder.Property(t => t.ProductId).HasColumnOrder(3);
			//TODO: builder.Property(t => t.UnitPrice).HasColumnOrder(4);
			//TODO: builder.Property(t => t.Amount).HasColumnOrder(5);
			//TODO: builder.Property(t => t.Discount).HasColumnOrder(6);

			#endregion	
	    }
	}
}
