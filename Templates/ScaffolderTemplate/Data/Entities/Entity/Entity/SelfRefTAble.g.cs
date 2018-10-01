
// <copyright file="SelfRefTAble.g.cs" company="Dot Net Scaffolder">
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

using System;
using System.Collections.Generic;
using Banking.Models.Interfaces;

namespace Banking.Models.Entity
{
	public partial class SelfRefTAble : ISelfRefTAble 
	{
		#region CTOR
		
		public SelfRefTAble()
		{
			this.SelfRefTAble1 = new List <SelfRefTAble>();
		}
		
		public SelfRefTAble(ISelfRefTAble item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Description = item.Description;
			this.ParentId = item.ParentId;
			this.SoftwareId = item.SoftwareId;
			this.SelfRefTAble1 = new List <SelfRefTAble>();

			if(deep)
			{
				if(item.SelfRefTAble1 != null)
				{
					foreach(var childItem in item.SelfRefTAble1)
					{
						this.SelfRefTAble1.Add(new SelfRefTAble(childItem, deep));
					}
				}
				if(item.SelfRefTAble2 != null)
                {
                    this.SelfRefTAble2 = new SelfRefTAble(item.SelfRefTAble2, deep);
                }
				if(item.Software != null)
                {
                    this.Software = new Software(item.Software, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int Id { get; set; }
		public virtual string Description { get; set; }
		public virtual Nullable<int> ParentId { get; set; }
		public virtual Nullable<int> SoftwareId { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<SelfRefTAble> SelfRefTAble1 { get; set; }
	
        IList<ISelfRefTAble> ISelfRefTAble.SelfRefTAble1 
		{ 
			get
			{
				return this.SelfRefTAble1 == null ? null : (IList<ISelfRefTAble>)this.SelfRefTAble1;
			}
			set
			{
				if(value != this.SelfRefTAble1)
				{
					if(value != null)
					{
						this.SelfRefTAble1 = (IList<SelfRefTAble>)value;
					}
					else
					{
						this.SelfRefTAble1 = null;
					}
				}
			}			
		}

		#endregion

		#region Parent Relationships

        public virtual SelfRefTAble SelfRefTAble2 { get; set; }
		ISelfRefTAble ISelfRefTAble.SelfRefTAble2 
		{ 
			get
			{
				return this.SelfRefTAble2;
			}
			set
			{
				if(value != this.SelfRefTAble2)
				{
					if(value != null)
					{
						this.SelfRefTAble2 = (SelfRefTAble)value;
					}
					else
					{
						this.SelfRefTAble2 = null;
					}
				}
			}
		}

        public virtual Software Software { get; set; }
		ISoftware ISelfRefTAble.Software 
		{ 
			get
			{
				return this.Software;
			}
			set
			{
				if(value != this.Software)
				{
					if(value != null)
					{
						this.Software = (Software)value;
					}
					else
					{
						this.Software = null;
					}
				}
			}
		}
		
		#endregion
	}
}
