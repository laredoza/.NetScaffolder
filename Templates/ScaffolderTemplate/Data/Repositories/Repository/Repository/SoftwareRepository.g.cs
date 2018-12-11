
// <copyright file="Software.g.cs" company="MIT">
//  Copyright (c) 2018 MIT
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
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Repository
{
	/// <summary>
	/// The SoftwareRepository class responsible for database functions in the Software table
	/// </summary>
	public partial class SoftwareRepository : UowRepository<ISoftware> , ISoftwareRepository
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
        /// <returns>ISoftware</returns>
		public virtual ISoftware LoadByProductId(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == productId, cache, expr);
		}
		
        /// <summary>
        /// Load Software entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>ISoftware</returns>
		public virtual async Task<ISoftware> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Software>(cache, o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public virtual IList<ISoftware> LoadAll(bool cache, params Expression<Func<ISoftware, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Software>(cache, expr).ToList<ISoftware>();
		}
		
        /// <summary>
        /// Load all Software entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public virtual async Task<IList<ISoftware>> LoadAllAsync(bool cache, params Expression<Func<ISoftware,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Software>(cache, expr);
			return result.ToList<ISoftware>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public virtual IList<ISoftware> SearchByLicenseCode(string licenseCode, bool cache, bool caseSensitive = false, params Expression<Func<ISoftware, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.Contains(licenseCode), cache, expr).ToList<ISoftware>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.ToLower().Contains(licenseCode.ToLower()), cache, expr).ToList<ISoftware>();
			}
		}
		
        /// <summary>
        /// Search for Software entities async in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public virtual async Task<IList<ISoftware>> SearchByLicenseCodeAsync(string licenseCode, bool cache, bool caseSensitive = false, params Expression<Func<ISoftware, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Software>(o => o.LicenseCode.Contains(licenseCode), cache, expr);
				return result.ToList<ISoftware>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Software>(o => o.LicenseCode.ToLower().Contains(licenseCode.ToLower()), cache, expr);
				return result.ToList<ISoftware>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual bool Add(ISoftware entity)
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
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ISoftware entity)
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
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISoftware entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the Software entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ISoftware entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISoftware entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ISoftware entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
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
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<Software, TResult>>(maxExpression.Body, maxExpression.Parameters));
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
        public void BulkDelete(IEnumerable<ISoftware> items)
		{
			this.UnitOfWork.BulkDelete<ISoftware>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<ISoftware> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<ISoftware>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<ISoftware> items)
		{
			this.UnitOfWork.BulkInsert<ISoftware>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ISoftware> items)
		{
			await this.UnitOfWork.BulkInsertAsync<ISoftware>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<ISoftware> items)
		{
			this.UnitOfWork.BulkUpdate<ISoftware>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<ISoftware> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<ISoftware>(items);
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
