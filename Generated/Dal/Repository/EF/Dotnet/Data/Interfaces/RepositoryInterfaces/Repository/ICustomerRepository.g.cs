
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
    using RepositoryEFDotnet.Core.Base;

    /// <summary>
	/// The CustomerRepository interface that defines database functions for the Customer table
	/// </summary>
	public partial interface ICustomerRepository : IRepository<ICustomer>
	{
		#region Load

        /// <summary>
        /// Load Customer entities from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>ICustomer</returns>
		ICustomer LoadByCustomerId(int customerId);

        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> LoadByCountryId(Nullable<int> countryId);

        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> LoadByIsEnabled(bool isEnabled);

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByCustomerCode(string customerCode, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByCompanyName(string companyName, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByContactName(string contactName, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByContactTitle(string contactTitle, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByAddress(string address, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByCity(string city, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByPostalCode(string postalCode, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByTelephone(string telephone, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByFax(string fax, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByPhoto(string photo, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Save(ICustomer entity);

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Update(ICustomer entity);
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Delete(ICustomer entity);

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		bool Delete( int customerId);

		#endregion
	}
}
