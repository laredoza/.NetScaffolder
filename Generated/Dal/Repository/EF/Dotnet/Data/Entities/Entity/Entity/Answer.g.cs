
// <copyright file="Answer.g.cs" company="MIT">
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
	public partial class Answer : IAnswer 
	{
		#region CTOR
		
		public Answer()
		{
			this.AnswerConditionOutcomeResult = new List <AnswerConditionOutcomeResult>();
			this.AnswerOutcomeResult = new List <AnswerOutcomeResult>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
		}
		
		public Answer(IAnswer item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.QuestionId = item.QuestionId;
			this.ResultId = item.ResultId;
			this.AnswerProfileId = item.AnswerProfileId;
			this.PreviousResultId = item.PreviousResultId;
			this.AnswerConditionOutcomeResult = new List <AnswerConditionOutcomeResult>();
			this.AnswerOutcomeResult = new List <AnswerOutcomeResult>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();

			if(deep)
			{
				if(item.AnswerConditionOutcomeResult != null)
				{
					foreach(var childItem in item.AnswerConditionOutcomeResult)
					{
						this.AnswerConditionOutcomeResult.Add(new AnswerConditionOutcomeResult(childItem, deep));
					}
				}
				if(item.AnswerOutcomeResult != null)
				{
					foreach(var childItem in item.AnswerOutcomeResult)
					{
						this.AnswerOutcomeResult.Add(new AnswerOutcomeResult(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroup(childItem, deep));
					}
				}
				if(item.Result != null)
                {
                    this.Result = new Result(item.Result, deep);
                }
				if(item.Question != null)
                {
                    this.Question = new Question(item.Question, deep);
                }
				if(item.AnswerProfile != null)
                {
                    this.AnswerProfile = new AnswerProfile(item.AnswerProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> QuestionId { get; set; }
		public Nullable<int> ResultId { get; set; }
		public Nullable<int> AnswerProfileId { get; set; }
		public Nullable<int> PreviousResultId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<AnswerConditionOutcomeResult> AnswerConditionOutcomeResult { get; set; }

        IList<IAnswerConditionOutcomeResult> IAnswer.AnswerConditionOutcomeResult 
		{ 
			get
			{
				return (IList<IAnswerConditionOutcomeResult>)this.AnswerConditionOutcomeResult;
			}
			set
			{
				this.AnswerConditionOutcomeResult = (IList<AnswerConditionOutcomeResult>)value;
			}			
		}
        
        public virtual IList<AnswerOutcomeResult> AnswerOutcomeResult { get; set; }

        IList<IAnswerOutcomeResult> IAnswer.AnswerOutcomeResult 
		{ 
			get
			{
				return (IList<IAnswerOutcomeResult>)this.AnswerOutcomeResult;
			}
			set
			{
				this.AnswerOutcomeResult = (IList<AnswerOutcomeResult>)value;
			}			
		}
        
        public virtual IList<RunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }

        IList<IRunOnceOutcomeGroup> IAnswer.RunOnceOutcomeGroup 
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
		
		#endregion
		
		#region Parent Relationships

        public virtual Result Result { get; set; }

		IResult IAnswer.Result 
		{ 
			get
			{
				return this.Result;
			}
			set
			{
				this.Result = (Result)value;
			}
		}

        public virtual Question Question { get; set; }

		IQuestion IAnswer.Question 
		{ 
			get
			{
				return this.Question;
			}
			set
			{
				this.Question = (Question)value;
			}
		}

        public virtual AnswerProfile AnswerProfile { get; set; }

		IAnswerProfile IAnswer.AnswerProfile 
		{ 
			get
			{
				return this.AnswerProfile;
			}
			set
			{
				this.AnswerProfile = (AnswerProfile)value;
			}
		}
		
		#endregion
	}
}
