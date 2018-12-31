
// <copyright file="OrderDetails.g.cs" company="MIT">
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
	/// The OrderDetailsRepository class responsible for database functions in the OrderDetails table
	/// </summary>
	public partial class OrderDetailsRepository : UowRepository<IOrderDetails> , IOrderDetailsRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for OrderDetailsRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OrderDetailsRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for OrderDetailsRepository
        /// </summary>
		public OrderDetailsRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load OrderDetails entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		public virtual IOrderDetails LoadByOrderDetailsId(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == orderDetailsId, cache, expr);
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		public virtual async Task<IOrderDetails> LoadByOrderDetailsIdAsync(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(cache, o => o.OrderDetailsId == orderDetailsId, expr);
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByOrderId(int orderId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.OrderId == orderId, cache, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.OrderId == orderId,cache, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByProductId(int productId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.ProductId == productId, cache, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.ProductId == productId,cache, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByUnitPrice(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.UnitPrice == unitPrice, cache, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.UnitPrice == unitPrice,cache, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByAmount(Nullable<short> amount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Amount == amount, cache, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByAmountAsync(Nullable<short> amount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.Amount == amount,cache, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByDiscount(Nullable<float> discount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Discount == discount, cache, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByDiscountAsync(Nullable<float> discount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.Discount == discount,cache, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadAll(bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<OrderDetails>(cache, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load all OrderDetails entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadAllAsync(bool cache, params Expression<Func<IOrderDetails,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<OrderDetails>(cache, expr);
			return result.ToList<IOrderDetails>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Add(IOrderDetails entity)
		{
			var entityToSave = new OrderDetails(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.OrderDetailsId = entityToSave.OrderDetailsId;
			entity.OrderId = entityToSave.OrderId;
			entity.ProductId = entityToSave.ProductId;
			entity.UnitPrice = entityToSave.UnitPrice;
			entity.Amount = entityToSave.Amount;
			entity.Discount = entityToSave.Discount;
			
			return result;
		}
		
        /// <summary>
        /// Add the OrderDetails entity async to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IOrderDetails entity)
		{
			var entityToSave = new OrderDetails(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.OrderDetailsId = entityToSave.OrderDetailsId;
			entity.OrderId = entityToSave.OrderId;
			entity.ProductId = entityToSave.ProductId;
			entity.UnitPrice = entityToSave.UnitPrice;
			entity.Amount = entityToSave.Amount;
			entity.Discount = entityToSave.Discount;
			
			return result;
		}

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOrderDetails entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the OrderDetails entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IOrderDetails entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOrderDetails entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IOrderDetails entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int orderDetailsId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OrderDetails>(o =>  o.OrderDetailsId == orderDetailsId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int orderDetailsId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(cache, o =>  o.OrderDetailsId == orderDetailsId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<OrderDetails, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<OrderDetails, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IOrderDetails, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<OrderDetails, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<OrderDetails, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IOrderDetails> items)
		{
			this.UnitOfWork.BulkDelete<IOrderDetails>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IOrderDetails> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<IOrderDetails>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IOrderDetails> items)
		{
			this.UnitOfWork.BulkInsert<IOrderDetails>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IOrderDetails> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IOrderDetails>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IOrderDetails> items)
		{
			this.UnitOfWork.BulkUpdate<IOrderDetails>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IOrderDetails> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<IOrderDetails>(items);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<OrderDetails, object>>[] Convert(params Expression<Func<IOrderDetails, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<OrderDetails, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<OrderDetails, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
