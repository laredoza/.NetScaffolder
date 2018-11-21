
// <copyright file="CustomerContext.g.cs" company="MIT">
//  Copyright (c) 2018 MIT
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
using RepositoryEFDotnet.Core.Base;
using Banking.Models.Customers.Mappings.NHib.Oracle;
using Quirc.DataAccess.Context.NHib.Base;

namespace Banking.Models.Customers.NHib
{
	public partial class OracleCustomerContext : BaseContext
	{	
		#region CTOR
		
		// Use other target e.g. in memory sqlite
	    public OracleCustomerContext(Configuration config) : base(config)
	    {
        }
		
		// Use db as target
	    public OracleCustomerContext(OracleDataClientConfiguration config) : base(config)
	    {
            config.IsolationLevel(IsolationLevel.ReadCommitted);
	    }
		
		// Use external factory
	    public OracleCustomerContext(ISessionFactory factory) : base(factory)
	    {
	    }
		
		// Use persistence configurer
	    public OracleCustomerContext(IPersistenceConfigurer config) : base(config)
	    {
	    }
		
		// Use Fluent Configuration
	    public OracleCustomerContext(FluentConfiguration config) : base(config)
	    {
	    }
		
		#endregion
		
	    protected override void ConfigureMappings(MappingConfiguration config)
	    {
			config.FluentMappings.Add(typeof(CustomerContextBookMap));
			config.FluentMappings.Add(typeof(CustomerContextCountryMap));
			config.FluentMappings.Add(typeof(CustomerContextCustomerMap));
			config.FluentMappings.Add(typeof(CustomerContextOrderMap));
			config.FluentMappings.Add(typeof(CustomerContextOrderDetailsMap));
			config.FluentMappings.Add(typeof(CustomerContextProductMap));
			config.FluentMappings.Add(typeof(CustomerContextSoftwareMap));
        }
	}
}
