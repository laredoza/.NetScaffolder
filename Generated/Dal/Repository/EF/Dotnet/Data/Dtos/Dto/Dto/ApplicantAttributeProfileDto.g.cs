
// <copyright file="ApplicantAttributeProfileDto.g.cs" company="MIT">
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
	public partial class ApplicantAttributeProfileDto : IApplicantAttributeProfile 
	{
		#region CTOR
		
		public ApplicantAttributeProfileDto()
		{
			this.AnswerProfile = new List <IAnswerProfile>();
			this.ApplicantAttribute = new List <IApplicantAttribute>();
			this.CedantApplicantAttribute = new List <ICedantApplicantAttribute>();
			this.CedantMandatoryFieldConfig = new List <ICedantMandatoryFieldConfig>();
			this.CustomerApplicantAttribute = new List <ICustomerApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.ScoringOutcome = new List <IScoringOutcome>();
		}
		
		public ApplicantAttributeProfileDto(IApplicantAttributeProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.Type = item.Type;
			this.AlsoForCustomer = item.AlsoForCustomer;
			this.Status = item.Status;
			this.DisplayOnReport = item.DisplayOnReport;
			this.AnswerProfile = new List <IAnswerProfile>();
			this.ApplicantAttribute = new List <IApplicantAttribute>();
			this.CedantApplicantAttribute = new List <ICedantApplicantAttribute>();
			this.CedantMandatoryFieldConfig = new List <ICedantMandatoryFieldConfig>();
			this.CustomerApplicantAttribute = new List <ICustomerApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.ScoringOutcome = new List <IScoringOutcome>();

			if(deep)
			{
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfileDto(childItem, deep));
					}
				}
				if(item.ApplicantAttribute != null)
				{
					foreach(var childItem in item.ApplicantAttribute)
					{
						this.ApplicantAttribute.Add(new ApplicantAttributeDto(childItem, deep));
					}
				}
				if(item.CedantApplicantAttribute != null)
				{
					foreach(var childItem in item.CedantApplicantAttribute)
					{
						this.CedantApplicantAttribute.Add(new CedantApplicantAttributeDto(childItem, deep));
					}
				}
				if(item.CedantMandatoryFieldConfig != null)
				{
					foreach(var childItem in item.CedantMandatoryFieldConfig)
					{
						this.CedantMandatoryFieldConfig.Add(new CedantMandatoryFieldConfigDto(childItem, deep));
					}
				}
				if(item.CustomerApplicantAttribute != null)
				{
					foreach(var childItem in item.CustomerApplicantAttribute)
					{
						this.CustomerApplicantAttribute.Add(new CustomerApplicantAttributeDto(childItem, deep));
					}
				}
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttributeDto(childItem, deep));
					}
				}
				if(item.ScoringOutcome != null)
				{
					foreach(var childItem in item.ScoringOutcome)
					{
						this.ScoringOutcome.Add(new ScoringOutcomeDto(childItem, deep));
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
		public Nullable<int> Type { get; set; }
		public Nullable<bool> AlsoForCustomer { get; set; }
		public Nullable<bool> Status { get; set; }
		public Nullable<bool> DisplayOnReport { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IAnswerProfile> AnswerProfile { get; set; }
		public IList<IApplicantAttribute> ApplicantAttribute { get; set; }
		public IList<ICedantApplicantAttribute> CedantApplicantAttribute { get; set; }
		public IList<ICedantMandatoryFieldConfig> CedantMandatoryFieldConfig { get; set; }
		public IList<ICustomerApplicantAttribute> CustomerApplicantAttribute { get; set; }
		public IList<IOutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }
		public IList<IScoringOutcome> ScoringOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
