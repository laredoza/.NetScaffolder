
// <copyright file="AnswerConditionOutcomeResult.g.cs" company="MIT">
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
	public partial class AnswerConditionOutcomeResult : IAnswerConditionOutcomeResult 
	{
		#region CTOR
		
		public AnswerConditionOutcomeResult()
		{
			this.ConditionOutcomeResult = new List <ConditionOutcomeResult>();
		}
		
		public AnswerConditionOutcomeResult(IAnswerConditionOutcomeResult item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerId = item.AnswerId;
			this.ConditionResultId = item.ConditionResultId;
			this.ConditionOutcomeResult = new List <ConditionOutcomeResult>();

			if(deep)
			{
				if(item.ConditionOutcomeResult != null)
				{
					foreach(var childItem in item.ConditionOutcomeResult)
					{
						this.ConditionOutcomeResult.Add(new ConditionOutcomeResult(childItem, deep));
					}
				}
				if(item.Answer != null)
                {
                    this.Answer = new Answer(item.Answer, deep);
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
		public Nullable<int> AnswerId { get; set; }
		public Nullable<int> ConditionResultId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<ConditionOutcomeResult> ConditionOutcomeResult { get; set; }

        IList<IConditionOutcomeResult> IAnswerConditionOutcomeResult.ConditionOutcomeResult 
		{ 
			get
			{
				return (IList<IConditionOutcomeResult>)this.ConditionOutcomeResult;
			}
			set
			{
				this.ConditionOutcomeResult = (IList<ConditionOutcomeResult>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Answer Answer { get; set; }

		IAnswer IAnswerConditionOutcomeResult.Answer 
		{ 
			get
			{
				return this.Answer;
			}
			set
			{
				this.Answer = (Answer)value;
			}
		}

        public virtual ConditionResultContainer ConditionResultContainer { get; set; }

		IConditionResultContainer IAnswerConditionOutcomeResult.ConditionResultContainer 
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
