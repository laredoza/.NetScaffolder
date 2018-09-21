
// <copyright file="Software.g.cs" company="Dot Net Scaffolder">
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
	public partial class Software : ISoftware 
	{
		#region CTOR
		
		public Software()
		{
			this.SelfRefTAble = new List <SelfRefTAble>();
		}
		
		public Software(ISoftware item, bool deep = false)
		{
			if(item == null) return;
			
			this.ProductId = item.ProductId;
			this.LicenseCode = item.LicenseCode;
			this.SelfRefTAble = new List <SelfRefTAble>();

			if(deep)
			{
				if(item.SelfRefTAble != null)
				{
					foreach(var childItem in item.SelfRefTAble)
					{
						this.SelfRefTAble.Add(new SelfRefTAble(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int ProductId { get; set; }
		public virtual string LicenseCode { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<SelfRefTAble> SelfRefTAble { get; set; }
	
        IList<ISelfRefTAble> ISoftware.SelfRefTAble 
		{ 
			get
			{
				return this.SelfRefTAble == null ? null : (IList<ISelfRefTAble>)this.SelfRefTAble;
			}
			set
			{
				if(value != this.SelfRefTAble)
				{
					if(value != null)
					{
						this.SelfRefTAble = (IList<SelfRefTAble>)value;
					}
					else
					{
						this.SelfRefTAble = null;
					}
				}
			}			
		}

		#endregion
	}
}
