
// <copyright file="AnswerOutcomeResultDto.g.cs" company="MIT">
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
	public partial class AnswerOutcomeResultDto : IAnswerOutcomeResult 
	{
		#region CTOR
		
		public AnswerOutcomeResultDto()
		{
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.SectionDisclosure = new List <ISectionDisclosure>();
		}
		
		public AnswerOutcomeResultDto(IAnswerOutcomeResult item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerId = item.AnswerId;
			this.OutcomeResultId = item.OutcomeResultId;
			this.OutcomeGroupAttribute = new List <IOutcomeGroupAttribute>();
			this.SectionDisclosure = new List <ISectionDisclosure>();

			if(deep)
			{
				if(item.OutcomeGroupAttribute != null)
				{
					foreach(var childItem in item.OutcomeGroupAttribute)
					{
						this.OutcomeGroupAttribute.Add(new OutcomeGroupAttributeDto(childItem, deep));
					}
				}
				if(item.SectionDisclosure != null)
				{
					foreach(var childItem in item.SectionDisclosure)
					{
						this.SectionDisclosure.Add(new SectionDisclosureDto(childItem, deep));
					}
				}
                if(item.Answer != null)
                {
				    this.Answer = new AnswerDto(item.Answer, deep);
                }
                if(item.OutcomeResult != null)
                {
				    this.OutcomeResult = new OutcomeResultDto(item.OutcomeResult, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> AnswerId { get; set; }
		public Nullable<int> OutcomeResultId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IOutcomeGroupAttribute> OutcomeGroupAttribute { get; set; }
		public IList<ISectionDisclosure> SectionDisclosure { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IAnswer Answer { get; set; }
		public IOutcomeResult OutcomeResult { get; set; }
		
		#endregion
	}
}
