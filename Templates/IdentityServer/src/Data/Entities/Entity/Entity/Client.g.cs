
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
	public partial class Client : IClient 
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

		#endregion

		#region Child Relationships
        
        public virtual IList<AllowedScope> AllowedScope { get; set; }
	
        IList<IAllowedScope> IClient.AllowedScope 
		{ 
			get
			{
				return this.AllowedScope == null ? null : this.AllowedScope as IList<IAllowedScope>;
			}
			set
			{
				if(value != this.AllowedScope)
				{
					if(value != null)
					{
						this.AllowedScope = (IList<AllowedScope>)value;
					}
					else
					{
						this.AllowedScope = null;
					}
				}
			}			
		}
        
        public virtual IList<ClientGrantType> ClientGrantType { get; set; }
	
        IList<IClientGrantType> IClient.ClientGrantType 
		{ 
			get
			{
				return this.ClientGrantType == null ? null : this.ClientGrantType as IList<IClientGrantType>;
			}
			set
			{
				if(value != this.ClientGrantType)
				{
					if(value != null)
					{
						this.ClientGrantType = (IList<ClientGrantType>)value;
					}
					else
					{
						this.ClientGrantType = null;
					}
				}
			}			
		}
        
        public virtual IList<PostLogoutRedirectUri> PostLogoutRedirectUri { get; set; }
	
        IList<IPostLogoutRedirectUri> IClient.PostLogoutRedirectUri 
		{ 
			get
			{
				return this.PostLogoutRedirectUri == null ? null : this.PostLogoutRedirectUri as IList<IPostLogoutRedirectUri>;
			}
			set
			{
				if(value != this.PostLogoutRedirectUri)
				{
					if(value != null)
					{
						this.PostLogoutRedirectUri = (IList<PostLogoutRedirectUri>)value;
					}
					else
					{
						this.PostLogoutRedirectUri = null;
					}
				}
			}			
		}
        
        public virtual IList<RedirectUri> RedirectUri { get; set; }
	
        IList<IRedirectUri> IClient.RedirectUri 
		{ 
			get
			{
				return this.RedirectUri == null ? null : this.RedirectUri as IList<IRedirectUri>;
			}
			set
			{
				if(value != this.RedirectUri)
				{
					if(value != null)
					{
						this.RedirectUri = (IList<RedirectUri>)value;
					}
					else
					{
						this.RedirectUri = null;
					}
				}
			}			
		}

		#endregion
	}
}
