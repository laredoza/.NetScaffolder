
// <copyright file="VersionSectionDto.g.cs" company="MIT">
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
	public partial class VersionSectionDto : IVersionSection 
	{
		#region CTOR
		
		public VersionSectionDto()
		{
			this.Section = new List <ISection>();
			this.VersionSection1 = new List <IVersionSection>();
		}
		
		public VersionSectionDto(IVersionSection item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.VersionLocked = item.VersionLocked;
			this.ProfileVersionId = item.ProfileVersionId;
			this.SectionProfileId = item.SectionProfileId;
			this.ParentVersionSectionId = item.ParentVersionSectionId;
			this.SequenceId = item.SequenceId;
			this.Section = new List <ISection>();
			this.VersionSection1 = new List <IVersionSection>();

			if(deep)
			{
				if(item.Section != null)
				{
					foreach(var childItem in item.Section)
					{
						this.Section.Add(new SectionDto(childItem, deep));
					}
				}
				if(item.VersionSection1 != null)
				{
					foreach(var childItem in item.VersionSection1)
					{
						this.VersionSection1.Add(new VersionSectionDto(childItem, deep));
					}
				}
                if(item.SectionProfile != null)
                {
				    this.SectionProfile = new SectionProfileDto(item.SectionProfile, deep);
                }
                if(item.QuestionnaireProfileVersion != null)
                {
				    this.QuestionnaireProfileVersion = new QuestionnaireProfileVersionDto(item.QuestionnaireProfileVersion, deep);
                }
                if(item.SequenceProvider != null)
                {
				    this.SequenceProvider = new SequenceProviderDto(item.SequenceProvider, deep);
                }
                if(item.QuestionnaireSequence != null)
                {
				    this.QuestionnaireSequence = new QuestionnaireSequenceDto(item.QuestionnaireSequence, deep);
                }
                if(item.VersionSection2 != null)
                {
				    this.VersionSection2 = new VersionSectionDto(item.VersionSection2, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<bool> VersionLocked { get; set; }
		public Nullable<int> ProfileVersionId { get; set; }
		public Nullable<int> SectionProfileId { get; set; }
		public Nullable<int> ParentVersionSectionId { get; set; }
		public Nullable<int> SequenceId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<ISection> Section { get; set; }
		public IList<IVersionSection> VersionSection1 { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ISectionProfile SectionProfile { get; set; }
		public IQuestionnaireProfileVersion QuestionnaireProfileVersion { get; set; }
		public ISequenceProvider SequenceProvider { get; set; }
		public IQuestionnaireSequence QuestionnaireSequence { get; set; }
		public IVersionSection VersionSection2 { get; set; }
		
		#endregion
	}
}
