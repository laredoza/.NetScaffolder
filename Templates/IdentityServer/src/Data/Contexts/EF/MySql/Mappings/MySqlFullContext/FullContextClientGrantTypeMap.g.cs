
// <copyright file="ClientGrantTypeMap.g.cs" company="MIT">
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
	public partial class FullContextClientGrantTypeMap : EntityTypeConfiguration<ClientGrantType>
	{	
		public FullContextClientGrantTypeMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			ToTable("ClientGrantType");
			
			#region Primary Keys
			
			HasKey(t => new {t.ClientId, t.GrantTypeId});
			Property(t => t.ClientId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			Property(t => t.GrantTypeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			#endregion

			#region Constraints
			
			Property(t => t.ClientId).IsRequired();
			Property(t => t.GrantTypeId).IsRequired();
			
			#endregion
			
			#region Indexes
			#endregion

			#region Relationships
			
			HasRequired<Client>(s => s.Client).WithMany(s => s.ClientGrantType).HasForeignKey(s => s.ClientId).WillCascadeOnDelete(false);
			HasRequired<GrantType>(s => s.GrantType).WithMany(s => s.ClientGrantType).HasForeignKey(s => s.GrantTypeId).WillCascadeOnDelete(false);
			
			#endregion			

			#region Column Order
			
			Property(t => t.ClientId).HasColumnOrder(1);
			Property(t => t.GrantTypeId).HasColumnOrder(2);

			#endregion
	
		}
	}
}
