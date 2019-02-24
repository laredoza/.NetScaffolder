
// <copyright file="RedirectUri.g.cs" company="MIT">
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
	/// The RedirectUriRepository class responsible for database functions in the RedirectUri table
	/// </summary>
	public partial class RedirectUriRepository : UowRepository<RedirectUri> , IRedirectUriRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for RedirectUriRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public RedirectUriRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for RedirectUriRepository
        /// </summary>
		public RedirectUriRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load RedirectUri entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>RedirectUri</returns>
		public virtual RedirectUri LoadById(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<RedirectUri>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load RedirectUri entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>RedirectUri</returns>
		public virtual async Task<RedirectUri> LoadByIdAsync(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<RedirectUri>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load RedirectUri entities from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param>
		/// <param name="includes">params Expression<Func<RedirectUri, object>>[]</param>
        /// <returns>IList<IRedirectUri></returns>
		public virtual IList<RedirectUri> LoadByClientId(int clientId, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<RedirectUri>(o => o.ClientId == clientId, cache, expr).ToList<RedirectUri>();
		}
		
        /// <summary>
        /// Load RedirectUri entities async from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param>
		/// <param name="includes">params Expression<Func<RedirectUri, object>>[]</param>
        /// <returns>IList<IRedirectUri></returns>
		public virtual async Task<IList<RedirectUri>> LoadByClientIdAsync(int clientId, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<RedirectUri>(o => o.ClientId == clientId,cache, expr);
			return result.ToList<RedirectUri>();
		}

        /// <summary>
        /// Load all RedirectUri entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		public virtual IList<RedirectUri> LoadAll(bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<RedirectUri>(cache, expr).ToList<RedirectUri>();
		}
		
        /// <summary>
        /// Load all RedirectUri entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		public virtual async Task<IList<RedirectUri>> LoadAllAsync(bool cache, params Expression<Func<IRedirectUri,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<RedirectUri>(cache, expr);
			return result.ToList<RedirectUri>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for RedirectUri entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		public virtual IList<RedirectUri> SearchByUri(string uri, bool cache, bool caseSensitive = false, params Expression<Func<IRedirectUri, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<RedirectUri>(o => o.Uri.Contains(uri), cache, expr).ToList<RedirectUri>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<RedirectUri>(o => o.Uri.ToLower().Contains(uri.ToLower()), cache, expr).ToList<RedirectUri>();
			}
		}
		
        /// <summary>
        /// Search for RedirectUri entities async in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		public virtual async Task<IList<RedirectUri>> SearchByUriAsync(string uri, bool cache, bool caseSensitive = false, params Expression<Func<IRedirectUri, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<RedirectUri>(o => o.Uri.Contains(uri), cache, expr);
				return result.ToList<RedirectUri>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<RedirectUri>(o => o.Uri.ToLower().Contains(uri.ToLower()), cache, expr);
				return result.ToList<RedirectUri>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the RedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		public virtual bool Add(RedirectUri entity)
		{
			this.UnitOfWork.Add(entity);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.Uri = entityToSave.Uri;
//			
			return result;
		}
		
        /// <summary>
        /// Add the RedirectUri entity async to the database.
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(RedirectUri entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.Uri = entityToSave.Uri;
//			
			return result;
		}

        /// <summary>
        /// Update the RedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		public virtual bool Update(RedirectUri entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<RedirectUri>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The RedirectUri entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.Uri != entity.Uri) { entityToUpdate.Uri = entity.Uri;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the RedirectUri entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(RedirectUri entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<RedirectUri>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The RedirectUri entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.Uri != entity.Uri) { entityToUpdate.Uri = entity.Uri;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		public virtual bool Delete(RedirectUri entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<RedirectUri>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The RedirectUri entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(RedirectUri entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<RedirectUri>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The RedirectUri entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<RedirectUri>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The RedirectUri entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<RedirectUri>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The RedirectUri entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<RedirectUri, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IRedirectUri, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IRedirectUri, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<RedirectUri, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IRedirectUri, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<RedirectUri, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<RedirectUri> items)
		{
            List<RedirectUri> foundItems = new List<RedirectUri>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<RedirectUri>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The RedirectUri> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<RedirectUri>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<RedirectUri> items)
		{
            List<RedirectUri> foundItems = new List<RedirectUri>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<RedirectUri>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The RedirectUri> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<RedirectUri>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<RedirectUri> items)
		{
			this.UnitOfWork.BulkInsert<RedirectUri>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<RedirectUri> items)
		{
			await this.UnitOfWork.BulkInsertAsync<RedirectUri>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<RedirectUri> items)
		{
            List<RedirectUri> foundItems = new List<RedirectUri>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<RedirectUri>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The RedirectUri entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.Uri != entity.Uri) { entityToUpdate.Uri = entity.Uri;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<RedirectUri>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<RedirectUri> items)
		{
            List<RedirectUri> foundItems = new List<RedirectUri>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<RedirectUri>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The RedirectUri entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.Uri != entity.Uri) { entityToUpdate.Uri = entity.Uri;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<RedirectUri>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<RedirectUri, object>>[] Convert(params Expression<Func<IRedirectUri, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<RedirectUri, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<RedirectUri, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
