
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

namespace Banking.Models.Interfaces
{
	public partial interface IProvider  
	{
		#region Fields
		
		int Id { get; set; }
		Nullable<DateTime> Stamp { get; set; }
		string UserName { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<IAnswerOutcome> AnswerOutcome { get; set; }
		IList<IAnswerProfile> AnswerProfile { get; set; }
		IList<ICedantMandatoryFieldConfig> CedantMandatoryFieldConfig { get; set; }
		IList<IConditionOutcome> ConditionOutcome { get; set; }
		IList<IOutcomeGroupOutcome> OutcomeGroupOutcome { get; set; }
		IList<IResult> Result { get; set; }
		IList<ISetupTableOutcome> SetupTableOutcome { get; set; }
		IList<IVersionOutcome> VersionOutcome { get; set; }
		IBasicAnswerProvider BasicAnswerProvider { get; set; }
		ICalculatedAnswerProvider CalculatedAnswerProvider { get; set; }
		ICompletedAnswerProvider CompletedAnswerProvider { get; set; }
		ILoadingOutcome LoadingOutcome { get; set; }
		IMandatoryFieldAgeCalculator MandatoryFieldAgeCalculator { get; set; }
		IMultipleSelectionAnswerProvider MultipleSelectionAnswerProvider { get; set; }
		IPolicyReferenceOutcome PolicyReferenceOutcome { get; set; }
		IPolicyStatusOutcome PolicyStatusOutcome { get; set; }
		IProductPostponeStatusOutcome ProductPostponeStatusOutcome { get; set; }
		IProductReferenceOutcome ProductReferenceOutcome { get; set; }
		IProductStatusOutcome ProductStatusOutcome { get; set; }
		IReferenceOutcome ReferenceOutcome { get; set; }
		IReferenceProductOutcome ReferenceProductOutcome { get; set; }
		IScoringOutcome ScoringOutcome { get; set; }
		ISectionVisibilityOutcome SectionVisibilityOutcome { get; set; }
		ISelectionAnswerProvider SelectionAnswerProvider { get; set; }
		ISingleEntryAnswerProvider SingleEntryAnswerProvider { get; set; }
		IVisibilityOutcome VisibilityOutcome { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
