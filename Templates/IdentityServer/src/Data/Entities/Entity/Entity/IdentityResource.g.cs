
// <copyright file="IdentityResource.g.cs" company="MIT">
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
	public partial class IdentityResource : IIdentityResource 
	{
		#region CTOR
		
		public IdentityResource()
		{
			this.IdentityResourceClaimType = new List <IdentityResourceClaimType>();
		}
		
		public IdentityResource(IIdentityResource item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Name = item.Name;
			this.DisplayName = item.DisplayName;
			this.ShowInDiscoveryDocument = item.ShowInDiscoveryDocument;
			this.Required = item.Required;
			this.Emphasize = item.Emphasize;
			this.IdentityResourceClaimType = new List <IdentityResourceClaimType>();

			if(deep)
			{
				if(item.IdentityResourceClaimType != null)
				{
					foreach(var childItem in item.IdentityResourceClaimType)
					{
						this.IdentityResourceClaimType.Add(new IdentityResourceClaimType(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string DisplayName { get; set; }
		public virtual bool ShowInDiscoveryDocument { get; set; }
		public virtual bool Required { get; set; }
		public virtual bool Emphasize { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<IdentityResourceClaimType> IdentityResourceClaimType { get; set; }
	
        IList<IIdentityResourceClaimType> IIdentityResource.IdentityResourceClaimType 
		{ 
			get
			{
				return this.IdentityResourceClaimType == null ? null : this.IdentityResourceClaimType as IList<IIdentityResourceClaimType>;
			}
			set
			{
				if(value != this.IdentityResourceClaimType)
				{
					if(value != null)
					{
						this.IdentityResourceClaimType = (IList<IdentityResourceClaimType>)value;
					}
					else
					{
						this.IdentityResourceClaimType = null;
					}
				}
			}			
		}

		#endregion
	}
}
