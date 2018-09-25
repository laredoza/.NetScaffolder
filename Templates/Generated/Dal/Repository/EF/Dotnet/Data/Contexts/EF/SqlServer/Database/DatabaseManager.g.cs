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
using RepositoryEFDotnet.Core.Base;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using Banking.Models.Context.EF;
using System;
using System.Collections.Generic;

namespace Banking.Models.Context.SqlServer.EF.Database
{
	public class DatabaseManager : IDatabaseManager
	{	
		private IDictionary<string, string> configuration;
		
		#region CTOR
		
		public DatabaseManager(IDictionary<string, string> configuration)
		{
			this.configuration = configuration;
		}
		
		#endregion
		
        /// <summary>
        /// The begin unit of work.
        /// </summary>
        /// <returns>
        /// The <see cref="IUnitOfWork"/>.
        /// </returns>
        public virtual IUnitOfWork BeginUnitOfWork()
        {
            if (this.configuration == null || !this.configuration.ContainsKey("QUIRCSqlServer"))
            {
                throw new Exception("Invalid configuration specified in database manager");
            }

			return new SqlServerFullContext(this.configuration["QUIRCSqlServer"]);
        }
	}
}