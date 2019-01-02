
// <copyright file="OrderMap.g.cs" company="MIT">
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
	public partial class FullContextOrderMap : EntityTypeConfiguration<Order>
	{	
		public FullContextOrderMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("Order");
			
			#region Primary Keys
			
			HasKey(t => t.OrderId);
			Property(t => t.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.OrderId).IsRequired();
			Property(t => t.CustomerId).IsOptional();
			Property(t => t.OrderDate).IsOptional();
			Property(t => t.DeliveryDate).IsOptional();
			Property(t => t.ShippingName).HasMaxLength(50);
			Property(t => t.ShippingName).IsOptional();
			Property(t => t.ShippingAddress).HasMaxLength(50);
			Property(t => t.ShippingAddress).IsOptional();
			Property(t => t.ShippingCity).HasMaxLength(50);
			Property(t => t.ShippingCity).IsOptional();
			Property(t => t.ShippingZip).HasMaxLength(50);
			Property(t => t.ShippingZip).IsOptional();
			
			#endregion
			
			#region Indexes
			Property(t => t.OrderId).HasColumnAnnotation("UQ__Order__C3905BCE3C614174", new IndexAnnotation(new [] { new IndexAttribute("UQ__Order__C3905BCE3C614174"){ IsClustered = false, IsUnique = true, Order = 0}}));
			Property(t => t.CustomerId).HasColumnAnnotation("IX_CustomerId", new IndexAnnotation(new [] { new IndexAttribute("IX_CustomerId"){ IsClustered = false, IsUnique = false, Order = 0}}));
			#endregion

			#region Relationships
			
			HasOptional<Customer>(s => s.Customer).WithMany(s => s.Order).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			HasMany<OrderDetails>(s => s.OrderDetails).WithRequired(s => s.Order).HasForeignKey(s => s.OrderId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.OrderId).HasColumnOrder(1);
			Property(t => t.CustomerId).HasColumnOrder(2);
			Property(t => t.OrderDate).HasColumnOrder(3);
			Property(t => t.DeliveryDate).HasColumnOrder(4);
			Property(t => t.ShippingName).HasColumnOrder(5);
			Property(t => t.ShippingAddress).HasColumnOrder(6);
			Property(t => t.ShippingCity).HasColumnOrder(7);
			Property(t => t.ShippingZip).HasColumnOrder(8);

			#endregion
	
		}
	}
}
