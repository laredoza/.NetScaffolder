
// <copyright file="AspNetUserRole.g.cs" company="MIT">
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
	/// The AspNetUserRoleRepository class responsible for database functions in the AspNetUserRole table
	/// </summary>
	public partial class AspNetUserRoleRepository : UowRepository<AspNetUserRole> , IAspNetUserRoleRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetUserRoleRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetUserRoleRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetUserRoleRepository
        /// </summary>
		public AspNetUserRoleRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetUserRole entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
		/// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>AspNetUserRole</returns>
		public virtual AspNetUserRole Load( Guid userId,  Guid roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetUserRole>(o =>  o.UserId == userId &&  o.RoleId == roleId , cache, expr);
		}
		
        /// <summary>
        /// Load AspNetUserRole entities async from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
		/// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>AspNetUserRole</returns>
		public virtual async Task<AspNetUserRole> LoadAsync( Guid userId,  Guid roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserRole>(cache, o =>  o.UserId == userId &&  o.RoleId == roleId , expr);
		}

        /// <summary>
        /// Load all AspNetUserRole entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRole></returns>
		public virtual IList<AspNetUserRole> LoadAll(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetUserRole>(cache, expr).ToList<AspNetUserRole>();
		}
		
        /// <summary>
        /// Load all AspNetUserRole entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRole></returns>
		public virtual async Task<IList<AspNetUserRole>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUserRole,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetUserRole>(cache, expr);
			return result.ToList<AspNetUserRole>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUserRole entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserRole</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetUserRole entity)
		{
			var entityToSave = new AspNetUserRole(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.UserId = entityToSave.UserId;
			entity.RoleId = entityToSave.RoleId;
			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetUserRole entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetUserRole</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetUserRole entity)
		{
            var entityToSave = new AspNetUserRole(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.UserId = entityToSave.UserId;
			entity.RoleId = entityToSave.RoleId;
			
			return result;
		}

        /// <summary>
        /// Update the AspNetUserRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserRole</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetUserRole entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserRole>(o =>  o.UserId == entity.UserId &&  o.RoleId == entity.RoleId , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserRole entity does not exist");
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
        /// Update the AspNetUserRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserRole</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetUserRole entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserRole>(true, o =>  o.UserId == entity.UserId &&  o.RoleId == entity.RoleId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserRole entity does not exist");
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
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserRole</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetUserRole entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserRole>(o =>  o.UserId == entity.UserId &&  o.RoleId == entity.RoleId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserRole entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUserRole</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetUserRole entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserRole>(true, o =>  o.UserId == entity.UserId &&  o.RoleId == entity.RoleId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserRole entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
        /// <returns>bool</returns>
		public virtual bool Delete( Guid userId,  Guid roleId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserRole>(o =>  o.UserId == userId &&  o.RoleId == roleId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserRole entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( Guid userId,  Guid roleId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserRole>(cache, o =>  o.UserId == userId &&  o.RoleId == roleId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserRole entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetUserRole, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetUserRole, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetUserRole, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetUserRole, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUserRole, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetUserRole, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetUserRole> items)
		{
            List<AspNetUserRole> foundItems = new List<AspNetUserRole>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetUserRole>(o => o.UserId == item.UserId &&  o.RoleId == item.RoleId , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserRole> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IAspNetUserRole>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetUserRole> items)
		{
            List<AspNetUserRole> foundItems = new List<AspNetUserRole>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserRole>(true, o => o.UserId == item.UserId &&  o.RoleId == item.RoleId );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserRole> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetUserRole>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetUserRole> items)
		{
			this.UnitOfWork.BulkInsert<AspNetUserRole>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetUserRole> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetUserRole>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetUserRole> items)
		{
            List<AspNetUserRole> foundItems = new List<AspNetUserRole>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserRole>(o =>  o.UserId == entity.UserId &&  o.RoleId == entity.RoleId , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserRole entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetUserRole>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetUserRole> items)
		{
            List<AspNetUserRole> foundItems = new List<AspNetUserRole>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserRole>(true, o =>  o.UserId == entity.UserId &&  o.RoleId == entity.RoleId );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserRole entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetUserRole>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetUserRole, object>>[] Convert(params Expression<Func<IAspNetUserRole, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetUserRole, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetUserRole, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
