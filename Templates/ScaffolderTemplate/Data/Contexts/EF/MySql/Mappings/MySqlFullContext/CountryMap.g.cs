
// <copyright file="CountryMap.g.cs" company="MIT">
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
using System.Data.Entity.Infrastructure.Annotations;
using MySql.Data.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;
using System.Data.Common;

namespace Banking.Models.Context.Mappings.EF.MySql
{
	public partial class CountryMap : EntityTypeConfiguration<Country>
	{	
		public CountryMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("Country");
			
			#region Primary Keys
			
			HasKey(t => t.CountryId);
			Property(t => t.CountryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.CountryId).IsRequired();
			Property(t => t.CountryName).HasMaxLength(100);
			Property(t => t.CountryName).IsOptional();
			
			#endregion
			
			#region Indexes
			HasIndex(i => new {i.CountryId}).HasName("UQ__Country__10D1609E8CC26505").IsUnique(true);
			#endregion

			#region Relationships
			
			HasMany<Customer>(s => s.Customer).WithOptional(s => s.Country).HasForeignKey(s => s.CountryId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.CountryId).HasColumnOrder(1);
			Property(t => t.CountryName).HasColumnOrder(2);

			#endregion
	
		}
	}
}
