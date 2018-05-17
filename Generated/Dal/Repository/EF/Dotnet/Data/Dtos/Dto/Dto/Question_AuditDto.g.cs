
// <copyright file="Question_AuditDto.g.cs" company="MIT">
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
	public partial class Question_AuditDto : IQuestion_Audit 
	{
		#region CTOR
		
		public Question_AuditDto()
		{
		}
		
		public Question_AuditDto(IQuestion_Audit item, bool deep = false)
		{
			if(item == null) return;
			
			this.Audit_Id = item.Audit_Id;
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.isAnswered = item.isAnswered;
			this.isVisible = item.isVisible;
			this.isFlagged = item.isFlagged;
			this.QuestionProfileId = item.QuestionProfileId;
			this.SectionId = item.SectionId;
			this.AuditTrailType = item.AuditTrailType;
			this.PreviousQuestionId = item.PreviousQuestionId;
			this.PopupStartedQuestionId = item.PopupStartedQuestionId;
			this.NextQuestionId = item.NextQuestionId;

			if(deep)
			{
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Audit_Id { get; set; }
		public int Id { get; set; }
		public DateTime Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<bool> isAnswered { get; set; }
		public Nullable<bool> isVisible { get; set; }
		public Nullable<bool> isFlagged { get; set; }
		public Nullable<int> QuestionProfileId { get; set; }
		public Nullable<int> SectionId { get; set; }
		public int AuditTrailType { get; set; }
		public Nullable<int> PreviousQuestionId { get; set; }
		public Nullable<int> PopupStartedQuestionId { get; set; }
		public Nullable<int> NextQuestionId { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
