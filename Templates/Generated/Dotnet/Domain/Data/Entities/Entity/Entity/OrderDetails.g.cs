﻿
// <copyright file="OrderDetails.g.cs" company="MIT">
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

using System;
using System.Collections.Generic;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity
{
	public partial class OrderDetails : IOrderDetails 
	{
		#region CTOR
		
		public OrderDetails()
		{
		}
		
		public OrderDetails(IOrderDetails item, bool deep = false)
		{
			if(item == null) return;
			
			this.OrderDetailsId = item.OrderDetailsId;
			this.OrderId = item.OrderId;
			this.ProductId = item.ProductId;
			this.UnitPrice = item.UnitPrice;
			this.Amount = item.Amount;
			this.Discount = item.Discount;

			if(deep)
			{
				if(item.Order != null)
                {
                    this.Order = new Order(item.Order, deep);
                }
				if(item.Product != null)
                {
                    this.Product = new Product(item.Product, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int OrderDetailsId { get; set; }
		public virtual int OrderId { get; set; }
		public virtual int ProductId { get; set; }
		public virtual Nullable<decimal> UnitPrice { get; set; }
		public virtual Nullable<short> Amount { get; set; }
		public virtual Nullable<float> Discount { get; set; }

		#endregion

		#region Parent Relationships

        public virtual Order Order { get; set; }
		IOrder IOrderDetails.Order 
		{ 
			get
			{
				return this.Order;
			}
			set
			{
				if(value != this.Order)
				{
					if(value != null)
					{
						this.Order = (Order)value;
					}
					else
					{
						this.Order = null;
					}
				}
			}
		}

        public virtual Product Product { get; set; }
		IProduct IOrderDetails.Product 
		{ 
			get
			{
				return this.Product;
			}
			set
			{
				if(value != this.Product)
				{
					if(value != null)
					{
						this.Product = (Product)value;
					}
					else
					{
						this.Product = null;
					}
				}
			}
		}
		
		#endregion
	}
}
