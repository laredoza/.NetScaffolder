
// <copyright file="ScoringOutcome.g.cs" company="MIT">
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
	public partial class ScoringOutcome : IScoringOutcome 
	{
		#region CTOR
		
		public ScoringOutcome()
		{
		}
		
		public ScoringOutcome(IScoringOutcome item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.MathOption = item.MathOption;
			this.UnitValue = item.UnitValue;
			this.AttributeProfileId = item.AttributeProfileId;
			this.TypeOption = item.TypeOption;
			this.PercentageValue = item.PercentageValue;

			if(deep)
			{
				if(item.Provider != null)
                {
                    this.Provider = new Provider(item.Provider, deep);
                }
				if(item.ApplicantAttributeProfile != null)
                {
                    this.ApplicantAttributeProfile = new ApplicantAttributeProfile(item.ApplicantAttributeProfile, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<int> MathOption { get; set; }
		public Nullable<decimal> UnitValue { get; set; }
		public Nullable<int> AttributeProfileId { get; set; }
		public int TypeOption { get; set; }
		public Nullable<decimal> PercentageValue { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual Provider Provider { get; set; }

		IProvider IScoringOutcome.Provider 
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

        public virtual ApplicantAttributeProfile ApplicantAttributeProfile { get; set; }

		IApplicantAttributeProfile IScoringOutcome.ApplicantAttributeProfile 
		{ 
			get
			{
				return this.ApplicantAttributeProfile;
			}
			set
			{
				this.ApplicantAttributeProfile = (ApplicantAttributeProfile)value;
			}
		}
		
		#endregion
	}
}
