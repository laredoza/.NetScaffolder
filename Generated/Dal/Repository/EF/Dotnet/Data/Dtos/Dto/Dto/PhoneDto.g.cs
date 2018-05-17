
// <copyright file="PhoneDto.g.cs" company="MIT">
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
	public partial class PhoneDto : IPhone 
	{
		#region CTOR
		
		public PhoneDto()
		{
			this.Customer = new List <ICustomer>();
			this.CustomerPhone = new List <ICustomerPhone>();
			this.Doctor = new List <IDoctor>();
		}
		
		public PhoneDto(IPhone item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.CountryCode = item.CountryCode;
			this.AreaCode = item.AreaCode;
			this.Number = item.Number;
			this.Extension = item.Extension;
			this.FormattedNumber = item.FormattedNumber;
			this.Type = item.Type;
			this.DefaultPhone = item.DefaultPhone;
			this.Customer = new List <ICustomer>();
			this.CustomerPhone = new List <ICustomerPhone>();
			this.Doctor = new List <IDoctor>();

			if(deep)
			{
				if(item.Customer != null)
				{
					foreach(var childItem in item.Customer)
					{
						this.Customer.Add(new CustomerDto(childItem, deep));
					}
				}
				if(item.CustomerPhone != null)
				{
					foreach(var childItem in item.CustomerPhone)
					{
						this.CustomerPhone.Add(new CustomerPhoneDto(childItem, deep));
					}
				}
				if(item.Doctor != null)
				{
					foreach(var childItem in item.Doctor)
					{
						this.Doctor.Add(new DoctorDto(childItem, deep));
					}
				}
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> CountryCode { get; set; }
		public Nullable<int> AreaCode { get; set; }
		public string Number { get; set; }
		public Nullable<int> Extension { get; set; }
		public string FormattedNumber { get; set; }
		public Nullable<int> Type { get; set; }
		public Nullable<bool> DefaultPhone { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<ICustomer> Customer { get; set; }
		public IList<ICustomerPhone> CustomerPhone { get; set; }
		public IList<IDoctor> Doctor { get; set; }

		#endregion
		
		#region Parent Relationships
		
		
		#endregion
	}
}
