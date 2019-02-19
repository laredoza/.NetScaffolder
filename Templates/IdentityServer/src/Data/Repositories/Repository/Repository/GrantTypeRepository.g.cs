
// <copyright file="GrantType.g.cs" company="MIT">
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
	/// The GrantTypeRepository class responsible for database functions in the GrantType table
	/// </summary>
	public partial class GrantTypeRepository : UowRepository<GrantType> , IGrantTypeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for GrantTypeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public GrantTypeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for GrantTypeRepository
        /// </summary>
		public GrantTypeRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load GrantType entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>GrantType</returns>
		public virtual GrantType LoadById(int id, bool cache, params Expression<Func<IGrantType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<GrantType>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load GrantType entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>GrantType</returns>
		public virtual async Task<GrantType> LoadByIdAsync(int id, bool cache, params Expression<Func<IGrantType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<GrantType>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load all GrantType entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantType></returns>
		public virtual IList<GrantType> LoadAll(bool cache, params Expression<Func<IGrantType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<GrantType>(cache, expr).ToList<GrantType>();
		}
		
        /// <summary>
        /// Load all GrantType entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantType></returns>
		public virtual async Task<IList<GrantType>> LoadAllAsync(bool cache, params Expression<Func<IGrantType,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<GrantType>(cache, expr);
			return result.ToList<GrantType>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for GrantType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantType></returns>
		public virtual IList<GrantType> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IGrantType, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<GrantType>(o => o.Name.Contains(name), cache, expr).ToList<GrantType>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<GrantType>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr).ToList<GrantType>();
			}
		}
		
        /// <summary>
        /// Search for GrantType entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantType></returns>
		public virtual async Task<IList<GrantType>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IGrantType, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<GrantType>(o => o.Name.Contains(name), cache, expr);
				return result.ToList<GrantType>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<GrantType>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr);
				return result.ToList<GrantType>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the GrantType entity to the database.
        /// </summary>
        /// <param name="entity">GrantType</param>
        /// <returns>bool</returns>
		public virtual bool Add(GrantType entity)
		{
			var entityToSave = new GrantType(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			
			return result;
		}
		
        /// <summary>
        /// Add the GrantType entity async to the database.
        /// </summary>
        /// <param name="entity">GrantType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(GrantType entity)
		{
            var entityToSave = new GrantType(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			
			return result;
		}

        /// <summary>
        /// Update the GrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">GrantType</param>
        /// <returns>bool</returns>
		public virtual bool Update(GrantType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<GrantType>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The GrantType entity does not exist");
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
        /// Update the GrantType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">GrantType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(GrantType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<GrantType>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The GrantType entity does not exist");
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
        /// Delete the GrantType entity from the database
        /// </summary>
        /// <param name="entity">GrantType</param>
        /// <returns>bool</returns>
		public virtual bool Delete(GrantType entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<GrantType>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The GrantType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the GrantType entity async from the database
        /// </summary>
        /// <param name="entity">GrantType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(GrantType entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<GrantType>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The GrantType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the GrantType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<GrantType>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The GrantType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the GrantType entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<GrantType>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The GrantType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<GrantType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IGrantType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IGrantType, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<GrantType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IGrantType, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<GrantType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<GrantType> items)
		{
            List<GrantType> foundItems = new List<GrantType>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<GrantType>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The GrantType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IGrantType>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<GrantType> items)
		{
            List<GrantType> foundItems = new List<GrantType>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<GrantType>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The GrantType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<GrantType>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<GrantType> items)
		{
			this.UnitOfWork.BulkInsert<GrantType>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<GrantType> items)
		{
			await this.UnitOfWork.BulkInsertAsync<GrantType>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<GrantType> items)
		{
            List<GrantType> foundItems = new List<GrantType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<GrantType>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The GrantType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<GrantType>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<GrantType> items)
		{
            List<GrantType> foundItems = new List<GrantType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<GrantType>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The GrantType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<GrantType>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<GrantType, object>>[] Convert(params Expression<Func<IGrantType, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<GrantType, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<GrantType, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
