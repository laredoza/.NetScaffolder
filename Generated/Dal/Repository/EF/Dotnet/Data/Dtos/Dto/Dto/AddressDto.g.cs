
// <copyright file="AddressDto.g.cs" company="MIT">
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
	public partial class AddressDto : IAddress 
	{
		#region CTOR
		
		public AddressDto()
		{
			this.Customer = new List <ICustomer>();
			this.CustomerAddress = new List <ICustomerAddress>();
			this.Doctor = new List <IDoctor>();
		}
		
		public AddressDto(IAddress item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Line1 = item.Line1;
			this.Line2 = item.Line2;
			this.Suburb = item.Suburb;
			this.City = item.City;
			this.PostalCode = item.PostalCode;
			this.Type = item.Type;
			this.DefaultAddress = item.DefaultAddress;
			this.StateProvinceId = item.StateProvinceId;
			this.CountryId = item.CountryId;
			this.Customer = new List <ICustomer>();
			this.CustomerAddress = new List <ICustomerAddress>();
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
				if(item.CustomerAddress != null)
				{
					foreach(var childItem in item.CustomerAddress)
					{
						this.CustomerAddress.Add(new CustomerAddressDto(childItem, deep));
					}
				}
				if(item.Doctor != null)
				{
					foreach(var childItem in item.Doctor)
					{
						this.Doctor.Add(new DoctorDto(childItem, deep));
					}
				}
                if(item.Country != null)
                {
				    this.Country = new CountryDto(item.Country, deep);
                }
                if(item.StateProvince != null)
                {
				    this.StateProvince = new StateProvinceDto(item.StateProvince, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string Suburb { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public Nullable<int> Type { get; set; }
		public Nullable<bool> DefaultAddress { get; set; }
		public Nullable<int> StateProvinceId { get; set; }
		public Nullable<int> CountryId { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<ICustomer> Customer { get; set; }
		public IList<ICustomerAddress> CustomerAddress { get; set; }
		public IList<IDoctor> Doctor { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ICountry Country { get; set; }
		public IStateProvince StateProvince { get; set; }
		
		#endregion
	}
}
