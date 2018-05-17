
// <copyright file="QuestionnaireSequence.g.cs" company="MIT">
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
	public partial class QuestionnaireSequence : IQuestionnaireSequence 
	{
		#region CTOR
		
		public QuestionnaireSequence()
		{
			this.AnswerProfile = new List <AnswerProfile>();
			this.QuestionProfile = new List <QuestionProfile>();
			this.VersionSection = new List <VersionSection>();
		}
		
		public QuestionnaireSequence(IQuestionnaireSequence item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Seq = item.Seq;
			this.ProfileVersionId = item.ProfileVersionId;
			this.SequenceEntityId = item.SequenceEntityId;
			this.AnswerProfile = new List <AnswerProfile>();
			this.QuestionProfile = new List <QuestionProfile>();
			this.VersionSection = new List <VersionSection>();

			if(deep)
			{
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfile(childItem, deep));
					}
				}
				if(item.QuestionProfile != null)
				{
					foreach(var childItem in item.QuestionProfile)
					{
						this.QuestionProfile.Add(new QuestionProfile(childItem, deep));
					}
				}
				if(item.VersionSection != null)
				{
					foreach(var childItem in item.VersionSection)
					{
						this.VersionSection.Add(new VersionSection(childItem, deep));
					}
				}
				if(item.QuestionnaireProfileVersion != null)
                {
                    this.QuestionnaireProfileVersion = new QuestionnaireProfileVersion(item.QuestionnaireProfileVersion, deep);
                }
				if(item.SequenceProvider != null)
                {
                    this.SequenceProvider = new SequenceProvider(item.SequenceProvider, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> Seq { get; set; }
		public Nullable<int> ProfileVersionId { get; set; }
		public Nullable<int> SequenceEntityId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<AnswerProfile> AnswerProfile { get; set; }

        IList<IAnswerProfile> IQuestionnaireSequence.AnswerProfile 
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
        
        public virtual IList<QuestionProfile> QuestionProfile { get; set; }

        IList<IQuestionProfile> IQuestionnaireSequence.QuestionProfile 
		{ 
			get
			{
				return (IList<IQuestionProfile>)this.QuestionProfile;
			}
			set
			{
				this.QuestionProfile = (IList<QuestionProfile>)value;
			}			
		}
        
        public virtual IList<VersionSection> VersionSection { get; set; }

        IList<IVersionSection> IQuestionnaireSequence.VersionSection 
		{ 
			get
			{
				return (IList<IVersionSection>)this.VersionSection;
			}
			set
			{
				this.VersionSection = (IList<VersionSection>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual QuestionnaireProfileVersion QuestionnaireProfileVersion { get; set; }

		IQuestionnaireProfileVersion IQuestionnaireSequence.QuestionnaireProfileVersion 
		{ 
			get
			{
				return this.QuestionnaireProfileVersion;
			}
			set
			{
				this.QuestionnaireProfileVersion = (QuestionnaireProfileVersion)value;
			}
		}

        public virtual SequenceProvider SequenceProvider { get; set; }

		ISequenceProvider IQuestionnaireSequence.SequenceProvider 
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
		
		#endregion
	}
}
