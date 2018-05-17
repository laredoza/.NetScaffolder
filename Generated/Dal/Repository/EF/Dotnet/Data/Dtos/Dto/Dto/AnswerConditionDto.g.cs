﻿
// <copyright file="AnswerConditionDto.g.cs" company="MIT">
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
	public partial class AnswerConditionDto : IAnswerCondition 
	{
		#region CTOR
		
		public AnswerConditionDto()
		{
			this.ConditionOutcome = new List <IConditionOutcome>();
		}
		
		public AnswerConditionDto(IAnswerCondition item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerProfileId = item.AnswerProfileId;
			this.ConditionSetContainerId = item.ConditionSetContainerId;
			this.ConditionOutcome = new List <IConditionOutcome>();

			if(deep)
			{
				if(item.ConditionOutcome != null)
				{
					foreach(var childItem in item.ConditionOutcome)
					{
						this.ConditionOutcome.Add(new ConditionOutcomeDto(childItem, deep));
					}
				}
                if(item.ConditionSetContainer != null)
                {
				    this.ConditionSetContainer = new ConditionSetContainerDto(item.ConditionSetContainer, deep);
                }
                if(item.AnswerProfile != null)
                {
				    this.AnswerProfile = new AnswerProfileDto(item.AnswerProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> AnswerProfileId { get; set; }
		public Nullable<int> ConditionSetContainerId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IConditionOutcome> ConditionOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IConditionSetContainer ConditionSetContainer { get; set; }
		public IAnswerProfile AnswerProfile { get; set; }
		
		#endregion
	}
}
