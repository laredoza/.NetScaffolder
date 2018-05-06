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

namespace Banking.Models.Interfaces
{
	public partial interface ICustomer  
	{
		#region Fields
		
		int CustomerId { get; set; }
		string CustomerCode { get; set; }
		string CompanyName { get; set; }
		string ContactName { get; set; }
		string ContactTitle { get; set; }
		string Address { get; set; }
		string City { get; set; }
		string PostalCode { get; set; }
		string Telephone { get; set; }
		string Fax { get; set; }
		int CountryId { get; set; }
		string Photo { get; set; }
		bool IsEnabled { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<IBankAccount> BankAccounts { get; set; }
		IList<IOrder> Orders { get; set; }
		
		#endregion
		
		#region Parent Relationships
		
		ICountry Country { get; set; }
		
		#endregion
	}
}
