
// <copyright file="QuestionProfile.g.cs" company="MIT">
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

namespace Banking.Models.Interfaces
{
	public partial interface IQuestionProfile  
	{
		#region Fields
		
		int Id { get; set; }
		Nullable<int> Number { get; set; }
		string Title { get; set; }
		string PlaintText { get; set; }
		string Text { get; set; }
		Nullable<bool> allowMultipleAnswers { get; set; }
		Nullable<bool> isVisibleAtStart { get; set; }
		string CopiedFromQuestionProfileTitle { get; set; }
		string PromptPlaintText { get; set; }
		string PromptText { get; set; }
		Nullable<bool> PrePopulatedByService { get; set; }
		Nullable<int> SequenceId { get; set; }
		string ExternalReferenceId { get; set; }
		bool AnswerRequired { get; set; }
		Nullable<bool> DoNotDisplay { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<IAnswerProfile> AnswerProfile { get; set; }
		IList<IQuestion> Question { get; set; }
		IList<IQuestionProfile_History> QuestionProfile_History { get; set; }
		IList<ISectionQuestion> SectionQuestion { get; set; }

		#endregion
		
		#region Parent Relationships
		
		ISequenceProvider SequenceProvider { get; set; }
		IQuestionnaireSequence QuestionnaireSequence { get; set; }
		
		#endregion
	}
}
