
// <copyright file="AllowedScope.g.cs" company="MIT">
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
	/// The AllowedScopeRepository class responsible for database functions in the AllowedScope table
	/// </summary>
	public partial class AllowedScopeRepository : UowRepository<AllowedScope> , IAllowedScopeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AllowedScopeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AllowedScopeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AllowedScopeRepository
        /// </summary>
		public AllowedScopeRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AllowedScope entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>AllowedScope</returns>
		public virtual AllowedScope LoadById(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AllowedScope>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load AllowedScope entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>AllowedScope</returns>
		public virtual async Task<AllowedScope> LoadByIdAsync(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AllowedScope>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load AllowedScope entities from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param>
		/// <param name="includes">params Expression<Func<AllowedScope, object>>[]</param>
        /// <returns>IList<IAllowedScope></returns>
		public virtual IList<AllowedScope> LoadByClientId(int clientId, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AllowedScope>(o => o.ClientId == clientId, cache, expr).ToList<AllowedScope>();
		}
		
        /// <summary>
        /// Load AllowedScope entities async from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param>
		/// <param name="includes">params Expression<Func<AllowedScope, object>>[]</param>
        /// <returns>IList<IAllowedScope></returns>
		public virtual async Task<IList<AllowedScope>> LoadByClientIdAsync(int clientId, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AllowedScope>(o => o.ClientId == clientId,cache, expr);
			return result.ToList<AllowedScope>();
		}

        /// <summary>
        /// Load all AllowedScope entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		public virtual IList<AllowedScope> LoadAll(bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AllowedScope>(cache, expr).ToList<AllowedScope>();
		}
		
        /// <summary>
        /// Load all AllowedScope entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		public virtual async Task<IList<AllowedScope>> LoadAllAsync(bool cache, params Expression<Func<IAllowedScope,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AllowedScope>(cache, expr);
			return result.ToList<AllowedScope>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AllowedScope entities in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		public virtual IList<AllowedScope> SearchByResourceName(string resourceName, bool cache, bool caseSensitive = false, params Expression<Func<IAllowedScope, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AllowedScope>(o => o.ResourceName.Contains(resourceName), cache, expr).ToList<AllowedScope>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AllowedScope>(o => o.ResourceName.ToLower().Contains(resourceName.ToLower()), cache, expr).ToList<AllowedScope>();
			}
		}
		
        /// <summary>
        /// Search for AllowedScope entities async in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		public virtual async Task<IList<AllowedScope>> SearchByResourceNameAsync(string resourceName, bool cache, bool caseSensitive = false, params Expression<Func<IAllowedScope, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AllowedScope>(o => o.ResourceName.Contains(resourceName), cache, expr);
				return result.ToList<AllowedScope>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AllowedScope>(o => o.ResourceName.ToLower().Contains(resourceName.ToLower()), cache, expr);
				return result.ToList<AllowedScope>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AllowedScope entity to the database.
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		public virtual bool Add(AllowedScope entity)
		{
			this.UnitOfWork.Add(entity);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.ResourceName = entityToSave.ResourceName;
//			
			return result;
		}
		
        /// <summary>
        /// Add the AllowedScope entity async to the database.
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AllowedScope entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.ResourceName = entityToSave.ResourceName;
//			
			return result;
		}

        /// <summary>
        /// Update the AllowedScope entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		public virtual bool Update(AllowedScope entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AllowedScope>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AllowedScope entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.ResourceName != entity.ResourceName) { entityToUpdate.ResourceName = entity.ResourceName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the AllowedScope entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AllowedScope entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AllowedScope>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AllowedScope entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.ResourceName != entity.ResourceName) { entityToUpdate.ResourceName = entity.ResourceName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AllowedScope entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AllowedScope>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AllowedScope entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AllowedScope entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AllowedScope>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AllowedScope entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AllowedScope>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AllowedScope entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AllowedScope>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AllowedScope entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AllowedScope, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAllowedScope, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAllowedScope, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AllowedScope, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAllowedScope, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AllowedScope, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AllowedScope> items)
		{
            List<AllowedScope> foundItems = new List<AllowedScope>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AllowedScope>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AllowedScope> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<AllowedScope>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AllowedScope> items)
		{
            List<AllowedScope> foundItems = new List<AllowedScope>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AllowedScope>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AllowedScope> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AllowedScope>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AllowedScope> items)
		{
			this.UnitOfWork.BulkInsert<AllowedScope>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AllowedScope> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AllowedScope>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AllowedScope> items)
		{
            List<AllowedScope> foundItems = new List<AllowedScope>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AllowedScope>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AllowedScope entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.ResourceName != entity.ResourceName) { entityToUpdate.ResourceName = entity.ResourceName;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AllowedScope>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AllowedScope> items)
		{
            List<AllowedScope> foundItems = new List<AllowedScope>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AllowedScope>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AllowedScope entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.ResourceName != entity.ResourceName) { entityToUpdate.ResourceName = entity.ResourceName;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AllowedScope>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AllowedScope, object>>[] Convert(params Expression<Func<IAllowedScope, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AllowedScope, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AllowedScope, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
