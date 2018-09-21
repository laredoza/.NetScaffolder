
// <copyright file="BankAccountMap.g.cs" company="Dot Net Scaffolder">
//  Copyright (c) 2018 MIT License
// </copyright>  

 // Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in th
// e Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subj
// ect to the following conditions: The above copyright notice and this permission 
// notice shall be included in all copies or substantial portions of the Software. 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLI
// ED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR 
// A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYR
// IGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WIT
// H THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************
using Banking.Models.Entity;
using FluentNHibernate.Mapping;

namespace Banking.Models.Context.Mappings.NHib.SqlServer
{
	public partial class BankAccountMap : ClassMap<BankAccount>
	{	
		public BankAccountMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("BankAccount");
			Schema("dbo");
			
			#region Primary Keys
			
			Id(t => t.BankAccountId).GeneratedBy.Assigned()
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
			.Nullable();
			Map(t => t.Locked).Column("Locked")
			.Not.Nullable();
			
			#endregion
			
			#region Relationships
			
			References(o => o.Customer).Column("CustomerId").Unique().Not.Insert().Not.Update();
			HasMany(s => s.BankTransfers).KeyColumn("ToBankAccountId");
			HasMany(s => s.BankTransfers1).KeyColumn("BankAccountId");
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
