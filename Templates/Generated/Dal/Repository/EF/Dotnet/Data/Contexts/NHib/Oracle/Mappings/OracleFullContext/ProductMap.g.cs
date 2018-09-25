﻿
// <copyright file="ProductMap.g.cs" company="MIT">
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

namespace Banking.Models.Context.Mappings.NHib.Oracle
{
	public partial class ProductMap : ClassMap<Product>
	{	
		public ProductMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("Product");
			
			#region Primary Keys
			
			Id(t => t.ProductId).GeneratedBy.Increment().Unique()
			.Not.Nullable();
			Map(t => t.ProductId).Column("ProductId").ReadOnly().Generated.Insert();

			#endregion

			#region Properties
			
			Map(t => t.ProductDescription).Column("ProductDescription")
			.Length(100)
			.Nullable();
			Map(t => t.UnitPrice).Column("UnitPrice")
			.Precision(19).Scale(4)
			.Nullable();
			Map(t => t.UnitAmount).Column("UnitAmount")
			.Length(50)
			.Nullable();
			Map(t => t.Publisher).Column("Publisher")
			.Length(200)
			.Nullable();
			Map(t => t.AmountInStock).Column("AmountInStock")
			.Nullable();
			
			#endregion
			
			#region Relationships
			
			HasOne(s => s.Book).PropertyRef(o => o.Product);
			HasMany(s => s.OrderDetails).KeyColumn("ProductId");
			HasOne(s => s.Software).PropertyRef(o => o.Product);
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}