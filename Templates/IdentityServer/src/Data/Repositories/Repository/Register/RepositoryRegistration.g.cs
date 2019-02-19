
// <copyright file="RepositoryRegistration.g.cs" company="MIT">
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
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using StructureMap.Pipeline;

namespace DotNetScaffolder.Domain.Data.Repositories.Repository.Register
{
	public class RepositoryRegistration : StructureMap.Registry
	{			
		#region CTOR
		
        public RepositoryRegistration()
        {
			this.For<IAspNetRoleRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetRoleRepository>();
			this.For<IAspNetRoleClaimRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetRoleClaimRepository>();
			this.For<IAspNetUserRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetUserRepository>();
			this.For<IAspNetUserClaimRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetUserClaimRepository>();
			this.For<IAspNetUserLoginRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetUserLoginRepository>();
			this.For<IAspNetUserRoleRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetUserRoleRepository>();
			this.For<IAspNetUserTokenRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AspNetUserTokenRepository>();
			this.For<IAllowedScopeRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<AllowedScopeRepository>();
			this.For<IApiResourceRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<ApiResourceRepository>();
			this.For<IClientRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<ClientRepository>();
			this.For<IClientGrantTypeRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<ClientGrantTypeRepository>();
			this.For<IGrantTypeRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<GrantTypeRepository>();
			this.For<IIdentityResourceRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<IdentityResourceRepository>();
			this.For<IIdentityResourceClaimTypeRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<IdentityResourceClaimTypeRepository>();
			this.For<IPostLogoutRedirectUriRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<PostLogoutRedirectUriRepository>();
			this.For<IRedirectUriRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<RedirectUriRepository>();
			this.For<IResourceClaimTypeRepository>().LifecycleIs(Lifecycles.Unique).UseIfNone<ResourceClaimTypeRepository>();
        }
		
		#endregion
	}
}
