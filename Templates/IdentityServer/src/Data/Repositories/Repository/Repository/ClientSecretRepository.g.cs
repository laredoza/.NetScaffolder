
// <copyright file="ClientSecret.g.cs" company="MIT">
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
	/// The ClientSecretRepository class responsible for database functions in the ClientSecret table
	/// </summary>
	public partial class ClientSecretRepository : UowRepository<ClientSecret> , IClientSecretRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ClientSecretRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ClientSecretRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for ClientSecretRepository
        /// </summary>
		public ClientSecretRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load ClientSecret entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>ClientSecret</returns>
		public virtual ClientSecret LoadById(int id, bool cache, params Expression<Func<IClientSecret, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<ClientSecret>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load ClientSecret entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>ClientSecret</returns>
		public virtual async Task<ClientSecret> LoadByIdAsync(int id, bool cache, params Expression<Func<IClientSecret, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<ClientSecret>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load ClientSecret entities from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param>
		/// <param name="includes">params Expression<Func<ClientSecret, object>>[]</param>
        /// <returns>IList<IClientSecret></returns>
		public virtual IList<ClientSecret> LoadByClientId(int clientId, bool cache, params Expression<Func<IClientSecret, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<ClientSecret>(o => o.ClientId == clientId, cache, expr).ToList<ClientSecret>();
		}
		
        /// <summary>
        /// Load ClientSecret entities async from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param>
		/// <param name="includes">params Expression<Func<ClientSecret, object>>[]</param>
        /// <returns>IList<IClientSecret></returns>
		public virtual async Task<IList<ClientSecret>> LoadByClientIdAsync(int clientId, bool cache, params Expression<Func<IClientSecret, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<ClientSecret>(o => o.ClientId == clientId,cache, expr);
			return result.ToList<ClientSecret>();
		}

        /// <summary>
        /// Load all ClientSecret entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		public virtual IList<ClientSecret> LoadAll(bool cache, params Expression<Func<IClientSecret, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<ClientSecret>(cache, expr).ToList<ClientSecret>();
		}
		
        /// <summary>
        /// Load all ClientSecret entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		public virtual async Task<IList<ClientSecret>> LoadAllAsync(bool cache, params Expression<Func<IClientSecret,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<ClientSecret>(cache, expr);
			return result.ToList<ClientSecret>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ClientSecret entities in the database by Secret
        /// </summary>
        /// <param name="secret">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		public virtual IList<ClientSecret> SearchBySecret(string secret, bool cache, bool caseSensitive = false, params Expression<Func<IClientSecret, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ClientSecret>(o => o.Secret.Contains(secret), cache, expr).ToList<ClientSecret>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ClientSecret>(o => o.Secret.ToLower().Contains(secret.ToLower()), cache, expr).ToList<ClientSecret>();
			}
		}
		
        /// <summary>
        /// Search for ClientSecret entities async in the database by Secret
        /// </summary>
        /// <param name="secret">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		public virtual async Task<IList<ClientSecret>> SearchBySecretAsync(string secret, bool cache, bool caseSensitive = false, params Expression<Func<IClientSecret, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ClientSecret>(o => o.Secret.Contains(secret), cache, expr);
				return result.ToList<ClientSecret>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<ClientSecret>(o => o.Secret.ToLower().Contains(secret.ToLower()), cache, expr);
				return result.ToList<ClientSecret>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ClientSecret entity to the database.
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		public virtual bool Add(ClientSecret entity)
		{
			this.UnitOfWork.Add(entity);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.Secret = entityToSave.Secret;
//			
			return result;
		}
		
        /// <summary>
        /// Add the ClientSecret entity async to the database.
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ClientSecret entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
//			//entity.Id = entityToSave.Id;
//			//entity.ClientId = entityToSave.ClientId;
//			//entity.Secret = entityToSave.Secret;
//			
			return result;
		}

        /// <summary>
        /// Update the ClientSecret entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		public virtual bool Update(ClientSecret entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ClientSecret>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ClientSecret entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.Secret != entity.Secret) { entityToUpdate.Secret = entity.Secret;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the ClientSecret entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ClientSecret entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ClientSecret>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ClientSecret entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.Secret != entity.Secret) { entityToUpdate.Secret = entity.Secret;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ClientSecret entity from the database
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ClientSecret entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ClientSecret>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientSecret entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ClientSecret entity async from the database
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ClientSecret entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ClientSecret>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientSecret entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the ClientSecret entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ClientSecret>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientSecret entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the ClientSecret entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<ClientSecret>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The ClientSecret entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IClientSecret, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<ClientSecret, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IClientSecret, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IClientSecret, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IClientSecret, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<ClientSecret, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IClientSecret, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<ClientSecret, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<ClientSecret> items)
		{
            List<ClientSecret> foundItems = new List<ClientSecret>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<ClientSecret>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The ClientSecret> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<ClientSecret>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<ClientSecret> items)
		{
            List<ClientSecret> foundItems = new List<ClientSecret>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<ClientSecret>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The ClientSecret> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<ClientSecret>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<ClientSecret> items)
		{
			this.UnitOfWork.BulkInsert<ClientSecret>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ClientSecret> items)
		{
			await this.UnitOfWork.BulkInsertAsync<ClientSecret>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<ClientSecret> items)
		{
            List<ClientSecret> foundItems = new List<ClientSecret>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<ClientSecret>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ClientSecret entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.Secret != entity.Secret) { entityToUpdate.Secret = entity.Secret;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<ClientSecret>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<ClientSecret> items)
		{
            List<ClientSecret> foundItems = new List<ClientSecret>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<ClientSecret>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The ClientSecret entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.Secret != entity.Secret) { entityToUpdate.Secret = entity.Secret;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<ClientSecret>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<ClientSecret, object>>[] Convert(params Expression<Func<IClientSecret, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<ClientSecret, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<ClientSecret, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
