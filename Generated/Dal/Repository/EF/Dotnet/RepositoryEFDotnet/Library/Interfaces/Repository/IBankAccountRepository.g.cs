
// <copyright file="BankAccount.g.cs" company="MIT">
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
	/// <summary>
	/// The BankAccountRepository interface that defines database functions for the BankAccount table
	/// </summary>
	public partial interface IBankAccountRepository
	{
		#region Load

        /// <summary>
        /// Load the BankAccount entity from the database using the BankAccountId primary key
        /// </summary>
        /// <param name="bankaccountid">int</param>
        /// <returns>IBankAccount</returns>
		IBankAccount LoadByBankAccountId(int bankaccountid);

        /// <summary>
        /// Load BankAccount entities from the database using the BankAccountNumber field
        /// </summary>
        /// <param name="bankaccountnumber">string</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> LoadByBankAccountNumber(string bankaccountnumber);

        /// <summary>
        /// Load BankAccount entities from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> LoadByBalance(decimal balance);

        /// <summary>
        /// Load BankAccount entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">int</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> LoadByCustomerId(int customerid);

        /// <summary>
        /// Load BankAccount entities from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> LoadByLocked(bool locked);

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankaccountnumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> SearchByBankAccountNumber(string bankaccountnumber, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool Save(IBankAccount entity);
		
        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool Update(IBankAccount entity);
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool Delete(IBankAccount entity);
		
        /// <summary>
        /// Delete the BankAccount entity from the database using the BankAccountId
        /// </summary>
        /// <param name="bankaccountid">int</param>
        /// <returns>bool</returns>
		bool DeleteByBankAccountId(int bankaccountid);

		#endregion
	}
}
