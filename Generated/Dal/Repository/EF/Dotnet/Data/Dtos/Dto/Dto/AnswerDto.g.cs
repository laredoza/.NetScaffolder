
// <copyright file="AnswerDto.g.cs" company="MIT">
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
	public partial class AnswerDto : IAnswer 
	{
		#region CTOR
		
		public AnswerDto()
		{
			this.AnswerConditionOutcomeResult = new List <IAnswerConditionOutcomeResult>();
			this.AnswerOutcomeResult = new List <IAnswerOutcomeResult>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
		}
		
		public AnswerDto(IAnswer item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.QuestionId = item.QuestionId;
			this.ResultId = item.ResultId;
			this.AnswerProfileId = item.AnswerProfileId;
			this.PreviousResultId = item.PreviousResultId;
			this.AnswerConditionOutcomeResult = new List <IAnswerConditionOutcomeResult>();
			this.AnswerOutcomeResult = new List <IAnswerOutcomeResult>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();

			if(deep)
			{
				if(item.AnswerConditionOutcomeResult != null)
				{
					foreach(var childItem in item.AnswerConditionOutcomeResult)
					{
						this.AnswerConditionOutcomeResult.Add(new AnswerConditionOutcomeResultDto(childItem, deep));
					}
				}
				if(item.AnswerOutcomeResult != null)
				{
					foreach(var childItem in item.AnswerOutcomeResult)
					{
						this.AnswerOutcomeResult.Add(new AnswerOutcomeResultDto(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroupDto(childItem, deep));
					}
				}
                if(item.Result != null)
                {
				    this.Result = new ResultDto(item.Result, deep);
                }
                if(item.Question != null)
                {
				    this.Question = new QuestionDto(item.Question, deep);
                }
                if(item.AnswerProfile != null)
                {
				    this.AnswerProfile = new AnswerProfileDto(item.AnswerProfile, deep);
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
		
		public IList<IAnswerConditionOutcomeResult> AnswerConditionOutcomeResult { get; set; }
		public IList<IAnswerOutcomeResult> AnswerOutcomeResult { get; set; }
		public IList<IRunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IResult Result { get; set; }
		public IQuestion Question { get; set; }
		public IAnswerProfile AnswerProfile { get; set; }
		
		#endregion
	}
}
