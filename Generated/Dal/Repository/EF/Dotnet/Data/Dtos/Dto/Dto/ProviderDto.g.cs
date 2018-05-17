
// <copyright file="ProviderDto.g.cs" company="MIT">
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
	public partial class ProviderDto : IProvider 
	{
		#region CTOR
		
		public ProviderDto()
		{
			this.AnswerOutcome = new List <IAnswerOutcome>();
			this.AnswerProfile = new List <IAnswerProfile>();
			this.CedantMandatoryFieldConfig = new List <ICedantMandatoryFieldConfig>();
			this.ConditionOutcome = new List <IConditionOutcome>();
			this.OutcomeGroupOutcome = new List <IOutcomeGroupOutcome>();
			this.Result = new List <IResult>();
			this.SetupTableOutcome = new List <ISetupTableOutcome>();
			this.VersionOutcome = new List <IVersionOutcome>();
		}
		
		public ProviderDto(IProvider item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.AnswerOutcome = new List <IAnswerOutcome>();
			this.AnswerProfile = new List <IAnswerProfile>();
			this.CedantMandatoryFieldConfig = new List <ICedantMandatoryFieldConfig>();
			this.ConditionOutcome = new List <IConditionOutcome>();
			this.OutcomeGroupOutcome = new List <IOutcomeGroupOutcome>();
			this.Result = new List <IResult>();
			this.SetupTableOutcome = new List <ISetupTableOutcome>();
			this.VersionOutcome = new List <IVersionOutcome>();

			if(deep)
			{
				if(item.AnswerOutcome != null)
				{
					foreach(var childItem in item.AnswerOutcome)
					{
						this.AnswerOutcome.Add(new AnswerOutcomeDto(childItem, deep));
					}
				}
				if(item.AnswerProfile != null)
				{
					foreach(var childItem in item.AnswerProfile)
					{
						this.AnswerProfile.Add(new AnswerProfileDto(childItem, deep));
					}
				}
				if(item.CedantMandatoryFieldConfig != null)
				{
					foreach(var childItem in item.CedantMandatoryFieldConfig)
					{
						this.CedantMandatoryFieldConfig.Add(new CedantMandatoryFieldConfigDto(childItem, deep));
					}
				}
				if(item.ConditionOutcome != null)
				{
					foreach(var childItem in item.ConditionOutcome)
					{
						this.ConditionOutcome.Add(new ConditionOutcomeDto(childItem, deep));
					}
				}
				if(item.OutcomeGroupOutcome != null)
				{
					foreach(var childItem in item.OutcomeGroupOutcome)
					{
						this.OutcomeGroupOutcome.Add(new OutcomeGroupOutcomeDto(childItem, deep));
					}
				}
				if(item.Result != null)
				{
					foreach(var childItem in item.Result)
					{
						this.Result.Add(new ResultDto(childItem, deep));
					}
				}
				if(item.SetupTableOutcome != null)
				{
					foreach(var childItem in item.SetupTableOutcome)
					{
						this.SetupTableOutcome.Add(new SetupTableOutcomeDto(childItem, deep));
					}
				}
				if(item.VersionOutcome != null)
				{
					foreach(var childItem in item.VersionOutcome)
					{
						this.VersionOutcome.Add(new VersionOutcomeDto(childItem, deep));
					}
				}
				this.BasicAnswerProvider = new BasicAnswerProviderDto(item.BasicAnswerProvider, deep);
				this.CalculatedAnswerProvider = new CalculatedAnswerProviderDto(item.CalculatedAnswerProvider, deep);
				this.CompletedAnswerProvider = new CompletedAnswerProviderDto(item.CompletedAnswerProvider, deep);
				this.LoadingOutcome = new LoadingOutcomeDto(item.LoadingOutcome, deep);
				this.MandatoryFieldAgeCalculator = new MandatoryFieldAgeCalculatorDto(item.MandatoryFieldAgeCalculator, deep);
				this.MultipleSelectionAnswerProvider = new MultipleSelectionAnswerProviderDto(item.MultipleSelectionAnswerProvider, deep);
				this.PolicyReferenceOutcome = new PolicyReferenceOutcomeDto(item.PolicyReferenceOutcome, deep);
				this.PolicyStatusOutcome = new PolicyStatusOutcomeDto(item.PolicyStatusOutcome, deep);
				this.ProductPostponeStatusOutcome = new ProductPostponeStatusOutcomeDto(item.ProductPostponeStatusOutcome, deep);
				this.ProductReferenceOutcome = new ProductReferenceOutcomeDto(item.ProductReferenceOutcome, deep);
				this.ProductStatusOutcome = new ProductStatusOutcomeDto(item.ProductStatusOutcome, deep);
				this.ReferenceOutcome = new ReferenceOutcomeDto(item.ReferenceOutcome, deep);
				this.ReferenceProductOutcome = new ReferenceProductOutcomeDto(item.ReferenceProductOutcome, deep);
				this.ScoringOutcome = new ScoringOutcomeDto(item.ScoringOutcome, deep);
				this.SectionVisibilityOutcome = new SectionVisibilityOutcomeDto(item.SectionVisibilityOutcome, deep);
				this.SelectionAnswerProvider = new SelectionAnswerProviderDto(item.SelectionAnswerProvider, deep);
				this.SingleEntryAnswerProvider = new SingleEntryAnswerProviderDto(item.SingleEntryAnswerProvider, deep);
				this.VisibilityOutcome = new VisibilityOutcomeDto(item.VisibilityOutcome, deep);
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IAnswerOutcome> AnswerOutcome { get; set; }
		public IList<IAnswerProfile> AnswerProfile { get; set; }
		public IList<ICedantMandatoryFieldConfig> CedantMandatoryFieldConfig { get; set; }
		public IList<IConditionOutcome> ConditionOutcome { get; set; }
		public IList<IOutcomeGroupOutcome> OutcomeGroupOutcome { get; set; }
		public IList<IResult> Result { get; set; }
		public IList<ISetupTableOutcome> SetupTableOutcome { get; set; }
		public IList<IVersionOutcome> VersionOutcome { get; set; }
		public IBasicAnswerProvider BasicAnswerProvider { get; set; }
		public ICalculatedAnswerProvider CalculatedAnswerProvider { get; set; }
		public ICompletedAnswerProvider CompletedAnswerProvider { get; set; }
		public ILoadingOutcome LoadingOutcome { get; set; }
		public IMandatoryFieldAgeCalculator MandatoryFieldAgeCalculator { get; set; }
		public IMultipleSelectionAnswerProvider MultipleSelectionAnswerProvider { get; set; }
		public IPolicyReferenceOutcome PolicyReferenceOutcome { get; set; }
		public IPolicyStatusOutcome PolicyStatusOutcome { get; set; }
		public IProductPostponeStatusOutcome ProductPostponeStatusOutcome { get; set; }
		public IProductReferenceOutcome ProductReferenceOutcome { get; set; }
		public IProductStatusOutcome ProductStatusOutcome { get; set; }
		public IReferenceOutcome ReferenceOutcome { get; set; }
		public IReferenceProductOutcome ReferenceProductOutcome { get; set; }
		public IScoringOutcome ScoringOutcome { get; set; }
		public ISectionVisibilityOutcome SectionVisibilityOutcome { get; set; }
		public ISelectionAnswerProvider SelectionAnswerProvider { get; set; }
		public ISingleEntryAnswerProvider SingleEntryAnswerProvider { get; set; }
		public IVisibilityOutcome VisibilityOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
