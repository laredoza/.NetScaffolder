
// <copyright file="CustomerDto.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using Newtonsoft.Json;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto
{
	public partial class CustomerDto : ICustomer 
	{
		#region CTOR
		
		public CustomerDto()
		{
			this.BankAccount = new List <IBankAccount>();
		}
		
		public CustomerDto(ICustomer item, bool deep = false)
		{
			if(item == null) return;
			
			this.CustomerId = item.CustomerId;
			this.CustomerCode = item.CustomerCode;
			this.CompanyName = item.CompanyName;
			this.ContactName = item.ContactName;
			this.ContactTitle = item.ContactTitle;
			this.Address = item.Address;
			this.City = item.City;
			this.PostalCode = item.PostalCode;
			this.Telephone = item.Telephone;
			this.Fax = item.Fax;
			this.CountryId = item.CountryId;
			this.Photo = item.Photo;
			this.IsEnabled = item.IsEnabled;
			this.BankAccount = new List <IBankAccount>();

			if(deep)
			{
				if(item.BankAccount != null)
				{
					foreach(var childItem in item.BankAccount)
					{
						this.BankAccount.Add(new BankAccountDto(childItem, deep));
					}
				}
                if(item.Country != null)
                {
				    this.Country = new CountryDto(item.Country, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int CustomerId { get; set; }
		public string CustomerCode { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Telephone { get; set; }
		public string Fax { get; set; }
		public Nullable<int> CountryId { get; set; }
		public string Photo { get; set; }
		public bool IsEnabled { get; set; }

		#endregion
		
		#region Child Relationships
		
        // [JsonConverter(typeof(ConcreteTypeConverter<BankAccountDto>))]
		public IList<IBankAccount> BankAccount { get; set; }

		#endregion
		
		#region Parent Relationships
		
        [JsonConverter(typeof(ConcreteTypeConverter<CountryDto>))]
		public ICountry Country { get; set; }
		
		#endregion
	}
}
