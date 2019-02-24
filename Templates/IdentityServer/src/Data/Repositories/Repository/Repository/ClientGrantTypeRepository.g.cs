
// <copyright file="ClientGrantType.g.cs" company="MIT">
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
	/// The ClientGrantTypeRepository class responsible for database functions in the ClientGrantType table
	/// </summary>
	public partial class ClientGrantTypeRepository : UowRepository<ClientGrantType> , IClientGrantTypeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ClientGrantTypeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ClientGrantTypeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for ClientGrantTypeRepository
        /// </summary>
		public ClientGrantTypeRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load ClientGrantType entities from the database using the composite primary keys
        /// </summary
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>ClientGrantType</returns>
		public virtual ClientGrantType Load( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<ClientGrantType>(o =>  o.ClientId == clientId &&  o.GrantTypeId == grantTypeId , cache, expr);
		}
		
        /// <summary>
        /// Load ClientGrantType entities async from the database using the composite primary keys
        /// </summary
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>ClientGrantType</returns>
		public virtual async Task<ClientGrantType> LoadAsync( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<ClientGrantType>(cache, o =>  o.ClientId == clientId &&  o.GrantTypeId == grantTypeId , expr);
		}

        /// <summary>
        /// Load all ClientGrantType entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantType></returns>
		public virtual IList<ClientGrantType> LoadAll(bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<ClientGrantType>(cache, expr).ToList<ClientGrantType>();
		}
		
        /// <summary>
        /// Load all ClientGrantType entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantType></returns>
		public virtual async Task<IList<ClientGrantType>> LoadAllAsync(bool cache, params Expression<Func<IClientGrantType,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<ClientGrantType>(cache, expr);
			return result.ToList<ClientGrantType>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ClientGrantType entity to the database.
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		public virtual bool Add(ClientGrantType entity)
		{
			this.UnitOfWork.Add(entity);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.GrantTypeId = entityToSave.GrantTypeId;
//			
			return result;
		}
		
        /// <summary>
        /// Add the ClientGrantType entity async to the database.
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ClientGrantType entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.GrantTypeId = entityToSave.GrantTypeId;
//			
			return result;
		}

        /// <summary>
        /// Update the ClientGrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		public virtual bool Update(ClientGrantType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ClientGrantType>(o =>  o.ClientId == entity.ClientId &&  o.GrantTypeId == entity.GrantTypeId , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ClientGrantType entity does not exist");
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
        /// Update the ClientGrantType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ClientGrantType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ClientGrantType>(true, o =>  o.ClientId == entity.ClientId &&  o.GrantTypeId == entity.GrantTypeId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ClientGrantType entity does not exist");
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
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ClientGrantType entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ClientGrantType>(o =>  o.ClientId == entity.ClientId &&  o.GrantTypeId == entity.GrantTypeId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientGrantType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ClientGrantType entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ClientGrantType>(true, o =>  o.ClientId == entity.ClientId &&  o.GrantTypeId == entity.GrantTypeId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientGrantType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int clientId,  int grantTypeId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ClientGrantType>(o =>  o.ClientId == clientId &&  o.GrantTypeId == grantTypeId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientGrantType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int clientId,  int grantTypeId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ClientGrantType>(cache, o =>  o.ClientId == clientId &&  o.GrantTypeId == grantTypeId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientGrantType entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<ClientGrantType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IClientGrantType, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IClientGrantType, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<ClientGrantType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IClientGrantType, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<ClientGrantType, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<ClientGrantType> items)
		{
            List<ClientGrantType> foundItems = new List<ClientGrantType>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<ClientGrantType>(o => o.ClientId == item.ClientId &&  o.GrantTypeId == item.GrantTypeId , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The ClientGrantType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<ClientGrantType>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<ClientGrantType> items)
		{
            List<ClientGrantType> foundItems = new List<ClientGrantType>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<ClientGrantType>(true, o => o.ClientId == item.ClientId &&  o.GrantTypeId == item.GrantTypeId );

		        if (foundEntity == null)
		        {
		            throw new Exception("The ClientGrantType> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<ClientGrantType>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<ClientGrantType> items)
		{
			this.UnitOfWork.BulkInsert<ClientGrantType>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ClientGrantType> items)
		{
			await this.UnitOfWork.BulkInsertAsync<ClientGrantType>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<ClientGrantType> items)
		{
            List<ClientGrantType> foundItems = new List<ClientGrantType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<ClientGrantType>(o =>  o.ClientId == entity.ClientId &&  o.GrantTypeId == entity.GrantTypeId , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ClientGrantType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<ClientGrantType>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<ClientGrantType> items)
		{
            List<ClientGrantType> foundItems = new List<ClientGrantType>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ClientGrantType>(true, o =>  o.ClientId == entity.ClientId &&  o.GrantTypeId == entity.GrantTypeId );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ClientGrantType entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<ClientGrantType>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<ClientGrantType, object>>[] Convert(params Expression<Func<IClientGrantType, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<ClientGrantType, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<ClientGrantType, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
