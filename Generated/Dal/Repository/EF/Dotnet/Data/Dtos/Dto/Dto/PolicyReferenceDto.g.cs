
// <copyright file="PolicyReferenceDto.g.cs" company="MIT">
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
	public partial class PolicyReferenceDto : IPolicyReference 
	{
		#region CTOR
		
		public PolicyReferenceDto()
		{
			this.PolicyReferenceOutcome = new List <IPolicyReferenceOutcome>();
		}
		
		public PolicyReferenceDto(IPolicyReference item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.SetupTableDataId = item.SetupTableDataId;
			this.PolicyId = item.PolicyId;
			this.Source = item.Source;
			this.PolicyReferenceOutcome = new List <IPolicyReferenceOutcome>();

			if(deep)
			{
				if(item.PolicyReferenceOutcome != null)
				{
					foreach(var childItem in item.PolicyReferenceOutcome)
					{
						this.PolicyReferenceOutcome.Add(new PolicyReferenceOutcomeDto(childItem, deep));
					}
				}
				this.MonitoredPolicyReference = new MonitoredPolicyReferenceDto(item.MonitoredPolicyReference, deep);
				this.StandardPolicyReference = new StandardPolicyReferenceDto(item.StandardPolicyReference, deep);
                if(item.SetupTableData != null)
                {
				    this.SetupTableData = new SetupTableDataDto(item.SetupTableData, deep);
                }
                if(item.Policy != null)
                {
				    this.Policy = new PolicyDto(item.Policy, deep);
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
		
		public IList<IPolicyReferenceOutcome> PolicyReferenceOutcome { get; set; }
		public IMonitoredPolicyReference MonitoredPolicyReference { get; set; }
		public IStandardPolicyReference StandardPolicyReference { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ISetupTableData SetupTableData { get; set; }
		public IPolicy Policy { get; set; }
		
		#endregion
	}
}
