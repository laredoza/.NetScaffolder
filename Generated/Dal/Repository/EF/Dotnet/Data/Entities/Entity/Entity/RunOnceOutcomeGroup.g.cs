
// <copyright file="RunOnceOutcomeGroup.g.cs" company="MIT">
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
	public partial class RunOnceOutcomeGroup : IRunOnceOutcomeGroup 
	{
		#region CTOR
		
		public RunOnceOutcomeGroup()
		{
		}
		
		public RunOnceOutcomeGroup(IRunOnceOutcomeGroup item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.QuestionnaireId = item.QuestionnaireId;
			this.SetupTableDataId = item.SetupTableDataId;
			this.OutcomeGroupId = item.OutcomeGroupId;
			this.AnswerId = item.AnswerId;
			this.RunOnceActiveFlag = item.RunOnceActiveFlag;

			if(deep)
			{
				if(item.Answer != null)
                {
                    this.Answer = new Answer(item.Answer, deep);
                }
				if(item.OutcomeGroup != null)
                {
                    this.OutcomeGroup = new OutcomeGroup(item.OutcomeGroup, deep);
                }
				if(item.Questionnaire != null)
                {
                    this.Questionnaire = new Questionnaire(item.Questionnaire, deep);
                }
				if(item.SetupTableData != null)
                {
                    this.SetupTableData = new SetupTableData(item.SetupTableData, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> QuestionnaireId { get; set; }
		public Nullable<int> SetupTableDataId { get; set; }
		public Nullable<int> OutcomeGroupId { get; set; }
		public Nullable<int> AnswerId { get; set; }
		public Nullable<bool> RunOnceActiveFlag { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual Answer Answer { get; set; }

		IAnswer IRunOnceOutcomeGroup.Answer 
		{ 
			get
			{
				return this.Answer;
			}
			set
			{
				this.Answer = (Answer)value;
			}
		}

        public virtual OutcomeGroup OutcomeGroup { get; set; }

		IOutcomeGroup IRunOnceOutcomeGroup.OutcomeGroup 
		{ 
			get
			{
				return this.OutcomeGroup;
			}
			set
			{
				this.OutcomeGroup = (OutcomeGroup)value;
			}
		}

        public virtual Questionnaire Questionnaire { get; set; }

		IQuestionnaire IRunOnceOutcomeGroup.Questionnaire 
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

        public virtual SetupTableData SetupTableData { get; set; }

		ISetupTableData IRunOnceOutcomeGroup.SetupTableData 
		{ 
			get
			{
				return this.SetupTableData;
			}
			set
			{
				this.SetupTableData = (SetupTableData)value;
			}
		}
		
		#endregion
	}
}
