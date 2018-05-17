
// <copyright file="SectionProfile.g.cs" company="MIT">
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
	public partial class SectionProfile : ISectionProfile 
	{
		#region CTOR
		
		public SectionProfile()
		{
			this.Section = new List <Section>();
			this.SectionQuestion = new List <SectionQuestion>();
			this.VersionSection = new List <VersionSection>();
		}
		
		public SectionProfile(ISectionProfile item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Title = item.Title;
			this.isVisibleAtStart = item.isVisibleAtStart;
			this.isQuestionsGrouped = item.isQuestionsGrouped;
			this.CopiedFromSectionProfileTitle = item.CopiedFromSectionProfileTitle;
			this.ExternalReferenceId = item.ExternalReferenceId;
			this.PromptText = item.PromptText;
			this.isPopupWindow = item.isPopupWindow;
			this.Section = new List <Section>();
			this.SectionQuestion = new List <SectionQuestion>();
			this.VersionSection = new List <VersionSection>();

			if(deep)
			{
				if(item.Section != null)
				{
					foreach(var childItem in item.Section)
					{
						this.Section.Add(new Section(childItem, deep));
					}
				}
				if(item.SectionQuestion != null)
				{
					foreach(var childItem in item.SectionQuestion)
					{
						this.SectionQuestion.Add(new SectionQuestion(childItem, deep));
					}
				}
				if(item.VersionSection != null)
				{
					foreach(var childItem in item.VersionSection)
					{
						this.VersionSection.Add(new VersionSection(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Title { get; set; }
		public Nullable<bool> isVisibleAtStart { get; set; }
		public Nullable<bool> isQuestionsGrouped { get; set; }
		public string CopiedFromSectionProfileTitle { get; set; }
		public string ExternalReferenceId { get; set; }
		public string PromptText { get; set; }
		public Nullable<bool> isPopupWindow { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<Section> Section { get; set; }

        IList<ISection> ISectionProfile.Section 
		{ 
			get
			{
				return (IList<ISection>)this.Section;
			}
			set
			{
				this.Section = (IList<Section>)value;
			}			
		}
        
        public virtual IList<SectionQuestion> SectionQuestion { get; set; }

        IList<ISectionQuestion> ISectionProfile.SectionQuestion 
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
        
        public virtual IList<VersionSection> VersionSection { get; set; }

        IList<IVersionSection> ISectionProfile.VersionSection 
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
		
		#endregion
	}
}
