
// <copyright file="ProductProfileDto.g.cs" company="MIT">
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

namespace Banking.Models.Dto
{
	public partial class ProductProfileDto : IProductProfile 
	{
		#region CTOR
		
		public ProductProfileDto()
		{
			this.LoadingOutcome = new List <ILoadingOutcome>();
			this.PremiumProfile = new List <IPremiumProfile>();
			this.Product = new List <IProduct>();
			this.ProductPostponeStatusOutcome = new List <IProductPostponeStatusOutcome>();
			this.ProductStatusOutcome = new List <IProductStatusOutcome>();
			this.ProductSumAssuredOutcome = new List <IProductSumAssuredOutcome>();
			this.ReferenceProductOutcome = new List <IReferenceProductOutcome>();
		}
		
		public ProductProfileDto(IProductProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.Description = item.Description;
			this.LoadingOutcome = new List <ILoadingOutcome>();
			this.PremiumProfile = new List <IPremiumProfile>();
			this.Product = new List <IProduct>();
			this.ProductPostponeStatusOutcome = new List <IProductPostponeStatusOutcome>();
			this.ProductStatusOutcome = new List <IProductStatusOutcome>();
			this.ProductSumAssuredOutcome = new List <IProductSumAssuredOutcome>();
			this.ReferenceProductOutcome = new List <IReferenceProductOutcome>();

			if(deep)
			{
				if(item.LoadingOutcome != null)
				{
					foreach(var childItem in item.LoadingOutcome)
					{
						this.LoadingOutcome.Add(new LoadingOutcomeDto(childItem, deep));
					}
				}
				if(item.PremiumProfile != null)
				{
					foreach(var childItem in item.PremiumProfile)
					{
						this.PremiumProfile.Add(new PremiumProfileDto(childItem, deep));
					}
				}
				if(item.Product != null)
				{
					foreach(var childItem in item.Product)
					{
						this.Product.Add(new ProductDto(childItem, deep));
					}
				}
				if(item.ProductPostponeStatusOutcome != null)
				{
					foreach(var childItem in item.ProductPostponeStatusOutcome)
					{
						this.ProductPostponeStatusOutcome.Add(new ProductPostponeStatusOutcomeDto(childItem, deep));
					}
				}
				if(item.ProductStatusOutcome != null)
				{
					foreach(var childItem in item.ProductStatusOutcome)
					{
						this.ProductStatusOutcome.Add(new ProductStatusOutcomeDto(childItem, deep));
					}
				}
				if(item.ProductSumAssuredOutcome != null)
				{
					foreach(var childItem in item.ProductSumAssuredOutcome)
					{
						this.ProductSumAssuredOutcome.Add(new ProductSumAssuredOutcomeDto(childItem, deep));
					}
				}
				if(item.ReferenceProductOutcome != null)
				{
					foreach(var childItem in item.ReferenceProductOutcome)
					{
						this.ReferenceProductOutcome.Add(new ReferenceProductOutcomeDto(childItem, deep));
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
		
		public IList<ILoadingOutcome> LoadingOutcome { get; set; }
		public IList<IPremiumProfile> PremiumProfile { get; set; }
		public IList<IProduct> Product { get; set; }
		public IList<IProductPostponeStatusOutcome> ProductPostponeStatusOutcome { get; set; }
		public IList<IProductStatusOutcome> ProductStatusOutcome { get; set; }
		public IList<IProductSumAssuredOutcome> ProductSumAssuredOutcome { get; set; }
		public IList<IReferenceProductOutcome> ReferenceProductOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
