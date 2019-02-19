
// <copyright file="AspNetRole.g.cs" company="MIT">
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
	/// The AspNetRoleRepository class responsible for database functions in the AspNetRole table
	/// </summary>
	public partial class AspNetRoleRepository : UowRepository<AspNetRole> , IAspNetRoleRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetRoleRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetRoleRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetRoleRepository
        /// </summary>
		public AspNetRoleRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetRole entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">string</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>AspNetRole</returns>
		public virtual AspNetRole LoadById(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetRole>(o => o.Id.ToLower().Contains(id.ToLower()), cache, expr);
		}
		
        /// <summary>
        /// Load AspNetRole entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">string</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>AspNetRole</returns>
		public virtual async Task<AspNetRole> LoadByIdAsync(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetRole>(cache, o => o.Id.ToLower().Contains(id.ToLower()), expr);
		}

        /// <summary>
        /// Load all AspNetRole entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual IList<AspNetRole> LoadAll(bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetRole>(cache, expr).ToList<AspNetRole>();
		}
		
        /// <summary>
        /// Load all AspNetRole entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual async Task<IList<AspNetRole>> LoadAllAsync(bool cache, params Expression<Func<IAspNetRole,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetRole>(cache, expr);
			return result.ToList<AspNetRole>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetRole entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual IList<AspNetRole> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetRole>(o => o.Name.Contains(name), cache, expr).ToList<AspNetRole>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetRole>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr).ToList<AspNetRole>();
			}
		}
		
        /// <summary>
        /// Search for AspNetRole entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual async Task<IList<AspNetRole>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRole>(o => o.Name.Contains(name), cache, expr);
				return result.ToList<AspNetRole>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRole>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr);
				return result.ToList<AspNetRole>();
			}
		}

        /// <summary>
        /// Search for AspNetRole entities in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual IList<AspNetRole> SearchByNormalizedName(string normalizedName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetRole>(o => o.NormalizedName.Contains(normalizedName), cache, expr).ToList<AspNetRole>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetRole>(o => o.NormalizedName.ToLower().Contains(normalizedName.ToLower()), cache, expr).ToList<AspNetRole>();
			}
		}
		
        /// <summary>
        /// Search for AspNetRole entities async in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual async Task<IList<AspNetRole>> SearchByNormalizedNameAsync(string normalizedName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRole>(o => o.NormalizedName.Contains(normalizedName), cache, expr);
				return result.ToList<AspNetRole>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRole>(o => o.NormalizedName.ToLower().Contains(normalizedName.ToLower()), cache, expr);
				return result.ToList<AspNetRole>();
			}
		}

        /// <summary>
        /// Search for AspNetRole entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual IList<AspNetRole> SearchByConcurrencyStamp(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetRole>(o => o.ConcurrencyStamp.Contains(concurrencyStamp), cache, expr).ToList<AspNetRole>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetRole>(o => o.ConcurrencyStamp.ToLower().Contains(concurrencyStamp.ToLower()), cache, expr).ToList<AspNetRole>();
			}
		}
		
        /// <summary>
        /// Search for AspNetRole entities async in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		public virtual async Task<IList<AspNetRole>> SearchByConcurrencyStampAsync(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRole>(o => o.ConcurrencyStamp.Contains(concurrencyStamp), cache, expr);
				return result.ToList<AspNetRole>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetRole>(o => o.ConcurrencyStamp.ToLower().Contains(concurrencyStamp.ToLower()), cache, expr);
				return result.ToList<AspNetRole>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetRole entity to the database.
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetRole entity)
		{
			var entityToSave = new AspNetRole(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			entity.NormalizedName = entityToSave.NormalizedName;
			entity.ConcurrencyStamp = entityToSave.ConcurrencyStamp;
			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetRole entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetRole entity)
		{
            var entityToSave = new AspNetRole(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			entity.NormalizedName = entityToSave.NormalizedName;
			entity.ConcurrencyStamp = entityToSave.ConcurrencyStamp;
			
			return result;
		}

        /// <summary>
        /// Update the AspNetRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetRole entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetRole>(o =>  o.Id.ToLower().Contains(entity.Id.ToLower()) , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetRole entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.NormalizedName != entity.NormalizedName) { entityToUpdate.NormalizedName = entity.NormalizedName;doUpdate = true; }
			if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the AspNetRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetRole entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRole>(true, o =>  o.Id.ToLower().Contains(entity.Id.ToLower()) );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetRole entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.NormalizedName != entity.NormalizedName) { entityToUpdate.NormalizedName = entity.NormalizedName;doUpdate = true; }
			if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetRole entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetRole>(o =>  o.Id.ToLower().Contains(entity.Id.ToLower()) , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRole entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetRole entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRole>(true, o =>  o.Id.ToLower().Contains(entity.Id.ToLower()) );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRole entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		public virtual bool Delete( string id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetRole>(o =>  o.Id.ToLower().Contains(id.ToLower()) , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRole entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( string id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRole>(cache, o =>  o.Id.ToLower().Contains(id.ToLower())  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetRole entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetRole, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetRole, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetRole, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetRole, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetRole, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetRole, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetRole> items)
		{
            List<AspNetRole> foundItems = new List<AspNetRole>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetRole>(o => o.Id.ToLower().Contains(item.Id.ToLower()) , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetRole> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IAspNetRole>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetRole> items)
		{
            List<AspNetRole> foundItems = new List<AspNetRole>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRole>(true, o => o.Id.ToLower().Contains(item.Id.ToLower()) );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetRole> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetRole>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetRole> items)
		{
			this.UnitOfWork.BulkInsert<AspNetRole>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetRole> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetRole>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetRole> items)
		{
            List<AspNetRole> foundItems = new List<AspNetRole>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetRole>(o =>  o.Id.ToLower().Contains(entity.Id.ToLower()) , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetRole entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			    if (entityToUpdate.NormalizedName != entity.NormalizedName) { entityToUpdate.NormalizedName = entity.NormalizedName;doUpdate = true; }
			    if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetRole>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetRole> items)
		{
            List<AspNetRole> foundItems = new List<AspNetRole>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetRole>(true, o =>  o.Id.ToLower().Contains(entity.Id.ToLower()) );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetRole entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			    if (entityToUpdate.NormalizedName != entity.NormalizedName) { entityToUpdate.NormalizedName = entity.NormalizedName;doUpdate = true; }
			    if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetRole>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetRole, object>>[] Convert(params Expression<Func<IAspNetRole, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetRole, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetRole, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
