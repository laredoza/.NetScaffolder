
// <copyright file="FullContext.g.cs" company="MIT">
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


using System.Data;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Contexts.NHib.Base.Context;
using DotNetScaffolder.Domain.Core.Interfaces;
using DotNetScaffolder.Domain.Data.Contexts.NHib.SqlServer.Mappings.SqlServerFullContext;

namespace DotNetScaffolder.Domain.Data.Contexts.NHib.SqlServer.Context
{
	public partial class SqlServerFullContext : BaseContext
	{	
		#region CTOR
		
		// Use other target e.g. in memory sqlite
	    public SqlServerFullContext(Configuration config) : base(config)
	    {
        }
		
		// Use db as target
	    public SqlServerFullContext(MsSqlConfiguration config) : base(config)
	    {
            config.IsolationLevel(IsolationLevel.ReadCommitted);
	    }
		
		// Use external factory
	    public SqlServerFullContext(ISessionFactory factory) : base(factory)
	    {
	    }
		
		// Use persistence configurer
	    public SqlServerFullContext(IPersistenceConfigurer config) : base(config)
	    {
	    }
		
		// Use Fluent Configuration
	    public SqlServerFullContext(FluentConfiguration config) : base(config)
	    {
	    }
		
		#endregion
		
	    protected override void ConfigureMappings(MappingConfiguration config)
	    {
			config.FluentMappings.Add(typeof(FullContextAllowedScopeMap));
			config.FluentMappings.Add(typeof(FullContextApiResourceMap));
			config.FluentMappings.Add(typeof(FullContextAspNetRoleMap));
			config.FluentMappings.Add(typeof(FullContextAspNetRoleClaimMap));
			config.FluentMappings.Add(typeof(FullContextAspNetUserMap));
			config.FluentMappings.Add(typeof(FullContextAspNetUserClaimMap));
			config.FluentMappings.Add(typeof(FullContextAspNetUserLoginMap));
			config.FluentMappings.Add(typeof(FullContextAspNetUserRoleMap));
			config.FluentMappings.Add(typeof(FullContextAspNetUserTokenMap));
			config.FluentMappings.Add(typeof(FullContextClientMap));
			config.FluentMappings.Add(typeof(FullContextClientGrantTypeMap));
			config.FluentMappings.Add(typeof(FullContextGrantTypeMap));
			config.FluentMappings.Add(typeof(FullContextIdentityResourceMap));
			config.FluentMappings.Add(typeof(FullContextIdentityResourceClaimTypeMap));
			config.FluentMappings.Add(typeof(FullContextPostLogoutRedirectUriMap));
			config.FluentMappings.Add(typeof(FullContextRedirectUriMap));
			config.FluentMappings.Add(typeof(FullContextResourceClaimTypeMap));
        }
	}
}
