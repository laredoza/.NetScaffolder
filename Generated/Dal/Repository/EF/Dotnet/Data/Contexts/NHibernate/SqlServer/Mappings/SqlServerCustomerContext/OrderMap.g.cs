
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
using Banking.Models.Entity;
using FluentNHibernate.Mapping;

namespace Banking.Models.Customers.Mappings.NHibernate.SqlServer
{
	public partial class OrderMap : ClassMap<Order>
	{	
		public OrderMap ()
		{
			Table("Order");
			Schema("dbo");
			
			#region Primary Keys
			
			Id(t => t.OrderId).GeneratedBy.Increment();

			#endregion

			#region Constraints
			
			Map(t => t.OrderId).ReadOnly().Generated.Insert()
			.Not.Nullable();
			Map(t => t.CustomerId)
			.Nullable();
			Map(t => t.OrderDate)
			.Nullable();
			Map(t => t.DeliveryDate)
			.Nullable();
			Map(t => t.ShippingName)
			.Length(50)
			.Nullable();
			Map(t => t.ShippingAddress)
			.Length(50)
			.Nullable();
			Map(t => t.ShippingCity)
			.Length(50)
			.Nullable();
			Map(t => t.ShippingZip)
			.Length(50)
			.Nullable();
			
			#endregion

			#region Relationships
			
			References(o => o.Customer).Column("CustomerId").Unique().Not.Insert().Not.Update();
			HasMany(s => s.OrderDetails).KeyColumn("OrderId");
			
			#endregion			
	
		}
	}
}
