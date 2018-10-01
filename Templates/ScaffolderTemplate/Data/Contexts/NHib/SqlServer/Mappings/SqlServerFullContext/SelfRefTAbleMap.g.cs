
// <copyright file="SelfRefTAbleMap.g.cs" company="Dot Net Scaffolder">
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
using Banking.Models.Entity;
using FluentNHibernate.Mapping;

namespace Banking.Models.Context.Mappings.NHib.SqlServer
{
	public partial class SelfRefTAbleMap : ClassMap<SelfRefTAble>
	{	
		public SelfRefTAbleMap ()
		{
			CreateMapping();
		}
		
		protected virtual void CreateMapping()
		{
			Table("SelfRefTAble");
			Schema("dbo");
			
			#region Primary Keys
			
			Id(t => t.Id).GeneratedBy.Increment().Unique()
			.Not.Nullable();
			Map(t => t.Id).Column("Id").ReadOnly().Generated.Insert();

			#endregion

			#region Properties
			
			Map(t => t.Description).Column("Description")
			.Length(10)
			.Nullable();
			Map(t => t.ParentId).Column("ParentId")
			.Nullable();
			Map(t => t.SoftwareId).Column("SoftwareId")
			.Nullable();
			
			#endregion
			
			#region Relationships
			
			References(o => o.SelfRefTAble2).Column("Id").Unique().Not.Insert().Not.Update();
			References(o => o.Software).Column("ProductId").Unique().Not.Insert().Not.Update();
			HasMany(s => s.SelfRefTAble1).KeyColumn("ParentId");
			
			#endregion			

			#region Column Order
			
			// Not available in NHibernate at the moment

			#endregion
	
		}
	}
}
