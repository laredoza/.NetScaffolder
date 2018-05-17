﻿
// <copyright file="Doctor.g.cs" company="MIT">
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
	public partial class Doctor : IDoctor 
	{
		#region CTOR
		
		public Doctor()
		{
			this.Customer = new List <Customer>();
		}
		
		public Doctor(IDoctor item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Surname = item.Surname;
			this.FirstName = item.FirstName;
			this.AddressID = item.AddressID;
			this.PhoneId = item.PhoneId;
			this.Customer = new List <Customer>();

			if(deep)
			{
				if(item.Customer != null)
				{
					foreach(var childItem in item.Customer)
					{
						this.Customer.Add(new Customer(childItem, deep));
					}
				}
				if(item.Phone != null)
                {
                    this.Phone = new Phone(item.Phone, deep);
                }
				if(item.Address != null)
                {
                    this.Address = new Address(item.Address, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Surname { get; set; }
		public string FirstName { get; set; }
		public Nullable<int> AddressID { get; set; }
		public Nullable<int> PhoneId { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<Customer> Customer { get; set; }

        IList<ICustomer> IDoctor.Customer 
		{ 
			get
			{
				return (IList<ICustomer>)this.Customer;
			}
			set
			{
				this.Customer = (IList<Customer>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Phone Phone { get; set; }

		IPhone IDoctor.Phone 
		{ 
			get
			{
				return this.Phone;
			}
			set
			{
				this.Phone = (Phone)value;
			}
		}

        public virtual Address Address { get; set; }

		IAddress IDoctor.Address 
		{ 
			get
			{
				return this.Address;
			}
			set
			{
				this.Address = (Address)value;
			}
		}
		
		#endregion
	}
}
