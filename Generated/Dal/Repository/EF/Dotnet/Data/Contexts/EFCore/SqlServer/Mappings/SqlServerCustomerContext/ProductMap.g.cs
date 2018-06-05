
// <copyright file="ProductMap.g.cs.g.cs" company="MIT">
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


namespace Banking.Models.Customers.Mappings.SqlServer
{
	public partial class ProductMap : IEntityTypeConfiguration<Product>
	{	
	    public void Configure(EntityTypeBuilder<Product> builder)
	    {
			builder.ToTable("Product", "dbo");
			
			#region Primary keys
			
			builder.HasKey(t => t.ProductId);
			builder.Property(t => t.ProductId).ValueGeneratedOnAdd();

			#endregion

			#region Constraints
			
			builder.Property(t => t.ProductId).IsRequired();
			builder.Property(t => t.ProductDescription).HasMaxLength(100);
			builder.Property(t => t.ProductDescription).IsRequired(false);
			builder.Property(t => t.UnitPrice).IsRequired(false);
			builder.Property(t => t.UnitPrice).HasColumnType("decimal(19, 4)");
			builder.Property(t => t.UnitAmount).HasMaxLength(50);
			builder.Property(t => t.UnitAmount).IsRequired(false);
			builder.Property(t => t.Publisher).HasMaxLength(200);
			builder.Property(t => t.Publisher).IsRequired(false);
			builder.Property(t => t.AmountInStock).IsRequired(false);
			
			#endregion

			#region Relationships
			
			builder.HasOne<Book>(s => s.Book).WithOne(s => s.Product).OnDelete(DeleteBehavior.Restrict);
			builder.HasMany<OrderDetails>(s => s.OrderDetails).WithOne(s => s.Product).HasForeignKey(s => s.ProductId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne<Software>(s => s.Software).WithOne(s => s.Product).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	
	    }
	}
}
