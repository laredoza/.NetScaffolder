
// <copyright file="AspNetRoleClaimDto.g.cs" company="MIT">
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
	public partial class AspNetRoleClaimDto
	{
		#region CTOR
		
		public AspNetRoleClaimDto()
		{
		}
		
		public AspNetRoleClaimDto(IAspNetRoleClaim item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.RoleId = item.RoleId;
			this.ClaimType = item.ClaimType;
			this.ClaimValue = item.ClaimValue;

			if(deep)
			{
                if(item.AspNetRole != null)
                {
				    this.AspNetRole = new AspNetRoleDto(item.AspNetRole, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Guid RoleId { get; set; }
		public string ClaimType { get; set; }
		public string ClaimValue { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
        [JsonConverter(typeof(ConcreteTypeConverter<AspNetRoleDto>))]
		public AspNetRoleDto AspNetRole { get; set; }
		
		#endregion
	}
}
