
// <copyright file="CedantMandatoryFieldConfigDto.g.cs" company="MIT">
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
	public partial class CedantMandatoryFieldConfigDto : ICedantMandatoryFieldConfig 
	{
		#region CTOR
		
		public CedantMandatoryFieldConfigDto()
		{
		}
		
		public CedantMandatoryFieldConfigDto(ICedantMandatoryFieldConfig item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Type = item.Type;
			this.Length = item.Length;
			this.Sequence = item.Sequence;
			this.Status = item.Status;
			this.CedantMandatoryFieldId = item.CedantMandatoryFieldId;
			this.ProviderId = item.ProviderId;
			this.ApplicantAttributeId = item.ApplicantAttributeId;

			if(deep)
			{
                if(item.CedantMandatoryField != null)
                {
				    this.CedantMandatoryField = new CedantMandatoryFieldDto(item.CedantMandatoryField, deep);
                }
                if(item.ApplicantAttributeProfile != null)
                {
				    this.ApplicantAttributeProfile = new ApplicantAttributeProfileDto(item.ApplicantAttributeProfile, deep);
                }
                if(item.Provider != null)
                {
				    this.Provider = new ProviderDto(item.Provider, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> Type { get; set; }
		public Nullable<int> Length { get; set; }
		public Nullable<int> Sequence { get; set; }
		public Nullable<int> Status { get; set; }
		public Nullable<int> CedantMandatoryFieldId { get; set; }
		public Nullable<int> ProviderId { get; set; }
		public Nullable<int> ApplicantAttributeId { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public ICedantMandatoryField CedantMandatoryField { get; set; }
		public IApplicantAttributeProfile ApplicantAttributeProfile { get; set; }
		public IProvider Provider { get; set; }
		
		#endregion
	}
}
