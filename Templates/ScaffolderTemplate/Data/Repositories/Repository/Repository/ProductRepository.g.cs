
// <copyright file="Product.g.cs" company="MIT">
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

using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Repositories.Repository
{
	/// <summary>
	/// The ProductRepository class responsible for database functions in the Product table
	/// </summary>
	public partial class ProductRepository : UowRepository<IProduct> , IProductRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for ProductRepository
        /// </summary>
		public ProductRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Product entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		public virtual IProduct LoadByProductId(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == productId, cache, expr);
		}
		
        /// <summary>
        /// Load Product entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		public virtual async Task<IProduct> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Product>(cache, o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadByUnitPrice(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Product>(o => o.UnitPrice == unitPrice, cache, expr).ToList<IProduct>();
		}
		
        /// <summary>
        /// Load Product entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.UnitPrice == unitPrice,cache, expr);
			return result.ToList<IProduct>();
		}

        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadByAmountInStock(Nullable<short> amountInStock, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Product>(o => o.AmountInStock == amountInStock, cache, expr).ToList<IProduct>();
		}
		
        /// <summary>
        /// Load Product entities async from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> LoadByAmountInStockAsync(Nullable<short> amountInStock, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.AmountInStock == amountInStock,cache, expr);
			return result.ToList<IProduct>();
		}

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadAll(bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Product>(cache, expr).ToList<IProduct>();
		}
		
        /// <summary>
        /// Load all Product entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> LoadAllAsync(bool cache, params Expression<Func<IProduct,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Product>(cache, expr);
			return result.ToList<IProduct>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> SearchByProductDescription(string productDescription, bool cache, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.Contains(productDescription), cache, expr).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower()), cache, expr).ToList<IProduct>();
			}
		}
		
        /// <summary>
        /// Search for Product entities async in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> SearchByProductDescriptionAsync(string productDescription, bool cache, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.ProductDescription.Contains(productDescription), cache, expr);
				return result.ToList<IProduct>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower()), cache, expr);
				return result.ToList<IProduct>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual bool Add(IProduct entity)
		{
			var entityToSave = new Product(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.ProductDescription = entityToSave.ProductDescription;
			entity.UnitPrice = entityToSave.UnitPrice;
			entity.AmountInStock = entityToSave.AmountInStock;
			
			return result;
		}
		
        /// <summary>
        /// Add the Product entity async to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IProduct entity)
		{
			var entityToSave = new Product(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.ProductDescription = entityToSave.ProductDescription;
			entity.UnitPrice = entityToSave.UnitPrice;
			entity.AmountInStock = entityToSave.AmountInStock;
			
			return result;
		}

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProduct entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the Product entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IProduct entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProduct entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IProduct entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int productId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product>(o =>  o.ProductId == productId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int productId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Product>(cache, o =>  o.ProductId == productId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Product, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<Product, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IProduct, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Product, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IProduct, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Product, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IProduct> items)
		{
			this.UnitOfWork.BulkDelete<IProduct>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IProduct> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<IProduct>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IProduct> items)
		{
			this.UnitOfWork.BulkInsert<IProduct>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IProduct> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IProduct>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IProduct> items)
		{
			this.UnitOfWork.BulkUpdate<IProduct>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IProduct> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<IProduct>(items);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<Product, object>>[] Convert(params Expression<Func<IProduct, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Product, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Product, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
