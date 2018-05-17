
// <copyright file="CedantUserLoadingLimitDto.g.cs" company="MIT">
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
	public partial class CedantUserLoadingLimitDto : ICedantUserLoadingLimit 
	{
		#region CTOR
		
		public CedantUserLoadingLimitDto()
		{
		}
		
		public CedantUserLoadingLimitDto(ICedantUserLoadingLimit item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.MinPercentage = item.MinPercentage;
			this.MaxPercentage = item.MaxPercentage;
			this.UserId = item.UserId;
			this.PremiumProfileId = item.PremiumProfileId;
			this.CedantId = item.CedantId;
			this.MinUnit = item.MinUnit;
			this.MaxUnit = item.MaxUnit;

			if(deep)
			{
                if(item.Cedant != null)
                {
				    this.Cedant = new CedantDto(item.Cedant, deep);
                }
                if(item.QUIRCUser != null)
                {
				    this.QUIRCUser = new QUIRCUserDto(item.QUIRCUser, deep);
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
		public Nullable<decimal> MinPercentage { get; set; }
		public Nullable<decimal> MaxPercentage { get; set; }
		public Nullable<int> UserId { get; set; }
		public Nullable<int> PremiumProfileId { get; set; }
		public Nullable<int> CedantId { get; set; }
		public Nullable<decimal> MinUnit { get; set; }
		public Nullable<decimal> MaxUnit { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public ICedant Cedant { get; set; }
		public IQUIRCUser QUIRCUser { get; set; }
		public IPremiumProfile PremiumProfile { get; set; }
		
		#endregion
	}
}
