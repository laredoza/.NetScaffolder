
// <copyright file="VersionConditionResult.g.cs" company="MIT">
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
	public partial class VersionConditionResult : IVersionConditionResult 
	{
		#region CTOR
		
		public VersionConditionResult()
		{
			this.VersionOutcomeResult = new List <VersionOutcomeResult>();
		}
		
		public VersionConditionResult(IVersionConditionResult item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.QuestionnaireId = item.QuestionnaireId;
			this.VersionConditionId = item.VersionConditionId;
			this.ConditionResultId = item.ConditionResultId;
			this.VersionOutcomeResult = new List <VersionOutcomeResult>();

			if(deep)
			{
				if(item.VersionOutcomeResult != null)
				{
					foreach(var childItem in item.VersionOutcomeResult)
					{
						this.VersionOutcomeResult.Add(new VersionOutcomeResult(childItem, deep));
					}
				}
				if(item.VersionCondition != null)
                {
                    this.VersionCondition = new VersionCondition(item.VersionCondition, deep);
                }
				if(item.ConditionResultContainer != null)
                {
                    this.ConditionResultContainer = new ConditionResultContainer(item.ConditionResultContainer, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> QuestionnaireId { get; set; }
		public Nullable<int> VersionConditionId { get; set; }
		public Nullable<int> ConditionResultId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<VersionOutcomeResult> VersionOutcomeResult { get; set; }

        IList<IVersionOutcomeResult> IVersionConditionResult.VersionOutcomeResult 
		{ 
			get
			{
				return (IList<IVersionOutcomeResult>)this.VersionOutcomeResult;
			}
			set
			{
				this.VersionOutcomeResult = (IList<VersionOutcomeResult>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual VersionCondition VersionCondition { get; set; }

		IVersionCondition IVersionConditionResult.VersionCondition 
		{ 
			get
			{
				return this.VersionCondition;
			}
			set
			{
				this.VersionCondition = (VersionCondition)value;
			}
		}

        public virtual ConditionResultContainer ConditionResultContainer { get; set; }

		IConditionResultContainer IVersionConditionResult.ConditionResultContainer 
		{ 
			get
			{
				return this.ConditionResultContainer;
			}
			set
			{
				this.ConditionResultContainer = (ConditionResultContainer)value;
			}
		}
		
		#endregion
	}
}
