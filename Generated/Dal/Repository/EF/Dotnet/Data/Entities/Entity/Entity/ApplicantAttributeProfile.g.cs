
// <copyright file="ApplicantAttributeProfile.g.cs" company="MIT">
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
	public partial class ApplicantAttributeProfile : IApplicantAttributeProfile 
	{
		#region CTOR
		
		public ApplicantAttributeProfile()
		{
			this.AnswerProfile = new List <AnswerProfile>();
			this.ApplicantAttribute = new List <ApplicantAttribute>();
			this.CedantApplicantAttribute = new List <CedantApplicantAttribute>();
			this.CedantMandatoryFieldConfig = new List <CedantMandatoryFieldConfig>();
			this.CustomerApplicantAttribute = new List <CustomerApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <OutcomeGroupAttribute>();
			this.ScoringOutcome = new List <ScoringOutcome>();
		}
		
		public ApplicantAttributeProfile(IApplicantAttributeProfile item, bool deep = false)
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
			this.AnswerProfile = new List <AnswerProfile>();
			this.ApplicantAttribute = new List <ApplicantAttribute>();
			this.CedantApplicantAttribute = new List <CedantApplicantAttribute>();
			this.CedantMandatoryFieldConfig = new List <CedantMandatoryFieldConfig>();
			this.CustomerApplicantAttribute = new List <CustomerApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <OutcomeGroupAttribute>();
			this.ScoringOutcome = new List <ScoringOutcome>();

			if(deep)
			{
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfile(childItem, deep));
					}
				}
				if(item.ApplicantAttribute != null)
				{
					foreach(var childItem in item.ApplicantAttribute)
					{
						this.ApplicantAttribute.Add(new ApplicantAttribute(childItem, deep));
					}
				}
				if(item.CedantApplicantAttribute != null)
				{
					foreach(var childItem in item.CedantApplicantAttribute)
					{
						this.CedantApplicantAttribute.Add(new CedantApplicantAttribute(childItem, deep));
					}
				}
				if(item.CedantMandatoryFieldConfig != null)
				{
					foreach(var childItem in item.CedantMandatoryFieldConfig)
					{
						this.CedantMandatoryFieldConfig.Add(new CedantMandatoryFieldConfig(childItem, deep));
					}
				}
				if(item.CustomerApplicantAttribute != null)
				{
					foreach(var childItem in item.CustomerApplicantAttribute)
					{
						this.CustomerApplicantAttribute.Add(new CustomerApplicantAttribute(childItem, deep));
					}
				}
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttribute(childItem, deep));
					}
				}
				if(item.ScoringOutcome != null)
				{
					foreach(var childItem in item.ScoringOutcome)
					{
						this.ScoringOutcome.Add(new ScoringOutcome(childItem, deep));
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
        
        public virtual IList<AnswerProfile> AnswerProfile { get; set; }

        IList<IAnswerProfile> IApplicantAttributeProfile.AnswerProfile 
		{ 
			get
			{
				return (IList<IAnswerProfile>)this.AnswerProfile;
			}
			set
			{
				this.AnswerProfile = (IList<AnswerProfile>)value;
			}			
		}
        
        public virtual IList<ApplicantAttribute> ApplicantAttribute { get; set; }

        IList<IApplicantAttribute> IApplicantAttributeProfile.ApplicantAttribute 
		{ 
			get
			{
				return (IList<IApplicantAttribute>)this.ApplicantAttribute;
			}
			set
			{
				this.ApplicantAttribute = (IList<ApplicantAttribute>)value;
			}			
		}
        
        public virtual IList<CedantApplicantAttribute> CedantApplicantAttribute { get; set; }

        IList<ICedantApplicantAttribute> IApplicantAttributeProfile.CedantApplicantAttribute 
		{ 
			get
			{
				return (IList<ICedantApplicantAttribute>)this.CedantApplicantAttribute;
			}
			set
			{
				this.CedantApplicantAttribute = (IList<CedantApplicantAttribute>)value;
			}			
		}
        
        public virtual IList<CedantMandatoryFieldConfig> CedantMandatoryFieldConfig { get; set; }

        IList<ICedantMandatoryFieldConfig> IApplicantAttributeProfile.CedantMandatoryFieldConfig 
		{ 
			get
			{
				return (IList<ICedantMandatoryFieldConfig>)this.CedantMandatoryFieldConfig;
			}
			set
			{
				this.CedantMandatoryFieldConfig = (IList<CedantMandatoryFieldConfig>)value;
			}			
		}
        
        public virtual IList<CustomerApplicantAttribute> CustomerApplicantAttribute { get; set; }

        IList<ICustomerApplicantAttribute> IApplicantAttributeProfile.CustomerApplicantAttribute 
		{ 
			get
			{
				return (IList<ICustomerApplicantAttribute>)this.CustomerApplicantAttribute;
			}
			set
			{
				this.CustomerApplicantAttribute = (IList<CustomerApplicantAttribute>)value;
			}			
		}
        
        public virtual IList<OutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }

        IList<IOutcomeGroupAttribute> IApplicantAttributeProfile.OutcomeGroupAttribute 
		{ 
			get
			{
				return (IList<IOutcomeGroupAttribute>)this.OutcomeGroupAttribute;
			}
			set
			{
				this.OutcomeGroupAttribute = (IList<OutcomeGroupAttribute>)value;
			}			
		}
        
        public virtual IList<ScoringOutcome> ScoringOutcome { get; set; }

        IList<IScoringOutcome> IApplicantAttributeProfile.ScoringOutcome 
		{ 
			get
			{
				return (IList<IScoringOutcome>)this.ScoringOutcome;
			}
			set
			{
				this.ScoringOutcome = (IList<ScoringOutcome>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
