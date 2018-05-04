
// <copyright file="BankTransfers.g.cs" company="MIT">
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
	/// The BankTransfersRepository interface that defines database functions for the BankTransfers table
	/// </summary>
	public partial interface IBankTransfersRepository
	{
		#region Load

        /// <summary>
        /// Load the BankTransfers entity from the database using the BankTransferId primary key
        /// </summary>
        /// <param name="banktransferid">int</param>
        /// <returns>IBankTransfers</returns>
		IBankTransfers LoadByBankTransferId(int banktransferid);

        /// <summary>
        /// Load BankTransfers entities from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="frombankaccountid">int</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByFromBankAccountId(int frombankaccountid);

        /// <summary>
        /// Load BankTransfers entities from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="tobankaccountid">int</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByToBankAccountId(int tobankaccountid);

        /// <summary>
        /// Load BankTransfers entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByAmount(decimal amount);

        /// <summary>
        /// Load BankTransfers entities from the database using the TransferDate field
        /// </summary>
        /// <param name="transferdate">DateTime</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByTransferDate(DateTime transferdate);

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool Save(IBankTransfers entity);
		
        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool Update(IBankTransfers entity);
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool Delete(IBankTransfers entity);
		
        /// <summary>
        /// Delete the BankTransfers entity from the database using the BankTransferId
        /// </summary>
        /// <param name="banktransferid">int</param>
        /// <returns>bool</returns>
		bool DeleteByBankTransferId(int banktransferid);

		#endregion
	}
}
