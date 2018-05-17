
// <copyright file="OutcomeResult.g.cs" company="MIT">
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
	public partial class OutcomeResult : IOutcomeResult 
	{
		#region CTOR
		
		public OutcomeResult()
		{
			this.AnswerOutcomeResult = new List <AnswerOutcomeResult>();
			this.ConditionOutcomeResult = new List <ConditionOutcomeResult>();
			this.VersionOutcomeResult = new List <VersionOutcomeResult>();
		}
		
		public OutcomeResult(IOutcomeResult item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.HadEffect = item.HadEffect;
			this.EffectPercentageValue = item.EffectPercentageValue;
			this.EffectDescription = item.EffectDescription;
			this.OutcomeId = item.OutcomeId;
			this.PremiumId = item.PremiumId;
			this.PolicyId = item.PolicyId;
			this.UserId = item.UserId;
			this.TypeOption = item.TypeOption;
			this.EffectUnitValue = item.EffectUnitValue;
			this.AnswerOutcomeResult = new List <AnswerOutcomeResult>();
			this.ConditionOutcomeResult = new List <ConditionOutcomeResult>();
			this.VersionOutcomeResult = new List <VersionOutcomeResult>();

			if(deep)
			{
				if(item.AnswerOutcomeResult != null)
				{
					foreach(var childItem in item.AnswerOutcomeResult)
					{
						this.AnswerOutcomeResult.Add(new AnswerOutcomeResult(childItem, deep));
					}
				}
				if(item.ConditionOutcomeResult != null)
				{
					foreach(var childItem in item.ConditionOutcomeResult)
					{
						this.ConditionOutcomeResult.Add(new ConditionOutcomeResult(childItem, deep));
					}
				}
				if(item.VersionOutcomeResult != null)
				{
					foreach(var childItem in item.VersionOutcomeResult)
					{
						this.VersionOutcomeResult.Add(new VersionOutcomeResult(childItem, deep));
					}
				}
				if(item.Policy != null)
                {
                    this.Policy = new Policy(item.Policy, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<bool> HadEffect { get; set; }
		public Nullable<decimal> EffectPercentageValue { get; set; }
		public string EffectDescription { get; set; }
		public Nullable<int> OutcomeId { get; set; }
		public Nullable<int> PremiumId { get; set; }
		public Nullable<int> PolicyId { get; set; }
		public Nullable<int> UserId { get; set; }
		public int TypeOption { get; set; }
		public Nullable<decimal> EffectUnitValue { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<AnswerOutcomeResult> AnswerOutcomeResult { get; set; }

        IList<IAnswerOutcomeResult> IOutcomeResult.AnswerOutcomeResult 
		{ 
			get
			{
				return (IList<IAnswerOutcomeResult>)this.AnswerOutcomeResult;
			}
			set
			{
				this.AnswerOutcomeResult = (IList<AnswerOutcomeResult>)value;
			}			
		}
        
        public virtual IList<ConditionOutcomeResult> ConditionOutcomeResult { get; set; }

        IList<IConditionOutcomeResult> IOutcomeResult.ConditionOutcomeResult 
		{ 
			get
			{
				return (IList<IConditionOutcomeResult>)this.ConditionOutcomeResult;
			}
			set
			{
				this.ConditionOutcomeResult = (IList<ConditionOutcomeResult>)value;
			}			
		}
        
        public virtual IList<VersionOutcomeResult> VersionOutcomeResult { get; set; }

        IList<IVersionOutcomeResult> IOutcomeResult.VersionOutcomeResult 
		{ 
			get
			{
				return (IList<IVersionOutcomeResult>)this.VersionOutcomeResult;
			}
			set
			{
				this.VersionOutcomeResult = (IList<VersionOutcomeResult>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Policy Policy { get; set; }

		IPolicy IOutcomeResult.Policy 
		{ 
			get
			{
				return this.Policy;
			}
			set
			{
				this.Policy = (Policy)value;
			}
		}
		
		#endregion
	}
}
