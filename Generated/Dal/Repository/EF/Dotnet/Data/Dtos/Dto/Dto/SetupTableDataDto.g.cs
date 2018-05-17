
// <copyright file="SetupTableDataDto.g.cs" company="MIT">
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
	public partial class SetupTableDataDto : ISetupTableData 
	{
		#region CTOR
		
		public SetupTableDataDto()
		{
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.PolicyReference = new List <IPolicyReference>();
			this.ProductPostponeStatusOutcome = new List <IProductPostponeStatusOutcome>();
			this.ProductReference = new List <IProductReference>();
			this.ProductStatusReason = new List <IProductStatusReason>();
			this.ReferenceOutcome = new List <IReferenceOutcome>();
			this.ReferenceProductOutcome = new List <IReferenceProductOutcome>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
			this.SectionDisclosure = new List <ISectionDisclosure>();
			this.SetupTableDataOutcomeGroup = new List <ISetupTableDataOutcomeGroup>();
			this.SetupTableOutcome = new List <ISetupTableOutcome>();
		}
		
		public SetupTableDataDto(ISetupTableData item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Title = item.Title;
			this.Description = item.Description;
			this.Code = item.Code;
			this.Status = item.Status;
			this.Seq = item.Seq;
			this.SetupTableId = item.SetupTableId;
			this.ParentId = item.ParentId;
			this.FloatingIndex = item.FloatingIndex;
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.PolicyReference = new List <IPolicyReference>();
			this.ProductPostponeStatusOutcome = new List <IProductPostponeStatusOutcome>();
			this.ProductReference = new List <IProductReference>();
			this.ProductStatusReason = new List <IProductStatusReason>();
			this.ReferenceOutcome = new List <IReferenceOutcome>();
			this.ReferenceProductOutcome = new List <IReferenceProductOutcome>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
			this.SectionDisclosure = new List <ISectionDisclosure>();
			this.SetupTableDataOutcomeGroup = new List <ISetupTableDataOutcomeGroup>();
			this.SetupTableOutcome = new List <ISetupTableOutcome>();

			if(deep)
			{
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttributeDto(childItem, deep));
					}
				}
				if(item.PolicyReference != null)
				{
					foreach(var childItem in item.PolicyReference)
					{
						this.PolicyReference.Add(new PolicyReferenceDto(childItem, deep));
					}
				}
				if(item.ProductPostponeStatusOutcome != null)
				{
					foreach(var childItem in item.ProductPostponeStatusOutcome)
					{
						this.ProductPostponeStatusOutcome.Add(new ProductPostponeStatusOutcomeDto(childItem, deep));
					}
				}
				if(item.ProductReference != null)
				{
					foreach(var childItem in item.ProductReference)
					{
						this.ProductReference.Add(new ProductReferenceDto(childItem, deep));
					}
				}
				if(item.ProductStatusReason != null)
				{
					foreach(var childItem in item.ProductStatusReason)
					{
						this.ProductStatusReason.Add(new ProductStatusReasonDto(childItem, deep));
					}
				}
				if(item.ReferenceOutcome != null)
				{
					foreach(var childItem in item.ReferenceOutcome)
					{
						this.ReferenceOutcome.Add(new ReferenceOutcomeDto(childItem, deep));
					}
				}
				if(item.ReferenceProductOutcome != null)
				{
					foreach(var childItem in item.ReferenceProductOutcome)
					{
						this.ReferenceProductOutcome.Add(new ReferenceProductOutcomeDto(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroupDto(childItem, deep));
					}
				}
				if(item.SectionDisclosure != null)
				{
					foreach(var childItem in item.SectionDisclosure)
					{
						this.SectionDisclosure.Add(new SectionDisclosureDto(childItem, deep));
					}
				}
				if(item.SetupTableDataOutcomeGroup != null)
				{
					foreach(var childItem in item.SetupTableDataOutcomeGroup)
					{
						this.SetupTableDataOutcomeGroup.Add(new SetupTableDataOutcomeGroupDto(childItem, deep));
					}
				}
				if(item.SetupTableOutcome != null)
				{
					foreach(var childItem in item.SetupTableOutcome)
					{
						this.SetupTableOutcome.Add(new SetupTableOutcomeDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Code { get; set; }
		public Nullable<int> Status { get; set; }
		public Nullable<int> Seq { get; set; }
		public Nullable<int> SetupTableId { get; set; }
		public Nullable<int> ParentId { get; set; }
		public Nullable<bool> FloatingIndex { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IOutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }
		public IList<IPolicyReference> PolicyReference { get; set; }
		public IList<IProductPostponeStatusOutcome> ProductPostponeStatusOutcome { get; set; }
		public IList<IProductReference> ProductReference { get; set; }
		public IList<IProductStatusReason> ProductStatusReason { get; set; }
		public IList<IReferenceOutcome> ReferenceOutcome { get; set; }
		public IList<IReferenceProductOutcome> ReferenceProductOutcome { get; set; }
		public IList<IRunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }
		public IList<ISectionDisclosure> SectionDisclosure { get; set; }
		public IList<ISetupTableDataOutcomeGroup> SetupTableDataOutcomeGroup { get; set; }
		public IList<ISetupTableOutcome> SetupTableOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
