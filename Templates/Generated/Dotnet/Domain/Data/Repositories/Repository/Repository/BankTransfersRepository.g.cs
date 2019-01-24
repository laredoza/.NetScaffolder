﻿
// <copyright file="BankTransfers.g.cs" company="MIT">
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;

using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Repositories.Repository
{
	/// <summary>
	/// The BankTransfersRepository class responsible for database functions in the BankTransfers table
	/// </summary>
	public partial class BankTransfersRepository : UowRepository<BankTransfers> , IBankTransfersRepository
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
        /// <returns>BankTransfers</returns>
		public virtual BankTransfers LoadByBankTransferId(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == bankTransferId, cache, expr);
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the composite primary keys
        /// </summary
        /// <param name="bankTransferId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>BankTransfers</returns>
		public virtual async Task<BankTransfers> LoadByBankTransferIdAsync(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(cache, o => o.BankTransferId == bankTransferId, expr);
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<BankTransfers> LoadByFromBankAccountId(int fromBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.FromBankAccountId == fromBankAccountId, cache, expr).ToList<BankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<BankTransfers>> LoadByFromBankAccountIdAsync(int fromBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.FromBankAccountId == fromBankAccountId,cache, expr);
			return result.ToList<BankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<BankTransfers> LoadByToBankAccountId(int toBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.ToBankAccountId == toBankAccountId, cache, expr).ToList<BankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<BankTransfers>> LoadByToBankAccountIdAsync(int toBankAccountId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.ToBankAccountId == toBankAccountId,cache, expr);
			return result.ToList<BankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<BankTransfers> LoadByAmount(decimal amount, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.Amount == amount, cache, expr).ToList<BankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<BankTransfers>> LoadByAmountAsync(decimal amount, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.Amount == amount,cache, expr);
			return result.ToList<BankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<BankTransfers> LoadByTransferDate(DateTime transferDate, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.TransferDate == transferDate, cache, expr).ToList<BankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param>
		/// <param name="includes">params Expression<Func<BankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<BankTransfers>> LoadByTransferDateAsync(DateTime transferDate, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.TransferDate == transferDate,cache, expr);
			return result.ToList<BankTransfers>();
		}

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<BankTransfers></returns>
		public virtual IList<BankTransfers> LoadAll(bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<BankTransfers>(cache, expr).ToList<BankTransfers>();
		}
		
        /// <summary>
        /// Load all BankTransfers entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<BankTransfers></returns>
		public virtual async Task<IList<BankTransfers>> LoadAllAsync(bool cache, params Expression<Func<IBankTransfers,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<BankTransfers>(cache, expr);
			return result.ToList<BankTransfers>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">BankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Add(BankTransfers entity)
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
        /// <param name="entity">BankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(BankTransfers entity)
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
        /// <param name="entity">BankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Update(BankTransfers entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.FromBankAccountId != entity.FromBankAccountId) { entityToUpdate.FromBankAccountId = entity.FromBankAccountId;doUpdate = true; }
			if (entityToUpdate.ToBankAccountId != entity.ToBankAccountId) { entityToUpdate.ToBankAccountId = entity.ToBankAccountId;doUpdate = true; }
			if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			if (entityToUpdate.TransferDate != entity.TransferDate) { entityToUpdate.TransferDate = entity.TransferDate;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the BankTransfers entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(BankTransfers entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(true, o =>  o.BankTransferId == entity.BankTransferId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.FromBankAccountId != entity.FromBankAccountId) { entityToUpdate.FromBankAccountId = entity.FromBankAccountId;doUpdate = true; }
			if (entityToUpdate.ToBankAccountId != entity.ToBankAccountId) { entityToUpdate.ToBankAccountId = entity.ToBankAccountId;doUpdate = true; }
			if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			if (entityToUpdate.TransferDate != entity.TransferDate) { entityToUpdate.TransferDate = entity.TransferDate;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">BankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Delete(BankTransfers entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="entity">BankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(BankTransfers entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(true, o =>  o.BankTransferId == entity.BankTransferId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
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
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IBankTransfers, TResult>>(maxExpression.Body, maxExpression.Parameters));
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
        public void BulkDelete(IEnumerable<BankTransfers> items)
		{
            List<BankTransfers> foundItems = new List<BankTransfers>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == item.BankTransferId , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The BankTransfers> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IBankTransfers>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<BankTransfers> items)
		{
            List<BankTransfers> foundItems = new List<BankTransfers>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(true, o => o.BankTransferId == item.BankTransferId );

		        if (foundEntity == null)
		        {
		            throw new Exception("The BankTransfers> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<BankTransfers>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<BankTransfers> items)
		{
			this.UnitOfWork.BulkInsert<BankTransfers>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<BankTransfers> items)
		{
			await this.UnitOfWork.BulkInsertAsync<BankTransfers>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<BankTransfers> items)
		{
            List<BankTransfers> foundItems = new List<BankTransfers>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The BankTransfers entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.FromBankAccountId != entity.FromBankAccountId) { entityToUpdate.FromBankAccountId = entity.FromBankAccountId;doUpdate = true; }
			    if (entityToUpdate.ToBankAccountId != entity.ToBankAccountId) { entityToUpdate.ToBankAccountId = entity.ToBankAccountId;doUpdate = true; }
			    if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			    if (entityToUpdate.TransferDate != entity.TransferDate) { entityToUpdate.TransferDate = entity.TransferDate;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<BankTransfers>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<BankTransfers> items)
		{
            List<BankTransfers> foundItems = new List<BankTransfers>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(true, o =>  o.BankTransferId == entity.BankTransferId );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The BankTransfers entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.FromBankAccountId != entity.FromBankAccountId) { entityToUpdate.FromBankAccountId = entity.FromBankAccountId;doUpdate = true; }
			    if (entityToUpdate.ToBankAccountId != entity.ToBankAccountId) { entityToUpdate.ToBankAccountId = entity.ToBankAccountId;doUpdate = true; }
			    if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			    if (entityToUpdate.TransferDate != entity.TransferDate) { entityToUpdate.TransferDate = entity.TransferDate;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<BankTransfers>(foundItems);
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
