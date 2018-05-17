
// <copyright file="SectionDto.g.cs" company="MIT">
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
	public partial class SectionDto : ISection 
	{
		#region CTOR
		
		public SectionDto()
		{
			this.Question = new List <IQuestion>();
			this.Section1 = new List <ISection>();
			this.SectionDisclosure = new List <ISectionDisclosure>();
		}
		
		public SectionDto(ISection item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.isVisible = item.isVisible;
			this.QuestionnaireId = item.QuestionnaireId;
			this.SectionProfileId = item.SectionProfileId;
			this.SectionVersionId = item.SectionVersionId;
			this.ParentSectionId = item.ParentSectionId;
			this.Question = new List <IQuestion>();
			this.Section1 = new List <ISection>();
			this.SectionDisclosure = new List <ISectionDisclosure>();

			if(deep)
			{
				if(item.Question != null)
				{
					foreach(var childItem in item.Question)
					{
						this.Question.Add(new QuestionDto(childItem, deep));
					}
				}
				if(item.Section1 != null)
				{
					foreach(var childItem in item.Section1)
					{
						this.Section1.Add(new SectionDto(childItem, deep));
					}
				}
				if(item.SectionDisclosure != null)
				{
					foreach(var childItem in item.SectionDisclosure)
					{
						this.SectionDisclosure.Add(new SectionDisclosureDto(childItem, deep));
					}
				}
                if(item.SectionProfile != null)
                {
				    this.SectionProfile = new SectionProfileDto(item.SectionProfile, deep);
                }
                if(item.Section2 != null)
                {
				    this.Section2 = new SectionDto(item.Section2, deep);
                }
                if(item.Questionnaire != null)
                {
				    this.Questionnaire = new QuestionnaireDto(item.Questionnaire, deep);
                }
                if(item.VersionSection != null)
                {
				    this.VersionSection = new VersionSectionDto(item.VersionSection, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<bool> isVisible { get; set; }
		public Nullable<int> QuestionnaireId { get; set; }
		public Nullable<int> SectionProfileId { get; set; }
		public Nullable<int> SectionVersionId { get; set; }
		public Nullable<int> ParentSectionId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IQuestion> Question { get; set; }
		public IList<ISection> Section1 { get; set; }
		public IList<ISectionDisclosure> SectionDisclosure { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ISectionProfile SectionProfile { get; set; }
		public ISection Section2 { get; set; }
		public IQuestionnaire Questionnaire { get; set; }
		public IVersionSection VersionSection { get; set; }
		
		#endregion
	}
}
