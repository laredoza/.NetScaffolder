// <copyright file="Product.g.cs" company="MIT">
//  Copyright (c) 2020 MIT
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
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
namespace DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity
{
	public partial class Product : IProduct
	{
		#region CTOR

		public Product()
		{
			this.OrderDetails = new List<OrderDetails>(); 
		}
		
		public Product(IProduct item, bool deep = false)
		{
			if(item == null) return;

			this.ProductId = item.ProductId;
			this.ProductDescription = item.ProductDescription;
			this.UnitPrice = item.UnitPrice;
			this.AmountInStock = item.AmountInStock;

			this.OrderDetails = new List<OrderDetails>(); 


			if(deep)
			{
				if(item.OrderDetails != null)
				{
					foreach(var childItem in item.OrderDetails)
					{
						this.OrderDetails.Add(new OrderDetails(childItem, deep));
					}
				}

				this.OrderDetails = new OrderDetails(item.OrderDetails, deep);

			}
		}
		
		#endregion
		#region Fields
		
		public virtual int ProductId { get; set; }
		public virtual string ProductDescription { get; set; }
		public virtual decimal? UnitPrice { get; set; }
		public virtual short? AmountInStock { get; set; }

		#endregion

        #region Child Relationships

        public virtual IListOrderDetails OrderDetails { get; set; }
        IListIOrderDetails IProduct.OrderDetails
		{ 
			get
			{
				return this.OrderDetails == null ? null : this.OrderDetails as IList<IOrderDetails>;
			}
			set
			{
				if(value != this.OrderDetails)
				{
					if(value != null)
					{
						this.OrderDetails = (IList<OrderDetails>)value;
					}
					else
					{
						this.OrderDetails = null;
					}
				}
			}			
		}

		#endregion
    }
}
