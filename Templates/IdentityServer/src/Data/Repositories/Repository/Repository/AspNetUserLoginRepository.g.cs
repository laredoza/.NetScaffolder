
// <copyright file="AspNetUserLogin.g.cs" company="MIT">
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
	/// The AspNetUserLoginRepository class responsible for database functions in the AspNetUserLogin table
	/// </summary>
	public partial class AspNetUserLoginRepository : UowRepository<AspNetUserLogin> , IAspNetUserLoginRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetUserLoginRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetUserLoginRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetUserLoginRepository
        /// </summary>
		public AspNetUserLoginRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetUserLogin entities from the database using the composite primary keys
        /// </summary
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>AspNetUserLogin</returns>
		public virtual AspNetUserLogin Load( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetUserLogin>(o =>  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(providerKey.ToLower()) , cache, expr);
		}
		
        /// <summary>
        /// Load AspNetUserLogin entities async from the database using the composite primary keys
        /// </summary
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>AspNetUserLogin</returns>
		public virtual async Task<AspNetUserLogin> LoadAsync( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserLogin>(cache, o =>  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(providerKey.ToLower()) , expr);
		}

        /// <summary>
        /// Load all AspNetUserLogin entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		public virtual IList<AspNetUserLogin> LoadAll(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetUserLogin>(cache, expr).ToList<AspNetUserLogin>();
		}
		
        /// <summary>
        /// Load all AspNetUserLogin entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		public virtual async Task<IList<AspNetUserLogin>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUserLogin,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetUserLogin>(cache, expr);
			return result.ToList<AspNetUserLogin>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUserLogin entities in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		public virtual IList<AspNetUserLogin> SearchByProviderDisplayName(string providerDisplayName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUserLogin>(o => o.ProviderDisplayName.Contains(providerDisplayName), cache, expr).ToList<AspNetUserLogin>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUserLogin>(o => o.ProviderDisplayName.ToLower().Contains(providerDisplayName.ToLower()), cache, expr).ToList<AspNetUserLogin>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUserLogin entities async in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		public virtual async Task<IList<AspNetUserLogin>> SearchByProviderDisplayNameAsync(string providerDisplayName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserLogin>(o => o.ProviderDisplayName.Contains(providerDisplayName), cache, expr);
				return result.ToList<AspNetUserLogin>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserLogin>(o => o.ProviderDisplayName.ToLower().Contains(providerDisplayName.ToLower()), cache, expr);
				return result.ToList<AspNetUserLogin>();
			}
		}

        /// <summary>
        /// Search for AspNetUserLogin entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		public virtual IList<AspNetUserLogin> SearchByUserId(string userId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUserLogin>(o => o.UserId.Contains(userId), cache, expr).ToList<AspNetUserLogin>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUserLogin>(o => o.UserId.ToLower().Contains(userId.ToLower()), cache, expr).ToList<AspNetUserLogin>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUserLogin entities async in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		public virtual async Task<IList<AspNetUserLogin>> SearchByUserIdAsync(string userId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserLogin>(o => o.UserId.Contains(userId), cache, expr);
				return result.ToList<AspNetUserLogin>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserLogin>(o => o.UserId.ToLower().Contains(userId.ToLower()), cache, expr);
				return result.ToList<AspNetUserLogin>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUserLogin entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetUserLogin entity)
		{
			var entityToSave = new AspNetUserLogin(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.LoginProvider = entityToSave.LoginProvider;
			entity.ProviderKey = entityToSave.ProviderKey;
			entity.ProviderDisplayName = entityToSave.ProviderDisplayName;
			entity.UserId = entityToSave.UserId;
			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetUserLogin entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetUserLogin entity)
		{
            var entityToSave = new AspNetUserLogin(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.LoginProvider = entityToSave.LoginProvider;
			entity.ProviderKey = entityToSave.ProviderKey;
			entity.ProviderDisplayName = entityToSave.ProviderDisplayName;
			entity.UserId = entityToSave.UserId;
			
			return result;
		}

        /// <summary>
        /// Update the AspNetUserLogin entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetUserLogin entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserLogin>(o =>  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(entity.ProviderKey.ToLower()) , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserLogin entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ProviderDisplayName != entity.ProviderDisplayName) { entityToUpdate.ProviderDisplayName = entity.ProviderDisplayName;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the AspNetUserLogin entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetUserLogin entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserLogin>(true, o =>  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(entity.ProviderKey.ToLower()) );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserLogin entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ProviderDisplayName != entity.ProviderDisplayName) { entityToUpdate.ProviderDisplayName = entity.ProviderDisplayName;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetUserLogin entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserLogin>(o =>  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(entity.ProviderKey.ToLower()) , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserLogin entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetUserLogin entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserLogin>(true, o =>  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(entity.ProviderKey.ToLower()) );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserLogin entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		public virtual bool Delete( string loginProvider,  string providerKey, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserLogin>(o =>  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(providerKey.ToLower()) , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserLogin entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( string loginProvider,  string providerKey, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserLogin>(cache, o =>  o.LoginProvider.ToLower().Contains(loginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(providerKey.ToLower())  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserLogin entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetUserLogin, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetUserLogin, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetUserLogin, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetUserLogin, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetUserLogin, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetUserLogin> items)
		{
            List<AspNetUserLogin> foundItems = new List<AspNetUserLogin>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetUserLogin>(o => o.LoginProvider.ToLower().Contains(item.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(item.ProviderKey.ToLower()) , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserLogin> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IAspNetUserLogin>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetUserLogin> items)
		{
            List<AspNetUserLogin> foundItems = new List<AspNetUserLogin>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserLogin>(true, o => o.LoginProvider.ToLower().Contains(item.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(item.ProviderKey.ToLower()) );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserLogin> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetUserLogin>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetUserLogin> items)
		{
			this.UnitOfWork.BulkInsert<AspNetUserLogin>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetUserLogin> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetUserLogin>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetUserLogin> items)
		{
            List<AspNetUserLogin> foundItems = new List<AspNetUserLogin>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserLogin>(o =>  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(entity.ProviderKey.ToLower()) , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserLogin entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ProviderDisplayName != entity.ProviderDisplayName) { entityToUpdate.ProviderDisplayName = entity.ProviderDisplayName;doUpdate = true; }
			    if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetUserLogin>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetUserLogin> items)
		{
            List<AspNetUserLogin> foundItems = new List<AspNetUserLogin>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserLogin>(true, o =>  o.LoginProvider.ToLower().Contains(entity.LoginProvider.ToLower()) &&  o.ProviderKey.ToLower().Contains(entity.ProviderKey.ToLower()) );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserLogin entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ProviderDisplayName != entity.ProviderDisplayName) { entityToUpdate.ProviderDisplayName = entity.ProviderDisplayName;doUpdate = true; }
			    if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetUserLogin>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetUserLogin, object>>[] Convert(params Expression<Func<IAspNetUserLogin, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetUserLogin, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetUserLogin, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
