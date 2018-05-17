
// <copyright file="VersionOutcomeResult.g.cs" company="MIT">
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
	public partial class VersionOutcomeResult : IVersionOutcomeResult 
	{
		#region CTOR
		
		public VersionOutcomeResult()
		{
			this.SectionDisclosure = new List <SectionDisclosure>();
		}
		
		public VersionOutcomeResult(IVersionOutcomeResult item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.ConditionResultId = item.ConditionResultId;
			this.OutcomeResultId = item.OutcomeResultId;
			this.SectionDisclosure = new List <SectionDisclosure>();

			if(deep)
			{
				if(item.SectionDisclosure != null)
				{
					foreach(var childItem in item.SectionDisclosure)
					{
						this.SectionDisclosure.Add(new SectionDisclosure(childItem, deep));
					}
				}
				if(item.VersionConditionResult != null)
                {
                    this.VersionConditionResult = new VersionConditionResult(item.VersionConditionResult, deep);
                }
				if(item.OutcomeResult != null)
                {
                    this.OutcomeResult = new OutcomeResult(item.OutcomeResult, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> ConditionResultId { get; set; }
		public Nullable<int> OutcomeResultId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<SectionDisclosure> SectionDisclosure { get; set; }

        IList<ISectionDisclosure> IVersionOutcomeResult.SectionDisclosure 
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

        public virtual VersionConditionResult VersionConditionResult { get; set; }

		IVersionConditionResult IVersionOutcomeResult.VersionConditionResult 
		{ 
			get
			{
				return this.VersionConditionResult;
			}
			set
			{
				this.VersionConditionResult = (VersionConditionResult)value;
			}
		}

        public virtual OutcomeResult OutcomeResult { get; set; }

		IOutcomeResult IVersionOutcomeResult.OutcomeResult 
		{ 
			get
			{
				return this.OutcomeResult;
			}
			set
			{
				this.OutcomeResult = (OutcomeResult)value;
			}
		}
		
		#endregion
	}
}
