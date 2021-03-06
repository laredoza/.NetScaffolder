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



using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Contexts.EFCore.Base.Context;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System;
using DotNetScaffolder.Domain.Data.Contexts.EFCore.Seed;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.Context
{
	public partial class SqlServerFullContext 
	{	
        #region Public Methods And Operators

        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        public void Seed(ModelBuilder modelBuilder)
        {
            MigrationHelper.AddCountries(modelBuilder);
            MigrationHelper.AddProducts(modelBuilder);
            MigrationHelper.AddCustomers(modelBuilder);
            MigrationHelper.AddBanking(modelBuilder);
            MigrationHelper.AddOrders(modelBuilder);
        }

        #endregion		
	}
}
