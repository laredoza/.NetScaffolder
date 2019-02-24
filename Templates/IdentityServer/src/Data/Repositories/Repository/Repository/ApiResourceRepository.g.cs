
// <copyright file="ApiResource.g.cs" company="MIT">
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
	/// The ApiResourceRepository class responsible for database functions in the ApiResource table
	/// </summary>
	public partial class ApiResourceRepository : UowRepository<ApiResource> , IApiResourceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ApiResourceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ApiResourceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for ApiResourceRepository
        /// </summary>
		public ApiResourceRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load ApiResource entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>ApiResource</returns>
		public virtual ApiResource LoadById(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<ApiResource>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load ApiResource entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>ApiResource</returns>
		public virtual async Task<ApiResource> LoadByIdAsync(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<ApiResource>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load all ApiResource entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		public virtual IList<ApiResource> LoadAll(bool cache, params Expression<Func<IApiResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<ApiResource>(cache, expr).ToList<ApiResource>();
		}
		
        /// <summary>
        /// Load all ApiResource entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		public virtual async Task<IList<ApiResource>> LoadAllAsync(bool cache, params Expression<Func<IApiResource,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<ApiResource>(cache, expr);
			return result.ToList<ApiResource>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ApiResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		public virtual IList<ApiResource> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ApiResource>(o => o.Name.Contains(name), cache, expr).ToList<ApiResource>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ApiResource>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr).ToList<ApiResource>();
			}
		}
		
        /// <summary>
        /// Search for ApiResource entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		public virtual async Task<IList<ApiResource>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ApiResource>(o => o.Name.Contains(name), cache, expr);
				return result.ToList<ApiResource>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ApiResource>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr);
				return result.ToList<ApiResource>();
			}
		}

        /// <summary>
        /// Search for ApiResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		public virtual IList<ApiResource> SearchByDisplayName(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ApiResource>(o => o.DisplayName.Contains(displayName), cache, expr).ToList<ApiResource>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ApiResource>(o => o.DisplayName.ToLower().Contains(displayName.ToLower()), cache, expr).ToList<ApiResource>();
			}
		}
		
        /// <summary>
        /// Search for ApiResource entities async in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		public virtual async Task<IList<ApiResource>> SearchByDisplayNameAsync(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ApiResource>(o => o.DisplayName.Contains(displayName), cache, expr);
				return result.ToList<ApiResource>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ApiResource>(o => o.DisplayName.ToLower().Contains(displayName.ToLower()), cache, expr);
				return result.ToList<ApiResource>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ApiResource entity to the database.
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		public virtual bool Add(ApiResource entity)
		{
			this.UnitOfWork.Add(entity);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.Name = entityToSave.Name;
//			//entity.DisplayName = entityToSave.DisplayName;
//			
			return result;
		}
		
        /// <summary>
        /// Add the ApiResource entity async to the database.
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ApiResource entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.Name = entityToSave.Name;
//			//entity.DisplayName = entityToSave.DisplayName;
//			
			return result;
		}

        /// <summary>
        /// Update the ApiResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		public virtual bool Update(ApiResource entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ApiResource>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ApiResource entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the ApiResource entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ApiResource entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ApiResource>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ApiResource entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ApiResource entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ApiResource>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApiResource entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ApiResource entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ApiResource>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApiResource entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ApiResource>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApiResource entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ApiResource>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApiResource entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<ApiResource, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IApiResource, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IApiResource, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<ApiResource, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IApiResource, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<ApiResource, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<ApiResource> items)
		{
            List<ApiResource> foundItems = new List<ApiResource>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<ApiResource>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The ApiResource> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<ApiResource>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<ApiResource> items)
		{
            List<ApiResource> foundItems = new List<ApiResource>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<ApiResource>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The ApiResource> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<ApiResource>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<ApiResource> items)
		{
			this.UnitOfWork.BulkInsert<ApiResource>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ApiResource> items)
		{
			await this.UnitOfWork.BulkInsertAsync<ApiResource>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<ApiResource> items)
		{
            List<ApiResource> foundItems = new List<ApiResource>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<ApiResource>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ApiResource entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			    if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<ApiResource>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<ApiResource> items)
		{
            List<ApiResource> foundItems = new List<ApiResource>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ApiResource>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ApiResource entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			    if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<ApiResource>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<ApiResource, object>>[] Convert(params Expression<Func<IApiResource, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<ApiResource, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<ApiResource, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
