
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using Oracle.ManagedDataAccess.Client;
using Oracle.Config;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Oracle.Mappings.OracleFullContext
{
	public partial class FullContextOrderDetailsMap : EntityTypeConfiguration<OrderDetails>
	{	
		public FullContextOrderDetailsMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("OrderDetails", "DBO");
			
			#region Primary Keys
			
			HasKey(t => t.OrderDetailsId);
			Property(t => t.OrderDetailsId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.OrderDetailsId).IsRequired();
			Property(t => t.OrderId).IsRequired();
			Property(t => t.ProductId).IsRequired();
			Property(t => t.UnitPrice).IsOptional();
			Property(t => t.UnitPrice).HasPrecision(19, 4);
			Property(t => t.Amount).IsOptional();
			Property(t => t.Discount).IsOptional();
			
			#endregion
			
			#region Indexes
			Property(t => t.OrderDetailsId).HasColumnAnnotation("UQ__OrderDet__9DD74DBC8AA17DA0", new IndexAnnotation(new [] { new IndexAttribute("UQ__OrderDet__9DD74DBC8AA17DA0"){ IsClustered = false, IsUnique = true, Order = 0}}));
			Property(t => t.OrderId).HasColumnAnnotation("IX_OrderId1", new IndexAnnotation(new [] { new IndexAttribute("IX_OrderId1"){ IsClustered = false, IsUnique = false, Order = 0}}));
			Property(t => t.ProductId).HasColumnAnnotation("IX_ProductId2", new IndexAnnotation(new [] { new IndexAttribute("IX_ProductId2"){ IsClustered = false, IsUnique = false, Order = 0}}));
			#endregion

			#region Relationships
			
			HasRequired<Order>(s => s.Order).WithMany(s => s.OrderDetails).HasForeignKey(s => s.OrderId).WillCascadeOnDelete(false);
			HasRequired<Product>(s => s.Product).WithMany(s => s.OrderDetails).HasForeignKey(s => s.ProductId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.OrderDetailsId).HasColumnOrder(1);
			Property(t => t.OrderId).HasColumnOrder(2);
			Property(t => t.ProductId).HasColumnOrder(3);
			Property(t => t.UnitPrice).HasColumnOrder(4);
			Property(t => t.Amount).HasColumnOrder(5);
			Property(t => t.Discount).HasColumnOrder(6);

			#endregion
	
		}
	}
}
