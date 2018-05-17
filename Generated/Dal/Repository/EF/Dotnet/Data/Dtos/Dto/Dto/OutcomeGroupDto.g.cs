
// <copyright file="OutcomeGroupDto.g.cs" company="MIT">
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
	public partial class OutcomeGroupDto : IOutcomeGroup 
	{
		#region CTOR
		
		public OutcomeGroupDto()
		{
			this.CedantOutcomeGroup = new List <ICedantOutcomeGroup>();
			this.OutcomeGroupOutcome = new List <IOutcomeGroupOutcome>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
			this.SetupTableDataOutcomeGroup = new List <ISetupTableDataOutcomeGroup>();
		}
		
		public OutcomeGroupDto(IOutcomeGroup item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.OutcomeGroupUniqueId = item.OutcomeGroupUniqueId;
			this.OutcomeGroupName = item.OutcomeGroupName;
			this.CedantOutcomeGroup = new List <ICedantOutcomeGroup>();
			this.OutcomeGroupOutcome = new List <IOutcomeGroupOutcome>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
			this.SetupTableDataOutcomeGroup = new List <ISetupTableDataOutcomeGroup>();

			if(deep)
			{
				if(item.CedantOutcomeGroup != null)
				{
					foreach(var childItem in item.CedantOutcomeGroup)
					{
						this.CedantOutcomeGroup.Add(new CedantOutcomeGroupDto(childItem, deep));
					}
				}
				if(item.OutcomeGroupOutcome != null)
				{
					foreach(var childItem in item.OutcomeGroupOutcome)
					{
						this.OutcomeGroupOutcome.Add(new OutcomeGroupOutcomeDto(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroupDto(childItem, deep));
					}
				}
				if(item.SetupTableDataOutcomeGroup != null)
				{
					foreach(var childItem in item.SetupTableDataOutcomeGroup)
					{
						this.SetupTableDataOutcomeGroup.Add(new SetupTableDataOutcomeGroupDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string OutcomeGroupUniqueId { get; set; }
		public string OutcomeGroupName { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<ICedantOutcomeGroup> CedantOutcomeGroup { get; set; }
		public IList<IOutcomeGroupOutcome> OutcomeGroupOutcome { get; set; }
		public IList<IRunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }
		public IList<ISetupTableDataOutcomeGroup> SetupTableDataOutcomeGroup { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
