
// <copyright file="burgerTable.g.cs" company="Dot Net Scaffolder">
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
	public partial class burgerTable : IburgerTable 
	{
		#region CTOR
		
		public burgerTable()
		{
		}
		
		public burgerTable(IburgerTable item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id1 = item.Id1;
			this.Id2 = item.Id2;
			this.description = item.description;

			if(deep)
			{
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int Id1 { get; set; }
		public virtual int Id2 { get; set; }
		public virtual string description { get; set; }

		#endregion

		public override int GetHashCode()
		{
			return 
	this.Id1.GetHashCode()
			^ 
	this.Id2.GetHashCode()
;
		}
		
		public override bool Equals(object obj)
		{
			var item = obj as burgerTable;
			if(item == null) return false;
			return 
	this.Id1 == item.Id1
			&& 
	this.Id2 == item.Id2
;
		}
	}
}
