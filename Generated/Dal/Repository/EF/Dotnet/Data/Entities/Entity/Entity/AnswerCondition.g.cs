﻿
// <copyright file="AnswerCondition.g.cs" company="MIT">
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
	public partial class AnswerCondition : IAnswerCondition 
	{
		#region CTOR
		
		public AnswerCondition()
		{
			this.ConditionOutcome = new List <ConditionOutcome>();
		}
		
		public AnswerCondition(IAnswerCondition item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerProfileId = item.AnswerProfileId;
			this.ConditionSetContainerId = item.ConditionSetContainerId;
			this.ConditionOutcome = new List <ConditionOutcome>();

			if(deep)
			{
				if(item.ConditionOutcome != null)
				{
					foreach(var childItem in item.ConditionOutcome)
					{
						this.ConditionOutcome.Add(new ConditionOutcome(childItem, deep));
					}
				}
				if(item.ConditionSetContainer != null)
                {
                    this.ConditionSetContainer = new ConditionSetContainer(item.ConditionSetContainer, deep);
                }
				if(item.AnswerProfile != null)
                {
                    this.AnswerProfile = new AnswerProfile(item.AnswerProfile, deep);
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
        
        public virtual IList<ConditionOutcome> ConditionOutcome { get; set; }

        IList<IConditionOutcome> IAnswerCondition.ConditionOutcome 
		{ 
			get
			{
				return (IList<IConditionOutcome>)this.ConditionOutcome;
			}
			set
			{
				this.ConditionOutcome = (IList<ConditionOutcome>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual ConditionSetContainer ConditionSetContainer { get; set; }

		IConditionSetContainer IAnswerCondition.ConditionSetContainer 
		{ 
			get
			{
				return this.ConditionSetContainer;
			}
			set
			{
				this.ConditionSetContainer = (ConditionSetContainer)value;
			}
		}

        public virtual AnswerProfile AnswerProfile { get; set; }

		IAnswerProfile IAnswerCondition.AnswerProfile 
		{ 
			get
			{
				return this.AnswerProfile;
			}
			set
			{
				this.AnswerProfile = (AnswerProfile)value;
			}
		}
		
		#endregion
	}
}