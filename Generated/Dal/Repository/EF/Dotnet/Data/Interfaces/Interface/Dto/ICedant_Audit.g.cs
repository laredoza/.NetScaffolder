
// <copyright file="Cedant_Audit.g.cs" company="MIT">
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
	public partial interface ICedant_Audit  
	{
		#region Fields
		
		int Audit_Id { get; set; }
		int Id { get; set; }
		DateTime Stamp { get; set; }
		string UserName { get; set; }
		string Name { get; set; }
		Nullable<long> TimeLimit { get; set; }
		Nullable<bool> isChangeLimited { get; set; }
		Nullable<int> RemainingChanges { get; set; }
		Nullable<bool> LimitInternetUserOnly { get; set; }
		byte[] BannerImage { get; set; }
		string BannerImageType { get; set; }
		string TermsConditions { get; set; }
		string ReportName { get; set; }
		string License { get; set; }
		string Validator { get; set; }
		string LicenseKey { get; set; }
		string LicenseSalt { get; set; }
		Nullable<Guid> CedantUniqueIdentifier { get; set; }
		string ExclusionSetupTableName { get; set; }
		string PostponementSetupTableName { get; set; }
		Nullable<int> QuestionnaireProfileVersionId { get; set; }
		int AuditTrailType { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
