
// <copyright file="VersionCondition.g.cs" company="MIT">
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
	public partial class VersionCondition : IVersionCondition 
	{
		#region CTOR
		
		public VersionCondition()
		{
			this.VersionConditionResult = new List <VersionConditionResult>();
			this.VersionOutcome = new List <VersionOutcome>();
		}
		
		public VersionCondition(IVersionCondition item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.RunAtEnd = item.RunAtEnd;
			this.QuestionnaireVersionId = item.QuestionnaireVersionId;
			this.ConditionSetContainerId = item.ConditionSetContainerId;
			this.SequenceNumber = item.SequenceNumber;
			this.VersionConditionResult = new List <VersionConditionResult>();
			this.VersionOutcome = new List <VersionOutcome>();

			if(deep)
			{
				if(item.VersionConditionResult != null)
				{
					foreach(var childItem in item.VersionConditionResult)
					{
						this.VersionConditionResult.Add(new VersionConditionResult(childItem, deep));
					}
				}
				if(item.VersionOutcome != null)
				{
					foreach(var childItem in item.VersionOutcome)
					{
						this.VersionOutcome.Add(new VersionOutcome(childItem, deep));
					}
				}
				if(item.ConditionSetContainer != null)
                {
                    this.ConditionSetContainer = new ConditionSetContainer(item.ConditionSetContainer, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Name { get; set; }
		public Nullable<bool> RunAtEnd { get; set; }
		public Nullable<int> QuestionnaireVersionId { get; set; }
		public Nullable<int> ConditionSetContainerId { get; set; }
		public Nullable<int> SequenceNumber { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<VersionConditionResult> VersionConditionResult { get; set; }

        IList<IVersionConditionResult> IVersionCondition.VersionConditionResult 
		{ 
			get
			{
				return (IList<IVersionConditionResult>)this.VersionConditionResult;
			}
			set
			{
				this.VersionConditionResult = (IList<VersionConditionResult>)value;
			}			
		}
        
        public virtual IList<VersionOutcome> VersionOutcome { get; set; }

        IList<IVersionOutcome> IVersionCondition.VersionOutcome 
		{ 
			get
			{
				return (IList<IVersionOutcome>)this.VersionOutcome;
			}
			set
			{
				this.VersionOutcome = (IList<VersionOutcome>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual ConditionSetContainer ConditionSetContainer { get; set; }

		IConditionSetContainer IVersionCondition.ConditionSetContainer 
		{ 
			get
			{
				return this.ConditionSetContainer;
			}
			set
			{
				this.ConditionSetContainer = (ConditionSetContainer)value;
			}
		}
		
		#endregion
	}
}
