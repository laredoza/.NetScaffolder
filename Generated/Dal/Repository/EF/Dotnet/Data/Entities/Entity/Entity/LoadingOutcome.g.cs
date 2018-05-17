
// <copyright file="LoadingOutcome.g.cs" company="MIT">
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
	public partial class LoadingOutcome : ILoadingOutcome 
	{
		#region CTOR
		
		public LoadingOutcome()
		{
		}
		
		public LoadingOutcome(ILoadingOutcome item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.MathOption = item.MathOption;
			this.PercentageValue = item.PercentageValue;
			this.ProductProfileId = item.ProductProfileId;
			this.PremiumProfileId = item.PremiumProfileId;
			this.TypeOption = item.TypeOption;
			this.UnitValue = item.UnitValue;
			this.PeriodOption = item.PeriodOption;
			this.MonthFrom = item.MonthFrom;
			this.YearFrom = item.YearFrom;

			if(deep)
			{
				if(item.Provider != null)
                {
                    this.Provider = new Provider(item.Provider, deep);
                }
				if(item.ProductProfile != null)
                {
                    this.ProductProfile = new ProductProfile(item.ProductProfile, deep);
                }
				if(item.PremiumProfile != null)
                {
                    this.PremiumProfile = new PremiumProfile(item.PremiumProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<int> MathOption { get; set; }
		public Nullable<decimal> PercentageValue { get; set; }
		public Nullable<int> ProductProfileId { get; set; }
		public Nullable<int> PremiumProfileId { get; set; }
		public int TypeOption { get; set; }
		public Nullable<decimal> UnitValue { get; set; }
		public Nullable<int> PeriodOption { get; set; }
		public Nullable<int> MonthFrom { get; set; }
		public Nullable<int> YearFrom { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual Provider Provider { get; set; }

		IProvider ILoadingOutcome.Provider 
		{ 
			get
			{
				return this.Provider;
			}
			set
			{
				this.Provider = (Provider)value;
			}
		}

        public virtual ProductProfile ProductProfile { get; set; }

		IProductProfile ILoadingOutcome.ProductProfile 
		{ 
			get
			{
				return this.ProductProfile;
			}
			set
			{
				this.ProductProfile = (ProductProfile)value;
			}
		}

        public virtual PremiumProfile PremiumProfile { get; set; }

		IPremiumProfile ILoadingOutcome.PremiumProfile 
		{ 
			get
			{
				return this.PremiumProfile;
			}
			set
			{
				this.PremiumProfile = (PremiumProfile)value;
			}
		}
		
		#endregion
	}
}
