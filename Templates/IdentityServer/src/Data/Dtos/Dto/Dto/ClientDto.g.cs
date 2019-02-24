
// <copyright file="ClientDto.g.cs" company="MIT">
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
	public partial class ClientDto
	{
		#region CTOR
		
		public ClientDto()
		{
			this.AllowedScope = new List <AllowedScopeDto>();
			this.ClientGrantType = new List <ClientGrantTypeDto>();
			this.PostLogoutRedirectUri = new List <PostLogoutRedirectUriDto>();
			this.RedirectUri = new List <RedirectUriDto>();
		}
		
		public ClientDto(IClient item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.ClientId = item.ClientId;
			this.ClientName = item.ClientName;
			this.AlwaysSendClientClaims = item.AlwaysSendClientClaims;
			this.Active = item.Active;
			this.AllowedScope = new List <AllowedScopeDto>();
			this.ClientGrantType = new List <ClientGrantTypeDto>();
			this.PostLogoutRedirectUri = new List <PostLogoutRedirectUriDto>();
			this.RedirectUri = new List <RedirectUriDto>();

			if(deep)
			{
				if(item.AllowedScope != null)
				{
					foreach(var childItem in item.AllowedScope)
					{
						this.AllowedScope.Add(new AllowedScopeDto(childItem, deep));
					}
				}
				if(item.ClientGrantType != null)
				{
					foreach(var childItem in item.ClientGrantType)
					{
						this.ClientGrantType.Add(new ClientGrantTypeDto(childItem, deep));
					}
				}
				if(item.PostLogoutRedirectUri != null)
				{
					foreach(var childItem in item.PostLogoutRedirectUri)
					{
						this.PostLogoutRedirectUri.Add(new PostLogoutRedirectUriDto(childItem, deep));
					}
				}
				if(item.RedirectUri != null)
				{
					foreach(var childItem in item.RedirectUri)
					{
						this.RedirectUri.Add(new RedirectUriDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public string ClientId { get; set; }
		public string ClientName { get; set; }
		public bool AlwaysSendClientClaims { get; set; }
		public bool Active { get; set; }

		#endregion
		
		#region Child Relationships
		
        // [JsonConverter(typeof(ConcreteTypeConverter<AllowedScopeDto>))]
		public IList<AllowedScopeDto> AllowedScope { get; set; }
        // [JsonConverter(typeof(ConcreteTypeConverter<ClientGrantTypeDto>))]
		public IList<ClientGrantTypeDto> ClientGrantType { get; set; }
        // [JsonConverter(typeof(ConcreteTypeConverter<PostLogoutRedirectUriDto>))]
		public IList<PostLogoutRedirectUriDto> PostLogoutRedirectUri { get; set; }
        // [JsonConverter(typeof(ConcreteTypeConverter<RedirectUriDto>))]
		public IList<RedirectUriDto> RedirectUri { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
