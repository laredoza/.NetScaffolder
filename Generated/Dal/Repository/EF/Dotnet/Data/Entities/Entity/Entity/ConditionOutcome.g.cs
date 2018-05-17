
// <copyright file="ConditionOutcome.g.cs" company="MIT">
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
	public partial class ConditionOutcome : IConditionOutcome 
	{
		#region CTOR
		
		public ConditionOutcome()
		{
		}
		
		public ConditionOutcome(IConditionOutcome item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerConditionId = item.AnswerConditionId;
			this.ProviderId = item.ProviderId;

			if(deep)
			{
				if(item.AnswerCondition != null)
                {
                    this.AnswerCondition = new AnswerCondition(item.AnswerCondition, deep);
                }
				if(item.Provider != null)
                {
                    this.Provider = new Provider(item.Provider, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> AnswerConditionId { get; set; }
		public Nullable<int> ProviderId { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual AnswerCondition AnswerCondition { get; set; }

		IAnswerCondition IConditionOutcome.AnswerCondition 
		{ 
			get
			{
				return this.AnswerCondition;
			}
			set
			{
				this.AnswerCondition = (AnswerCondition)value;
			}
		}

        public virtual Provider Provider { get; set; }

		IProvider IConditionOutcome.Provider 
		{ 
			get
			{
				return this.Provider;
			}
			set
			{
				this.Provider = (Provider)value;
			}
		}
		
		#endregion
	}
}
