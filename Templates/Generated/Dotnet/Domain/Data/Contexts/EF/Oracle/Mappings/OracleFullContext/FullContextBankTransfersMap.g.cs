﻿
// <copyright file="BankTransfersMap.g.cs" company="MIT">
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using Oracle.ManagedDataAccess.Client;
using Oracle.Config;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EF.Oracle.Mappings.OracleFullContext
{
	public partial class FullContextBankTransfersMap : EntityTypeConfiguration<BankTransfers>
	{	
		public FullContextBankTransfersMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("BankTransfers", "DBO");
			
			#region Primary Keys
			
			HasKey(t => t.BankTransferId);
			Property(t => t.BankTransferId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.BankTransferId).IsRequired();
			Property(t => t.FromBankAccountId).IsRequired();
			Property(t => t.ToBankAccountId).IsRequired();
			Property(t => t.Amount).IsRequired();
			Property(t => t.Amount).HasPrecision(18, 2);
			Property(t => t.TransferDate).IsRequired();
			
			#endregion
			
			#region Indexes
			Property(t => t.BankTransferId).HasColumnAnnotation("UQ__BankTran__2E82727AB11DB584", new IndexAnnotation(new [] { new IndexAttribute("UQ__BankTran__2E82727AB11DB584"){ IsClustered = false, IsUnique = true, Order = 0}}));
			Property(t => t.ToBankAccountId).HasColumnAnnotation("IX_ToBankAccountId", new IndexAnnotation(new [] { new IndexAttribute("IX_ToBankAccountId"){ IsClustered = false, IsUnique = false, Order = 0}}));
			#endregion

			#region Relationships
			
			HasRequired<BankAccount>(s => s.BankAccount).WithMany(s => s.BankTransfers).HasForeignKey(s => s.ToBankAccountId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.BankTransferId).HasColumnOrder(1);
			Property(t => t.FromBankAccountId).HasColumnOrder(2);
			Property(t => t.ToBankAccountId).HasColumnOrder(3);
			Property(t => t.Amount).HasColumnOrder(4);
			Property(t => t.TransferDate).HasColumnOrder(5);

			#endregion
	
		}
	}
}
