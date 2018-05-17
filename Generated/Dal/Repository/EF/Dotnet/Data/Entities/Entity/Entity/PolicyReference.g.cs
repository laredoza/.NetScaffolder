
// <copyright file="PolicyReference.g.cs" company="MIT">
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
	public partial class PolicyReference : IPolicyReference 
	{
		#region CTOR
		
		public PolicyReference()
		{
			this.PolicyReferenceOutcome = new List <PolicyReferenceOutcome>();
		}
		
		public PolicyReference(IPolicyReference item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.SetupTableDataId = item.SetupTableDataId;
			this.PolicyId = item.PolicyId;
			this.Source = item.Source;
			this.PolicyReferenceOutcome = new List <PolicyReferenceOutcome>();

			if(deep)
			{
				if(item.PolicyReferenceOutcome != null)
				{
					foreach(var childItem in item.PolicyReferenceOutcome)
					{
						this.PolicyReferenceOutcome.Add(new PolicyReferenceOutcome(childItem, deep));
					}
				}
				this.MonitoredPolicyReference = new MonitoredPolicyReference(item.MonitoredPolicyReference, deep);
				this.StandardPolicyReference = new StandardPolicyReference(item.StandardPolicyReference, deep);
				if(item.SetupTableData != null)
                {
                    this.SetupTableData = new SetupTableData(item.SetupTableData, deep);
                }
				if(item.Policy != null)
                {
                    this.Policy = new Policy(item.Policy, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> SetupTableDataId { get; set; }
		public Nullable<int> PolicyId { get; set; }
		public bool Source { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<PolicyReferenceOutcome> PolicyReferenceOutcome { get; set; }

        IList<IPolicyReferenceOutcome> IPolicyReference.PolicyReferenceOutcome 
		{ 
			get
			{
				return (IList<IPolicyReferenceOutcome>)this.PolicyReferenceOutcome;
			}
			set
			{
				this.PolicyReferenceOutcome = (IList<PolicyReferenceOutcome>)value;
			}			
		}
        
        public virtual MonitoredPolicyReference MonitoredPolicyReference { get; set; }

		IMonitoredPolicyReference IPolicyReference.MonitoredPolicyReference 
		{ 
			get
			{
				return this.MonitoredPolicyReference;
			}
			set
			{
				this.MonitoredPolicyReference = (MonitoredPolicyReference)value;
			}
		}
        
        public virtual StandardPolicyReference StandardPolicyReference { get; set; }

		IStandardPolicyReference IPolicyReference.StandardPolicyReference 
		{ 
			get
			{
				return this.StandardPolicyReference;
			}
			set
			{
				this.StandardPolicyReference = (StandardPolicyReference)value;
			}
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual SetupTableData SetupTableData { get; set; }

		ISetupTableData IPolicyReference.SetupTableData 
		{ 
			get
			{
				return this.SetupTableData;
			}
			set
			{
				this.SetupTableData = (SetupTableData)value;
			}
		}

        public virtual Policy Policy { get; set; }

		IPolicy IPolicyReference.Policy 
		{ 
			get
			{
				return this.Policy;
			}
			set
			{
				this.Policy = (Policy)value;
			}
		}
		
		#endregion
	}
}
