
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
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;

using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Repositories.Repository
{
	/// <summary>
	/// The ProductRepository class responsible for database functions in the Product table
	/// </summary>
	public partial class ProductRepository : UowRepository<Product> , IProductRepository
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
        /// <returns>Product</returns>
		public virtual Product LoadByProductId(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == productId, cache, expr);
		}
		
        /// <summary>
        /// Load Product entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>Product</returns>
		public virtual async Task<Product> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Product>(cache, o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<Product, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<Product> LoadByUnitPrice(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Product>(o => o.UnitPrice == unitPrice, cache, expr).ToList<Product>();
		}
		
        /// <summary>
        /// Load Product entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<Product, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<Product>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.UnitPrice == unitPrice,cache, expr);
			return result.ToList<Product>();
		}

        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
		/// <param name="includes">params Expression<Func<Product, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<Product> LoadByAmountInStock(Nullable<short> amountInStock, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Product>(o => o.AmountInStock == amountInStock, cache, expr).ToList<Product>();
		}
		
        /// <summary>
        /// Load Product entities async from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
		/// <param name="includes">params Expression<Func<Product, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<Product>> LoadByAmountInStockAsync(Nullable<short> amountInStock, bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.AmountInStock == amountInStock,cache, expr);
			return result.ToList<Product>();
		}

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<Product></returns>
		public virtual IList<Product> LoadAll(bool cache, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Product>(cache, expr).ToList<Product>();
		}
		
        /// <summary>
        /// Load all Product entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<Product></returns>
		public virtual async Task<IList<Product>> LoadAllAsync(bool cache, params Expression<Func<IProduct,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Product>(cache, expr);
			return result.ToList<Product>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<Product></returns>
		public virtual IList<Product> SearchByProductDescription(string productDescription, bool cache, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.Contains(productDescription), cache, expr).ToList<Product>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower()), cache, expr).ToList<Product>();
			}
		}
		
        /// <summary>
        /// Search for Product entities async in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<Product></returns>
		public virtual async Task<IList<Product>> SearchByProductDescriptionAsync(string productDescription, bool cache, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.ProductDescription.Contains(productDescription), cache, expr);
				return result.ToList<Product>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower()), cache, expr);
				return result.ToList<Product>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">Product</param>
        /// <returns>bool</returns>
		public virtual bool Add(Product entity)
		{
			this.UnitOfWork.Add(entity);
			return this.UnitOfWork.Save();
		}
		
        /// <summary>
        /// Add the Product entity async to the database.
        /// </summary>
        /// <param name="entity">Product</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(Product entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			return await this.UnitOfWork.SaveAsync();
		}

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Product</param>
        /// <returns>bool</returns>
		public virtual bool Update(Product entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the Product entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Product</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(Product entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">Product</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Product entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="entity">Product</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(Product entity)
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
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IProduct, TResult>>(maxExpression.Body, maxExpression.Parameters));
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
        public void BulkDelete(IEnumerable<Product> items)
		{
			this.UnitOfWork.BulkDelete<IProduct>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<Product> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<Product>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<Product> items)
		{
			this.UnitOfWork.BulkInsert<Product>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Product> items)
		{
			await this.UnitOfWork.BulkInsertAsync<Product>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<Product> items)
		{
			this.UnitOfWork.BulkUpdate<Product>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<Product> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<Product>(items);
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
