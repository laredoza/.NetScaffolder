
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
using Banking.Models.Interfaces;

namespace Banking.Models.Entity
{
	public partial class QuestionProfile : IQuestionProfile 
	{
		#region CTOR
		
		public QuestionProfile()
		{
			this.AnswerProfile = new List <AnswerProfile>();
			this.Question = new List <Question>();
			this.QuestionProfile_History = new List <QuestionProfile_History>();
			this.SectionQuestion = new List <SectionQuestion>();
		}
		
		public QuestionProfile(IQuestionProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Number = item.Number;
			this.Title = item.Title;
			this.PlaintText = item.PlaintText;
			this.Text = item.Text;
			this.allowMultipleAnswers = item.allowMultipleAnswers;
			this.isVisibleAtStart = item.isVisibleAtStart;
			this.CopiedFromQuestionProfileTitle = item.CopiedFromQuestionProfileTitle;
			this.PromptPlaintText = item.PromptPlaintText;
			this.PromptText = item.PromptText;
			this.PrePopulatedByService = item.PrePopulatedByService;
			this.SequenceId = item.SequenceId;
			this.ExternalReferenceId = item.ExternalReferenceId;
			this.AnswerRequired = item.AnswerRequired;
			this.DoNotDisplay = item.DoNotDisplay;
			this.AnswerProfile = new List <AnswerProfile>();
			this.Question = new List <Question>();
			this.QuestionProfile_History = new List <QuestionProfile_History>();
			this.SectionQuestion = new List <SectionQuestion>();

			if(deep)
			{
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfile(childItem, deep));
					}
				}
				if(item.Question != null)
				{
					foreach(var childItem in item.Question)
					{
						this.Question.Add(new Question(childItem, deep));
					}
				}
				if(item.QuestionProfile_History != null)
				{
					foreach(var childItem in item.QuestionProfile_History)
					{
						this.QuestionProfile_History.Add(new QuestionProfile_History(childItem, deep));
					}
				}
				if(item.SectionQuestion != null)
				{
					foreach(var childItem in item.SectionQuestion)
					{
						this.SectionQuestion.Add(new SectionQuestion(childItem, deep));
					}
				}
				if(item.SequenceProvider != null)
                {
                    this.SequenceProvider = new SequenceProvider(item.SequenceProvider, deep);
                }
				if(item.QuestionnaireSequence != null)
                {
                    this.QuestionnaireSequence = new QuestionnaireSequence(item.QuestionnaireSequence, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<int> Number { get; set; }
		public string Title { get; set; }
		public string PlaintText { get; set; }
		public string Text { get; set; }
		public Nullable<bool> allowMultipleAnswers { get; set; }
		public Nullable<bool> isVisibleAtStart { get; set; }
		public string CopiedFromQuestionProfileTitle { get; set; }
		public string PromptPlaintText { get; set; }
		public string PromptText { get; set; }
		public Nullable<bool> PrePopulatedByService { get; set; }
		public Nullable<int> SequenceId { get; set; }
		public string ExternalReferenceId { get; set; }
		public bool AnswerRequired { get; set; }
		public Nullable<bool> DoNotDisplay { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<AnswerProfile> AnswerProfile { get; set; }

        IList<IAnswerProfile> IQuestionProfile.AnswerProfile 
		{ 
			get
			{
				return (IList<IAnswerProfile>)this.AnswerProfile;
			}
			set
			{
				this.AnswerProfile = (IList<AnswerProfile>)value;
			}			
		}
        
        public virtual IList<Question> Question { get; set; }

        IList<IQuestion> IQuestionProfile.Question 
		{ 
			get
			{
				return (IList<IQuestion>)this.Question;
			}
			set
			{
				this.Question = (IList<Question>)value;
			}			
		}
        
        public virtual IList<QuestionProfile_History> QuestionProfile_History { get; set; }

        IList<IQuestionProfile_History> IQuestionProfile.QuestionProfile_History 
		{ 
			get
			{
				return (IList<IQuestionProfile_History>)this.QuestionProfile_History;
			}
			set
			{
				this.QuestionProfile_History = (IList<QuestionProfile_History>)value;
			}			
		}
        
        public virtual IList<SectionQuestion> SectionQuestion { get; set; }

        IList<ISectionQuestion> IQuestionProfile.SectionQuestion 
		{ 
			get
			{
				return (IList<ISectionQuestion>)this.SectionQuestion;
			}
			set
			{
				this.SectionQuestion = (IList<SectionQuestion>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual SequenceProvider SequenceProvider { get; set; }

		ISequenceProvider IQuestionProfile.SequenceProvider 
		{ 
			get
			{
				return this.SequenceProvider;
			}
			set
			{
				this.SequenceProvider = (SequenceProvider)value;
			}
		}

        public virtual QuestionnaireSequence QuestionnaireSequence { get; set; }

		IQuestionnaireSequence IQuestionProfile.QuestionnaireSequence 
		{ 
			get
			{
				return this.QuestionnaireSequence;
			}
			set
			{
				this.QuestionnaireSequence = (QuestionnaireSequence)value;
			}
		}
		
		#endregion
	}
}
