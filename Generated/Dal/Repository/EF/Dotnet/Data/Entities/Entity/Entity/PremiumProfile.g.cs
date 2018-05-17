
// <copyright file="PremiumProfile.g.cs" company="MIT">
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
	public partial class PremiumProfile : IPremiumProfile 
	{
		#region CTOR
		
		public PremiumProfile()
		{
			this.CedantUserLoadingLimit = new List <CedantUserLoadingLimit>();
			this.LoadingOutcome = new List <LoadingOutcome>();
			this.Premium = new List <Premium>();
		}
		
		public PremiumProfile(IPremiumProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.ProductProfile = item.ProductProfile;
			this.CedantUserLoadingLimit = new List <CedantUserLoadingLimit>();
			this.LoadingOutcome = new List <LoadingOutcome>();
			this.Premium = new List <Premium>();

			if(deep)
			{
				if(item.CedantUserLoadingLimit != null)
				{
					foreach(var childItem in item.CedantUserLoadingLimit)
					{
						this.CedantUserLoadingLimit.Add(new CedantUserLoadingLimit(childItem, deep));
					}
				}
				if(item.LoadingOutcome != null)
				{
					foreach(var childItem in item.LoadingOutcome)
					{
						this.LoadingOutcome.Add(new LoadingOutcome(childItem, deep));
					}
				}
				if(item.Premium != null)
				{
					foreach(var childItem in item.Premium)
					{
						this.Premium.Add(new Premium(childItem, deep));
					}
				}
				if(item.ProductProfile1 != null)
                {
                    this.ProductProfile1 = new ProductProfile(item.ProductProfile1, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Name { get; set; }
		public Nullable<int> ProductProfile { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<CedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }

        IList<ICedantUserLoadingLimit> IPremiumProfile.CedantUserLoadingLimit 
		{ 
			get
			{
				return (IList<ICedantUserLoadingLimit>)this.CedantUserLoadingLimit;
			}
			set
			{
				this.CedantUserLoadingLimit = (IList<CedantUserLoadingLimit>)value;
			}			
		}
        
        public virtual IList<LoadingOutcome> LoadingOutcome { get; set; }

        IList<ILoadingOutcome> IPremiumProfile.LoadingOutcome 
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
        
        public virtual IList<Premium> Premium { get; set; }

        IList<IPremium> IPremiumProfile.Premium 
		{ 
			get
			{
				return (IList<IPremium>)this.Premium;
			}
			set
			{
				this.Premium = (IList<Premium>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual ProductProfile ProductProfile1 { get; set; }

		IProductProfile IPremiumProfile.ProductProfile1 
		{ 
			get
			{
				return this.ProductProfile1;
			}
			set
			{
				this.ProductProfile1 = (ProductProfile)value;
			}
		}
		
		#endregion
	}
}
