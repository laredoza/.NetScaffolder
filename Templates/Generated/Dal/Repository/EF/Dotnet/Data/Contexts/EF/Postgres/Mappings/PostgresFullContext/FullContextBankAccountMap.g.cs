﻿
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

using Npgsql;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using RepositoryEFDotnet.Data.Entity;
using System.Data.Common;

namespace RepositoryEFDotnet.Data.Context.Mappings.EF.Postgres
{
	public partial class FullContextBankAccountMap : EntityTypeConfiguration<BankAccount>
	{	
		public FullContextBankAccountMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("BankAccount", "dbo");
			
			#region Primary Keys
			
			HasKey(t => t.BankAccountId);
			Property(t => t.BankAccountId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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
			Property(t => t.Balance).HasColumnAnnotation("NonClusteredIndex-20180611-172244", new IndexAnnotation(new [] { new IndexAttribute("NonClusteredIndex-20180611-172244"){ IsClustered = false, IsUnique = false, Order = 0}, new IndexAttribute("NonClusteredIndex-20180611-172244"){ IsClustered = false, IsUnique = false, Order = 1}}));
			Property(t => t.CustomerId).HasColumnAnnotation("IX_CustomerId", new IndexAnnotation(new [] { new IndexAttribute("IX_CustomerId"){ IsClustered = false, IsUnique = false, Order = 0}}));
			Property(t => t.Locked).HasColumnAnnotation("NonClusteredIndex-20180611-172244", new IndexAnnotation(new [] { new IndexAttribute("NonClusteredIndex-20180611-172244"){ IsClustered = false, IsUnique = false, Order = 0}, new IndexAttribute("NonClusteredIndex-20180611-172244"){ IsClustered = false, IsUnique = false, Order = 1}}));
			#endregion

			#region Relationships
			
			HasOptional<Customer>(s => s.Customer).WithMany(s => s.BankAccount).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			HasMany<BankTransfers>(s => s.BankTransfers1).WithRequired(s => s.BankAccount1).HasForeignKey(s => s.FromBankAccountId).WillCascadeOnDelete(false);
			HasMany<BankTransfers>(s => s.BankTransfers).WithRequired(s => s.BankAccount).HasForeignKey(s => s.ToBankAccountId).WillCascadeOnDelete(false);
			
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
