﻿
// <copyright file="FullContext.g.cs" company="MIT">
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
using Banking.Models.Context.Mappings.NHib.MySql;
using RepositoryEFDotnet.Contexts.NHib;

namespace Banking.Models.Context.NHib
{
	public partial class MySqlFullContext : BaseContext
	{	
		#region CTOR
		
		// Use other target e.g. in memory sqlite
	    public MySqlFullContext(Configuration config)
	    {
			SetConfig(config);
        }
		
		// Use db as target
	    public MySqlFullContext(MySQLConfiguration config)
	    {
            config.IsolationLevel(IsolationLevel.ReadCommitted);
            SetConfig(config);
	    }
		
		#endregion
		
	    protected override void ConfigureMappings(MappingConfiguration config)
	    {
			config.FluentMappings.Add(typeof(BankAccountMap));
			config.FluentMappings.Add(typeof(BankTransfersMap));
			config.FluentMappings.Add(typeof(BookMap));
			config.FluentMappings.Add(typeof(CountryMap));
			config.FluentMappings.Add(typeof(CustomerMap));
			config.FluentMappings.Add(typeof(OrderMap));
			config.FluentMappings.Add(typeof(OrderDetailsMap));
			config.FluentMappings.Add(typeof(ProductMap));
        }
	}
}
