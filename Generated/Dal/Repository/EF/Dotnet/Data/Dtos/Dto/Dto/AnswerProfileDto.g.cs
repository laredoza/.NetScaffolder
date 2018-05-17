
// <copyright file="AnswerProfileDto.g.cs" company="MIT">
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
	public partial class AnswerProfileDto : IAnswerProfile 
	{
		#region CTOR
		
		public AnswerProfileDto()
		{
			this.Answer = new List <IAnswer>();
			this.AnswerCondition = new List <IAnswerCondition>();
			this.AnswerOutcome = new List <IAnswerOutcome>();
		}
		
		public AnswerProfileDto(IAnswerProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.DataType = item.DataType;
			this.QuestionProfileId = item.QuestionProfileId;
			this.AnswerProviderId = item.AnswerProviderId;
			this.ApplicantAttributeId = item.ApplicantAttributeId;
			this.SequenceId = item.SequenceId;
			this.PromptText = item.PromptText;
			this.Answer = new List <IAnswer>();
			this.AnswerCondition = new List <IAnswerCondition>();
			this.AnswerOutcome = new List <IAnswerOutcome>();

			if(deep)
			{
				if(item.Answer != null)
				{
					foreach(var childItem in item.Answer)
					{
						this.Answer.Add(new AnswerDto(childItem, deep));
					}
				}
				if(item.AnswerCondition != null)
				{
					foreach(var childItem in item.AnswerCondition)
					{
						this.AnswerCondition.Add(new AnswerConditionDto(childItem, deep));
					}
				}
				if(item.AnswerOutcome != null)
				{
					foreach(var childItem in item.AnswerOutcome)
					{
						this.AnswerOutcome.Add(new AnswerOutcomeDto(childItem, deep));
					}
				}
                if(item.Provider != null)
                {
				    this.Provider = new ProviderDto(item.Provider, deep);
                }
                if(item.ApplicantAttributeProfile != null)
                {
				    this.ApplicantAttributeProfile = new ApplicantAttributeProfileDto(item.ApplicantAttributeProfile, deep);
                }
                if(item.SequenceProvider != null)
                {
				    this.SequenceProvider = new SequenceProviderDto(item.SequenceProvider, deep);
                }
                if(item.QuestionnaireSequence != null)
                {
				    this.QuestionnaireSequence = new QuestionnaireSequenceDto(item.QuestionnaireSequence, deep);
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
		public Nullable<int> DataType { get; set; }
		public Nullable<int> QuestionProfileId { get; set; }
		public Nullable<int> AnswerProviderId { get; set; }
		public Nullable<int> ApplicantAttributeId { get; set; }
		public Nullable<int> SequenceId { get; set; }
		public string PromptText { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IAnswer> Answer { get; set; }
		public IList<IAnswerCondition> AnswerCondition { get; set; }
		public IList<IAnswerOutcome> AnswerOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IProvider Provider { get; set; }
		public IApplicantAttributeProfile ApplicantAttributeProfile { get; set; }
		public ISequenceProvider SequenceProvider { get; set; }
		public IQuestionnaireSequence QuestionnaireSequence { get; set; }
		public IQuestionProfile QuestionProfile { get; set; }
		
		#endregion
	}
}
