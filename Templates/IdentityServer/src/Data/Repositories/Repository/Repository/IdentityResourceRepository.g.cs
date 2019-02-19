
// <copyright file="IdentityResource.g.cs" company="MIT">
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
	/// The IdentityResourceRepository class responsible for database functions in the IdentityResource table
	/// </summary>
	public partial class IdentityResourceRepository : UowRepository<IdentityResource> , IIdentityResourceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for IdentityResourceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public IdentityResourceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for IdentityResourceRepository
        /// </summary>
		public IdentityResourceRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load IdentityResource entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IdentityResource</returns>
		public virtual IdentityResource LoadById(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<IdentityResource>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IdentityResource</returns>
		public virtual async Task<IdentityResource> LoadByIdAsync(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<IdentityResource>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load IdentityResource entities from the database using the ShowInDiscoveryDocument field
        /// </summary>
        /// <param name="showInDiscoveryDocument">bool</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IIdentityResource></returns>
		public virtual IList<IdentityResource> LoadByShowInDiscoveryDocument(bool showInDiscoveryDocument, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<IdentityResource>(o => o.ShowInDiscoveryDocument == showInDiscoveryDocument, cache, expr).ToList<IdentityResource>();
		}
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the ShowInDiscoveryDocument field
        /// </summary>
        /// <param name="showInDiscoveryDocument">bool</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IIdentityResource></returns>
		public virtual async Task<IList<IdentityResource>> LoadByShowInDiscoveryDocumentAsync(bool showInDiscoveryDocument, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.ShowInDiscoveryDocument == showInDiscoveryDocument,cache, expr);
			return result.ToList<IdentityResource>();
		}

        /// <summary>
        /// Load IdentityResource entities from the database using the Required field
        /// </summary>
        /// <param name="required">bool</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IIdentityResource></returns>
		public virtual IList<IdentityResource> LoadByRequired(bool required, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<IdentityResource>(o => o.Required == required, cache, expr).ToList<IdentityResource>();
		}
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the Required field
        /// </summary>
        /// <param name="required">bool</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IIdentityResource></returns>
		public virtual async Task<IList<IdentityResource>> LoadByRequiredAsync(bool required, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.Required == required,cache, expr);
			return result.ToList<IdentityResource>();
		}

        /// <summary>
        /// Load IdentityResource entities from the database using the Emphasize field
        /// </summary>
        /// <param name="emphasize">bool</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IIdentityResource></returns>
		public virtual IList<IdentityResource> LoadByEmphasize(bool emphasize, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<IdentityResource>(o => o.Emphasize == emphasize, cache, expr).ToList<IdentityResource>();
		}
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the Emphasize field
        /// </summary>
        /// <param name="emphasize">bool</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IIdentityResource></returns>
		public virtual async Task<IList<IdentityResource>> LoadByEmphasizeAsync(bool emphasize, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.Emphasize == emphasize,cache, expr);
			return result.ToList<IdentityResource>();
		}

        /// <summary>
        /// Load all IdentityResource entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		public virtual IList<IdentityResource> LoadAll(bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<IdentityResource>(cache, expr).ToList<IdentityResource>();
		}
		
        /// <summary>
        /// Load all IdentityResource entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		public virtual async Task<IList<IdentityResource>> LoadAllAsync(bool cache, params Expression<Func<IIdentityResource,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<IdentityResource>(cache, expr);
			return result.ToList<IdentityResource>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for IdentityResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		public virtual IList<IdentityResource> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<IdentityResource>(o => o.Name.Contains(name), cache, expr).ToList<IdentityResource>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<IdentityResource>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr).ToList<IdentityResource>();
			}
		}
		
        /// <summary>
        /// Search for IdentityResource entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		public virtual async Task<IList<IdentityResource>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.Name.Contains(name), cache, expr);
				return result.ToList<IdentityResource>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.Name.ToLower().Contains(name.ToLower()), cache, expr);
				return result.ToList<IdentityResource>();
			}
		}

        /// <summary>
        /// Search for IdentityResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		public virtual IList<IdentityResource> SearchByDisplayName(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<IdentityResource>(o => o.DisplayName.Contains(displayName), cache, expr).ToList<IdentityResource>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<IdentityResource>(o => o.DisplayName.ToLower().Contains(displayName.ToLower()), cache, expr).ToList<IdentityResource>();
			}
		}
		
        /// <summary>
        /// Search for IdentityResource entities async in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		public virtual async Task<IList<IdentityResource>> SearchByDisplayNameAsync(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.DisplayName.Contains(displayName), cache, expr);
				return result.ToList<IdentityResource>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<IdentityResource>(o => o.DisplayName.ToLower().Contains(displayName.ToLower()), cache, expr);
				return result.ToList<IdentityResource>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the IdentityResource entity to the database.
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		public virtual bool Add(IdentityResource entity)
		{
			var entityToSave = new IdentityResource(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			entity.DisplayName = entityToSave.DisplayName;
			entity.ShowInDiscoveryDocument = entityToSave.ShowInDiscoveryDocument;
			entity.Required = entityToSave.Required;
			entity.Emphasize = entityToSave.Emphasize;
			
			return result;
		}
		
        /// <summary>
        /// Add the IdentityResource entity async to the database.
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IdentityResource entity)
		{
            var entityToSave = new IdentityResource(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Name = entityToSave.Name;
			entity.DisplayName = entityToSave.DisplayName;
			entity.ShowInDiscoveryDocument = entityToSave.ShowInDiscoveryDocument;
			entity.Required = entityToSave.Required;
			entity.Emphasize = entityToSave.Emphasize;
			
			return result;
		}

        /// <summary>
        /// Update the IdentityResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		public virtual bool Update(IdentityResource entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<IdentityResource>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The IdentityResource entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }
			if (entityToUpdate.ShowInDiscoveryDocument != entity.ShowInDiscoveryDocument) { entityToUpdate.ShowInDiscoveryDocument = entity.ShowInDiscoveryDocument;doUpdate = true; }
			if (entityToUpdate.Required != entity.Required) { entityToUpdate.Required = entity.Required;doUpdate = true; }
			if (entityToUpdate.Emphasize != entity.Emphasize) { entityToUpdate.Emphasize = entity.Emphasize;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the IdentityResource entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IdentityResource entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResource>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The IdentityResource entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }
			if (entityToUpdate.ShowInDiscoveryDocument != entity.ShowInDiscoveryDocument) { entityToUpdate.ShowInDiscoveryDocument = entity.ShowInDiscoveryDocument;doUpdate = true; }
			if (entityToUpdate.Required != entity.Required) { entityToUpdate.Required = entity.Required;doUpdate = true; }
			if (entityToUpdate.Emphasize != entity.Emphasize) { entityToUpdate.Emphasize = entity.Emphasize;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IdentityResource entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<IdentityResource>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResource entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IdentityResource entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResource>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResource entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<IdentityResource>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResource entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResource>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The IdentityResource entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<IdentityResource, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IIdentityResource, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IIdentityResource, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<IdentityResource, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IIdentityResource, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<IdentityResource, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IdentityResource> items)
		{
            List<IdentityResource> foundItems = new List<IdentityResource>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<IdentityResource>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The IdentityResource> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IIdentityResource>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IdentityResource> items)
		{
            List<IdentityResource> foundItems = new List<IdentityResource>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResource>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The IdentityResource> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<IdentityResource>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IdentityResource> items)
		{
			this.UnitOfWork.BulkInsert<IdentityResource>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IdentityResource> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IdentityResource>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IdentityResource> items)
		{
            List<IdentityResource> foundItems = new List<IdentityResource>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<IdentityResource>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The IdentityResource entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			    if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }
			    if (entityToUpdate.ShowInDiscoveryDocument != entity.ShowInDiscoveryDocument) { entityToUpdate.ShowInDiscoveryDocument = entity.ShowInDiscoveryDocument;doUpdate = true; }
			    if (entityToUpdate.Required != entity.Required) { entityToUpdate.Required = entity.Required;doUpdate = true; }
			    if (entityToUpdate.Emphasize != entity.Emphasize) { entityToUpdate.Emphasize = entity.Emphasize;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<IdentityResource>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IdentityResource> items)
		{
            List<IdentityResource> foundItems = new List<IdentityResource>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<IdentityResource>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The IdentityResource entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			    if (entityToUpdate.DisplayName != entity.DisplayName) { entityToUpdate.DisplayName = entity.DisplayName;doUpdate = true; }
			    if (entityToUpdate.ShowInDiscoveryDocument != entity.ShowInDiscoveryDocument) { entityToUpdate.ShowInDiscoveryDocument = entity.ShowInDiscoveryDocument;doUpdate = true; }
			    if (entityToUpdate.Required != entity.Required) { entityToUpdate.Required = entity.Required;doUpdate = true; }
			    if (entityToUpdate.Emphasize != entity.Emphasize) { entityToUpdate.Emphasize = entity.Emphasize;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<IdentityResource>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<IdentityResource, object>>[] Convert(params Expression<Func<IIdentityResource, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<IdentityResource, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<IdentityResource, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
