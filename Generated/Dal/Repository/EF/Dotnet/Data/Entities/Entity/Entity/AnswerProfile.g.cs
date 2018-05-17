
// <copyright file="AnswerProfile.g.cs" company="MIT">
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
	public partial class AnswerProfile : IAnswerProfile 
	{
		#region CTOR
		
		public AnswerProfile()
		{
			this.Answer = new List <Answer>();
			this.AnswerCondition = new List <AnswerCondition>();
			this.AnswerOutcome = new List <AnswerOutcome>();
		}
		
		public AnswerProfile(IAnswerProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.DataType = item.DataType;
			this.QuestionProfileId = item.QuestionProfileId;
			this.AnswerProviderId = item.AnswerProviderId;
			this.ApplicantAttributeId = item.ApplicantAttributeId;
			this.SequenceId = item.SequenceId;
			this.PromptText = item.PromptText;
			this.Answer = new List <Answer>();
			this.AnswerCondition = new List <AnswerCondition>();
			this.AnswerOutcome = new List <AnswerOutcome>();

			if(deep)
			{
				if(item.Answer != null)
				{
					foreach(var childItem in item.Answer)
					{
						this.Answer.Add(new Answer(childItem, deep));
					}
				}
				if(item.AnswerCondition != null)
				{
					foreach(var childItem in item.AnswerCondition)
					{
						this.AnswerCondition.Add(new AnswerCondition(childItem, deep));
					}
				}
				if(item.AnswerOutcome != null)
				{
					foreach(var childItem in item.AnswerOutcome)
					{
						this.AnswerOutcome.Add(new AnswerOutcome(childItem, deep));
					}
				}
				if(item.Provider != null)
                {
                    this.Provider = new Provider(item.Provider, deep);
                }
				if(item.ApplicantAttributeProfile != null)
                {
                    this.ApplicantAttributeProfile = new ApplicantAttributeProfile(item.ApplicantAttributeProfile, deep);
                }
				if(item.SequenceProvider != null)
                {
                    this.SequenceProvider = new SequenceProvider(item.SequenceProvider, deep);
                }
				if(item.QuestionnaireSequence != null)
                {
                    this.QuestionnaireSequence = new QuestionnaireSequence(item.QuestionnaireSequence, deep);
                }
				if(item.QuestionProfile != null)
                {
                    this.QuestionProfile = new QuestionProfile(item.QuestionProfile, deep);
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
        
        public virtual IList<Answer> Answer { get; set; }

        IList<IAnswer> IAnswerProfile.Answer 
		{ 
			get
			{
				return (IList<IAnswer>)this.Answer;
			}
			set
			{
				this.Answer = (IList<Answer>)value;
			}			
		}
        
        public virtual IList<AnswerCondition> AnswerCondition { get; set; }

        IList<IAnswerCondition> IAnswerProfile.AnswerCondition 
		{ 
			get
			{
				return (IList<IAnswerCondition>)this.AnswerCondition;
			}
			set
			{
				this.AnswerCondition = (IList<AnswerCondition>)value;
			}			
		}
        
        public virtual IList<AnswerOutcome> AnswerOutcome { get; set; }

        IList<IAnswerOutcome> IAnswerProfile.AnswerOutcome 
		{ 
			get
			{
				return (IList<IAnswerOutcome>)this.AnswerOutcome;
			}
			set
			{
				this.AnswerOutcome = (IList<AnswerOutcome>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Provider Provider { get; set; }

		IProvider IAnswerProfile.Provider 
		{ 
			get
			{
				return this.Provider;
			}
			set
			{
				this.Provider = (Provider)value;
			}
		}

        public virtual ApplicantAttributeProfile ApplicantAttributeProfile { get; set; }

		IApplicantAttributeProfile IAnswerProfile.ApplicantAttributeProfile 
		{ 
			get
			{
				return this.ApplicantAttributeProfile;
			}
			set
			{
				this.ApplicantAttributeProfile = (ApplicantAttributeProfile)value;
			}
		}

        public virtual SequenceProvider SequenceProvider { get; set; }

		ISequenceProvider IAnswerProfile.SequenceProvider 
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

		IQuestionnaireSequence IAnswerProfile.QuestionnaireSequence 
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

        public virtual QuestionProfile QuestionProfile { get; set; }

		IQuestionProfile IAnswerProfile.QuestionProfile 
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
