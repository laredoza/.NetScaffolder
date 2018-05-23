﻿
// <copyright file="QUIRCUser.g.cs" company="MIT">
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
	public partial interface IQUIRCUser  
	{
		#region Fields
		
		int Id { get; set; }
		Nullable<DateTime> Stamp { get; set; }
		string UserName { get; set; }
		string LoginId { get; set; }
		string PasswordHash { get; set; }
		string PasswordSalt { get; set; }
		string EmailAddress { get; set; }
		string FirstName { get; set; }
		string Surname { get; set; }
		Nullable<int> Role { get; set; }
		Nullable<int> Status { get; set; }
		string SecurityQuestions { get; set; }
		Nullable<int> CendantId { get; set; }
		Nullable<int> CedantUserLoadingLimitId { get; set; }
		Nullable<DateTime> LastLogin { get; set; }
		Nullable<bool> LockoutEnabled { get; set; }
		Nullable<bool> TwoFactorEnabled { get; set; }
		Nullable<int> AccessFailedCount { get; set; }
		Nullable<DateTime> LockoutEndDate { get; set; }
		Nullable<Guid> PasswordResetToken { get; set; }
		Nullable<bool> EmailConfirmed { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<ICedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }
		IList<INote> Note { get; set; }
		IList<INoteFollowUp> NoteFollowUp { get; set; }
		IList<IQUIRCUserCedant> QUIRCUserCedant { get; set; }

		#endregion
		
		#region Parent Relationships
		
		ICedant Cedant { get; set; }
		
		#endregion
	}
}