﻿
// <copyright file="BankAccountMap.g.cs.g.cs" company="MIT">
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryEFDotnet.Contexts.EFCore;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;


namespace Banking.Models.Mappings.MySql
{
	public partial class BankAccountMap : IEntityTypeConfiguration<BankAccount>
	{	
	    public void Configure(EntityTypeBuilder<BankAccount> builder)
	    {
			builder.ToTable("BankAccount");
			
			#region Primary keys
			
			builder.HasKey(t => t.BankAccountId);
			builder.Property(t => t.BankAccountId).ValueGeneratedOnAdd();

			#endregion

			#region Constraints
			
			builder.Property(t => t.BankAccountId).IsRequired();
			builder.Property(t => t.BankAccountNumber).HasMaxLength(10);
			builder.Property(t => t.BankAccountNumber).IsRequired();
			builder.Property(t => t.Balance).IsRequired();
			builder.Property(t => t.Balance).HasColumnType("decimal(19, 0)");
			builder.Property(t => t.CustomerId).IsRequired(false);
			builder.Property(t => t.Locked).IsRequired();
			
			#endregion

			#region Relationships
			
			builder.HasMany<BankTransfers>(s => s.BankTransfersFrom).WithOne(s => s.FromBankAccount).HasForeignKey(s => s.FromBankAccountId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<BankTransfers>(s => s.BankTransfersTo).WithOne(s => s.ToBankAccount).HasForeignKey(s => s.ToBankAccountId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
	    }
	}
}
