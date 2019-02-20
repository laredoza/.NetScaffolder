﻿
// <copyright file="AspNetUserClaim.g.cs" company="MIT">
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
	public partial class AspNetUserClaim : IAspNetUserClaim 
	{
		#region CTOR
		
		public AspNetUserClaim()
		{
		}
		
		public AspNetUserClaim(IAspNetUserClaim item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.UserId = item.UserId;
			this.ClaimType = item.ClaimType;
			this.ClaimValue = item.ClaimValue;

			if(deep)
			{
				if(item.AspNetUser != null)
                {
                    this.AspNetUser = new AspNetUser(item.AspNetUser, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int Id { get; set; }
		public virtual Guid UserId { get; set; }
		public virtual string ClaimType { get; set; }
		public virtual string ClaimValue { get; set; }

		#endregion

		#region Parent Relationships

        public virtual AspNetUser AspNetUser { get; set; }
		IAspNetUser IAspNetUserClaim.AspNetUser 
		{ 
			get
			{
				return this.AspNetUser;
			}
			set
			{
				if(value != this.AspNetUser)
				{
					if(value != null)
					{
						this.AspNetUser = (AspNetUser)value;
					}
					else
					{
						this.AspNetUser = null;
					}
				}
			}
		}
		
		#endregion
	}
}
