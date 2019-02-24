﻿
// <copyright file="AspNetUserToken.g.cs" company="MIT">
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
	/// The AspNetUserTokenRepository class responsible for database functions in the AspNetUserToken table
	/// </summary>
	public partial class AspNetUserTokenRepository : UowRepository<AspNetUserToken> , IAspNetUserTokenRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetUserTokenRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetUserTokenRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetUserTokenRepository
        /// </summary>
		public AspNetUserTokenRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetUserToken entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
		/// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>AspNetUserToken</returns>
		public virtual AspNetUserToken Load( Guid userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetUserToken>(o =>  o.UserId == userId &&  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.Name.ToLower().Contains(name.ToLower()) , cache, expr);
		}
		
        /// <summary>
        /// Load AspNetUserToken entities async from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
		/// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>AspNetUserToken</returns>
		public virtual async Task<AspNetUserToken> LoadAsync( Guid userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserToken>(cache, o =>  o.UserId == userId &&  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.Name.ToLower().Contains(name.ToLower()) , expr);
		}

        /// <summary>
        /// Load all AspNetUserToken entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserToken></returns>
		public virtual IList<AspNetUserToken> LoadAll(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetUserToken>(cache, expr).ToList<AspNetUserToken>();
		}
		
        /// <summary>
        /// Load all AspNetUserToken entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserToken></returns>
		public virtual async Task<IList<AspNetUserToken>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUserToken,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetUserToken>(cache, expr);
			return result.ToList<AspNetUserToken>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUserToken entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserToken></returns>
		public virtual IList<AspNetUserToken> SearchByValue(string value, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserToken, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUserToken>(o => o.Value.Contains(value), cache, expr).ToList<AspNetUserToken>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUserToken>(o => o.Value.ToLower().Contains(value.ToLower()), cache, expr).ToList<AspNetUserToken>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUserToken entities async in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserToken></returns>
		public virtual async Task<IList<AspNetUserToken>> SearchByValueAsync(string value, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserToken, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserToken>(o => o.Value.Contains(value), cache, expr);
				return result.ToList<AspNetUserToken>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserToken>(o => o.Value.ToLower().Contains(value.ToLower()), cache, expr);
				return result.ToList<AspNetUserToken>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUserToken entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserToken</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetUserToken entity)
		{
			this.UnitOfWork.Add(entity);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
//			//entity.UserId = entityToSave.UserId;
//			//entity.LoginProvider = entityToSave.LoginProvider;
//			//entity.Name = entityToSave.Name;
//			//entity.Value = entityToSave.Value;
//			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetUserToken entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetUserToken</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetUserToken entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
//			//entity.UserId = entityToSave.UserId;
//			//entity.LoginProvider = entityToSave.LoginProvider;
//			//entity.Name = entityToSave.Name;
//			//entity.Value = entityToSave.Value;
//			
			return result;
		}

        /// <summary>
        /// Update the AspNetUserToken entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserToken</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetUserToken entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserToken>(o =>  o.UserId == entity.UserId &&  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(entity.Name.ToLower()) , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserToken entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the AspNetUserToken entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserToken</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetUserToken entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserToken>(true, o =>  o.UserId == entity.UserId &&  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(entity.Name.ToLower()) );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserToken entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserToken</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetUserToken entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserToken>(o =>  o.UserId == entity.UserId &&  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(entity.Name.ToLower()) , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserToken entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUserToken</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetUserToken entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserToken>(true, o =>  o.UserId == entity.UserId &&  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(entity.Name.ToLower()) );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserToken entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		public virtual bool Delete( Guid userId,  string loginProvider,  string name, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserToken>(o =>  o.UserId == userId &&  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.Name.ToLower().Contains(name.ToLower()) , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserToken entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( Guid userId,  string loginProvider,  string name, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserToken>(cache, o =>  o.UserId == userId &&  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.Name.ToLower().Contains(name.ToLower())  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserToken entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetUserToken, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetUserToken, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetUserToken, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetUserToken, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUserToken, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetUserToken, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetUserToken> items)
		{
            List<AspNetUserToken> foundItems = new List<AspNetUserToken>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetUserToken>(o => o.UserId == item.UserId &&  o.LoginProvider.ToLower().Contains(item.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(item.Name.ToLower()) , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserToken> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<AspNetUserToken>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetUserToken> items)
		{
            List<AspNetUserToken> foundItems = new List<AspNetUserToken>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserToken>(true, o => o.UserId == item.UserId &&  o.LoginProvider.ToLower().Contains(item.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(item.Name.ToLower()) );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserToken> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetUserToken>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetUserToken> items)
		{
			this.UnitOfWork.BulkInsert<AspNetUserToken>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetUserToken> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetUserToken>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetUserToken> items)
		{
            List<AspNetUserToken> foundItems = new List<AspNetUserToken>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserToken>(o =>  o.UserId == entity.UserId &&  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(entity.Name.ToLower()) , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserToken entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetUserToken>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetUserToken> items)
		{
            List<AspNetUserToken> foundItems = new List<AspNetUserToken>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserToken>(true, o =>  o.UserId == entity.UserId &&  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.Name.ToLower().Contains(entity.Name.ToLower()) );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserToken entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetUserToken>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetUserToken, object>>[] Convert(params Expression<Func<IAspNetUserToken, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetUserToken, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetUserToken, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
