
// <copyright file="Software.g.cs" company="MIT">
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
	/// The SoftwareRepository class responsible for database functions in the Software table
	/// </summary>
	public partial class SoftwareRepository : UowRepository<Software> , ISoftwareRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SoftwareRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SoftwareRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for SoftwareRepository
        /// </summary>
		public SoftwareRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Software entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>Software</returns>
		public virtual Software LoadByProductId(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == productId, cache, expr);
		}
		
        /// <summary>
        /// Load Software entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>Software</returns>
		public virtual async Task<Software> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Software>(cache, o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<Software></returns>
		public virtual IList<Software> LoadAll(bool cache, params Expression<Func<ISoftware, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Software>(cache, expr).ToList<Software>();
		}
		
        /// <summary>
        /// Load all Software entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<Software></returns>
		public virtual async Task<IList<Software>> LoadAllAsync(bool cache, params Expression<Func<ISoftware,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Software>(cache, expr);
			return result.ToList<Software>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<Software></returns>
		public virtual IList<Software> SearchByLicenseCode(string licenseCode, bool cache, bool caseSensitive = false, params Expression<Func<ISoftware, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.Contains(licenseCode), cache, expr).ToList<Software>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.ToLower().Contains(licenseCode.ToLower()), cache, expr).ToList<Software>();
			}
		}
		
        /// <summary>
        /// Search for Software entities async in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<Software></returns>
		public virtual async Task<IList<Software>> SearchByLicenseCodeAsync(string licenseCode, bool cache, bool caseSensitive = false, params Expression<Func<ISoftware, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Software>(o => o.LicenseCode.Contains(licenseCode), cache, expr);
				return result.ToList<Software>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Software>(o => o.LicenseCode.ToLower().Contains(licenseCode.ToLower()), cache, expr);
				return result.ToList<Software>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">Software</param>
        /// <returns>bool</returns>
		public virtual bool Add(Software entity)
		{
			var entityToSave = new Software(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.LicenseCode = entityToSave.LicenseCode;
			
			return result;
		}
		
        /// <summary>
        /// Add the Software entity async to the database.
        /// </summary>
        /// <param name="entity">Software</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(Software entity)
		{
            var entityToSave = new Software(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.LicenseCode = entityToSave.LicenseCode;
			
			return result;
		}

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Software</param>
        /// <returns>bool</returns>
		public virtual bool Update(Software entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == entity.ProductId , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.LicenseCode != entity.LicenseCode) { entityToUpdate.LicenseCode = entity.LicenseCode;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the Software entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Software</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(Software entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Software>(true, o =>  o.ProductId == entity.ProductId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.LicenseCode != entity.LicenseCode) { entityToUpdate.LicenseCode = entity.LicenseCode;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">Software</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Software entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == entity.ProductId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="entity">Software</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(Software entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Software>(true, o =>  o.ProductId == entity.ProductId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int productId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == productId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int productId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Software>(cache, o =>  o.ProductId == productId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Software, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<ISoftware, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<ISoftware, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Software, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<ISoftware, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Software, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<Software> items)
		{
            List<Software> foundItems = new List<Software>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == item.ProductId , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The Software> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<ISoftware>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<Software> items)
		{
            List<Software> foundItems = new List<Software>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<Software>(true, o => o.ProductId == item.ProductId );

		        if (foundEntity == null)
		        {
		            throw new Exception("The Software> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<Software>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<Software> items)
		{
			this.UnitOfWork.BulkInsert<Software>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Software> items)
		{
			await this.UnitOfWork.BulkInsertAsync<Software>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<Software> items)
		{
            List<Software> foundItems = new List<Software>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == entity.ProductId , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The Software entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.LicenseCode != entity.LicenseCode) { entityToUpdate.LicenseCode = entity.LicenseCode;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<Software>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<Software> items)
		{
            List<Software> foundItems = new List<Software>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Software>(true, o =>  o.ProductId == entity.ProductId );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The Software entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.LicenseCode != entity.LicenseCode) { entityToUpdate.LicenseCode = entity.LicenseCode;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<Software>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<Software, object>>[] Convert(params Expression<Func<ISoftware, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Software, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Software, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
