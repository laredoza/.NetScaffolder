// <copyright file="Customer.g.cs" company="MIT">
//  Copyright (c) 2020 MIT
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
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
namespace DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity
{
	public partial class Customer : ICustomer
	{
		#region CTOR

		public Customer()
		{
			this.BankAccount = new List<BankAccount>(); 
			this.Order = new List<Order>(); 
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
			this.BankAccount = new List<BankAccount>(); 
			this.Order = new List<Order>(); 
			if(deep)
			{
				if(item.BankAccount != null)
				{
					foreach(var childItem in item.BankAccount)
					{
						this.BankAccount.Add(new BankAccount(childItem, deep));
					}
				}
				if(item.Order != null)
				{
					foreach(var childItem in item.Order)
					{
						this.Order.Add(new Order(childItem, deep));
					}
				}
				if(item.Country != null)
                {
                    this.Country = new Country(item.Country, deep);
                }
			}
		}
		
		#endregion
		#region Fields
		
		public virtual int CustomerId { get; set; }
		public virtual string CustomerCode { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string ContactName { get; set; }
		public virtual string ContactTitle { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string Telephone { get; set; }
		public virtual string Fax { get; set; }
		public virtual int? CountryId { get; set; }
		public virtual string Photo { get; set; }
		public virtual bool IsEnabled { get; set; }

		#endregion

        #region Child Relationships

        public virtual IListBankAccount BankAccount { get; set; }
        IListIBankAccount ICustomer.BankAccount
		{ 
			get
			{
				return this.BankAccount == null ? null : this.BankAccount as IList<IBankAccount>;
			}
			set
			{
				if(value != this.BankAccount)
				{
					if(value != null)
					{
						this.BankAccount = (IList<BankAccount>)value;
					}
					else
					{
						this.BankAccount = null;
					}
				}
			}			
		}
        public virtual IListOrder Order { get; set; }
        IListIOrder ICustomer.Order
		{ 
			get
			{
				return this.Order == null ? null : this.Order as IList<IOrder>;
			}
			set
			{
				if(value != this.Order)
				{
					if(value != null)
					{
						this.Order = (IList<Order>)value;
					}
					else
					{
						this.Order = null;
					}
				}
			}			
		}


		#endregion
		#region Parent Relationships

        public virtual Country Country { get; set; }
		ICountry ICustomer.Country 
		{ 
			get
			{
				return this.Country;
			}
			set
			{
				if(value != this.Country)
				{
					if(value != null)
					{
						this.Country = (Country)value;
					}
					else
					{
						this.Country = null;
					}
				}
			}
		}
		
		#endregion
    }
}
