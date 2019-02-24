
// <copyright file="AspNetUserRole.g.cs" company="MIT">
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
	public partial class AspNetUserRole 
	{
		#region CTOR
		
		public AspNetUserRole()
		{
		}
		
		public AspNetUserRole(IAspNetUserRole item, bool deep = false)
		{
			if(item == null) return;
			
			this.UserId = item.UserId;
			this.RoleId = item.RoleId;

			if(deep)
			{
				if(item.AspNetRole != null)
                {
                    this.AspNetRole = new AspNetRole(item.AspNetRole, deep);
                }
				if(item.AspNetUser != null)
                {
                    this.AspNetUser = new AspNetUser(item.AspNetUser, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual Guid UserId { get; set; }
		public virtual Guid RoleId { get; set; }

		#endregion

		#region Parent Relationships

        public virtual AspNetRole AspNetRole { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
		
		#endregion

		public override int GetHashCode()
		{
			return 
	this.UserId.GetHashCode()
			^ 
	this.RoleId.GetHashCode()
;
		}
		
		public override bool Equals(object obj)
		{
			var item = obj as AspNetUserRole;
			if(item == null) return false;
			return 
	this.UserId == item.UserId
			&& 
	this.RoleId == item.RoleId
;
		}
	}
}
