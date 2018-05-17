
// <copyright file="PremiumProfileDto.g.cs" company="MIT">
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
	public partial class PremiumProfileDto : IPremiumProfile 
	{
		#region CTOR
		
		public PremiumProfileDto()
		{
			this.CedantUserLoadingLimit = new List <ICedantUserLoadingLimit>();
			this.LoadingOutcome = new List <ILoadingOutcome>();
			this.Premium = new List <IPremium>();
		}
		
		public PremiumProfileDto(IPremiumProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.ProductProfile = item.ProductProfile;
			this.CedantUserLoadingLimit = new List <ICedantUserLoadingLimit>();
			this.LoadingOutcome = new List <ILoadingOutcome>();
			this.Premium = new List <IPremium>();

			if(deep)
			{
				if(item.CedantUserLoadingLimit != null)
				{
					foreach(var childItem in item.CedantUserLoadingLimit)
					{
						this.CedantUserLoadingLimit.Add(new CedantUserLoadingLimitDto(childItem, deep));
					}
				}
				if(item.LoadingOutcome != null)
				{
					foreach(var childItem in item.LoadingOutcome)
					{
						this.LoadingOutcome.Add(new LoadingOutcomeDto(childItem, deep));
					}
				}
				if(item.Premium != null)
				{
					foreach(var childItem in item.Premium)
					{
						this.Premium.Add(new PremiumDto(childItem, deep));
					}
				}
                if(item.ProductProfile1 != null)
                {
				    this.ProductProfile1 = new ProductProfileDto(item.ProductProfile1, deep);
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
		
		public IList<ICedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }
		public IList<ILoadingOutcome> LoadingOutcome { get; set; }
		public IList<IPremium> Premium { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IProductProfile ProductProfile1 { get; set; }
		
		#endregion
	}
}
