
// <copyright file="QuestionnaireSequenceDto.g.cs" company="MIT">
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
	public partial class QuestionnaireSequenceDto : IQuestionnaireSequence 
	{
		#region CTOR
		
		public QuestionnaireSequenceDto()
		{
			this.AnswerProfile = new List <IAnswerProfile>();
			this.QuestionProfile = new List <IQuestionProfile>();
			this.VersionSection = new List <IVersionSection>();
		}
		
		public QuestionnaireSequenceDto(IQuestionnaireSequence item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Seq = item.Seq;
			this.ProfileVersionId = item.ProfileVersionId;
			this.SequenceEntityId = item.SequenceEntityId;
			this.AnswerProfile = new List <IAnswerProfile>();
			this.QuestionProfile = new List <IQuestionProfile>();
			this.VersionSection = new List <IVersionSection>();

			if(deep)
			{
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfileDto(childItem, deep));
					}
				}
				if(item.QuestionProfile != null)
				{
					foreach(var childItem in item.QuestionProfile)
					{
						this.QuestionProfile.Add(new QuestionProfileDto(childItem, deep));
					}
				}
				if(item.VersionSection != null)
				{
					foreach(var childItem in item.VersionSection)
					{
						this.VersionSection.Add(new VersionSectionDto(childItem, deep));
					}
				}
                if(item.QuestionnaireProfileVersion != null)
                {
				    this.QuestionnaireProfileVersion = new QuestionnaireProfileVersionDto(item.QuestionnaireProfileVersion, deep);
                }
                if(item.SequenceProvider != null)
                {
				    this.SequenceProvider = new SequenceProviderDto(item.SequenceProvider, deep);
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
		
		public IList<IAnswerProfile> AnswerProfile { get; set; }
		public IList<IQuestionProfile> QuestionProfile { get; set; }
		public IList<IVersionSection> VersionSection { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IQuestionnaireProfileVersion QuestionnaireProfileVersion { get; set; }
		public ISequenceProvider SequenceProvider { get; set; }
		
		#endregion
	}
}
