
// <copyright file=".g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;

namespace DotNetScaffolder.Domain.ApplicationService
{
    /// <summary>
	/// The ProductApplication Service 
	/// </summary>
	public partial class ProductApplicationService  : IProductApplicationService
	{

        /// <summary>
        /// Gets or sets the BankAccount Repository 
        /// </summary>
        protected IBankAccountRepository BankAccountRepository { get; set; }

        public ProductApplicationService (
                      IBankAccountRepository bankAccountRepository
                                     )
        {
            this.BankAccountRepository = bankAccountRepository;
        }

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>BankAccountDto</returns>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
		public BankAccountDto LoadByBankAccountBankAccountId(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return new BankAccountDto(this.BankAccountRepository.LoadByBankAccountId(bankAccountId, cache, includes), true);
        }

        /// <summary>
        /// Load BankAccount Async entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>BankAccountDto</returns>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
		public async Task<BankAccountDto> LoadByBankAccountBankAccountIdAsync(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return new BankAccountDto(await this.BankAccountRepository.LoadByBankAccountIdAsync(bankAccountId, cache, includes), true);
        }

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public IList<BankAccountDto> BankAccountLoadAll(bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto(this.BankAccountRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all BankAccount Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public async Task<IList<BankAccountDto>> BankAccountLoadAllAsync(bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto( await this.BankAccountRepository.LoadAllAsync(cache, includes));
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public IList<BankAccountDto> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto(this.BankAccountRepository.SearchByBankAccountNumber(bankAccountNumber,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for BankAccount Async entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public async Task<IList<BankAccountDto>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber, bool caseSensitive, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto(await this.BankAccountRepository.SearchByBankAccountNumberAsync(bankAccountNumber,caseSensitive, cache, includes));
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountAdd(BankAccountDto entity)
        {
            return this.BankAccountRepository.Add(new BankAccount(entity, true));
        }

        /// <summary>
        /// Add the BankAccount entity async to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public async Task<bool> BankAccountAddAsync(BankAccountDto entity)
        {
            return await this.BankAccountRepository.AddAsync(new BankAccount(entity, true));
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountUpdate(BankAccountDto entity)
        {
            return this.BankAccountRepository.Update(new BankAccount(entity, true));
        }
		
        /// <summary>
        /// Update the BankAccount entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public async Task<bool> BankAccountUpdateAsync(BankAccountDto entity)
        {
            return await this.BankAccountRepository.UpdateAsync(new BankAccount(entity, true));
        }

        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete(BankAccountDto entity)
        {
            return this.BankAccountRepository.Delete(new BankAccount(entity, true));
        }

        /// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public async Task<bool> BankAccountDeleteAsync(BankAccountDto entity)
        {
            return await this.BankAccountRepository.DeleteAsync(new BankAccount(entity, true));
        }

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete( int bankAccountId, bool cache)
        {
            return this.BankAccountRepository.Delete( bankAccountId, cache);
        }

        /// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public async Task<bool> BankAccountDeleteAsync( int bankAccountId, bool cache)
        {
            return await this.BankAccountRepository.DeleteAsync( bankAccountId, cache);
        }


		#endregion

        #region Aggregates
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BankAccountMax<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return this.BankAccountRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankAccountMaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return await this.BankAccountRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BankAccountMin<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return this.BankAccountRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> BankAccountMinAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return await this.BankAccountRepository.MinAsync(maxExpression, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        /// Converts a BankAccountDto list to BankAccount list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BankAccount> ConvertBankAccountDtoToEntity(IEnumerable<BankAccountDto> items)
	    {
            List<BankAccount> results = new List<BankAccount>();

	        foreach (var item in items)
	        {
	            results.Add(new BankAccount(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a BankAccount list to BankAccountDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BankAccountDto> ConvertBankAccountEntityToDto(IEnumerable<BankAccount> items)
	    {
            List<BankAccountDto> results = new List<BankAccountDto>();

	        foreach (var item in items)
	        {
	            results.Add(new BankAccountDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void BankAccountBulkDelete(IEnumerable<BankAccountDto> items)
		{
			this.BankAccountRepository.BulkDelete(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BankAccountBulkDeleteAsync(IEnumerable<BankAccountDto> items)
		{
			await this.BankAccountRepository.BulkDeleteAsync(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  BankAccountBulkInsert(IEnumerable<BankAccountDto> items)
		{
			this.BankAccountRepository.BulkInsert(this.ConvertBankAccountDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BankAccountBulkInsertAsync(IEnumerable<BankAccountDto> items)
		{
			await this.BankAccountRepository.BulkInsertAsync(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  BankAccountBulkUpdate(IEnumerable<BankAccountDto> items)
		{
			this.BankAccountRepository.BulkUpdate(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BankAccountBulkUpdateAsync(IEnumerable<BankAccountDto> items)
		{
			await this.BankAccountRepository.BulkUpdateAsync(this.ConvertBankAccountDtoToEntity(items));
		}

        #endregion

    }
}

