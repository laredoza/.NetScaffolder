
// <copyright file="ConditionSetContainerDto.g.cs" company="MIT">
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
	public partial class ConditionSetContainerDto : IConditionSetContainer 
	{
		#region CTOR
		
		public ConditionSetContainerDto()
		{
			this.AnswerCondition = new List <IAnswerCondition>();
			this.VersionCondition = new List <IVersionCondition>();
		}
		
		public ConditionSetContainerDto(IConditionSetContainer item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.ConditionSetXml = item.ConditionSetXml;
			this.AnswerCondition = new List <IAnswerCondition>();
			this.VersionCondition = new List <IVersionCondition>();

			if(deep)
			{
				if(item.AnswerCondition != null)
				{
					foreach(var childItem in item.AnswerCondition)
					{
						this.AnswerCondition.Add(new AnswerConditionDto(childItem, deep));
					}
				}
				if(item.VersionCondition != null)
				{
					foreach(var childItem in item.VersionCondition)
					{
						this.VersionCondition.Add(new VersionConditionDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string ConditionSetXml { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IAnswerCondition> AnswerCondition { get; set; }
		public IList<IVersionCondition> VersionCondition { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
