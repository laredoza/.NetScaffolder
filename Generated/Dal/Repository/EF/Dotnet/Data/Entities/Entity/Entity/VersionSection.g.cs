
// <copyright file="VersionSection.g.cs" company="MIT">
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
	public partial class VersionSection : IVersionSection 
	{
		#region CTOR
		
		public VersionSection()
		{
			this.Section = new List <Section>();
			this.VersionSection1 = new List <VersionSection>();
		}
		
		public VersionSection(IVersionSection item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.VersionLocked = item.VersionLocked;
			this.ProfileVersionId = item.ProfileVersionId;
			this.SectionProfileId = item.SectionProfileId;
			this.ParentVersionSectionId = item.ParentVersionSectionId;
			this.SequenceId = item.SequenceId;
			this.Section = new List <Section>();
			this.VersionSection1 = new List <VersionSection>();

			if(deep)
			{
				if(item.Section != null)
				{
					foreach(var childItem in item.Section)
					{
						this.Section.Add(new Section(childItem, deep));
					}
				}
				if(item.VersionSection1 != null)
				{
					foreach(var childItem in item.VersionSection1)
					{
						this.VersionSection1.Add(new VersionSection(childItem, deep));
					}
				}
				if(item.SectionProfile != null)
                {
                    this.SectionProfile = new SectionProfile(item.SectionProfile, deep);
                }
				if(item.QuestionnaireProfileVersion != null)
                {
                    this.QuestionnaireProfileVersion = new QuestionnaireProfileVersion(item.QuestionnaireProfileVersion, deep);
                }
				if(item.SequenceProvider != null)
                {
                    this.SequenceProvider = new SequenceProvider(item.SequenceProvider, deep);
                }
				if(item.QuestionnaireSequence != null)
                {
                    this.QuestionnaireSequence = new QuestionnaireSequence(item.QuestionnaireSequence, deep);
                }
				if(item.VersionSection2 != null)
                {
                    this.VersionSection2 = new VersionSection(item.VersionSection2, deep);
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
        
        public virtual IList<Section> Section { get; set; }

        IList<ISection> IVersionSection.Section 
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
        
        public virtual IList<VersionSection> VersionSection1 { get; set; }

        IList<IVersionSection> IVersionSection.VersionSection1 
		{ 
			get
			{
				return (IList<IVersionSection>)this.VersionSection1;
			}
			set
			{
				this.VersionSection1 = (IList<VersionSection>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual SectionProfile SectionProfile { get; set; }

		ISectionProfile IVersionSection.SectionProfile 
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

        public virtual QuestionnaireProfileVersion QuestionnaireProfileVersion { get; set; }

		IQuestionnaireProfileVersion IVersionSection.QuestionnaireProfileVersion 
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

		ISequenceProvider IVersionSection.SequenceProvider 
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

		IQuestionnaireSequence IVersionSection.QuestionnaireSequence 
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

        public virtual VersionSection VersionSection2 { get; set; }

		IVersionSection IVersionSection.VersionSection2 
		{ 
			get
			{
				return this.VersionSection2;
			}
			set
			{
				this.VersionSection2 = (VersionSection)value;
			}
		}
		
		#endregion
	}
}
