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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.MySql.Mappings.MySqlFullContext
{
	public partial class FullContextBankTransfersMap : IEntityTypeConfiguration<BankTransfers>
	{	
	    public virtual void Configure(EntityTypeBuilder<BankTransfers> builder)
	    {
			builder.ToTable("BankTransfers");
			
			#region Primary keys
			
			builder.HasKey(t => t.BankTransferId);
			builder.Property(t => t.BankTransferId).HasColumnName("BankTransferId").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.BankTransferId).HasColumnName("BankTransferId").IsRequired();
			builder.Property(t => t.FromBankAccountId).HasColumnName("FromBankAccountId").IsRequired();
			builder.Property(t => t.ToBankAccountId).HasColumnName("ToBankAccountId").IsRequired();
			builder.Property(t => t.Amount).HasColumnName("Amount").IsRequired();
			builder.Property(t => t.Amount).HasColumnType("decimal(18, 2)");
			builder.Property(t => t.TransferDate).HasColumnName("TransferDate").IsRequired();
			
			#endregion

			#region Indexes
			builder.HasIndex(i => new {i.BankTransferId}).HasName("UQ__BankTran__2E82727AB11DB584").IsUnique(true);
			builder.HasIndex(i => new {i.ToBankAccountId}).HasName("IX_ToBankAccountId").IsUnique(false);
			#endregion
			
			#region Relationships
			
			builder.HasOne<BankAccount>(s => s.BankAccount).WithMany(s => s.BankTransfers).HasForeignKey(s => s.ToBankAccountId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	

			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.BankTransferId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.FromBankAccountId).HasColumnOrder(2);
			//TODO: builder.Property(t => t.ToBankAccountId).HasColumnOrder(3);
			//TODO: builder.Property(t => t.Amount).HasColumnOrder(4);
			//TODO: builder.Property(t => t.TransferDate).HasColumnOrder(5);

			#endregion	
	    }
	}
}
