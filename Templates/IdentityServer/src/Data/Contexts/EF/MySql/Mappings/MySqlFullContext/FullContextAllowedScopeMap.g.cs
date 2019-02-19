
// <copyright file="AllowedScopeMap.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EF.MySql.Mappings.MySqlFullContext
{
	public partial class FullContextAllowedScopeMap : EntityTypeConfiguration<AllowedScope>
	{	
		public FullContextAllowedScopeMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("AllowedScope");
			
			#region Primary Keys
			
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			#endregion

			#region Constraints
			
			Property(t => t.Id).IsRequired();
			Property(t => t.ClientId).IsRequired();
			Property(t => t.ResourceName).HasMaxLength(50);
			Property(t => t.ResourceName).IsRequired();
			
			#endregion
			
			#region Indexes
			#endregion

			#region Relationships
			
			HasRequired<Client>(s => s.Client).WithMany(s => s.AllowedScope).HasForeignKey(s => s.ClientId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.Id).HasColumnOrder(1);
			Property(t => t.ClientId).HasColumnOrder(2);
			Property(t => t.ResourceName).HasColumnOrder(3);

			#endregion
	
		}
	}
}
