
// <copyright file="CustomerMap.g.cs.g.cs" company="MIT">
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
using RepositoryEFDotnet.Contexts.EFCore;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;


namespace Banking.Models.Mappings.SqlServer
{
	public partial class CustomerMap : IEntityTypeConfiguration<Customer>
	{	
	    public void Configure(EntityTypeBuilder<Customer> builder)
	    {
			builder.ToTable("Customer", "dbo");
			
			#region Primary keys
			
			builder.HasKey(t => t.CustomerId);
			builder.Property(t => t.CustomerId).ValueGeneratedOnAdd();

			#endregion

			#region Constraints
			
			builder.Property(t => t.CustomerId).IsRequired();
			builder.Property(t => t.CustomerCode).HasMaxLength(5);
			builder.Property(t => t.CustomerCode).IsRequired();
			builder.Property(t => t.CompanyName).HasMaxLength(50);
			builder.Property(t => t.CompanyName).IsRequired();
			builder.Property(t => t.ContactName).HasMaxLength(50);
			builder.Property(t => t.ContactName).IsRequired(false);
			builder.Property(t => t.ContactTitle).HasMaxLength(50);
			builder.Property(t => t.ContactTitle).IsRequired(false);
			builder.Property(t => t.Address).HasMaxLength(50);
			builder.Property(t => t.Address).IsRequired(false);
			builder.Property(t => t.City).HasMaxLength(20);
			builder.Property(t => t.City).IsRequired(false);
			builder.Property(t => t.PostalCode).HasMaxLength(10);
			builder.Property(t => t.PostalCode).IsRequired(false);
			builder.Property(t => t.Telephone).HasMaxLength(50);
			builder.Property(t => t.Telephone).IsRequired(false);
			builder.Property(t => t.Fax).HasMaxLength(50);
			builder.Property(t => t.Fax).IsRequired(false);
			builder.Property(t => t.CountryId).IsRequired(false);
			builder.Property(t => t.Photo).HasMaxLength(2147483647);
			builder.Property(t => t.Photo).IsRequired(false);
			builder.Property(t => t.IsEnabled).IsRequired();
			
			#endregion

			#region Relationships
			
			builder.HasMany<Order>(s => s.Order).WithOne(s => s.Customer).HasForeignKey(s => s.CustomerId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
	    }
	}
}
