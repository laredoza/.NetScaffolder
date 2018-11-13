
// <copyright file=".g.cs" company="MIT">
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

namespace Banking.Models.ApplicationService
{
    /// <summary>
	/// The NewApplication Service 
	/// </summary>
	public partial class NewApplicationService  : INewApplicationService
	{


        protected IBankAccountRepository BankAccountRepository { get; set; }

        protected ICountryRepository CountryRepository { get; set; }

        public NewApplicationService (
                                          IBankAccountRepository bankAccountRepository,
                                          ICountryRepository countryRepository
                                     )
        {
            this.BankAccountRepository = bankAccountRepository;
            this.CountryRepository = countryRepository;
        }

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>IBankAccount</returns>
		public IBankAccount LoadByBankAccountBankAccountId(int bankAccountId)
        {
            return this.BankAccountRepository.LoadByBankAccountId(bankAccountId);
        }


        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <returns>IList<IBankAccount></returns>
		public IList<IBankAccount> BankAccountLoadAll()
        {
            return this.BankAccountRepository.LoadAll();
        }


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>ICountry</returns>
		public ICountry LoadByCountryCountryId(int countryId)
        {
            return this.CountryRepository.LoadByCountryCountryId(countryId);
        }


        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> CountryLoadAll()
        {
            return this.CountryRepository.LoadAll();
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
		public IList<IBankAccount> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive = false)
        {
            return this.BankAccountRepository.SearchByBankAccountNumber(bankAccountNumber,caseSensitive);
        }


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> CountrySearchByCountryName(string countryName, bool caseSensitive = false)
        {
            return this.CountryRepository.SearchByCountryName(countryName,caseSensitive);
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountSave(IBankAccount entity)
        {
            return this.BankAccountRepository.Save(entity);
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountUpdate(IBankAccount entity)
        {
            return this.BankAccountRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete(IBankAccount entity)
        {
            return this.BankAccountRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete( int bankAccountId)
        {
            return this.BankAccountRepository.Delete( bankAccountId);
        }

		
        /// <summary>
        /// Save the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountrySave(ICountry entity)
        {
            return this.CountryRepository.Save(entity);
        }

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryUpdate(ICountry entity)
        {
            return this.CountryRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryDelete(ICountry entity)
        {
            return this.CountryRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		public bool CountryDelete( int countryId)
        {
            return this.CountryRepository.Delete( countryId);
        }


		#endregion

    }
}

