
// <copyright file="ProductReference.g.cs" company="MIT">
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
	public partial class ProductReference : IProductReference 
	{
		#region CTOR
		
		public ProductReference()
		{
			this.ProductReferenceOutcome = new List <ProductReferenceOutcome>();
		}
		
		public ProductReference(IProductReference item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.SetupTableDataId = item.SetupTableDataId;
			this.ProductId = item.ProductId;
			this.Source = item.Source;
			this.ProductReferenceOutcome = new List <ProductReferenceOutcome>();

			if(deep)
			{
				if(item.ProductReferenceOutcome != null)
				{
					foreach(var childItem in item.ProductReferenceOutcome)
					{
						this.ProductReferenceOutcome.Add(new ProductReferenceOutcome(childItem, deep));
					}
				}
				this.MonitoredProductReference = new MonitoredProductReference(item.MonitoredProductReference, deep);
				this.StandardProductReference = new StandardProductReference(item.StandardProductReference, deep);
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
		public Nullable<int> SetupTableDataId { get; set; }
		public Nullable<int> ProductId { get; set; }
		public bool Source { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<ProductReferenceOutcome> ProductReferenceOutcome { get; set; }

        IList<IProductReferenceOutcome> IProductReference.ProductReferenceOutcome 
		{ 
			get
			{
				return (IList<IProductReferenceOutcome>)this.ProductReferenceOutcome;
			}
			set
			{
				this.ProductReferenceOutcome = (IList<ProductReferenceOutcome>)value;
			}			
		}
        
        public virtual MonitoredProductReference MonitoredProductReference { get; set; }

		IMonitoredProductReference IProductReference.MonitoredProductReference 
		{ 
			get
			{
				return this.MonitoredProductReference;
			}
			set
			{
				this.MonitoredProductReference = (MonitoredProductReference)value;
			}
		}
        
        public virtual StandardProductReference StandardProductReference { get; set; }

		IStandardProductReference IProductReference.StandardProductReference 
		{ 
			get
			{
				return this.StandardProductReference;
			}
			set
			{
				this.StandardProductReference = (StandardProductReference)value;
			}
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Product Product { get; set; }

		IProduct IProductReference.Product 
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

		ISetupTableData IProductReference.SetupTableData 
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
