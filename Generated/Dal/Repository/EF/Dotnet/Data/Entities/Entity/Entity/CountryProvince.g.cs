
// <copyright file="CountryProvince.g.cs" company="MIT">
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
	public partial class CountryProvince : ICountryProvince 
	{
		#region CTOR
		
		public CountryProvince()
		{
			this.CountryProvince1 = new List <CountryProvince>();
		}
		
		public CountryProvince(ICountryProvince item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Code = item.Code;
			this.Name = item.Name;
			this.Status = item.Status;
			this.ParentId = item.ParentId;
			this.CountryProvince1 = new List <CountryProvince>();

			if(deep)
			{
				if(item.CountryProvince1 != null)
				{
					foreach(var childItem in item.CountryProvince1)
					{
						this.CountryProvince1.Add(new CountryProvince(childItem, deep));
					}
				}
				if(item.CountryProvince2 != null)
                {
                    this.CountryProvince2 = new CountryProvince(item.CountryProvince2, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public Nullable<int> Status { get; set; }
		public Nullable<int> ParentId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<CountryProvince> CountryProvince1 { get; set; }

        IList<ICountryProvince> ICountryProvince.CountryProvince1 
		{ 
			get
			{
				return (IList<ICountryProvince>)this.CountryProvince1;
			}
			set
			{
				this.CountryProvince1 = (IList<CountryProvince>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual CountryProvince CountryProvince2 { get; set; }

		ICountryProvince ICountryProvince.CountryProvince2 
		{ 
			get
			{
				return this.CountryProvince2;
			}
			set
			{
				this.CountryProvince2 = (CountryProvince)value;
			}
		}
		
		#endregion
	}
}
