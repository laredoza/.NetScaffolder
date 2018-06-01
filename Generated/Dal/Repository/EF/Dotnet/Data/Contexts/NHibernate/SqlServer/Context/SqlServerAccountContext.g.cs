﻿
// <copyright file="AccountContext.g.cs" company="MIT">
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

using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using Banking.Models.Accounts.Mappings;
using RepositoryEFDotnet.Contexts.NHibernate;
using System.Data;

namespace Banking.Models.Accounts.NHibernate
{
	public partial class SqlServerAccountContext : BaseContext
	{	
		#region CTOR
		
		// Use in memory as target
	    public SqlServerAccountContext(MsSqliteConfiguration config, bool showSql = false)
	    {
			if(showSql)
			{
				config.InMemory().ShowSql();
			}
			else
			{
				config.InMemory();
			}
			
	        CreateSession(config);
        }
		
		// Use db as target
	    public SqlServerAccountContext(MsSqlConfiguration config)
	    {
            config.IsolationLevel(IsolationLevel.ReadCommitted);
            CreateSession(config);
	    }
		
		#endregion
		
	    protected override void ConfigureMappings(MappingConfiguration config)
	    {
			config.FluentMappings.Add(typeof(BankAccountMap));
			config.FluentMappings.Add(typeof(BankTransfersMap));
        }
	}
}
