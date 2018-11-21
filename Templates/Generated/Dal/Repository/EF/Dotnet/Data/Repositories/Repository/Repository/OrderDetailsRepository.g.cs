
// <copyright file="OrderDetails.g.cs" company="MIT">
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
		public virtual IOrderDetails LoadByOrderDetailsId(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == orderDetailsId, expr);
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		public virtual async Task<IOrderDetails> LoadByOrderDetailsIdAsync(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(o => o.OrderDetailsId == orderDetailsId, expr);
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByOrderId(int orderId, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.OrderId == orderId, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByOrderIdAsync(int orderId, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.OrderId == orderId, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByProductId(int productId, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.ProductId == productId, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByProductIdAsync(int productId, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.ProductId == productId, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByUnitPrice(Nullable<decimal> unitPrice, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.UnitPrice == unitPrice, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.UnitPrice == unitPrice, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByAmount(Nullable<short> amount, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Amount == amount, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByAmountAsync(Nullable<short> amount, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.Amount == amount, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByDiscount(Nullable<float> discount, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Discount == discount, expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadByDiscountAsync(Nullable<float> discount, params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<OrderDetails>(o => o.Discount == discount, expr);
			return result.ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadAll(params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<OrderDetails>(expr).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load all OrderDetails entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual async Task<IList<IOrderDetails>> LoadAllAsync(params Expression<Func<IOrderDetails, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<OrderDetails>(expr);
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
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<OrderDetails>(o =>  o.OrderDetailsId == entity.OrderDetailsId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.OrderId != entity.OrderId) { entityToUpdate.OrderId = entity.OrderId;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.UnitPrice != entity.UnitPrice) { entityToUpdate.UnitPrice = entity.UnitPrice;doUpdate = true; }
			if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			if (entityToUpdate.Discount != entity.Discount) { entityToUpdate.Discount = entity.Discount;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the OrderDetails entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IOrderDetails entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(o =>  o.OrderDetailsId == entity.OrderDetailsId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.OrderId != entity.OrderId) { entityToUpdate.OrderId = entity.OrderId;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.UnitPrice != entity.UnitPrice) { entityToUpdate.UnitPrice = entity.UnitPrice;doUpdate = true; }
			if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			if (entityToUpdate.Discount != entity.Discount) { entityToUpdate.Discount = entity.Discount;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOrderDetails entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OrderDetails>(o =>  o.OrderDetailsId == entity.OrderDetailsId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IOrderDetails entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(o =>  o.OrderDetailsId == entity.OrderDetailsId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int orderDetailsId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OrderDetails>(o =>  o.OrderDetailsId == orderDetailsId );
			
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
		public virtual async Task<bool> DeleteAsync( int orderDetailsId)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<OrderDetails>(o =>  o.OrderDetailsId == orderDetailsId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression)
		{
			return this.UnitOfWork.Max(Expression.Lambda<Func<OrderDetails, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression)
		{
			return await this.UnitOfWork.MaxAsync(Expression.Lambda<Func<OrderDetails, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IOrderDetails, TResult>> minExpression)
		{
			return this.UnitOfWork.Min(Expression.Lambda<Func<OrderDetails, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> minExpression)
		{
			return await this.UnitOfWork.MinAsync(Expression.Lambda<Func<OrderDetails, TResult>>(minExpression.Body, minExpression.Parameters));
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
