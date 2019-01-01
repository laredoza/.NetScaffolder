
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
using DotNetScaffolder.Domain.Data.Contexts.EFCore.Oracle.Mappings.OracleFullContext;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Oracle.Context
{
	public partial class OracleFullContext : BaseContext
	{	
		#region CTOR
		
		// Use other target e.g. in memory sqlite
	    public OracleFullContext(Configuration config) : base(config)
	    {
        }
		
		// Use db as target
	    public OracleFullContext(OracleDataClientConfiguration config) : base(config)
	    {
            config.IsolationLevel(IsolationLevel.ReadCommitted);
	    }
		
		// Use external factory
	    public OracleFullContext(ISessionFactory factory) : base(factory)
	    {
	    }
		
		// Use persistence configurer
	    public OracleFullContext(IPersistenceConfigurer config) : base(config)
	    {
	    }
		
		// Use Fluent Configuration
	    public OracleFullContext(FluentConfiguration config) : base(config)
	    {
	    }
		
		#endregion
		
	    protected override void ConfigureMappings(MappingConfiguration config)
	    {
			config.FluentMappings.Add(typeof(FullContextBankAccountMap));
			config.FluentMappings.Add(typeof(FullContextBankTransfersMap));
			config.FluentMappings.Add(typeof(FullContextBookMap));
			config.FluentMappings.Add(typeof(FullContextCountryMap));
			config.FluentMappings.Add(typeof(FullContextCustomerMap));
			config.FluentMappings.Add(typeof(FullContextOrderMap));
			config.FluentMappings.Add(typeof(FullContextOrderDetailsMap));
			config.FluentMappings.Add(typeof(FullContextProductMap));
			config.FluentMappings.Add(typeof(FullContextSoftwareMap));
        }
	}
}
