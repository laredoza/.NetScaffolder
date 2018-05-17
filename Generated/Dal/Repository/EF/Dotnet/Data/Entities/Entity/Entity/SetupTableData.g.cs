
// <copyright file="SetupTableData.g.cs" company="MIT">
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
	public partial class SetupTableData : ISetupTableData 
	{
		#region CTOR
		
		public SetupTableData()
		{
			this.OutcomeGroupAttribute = new List <OutcomeGroupAttribute>();
			this.PolicyReference = new List <PolicyReference>();
			this.ProductPostponeStatusOutcome = new List <ProductPostponeStatusOutcome>();
			this.ProductReference = new List <ProductReference>();
			this.ProductStatusReason = new List <ProductStatusReason>();
			this.ReferenceOutcome = new List <ReferenceOutcome>();
			this.ReferenceProductOutcome = new List <ReferenceProductOutcome>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
			this.SectionDisclosure = new List <SectionDisclosure>();
			this.SetupTableDataOutcomeGroup = new List <SetupTableDataOutcomeGroup>();
			this.SetupTableOutcome = new List <SetupTableOutcome>();
		}
		
		public SetupTableData(ISetupTableData item, bool deep = false)
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
			this.OutcomeGroupAttribute = new List <OutcomeGroupAttribute>();
			this.PolicyReference = new List <PolicyReference>();
			this.ProductPostponeStatusOutcome = new List <ProductPostponeStatusOutcome>();
			this.ProductReference = new List <ProductReference>();
			this.ProductStatusReason = new List <ProductStatusReason>();
			this.ReferenceOutcome = new List <ReferenceOutcome>();
			this.ReferenceProductOutcome = new List <ReferenceProductOutcome>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
			this.SectionDisclosure = new List <SectionDisclosure>();
			this.SetupTableDataOutcomeGroup = new List <SetupTableDataOutcomeGroup>();
			this.SetupTableOutcome = new List <SetupTableOutcome>();

			if(deep)
			{
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttribute(childItem, deep));
					}
				}
				if(item.PolicyReference != null)
				{
					foreach(var childItem in item.PolicyReference)
					{
						this.PolicyReference.Add(new PolicyReference(childItem, deep));
					}
				}
				if(item.ProductPostponeStatusOutcome != null)
				{
					foreach(var childItem in item.ProductPostponeStatusOutcome)
					{
						this.ProductPostponeStatusOutcome.Add(new ProductPostponeStatusOutcome(childItem, deep));
					}
				}
				if(item.ProductReference != null)
				{
					foreach(var childItem in item.ProductReference)
					{
						this.ProductReference.Add(new ProductReference(childItem, deep));
					}
				}
				if(item.ProductStatusReason != null)
				{
					foreach(var childItem in item.ProductStatusReason)
					{
						this.ProductStatusReason.Add(new ProductStatusReason(childItem, deep));
					}
				}
				if(item.ReferenceOutcome != null)
				{
					foreach(var childItem in item.ReferenceOutcome)
					{
						this.ReferenceOutcome.Add(new ReferenceOutcome(childItem, deep));
					}
				}
				if(item.ReferenceProductOutcome != null)
				{
					foreach(var childItem in item.ReferenceProductOutcome)
					{
						this.ReferenceProductOutcome.Add(new ReferenceProductOutcome(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroup(childItem, deep));
					}
				}
				if(item.SectionDisclosure != null)
				{
					foreach(var childItem in item.SectionDisclosure)
					{
						this.SectionDisclosure.Add(new SectionDisclosure(childItem, deep));
					}
				}
				if(item.SetupTableDataOutcomeGroup != null)
				{
					foreach(var childItem in item.SetupTableDataOutcomeGroup)
					{
						this.SetupTableDataOutcomeGroup.Add(new SetupTableDataOutcomeGroup(childItem, deep));
					}
				}
				if(item.SetupTableOutcome != null)
				{
					foreach(var childItem in item.SetupTableOutcome)
					{
						this.SetupTableOutcome.Add(new SetupTableOutcome(childItem, deep));
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
        
        public virtual IList<OutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }

        IList<IOutcomeGroupAttribute> ISetupTableData.OutcomeGroupAttribute 
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
        
        public virtual IList<PolicyReference> PolicyReference { get; set; }

        IList<IPolicyReference> ISetupTableData.PolicyReference 
		{ 
			get
			{
				return (IList<IPolicyReference>)this.PolicyReference;
			}
			set
			{
				this.PolicyReference = (IList<PolicyReference>)value;
			}			
		}
        
        public virtual IList<ProductPostponeStatusOutcome> ProductPostponeStatusOutcome { get; set; }

        IList<IProductPostponeStatusOutcome> ISetupTableData.ProductPostponeStatusOutcome 
		{ 
			get
			{
				return (IList<IProductPostponeStatusOutcome>)this.ProductPostponeStatusOutcome;
			}
			set
			{
				this.ProductPostponeStatusOutcome = (IList<ProductPostponeStatusOutcome>)value;
			}			
		}
        
        public virtual IList<ProductReference> ProductReference { get; set; }

        IList<IProductReference> ISetupTableData.ProductReference 
		{ 
			get
			{
				return (IList<IProductReference>)this.ProductReference;
			}
			set
			{
				this.ProductReference = (IList<ProductReference>)value;
			}			
		}
        
        public virtual IList<ProductStatusReason> ProductStatusReason { get; set; }

        IList<IProductStatusReason> ISetupTableData.ProductStatusReason 
		{ 
			get
			{
				return (IList<IProductStatusReason>)this.ProductStatusReason;
			}
			set
			{
				this.ProductStatusReason = (IList<ProductStatusReason>)value;
			}			
		}
        
        public virtual IList<ReferenceOutcome> ReferenceOutcome { get; set; }

        IList<IReferenceOutcome> ISetupTableData.ReferenceOutcome 
		{ 
			get
			{
				return (IList<IReferenceOutcome>)this.ReferenceOutcome;
			}
			set
			{
				this.ReferenceOutcome = (IList<ReferenceOutcome>)value;
			}			
		}
        
        public virtual IList<ReferenceProductOutcome> ReferenceProductOutcome { get; set; }

        IList<IReferenceProductOutcome> ISetupTableData.ReferenceProductOutcome 
		{ 
			get
			{
				return (IList<IReferenceProductOutcome>)this.ReferenceProductOutcome;
			}
			set
			{
				this.ReferenceProductOutcome = (IList<ReferenceProductOutcome>)value;
			}			
		}
        
        public virtual IList<RunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }

        IList<IRunOnceOutcomeGroup> ISetupTableData.RunOnceOutcomeGroup 
		{ 
			get
			{
				return (IList<IRunOnceOutcomeGroup>)this.RunOnceOutcomeGroup;
			}
			set
			{
				this.RunOnceOutcomeGroup = (IList<RunOnceOutcomeGroup>)value;
			}			
		}
        
        public virtual IList<SectionDisclosure> SectionDisclosure { get; set; }

        IList<ISectionDisclosure> ISetupTableData.SectionDisclosure 
		{ 
			get
			{
				return (IList<ISectionDisclosure>)this.SectionDisclosure;
			}
			set
			{
				this.SectionDisclosure = (IList<SectionDisclosure>)value;
			}			
		}
        
        public virtual IList<SetupTableDataOutcomeGroup> SetupTableDataOutcomeGroup { get; set; }

        IList<ISetupTableDataOutcomeGroup> ISetupTableData.SetupTableDataOutcomeGroup 
		{ 
			get
			{
				return (IList<ISetupTableDataOutcomeGroup>)this.SetupTableDataOutcomeGroup;
			}
			set
			{
				this.SetupTableDataOutcomeGroup = (IList<SetupTableDataOutcomeGroup>)value;
			}			
		}
        
        public virtual IList<SetupTableOutcome> SetupTableOutcome { get; set; }

        IList<ISetupTableOutcome> ISetupTableData.SetupTableOutcome 
		{ 
			get
			{
				return (IList<ISetupTableOutcome>)this.SetupTableOutcome;
			}
			set
			{
				this.SetupTableOutcome = (IList<SetupTableOutcome>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
