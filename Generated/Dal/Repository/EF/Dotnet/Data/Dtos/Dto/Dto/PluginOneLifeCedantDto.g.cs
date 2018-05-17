
// <copyright file="PluginOneLifeCedantDto.g.cs" company="MIT">
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

using System;
using System.Collections.Generic;
using Banking.Models.Interfaces;

namespace Banking.Models.Dto
{
	public partial class PluginOneLifeCedantDto : IPluginOneLifeCedant 
	{
		#region CTOR
		
		public PluginOneLifeCedantDto()
		{
			this.PluginOneLifeBatchRun = new List <IPluginOneLifeBatchRun>();
			this.PluginOneLifeMapping = new List <IPluginOneLifeMapping>();
			this.PluginOneLifePolicy = new List <IPluginOneLifePolicy>();
		}
		
		public PluginOneLifeCedantDto(IPluginOneLifeCedant item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.CedantId = item.CedantId;
			this.PluginOneLifeBatchRun = new List <IPluginOneLifeBatchRun>();
			this.PluginOneLifeMapping = new List <IPluginOneLifeMapping>();
			this.PluginOneLifePolicy = new List <IPluginOneLifePolicy>();

			if(deep)
			{
				if(item.PluginOneLifeBatchRun != null)
				{
					foreach(var childItem in item.PluginOneLifeBatchRun)
					{
						this.PluginOneLifeBatchRun.Add(new PluginOneLifeBatchRunDto(childItem, deep));
					}
				}
				if(item.PluginOneLifeMapping != null)
				{
					foreach(var childItem in item.PluginOneLifeMapping)
					{
						this.PluginOneLifeMapping.Add(new PluginOneLifeMappingDto(childItem, deep));
					}
				}
				if(item.PluginOneLifePolicy != null)
				{
					foreach(var childItem in item.PluginOneLifePolicy)
					{
						this.PluginOneLifePolicy.Add(new PluginOneLifePolicyDto(childItem, deep));
					}
				}
                if(item.Cedant != null)
                {
				    this.Cedant = new CedantDto(item.Cedant, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> CedantId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IPluginOneLifeBatchRun> PluginOneLifeBatchRun { get; set; }
		public IList<IPluginOneLifeMapping> PluginOneLifeMapping { get; set; }
		public IList<IPluginOneLifePolicy> PluginOneLifePolicy { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ICedant Cedant { get; set; }
		
		#endregion
	}
}
