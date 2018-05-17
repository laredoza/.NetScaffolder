
// <copyright file="PluginOneLifeBatchRun.g.cs" company="MIT">
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
	public partial class PluginOneLifeBatchRun : IPluginOneLifeBatchRun 
	{
		#region CTOR
		
		public PluginOneLifeBatchRun()
		{
			this.PluginOneLifeBatchRunPolicy = new List <PluginOneLifeBatchRunPolicy>();
		}
		
		public PluginOneLifeBatchRun(IPluginOneLifeBatchRun item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PluginOneLifeCedantId = item.PluginOneLifeCedantId;
			this.Completed = item.Completed;
			this.HasError = item.HasError;
			this.PluginOneLifeBatchRunPolicy = new List <PluginOneLifeBatchRunPolicy>();

			if(deep)
			{
				if(item.PluginOneLifeBatchRunPolicy != null)
				{
					foreach(var childItem in item.PluginOneLifeBatchRunPolicy)
					{
						this.PluginOneLifeBatchRunPolicy.Add(new PluginOneLifeBatchRunPolicy(childItem, deep));
					}
				}
				if(item.PluginOneLifeCedant != null)
                {
                    this.PluginOneLifeCedant = new PluginOneLifeCedant(item.PluginOneLifeCedant, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> PluginOneLifeCedantId { get; set; }
		public Nullable<bool> Completed { get; set; }
		public Nullable<bool> HasError { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<PluginOneLifeBatchRunPolicy> PluginOneLifeBatchRunPolicy { get; set; }

        IList<IPluginOneLifeBatchRunPolicy> IPluginOneLifeBatchRun.PluginOneLifeBatchRunPolicy 
		{ 
			get
			{
				return (IList<IPluginOneLifeBatchRunPolicy>)this.PluginOneLifeBatchRunPolicy;
			}
			set
			{
				this.PluginOneLifeBatchRunPolicy = (IList<PluginOneLifeBatchRunPolicy>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual PluginOneLifeCedant PluginOneLifeCedant { get; set; }

		IPluginOneLifeCedant IPluginOneLifeBatchRun.PluginOneLifeCedant 
		{ 
			get
			{
				return this.PluginOneLifeCedant;
			}
			set
			{
				this.PluginOneLifeCedant = (PluginOneLifeCedant)value;
			}
		}
		
		#endregion
	}
}
