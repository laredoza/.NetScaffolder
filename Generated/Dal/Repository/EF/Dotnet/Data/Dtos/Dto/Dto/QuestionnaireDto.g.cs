
// <copyright file="QuestionnaireDto.g.cs" company="MIT">
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
	public partial class QuestionnaireDto : IQuestionnaire 
	{
		#region CTOR
		
		public QuestionnaireDto()
		{
			this.AnswerLog = new List <IAnswerLog>();
			this.ApplicantAttribute = new List <IApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
			this.Section = new List <ISection>();
		}
		
		public QuestionnaireDto(IQuestionnaire item, bool deep = false)
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
			this.AnswerLog = new List <IAnswerLog>();
			this.ApplicantAttribute = new List <IApplicantAttribute>();
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.RunOnceOutcomeGroup = new List <IRunOnceOutcomeGroup>();
			this.Section = new List <ISection>();

			if(deep)
			{
				if(item.AnswerLog != null)
				{
					foreach(var childItem in item.AnswerLog)
					{
						this.AnswerLog.Add(new AnswerLogDto(childItem, deep));
					}
				}
				if(item.ApplicantAttribute != null)
				{
					foreach(var childItem in item.ApplicantAttribute)
					{
						this.ApplicantAttribute.Add(new ApplicantAttributeDto(childItem, deep));
					}
				}
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttributeDto(childItem, deep));
					}
				}
				if(item.RunOnceOutcomeGroup != null)
				{
					foreach(var childItem in item.RunOnceOutcomeGroup)
					{
						this.RunOnceOutcomeGroup.Add(new RunOnceOutcomeGroupDto(childItem, deep));
					}
				}
				if(item.Section != null)
				{
					foreach(var childItem in item.Section)
					{
						this.Section.Add(new SectionDto(childItem, deep));
					}
				}
                if(item.Policy != null)
                {
				    this.Policy = new PolicyDto(item.Policy, deep);
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
		
		public IList<IAnswerLog> AnswerLog { get; set; }
		public IList<IApplicantAttribute> ApplicantAttribute { get; set; }
		public IList<IOutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }
		public IList<IRunOnceOutcomeGroup> RunOnceOutcomeGroup { get; set; }
		public IList<ISection> Section { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IPolicy Policy { get; set; }
		
		#endregion
	}
}
