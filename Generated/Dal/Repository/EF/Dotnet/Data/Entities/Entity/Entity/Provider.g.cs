
// <copyright file="Provider.g.cs" company="MIT">
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
	public partial class Provider : IProvider 
	{
		#region CTOR
		
		public Provider()
		{
			this.AnswerOutcome = new List <AnswerOutcome>();
			this.AnswerProfile = new List <AnswerProfile>();
			this.CedantMandatoryFieldConfig = new List <CedantMandatoryFieldConfig>();
			this.ConditionOutcome = new List <ConditionOutcome>();
			this.OutcomeGroupOutcome = new List <OutcomeGroupOutcome>();
			this.Result = new List <Result>();
			this.SetupTableOutcome = new List <SetupTableOutcome>();
			this.VersionOutcome = new List <VersionOutcome>();
		}
		
		public Provider(IProvider item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerOutcome = new List <AnswerOutcome>();
			this.AnswerProfile = new List <AnswerProfile>();
			this.CedantMandatoryFieldConfig = new List <CedantMandatoryFieldConfig>();
			this.ConditionOutcome = new List <ConditionOutcome>();
			this.OutcomeGroupOutcome = new List <OutcomeGroupOutcome>();
			this.Result = new List <Result>();
			this.SetupTableOutcome = new List <SetupTableOutcome>();
			this.VersionOutcome = new List <VersionOutcome>();

			if(deep)
			{
				if(item.AnswerOutcome != null)
				{
					foreach(var childItem in item.AnswerOutcome)
					{
						this.AnswerOutcome.Add(new AnswerOutcome(childItem, deep));
					}
				}
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfile(childItem, deep));
					}
				}
				if(item.CedantMandatoryFieldConfig != null)
				{
					foreach(var childItem in item.CedantMandatoryFieldConfig)
					{
						this.CedantMandatoryFieldConfig.Add(new CedantMandatoryFieldConfig(childItem, deep));
					}
				}
				if(item.ConditionOutcome != null)
				{
					foreach(var childItem in item.ConditionOutcome)
					{
						this.ConditionOutcome.Add(new ConditionOutcome(childItem, deep));
					}
				}
				if(item.OutcomeGroupOutcome != null)
				{
					foreach(var childItem in item.OutcomeGroupOutcome)
					{
						this.OutcomeGroupOutcome.Add(new OutcomeGroupOutcome(childItem, deep));
					}
				}
				if(item.Result != null)
				{
					foreach(var childItem in item.Result)
					{
						this.Result.Add(new Result(childItem, deep));
					}
				}
				if(item.SetupTableOutcome != null)
				{
					foreach(var childItem in item.SetupTableOutcome)
					{
						this.SetupTableOutcome.Add(new SetupTableOutcome(childItem, deep));
					}
				}
				if(item.VersionOutcome != null)
				{
					foreach(var childItem in item.VersionOutcome)
					{
						this.VersionOutcome.Add(new VersionOutcome(childItem, deep));
					}
				}
				this.BasicAnswerProvider = new BasicAnswerProvider(item.BasicAnswerProvider, deep);
				this.CalculatedAnswerProvider = new CalculatedAnswerProvider(item.CalculatedAnswerProvider, deep);
				this.CompletedAnswerProvider = new CompletedAnswerProvider(item.CompletedAnswerProvider, deep);
				this.LoadingOutcome = new LoadingOutcome(item.LoadingOutcome, deep);
				this.MandatoryFieldAgeCalculator = new MandatoryFieldAgeCalculator(item.MandatoryFieldAgeCalculator, deep);
				this.MultipleSelectionAnswerProvider = new MultipleSelectionAnswerProvider(item.MultipleSelectionAnswerProvider, deep);
				this.PolicyReferenceOutcome = new PolicyReferenceOutcome(item.PolicyReferenceOutcome, deep);
				this.PolicyStatusOutcome = new PolicyStatusOutcome(item.PolicyStatusOutcome, deep);
				this.ProductPostponeStatusOutcome = new ProductPostponeStatusOutcome(item.ProductPostponeStatusOutcome, deep);
				this.ProductReferenceOutcome = new ProductReferenceOutcome(item.ProductReferenceOutcome, deep);
				this.ProductStatusOutcome = new ProductStatusOutcome(item.ProductStatusOutcome, deep);
				this.ReferenceOutcome = new ReferenceOutcome(item.ReferenceOutcome, deep);
				this.ReferenceProductOutcome = new ReferenceProductOutcome(item.ReferenceProductOutcome, deep);
				this.ScoringOutcome = new ScoringOutcome(item.ScoringOutcome, deep);
				this.SectionVisibilityOutcome = new SectionVisibilityOutcome(item.SectionVisibilityOutcome, deep);
				this.SelectionAnswerProvider = new SelectionAnswerProvider(item.SelectionAnswerProvider, deep);
				this.SingleEntryAnswerProvider = new SingleEntryAnswerProvider(item.SingleEntryAnswerProvider, deep);
				this.VisibilityOutcome = new VisibilityOutcome(item.VisibilityOutcome, deep);
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<AnswerOutcome> AnswerOutcome { get; set; }

        IList<IAnswerOutcome> IProvider.AnswerOutcome 
		{ 
			get
			{
				return (IList<IAnswerOutcome>)this.AnswerOutcome;
			}
			set
			{
				this.AnswerOutcome = (IList<AnswerOutcome>)value;
			}			
		}
        
        public virtual IList<AnswerProfile> AnswerProfile { get; set; }

        IList<IAnswerProfile> IProvider.AnswerProfile 
		{ 
			get
			{
				return (IList<IAnswerProfile>)this.AnswerProfile;
			}
			set
			{
				this.AnswerProfile = (IList<AnswerProfile>)value;
			}			
		}
        
        public virtual IList<CedantMandatoryFieldConfig> CedantMandatoryFieldConfig { get; set; }

        IList<ICedantMandatoryFieldConfig> IProvider.CedantMandatoryFieldConfig 
		{ 
			get
			{
				return (IList<ICedantMandatoryFieldConfig>)this.CedantMandatoryFieldConfig;
			}
			set
			{
				this.CedantMandatoryFieldConfig = (IList<CedantMandatoryFieldConfig>)value;
			}			
		}
        
        public virtual IList<ConditionOutcome> ConditionOutcome { get; set; }

        IList<IConditionOutcome> IProvider.ConditionOutcome 
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
        
        public virtual IList<OutcomeGroupOutcome> OutcomeGroupOutcome { get; set; }

        IList<IOutcomeGroupOutcome> IProvider.OutcomeGroupOutcome 
		{ 
			get
			{
				return (IList<IOutcomeGroupOutcome>)this.OutcomeGroupOutcome;
			}
			set
			{
				this.OutcomeGroupOutcome = (IList<OutcomeGroupOutcome>)value;
			}			
		}
        
        public virtual IList<Result> Result { get; set; }

        IList<IResult> IProvider.Result 
		{ 
			get
			{
				return (IList<IResult>)this.Result;
			}
			set
			{
				this.Result = (IList<Result>)value;
			}			
		}
        
        public virtual IList<SetupTableOutcome> SetupTableOutcome { get; set; }

        IList<ISetupTableOutcome> IProvider.SetupTableOutcome 
		{ 
			get
			{
				return (IList<ISetupTableOutcome>)this.SetupTableOutcome;
			}
			set
			{
				this.SetupTableOutcome = (IList<SetupTableOutcome>)value;
			}			
		}
        
        public virtual IList<VersionOutcome> VersionOutcome { get; set; }

        IList<IVersionOutcome> IProvider.VersionOutcome 
		{ 
			get
			{
				return (IList<IVersionOutcome>)this.VersionOutcome;
			}
			set
			{
				this.VersionOutcome = (IList<VersionOutcome>)value;
			}			
		}
        
        public virtual BasicAnswerProvider BasicAnswerProvider { get; set; }

		IBasicAnswerProvider IProvider.BasicAnswerProvider 
		{ 
			get
			{
				return this.BasicAnswerProvider;
			}
			set
			{
				this.BasicAnswerProvider = (BasicAnswerProvider)value;
			}
		}
        
        public virtual CalculatedAnswerProvider CalculatedAnswerProvider { get; set; }

		ICalculatedAnswerProvider IProvider.CalculatedAnswerProvider 
		{ 
			get
			{
				return this.CalculatedAnswerProvider;
			}
			set
			{
				this.CalculatedAnswerProvider = (CalculatedAnswerProvider)value;
			}
		}
        
        public virtual CompletedAnswerProvider CompletedAnswerProvider { get; set; }

		ICompletedAnswerProvider IProvider.CompletedAnswerProvider 
		{ 
			get
			{
				return this.CompletedAnswerProvider;
			}
			set
			{
				this.CompletedAnswerProvider = (CompletedAnswerProvider)value;
			}
		}
        
        public virtual LoadingOutcome LoadingOutcome { get; set; }

		ILoadingOutcome IProvider.LoadingOutcome 
		{ 
			get
			{
				return this.LoadingOutcome;
			}
			set
			{
				this.LoadingOutcome = (LoadingOutcome)value;
			}
		}
        
        public virtual MandatoryFieldAgeCalculator MandatoryFieldAgeCalculator { get; set; }

		IMandatoryFieldAgeCalculator IProvider.MandatoryFieldAgeCalculator 
		{ 
			get
			{
				return this.MandatoryFieldAgeCalculator;
			}
			set
			{
				this.MandatoryFieldAgeCalculator = (MandatoryFieldAgeCalculator)value;
			}
		}
        
        public virtual MultipleSelectionAnswerProvider MultipleSelectionAnswerProvider { get; set; }

		IMultipleSelectionAnswerProvider IProvider.MultipleSelectionAnswerProvider 
		{ 
			get
			{
				return this.MultipleSelectionAnswerProvider;
			}
			set
			{
				this.MultipleSelectionAnswerProvider = (MultipleSelectionAnswerProvider)value;
			}
		}
        
        public virtual PolicyReferenceOutcome PolicyReferenceOutcome { get; set; }

		IPolicyReferenceOutcome IProvider.PolicyReferenceOutcome 
		{ 
			get
			{
				return this.PolicyReferenceOutcome;
			}
			set
			{
				this.PolicyReferenceOutcome = (PolicyReferenceOutcome)value;
			}
		}
        
        public virtual PolicyStatusOutcome PolicyStatusOutcome { get; set; }

		IPolicyStatusOutcome IProvider.PolicyStatusOutcome 
		{ 
			get
			{
				return this.PolicyStatusOutcome;
			}
			set
			{
				this.PolicyStatusOutcome = (PolicyStatusOutcome)value;
			}
		}
        
        public virtual ProductPostponeStatusOutcome ProductPostponeStatusOutcome { get; set; }

		IProductPostponeStatusOutcome IProvider.ProductPostponeStatusOutcome 
		{ 
			get
			{
				return this.ProductPostponeStatusOutcome;
			}
			set
			{
				this.ProductPostponeStatusOutcome = (ProductPostponeStatusOutcome)value;
			}
		}
        
        public virtual ProductReferenceOutcome ProductReferenceOutcome { get; set; }

		IProductReferenceOutcome IProvider.ProductReferenceOutcome 
		{ 
			get
			{
				return this.ProductReferenceOutcome;
			}
			set
			{
				this.ProductReferenceOutcome = (ProductReferenceOutcome)value;
			}
		}
        
        public virtual ProductStatusOutcome ProductStatusOutcome { get; set; }

		IProductStatusOutcome IProvider.ProductStatusOutcome 
		{ 
			get
			{
				return this.ProductStatusOutcome;
			}
			set
			{
				this.ProductStatusOutcome = (ProductStatusOutcome)value;
			}
		}
        
        public virtual ReferenceOutcome ReferenceOutcome { get; set; }

		IReferenceOutcome IProvider.ReferenceOutcome 
		{ 
			get
			{
				return this.ReferenceOutcome;
			}
			set
			{
				this.ReferenceOutcome = (ReferenceOutcome)value;
			}
		}
        
        public virtual ReferenceProductOutcome ReferenceProductOutcome { get; set; }

		IReferenceProductOutcome IProvider.ReferenceProductOutcome 
		{ 
			get
			{
				return this.ReferenceProductOutcome;
			}
			set
			{
				this.ReferenceProductOutcome = (ReferenceProductOutcome)value;
			}
		}
        
        public virtual ScoringOutcome ScoringOutcome { get; set; }

		IScoringOutcome IProvider.ScoringOutcome 
		{ 
			get
			{
				return this.ScoringOutcome;
			}
			set
			{
				this.ScoringOutcome = (ScoringOutcome)value;
			}
		}
        
        public virtual SectionVisibilityOutcome SectionVisibilityOutcome { get; set; }

		ISectionVisibilityOutcome IProvider.SectionVisibilityOutcome 
		{ 
			get
			{
				return this.SectionVisibilityOutcome;
			}
			set
			{
				this.SectionVisibilityOutcome = (SectionVisibilityOutcome)value;
			}
		}
        
        public virtual SelectionAnswerProvider SelectionAnswerProvider { get; set; }

		ISelectionAnswerProvider IProvider.SelectionAnswerProvider 
		{ 
			get
			{
				return this.SelectionAnswerProvider;
			}
			set
			{
				this.SelectionAnswerProvider = (SelectionAnswerProvider)value;
			}
		}
        
        public virtual SingleEntryAnswerProvider SingleEntryAnswerProvider { get; set; }

		ISingleEntryAnswerProvider IProvider.SingleEntryAnswerProvider 
		{ 
			get
			{
				return this.SingleEntryAnswerProvider;
			}
			set
			{
				this.SingleEntryAnswerProvider = (SingleEntryAnswerProvider)value;
			}
		}
        
        public virtual VisibilityOutcome VisibilityOutcome { get; set; }

		IVisibilityOutcome IProvider.VisibilityOutcome 
		{ 
			get
			{
				return this.VisibilityOutcome;
			}
			set
			{
				this.VisibilityOutcome = (VisibilityOutcome)value;
			}
		}
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
