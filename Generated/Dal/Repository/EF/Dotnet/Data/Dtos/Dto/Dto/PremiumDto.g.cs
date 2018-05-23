﻿
// <copyright file="PremiumDto.g.cs" company="MIT">
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
	public partial class PremiumDto : IPremium 
	{
		#region CTOR
		
		public PremiumDto()
		{
		}
		
		public PremiumDto(IPremium item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.BasePremium = item.BasePremium;
			this.FinalPremium = item.FinalPremium;
			this.PercentageLoading = item.PercentageLoading;
			this.PremiumProfileId = item.PremiumProfileId;
			this.ProductId = item.ProductId;
			this.UserPremium = item.UserPremium;
			this.TypeOption = item.TypeOption;
			this.UnitLoading = item.UnitLoading;

			if(deep)
			{
                if(item.Product != null)
                {
				    this.Product = new ProductDto(item.Product, deep);
                }
                if(item.PremiumProfile != null)
                {
				    this.PremiumProfile = new PremiumProfileDto(item.PremiumProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<decimal> BasePremium { get; set; }
		public Nullable<decimal> FinalPremium { get; set; }
		public Nullable<decimal> PercentageLoading { get; set; }
		public Nullable<int> PremiumProfileId { get; set; }
		public Nullable<int> ProductId { get; set; }
		public Nullable<decimal> UserPremium { get; set; }
		public int TypeOption { get; set; }
		public Nullable<decimal> UnitLoading { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IProduct Product { get; set; }
		public IPremiumProfile PremiumProfile { get; set; }
		
		#endregion
	}
}