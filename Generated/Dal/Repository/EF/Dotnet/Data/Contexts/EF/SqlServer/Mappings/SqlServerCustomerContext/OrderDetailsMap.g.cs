﻿
// <copyright file="OrderDetailsMap.g.cs.g.cs" company="MIT">
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using RepositoryEFDotnet.Library;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;


namespace Banking.Models.Customers.Mappings.SqlServer
{
	public partial class OrderDetailsMap : EntityTypeConfiguration<OrderDetails>
	{	
		public OrderDetailsMap ()
		{
			ToTable("[OrderDetails]", "[dbo]");
			
			#region Primary Keys
			
			HasKey(t => t.OrderDetailsId);
			Property(t => t.OrderDetailsId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			#endregion

			#region Constraints
			
			Property(t => t.OrderDetailsId).IsRequired();
			Property(t => t.OrderId).IsRequired();
			Property(t => t.ProductId).IsRequired();
			Property(t => t.UnitPrice).IsOptional();
			Property(t => t.UnitPrice).HasPrecision(19, 4);
			Property(t => t.Amount).IsOptional();
			Property(t => t.Discount).IsOptional();
			
			#endregion

			#region Relationships
			
			HasRequired<Order>(s => s.Order).WithMany(s => s.OrderDetails).HasForeignKey(s => s.OrderId).WillCascadeOnDelete(false);
			HasRequired<Product>(s => s.Product).WithMany(s => s.OrderDetails).HasForeignKey(s => s.ProductId).WillCascadeOnDelete(false);
			
			#endregion			
	
		}
	}
}