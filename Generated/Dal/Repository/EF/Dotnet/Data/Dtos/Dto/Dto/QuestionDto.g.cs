
// <copyright file="QuestionDto.g.cs" company="MIT">
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
	public partial class QuestionDto : IQuestion 
	{
		#region CTOR
		
		public QuestionDto()
		{
			this.Answer = new List <IAnswer>();
			this.AnswerLog = new List <IAnswerLog>();
		}
		
		public QuestionDto(IQuestion item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.isAnswered = item.isAnswered;
			this.isVisible = item.isVisible;
			this.isFlagged = item.isFlagged;
			this.QuestionProfileId = item.QuestionProfileId;
			this.SectionId = item.SectionId;
			this.PreviousQuestionId = item.PreviousQuestionId;
			this.PopupStartedQuestionId = item.PopupStartedQuestionId;
			this.NextQuestionId = item.NextQuestionId;
			this.Answer = new List <IAnswer>();
			this.AnswerLog = new List <IAnswerLog>();

			if(deep)
			{
				if(item.Answer != null)
				{
					foreach(var childItem in item.Answer)
					{
						this.Answer.Add(new AnswerDto(childItem, deep));
					}
				}
				if(item.AnswerLog != null)
				{
					foreach(var childItem in item.AnswerLog)
					{
						this.AnswerLog.Add(new AnswerLogDto(childItem, deep));
					}
				}
                if(item.Section != null)
                {
				    this.Section = new SectionDto(item.Section, deep);
                }
                if(item.QuestionProfile != null)
                {
				    this.QuestionProfile = new QuestionProfileDto(item.QuestionProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<bool> isAnswered { get; set; }
		public Nullable<bool> isVisible { get; set; }
		public Nullable<bool> isFlagged { get; set; }
		public Nullable<int> QuestionProfileId { get; set; }
		public Nullable<int> SectionId { get; set; }
		public Nullable<int> PreviousQuestionId { get; set; }
		public Nullable<int> PopupStartedQuestionId { get; set; }
		public Nullable<int> NextQuestionId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IAnswer> Answer { get; set; }
		public IList<IAnswerLog> AnswerLog { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ISection Section { get; set; }
		public IQuestionProfile QuestionProfile { get; set; }
		
		#endregion
	}
}
