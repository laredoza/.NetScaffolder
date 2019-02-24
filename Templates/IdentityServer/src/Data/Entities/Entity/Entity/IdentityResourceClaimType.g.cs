
// <copyright file="IdentityResourceClaimType.g.cs" company="MIT">
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
	public partial class IdentityResourceClaimType 
	{
		#region CTOR
		
		public IdentityResourceClaimType()
		{
		}
		
		public IdentityResourceClaimType(IIdentityResourceClaimType item, bool deep = false)
		{
			if(item == null) return;
			
			this.IdentityResourceId = item.IdentityResourceId;
			this.ResourceClaimTypeId = item.ResourceClaimTypeId;

			if(deep)
			{
				if(item.IdentityResource != null)
                {
                    this.IdentityResource = new IdentityResource(item.IdentityResource, deep);
                }
				if(item.ResourceClaimType != null)
                {
                    this.ResourceClaimType = new ResourceClaimType(item.ResourceClaimType, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int IdentityResourceId { get; set; }
		public virtual int ResourceClaimTypeId { get; set; }

		#endregion

		#region Parent Relationships

        public virtual IdentityResource IdentityResource { get; set; }

        public virtual ResourceClaimType ResourceClaimType { get; set; }
		
		#endregion

		public override int GetHashCode()
		{
			return 
	this.IdentityResourceId.GetHashCode()
			^ 
	this.ResourceClaimTypeId.GetHashCode()
;
		}
		
		public override bool Equals(object obj)
		{
			var item = obj as IdentityResourceClaimType;
			if(item == null) return false;
			return 
	this.IdentityResourceId == item.IdentityResourceId
			&& 
	this.ResourceClaimTypeId == item.ResourceClaimTypeId
;
		}
	}
}
