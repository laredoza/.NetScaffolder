﻿
// <copyright file="Policy_AuditDto.g.cs" company="MIT">
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
	public partial class Policy_AuditDto : IPolicy_Audit 
	{
		#region CTOR
		
		public Policy_AuditDto()
		{
		}
		
		public Policy_AuditDto(IPolicy_Audit item, bool deep = false)
		{
			if(item == null) return;
			
			this.Audit_Id = item.Audit_Id;
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PolicyNumber = item.PolicyNumber;
			this.Premium = item.Premium;
			this.SumAssured = item.SumAssured;
			this.ActivationDate = item.ActivationDate;
			this.QuestionnaireId = item.QuestionnaireId;
			this.Status = item.Status;
			this.ExternalReferenceId = item.ExternalReferenceId;
			this.ExternalReferenceLocked = item.ExternalReferenceLocked;
			this.AcceptedStatus = item.AcceptedStatus;
			this.AcceptedDate = item.AcceptedDate;
			this.CustomerId = item.CustomerId;
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
		public Nullable<int> PolicyNumber { get; set; }
		public Nullable<decimal> Premium { get; set; }
		public Nullable<decimal> SumAssured { get; set; }
		public Nullable<DateTime> ActivationDate { get; set; }
		public Nullable<int> QuestionnaireId { get; set; }
		public Nullable<int> Status { get; set; }
		public string ExternalReferenceId { get; set; }
		public Nullable<bool> ExternalReferenceLocked { get; set; }
		public Nullable<int> AcceptedStatus { get; set; }
		public Nullable<DateTime> AcceptedDate { get; set; }
		public Nullable<int> CustomerId { get; set; }
		public int AuditTrailType { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}