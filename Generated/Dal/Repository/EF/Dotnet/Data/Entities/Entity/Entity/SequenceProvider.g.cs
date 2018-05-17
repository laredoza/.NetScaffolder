
// <copyright file="SequenceProvider.g.cs" company="MIT">
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
	public partial class SequenceProvider : ISequenceProvider 
	{
		#region CTOR
		
		public SequenceProvider()
		{
			this.QuestionnaireSequence = new List <QuestionnaireSequence>();
		}
		
		public SequenceProvider(ISequenceProvider item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.QuestionnaireSequence = new List <QuestionnaireSequence>();

			if(deep)
			{
				if(item.QuestionnaireSequence != null)
				{
					foreach(var childItem in item.QuestionnaireSequence)
					{
						this.QuestionnaireSequence.Add(new QuestionnaireSequence(childItem, deep));
					}
				}
				this.AnswerProfile = new AnswerProfile(item.AnswerProfile, deep);
				this.QuestionProfile = new QuestionProfile(item.QuestionProfile, deep);
				this.VersionSection = new VersionSection(item.VersionSection, deep);
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<QuestionnaireSequence> QuestionnaireSequence { get; set; }

        IList<IQuestionnaireSequence> ISequenceProvider.QuestionnaireSequence 
		{ 
			get
			{
				return (IList<IQuestionnaireSequence>)this.QuestionnaireSequence;
			}
			set
			{
				this.QuestionnaireSequence = (IList<QuestionnaireSequence>)value;
			}			
		}
        
        public virtual AnswerProfile AnswerProfile { get; set; }

		IAnswerProfile ISequenceProvider.AnswerProfile 
		{ 
			get
			{
				return this.AnswerProfile;
			}
			set
			{
				this.AnswerProfile = (AnswerProfile)value;
			}
		}
        
        public virtual QuestionProfile QuestionProfile { get; set; }

		IQuestionProfile ISequenceProvider.QuestionProfile 
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
        
        public virtual VersionSection VersionSection { get; set; }

		IVersionSection ISequenceProvider.VersionSection 
		{ 
			get
			{
				return this.VersionSection;
			}
			set
			{
				this.VersionSection = (VersionSection)value;
			}
		}
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
