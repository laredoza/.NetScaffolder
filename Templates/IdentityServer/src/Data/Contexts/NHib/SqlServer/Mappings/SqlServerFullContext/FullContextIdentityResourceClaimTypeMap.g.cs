
// <copyright file="IdentityResourceClaimTypeMap.g.cs" company="MIT">
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
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using System.Data.Common;
using FluentNHibernate.Mapping;


namespace DotNetScaffolder.Domain.Data.Contexts.NHib.SqlServer.Mappings.SqlServerFullContext
{
	public partial class FullContextIdentityResourceClaimTypeMap : ClassMap<IdentityResourceClaimType>
	{	
		public FullContextIdentityResourceClaimTypeMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("IdentityResourceClaimType");
			Schema("dbo");
			
			#region Primary Keys
			
			CompositeId().KeyProperty(t => t.IdentityResourceId, "IdentityResourceId").KeyProperty(t => t.ResourceClaimTypeId, "ResourceClaimTypeId");

			#endregion

			#region Properties
			
			
			#endregion
			
			#region Relationships
			
			References(o => o.IdentityResource).Column("Id").Unique().Not.Insert().Not.Update();
			References(o => o.ResourceClaimType).Column("Id").Unique().Not.Insert().Not.Update();
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
