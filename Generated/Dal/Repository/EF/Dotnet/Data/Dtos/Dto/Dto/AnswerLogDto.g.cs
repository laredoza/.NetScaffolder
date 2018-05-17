
// <copyright file="AnswerLogDto.g.cs" company="MIT">
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
	public partial class AnswerLogDto : IAnswerLog 
	{
		#region CTOR
		
		public AnswerLogDto()
		{
		}
		
		public AnswerLogDto(IAnswerLog item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.QuestionnaireId = item.QuestionnaireId;
			this.QuestionId = item.QuestionId;
			this.Answer = item.Answer;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;

			if(deep)
			{
                if(item.Question != null)
                {
				    this.Question = new QuestionDto(item.Question, deep);
                }
                if(item.Questionnaire != null)
                {
				    this.Questionnaire = new QuestionnaireDto(item.Questionnaire, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public int QuestionnaireId { get; set; }
		public int QuestionId { get; set; }
		public string Answer { get; set; }
		public DateTime Stamp { get; set; }
		public string UserName { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IQuestion Question { get; set; }
		public IQuestionnaire Questionnaire { get; set; }
		
		#endregion
	}
}
