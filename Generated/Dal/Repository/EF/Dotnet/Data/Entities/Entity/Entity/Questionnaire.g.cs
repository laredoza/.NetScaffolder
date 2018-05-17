
// <copyright file="Questionnaire.g.cs" company="MIT">
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
	public partial class Questionnaire : IQuestionnaire 
	{
		#region CTOR
		
		public Questionnaire()
		{
			this.AnswerLog = new List <AnswerLog>();
			this.ApplicantAttribute = new List <ApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <OutcomeGroupAttribute>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
			this.Section = new List <Section>();
		}
		
		public Questionnaire(IQuestionnaire item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Status = item.Status;
			this.QuestionnaireProfileVersionId = item.QuestionnaireProfileVersionId;
			this.RemainingChanges = item.RemainingChanges;
			this.PolicyId = item.PolicyId;
			this.Testing = item.Testing;
			this.AnswerLog = new List <AnswerLog>();
			this.ApplicantAttribute = new List <ApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <OutcomeGroupAttribute>();
			this.RunOnceOutcomeGroup = new List <RunOnceOutcomeGroup>();
			this.Section = new List <Section>();

			if(deep)
			{
				if(item.AnswerLog != null)
				{
					foreach(var childItem in item.AnswerLog)
					{
						this.AnswerLog.Add(new AnswerLog(childItem, deep));
					}
				}
				if(item.ApplicantAttribute != null)
				{
					foreach(var childItem in item.ApplicantAttribute)
					{
						this.ApplicantAttribute.Add(new ApplicantAttribute(childItem, deep));
					}
				}
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttribute(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroup(childItem, deep));
					}
				}
				if(item.Section != null)
				{
					foreach(var childItem in item.Section)
					{
						this.Section.Add(new Section(childItem, deep));
					}
				}
				if(item.Policy != null)
                {
                    this.Policy = new Policy(item.Policy, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> Status { get; set; }
		public Nullable<int> QuestionnaireProfileVersionId { get; set; }
		public Nullable<int> RemainingChanges { get; set; }
		public Nullable<int> PolicyId { get; set; }
		public bool Testing { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<AnswerLog> AnswerLog { get; set; }

        IList<IAnswerLog> IQuestionnaire.AnswerLog 
		{ 
			get
			{
				return (IList<IAnswerLog>)this.AnswerLog;
			}
			set
			{
				this.AnswerLog = (IList<AnswerLog>)value;
			}			
		}
        
        public virtual IList<ApplicantAttribute> ApplicantAttribute { get; set; }

        IList<IApplicantAttribute> IQuestionnaire.ApplicantAttribute 
		{ 
			get
			{
				return (IList<IApplicantAttribute>)this.ApplicantAttribute;
			}
			set
			{
				this.ApplicantAttribute = (IList<ApplicantAttribute>)value;
			}			
		}
        
        public virtual IList<OutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }

        IList<IOutcomeGroupAttribute> IQuestionnaire.OutcomeGroupAttribute 
		{ 
			get
			{
				return (IList<IOutcomeGroupAttribute>)this.OutcomeGroupAttribute;
			}
			set
			{
				this.OutcomeGroupAttribute = (IList<OutcomeGroupAttribute>)value;
			}			
		}
        
        public virtual IList<RunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }

        IList<IRunOnceOutcomeGroup> IQuestionnaire.RunOnceOutcomeGroup 
		{ 
			get
			{
				return (IList<IRunOnceOutcomeGroup>)this.RunOnceOutcomeGroup;
			}
			set
			{
				this.RunOnceOutcomeGroup = (IList<RunOnceOutcomeGroup>)value;
			}			
		}
        
        public virtual IList<Section> Section { get; set; }

        IList<ISection> IQuestionnaire.Section 
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
		
		#endregion
		
		#region Parent Relationships

        public virtual Policy Policy { get; set; }

		IPolicy IQuestionnaire.Policy 
		{ 
			get
			{
				return this.Policy;
			}
			set
			{
				this.Policy = (Policy)value;
			}
		}
		
		#endregion
	}
}
