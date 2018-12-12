
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
using RepositoryEFDotnet.Contexts.EFCore.Base.Context;
using RepositoryEFDotnet.Core.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using RepositoryEFDotnet.Data.Context.EFCore;
using System;
using System.Collections.Generic;
using StructureMap;
using StructureMap.Pipeline;
using RepositoryEFDotnet.Contexts.EFCore.Base;

namespace RepositoryEFDotnet.Data.Context.EFCore.SqlServer.Database
{
	public class DatabaseManager : IDatabaseManager
	{	
    
                

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
	                                  || !configuration.ConnectionStrings.ContainsKey("QUIRCSqlServer"))
	        {
	            throw new Exception("Invalid configuration specified in database manager");
	        }

            container.Configure(
                 config =>
                 {
                    config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use<SqlServerFullContext>()
                         .Ctor<string>("connectionString").Is(configuration.ConnectionStrings["RepoTestSqlServer"]);
                 });

            // End
	    }
        
	}
}
