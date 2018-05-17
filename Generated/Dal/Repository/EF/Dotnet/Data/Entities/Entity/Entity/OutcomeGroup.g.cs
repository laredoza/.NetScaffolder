
// <copyright file="OutcomeGroup.g.cs" company="MIT">
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
	public partial class OutcomeGroup : IOutcomeGroup 
	{
		#region CTOR
		
		public OutcomeGroup()
		{
			this.CedantOutcomeGroup = new List <CedantOutcomeGroup>();
			this.OutcomeGroupOutcome = new List <OutcomeGroupOutcome>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
			this.SetupTableDataOutcomeGroup = new List <SetupTableDataOutcomeGroup>();
		}
		
		public OutcomeGroup(IOutcomeGroup item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.OutcomeGroupUniqueId = item.OutcomeGroupUniqueId;
			this.OutcomeGroupName = item.OutcomeGroupName;
			this.CedantOutcomeGroup = new List <CedantOutcomeGroup>();
			this.OutcomeGroupOutcome = new List <OutcomeGroupOutcome>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
			this.SetupTableDataOutcomeGroup = new List <SetupTableDataOutcomeGroup>();

			if(deep)
			{
				if(item.CedantOutcomeGroup != null)
				{
					foreach(var childItem in item.CedantOutcomeGroup)
					{
						this.CedantOutcomeGroup.Add(new CedantOutcomeGroup(childItem, deep));
					}
				}
				if(item.OutcomeGroupOutcome != null)
				{
					foreach(var childItem in item.OutcomeGroupOutcome)
					{
						this.OutcomeGroupOutcome.Add(new OutcomeGroupOutcome(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroup(childItem, deep));
					}
				}
				if(item.SetupTableDataOutcomeGroup != null)
				{
					foreach(var childItem in item.SetupTableDataOutcomeGroup)
					{
						this.SetupTableDataOutcomeGroup.Add(new SetupTableDataOutcomeGroup(childItem, deep));
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
        
        public virtual IList<CedantOutcomeGroup> CedantOutcomeGroup { get; set; }

        IList<ICedantOutcomeGroup> IOutcomeGroup.CedantOutcomeGroup 
		{ 
			get
			{
				return (IList<ICedantOutcomeGroup>)this.CedantOutcomeGroup;
			}
			set
			{
				this.CedantOutcomeGroup = (IList<CedantOutcomeGroup>)value;
			}			
		}
        
        public virtual IList<OutcomeGroupOutcome> OutcomeGroupOutcome { get; set; }

        IList<IOutcomeGroupOutcome> IOutcomeGroup.OutcomeGroupOutcome 
		{ 
			get
			{
				return (IList<IOutcomeGroupOutcome>)this.OutcomeGroupOutcome;
			}
			set
			{
				this.OutcomeGroupOutcome = (IList<OutcomeGroupOutcome>)value;
			}			
		}
        
        public virtual IList<RunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }

        IList<IRunOnceOutcomeGroup> IOutcomeGroup.RunOnceOutcomeGroup 
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
        
        public virtual IList<SetupTableDataOutcomeGroup> SetupTableDataOutcomeGroup { get; set; }

        IList<ISetupTableDataOutcomeGroup> IOutcomeGroup.SetupTableDataOutcomeGroup 
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
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
