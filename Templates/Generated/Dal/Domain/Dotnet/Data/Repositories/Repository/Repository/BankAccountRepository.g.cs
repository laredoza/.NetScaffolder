
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Repository
{
	/// <summary>
	/// The BankAccountRepository class responsible for database functions in the BankAccount table
	/// </summary>
	public partial class BankAccountRepository : UowRepository<IBankAccount> , IBankAccountRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BankAccountRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BankAccountRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for BankAccountRepository
        /// </summary>
		public BankAccountRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load BankAccount entities from the database using the composite primary keys
        /// </summary
        /// <param name="bankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IBankAccount</returns>
		public virtual IBankAccount LoadByBankAccountId(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<BankAccount>(o => o.BankAccountId == bankAccountId, cache, expr);
		}
		
        /// <summary>
        /// Load BankAccount entities async from the database using the composite primary keys
        /// </summary
        /// <param name="bankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IBankAccount</returns>
		public virtual async Task<IBankAccount> LoadByBankAccountIdAsync(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<BankAccount>(cache, o => o.BankAccountId == bankAccountId, expr);
		}

        /// <summary>
        /// Load BankAccount entities from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByBalance(decimal balance, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.Balance == balance, cache, expr).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load BankAccount entities async from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual async Task<IList<IBankAccount>> LoadByBalanceAsync(decimal balance, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankAccount>(o => o.Balance == balance,cache, expr);
			return result.ToList<IBankAccount>();
		}

        /// <summary>
        /// Load BankAccount entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByCustomerId(Nullable<int> customerId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.CustomerId == customerId, cache, expr).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load BankAccount entities async from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual async Task<IList<IBankAccount>> LoadByCustomerIdAsync(Nullable<int> customerId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankAccount>(o => o.CustomerId == customerId,cache, expr);
			return result.ToList<IBankAccount>();
		}

        /// <summary>
        /// Load BankAccount entities from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByLocked(bool locked, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.Locked == locked, cache, expr).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load BankAccount entities async from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual async Task<IList<IBankAccount>> LoadByLockedAsync(bool locked, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankAccount>(o => o.Locked == locked,cache, expr);
			return result.ToList<IBankAccount>();
		}

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadAll(bool cache, params Expression<Func<IBankAccount, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<BankAccount>(cache, expr).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load all BankAccount entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual async Task<IList<IBankAccount>> LoadAllAsync(bool cache, params Expression<Func<IBankAccount,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<BankAccount>(cache, expr);
			return result.ToList<IBankAccount>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> SearchByBankAccountNumber(string bankAccountNumber, bool cache, bool caseSensitive = false, params Expression<Func<IBankAccount, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<BankAccount>(o => o.BankAccountNumber.Contains(bankAccountNumber), cache, expr).ToList<IBankAccount>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<BankAccount>(o => o.BankAccountNumber.ToLower().Contains(bankAccountNumber.ToLower()), cache, expr).ToList<IBankAccount>();
			}
		}
		
        /// <summary>
        /// Search for BankAccount entities async in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual async Task<IList<IBankAccount>> SearchByBankAccountNumberAsync(string bankAccountNumber, bool cache, bool caseSensitive = false, params Expression<Func<IBankAccount, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<BankAccount>(o => o.BankAccountNumber.Contains(bankAccountNumber), cache, expr);
				return result.ToList<IBankAccount>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<BankAccount>(o => o.BankAccountNumber.ToLower().Contains(bankAccountNumber.ToLower()), cache, expr);
				return result.ToList<IBankAccount>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool Add(IBankAccount entity)
		{
			var entityToSave = new BankAccount(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.BankAccountId = entityToSave.BankAccountId;
			entity.BankAccountNumber = entityToSave.BankAccountNumber;
			entity.Balance = entityToSave.Balance;
			entity.CustomerId = entityToSave.CustomerId;
			entity.Locked = entityToSave.Locked;
			
			return result;
		}
		
        /// <summary>
        /// Add the BankAccount entity async to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IBankAccount entity)
		{
			var entityToSave = new BankAccount(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.BankAccountId = entityToSave.BankAccountId;
			entity.BankAccountNumber = entityToSave.BankAccountNumber;
			entity.Balance = entityToSave.Balance;
			entity.CustomerId = entityToSave.CustomerId;
			entity.Locked = entityToSave.Locked;
			
			return result;
		}

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool Update(IBankAccount entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the BankAccount entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IBankAccount entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IBankAccount entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IBankAccount entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int bankAccountId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankAccount>(o =>  o.BankAccountId == bankAccountId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankAccount entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int bankAccountId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<BankAccount>(cache, o =>  o.BankAccountId == bankAccountId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankAccount entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<BankAccount, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<BankAccount, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IBankAccount, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<BankAccount, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IBankAccount, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<BankAccount, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IBankAccount> items)
		{
			this.UnitOfWork.BulkDelete<IBankAccount>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IBankAccount> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<IBankAccount>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IBankAccount> items)
		{
			this.UnitOfWork.BulkInsert<IBankAccount>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IBankAccount> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IBankAccount>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IBankAccount> items)
		{
			this.UnitOfWork.BulkUpdate<IBankAccount>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IBankAccount> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<IBankAccount>(items);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<BankAccount, object>>[] Convert(params Expression<Func<IBankAccount, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<BankAccount, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<BankAccount, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
