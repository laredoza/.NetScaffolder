
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
		public virtual IBankTransfers LoadByBankTransferId(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == bankTransferId, expr);
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the composite primary keys
        /// </summary
        /// <param name="bankTransferId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		public virtual async Task<IBankTransfers> LoadByBankTransferIdAsync(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(o => o.BankTransferId == bankTransferId, expr);
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByFromBankAccountId(int fromBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.FromBankAccountId == fromBankAccountId, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByFromBankAccountIdAsync(int fromBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.FromBankAccountId == fromBankAccountId, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByToBankAccountId(int toBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.ToBankAccountId == toBankAccountId, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByToBankAccountIdAsync(int toBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.ToBankAccountId == toBankAccountId, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByAmount(decimal amount, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.Amount == amount, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByAmountAsync(decimal amount, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.Amount == amount, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load BankTransfers entities from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadByTransferDate(DateTime transferDate, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<BankTransfers>(o => o.TransferDate == transferDate, expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadByTransferDateAsync(DateTime transferDate, params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<BankTransfers>(o => o.TransferDate == transferDate, expr);
			return result.ToList<IBankTransfers>();
		}

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual IList<IBankTransfers> LoadAll(params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<BankTransfers>(expr).ToList<IBankTransfers>();
		}
		
        /// <summary>
        /// Load all BankTransfers entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public virtual async Task<IList<IBankTransfers>> LoadAllAsync(params Expression<Func<IBankTransfers, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<BankTransfers>(expr);
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
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId );
			
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
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IBankTransfers entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId );
			
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
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IBankTransfers entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IBankTransfers entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(o =>  o.BankTransferId == entity.BankTransferId );
			
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
		public virtual bool Delete( int bankTransferId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankTransfers>(o =>  o.BankTransferId == bankTransferId );
			
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
		public virtual async Task<bool> DeleteAsync( int bankTransferId)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<BankTransfers>(o =>  o.BankTransferId == bankTransferId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression)
		{
			return this.UnitOfWork.Max(Expression.Lambda<Func<BankTransfers, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression)
		{
			return await this.UnitOfWork.MaxAsync(Expression.Lambda<Func<BankTransfers, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IBankTransfers, TResult>> minExpression)
		{
			return this.UnitOfWork.Min(Expression.Lambda<Func<BankTransfers, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> minExpression)
		{
			return await this.UnitOfWork.MinAsync(Expression.Lambda<Func<BankTransfers, TResult>>(minExpression.Body, minExpression.Parameters));
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
