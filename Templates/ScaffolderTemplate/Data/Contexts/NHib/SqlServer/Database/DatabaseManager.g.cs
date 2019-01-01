
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
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Contexts.NHib.Base.Context;
using DotNetScaffolder.Domain.Core.Interfaces;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.Context;
using System;
using System.Collections.Generic;
using StructureMap;
using StructureMap.Pipeline;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.Database
{
	public class DatabaseManager : IDatabaseManager
	{	
     	private static FluentConfiguration Configuration;
	    private static ISessionFactory Factory;   
                

		#region CTOR
		
		public DatabaseManager()
		{
		}
		
		#endregion
		
        /// <summary>
	    /// The register unit of work.
	    /// </summary>
	    /// <param name="configuration">
	    /// The configuration.
	    /// </param>
	    /// <param name="container">
	    /// The container.
	    /// </param>
	    /// <param name="serviceProvider">
	    /// The service provider.
	    /// </param>
	    /// <exception cref="Exception">
	    /// </exception>
	    public void RegisterUnitOfWork(
	        IDataConfiguration configuration,
	        IContainer container,
	        IServiceProvider serviceProvider = null)
	    {
	        if (configuration == null || configuration.ConnectionStrings == null
	                                  || !configuration.ConnectionStrings.ContainsKey("RepoTestSqlServer"))
	        {
	            throw new Exception("Invalid configuration specified in database manager");
	        }

            var nHibConfig = MsSqlConfiguration.MsSql2012.ConnectionString(configuration.ConnectionStrings["RepoTestSqlServer"]);
             Configuration = Fluently.Configure().Database(nHibConfig)
               .Mappings(o => o.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()));
             Factory = Configuration.BuildSessionFactory();

             container.Configure(
             config =>
             {
                config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use<SqlServerFullContext>()
                 .Ctor<ISessionFactory>("factory").Is(Factory);
             });

            // End
	    }
        
	}
}
