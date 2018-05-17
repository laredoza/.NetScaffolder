﻿
// <copyright file="ProductPostponeStatusOutcomeDto.g.cs" company="MIT">
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
	public partial class ProductPostponeStatusOutcomeDto : IProductPostponeStatusOutcome 
	{
		#region CTOR
		
		public ProductPostponeStatusOutcomeDto()
		{
		}
		
		public ProductPostponeStatusOutcomeDto(IProductPostponeStatusOutcome item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Status = item.Status;
			this.Months = item.Months;
			this.ProductProfileId = item.ProductProfileId;
			this.SetupTableDataId = item.SetupTableDataId;
			this.Days = item.Days;

			if(deep)
			{
                if(item.Provider != null)
                {
				    this.Provider = new ProviderDto(item.Provider, deep);
                }
                if(item.ProductProfile != null)
                {
				    this.ProductProfile = new ProductProfileDto(item.ProductProfile, deep);
                }
                if(item.SetupTableData != null)
                {
				    this.SetupTableData = new SetupTableDataDto(item.SetupTableData, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<int> Status { get; set; }
		public Nullable<int> Months { get; set; }
		public Nullable<int> ProductProfileId { get; set; }
		public Nullable<int> SetupTableDataId { get; set; }
		public Nullable<int> Days { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IProvider Provider { get; set; }
		public IProductProfile ProductProfile { get; set; }
		public ISetupTableData SetupTableData { get; set; }
		
		#endregion
	}
}
