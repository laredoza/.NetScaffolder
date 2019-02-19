
// <copyright file="AspNetRole.g.cs" company="MIT">
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
	public partial class AspNetRole : IAspNetRole 
	{
		#region CTOR
		
		public AspNetRole()
		{
			this.AspNetRoleClaim = new List <AspNetRoleClaim>();
			this.AspNetUserRole = new List <AspNetUserRole>();
		}
		
		public AspNetRole(IAspNetRole item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Name = item.Name;
			this.NormalizedName = item.NormalizedName;
			this.ConcurrencyStamp = item.ConcurrencyStamp;
			this.AspNetRoleClaim = new List <AspNetRoleClaim>();
			this.AspNetUserRole = new List <AspNetUserRole>();

			if(deep)
			{
				if(item.AspNetRoleClaim != null)
				{
					foreach(var childItem in item.AspNetRoleClaim)
					{
						this.AspNetRoleClaim.Add(new AspNetRoleClaim(childItem, deep));
					}
				}
				if(item.AspNetUserRole != null)
				{
					foreach(var childItem in item.AspNetUserRole)
					{
						this.AspNetUserRole.Add(new AspNetUserRole(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual string Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string NormalizedName { get; set; }
		public virtual string ConcurrencyStamp { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<AspNetRoleClaim> AspNetRoleClaim { get; set; }
	
        IList<IAspNetRoleClaim> IAspNetRole.AspNetRoleClaim 
		{ 
			get
			{
				return this.AspNetRoleClaim == null ? null : this.AspNetRoleClaim as IList<IAspNetRoleClaim>;
			}
			set
			{
				if(value != this.AspNetRoleClaim)
				{
					if(value != null)
					{
						this.AspNetRoleClaim = (IList<AspNetRoleClaim>)value;
					}
					else
					{
						this.AspNetRoleClaim = null;
					}
				}
			}			
		}
        
        public virtual IList<AspNetUserRole> AspNetUserRole { get; set; }
	
        IList<IAspNetUserRole> IAspNetRole.AspNetUserRole 
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

		#endregion
	}
}
