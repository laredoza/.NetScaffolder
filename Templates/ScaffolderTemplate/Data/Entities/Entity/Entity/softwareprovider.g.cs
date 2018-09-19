
// <copyright file="softwareprovider.g.cs" company="Dot Net Scaffolder">
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
	public partial class softwareprovider : Isoftwareprovider 
	{
		#region CTOR
		
		public softwareprovider()
		{
		}
		
		public softwareprovider(Isoftwareprovider item, bool deep = false)
		{
			if(item == null) return;
			
			this.id = item.id;
			this.ProductIdDDB = item.ProductIdDDB;
			this.name = item.name;
			this.x1 = item.x1;

			if(deep)
			{
				if(item.somealies != null)
                {
                    this.somealies = new Order(item.somealies, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual string id { get; set; }
		public virtual int ProductIdDDB { get; set; }
		public virtual string name { get; set; }
		public virtual string x1 { get; set; }

		#endregion

		#region Parent Relationships

        public virtual Order somealies { get; set; }
		IOrder Isoftwareprovider.somealies 
		{ 
			get
			{
				return this.somealies;
			}
			set
			{
				if(value != this.somealies)
				{
					if(value != null)
					{
						this.somealies = (Order)value;
					}
					else
					{
						this.somealies = null;
					}
				}
			}
		}
		
		#endregion
	}
}
