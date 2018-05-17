
// <copyright file="QuestionnaireProfileVersionDto.g.cs" company="MIT">
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
	public partial class QuestionnaireProfileVersionDto : IQuestionnaireProfileVersion 
	{
		#region CTOR
		
		public QuestionnaireProfileVersionDto()
		{
			this.Cedant = new List <ICedant>();
			this.QuestionnaireSequence = new List <IQuestionnaireSequence>();
			this.VersionSection = new List <IVersionSection>();
		}
		
		public QuestionnaireProfileVersionDto(IQuestionnaireProfileVersion item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Version = item.Version;
			this.GroupApplicantPropertyAnswers = item.GroupApplicantPropertyAnswers;
			this.VersionLocked = item.VersionLocked;
			this.QuestionnaireProfileId = item.QuestionnaireProfileId;
			this.Cedant = new List <ICedant>();
			this.QuestionnaireSequence = new List <IQuestionnaireSequence>();
			this.VersionSection = new List <IVersionSection>();

			if(deep)
			{
				if(item.Cedant != null)
				{
					foreach(var childItem in item.Cedant)
					{
						this.Cedant.Add(new CedantDto(childItem, deep));
					}
				}
				if(item.QuestionnaireSequence != null)
				{
					foreach(var childItem in item.QuestionnaireSequence)
					{
						this.QuestionnaireSequence.Add(new QuestionnaireSequenceDto(childItem, deep));
					}
				}
				if(item.VersionSection != null)
				{
					foreach(var childItem in item.VersionSection)
					{
						this.VersionSection.Add(new VersionSectionDto(childItem, deep));
					}
				}
                if(item.QuestionnaireProfile != null)
                {
				    this.QuestionnaireProfile = new QuestionnaireProfileDto(item.QuestionnaireProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Version { get; set; }
		public Nullable<bool> GroupApplicantPropertyAnswers { get; set; }
		public Nullable<bool> VersionLocked { get; set; }
		public Nullable<int> QuestionnaireProfileId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<ICedant> Cedant { get; set; }
		public IList<IQuestionnaireSequence> QuestionnaireSequence { get; set; }
		public IList<IVersionSection> VersionSection { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IQuestionnaireProfile QuestionnaireProfile { get; set; }
		
		#endregion
	}
}
