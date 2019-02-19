
// <copyright file="IdentityResourceMap.g.cs" company="MIT">
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Postgres.Mappings.PostgresFullContext
{
	public partial class FullContextIdentityResourceMap : IEntityTypeConfiguration<IdentityResource>
	{	
	    public virtual void Configure(EntityTypeBuilder<IdentityResource> builder)
	    {
			builder.ToTable("IdentityResource");
			
			#region Primary keys
			
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedOnAdd();

			#endregion

			#region Constraints
			
			builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
			builder.Property(t => t.Name).HasMaxLength(50);
			builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
			builder.Property(t => t.DisplayName).HasMaxLength(50);
			builder.Property(t => t.DisplayName).HasColumnName("DisplayName").IsRequired();
			builder.Property(t => t.ShowInDiscoveryDocument).HasColumnName("ShowInDiscoveryDocument").IsRequired();
			builder.Property(t => t.Required).HasColumnName("Required").IsRequired();
			builder.Property(t => t.Emphasize).HasColumnName("Emphasize").IsRequired();
			
			#endregion

			#region Indexes
			#endregion
			
			#region Relationships
			
			builder.HasMany<IdentityResourceClaimType>(s => s.IdentityResourceClaimType).WithOne(s => s.IdentityResource).HasForeignKey(s => s.IdentityResourceId).OnDelete(DeleteBehavior.Restrict);
			
			#endregion	

			#region Column Order
			
			// Column ordering available in EF Core 2.1 - https://data.uservoice.com/forums/72025-entity-framework-core-feature-suggestions/suggestions/18936844-ef-core-migrations-column-ordering
			// Waiting for that release before implementing
			//TODO: builder.Property(t => t.Id).HasColumnOrder(1);
			//TODO: builder.Property(t => t.Name).HasColumnOrder(2);
			//TODO: builder.Property(t => t.DisplayName).HasColumnOrder(3);
			//TODO: builder.Property(t => t.ShowInDiscoveryDocument).HasColumnOrder(4);
			//TODO: builder.Property(t => t.Required).HasColumnOrder(5);
			//TODO: builder.Property(t => t.Emphasize).HasColumnOrder(6);

			#endregion	
	    }
	}
}
