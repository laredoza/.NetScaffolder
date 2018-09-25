﻿
// <copyright file="Customer.g.cs" company="MIT">
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
	public partial class Customer : ICustomer 
	{
		#region CTOR
		
		public Customer()
		{
			this.BankAccounts = new List <BankAccount>();
			this.Orders = new List <Order>();
		}
		
		public Customer(ICustomer item, bool deep = false)
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
			this.BankAccounts = new List <BankAccount>();
			this.Orders = new List <Order>();

			if(deep)
			{
				if(item.BankAccounts != null)
				{
					foreach(var childItem in item.BankAccounts)
					{
						this.BankAccounts.Add(new BankAccount(childItem, deep));
					}
				}
				if(item.Orders != null)
				{
					foreach(var childItem in item.Orders)
					{
						this.Orders.Add(new Order(childItem, deep));
					}
				}
				this.Country = new Country(item.Country, deep);
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
		
		IList<IBankAccount> ICustomer.BankAccounts 
		{ 
			get
			{
				return (IList<IBankAccount>)this.BankAccounts;
			}
			set
			{
				this.BankAccounts = (IList<BankAccount>)value;
			}			
		}
		
		public virtual IList<BankAccount> BankAccounts { get; set; }
		IList<IOrder> ICustomer.Orders 
		{ 
			get
			{
				return (IList<IOrder>)this.Orders;
			}
			set
			{
				this.Orders = (IList<Order>)value;
			}			
		}
		
		public virtual IList<Order> Orders { get; set; }
		
		#endregion
		
		#region Parent Relationships

		ICountry ICustomer.Country 
		{ 
			get
			{
				return this.Country;
			}
			set
			{
				this.Country = (Country)value;
			}
		}
		
		public virtual Country Country { get; set; }
		
		#endregion
	}
}