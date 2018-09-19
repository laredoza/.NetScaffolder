
// <copyright file="CustomerDto.g.cs" company="Dot Net Scaffolder">
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

namespace Banking.Models.Dto
{
	public partial class CustomerDto : ICustomer 
	{
		#region CTOR
		
		public CustomerDto()
		{
			this.BankAccount = new List <IBankAccount>();
			this.Order = new List <IOrder>();
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
			this.Order = new List <IOrder>();

			if(deep)
			{
				if(item.BankAccount != null)
				{
					foreach(var childItem in item.BankAccount)
					{
						this.BankAccount.Add(new BankAccountDto(childItem, deep));
					}
				}
				if(item.Order != null)
				{
					foreach(var childItem in item.Order)
					{
						this.Order.Add(new OrderDto(childItem, deep));
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
		
		public IList<IBankAccount> BankAccount { get; set; }
		public IList<IOrder> Order { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ICountry Country { get; set; }
		
		#endregion
	}
}
