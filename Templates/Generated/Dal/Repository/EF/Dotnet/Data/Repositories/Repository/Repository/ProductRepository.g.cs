
// <copyright file="Product.g.cs" company="MIT">
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
using Banking.Models.Interfaces;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Repository
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
		public virtual IProduct LoadByProductId(int productId, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == productId, expr);
		}
		
        /// <summary>
        /// Load Product entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		public virtual async Task<IProduct> LoadByProductIdAsync(int productId, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Product>(o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadByUnitPrice(Nullable<decimal> unitPrice, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Product>(o => o.UnitPrice == unitPrice, expr).ToList<IProduct>();
		}
		
        /// <summary>
        /// Load Product entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.UnitPrice == unitPrice, expr);
			return result.ToList<IProduct>();
		}

        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadByAmountInStock(Nullable<short> amountInStock, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Product>(o => o.AmountInStock == amountInStock, expr).ToList<IProduct>();
		}
		
        /// <summary>
        /// Load Product entities async from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> LoadByAmountInStockAsync(Nullable<short> amountInStock, params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.AmountInStock == amountInStock, expr);
			return result.ToList<IProduct>();
		}

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadAll(params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Product>(expr).ToList<IProduct>();
		}
		
        /// <summary>
        /// Load all Product entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> LoadAllAsync(params Expression<Func<IProduct, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Product>(expr);
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
		public virtual IList<IProduct> SearchByProductDescription(string productDescription, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.Contains(productDescription), expr).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower()), expr).ToList<IProduct>();
			}
		}
		
        /// <summary>
        /// Search for Product entities async in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> SearchByProductDescriptionAsync(string productDescription, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.ProductDescription.Contains(productDescription), expr);
				return result.ToList<IProduct>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower()), expr);
				return result.ToList<IProduct>();
			}
		}

        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> SearchByUnitAmount(string unitAmount, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount.Contains(unitAmount), expr).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount.ToLower().Contains(unitAmount.ToLower()), expr).ToList<IProduct>();
			}
		}
		
        /// <summary>
        /// Search for Product entities async in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> SearchByUnitAmountAsync(string unitAmount, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.UnitAmount.Contains(unitAmount), expr);
				return result.ToList<IProduct>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.UnitAmount.ToLower().Contains(unitAmount.ToLower()), expr);
				return result.ToList<IProduct>();
			}
		}

        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> SearchByPublisher(string publisher, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.Publisher.Contains(publisher), expr).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.Publisher.ToLower().Contains(publisher.ToLower()), expr).ToList<IProduct>();
			}
		}
		
        /// <summary>
        /// Search for Product entities async in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public virtual async Task<IList<IProduct>> SearchByPublisherAsync(string publisher, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.Publisher.Contains(publisher), expr);
				return result.ToList<IProduct>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Product>(o => o.Publisher.ToLower().Contains(publisher.ToLower()), expr);
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
			entity.UnitAmount = entityToSave.UnitAmount;
			entity.Publisher = entityToSave.Publisher;
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
			entity.UnitAmount = entityToSave.UnitAmount;
			entity.Publisher = entityToSave.Publisher;
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
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Product>(o =>  o.ProductId == entity.ProductId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ProductDescription != entity.ProductDescription) { entityToUpdate.ProductDescription = entity.ProductDescription;doUpdate = true; }
			if (entityToUpdate.UnitPrice != entity.UnitPrice) { entityToUpdate.UnitPrice = entity.UnitPrice;doUpdate = true; }
			if (entityToUpdate.UnitAmount != entity.UnitAmount) { entityToUpdate.UnitAmount = entity.UnitAmount;doUpdate = true; }
			if (entityToUpdate.Publisher != entity.Publisher) { entityToUpdate.Publisher = entity.Publisher;doUpdate = true; }
			if (entityToUpdate.AmountInStock != entity.AmountInStock) { entityToUpdate.AmountInStock = entity.AmountInStock;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the Product entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IProduct entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Product>(o =>  o.ProductId == entity.ProductId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ProductDescription != entity.ProductDescription) { entityToUpdate.ProductDescription = entity.ProductDescription;doUpdate = true; }
			if (entityToUpdate.UnitPrice != entity.UnitPrice) { entityToUpdate.UnitPrice = entity.UnitPrice;doUpdate = true; }
			if (entityToUpdate.UnitAmount != entity.UnitAmount) { entityToUpdate.UnitAmount = entity.UnitAmount;doUpdate = true; }
			if (entityToUpdate.Publisher != entity.Publisher) { entityToUpdate.Publisher = entity.Publisher;doUpdate = true; }
			if (entityToUpdate.AmountInStock != entity.AmountInStock) { entityToUpdate.AmountInStock = entity.AmountInStock;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProduct entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product>(o =>  o.ProductId == entity.ProductId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IProduct entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Product>(o =>  o.ProductId == entity.ProductId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int productId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product>(o =>  o.ProductId == productId );
			
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
		public virtual async Task<bool> DeleteAsync( int productId)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Product>(o =>  o.ProductId == productId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IProduct, TResult>> maxExpression)
		{
			return this.UnitOfWork.Max(Expression.Lambda<Func<Product, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression)
		{
			return await this.UnitOfWork.MaxAsync(Expression.Lambda<Func<Product, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IProduct, TResult>> minExpression)
		{
			return this.UnitOfWork.Min(Expression.Lambda<Func<Product, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IProduct, TResult>> minExpression)
		{
			return await this.UnitOfWork.MinAsync(Expression.Lambda<Func<Product, TResult>>(minExpression.Body, minExpression.Parameters));
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
