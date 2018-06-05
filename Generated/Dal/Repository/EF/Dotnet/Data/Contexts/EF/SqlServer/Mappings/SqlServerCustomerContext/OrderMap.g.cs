
// <copyright file="OrderMap.g.cs.g.cs" company="MIT">
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;


namespace Banking.Models.Customers.Mappings.EF.SqlServer
{
	public partial class OrderMap : EntityTypeConfiguration<Order>
	{	
		public OrderMap ()
		{
			ToTable("Order", "dbo");
			
			#region Primary Keys
			
			HasKey(t => t.OrderId);
			Property(t => t.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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

			#region Relationships
			
			HasOptional<Customer>(s => s.Customer).WithMany(s => s.Order).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			HasMany<OrderDetails>(s => s.OrderDetails).WithRequired(s => s.Order).HasForeignKey(s => s.OrderId).WillCascadeOnDelete(false);
			
			#endregion			
	
		}
	}
}
