
// <copyright file="AspNetUser.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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

namespace DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto
{
	public partial interface IAspNetUser  
	{
		#region Fields
		
		Guid Id { get; set; }
		string UserName { get; set; }
		string NormalizedUserName { get; set; }
		string Email { get; set; }
		string NormalizedEmail { get; set; }
		bool EmailConfirmed { get; set; }
		string PasswordHash { get; set; }
		string SecurityStamp { get; set; }
		string ConcurrencyStamp { get; set; }
		string PhoneNumber { get; set; }
		bool PhoneNumberConfirmed { get; set; }
		bool TwoFactorEnabled { get; set; }
		Nullable<DateTimeOffset> LockoutEnd { get; set; }
		bool LockoutEnabled { get; set; }
		int AccessFailedCount { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<IAspNetUserClaim> AspNetUserClaim { get; set; }
		IList<IAspNetUserLogin> AspNetUserLogin { get; set; }
		IList<IAspNetUserRole> AspNetUserRole { get; set; }
		IList<IAspNetUserToken> AspNetUserToken { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
