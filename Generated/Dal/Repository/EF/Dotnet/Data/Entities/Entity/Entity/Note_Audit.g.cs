﻿
// <copyright file="Note_Audit.g.cs" company="MIT">
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
	public partial class Note_Audit : INote_Audit 
	{
		#region CTOR
		
		public Note_Audit()
		{
		}
		
		public Note_Audit(INote_Audit item, bool deep = false)
		{
			if(item == null) return;
			
			this.Audit_Id = item.Audit_Id;
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Description = item.Description;
			this.AllocatedToId = item.AllocatedToId;
			this.ActionRequiredFlag = item.ActionRequiredFlag;
			this.FollowUpDate = item.FollowUpDate;
			this.LinkId = item.LinkId;
			this.CompletedFlag = item.CompletedFlag;
			this.UserId = item.UserId;
			this.NoteStatusId = item.NoteStatusId;
			this.NoteLinkTypeId = item.NoteLinkTypeId;
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
		public string Description { get; set; }
		public Nullable<int> AllocatedToId { get; set; }
		public Nullable<bool> ActionRequiredFlag { get; set; }
		public Nullable<DateTime> FollowUpDate { get; set; }
		public Nullable<int> LinkId { get; set; }
		public Nullable<bool> CompletedFlag { get; set; }
		public Nullable<int> UserId { get; set; }
		public Nullable<int> NoteStatusId { get; set; }
		public Nullable<int> NoteLinkTypeId { get; set; }
		public int AuditTrailType { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships
		
		#endregion
	}
}