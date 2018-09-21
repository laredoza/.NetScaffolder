
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using Oracle.ManagedDataAccess.Client;
using Oracle.Config;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EF.Oracle
{
	public partial class BankAccountMap : EntityTypeConfiguration<BankAccount>
	{	
		public BankAccountMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("BankAccount", "DBO");
			
			#region Primary Keys
			
			HasKey(t => t.BankAccountId);
			Property(t => t.BankAccountId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.BankAccountId).IsRequired();
			Property(t => t.BankAccountNumber).HasMaxLength(10);
			Property(t => t.BankAccountNumber).IsRequired();
			Property(t => t.Balance).IsRequired();
			Property(t => t.Balance).HasPrecision(19, 4);
			Property(t => t.CustomerId).IsOptional();
			Property(t => t.Locked).IsRequired();
			
			#endregion
			
			#region Indexes
			#endregion

			#region Relationships
			
			HasOptional<Customer>(s => s.Customer).WithMany(s => s.BankAccount).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			HasMany<BankTransfers>(s => s.BankTransfers).WithRequired(s => s.BankAccount).HasForeignKey(s => s.ToBankAccountId).WillCascadeOnDelete(false);
			HasMany<BankTransfers>(s => s.BankTransfers1).WithOptional(s => s.BankAccount1).HasForeignKey(s => s.BankAccountId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.BankAccountId).HasColumnOrder(1);
			Property(t => t.BankAccountNumber).HasColumnOrder(2);
			Property(t => t.Balance).HasColumnOrder(3);
			Property(t => t.CustomerId).HasColumnOrder(4);
			Property(t => t.Locked).HasColumnOrder(5);

			#endregion
	
		}
	}
}
