
// <copyright file="AspNetUserClaim.g.cs" company="MIT">
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
	/// The AspNetUserClaimRepository class responsible for database functions in the AspNetUserClaim table
	/// </summary>
	public partial class AspNetUserClaimRepository : UowRepository<AspNetUserClaim> , IAspNetUserClaimRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetUserClaimRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetUserClaimRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetUserClaimRepository
        /// </summary>
		public AspNetUserClaimRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetUserClaim entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>AspNetUserClaim</returns>
		public virtual AspNetUserClaim LoadById(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetUserClaim>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load AspNetUserClaim entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>AspNetUserClaim</returns>
		public virtual async Task<AspNetUserClaim> LoadByIdAsync(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserClaim>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load AspNetUserClaim entities from the database using the UserId field
        /// </summary>
        /// <param name="userId">Guid</param>
		/// <param name="includes">params Expression<Func<AspNetUserClaim, object>>[]</param>
        /// <returns>IList<IAspNetUserClaim></returns>
		public virtual IList<AspNetUserClaim> LoadByUserId(Guid userId, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUserClaim>(o => o.UserId == userId, cache, expr).ToList<AspNetUserClaim>();
		}
		
        /// <summary>
        /// Load AspNetUserClaim entities async from the database using the UserId field
        /// </summary>
        /// <param name="userId">Guid</param>
		/// <param name="includes">params Expression<Func<AspNetUserClaim, object>>[]</param>
        /// <returns>IList<IAspNetUserClaim></returns>
		public virtual async Task<IList<AspNetUserClaim>> LoadByUserIdAsync(Guid userId, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserClaim>(o => o.UserId == userId,cache, expr);
			return result.ToList<AspNetUserClaim>();
		}

        /// <summary>
        /// Load all AspNetUserClaim entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		public virtual IList<AspNetUserClaim> LoadAll(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetUserClaim>(cache, expr).ToList<AspNetUserClaim>();
		}
		
        /// <summary>
        /// Load all AspNetUserClaim entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		public virtual async Task<IList<AspNetUserClaim>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUserClaim,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetUserClaim>(cache, expr);
			return result.ToList<AspNetUserClaim>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		public virtual IList<AspNetUserClaim> SearchByClaimType(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUserClaim>(o => o.ClaimType.Contains(claimType), cache, expr).ToList<AspNetUserClaim>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUserClaim>(o => o.ClaimType.ToLower().Contains(claimType.ToLower()), cache, expr).ToList<AspNetUserClaim>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUserClaim entities async in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		public virtual async Task<IList<AspNetUserClaim>> SearchByClaimTypeAsync(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserClaim>(o => o.ClaimType.Contains(claimType), cache, expr);
				return result.ToList<AspNetUserClaim>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserClaim>(o => o.ClaimType.ToLower().Contains(claimType.ToLower()), cache, expr);
				return result.ToList<AspNetUserClaim>();
			}
		}

        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		public virtual IList<AspNetUserClaim> SearchByClaimValue(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUserClaim>(o => o.ClaimValue.Contains(claimValue), cache, expr).ToList<AspNetUserClaim>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUserClaim>(o => o.ClaimValue.ToLower().Contains(claimValue.ToLower()), cache, expr).ToList<AspNetUserClaim>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUserClaim entities async in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		public virtual async Task<IList<AspNetUserClaim>> SearchByClaimValueAsync(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserClaim>(o => o.ClaimValue.Contains(claimValue), cache, expr);
				return result.ToList<AspNetUserClaim>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUserClaim>(o => o.ClaimValue.ToLower().Contains(claimValue.ToLower()), cache, expr);
				return result.ToList<AspNetUserClaim>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUserClaim entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetUserClaim entity)
		{
			var entityToSave = new AspNetUserClaim(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.UserId = entityToSave.UserId;
			entity.ClaimType = entityToSave.ClaimType;
			entity.ClaimValue = entityToSave.ClaimValue;
			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetUserClaim entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetUserClaim entity)
		{
            var entityToSave = new AspNetUserClaim(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.UserId = entityToSave.UserId;
			entity.ClaimType = entityToSave.ClaimType;
			entity.ClaimValue = entityToSave.ClaimValue;
			
			return result;
		}

        /// <summary>
        /// Update the AspNetUserClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetUserClaim entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserClaim>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserClaim entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
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
        /// Update the AspNetUserClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetUserClaim entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserClaim>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUserClaim entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
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
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetUserClaim entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserClaim>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserClaim entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetUserClaim entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserClaim>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserClaim entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUserClaim>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserClaim entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserClaim>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUserClaim entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetUserClaim, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetUserClaim, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetUserClaim, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetUserClaim, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetUserClaim, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetUserClaim> items)
		{
            List<AspNetUserClaim> foundItems = new List<AspNetUserClaim>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetUserClaim>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserClaim> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IAspNetUserClaim>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetUserClaim> items)
		{
            List<AspNetUserClaim> foundItems = new List<AspNetUserClaim>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserClaim>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUserClaim> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetUserClaim>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetUserClaim> items)
		{
			this.UnitOfWork.BulkInsert<AspNetUserClaim>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetUserClaim> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetUserClaim>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetUserClaim> items)
		{
            List<AspNetUserClaim> foundItems = new List<AspNetUserClaim>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUserClaim>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserClaim entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			    if (entityToUpdate.ClaimType != entity.ClaimType) { entityToUpdate.ClaimType = entity.ClaimType;doUpdate = true; }
			    if (entityToUpdate.ClaimValue != entity.ClaimValue) { entityToUpdate.ClaimValue = entity.ClaimValue;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetUserClaim>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetUserClaim> items)
		{
            List<AspNetUserClaim> foundItems = new List<AspNetUserClaim>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUserClaim>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUserClaim entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			    if (entityToUpdate.ClaimType != entity.ClaimType) { entityToUpdate.ClaimType = entity.ClaimType;doUpdate = true; }
			    if (entityToUpdate.ClaimValue != entity.ClaimValue) { entityToUpdate.ClaimValue = entity.ClaimValue;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetUserClaim>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetUserClaim, object>>[] Convert(params Expression<Func<IAspNetUserClaim, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetUserClaim, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetUserClaim, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
