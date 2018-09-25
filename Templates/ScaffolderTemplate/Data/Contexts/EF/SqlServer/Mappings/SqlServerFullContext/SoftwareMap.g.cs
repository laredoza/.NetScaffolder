﻿
// <copyright file="SoftwareMap.g.cs" company="Dot Net Scaffolder">
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EF.SqlServer
{
	public partial class SoftwareMap : EntityTypeConfiguration<Software>
	{	
		public SoftwareMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("Software", "dbo");
			
			#region Primary Keys
			
			HasKey(t => t.ProductId);
			Property(t => t.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.ProductId).IsRequired();
			Property(t => t.LicenseCode).HasMaxLength(200);
			Property(t => t.LicenseCode).IsRequired();
			
			#endregion
			
			#region Indexes
			#endregion

			#region Relationships
			
			HasMany<SelfRefTAble>(s => s.SelfRefTAble).WithOptional(s => s.Software).HasForeignKey(s => s.SoftwareId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.ProductId).HasColumnOrder(1);
			Property(t => t.LicenseCode).HasColumnOrder(2);

			#endregion
	
		}
	}
}