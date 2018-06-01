
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
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Banking.Models.Entity;


namespace Banking.Models.Context.Mappings
{
	public partial class CustomerMap : EntityTypeConfiguration<Customer>
	{	
		public CustomerMap ()
		{
			ToTable("Customer", "dbo");
			
			#region Primary Keys
			
			HasKey(t => t.CustomerId);
			Property(t => t.CustomerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			#endregion

			#region Constraints
			
			Property(t => t.CustomerId).IsRequired();
			Property(t => t.CustomerCode).HasMaxLength(5);
			Property(t => t.CustomerCode).IsRequired();
			Property(t => t.CompanyName).HasMaxLength(50);
			Property(t => t.CompanyName).IsRequired();
			Property(t => t.ContactName).HasMaxLength(50);
			Property(t => t.ContactName).IsOptional();
			Property(t => t.ContactTitle).HasMaxLength(50);
			Property(t => t.ContactTitle).IsOptional();
			Property(t => t.Address).HasMaxLength(50);
			Property(t => t.Address).IsOptional();
			Property(t => t.City).HasMaxLength(20);
			Property(t => t.City).IsOptional();
			Property(t => t.PostalCode).HasMaxLength(10);
			Property(t => t.PostalCode).IsOptional();
			Property(t => t.Telephone).HasMaxLength(50);
			Property(t => t.Telephone).IsOptional();
			Property(t => t.Fax).HasMaxLength(50);
			Property(t => t.Fax).IsOptional();
			Property(t => t.CountryId).IsOptional();
			Property(t => t.Photo).HasMaxLength(2147483647);
			Property(t => t.Photo).IsOptional();
			Property(t => t.IsEnabled).IsRequired();
			
			#endregion

			#region Relationships
			
			HasMany<BankAccount>(s => s.BankAccount).WithOptional(s => s.Customer).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			HasOptional<Country>(s => s.Country).WithMany(s => s.Customer).HasForeignKey(s => s.CountryId).WillCascadeOnDelete(false);
			HasMany<Order>(s => s.Order).WithOptional(s => s.Customer).HasForeignKey(s => s.CustomerId).WillCascadeOnDelete(false);
			
			#endregion			
	
		}
	}
}
