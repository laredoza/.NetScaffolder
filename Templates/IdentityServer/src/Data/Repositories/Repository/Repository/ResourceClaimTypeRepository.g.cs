
// <copyright file="ResourceClaimType.g.cs" company="MIT">
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
	/// The ResourceClaimTypeRepository class responsible for database functions in the ResourceClaimType table
	/// </summary>
	public partial class ResourceClaimTypeRepository : UowRepository<ResourceClaimType> , IResourceClaimTypeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ResourceClaimTypeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ResourceClaimTypeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for ResourceClaimTypeRepository
        /// </summary>
		public ResourceClaimTypeRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load ResourceClaimType entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>ResourceClaimType</returns>
		public virtual ResourceClaimType LoadById(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<ResourceClaimType>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load ResourceClaimType entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>ResourceClaimType</returns>
		public virtual async Task<ResourceClaimType> LoadByIdAsync(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<ResourceClaimType>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load all ResourceClaimType entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		public virtual IList<ResourceClaimType> LoadAll(bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<ResourceClaimType>(cache, expr).ToList<ResourceClaimType>();
		}
		
        /// <summary>
        /// Load all ResourceClaimType entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		public virtual async Task<IList<ResourceClaimType>> LoadAllAsync(bool cache, params Expression<Func<IResourceClaimType,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<ResourceClaimType>(cache, expr);
			return result.ToList<ResourceClaimType>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ResourceClaimType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		public virtual IList<ResourceClaimType> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IResourceClaimType, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ResourceClaimType>(o => o.Name.Contains(name), cache, expr).ToList<ResourceClaimType>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ResourceClaimType>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr).ToList<ResourceClaimType>();
			}
		}
		
        /// <summary>
        /// Search for ResourceClaimType entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		public virtual async Task<IList<ResourceClaimType>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IResourceClaimType, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ResourceClaimType>(o => o.Name.Contains(name), cache, expr);
				return result.ToList<ResourceClaimType>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ResourceClaimType>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr);
				return result.ToList<ResourceClaimType>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual bool Add(ResourceClaimType entity)
		{
			var entityToSave = new ResourceClaimType(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			
			return result;
		}
		
        /// <summary>
        /// Add the ResourceClaimType entity async to the database.
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ResourceClaimType entity)
		{
            var entityToSave = new ResourceClaimType(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			
			return result;
		}

        /// <summary>
        /// Update the ResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual bool Update(ResourceClaimType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ResourceClaimType>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ResourceClaimType entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the ResourceClaimType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ResourceClaimType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ResourceClaimType>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ResourceClaimType entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ResourceClaimType entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ResourceClaimType>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ResourceClaimType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ResourceClaimType entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ResourceClaimType>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ResourceClaimType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ResourceClaimType>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ResourceClaimType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ResourceClaimType>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ResourceClaimType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<ResourceClaimType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IResourceClaimType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IResourceClaimType, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<ResourceClaimType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<ResourceClaimType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<ResourceClaimType> items)
		{
            List<ResourceClaimType> foundItems = new List<ResourceClaimType>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<ResourceClaimType>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The ResourceClaimType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IResourceClaimType>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<ResourceClaimType> items)
		{
            List<ResourceClaimType> foundItems = new List<ResourceClaimType>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<ResourceClaimType>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The ResourceClaimType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<ResourceClaimType>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<ResourceClaimType> items)
		{
			this.UnitOfWork.BulkInsert<ResourceClaimType>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ResourceClaimType> items)
		{
			await this.UnitOfWork.BulkInsertAsync<ResourceClaimType>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<ResourceClaimType> items)
		{
            List<ResourceClaimType> foundItems = new List<ResourceClaimType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<ResourceClaimType>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ResourceClaimType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<ResourceClaimType>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<ResourceClaimType> items)
		{
            List<ResourceClaimType> foundItems = new List<ResourceClaimType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ResourceClaimType>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ResourceClaimType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<ResourceClaimType>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<ResourceClaimType, object>>[] Convert(params Expression<Func<IResourceClaimType, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<ResourceClaimType, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<ResourceClaimType, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
