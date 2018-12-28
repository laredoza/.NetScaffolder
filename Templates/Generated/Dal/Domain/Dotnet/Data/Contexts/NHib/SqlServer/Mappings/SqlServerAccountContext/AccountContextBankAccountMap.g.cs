
// <copyright file="BankAccountMap.g.cs" company="MIT">
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
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using RepositoryEFDotnet.Data.Entity;
using System.Data.Common;
using FluentNHibernate.Mapping;

namespace RepositoryEFDotnet.Data.Accounts.Mappings.NHib.SqlServer
{
	public partial class AccountContextBankAccountMap : ClassMap<BankAccount>
	{	
		public AccountContextBankAccountMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("BankAccount");
			Schema("dbo");
			
			#region Primary Keys
			
			Id(t => t.BankAccountId).GeneratedBy.Assigned()
			.UniqueKey("UQ__BankAcco__4FC8E4A0C45281C8")
			.Not.Nullable();

			#endregion

			#region Properties
			
			Map(t => t.BankAccountNumber).Column("BankAccountNumber")
			.Length(10)
			.Not.Nullable();
			Map(t => t.Balance).Column("Balance")
			.Precision(19).Scale(4)
			.Not.Nullable();
			Map(t => t.CustomerId).Column("CustomerId")
			.Index("IX_CustomerId")
			.Nullable();
			Map(t => t.Locked).Column("Locked")
			.Not.Nullable();
			
			#endregion
			
			#region Relationships
			
			HasMany(s => s.BankTransfers).KeyColumn("ToBankAccountId");
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
