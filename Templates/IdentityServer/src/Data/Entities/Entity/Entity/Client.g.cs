
// <copyright file="Client.g.cs" company="MIT">
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
	public partial class Client 
	{
		#region CTOR
		
		public Client()
		{
			this.AllowedScope = new List <AllowedScope>();
			this.ClientGrantType = new List <ClientGrantType>();
			this.PostLogoutRedirectUri = new List <PostLogoutRedirectUri>();
			this.RedirectUri = new List <RedirectUri>();
		}
		
		public Client(IClient item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.ClientId = item.ClientId;
			this.ClientName = item.ClientName;
			this.AlwaysSendClientClaims = item.AlwaysSendClientClaims;
			this.Active = item.Active;
			this.AllowedScope = new List <AllowedScope>();
			this.ClientGrantType = new List <ClientGrantType>();
			this.PostLogoutRedirectUri = new List <PostLogoutRedirectUri>();
			this.RedirectUri = new List <RedirectUri>();

			if(deep)
			{
				if(item.AllowedScope != null)
				{
					foreach(var childItem in item.AllowedScope)
					{
						this.AllowedScope.Add(new AllowedScope(childItem, deep));
					}
				}
				if(item.ClientGrantType != null)
				{
					foreach(var childItem in item.ClientGrantType)
					{
						this.ClientGrantType.Add(new ClientGrantType(childItem, deep));
					}
				}
				if(item.PostLogoutRedirectUri != null)
				{
					foreach(var childItem in item.PostLogoutRedirectUri)
					{
						this.PostLogoutRedirectUri.Add(new PostLogoutRedirectUri(childItem, deep));
					}
				}
				if(item.RedirectUri != null)
				{
					foreach(var childItem in item.RedirectUri)
					{
						this.RedirectUri.Add(new RedirectUri(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int Id { get; set; }
		public virtual string ClientId { get; set; }
		public virtual string ClientName { get; set; }
		public virtual bool AlwaysSendClientClaims { get; set; }
		public virtual bool Active { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<AllowedScope> AllowedScope { get; set; }

        
        public virtual IList<ClientGrantType> ClientGrantType { get; set; }

        
        public virtual IList<PostLogoutRedirectUri> PostLogoutRedirectUri { get; set; }

        
        public virtual IList<RedirectUri> RedirectUri { get; set; }


		#endregion
	}
}
