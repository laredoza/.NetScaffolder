
// <copyright file="OrderDetailsMap.g.cs" company="MIT">
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
using Banking.Models.Entity;
using FluentNHibernate.Mapping;

namespace Banking.Models.Customers.Mappings.NHibernate.MySql
{
	public partial class OrderDetailsMap : ClassMap<OrderDetails>
	{	
		public OrderDetailsMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("OrderDetails");
			
			#region Primary Keys
			
			Id(t => t.OrderDetailsId).GeneratedBy.Increment().Unique()
			.Not.Nullable();
			Map(t => t.OrderDetailsId).Column("OrderDetailsId").ReadOnly().Generated.Insert();

			#endregion

			#region Properties
			
			Map(t => t.OrderId).Column("OrderId")
			.Index("IX_OrderId")
			.Not.Nullable();
			Map(t => t.ProductId).Column("ProductId")
			.Index("IX_ProductId")
			.Not.Nullable();
			Map(t => t.UnitPrice).Column("UnitPrice")
			.Precision(19).Scale(4)
			.Nullable();
			Map(t => t.Amount).Column("Amount")
			.Nullable();
			Map(t => t.Discount).Column("Discount")
			.Nullable();
			
			#endregion
			
			#region Relationships
			
			References(o => o.Order).Column("OrderId").Unique().Not.Insert().Not.Update();
			References(o => o.Product).Column("ProductId").Unique().Not.Insert().Not.Update();
			
			#endregion			
	
		}
	}
}
