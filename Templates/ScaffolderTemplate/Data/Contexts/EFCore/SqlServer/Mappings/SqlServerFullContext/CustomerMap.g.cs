
// <copyright file="CustomerMap.g.cs" company="MIT">
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
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EFCore.SqlServer
{
	public partial class CustomerMap : IEntityTypeConfiguration<Customer>
	{	
	    public virtual void Configure(EntityTypeBuilder<Customer> builder)
	    {
			builder.ToTable("[Customer]", "[dbo]");
			
			#region Primary keys
			
			builder.HasKey(t => t.CustomerId);
			builder.Property(t => t.CustomerId).HasColumnName("CustomerId").ValueGeneratedNever();

			#endregion

			#region Constraints
			
			builder.Property(t => t.CustomerId).HasColumnName("CustomerId").IsRequired();
			builder.Property(t => t.CustomerCode).HasMaxLength(5);
			builder.Property(t => t.CustomerCode).HasColumnName("CustomerCode").IsRequired();
			builder.Property(t => t.CompanyName).HasMaxLength(50);
			builder.Property(t => t.CompanyName).HasColumnName("CompanyName").IsRequired();
			builder.Property(t => t.ContactName).HasMaxLength(50);
			builder.Property(t => t.ContactName).HasColumnName("ContactName").IsRequired(false);
			builder.Property(t => t.ContactTitle).HasMaxLength(50);
			builder.Property(t => t.ContactTitle).HasColumnName("ContactTitle").IsRequired(false);
			builder.Property(t => t.Address).HasMaxLength(50);
			builder.Property(t => t.Address).HasColumnName("Address").IsRequired(false);
			builder.Property(t => t.City).HasMaxLength(20);
			builder.Property(t => t.City).HasColumnName("City").IsRequired(false);
			builder.Property(t => t.PostalCode).HasMaxLength(10);
			builder.Property(t => t.PostalCode).HasColumnName("PostalCode").IsRequired(false);
			builder.Property(t => t.Telephone).HasMaxLength(50);
			builder.Property(t => t.Telephone).HasColumnName("Telephone").IsRequired(false);
			builder.Property(t => t.Fax).HasMaxLength(50);
			builder.Property(t => t.Fax).HasColumnName("Fax").IsRequired(false);
			builder.Property(t => t.CountryId).HasColumnName("CountryId").IsRequired(false);
			builder.Property(t => t.Photo).HasMaxLength(255);
			builder.Property(t => t.Photo).HasColumnName("Photo").IsRequired(false);
			builder.Property(t => t.IsEnabled).HasColumnName("IsEnabled").IsRequired();
			
			#endregion

			#region Indexes
			builder.HasIndex(i => new {i.CustomerId}).HasName("UQ__Customer__A4AE64D98B60CE6B").IsUnique(true);
			builder.HasIndex(i => new {i.CountryId}).HasName("IX_CountryId").IsUnique(false);
			#endregion
			
			#region Relationships
			
			builder.HasOne<Country>(s => s.Country).WithMany(s => s.Customer).HasForeignKey(s => s.CountryId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<BankAccount>(s => s.BankAccount).WithOne(s => s.Customer).HasForeignKey(s => s.CustomerId).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<Order>(s => s.Order).WithOne(s => s.Customer).HasForeignKey(s => s.CustomerId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.CustomerId).HasColumnOrder(1);
			//TODO: builder.Property(t => t.CustomerCode).HasColumnOrder(2);
			//TODO: builder.Property(t => t.CompanyName).HasColumnOrder(3);
			//TODO: builder.Property(t => t.ContactName).HasColumnOrder(4);
			//TODO: builder.Property(t => t.ContactTitle).HasColumnOrder(5);
			//TODO: builder.Property(t => t.Address).HasColumnOrder(6);
			//TODO: builder.Property(t => t.City).HasColumnOrder(7);
			//TODO: builder.Property(t => t.PostalCode).HasColumnOrder(8);
			//TODO: builder.Property(t => t.Telephone).HasColumnOrder(9);
			//TODO: builder.Property(t => t.Fax).HasColumnOrder(10);
			//TODO: builder.Property(t => t.CountryId).HasColumnOrder(11);
			//TODO: builder.Property(t => t.Photo).HasColumnOrder(12);
			//TODO: builder.Property(t => t.IsEnabled).HasColumnOrder(13);

			#endregion	
	    }
	}
}
