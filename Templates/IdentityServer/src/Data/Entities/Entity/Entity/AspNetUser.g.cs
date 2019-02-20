
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
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity
{
	public partial class AspNetUser : IAspNetUser 
	{
		#region CTOR
		
		public AspNetUser()
		{
			this.AspNetUserClaim = new List <AspNetUserClaim>();
			this.AspNetUserLogin = new List <AspNetUserLogin>();
			this.AspNetUserRole = new List <AspNetUserRole>();
			this.AspNetUserToken = new List <AspNetUserToken>();
		}
		
		public AspNetUser(IAspNetUser item, bool deep = false)
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
			this.AspNetUserClaim = new List <AspNetUserClaim>();
			this.AspNetUserLogin = new List <AspNetUserLogin>();
			this.AspNetUserRole = new List <AspNetUserRole>();
			this.AspNetUserToken = new List <AspNetUserToken>();

			if(deep)
			{
				if(item.AspNetUserClaim != null)
				{
					foreach(var childItem in item.AspNetUserClaim)
					{
						this.AspNetUserClaim.Add(new AspNetUserClaim(childItem, deep));
					}
				}
				if(item.AspNetUserLogin != null)
				{
					foreach(var childItem in item.AspNetUserLogin)
					{
						this.AspNetUserLogin.Add(new AspNetUserLogin(childItem, deep));
					}
				}
				if(item.AspNetUserRole != null)
				{
					foreach(var childItem in item.AspNetUserRole)
					{
						this.AspNetUserRole.Add(new AspNetUserRole(childItem, deep));
					}
				}
				if(item.AspNetUserToken != null)
				{
					foreach(var childItem in item.AspNetUserToken)
					{
						this.AspNetUserToken.Add(new AspNetUserToken(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual Guid Id { get; set; }
		public virtual string UserName { get; set; }
		public virtual string NormalizedUserName { get; set; }
		public virtual string Email { get; set; }
		public virtual string NormalizedEmail { get; set; }
		public virtual bool EmailConfirmed { get; set; }
		public virtual string PasswordHash { get; set; }
		public virtual string SecurityStamp { get; set; }
		public virtual string ConcurrencyStamp { get; set; }
		public virtual string PhoneNumber { get; set; }
		public virtual bool PhoneNumberConfirmed { get; set; }
		public virtual bool TwoFactorEnabled { get; set; }
		public virtual Nullable<DateTimeOffset> LockoutEnd { get; set; }
		public virtual bool LockoutEnabled { get; set; }
		public virtual int AccessFailedCount { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<AspNetUserClaim> AspNetUserClaim { get; set; }
	
        IList<IAspNetUserClaim> IAspNetUser.AspNetUserClaim 
		{ 
			get
			{
				return this.AspNetUserClaim == null ? null : this.AspNetUserClaim as IList<IAspNetUserClaim>;
			}
			set
			{
				if(value != this.AspNetUserClaim)
				{
					if(value != null)
					{
						this.AspNetUserClaim = (IList<AspNetUserClaim>)value;
					}
					else
					{
						this.AspNetUserClaim = null;
					}
				}
			}			
		}
        
        public virtual IList<AspNetUserLogin> AspNetUserLogin { get; set; }
	
        IList<IAspNetUserLogin> IAspNetUser.AspNetUserLogin 
		{ 
			get
			{
				return this.AspNetUserLogin == null ? null : this.AspNetUserLogin as IList<IAspNetUserLogin>;
			}
			set
			{
				if(value != this.AspNetUserLogin)
				{
					if(value != null)
					{
						this.AspNetUserLogin = (IList<AspNetUserLogin>)value;
					}
					else
					{
						this.AspNetUserLogin = null;
					}
				}
			}			
		}
        
        public virtual IList<AspNetUserRole> AspNetUserRole { get; set; }
	
        IList<IAspNetUserRole> IAspNetUser.AspNetUserRole 
		{ 
			get
			{
				return this.AspNetUserRole == null ? null : this.AspNetUserRole as IList<IAspNetUserRole>;
			}
			set
			{
				if(value != this.AspNetUserRole)
				{
					if(value != null)
					{
						this.AspNetUserRole = (IList<AspNetUserRole>)value;
					}
					else
					{
						this.AspNetUserRole = null;
					}
				}
			}			
		}
        
        public virtual IList<AspNetUserToken> AspNetUserToken { get; set; }
	
        IList<IAspNetUserToken> IAspNetUser.AspNetUserToken 
		{ 
			get
			{
				return this.AspNetUserToken == null ? null : this.AspNetUserToken as IList<IAspNetUserToken>;
			}
			set
			{
				if(value != this.AspNetUserToken)
				{
					if(value != null)
					{
						this.AspNetUserToken = (IList<AspNetUserToken>)value;
					}
					else
					{
						this.AspNetUserToken = null;
					}
				}
			}			
		}

		#endregion
	}
}
