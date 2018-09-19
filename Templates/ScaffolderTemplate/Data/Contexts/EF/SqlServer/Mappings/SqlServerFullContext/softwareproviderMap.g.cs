
// <copyright file="softwareproviderMap.g.cs" company="Dot Net Scaffolder">
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
	public partial class softwareproviderMap : EntityTypeConfiguration<softwareprovider>
	{	
		public softwareproviderMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("softwareprovider", "dbo");
			
			#region Primary Keys
			
			HasKey(t => t.id);
			Property(t => t.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.id).HasMaxLength(10);
			Property(t => t.id).IsRequired();
			Property(t => t.ProductIdDDB).IsRequired();
			Property(t => t.name).HasMaxLength(50);
			Property(t => t.name).IsOptional();
			Property(t => t.x1).HasMaxLength(10);
			Property(t => t.x1).IsOptional();
			
			#endregion
			
			#region Indexes
			#endregion

			#region Relationships
			
			HasRequired<Order>(s => s.somealies).WithMany(s => s.softwareprovider).HasForeignKey(s => s.ProductIdDDB).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.id).HasColumnOrder(1);
			Property(t => t.ProductIdDDB).HasColumnOrder(2);
			Property(t => t.name).HasColumnOrder(3);
			Property(t => t.x1).HasColumnOrder(4);

			#endregion
	
		}
	}
}
