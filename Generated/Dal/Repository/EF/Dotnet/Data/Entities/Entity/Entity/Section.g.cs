
// <copyright file="Section.g.cs" company="MIT">
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
	public partial class Section : ISection 
	{
		#region CTOR
		
		public Section()
		{
			this.Question = new List <Question>();
			this.Section1 = new List <Section>();
			this.SectionDisclosure = new List <SectionDisclosure>();
		}
		
		public Section(ISection item, bool deep = false)
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
			this.Question = new List <Question>();
			this.Section1 = new List <Section>();
			this.SectionDisclosure = new List <SectionDisclosure>();

			if(deep)
			{
				if(item.Question != null)
				{
					foreach(var childItem in item.Question)
					{
						this.Question.Add(new Question(childItem, deep));
					}
				}
				if(item.Section1 != null)
				{
					foreach(var childItem in item.Section1)
					{
						this.Section1.Add(new Section(childItem, deep));
					}
				}
				if(item.SectionDisclosure != null)
				{
					foreach(var childItem in item.SectionDisclosure)
					{
						this.SectionDisclosure.Add(new SectionDisclosure(childItem, deep));
					}
				}
				if(item.SectionProfile != null)
                {
                    this.SectionProfile = new SectionProfile(item.SectionProfile, deep);
                }
				if(item.Section2 != null)
                {
                    this.Section2 = new Section(item.Section2, deep);
                }
				if(item.Questionnaire != null)
                {
                    this.Questionnaire = new Questionnaire(item.Questionnaire, deep);
                }
				if(item.VersionSection != null)
                {
                    this.VersionSection = new VersionSection(item.VersionSection, deep);
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
        
        public virtual IList<Question> Question { get; set; }

        IList<IQuestion> ISection.Question 
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
        
        public virtual IList<Section> Section1 { get; set; }

        IList<ISection> ISection.Section1 
		{ 
			get
			{
				return (IList<ISection>)this.Section1;
			}
			set
			{
				this.Section1 = (IList<Section>)value;
			}			
		}
        
        public virtual IList<SectionDisclosure> SectionDisclosure { get; set; }

        IList<ISectionDisclosure> ISection.SectionDisclosure 
		{ 
			get
			{
				return (IList<ISectionDisclosure>)this.SectionDisclosure;
			}
			set
			{
				this.SectionDisclosure = (IList<SectionDisclosure>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual SectionProfile SectionProfile { get; set; }

		ISectionProfile ISection.SectionProfile 
		{ 
			get
			{
				return this.SectionProfile;
			}
			set
			{
				this.SectionProfile = (SectionProfile)value;
			}
		}

        public virtual Section Section2 { get; set; }

		ISection ISection.Section2 
		{ 
			get
			{
				return this.Section2;
			}
			set
			{
				this.Section2 = (Section)value;
			}
		}

        public virtual Questionnaire Questionnaire { get; set; }

		IQuestionnaire ISection.Questionnaire 
		{ 
			get
			{
				return this.Questionnaire;
			}
			set
			{
				this.Questionnaire = (Questionnaire)value;
			}
		}

        public virtual VersionSection VersionSection { get; set; }

		IVersionSection ISection.VersionSection 
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
	}
}
