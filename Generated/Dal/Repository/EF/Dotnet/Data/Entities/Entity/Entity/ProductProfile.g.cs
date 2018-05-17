
// <copyright file="ProductProfile.g.cs" company="MIT">
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
	public partial class ProductProfile : IProductProfile 
	{
		#region CTOR
		
		public ProductProfile()
		{
			this.LoadingOutcome = new List <LoadingOutcome>();
			this.PremiumProfile = new List <PremiumProfile>();
			this.Product = new List <Product>();
			this.ProductPostponeStatusOutcome = new List <ProductPostponeStatusOutcome>();
			this.ProductStatusOutcome = new List <ProductStatusOutcome>();
			this.ProductSumAssuredOutcome = new List <ProductSumAssuredOutcome>();
			this.ReferenceProductOutcome = new List <ReferenceProductOutcome>();
		}
		
		public ProductProfile(IProductProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.Description = item.Description;
			this.LoadingOutcome = new List <LoadingOutcome>();
			this.PremiumProfile = new List <PremiumProfile>();
			this.Product = new List <Product>();
			this.ProductPostponeStatusOutcome = new List <ProductPostponeStatusOutcome>();
			this.ProductStatusOutcome = new List <ProductStatusOutcome>();
			this.ProductSumAssuredOutcome = new List <ProductSumAssuredOutcome>();
			this.ReferenceProductOutcome = new List <ReferenceProductOutcome>();

			if(deep)
			{
				if(item.LoadingOutcome != null)
				{
					foreach(var childItem in item.LoadingOutcome)
					{
						this.LoadingOutcome.Add(new LoadingOutcome(childItem, deep));
					}
				}
				if(item.PremiumProfile != null)
				{
					foreach(var childItem in item.PremiumProfile)
					{
						this.PremiumProfile.Add(new PremiumProfile(childItem, deep));
					}
				}
				if(item.Product != null)
				{
					foreach(var childItem in item.Product)
					{
						this.Product.Add(new Product(childItem, deep));
					}
				}
				if(item.ProductPostponeStatusOutcome != null)
				{
					foreach(var childItem in item.ProductPostponeStatusOutcome)
					{
						this.ProductPostponeStatusOutcome.Add(new ProductPostponeStatusOutcome(childItem, deep));
					}
				}
				if(item.ProductStatusOutcome != null)
				{
					foreach(var childItem in item.ProductStatusOutcome)
					{
						this.ProductStatusOutcome.Add(new ProductStatusOutcome(childItem, deep));
					}
				}
				if(item.ProductSumAssuredOutcome != null)
				{
					foreach(var childItem in item.ProductSumAssuredOutcome)
					{
						this.ProductSumAssuredOutcome.Add(new ProductSumAssuredOutcome(childItem, deep));
					}
				}
				if(item.ReferenceProductOutcome != null)
				{
					foreach(var childItem in item.ReferenceProductOutcome)
					{
						this.ReferenceProductOutcome.Add(new ReferenceProductOutcome(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<LoadingOutcome> LoadingOutcome { get; set; }

        IList<ILoadingOutcome> IProductProfile.LoadingOutcome 
		{ 
			get
			{
				return (IList<ILoadingOutcome>)this.LoadingOutcome;
			}
			set
			{
				this.LoadingOutcome = (IList<LoadingOutcome>)value;
			}			
		}
        
        public virtual IList<PremiumProfile> PremiumProfile { get; set; }

        IList<IPremiumProfile> IProductProfile.PremiumProfile 
		{ 
			get
			{
				return (IList<IPremiumProfile>)this.PremiumProfile;
			}
			set
			{
				this.PremiumProfile = (IList<PremiumProfile>)value;
			}			
		}
        
        public virtual IList<Product> Product { get; set; }

        IList<IProduct> IProductProfile.Product 
		{ 
			get
			{
				return (IList<IProduct>)this.Product;
			}
			set
			{
				this.Product = (IList<Product>)value;
			}			
		}
        
        public virtual IList<ProductPostponeStatusOutcome> ProductPostponeStatusOutcome { get; set; }

        IList<IProductPostponeStatusOutcome> IProductProfile.ProductPostponeStatusOutcome 
		{ 
			get
			{
				return (IList<IProductPostponeStatusOutcome>)this.ProductPostponeStatusOutcome;
			}
			set
			{
				this.ProductPostponeStatusOutcome = (IList<ProductPostponeStatusOutcome>)value;
			}			
		}
        
        public virtual IList<ProductStatusOutcome> ProductStatusOutcome { get; set; }

        IList<IProductStatusOutcome> IProductProfile.ProductStatusOutcome 
		{ 
			get
			{
				return (IList<IProductStatusOutcome>)this.ProductStatusOutcome;
			}
			set
			{
				this.ProductStatusOutcome = (IList<ProductStatusOutcome>)value;
			}			
		}
        
        public virtual IList<ProductSumAssuredOutcome> ProductSumAssuredOutcome { get; set; }

        IList<IProductSumAssuredOutcome> IProductProfile.ProductSumAssuredOutcome 
		{ 
			get
			{
				return (IList<IProductSumAssuredOutcome>)this.ProductSumAssuredOutcome;
			}
			set
			{
				this.ProductSumAssuredOutcome = (IList<ProductSumAssuredOutcome>)value;
			}			
		}
        
        public virtual IList<ReferenceProductOutcome> ReferenceProductOutcome { get; set; }

        IList<IReferenceProductOutcome> IProductProfile.ReferenceProductOutcome 
		{ 
			get
			{
				return (IList<IReferenceProductOutcome>)this.ReferenceProductOutcome;
			}
			set
			{
				this.ReferenceProductOutcome = (IList<ReferenceProductOutcome>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
