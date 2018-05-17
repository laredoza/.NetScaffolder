
// <copyright file="QuestionProfile_History.g.cs" company="MIT">
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
	public partial class QuestionProfile_History : IQuestionProfile_History 
	{
		#region CTOR
		
		public QuestionProfile_History()
		{
		}
		
		public QuestionProfile_History(IQuestionProfile_History item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.OriginalQuestionProfileId = item.OriginalQuestionProfileId;
			this.NewQuestionProfileId = item.NewQuestionProfileId;
			this.NewQuestionnaireProfileId = item.NewQuestionnaireProfileId;
			this.TimeStamp = item.TimeStamp;
			this.UserName = item.UserName;

			if(deep)
			{
				if(item.QuestionProfile != null)
                {
                    this.QuestionProfile = new QuestionProfile(item.QuestionProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<int> OriginalQuestionProfileId { get; set; }
		public Nullable<int> NewQuestionProfileId { get; set; }
		public Nullable<int> NewQuestionnaireProfileId { get; set; }
		public DateTime TimeStamp { get; set; }
		public string UserName { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual QuestionProfile QuestionProfile { get; set; }

		IQuestionProfile IQuestionProfile_History.QuestionProfile 
		{ 
			get
			{
				return this.QuestionProfile;
			}
			set
			{
				this.QuestionProfile = (QuestionProfile)value;
			}
		}
		
		#endregion
	}
}
