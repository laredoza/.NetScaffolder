
// <copyright file="IdentityResourceClaimType.g.cs" company="MIT">
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
	/// The IdentityResourceClaimTypeRepository class responsible for database functions in the IdentityResourceClaimType table
	/// </summary>
	public partial class IdentityResourceClaimTypeRepository : UowRepository<IdentityResourceClaimType> , IIdentityResourceClaimTypeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for IdentityResourceClaimTypeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public IdentityResourceClaimTypeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for IdentityResourceClaimTypeRepository
        /// </summary>
		public IdentityResourceClaimTypeRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load IdentityResourceClaimType entities from the database using the composite primary keys
        /// </summary
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
		/// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IdentityResourceClaimType</returns>
		public virtual IdentityResourceClaimType Load( int identityResourceId,  int resourceClaimTypeId, bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<IdentityResourceClaimType>(o =>  o.IdentityResourceId == identityResourceId &&  o.ResourceClaimTypeId == resourceClaimTypeId , cache, expr);
		}
		
        /// <summary>
        /// Load IdentityResourceClaimType entities async from the database using the composite primary keys
        /// </summary
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
		/// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IdentityResourceClaimType</returns>
		public virtual async Task<IdentityResourceClaimType> LoadAsync( int identityResourceId,  int resourceClaimTypeId, bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<IdentityResourceClaimType>(cache, o =>  o.IdentityResourceId == identityResourceId &&  o.ResourceClaimTypeId == resourceClaimTypeId , expr);
		}

        /// <summary>
        /// Load all IdentityResourceClaimType entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IList<IdentityResourceClaimType></returns>
		public virtual IList<IdentityResourceClaimType> LoadAll(bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<IdentityResourceClaimType>(cache, expr).ToList<IdentityResourceClaimType>();
		}
		
        /// <summary>
        /// Load all IdentityResourceClaimType entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IList<IdentityResourceClaimType></returns>
		public virtual async Task<IList<IdentityResourceClaimType>> LoadAllAsync(bool cache, params Expression<Func<IIdentityResourceClaimType,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<IdentityResourceClaimType>(cache, expr);
			return result.ToList<IdentityResourceClaimType>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the IdentityResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">IdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual bool Add(IdentityResourceClaimType entity)
		{
			var entityToSave = new IdentityResourceClaimType(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.IdentityResourceId = entityToSave.IdentityResourceId;
			entity.ResourceClaimTypeId = entityToSave.ResourceClaimTypeId;
			
			return result;
		}
		
        /// <summary>
        /// Add the IdentityResourceClaimType entity async to the database.
        /// </summary>
        /// <param name="entity">IdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IdentityResourceClaimType entity)
		{
            var entityToSave = new IdentityResourceClaimType(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.IdentityResourceId = entityToSave.IdentityResourceId;
			entity.ResourceClaimTypeId = entityToSave.ResourceClaimTypeId;
			
			return result;
		}

        /// <summary>
        /// Update the IdentityResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual bool Update(IdentityResourceClaimType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<IdentityResourceClaimType>(o =>  o.IdentityResourceId == entity.IdentityResourceId &&  o.ResourceClaimTypeId == entity.ResourceClaimTypeId , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The IdentityResourceClaimType entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the IdentityResourceClaimType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IdentityResourceClaimType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResourceClaimType>(true, o =>  o.IdentityResourceId == entity.IdentityResourceId &&  o.ResourceClaimTypeId == entity.ResourceClaimTypeId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The IdentityResourceClaimType entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">IdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IdentityResourceClaimType entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<IdentityResourceClaimType>(o =>  o.IdentityResourceId == entity.IdentityResourceId &&  o.ResourceClaimTypeId == entity.ResourceClaimTypeId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResourceClaimType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the IdentityResourceClaimType entity async from the database
        /// </summary>
        /// <param name="entity">IdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IdentityResourceClaimType entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResourceClaimType>(true, o =>  o.IdentityResourceId == entity.IdentityResourceId &&  o.ResourceClaimTypeId == entity.ResourceClaimTypeId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResourceClaimType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int identityResourceId,  int resourceClaimTypeId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<IdentityResourceClaimType>(o =>  o.IdentityResourceId == identityResourceId &&  o.ResourceClaimTypeId == resourceClaimTypeId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResourceClaimType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the IdentityResourceClaimType entity async from the database
        /// </summary>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int identityResourceId,  int resourceClaimTypeId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResourceClaimType>(cache, o =>  o.IdentityResourceId == identityResourceId &&  o.ResourceClaimTypeId == resourceClaimTypeId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResourceClaimType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<IdentityResourceClaimType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IIdentityResourceClaimType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<IdentityResourceClaimType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<IdentityResourceClaimType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IdentityResourceClaimType> items)
		{
            List<IdentityResourceClaimType> foundItems = new List<IdentityResourceClaimType>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<IdentityResourceClaimType>(o => o.IdentityResourceId == item.IdentityResourceId &&  o.ResourceClaimTypeId == item.ResourceClaimTypeId , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The IdentityResourceClaimType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IIdentityResourceClaimType>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IdentityResourceClaimType> items)
		{
            List<IdentityResourceClaimType> foundItems = new List<IdentityResourceClaimType>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResourceClaimType>(true, o => o.IdentityResourceId == item.IdentityResourceId &&  o.ResourceClaimTypeId == item.ResourceClaimTypeId );

		        if (foundEntity == null)
		        {
		            throw new Exception("The IdentityResourceClaimType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<IdentityResourceClaimType>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IdentityResourceClaimType> items)
		{
			this.UnitOfWork.BulkInsert<IdentityResourceClaimType>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IdentityResourceClaimType> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IdentityResourceClaimType>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IdentityResourceClaimType> items)
		{
            List<IdentityResourceClaimType> foundItems = new List<IdentityResourceClaimType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<IdentityResourceClaimType>(o =>  o.IdentityResourceId == entity.IdentityResourceId &&  o.ResourceClaimTypeId == entity.ResourceClaimTypeId , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The IdentityResourceClaimType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<IdentityResourceClaimType>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IdentityResourceClaimType> items)
		{
            List<IdentityResourceClaimType> foundItems = new List<IdentityResourceClaimType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResourceClaimType>(true, o =>  o.IdentityResourceId == entity.IdentityResourceId &&  o.ResourceClaimTypeId == entity.ResourceClaimTypeId );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The IdentityResourceClaimType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<IdentityResourceClaimType>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<IdentityResourceClaimType, object>>[] Convert(params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<IdentityResourceClaimType, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<IdentityResourceClaimType, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
