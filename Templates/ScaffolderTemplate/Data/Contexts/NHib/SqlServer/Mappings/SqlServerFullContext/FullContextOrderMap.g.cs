﻿
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
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;
using FluentNHibernate.Mapping;


namespace DotNetScaffolder.Domain.Data.Contexts.NHib.SqlServer.Mappings.SqlServerFullContext
{
	public partial class FullContextOrderMap : ClassMap<Order>
	{	
		public FullContextOrderMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("Order");
			Schema("dbo");
			
			#region Primary Keys
			
			Id(t => t.OrderId).GeneratedBy.Assigned()
			.UniqueKey("UQ__Order__C3905BCE3C614174")
			.Not.Nullable();

			#endregion

			#region Properties
			
			Map(t => t.CustomerId).Column("CustomerId")
			.Index("IX_CustomerId")
			.Nullable();
			Map(t => t.OrderDate).Column("OrderDate")
			.Nullable();
			Map(t => t.DeliveryDate).Column("DeliveryDate")
			.Nullable();
			Map(t => t.ShippingName).Column("ShippingName")
			.Length(50)
			.Nullable();
			Map(t => t.ShippingAddress).Column("ShippingAddress")
			.Length(50)
			.Nullable();
			Map(t => t.ShippingCity).Column("ShippingCity")
			.Length(50)
			.Nullable();
			Map(t => t.ShippingZip).Column("ShippingZip")
			.Length(50)
			.Nullable();
			
			#endregion
			
			#region Relationships
			
			References(o => o.Customer).Column("CustomerId").Unique().Not.Insert().Not.Update();
			HasMany(s => s.OrderDetails).KeyColumn("OrderId");
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
