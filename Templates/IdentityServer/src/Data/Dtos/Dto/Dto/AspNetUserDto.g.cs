
// <copyright file="AspNetUserDto.g.cs" company="MIT">
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
using Newtonsoft.Json;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto
{
	public partial class AspNetUserDto : IAspNetUser 
	{
		#region CTOR
		
		public AspNetUserDto()
		{
			this.AspNetUserClaim = new List <IAspNetUserClaim>();
			this.AspNetUserLogin = new List <IAspNetUserLogin>();
			this.AspNetUserRole = new List <IAspNetUserRole>();
			this.AspNetUserToken = new List <IAspNetUserToken>();
		}
		
		public AspNetUserDto(IAspNetUser item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.UserName = item.UserName;
			this.NormalizedUserName = item.NormalizedUserName;
			this.Email = item.Email;
			this.NormalizedEmail = item.NormalizedEmail;
			this.EmailConfirmed = item.EmailConfirmed;
			this.PasswordHash = item.PasswordHash;
			this.SecurityStamp = item.SecurityStamp;
			this.ConcurrencyStamp = item.ConcurrencyStamp;
			this.PhoneNumber = item.PhoneNumber;
			this.PhoneNumberConfirmed = item.PhoneNumberConfirmed;
			this.TwoFactorEnabled = item.TwoFactorEnabled;
			this.LockoutEnd = item.LockoutEnd;
			this.LockoutEnabled = item.LockoutEnabled;
			this.AccessFailedCount = item.AccessFailedCount;
			this.AspNetUserClaim = new List <IAspNetUserClaim>();
			this.AspNetUserLogin = new List <IAspNetUserLogin>();
			this.AspNetUserRole = new List <IAspNetUserRole>();
			this.AspNetUserToken = new List <IAspNetUserToken>();

			if(deep)
			{
				if(item.AspNetUserClaim != null)
				{
					foreach(var childItem in item.AspNetUserClaim)
					{
						this.AspNetUserClaim.Add(new AspNetUserClaimDto(childItem, deep));
					}
				}
				if(item.AspNetUserLogin != null)
				{
					foreach(var childItem in item.AspNetUserLogin)
					{
						this.AspNetUserLogin.Add(new AspNetUserLoginDto(childItem, deep));
					}
				}
				if(item.AspNetUserRole != null)
				{
					foreach(var childItem in item.AspNetUserRole)
					{
						this.AspNetUserRole.Add(new AspNetUserRoleDto(childItem, deep));
					}
				}
				if(item.AspNetUserToken != null)
				{
					foreach(var childItem in item.AspNetUserToken)
					{
						this.AspNetUserToken.Add(new AspNetUserTokenDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string NormalizedUserName { get; set; }
		public string Email { get; set; }
		public string NormalizedEmail { get; set; }
		public bool EmailConfirmed { get; set; }
		public string PasswordHash { get; set; }
		public string SecurityStamp { get; set; }
		public string ConcurrencyStamp { get; set; }
		public string PhoneNumber { get; set; }
		public bool PhoneNumberConfirmed { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public Nullable<DateTimeOffset> LockoutEnd { get; set; }
		public bool LockoutEnabled { get; set; }
		public int AccessFailedCount { get; set; }

		#endregion
		
		#region Child Relationships
		
        // [JsonConverter(typeof(ConcreteTypeConverter<AspNetUserClaimDto>))]
		public IList<IAspNetUserClaim> AspNetUserClaim { get; set; }
        // [JsonConverter(typeof(ConcreteTypeConverter<AspNetUserLoginDto>))]
		public IList<IAspNetUserLogin> AspNetUserLogin { get; set; }
        // [JsonConverter(typeof(ConcreteTypeConverter<AspNetUserRoleDto>))]
		public IList<IAspNetUserRole> AspNetUserRole { get; set; }
        // [JsonConverter(typeof(ConcreteTypeConverter<AspNetUserTokenDto>))]
		public IList<IAspNetUserToken> AspNetUserToken { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
