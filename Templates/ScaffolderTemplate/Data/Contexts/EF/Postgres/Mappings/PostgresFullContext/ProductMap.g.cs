
// <copyright file="ProductMap.g.cs" company="Dot Net Scaffolder">
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

using Npgsql;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EF.Postgres
{
	public partial class ProductMap : EntityTypeConfiguration<Product>
	{	
		public ProductMap ()
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
			HasIndex(i => new {i.ProductId}).HasName("UQ__Product__B40CC6CC5F2A0195").IsUnique(true);
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
