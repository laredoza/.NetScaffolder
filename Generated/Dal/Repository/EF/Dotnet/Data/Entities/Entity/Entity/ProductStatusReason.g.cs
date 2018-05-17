
// <copyright file="ProductStatusReason.g.cs" company="MIT">
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

using System;
using System.Collections.Generic;
using Banking.Models.Interfaces;

namespace Banking.Models.Entity
{
	public partial class ProductStatusReason : IProductStatusReason 
	{
		#region CTOR
		
		public ProductStatusReason()
		{
			this.Product1 = new List <Product>();
		}
		
		public ProductStatusReason(IProductStatusReason item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.DateFrom = item.DateFrom;
			this.DateTo = item.DateTo;
			this.ProductId = item.ProductId;
			this.ReasonId = item.ReasonId;
			this.Product1 = new List <Product>();

			if(deep)
			{
				if(item.Product1 != null)
				{
					foreach(var childItem in item.Product1)
					{
						this.Product1.Add(new Product(childItem, deep));
					}
				}
				if(item.Product != null)
                {
                    this.Product = new Product(item.Product, deep);
                }
				if(item.SetupTableData != null)
                {
                    this.SetupTableData = new SetupTableData(item.SetupTableData, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<DateTime> DateFrom { get; set; }
		public Nullable<DateTime> DateTo { get; set; }
		public Nullable<int> ProductId { get; set; }
		public Nullable<int> ReasonId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<Product> Product1 { get; set; }

        IList<IProduct> IProductStatusReason.Product1 
		{ 
			get
			{
				return (IList<IProduct>)this.Product1;
			}
			set
			{
				this.Product1 = (IList<Product>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Product Product { get; set; }

		IProduct IProductStatusReason.Product 
		{ 
			get
			{
				return this.Product;
			}
			set
			{
				this.Product = (Product)value;
			}
		}

        public virtual SetupTableData SetupTableData { get; set; }

		ISetupTableData IProductStatusReason.SetupTableData 
		{ 
			get
			{
				return this.SetupTableData;
			}
			set
			{
				this.SetupTableData = (SetupTableData)value;
			}
		}
		
		#endregion
	}
}
