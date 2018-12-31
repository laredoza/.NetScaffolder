
// <copyright file="OrderMap.g.cs" company="MIT">
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
using DotNetScaffolder.Domain.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Context.Mappings.EFCore.MySql
{
	public partial class FullContextOrderMap : IEntityTypeConfiguration<Order>
	{	
	    public virtual void Configure(EntityTypeBuilder<Order> builder)
	    {
			builder.ToTable("`Order`");
			
			#region Primary keys
			
			builder.HasKey(t => t.OrderId);
			builder.Property(t => t.OrderId).HasColumnName("OrderId").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.OrderId).HasColumnName("OrderId").IsRequired();
			builder.Property(t => t.CustomerId).HasColumnName("CustomerId").IsRequired(false);
			builder.Property(t => t.OrderDate).HasColumnName("OrderDate").IsRequired(false);
			builder.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate").IsRequired(false);
			builder.Property(t => t.ShippingName).HasMaxLength(50);
			builder.Property(t => t.ShippingName).HasColumnName("ShippingName").IsRequired(false);
			builder.Property(t => t.ShippingAddress).HasMaxLength(50);
			builder.Property(t => t.ShippingAddress).HasColumnName("ShippingAddress").IsRequired(false);
			builder.Property(t => t.ShippingCity).HasMaxLength(50);
			builder.Property(t => t.ShippingCity).HasColumnName("ShippingCity").IsRequired(false);
			builder.Property(t => t.ShippingZip).HasMaxLength(50);
			builder.Property(t => t.ShippingZip).HasColumnName("ShippingZip").IsRequired(false);
			
			#endregion

			#region Indexes
			builder.HasIndex(i => new {i.OrderId}).HasName("UQ__Order__C3905BCE3C614174").IsUnique(true);
			builder.HasIndex(i => new {i.CustomerId}).HasName("IX_CustomerId").IsUnique(false);
			#endregion
			
			#region Relationships
			
			builder.HasOne<Customer>(s => s.Customer).WithMany(s => s.Order).HasForeignKey(s => s.CustomerId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<OrderDetails>(s => s.OrderDetails).WithOne(s => s.Order).HasForeignKey(s => s.OrderId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	

			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.OrderId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.CustomerId).HasColumnOrder(2);
			//TODO: builder.Property(t => t.OrderDate).HasColumnOrder(3);
			//TODO: builder.Property(t => t.DeliveryDate).HasColumnOrder(4);
			//TODO: builder.Property(t => t.ShippingName).HasColumnOrder(5);
			//TODO: builder.Property(t => t.ShippingAddress).HasColumnOrder(6);
			//TODO: builder.Property(t => t.ShippingCity).HasColumnOrder(7);
			//TODO: builder.Property(t => t.ShippingZip).HasColumnOrder(8);

			#endregion	
	    }
	}
}
