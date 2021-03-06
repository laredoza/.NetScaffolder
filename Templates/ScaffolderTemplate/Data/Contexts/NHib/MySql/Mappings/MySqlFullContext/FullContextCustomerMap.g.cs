﻿
// <copyright file="CustomerMap.g.cs" company="MIT">
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
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;
using FluentNHibernate.Mapping;


namespace DotNetScaffolder.Domain.Data.Contexts.NHib.MySql.Mappings.MySqlFullContext
{
	public partial class FullContextCustomerMap : ClassMap<Customer>
	{	
		public FullContextCustomerMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("Customer");
			
			#region Primary Keys
			
			Id(t => t.CustomerId).GeneratedBy.Assigned()
			.UniqueKey("UQ__Customer__A4AE64D98B60CE6B")
			.Not.Nullable();

			#endregion

			#region Properties
			
			Map(t => t.CustomerCode).Column("CustomerCode")
			.Length(5)
			.Not.Nullable();
			Map(t => t.CompanyName).Column("CompanyName")
			.Length(50)
			.Not.Nullable();
			Map(t => t.ContactName).Column("ContactName")
			.Length(50)
			.Nullable();
			Map(t => t.ContactTitle).Column("ContactTitle")
			.Length(50)
			.Nullable();
			Map(t => t.Address).Column("Address")
			.Length(50)
			.Nullable();
			Map(t => t.City).Column("City")
			.Length(20)
			.Nullable();
			Map(t => t.PostalCode).Column("PostalCode")
			.Length(10)
			.Nullable();
			Map(t => t.Telephone).Column("Telephone")
			.Length(50)
			.Nullable();
			Map(t => t.Fax).Column("Fax")
			.Length(50)
			.Nullable();
			Map(t => t.CountryId).Column("CountryId")
			.Index("IX_CountryId")
			.Nullable();
			Map(t => t.Photo).Column("Photo")
			.Length(255)
			.Nullable();
			Map(t => t.IsEnabled).Column("IsEnabled")
			.Not.Nullable();
			
			#endregion
			
			#region Relationships
			
			References(o => o.Country).Column("CountryId").Unique().Not.Insert().Not.Update();
			HasMany(s => s.BankAccount).KeyColumn("CustomerId");
			HasMany(s => s.Order).KeyColumn("CustomerId");
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
