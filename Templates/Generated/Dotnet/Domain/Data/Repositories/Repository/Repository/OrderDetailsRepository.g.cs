
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
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;

using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Repositories.Repository
{
	/// <summary>
	/// The OrderDetailsRepository class responsible for database functions in the OrderDetails table
	/// </summary>
	public partial class OrderDetailsRepository : UowRepository<OrderDetails> , IOrderDetailsRepository
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
        /// <returns>OrderDetails</returns>
		public virtual OrderDetails LoadByOrderDetailsId(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == orderDetailsId, cache, expr);
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>OrderDetails</returns>
		public virtual async Task<OrderDetails> LoadByOrderDetailsIdAsync(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(cache, o => o.OrderDetailsId == orderDetailsId, expr);
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<OrderDetails> LoadByOrderId(int orderId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.OrderId == orderId, cache, expr).ToList<OrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<OrderDetails>> LoadByOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.OrderId == orderId,cache, expr);
			return result.ToList<OrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<OrderDetails> LoadByProductId(int productId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.ProductId == productId, cache, expr).ToList<OrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<OrderDetails>> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.ProductId == productId,cache, expr);
			return result.ToList<OrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<OrderDetails> LoadByUnitPrice(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.UnitPrice == unitPrice, cache, expr).ToList<OrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<OrderDetails>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.UnitPrice == unitPrice,cache, expr);
			return result.ToList<OrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<OrderDetails> LoadByAmount(Nullable<short> amount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Amount == amount, cache, expr).ToList<OrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<OrderDetails>> LoadByAmountAsync(Nullable<short> amount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.Amount == amount,cache, expr);
			return result.ToList<OrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<OrderDetails> LoadByDiscount(Nullable<float> discount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Discount == discount, cache, expr).ToList<OrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
		/// <param name="includes">params Expression<Func<OrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<OrderDetails>> LoadByDiscountAsync(Nullable<float> discount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.Discount == discount,cache, expr);
			return result.ToList<OrderDetails>();
		}

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<OrderDetails></returns>
		public virtual IList<OrderDetails> LoadAll(bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<OrderDetails>(cache, expr).ToList<OrderDetails>();
		}
		
        /// <summary>
        /// Load all OrderDetails entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<OrderDetails></returns>
		public virtual async Task<IList<OrderDetails>> LoadAllAsync(bool cache, params Expression<Func<IOrderDetails,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<OrderDetails>(cache, expr);
			return result.ToList<OrderDetails>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">OrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Add(OrderDetails entity)
		{
			this.UnitOfWork.Add(entity);
			return this.UnitOfWork.Save();
		}
		
        /// <summary>
        /// Add the OrderDetails entity async to the database.
        /// </summary>
        /// <param name="entity">OrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(OrderDetails entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			return await this.UnitOfWork.SaveAsync();
		}

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Update(OrderDetails entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the OrderDetails entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(OrderDetails entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">OrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Delete(OrderDetails entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="entity">OrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(OrderDetails entity)
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
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IOrderDetails, TResult>>(maxExpression.Body, maxExpression.Parameters));
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
        public void BulkDelete(IEnumerable<OrderDetails> items)
		{
			this.UnitOfWork.BulkDelete<IOrderDetails>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<OrderDetails> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<OrderDetails>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<OrderDetails> items)
		{
			this.UnitOfWork.BulkInsert<OrderDetails>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<OrderDetails> items)
		{
			await this.UnitOfWork.BulkInsertAsync<OrderDetails>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<OrderDetails> items)
		{
			this.UnitOfWork.BulkUpdate<OrderDetails>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<OrderDetails> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<OrderDetails>(items);
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
