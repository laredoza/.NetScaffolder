﻿
// <copyright file="BankTransfersMap.g.cs" company="MIT">
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

namespace RepositoryEFDotnet.Data.Accounts.Mappings.NHib.Oracle
{
	public partial class AccountContextBankTransfersMap : ClassMap<BankTransfers>
	{	
		public AccountContextBankTransfersMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("BankTransfers");
			
			#region Primary Keys
			
			Id(t => t.BankTransferId).GeneratedBy.Assigned()
			.UniqueKey("UQ__BankTran__2E82727AB11DB584")
			.Not.Nullable();

			#endregion

			#region Properties
			
			Map(t => t.FromBankAccountId).Column("FromBankAccountId")
			.Not.Nullable();
			Map(t => t.ToBankAccountId).Column("ToBankAccountId")
			.Index("IX_ToBankAccountId")
			.Not.Nullable();
			Map(t => t.Amount).Column("Amount")
			.Precision(18).Scale(2)
			.Not.Nullable();
			Map(t => t.TransferDate).Column("TransferDate")
			.Not.Nullable();
			Map(t => t.BankAccountId).Column("BankAccountId")
			.UniqueKey("UQ__BankTran__4FC8E4A0CE69E10D")
			.Nullable();
			
			#endregion
			
			#region Relationships
			
			References(o => o.BankAccount).Column("BankAccountId").Unique().Not.Insert().Not.Update();
			References(o => o.BankAccount1).Column("BankAccountId").Unique().Not.Insert().Not.Update();
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
