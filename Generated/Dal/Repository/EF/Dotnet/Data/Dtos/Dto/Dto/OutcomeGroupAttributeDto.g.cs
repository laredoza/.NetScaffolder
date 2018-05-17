
// <copyright file="OutcomeGroupAttributeDto.g.cs" company="MIT">
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
	public partial class OutcomeGroupAttributeDto : IOutcomeGroupAttribute 
	{
		#region CTOR
		
		public OutcomeGroupAttributeDto()
		{
		}
		
		public OutcomeGroupAttributeDto(IOutcomeGroupAttribute item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.QuestionnaireId = item.QuestionnaireId;
			this.AnswerOutcomeResultId = item.AnswerOutcomeResultId;
			this.ApplicantAttributeProfileId = item.ApplicantAttributeProfileId;
			this.SetupTableDataId = item.SetupTableDataId;

			if(deep)
			{
                if(item.AnswerOutcomeResult != null)
                {
				    this.AnswerOutcomeResult = new AnswerOutcomeResultDto(item.AnswerOutcomeResult, deep);
                }
                if(item.ApplicantAttributeProfile != null)
                {
				    this.ApplicantAttributeProfile = new ApplicantAttributeProfileDto(item.ApplicantAttributeProfile, deep);
                }
                if(item.Questionnaire != null)
                {
				    this.Questionnaire = new QuestionnaireDto(item.Questionnaire, deep);
                }
                if(item.SetupTableData != null)
                {
				    this.SetupTableData = new SetupTableDataDto(item.SetupTableData, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public int QuestionnaireId { get; set; }
		public int AnswerOutcomeResultId { get; set; }
		public int ApplicantAttributeProfileId { get; set; }
		public int SetupTableDataId { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IAnswerOutcomeResult AnswerOutcomeResult { get; set; }
		public IApplicantAttributeProfile ApplicantAttributeProfile { get; set; }
		public IQuestionnaire Questionnaire { get; set; }
		public ISetupTableData SetupTableData { get; set; }
		
		#endregion
	}
}
