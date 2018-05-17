
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
using Banking.Models.Interfaces;

namespace Banking.Models.Entity
{
	public partial class Cedant_Audit : ICedant_Audit 
	{
		#region CTOR
		
		public Cedant_Audit()
		{
		}
		
		public Cedant_Audit(ICedant_Audit item, bool deep = false)
		{
			if(item == null) return;
			
			this.Audit_Id = item.Audit_Id;
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Name = item.Name;
			this.TimeLimit = item.TimeLimit;
			this.isChangeLimited = item.isChangeLimited;
			this.RemainingChanges = item.RemainingChanges;
			this.LimitInternetUserOnly = item.LimitInternetUserOnly;
			this.BannerImage = item.BannerImage;
			this.BannerImageType = item.BannerImageType;
			this.TermsConditions = item.TermsConditions;
			this.ReportName = item.ReportName;
			this.License = item.License;
			this.Validator = item.Validator;
			this.LicenseKey = item.LicenseKey;
			this.LicenseSalt = item.LicenseSalt;
			this.CedantUniqueIdentifier = item.CedantUniqueIdentifier;
			this.ExclusionSetupTableName = item.ExclusionSetupTableName;
			this.PostponementSetupTableName = item.PostponementSetupTableName;
			this.QuestionnaireProfileVersionId = item.QuestionnaireProfileVersionId;
			this.AuditTrailType = item.AuditTrailType;

			if(deep)
			{
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Audit_Id { get; set; }
		public int Id { get; set; }
		public DateTime Stamp { get; set; }
		public string UserName { get; set; }
		public string Name { get; set; }
		public Nullable<long> TimeLimit { get; set; }
		public Nullable<bool> isChangeLimited { get; set; }
		public Nullable<int> RemainingChanges { get; set; }
		public Nullable<bool> LimitInternetUserOnly { get; set; }
		public byte[] BannerImage { get; set; }
		public string BannerImageType { get; set; }
		public string TermsConditions { get; set; }
		public string ReportName { get; set; }
		public string License { get; set; }
		public string Validator { get; set; }
		public string LicenseKey { get; set; }
		public string LicenseSalt { get; set; }
		public Nullable<Guid> CedantUniqueIdentifier { get; set; }
		public string ExclusionSetupTableName { get; set; }
		public string PostponementSetupTableName { get; set; }
		public Nullable<int> QuestionnaireProfileVersionId { get; set; }
		public int AuditTrailType { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}
