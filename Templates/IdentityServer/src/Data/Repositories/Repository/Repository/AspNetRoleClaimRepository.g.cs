
// <copyright file="AspNetRoleClaim.g.cs" company="MIT">
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
	/// The AspNetRoleClaimRepository class responsible for database functions in the AspNetRoleClaim table
	/// </summary>
	public partial class AspNetRoleClaimRepository : UowRepository<AspNetRoleClaim> , IAspNetRoleClaimRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetRoleClaimRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetRoleClaimRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetRoleClaimRepository
        /// </summary>
		public AspNetRoleClaimRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetRoleClaim entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>AspNetRoleClaim</returns>
		public virtual AspNetRoleClaim LoadById(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetRoleClaim>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load AspNetRoleClaim entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>AspNetRoleClaim</returns>
		public virtual async Task<AspNetRoleClaim> LoadByIdAsync(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetRoleClaim>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load AspNetRoleClaim entities from the database using the RoleId field
        /// </summary>
        /// <param name="roleId">Guid</param>
		/// <param name="includes">params Expression<Func<AspNetRoleClaim, object>>[]</param>
        /// <returns>IList<IAspNetRoleClaim></returns>
		public virtual IList<AspNetRoleClaim> LoadByRoleId(Guid roleId, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetRoleClaim>(o => o.RoleId == roleId, cache, expr).ToList<AspNetRoleClaim>();
		}
		
        /// <summary>
        /// Load AspNetRoleClaim entities async from the database using the RoleId field
        /// </summary>
        /// <param name="roleId">Guid</param>
		/// <param name="includes">params Expression<Func<AspNetRoleClaim, object>>[]</param>
        /// <returns>IList<IAspNetRoleClaim></returns>
		public virtual async Task<IList<AspNetRoleClaim>> LoadByRoleIdAsync(Guid roleId, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetRoleClaim>(o => o.RoleId == roleId,cache, expr);
			return result.ToList<AspNetRoleClaim>();
		}

        /// <summary>
        /// Load all AspNetRoleClaim entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		public virtual IList<AspNetRoleClaim> LoadAll(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetRoleClaim>(cache, expr).ToList<AspNetRoleClaim>();
		}
		
        /// <summary>
        /// Load all AspNetRoleClaim entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		public virtual async Task<IList<AspNetRoleClaim>> LoadAllAsync(bool cache, params Expression<Func<IAspNetRoleClaim,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetRoleClaim>(cache, expr);
			return result.ToList<AspNetRoleClaim>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		public virtual IList<AspNetRoleClaim> SearchByClaimType(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetRoleClaim>(o => o.ClaimType.Contains(claimType), cache, expr).ToList<AspNetRoleClaim>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetRoleClaim>(o => o.ClaimType.ToLower().Contains(claimType.ToLower()), cache, expr).ToList<AspNetRoleClaim>();
			}
		}
		
        /// <summary>
        /// Search for AspNetRoleClaim entities async in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		public virtual async Task<IList<AspNetRoleClaim>> SearchByClaimTypeAsync(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRoleClaim>(o => o.ClaimType.Contains(claimType), cache, expr);
				return result.ToList<AspNetRoleClaim>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRoleClaim>(o => o.ClaimType.ToLower().Contains(claimType.ToLower()), cache, expr);
				return result.ToList<AspNetRoleClaim>();
			}
		}

        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		public virtual IList<AspNetRoleClaim> SearchByClaimValue(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetRoleClaim>(o => o.ClaimValue.Contains(claimValue), cache, expr).ToList<AspNetRoleClaim>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetRoleClaim>(o => o.ClaimValue.ToLower().Contains(claimValue.ToLower()), cache, expr).ToList<AspNetRoleClaim>();
			}
		}
		
        /// <summary>
        /// Search for AspNetRoleClaim entities async in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		public virtual async Task<IList<AspNetRoleClaim>> SearchByClaimValueAsync(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRoleClaim>(o => o.ClaimValue.Contains(claimValue), cache, expr);
				return result.ToList<AspNetRoleClaim>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRoleClaim>(o => o.ClaimValue.ToLower().Contains(claimValue.ToLower()), cache, expr);
				return result.ToList<AspNetRoleClaim>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetRoleClaim entity to the database.
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetRoleClaim entity)
		{
			var entityToSave = new AspNetRoleClaim(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.RoleId = entityToSave.RoleId;
			entity.ClaimType = entityToSave.ClaimType;
			entity.ClaimValue = entityToSave.ClaimValue;
			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetRoleClaim entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetRoleClaim entity)
		{
            var entityToSave = new AspNetRoleClaim(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.RoleId = entityToSave.RoleId;
			entity.ClaimType = entityToSave.ClaimType;
			entity.ClaimValue = entityToSave.ClaimValue;
			
			return result;
		}

        /// <summary>
        /// Update the AspNetRoleClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetRoleClaim entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetRoleClaim>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetRoleClaim entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.RoleId != entity.RoleId) { entityToUpdate.RoleId = entity.RoleId;doUpdate = true; }
			if (entityToUpdate.ClaimType != entity.ClaimType) { entityToUpdate.ClaimType = entity.ClaimType;doUpdate = true; }
			if (entityToUpdate.ClaimValue != entity.ClaimValue) { entityToUpdate.ClaimValue = entity.ClaimValue;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the AspNetRoleClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetRoleClaim entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRoleClaim>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetRoleClaim entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.RoleId != entity.RoleId) { entityToUpdate.RoleId = entity.RoleId;doUpdate = true; }
			if (entityToUpdate.ClaimType != entity.ClaimType) { entityToUpdate.ClaimType = entity.ClaimType;doUpdate = true; }
			if (entityToUpdate.ClaimValue != entity.ClaimValue) { entityToUpdate.ClaimValue = entity.ClaimValue;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetRoleClaim entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetRoleClaim>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRoleClaim entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetRoleClaim entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRoleClaim>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRoleClaim entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetRoleClaim>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRoleClaim entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRoleClaim>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRoleClaim entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetRoleClaim, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetRoleClaim, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetRoleClaim, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetRoleClaim, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetRoleClaim> items)
		{
            List<AspNetRoleClaim> foundItems = new List<AspNetRoleClaim>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetRoleClaim>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetRoleClaim> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IAspNetRoleClaim>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetRoleClaim> items)
		{
            List<AspNetRoleClaim> foundItems = new List<AspNetRoleClaim>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRoleClaim>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetRoleClaim> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetRoleClaim>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetRoleClaim> items)
		{
			this.UnitOfWork.BulkInsert<AspNetRoleClaim>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetRoleClaim> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetRoleClaim>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetRoleClaim> items)
		{
            List<AspNetRoleClaim> foundItems = new List<AspNetRoleClaim>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetRoleClaim>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetRoleClaim entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.RoleId != entity.RoleId) { entityToUpdate.RoleId = entity.RoleId;doUpdate = true; }
			    if (entityToUpdate.ClaimType != entity.ClaimType) { entityToUpdate.ClaimType = entity.ClaimType;doUpdate = true; }
			    if (entityToUpdate.ClaimValue != entity.ClaimValue) { entityToUpdate.ClaimValue = entity.ClaimValue;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetRoleClaim>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetRoleClaim> items)
		{
            List<AspNetRoleClaim> foundItems = new List<AspNetRoleClaim>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRoleClaim>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetRoleClaim entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.RoleId != entity.RoleId) { entityToUpdate.RoleId = entity.RoleId;doUpdate = true; }
			    if (entityToUpdate.ClaimType != entity.ClaimType) { entityToUpdate.ClaimType = entity.ClaimType;doUpdate = true; }
			    if (entityToUpdate.ClaimValue != entity.ClaimValue) { entityToUpdate.ClaimValue = entity.ClaimValue;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetRoleClaim>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetRoleClaim, object>>[] Convert(params Expression<Func<IAspNetRoleClaim, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetRoleClaim, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetRoleClaim, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
