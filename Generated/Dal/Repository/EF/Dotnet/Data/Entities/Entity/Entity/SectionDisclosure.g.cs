
// <copyright file="SectionDisclosure.g.cs" company="MIT">
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
	public partial class SectionDisclosure : ISectionDisclosure 
	{
		#region CTOR
		
		public SectionDisclosure()
		{
		}
		
		public SectionDisclosure(ISectionDisclosure item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.SectionId = item.SectionId;
			this.SetupTableDataId = item.SetupTableDataId;
			this.AnswerOutcomeResultId = item.AnswerOutcomeResultId;
			this.ConditionOutcomeResultId = item.ConditionOutcomeResultId;
			this.VersionOutcomeResultId = item.VersionOutcomeResultId;
			this.OutcomeGroupAttributeId = item.OutcomeGroupAttributeId;

			if(deep)
			{
				if(item.AnswerOutcomeResult != null)
                {
                    this.AnswerOutcomeResult = new AnswerOutcomeResult(item.AnswerOutcomeResult, deep);
                }
				if(item.ConditionOutcomeResult != null)
                {
                    this.ConditionOutcomeResult = new ConditionOutcomeResult(item.ConditionOutcomeResult, deep);
                }
				if(item.Section != null)
                {
                    this.Section = new Section(item.Section, deep);
                }
				if(item.SetupTableData != null)
                {
                    this.SetupTableData = new SetupTableData(item.SetupTableData, deep);
                }
				if(item.VersionOutcomeResult != null)
                {
                    this.VersionOutcomeResult = new VersionOutcomeResult(item.VersionOutcomeResult, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public int SectionId { get; set; }
		public int SetupTableDataId { get; set; }
		public Nullable<int> AnswerOutcomeResultId { get; set; }
		public Nullable<int> ConditionOutcomeResultId { get; set; }
		public Nullable<int> VersionOutcomeResultId { get; set; }
		public Nullable<int> OutcomeGroupAttributeId { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual AnswerOutcomeResult AnswerOutcomeResult { get; set; }

		IAnswerOutcomeResult ISectionDisclosure.AnswerOutcomeResult 
		{ 
			get
			{
				return this.AnswerOutcomeResult;
			}
			set
			{
				this.AnswerOutcomeResult = (AnswerOutcomeResult)value;
			}
		}

        public virtual ConditionOutcomeResult ConditionOutcomeResult { get; set; }

		IConditionOutcomeResult ISectionDisclosure.ConditionOutcomeResult 
		{ 
			get
			{
				return this.ConditionOutcomeResult;
			}
			set
			{
				this.ConditionOutcomeResult = (ConditionOutcomeResult)value;
			}
		}

        public virtual Section Section { get; set; }

		ISection ISectionDisclosure.Section 
		{ 
			get
			{
				return this.Section;
			}
			set
			{
				this.Section = (Section)value;
			}
		}

        public virtual SetupTableData SetupTableData { get; set; }

		ISetupTableData ISectionDisclosure.SetupTableData 
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

        public virtual VersionOutcomeResult VersionOutcomeResult { get; set; }

		IVersionOutcomeResult ISectionDisclosure.VersionOutcomeResult 
		{ 
			get
			{
				return this.VersionOutcomeResult;
			}
			set
			{
				this.VersionOutcomeResult = (VersionOutcomeResult)value;
			}
		}
		
		#endregion
	}
}
