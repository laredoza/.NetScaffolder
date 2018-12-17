
// <copyright file="ProductMap.g.cs" company="MIT">
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

namespace RepositoryEFDotnet.Data.Customers.Mappings.EF.Postgres
{
	public partial class CustomerContextProductMap : EntityTypeConfiguration<Product>
	{	
		public CustomerContextProductMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("Product", "dbo");
			
			#region Primary Keys
			
			HasKey(t => t.ProductId);
			Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.ProductId).IsRequired();
			Property(t => t.ProductDescription).HasMaxLength(100);
			Property(t => t.ProductDescription).IsOptional();
			Property(t => t.UnitPrice).IsOptional();
			Property(t => t.UnitPrice).HasPrecision(19, 4);
			Property(t => t.UnitAmount).HasMaxLength(50);
			Property(t => t.UnitAmount).IsOptional();
			Property(t => t.Publisher).HasMaxLength(200);
			Property(t => t.Publisher).IsOptional();
			Property(t => t.AmountInStock).IsOptional();
			
			#endregion
			
			#region Indexes
			Property(t => t.ProductId).HasColumnAnnotation("UQ__Product__B40CC6CC5F2A0195", new IndexAnnotation(new [] { new IndexAttribute("UQ__Product__B40CC6CC5F2A0195"){ IsClustered = false, IsUnique = true, Order = 0}}));
			#endregion

			#region Relationships
			
			HasMany<OrderDetails>(s => s.OrderDetails).WithRequired(s => s.Product).HasForeignKey(s => s.ProductId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.ProductId).HasColumnOrder(1);
			Property(t => t.ProductDescription).HasColumnOrder(2);
			Property(t => t.UnitPrice).HasColumnOrder(3);
			Property(t => t.UnitAmount).HasColumnOrder(4);
			Property(t => t.Publisher).HasColumnOrder(5);
			Property(t => t.AmountInStock).HasColumnOrder(6);

			#endregion
	
		}
	}
}
