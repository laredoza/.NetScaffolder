
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

namespace Banking.Models.Interfaces
{
	public partial interface ICustomerRepository
	{
		#region Load
		
		ICustomer LoadByCustomerId(int customerid);
		IList<ICustomer> LoadByCustomerCode(string customercode);
		IList<ICustomer> LoadByCompanyName(string companyname);
		IList<ICustomer> LoadByContactName(string contactname);
		IList<ICustomer> LoadByContactTitle(string contacttitle);
		IList<ICustomer> LoadByAddress(string address);
		IList<ICustomer> LoadByCity(string city);
		IList<ICustomer> LoadByPostalCode(string postalcode);
		IList<ICustomer> LoadByTelephone(string telephone);
		IList<ICustomer> LoadByFax(string fax);
		IList<ICustomer> LoadByCountryId(int countryid);
		IList<ICustomer> LoadByPhoto(string photo);
		IList<ICustomer> LoadByIsEnabled(bool isenabled);
		IList<ICustomer> LoadAll();
		
		#endregion

		#region Search
		
		IList<ICustomer> SearchByCustomerCode(string customercode);
		IList<ICustomer> SearchByCompanyName(string companyname);
		IList<ICustomer> SearchByContactName(string contactname);
		IList<ICustomer> SearchByContactTitle(string contacttitle);
		IList<ICustomer> SearchByAddress(string address);
		IList<ICustomer> SearchByCity(string city);
		IList<ICustomer> SearchByPostalCode(string postalcode);
		IList<ICustomer> SearchByTelephone(string telephone);
		IList<ICustomer> SearchByFax(string fax);
		IList<ICustomer> SearchByPhoto(string photo);

		#endregion
		
		#region CRUD
		
		bool Save(ICustomer entity);
		bool Update(ICustomer entity);
		bool Delete(ICustomer entity);
		bool DeleteByCustomerId(int customerid);

		#endregion
	}
}
