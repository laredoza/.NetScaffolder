
// <copyright file="OrderMap.g.cs" company="Dot Net Scaffolder">
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EF.SqlServer
{
	public partial class OrderMap : EntityTypeConfiguration<Order>
	{	
		public OrderMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("Order", "dbo");
			
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
			#endregion

			#region Relationships
			
			HasMany<softwareprovider>(s => s.softwareprovider).WithRequired(s => s.somealies).HasForeignKey(s => s.ProductIdDDB).WillCascadeOnDelete(false);
			HasMany<OrderDetails>(s => s.OrderDetails).WithRequired(s => s.Order).HasForeignKey(s => s.OrderId).WillCascadeOnDelete(false);
			HasOptional<Customer>(s => s.Customer).WithMany(s => s.Order).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			
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
