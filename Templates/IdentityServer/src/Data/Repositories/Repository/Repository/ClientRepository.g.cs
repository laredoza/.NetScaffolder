
// <copyright file="Client.g.cs" company="MIT">
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
	/// The ClientRepository class responsible for database functions in the Client table
	/// </summary>
	public partial class ClientRepository : UowRepository<Client> , IClientRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ClientRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ClientRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for ClientRepository
        /// </summary>
		public ClientRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Client entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>Client</returns>
		public virtual Client LoadById(int id, bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Client>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load Client entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>Client</returns>
		public virtual async Task<Client> LoadByIdAsync(int id, bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Client>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load Client entities from the database using the AlwaysSendClientClaims field
        /// </summary>
        /// <param name="alwaysSendClientClaims">bool</param>
		/// <param name="includes">params Expression<Func<Client, object>>[]</param>
        /// <returns>IList<IClient></returns>
		public virtual IList<Client> LoadByAlwaysSendClientClaims(bool alwaysSendClientClaims, bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Client>(o => o.AlwaysSendClientClaims == alwaysSendClientClaims, cache, expr).ToList<Client>();
		}
		
        /// <summary>
        /// Load Client entities async from the database using the AlwaysSendClientClaims field
        /// </summary>
        /// <param name="alwaysSendClientClaims">bool</param>
		/// <param name="includes">params Expression<Func<Client, object>>[]</param>
        /// <returns>IList<IClient></returns>
		public virtual async Task<IList<Client>> LoadByAlwaysSendClientClaimsAsync(bool alwaysSendClientClaims, bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Client>(o => o.AlwaysSendClientClaims == alwaysSendClientClaims,cache, expr);
			return result.ToList<Client>();
		}

        /// <summary>
        /// Load Client entities from the database using the Active field
        /// </summary>
        /// <param name="active">bool</param>
		/// <param name="includes">params Expression<Func<Client, object>>[]</param>
        /// <returns>IList<IClient></returns>
		public virtual IList<Client> LoadByActive(bool active, bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Client>(o => o.Active == active, cache, expr).ToList<Client>();
		}
		
        /// <summary>
        /// Load Client entities async from the database using the Active field
        /// </summary>
        /// <param name="active">bool</param>
		/// <param name="includes">params Expression<Func<Client, object>>[]</param>
        /// <returns>IList<IClient></returns>
		public virtual async Task<IList<Client>> LoadByActiveAsync(bool active, bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Client>(o => o.Active == active,cache, expr);
			return result.ToList<Client>();
		}

        /// <summary>
        /// Load all Client entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		public virtual IList<Client> LoadAll(bool cache, params Expression<Func<IClient, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Client>(cache, expr).ToList<Client>();
		}
		
        /// <summary>
        /// Load all Client entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		public virtual async Task<IList<Client>> LoadAllAsync(bool cache, params Expression<Func<IClient,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Client>(cache, expr);
			return result.ToList<Client>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Client entities in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		public virtual IList<Client> SearchByClientId(string clientId, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Client>(o => o.ClientId.Contains(clientId), cache, expr).ToList<Client>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Client>(o => o.ClientId.ToLower().Contains(clientId.ToLower()), cache, expr).ToList<Client>();
			}
		}
		
        /// <summary>
        /// Search for Client entities async in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		public virtual async Task<IList<Client>> SearchByClientIdAsync(string clientId, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Client>(o => o.ClientId.Contains(clientId), cache, expr);
				return result.ToList<Client>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Client>(o => o.ClientId.ToLower().Contains(clientId.ToLower()), cache, expr);
				return result.ToList<Client>();
			}
		}

        /// <summary>
        /// Search for Client entities in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		public virtual IList<Client> SearchByClientName(string clientName, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Client>(o => o.ClientName.Contains(clientName), cache, expr).ToList<Client>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Client>(o => o.ClientName.ToLower().Contains(clientName.ToLower()), cache, expr).ToList<Client>();
			}
		}
		
        /// <summary>
        /// Search for Client entities async in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		public virtual async Task<IList<Client>> SearchByClientNameAsync(string clientName, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Client>(o => o.ClientName.Contains(clientName), cache, expr);
				return result.ToList<Client>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Client>(o => o.ClientName.ToLower().Contains(clientName.ToLower()), cache, expr);
				return result.ToList<Client>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Client entity to the database.
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		public virtual bool Add(Client entity)
		{
			var entityToSave = new Client(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.ClientId = entityToSave.ClientId;
			entity.ClientName = entityToSave.ClientName;
			entity.AlwaysSendClientClaims = entityToSave.AlwaysSendClientClaims;
			entity.Active = entityToSave.Active;
			
			return result;
		}
		
        /// <summary>
        /// Add the Client entity async to the database.
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(Client entity)
		{
            var entityToSave = new Client(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.ClientId = entityToSave.ClientId;
			entity.ClientName = entityToSave.ClientName;
			entity.AlwaysSendClientClaims = entityToSave.AlwaysSendClientClaims;
			entity.Active = entityToSave.Active;
			
			return result;
		}

        /// <summary>
        /// Update the Client entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		public virtual bool Update(Client entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Client>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Client entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.ClientName != entity.ClientName) { entityToUpdate.ClientName = entity.ClientName;doUpdate = true; }
			if (entityToUpdate.AlwaysSendClientClaims != entity.AlwaysSendClientClaims) { entityToUpdate.AlwaysSendClientClaims = entity.AlwaysSendClientClaims;doUpdate = true; }
			if (entityToUpdate.Active != entity.Active) { entityToUpdate.Active = entity.Active;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the Client entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(Client entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Client>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Client entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			if (entityToUpdate.ClientName != entity.ClientName) { entityToUpdate.ClientName = entity.ClientName;doUpdate = true; }
			if (entityToUpdate.AlwaysSendClientClaims != entity.AlwaysSendClientClaims) { entityToUpdate.AlwaysSendClientClaims = entity.AlwaysSendClientClaims;doUpdate = true; }
			if (entityToUpdate.Active != entity.Active) { entityToUpdate.Active = entity.Active;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Client entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Client>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Client entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(Client entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Client>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Client entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Client>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Client entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Client>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Client entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Client, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IClient, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IClient, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Client, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IClient, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Client, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<Client> items)
		{
            List<Client> foundItems = new List<Client>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<Client>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The Client> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IClient>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<Client> items)
		{
            List<Client> foundItems = new List<Client>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<Client>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The Client> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<Client>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<Client> items)
		{
			this.UnitOfWork.BulkInsert<Client>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Client> items)
		{
			await this.UnitOfWork.BulkInsertAsync<Client>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<Client> items)
		{
            List<Client> foundItems = new List<Client>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<Client>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The Client entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.ClientName != entity.ClientName) { entityToUpdate.ClientName = entity.ClientName;doUpdate = true; }
			    if (entityToUpdate.AlwaysSendClientClaims != entity.AlwaysSendClientClaims) { entityToUpdate.AlwaysSendClientClaims = entity.AlwaysSendClientClaims;doUpdate = true; }
			    if (entityToUpdate.Active != entity.Active) { entityToUpdate.Active = entity.Active;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<Client>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<Client> items)
		{
            List<Client> foundItems = new List<Client>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Client>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The Client entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.ClientId != entity.ClientId) { entityToUpdate.ClientId = entity.ClientId;doUpdate = true; }
			    if (entityToUpdate.ClientName != entity.ClientName) { entityToUpdate.ClientName = entity.ClientName;doUpdate = true; }
			    if (entityToUpdate.AlwaysSendClientClaims != entity.AlwaysSendClientClaims) { entityToUpdate.AlwaysSendClientClaims = entity.AlwaysSendClientClaims;doUpdate = true; }
			    if (entityToUpdate.Active != entity.Active) { entityToUpdate.Active = entity.Active;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<Client>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<Client, object>>[] Convert(params Expression<Func<IClient, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Client, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Client, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
