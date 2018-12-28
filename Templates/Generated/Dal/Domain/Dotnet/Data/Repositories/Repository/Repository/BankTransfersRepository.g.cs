
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Repository
{
	/// <summary>
	/// The BankTransfersRepository class responsible for database functions in the BankTransfers table
	/// </summary>
	public partial class BankTransfersRepository : UowRepository<IBankTransfers> , IBankTransfersRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BankTransfersRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BankTransfersRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for BankTransfersRepository
        /// </summary>
		public BankTransfersRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load BankTransfers entities from the database using the composite primary keys
        /// </summary
        /// <param name="bankTransferId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		public virtual IBankTransfers LoadByBankTransferId(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == bankTransferId, cache, expr);
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the composite primary keys
        /// </summary
        /// <param name="bankTransferId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		public virtual async Task<IBankTransfers> LoadByBankTransferIdAsync(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(cache, o => o.BankTransferId == bankTransferId, expr);
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByFromBankAccountId(int fromBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.FromBankAccountId == fromBankAccountId, cache, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByFromBankAccountIdAsync(int fromBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.FromBankAccountId == fromBankAccountId,cache, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByToBankAccountId(int toBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.ToBankAccountId == toBankAccountId, cache, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByToBankAccountIdAsync(int toBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.ToBankAccountId == toBankAccountId,cache, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByAmount(decimal amount, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.Amount == amount, cache, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByAmountAsync(decimal amount, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.Amount == amount,cache, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByTransferDate(DateTime transferDate, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.TransferDate == transferDate, cache, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByTransferDateAsync(DateTime transferDate, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.TransferDate == transferDate,cache, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadAll(bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<BankTransfers>(cache, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load all BankTransfers entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadAllAsync(bool cache, params Expression<Func<IBankTransfers,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<BankTransfers>(cache, expr);
			return result.ToList<IBankTransfers>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Add(IBankTransfers entity)
		{
			var entityToSave = new BankTransfers(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.BankTransferId = entityToSave.BankTransferId;
			entity.FromBankAccountId = entityToSave.FromBankAccountId;
			entity.ToBankAccountId = entityToSave.ToBankAccountId;
			entity.Amount = entityToSave.Amount;
			entity.TransferDate = entityToSave.TransferDate;
			
			return result;
		}
		
        /// <summary>
        /// Add the BankTransfers entity async to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IBankTransfers entity)
		{
			var entityToSave = new BankTransfers(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.BankTransferId = entityToSave.BankTransferId;
			entity.FromBankAccountId = entityToSave.FromBankAccountId;
			entity.ToBankAccountId = entityToSave.ToBankAccountId;
			entity.Amount = entityToSave.Amount;
			entity.TransferDate = entityToSave.TransferDate;
			
			return result;
		}

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Update(IBankTransfers entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the BankTransfers entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IBankTransfers entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IBankTransfers entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IBankTransfers entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int bankTransferId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == bankTransferId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int bankTransferId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(cache, o =>  o.BankTransferId == bankTransferId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<BankTransfers, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<BankTransfers, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IBankTransfers, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<BankTransfers, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<BankTransfers, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IBankTransfers> items)
		{
			this.UnitOfWork.BulkDelete<IBankTransfers>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IBankTransfers> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<IBankTransfers>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IBankTransfers> items)
		{
			this.UnitOfWork.BulkInsert<IBankTransfers>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IBankTransfers> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IBankTransfers>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IBankTransfers> items)
		{
			this.UnitOfWork.BulkUpdate<IBankTransfers>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IBankTransfers> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<IBankTransfers>(items);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<BankTransfers, object>>[] Convert(params Expression<Func<IBankTransfers, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<BankTransfers, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<BankTransfers, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
