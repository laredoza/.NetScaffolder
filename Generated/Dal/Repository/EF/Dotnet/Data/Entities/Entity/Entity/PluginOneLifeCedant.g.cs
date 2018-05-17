
// <copyright file="PluginOneLifeCedant.g.cs" company="MIT">
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

namespace Banking.Models.Entity
{
	public partial class PluginOneLifeCedant : IPluginOneLifeCedant 
	{
		#region CTOR
		
		public PluginOneLifeCedant()
		{
			this.PluginOneLifeBatchRun = new List <PluginOneLifeBatchRun>();
			this.PluginOneLifeMapping = new List <PluginOneLifeMapping>();
			this.PluginOneLifePolicy = new List <PluginOneLifePolicy>();
		}
		
		public PluginOneLifeCedant(IPluginOneLifeCedant item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.CedantId = item.CedantId;
			this.PluginOneLifeBatchRun = new List <PluginOneLifeBatchRun>();
			this.PluginOneLifeMapping = new List <PluginOneLifeMapping>();
			this.PluginOneLifePolicy = new List <PluginOneLifePolicy>();

			if(deep)
			{
				if(item.PluginOneLifeBatchRun != null)
				{
					foreach(var childItem in item.PluginOneLifeBatchRun)
					{
						this.PluginOneLifeBatchRun.Add(new PluginOneLifeBatchRun(childItem, deep));
					}
				}
				if(item.PluginOneLifeMapping != null)
				{
					foreach(var childItem in item.PluginOneLifeMapping)
					{
						this.PluginOneLifeMapping.Add(new PluginOneLifeMapping(childItem, deep));
					}
				}
				if(item.PluginOneLifePolicy != null)
				{
					foreach(var childItem in item.PluginOneLifePolicy)
					{
						this.PluginOneLifePolicy.Add(new PluginOneLifePolicy(childItem, deep));
					}
				}
				if(item.Cedant != null)
                {
                    this.Cedant = new Cedant(item.Cedant, deep);
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
        
        public virtual IList<PluginOneLifeBatchRun> PluginOneLifeBatchRun { get; set; }

        IList<IPluginOneLifeBatchRun> IPluginOneLifeCedant.PluginOneLifeBatchRun 
		{ 
			get
			{
				return (IList<IPluginOneLifeBatchRun>)this.PluginOneLifeBatchRun;
			}
			set
			{
				this.PluginOneLifeBatchRun = (IList<PluginOneLifeBatchRun>)value;
			}			
		}
        
        public virtual IList<PluginOneLifeMapping> PluginOneLifeMapping { get; set; }

        IList<IPluginOneLifeMapping> IPluginOneLifeCedant.PluginOneLifeMapping 
		{ 
			get
			{
				return (IList<IPluginOneLifeMapping>)this.PluginOneLifeMapping;
			}
			set
			{
				this.PluginOneLifeMapping = (IList<PluginOneLifeMapping>)value;
			}			
		}
        
        public virtual IList<PluginOneLifePolicy> PluginOneLifePolicy { get; set; }

        IList<IPluginOneLifePolicy> IPluginOneLifeCedant.PluginOneLifePolicy 
		{ 
			get
			{
				return (IList<IPluginOneLifePolicy>)this.PluginOneLifePolicy;
			}
			set
			{
				this.PluginOneLifePolicy = (IList<PluginOneLifePolicy>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Cedant Cedant { get; set; }

		ICedant IPluginOneLifeCedant.Cedant 
		{ 
			get
			{
				return this.Cedant;
			}
			set
			{
				this.Cedant = (Cedant)value;
			}
		}
		
		#endregion
	}
}
