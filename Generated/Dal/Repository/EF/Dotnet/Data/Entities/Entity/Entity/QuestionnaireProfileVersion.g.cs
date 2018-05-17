
// <copyright file="QuestionnaireProfileVersion.g.cs" company="MIT">
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
	public partial class QuestionnaireProfileVersion : IQuestionnaireProfileVersion 
	{
		#region CTOR
		
		public QuestionnaireProfileVersion()
		{
			this.Cedant = new List <Cedant>();
			this.QuestionnaireSequence = new List <QuestionnaireSequence>();
			this.VersionSection = new List <VersionSection>();
		}
		
		public QuestionnaireProfileVersion(IQuestionnaireProfileVersion item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Version = item.Version;
			this.GroupApplicantPropertyAnswers = item.GroupApplicantPropertyAnswers;
			this.VersionLocked = item.VersionLocked;
			this.QuestionnaireProfileId = item.QuestionnaireProfileId;
			this.Cedant = new List <Cedant>();
			this.QuestionnaireSequence = new List <QuestionnaireSequence>();
			this.VersionSection = new List <VersionSection>();

			if(deep)
			{
				if(item.Cedant != null)
				{
					foreach(var childItem in item.Cedant)
					{
						this.Cedant.Add(new Cedant(childItem, deep));
					}
				}
				if(item.QuestionnaireSequence != null)
				{
					foreach(var childItem in item.QuestionnaireSequence)
					{
						this.QuestionnaireSequence.Add(new QuestionnaireSequence(childItem, deep));
					}
				}
				if(item.VersionSection != null)
				{
					foreach(var childItem in item.VersionSection)
					{
						this.VersionSection.Add(new VersionSection(childItem, deep));
					}
				}
				if(item.QuestionnaireProfile != null)
                {
                    this.QuestionnaireProfile = new QuestionnaireProfile(item.QuestionnaireProfile, deep);
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
        
        public virtual IList<Cedant> Cedant { get; set; }

        IList<ICedant> IQuestionnaireProfileVersion.Cedant 
		{ 
			get
			{
				return (IList<ICedant>)this.Cedant;
			}
			set
			{
				this.Cedant = (IList<Cedant>)value;
			}			
		}
        
        public virtual IList<QuestionnaireSequence> QuestionnaireSequence { get; set; }

        IList<IQuestionnaireSequence> IQuestionnaireProfileVersion.QuestionnaireSequence 
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
        
        public virtual IList<VersionSection> VersionSection { get; set; }

        IList<IVersionSection> IQuestionnaireProfileVersion.VersionSection 
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

        public virtual QuestionnaireProfile QuestionnaireProfile { get; set; }

		IQuestionnaireProfile IQuestionnaireProfileVersion.QuestionnaireProfile 
		{ 
			get
			{
				return this.QuestionnaireProfile;
			}
			set
			{
				this.QuestionnaireProfile = (QuestionnaireProfile)value;
			}
		}
		
		#endregion
	}
}
