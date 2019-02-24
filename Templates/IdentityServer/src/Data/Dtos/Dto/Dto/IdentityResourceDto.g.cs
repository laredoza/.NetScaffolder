
// <copyright file="IdentityResourceDto.g.cs" company="MIT">
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
	public partial class IdentityResourceDto
	{
		#region CTOR
		
		public IdentityResourceDto()
		{
			this.IdentityResourceClaimType = new List <IdentityResourceClaimTypeDto>();
		}
		
		public IdentityResourceDto(IIdentityResource item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Name = item.Name;
			this.DisplayName = item.DisplayName;
			this.ShowInDiscoveryDocument = item.ShowInDiscoveryDocument;
			this.Required = item.Required;
			this.Emphasize = item.Emphasize;
			this.IdentityResourceClaimType = new List <IdentityResourceClaimTypeDto>();

			if(deep)
			{
				if(item.IdentityResourceClaimType != null)
				{
					foreach(var childItem in item.IdentityResourceClaimType)
					{
						this.IdentityResourceClaimType.Add(new IdentityResourceClaimTypeDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public bool ShowInDiscoveryDocument { get; set; }
		public bool Required { get; set; }
		public bool Emphasize { get; set; }

		#endregion
		
		#region Child Relationships
		
        // [JsonConverter(typeof(ConcreteTypeConverter<IdentityResourceClaimTypeDto>))]
		public IList<IdentityResourceClaimTypeDto> IdentityResourceClaimType { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
