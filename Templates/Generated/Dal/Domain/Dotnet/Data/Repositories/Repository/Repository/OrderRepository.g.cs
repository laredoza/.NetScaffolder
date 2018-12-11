
// <copyright file="Order.g.cs" company="MIT">
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
	/// The OrderRepository class responsible for database functions in the Order table
	/// </summary>
	public partial class OrderRepository : UowRepository<IOrder> , IOrderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for OrderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OrderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for OrderRepository
        /// </summary>
		public OrderRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Order entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IOrder</returns>
		public virtual IOrder LoadByOrderId(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == orderId, cache, expr);
		}
		
        /// <summary>
        /// Load Order entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IOrder</returns>
		public virtual async Task<IOrder> LoadByOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Order>(cache, o => o.OrderId == orderId, expr);
		}

        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadByCustomerId(Nullable<int> customerId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Order>(o => o.CustomerId == customerId, cache, expr).ToList<IOrder>();
		}
		
        /// <summary>
        /// Load Order entities async from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> LoadByCustomerIdAsync(Nullable<int> customerId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.CustomerId == customerId,cache, expr);
			return result.ToList<IOrder>();
		}

        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadByOrderDate(Nullable<DateTime> orderDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Order>(o => o.OrderDate == orderDate, cache, expr).ToList<IOrder>();
		}
		
        /// <summary>
        /// Load Order entities async from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> LoadByOrderDateAsync(Nullable<DateTime> orderDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.OrderDate == orderDate,cache, expr);
			return result.ToList<IOrder>();
		}

        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadByDeliveryDate(Nullable<DateTime> deliveryDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Order>(o => o.DeliveryDate == deliveryDate, cache, expr).ToList<IOrder>();
		}
		
        /// <summary>
        /// Load Order entities async from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> LoadByDeliveryDateAsync(Nullable<DateTime> deliveryDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.DeliveryDate == deliveryDate,cache, expr);
			return result.ToList<IOrder>();
		}

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadAll(bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Order>(cache, expr).ToList<IOrder>();
		}
		
        /// <summary>
        /// Load all Order entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> LoadAllAsync(bool cache, params Expression<Func<IOrder,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Order>(cache, expr);
			return result.ToList<IOrder>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingName(string shippingName, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.Contains(shippingName), cache, expr).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.ToLower().Contains(shippingName.ToLower()), cache, expr).ToList<IOrder>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> SearchByShippingNameAsync(string shippingName, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingName.Contains(shippingName), cache, expr);
				return result.ToList<IOrder>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingName.ToLower().Contains(shippingName.ToLower()), cache, expr);
				return result.ToList<IOrder>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingAddress(string shippingAddress, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.Contains(shippingAddress), cache, expr).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.ToLower().Contains(shippingAddress.ToLower()), cache, expr).ToList<IOrder>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> SearchByShippingAddressAsync(string shippingAddress, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingAddress.Contains(shippingAddress), cache, expr);
				return result.ToList<IOrder>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingAddress.ToLower().Contains(shippingAddress.ToLower()), cache, expr);
				return result.ToList<IOrder>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingCity(string shippingCity, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.Contains(shippingCity), cache, expr).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.ToLower().Contains(shippingCity.ToLower()), cache, expr).ToList<IOrder>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> SearchByShippingCityAsync(string shippingCity, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingCity.Contains(shippingCity), cache, expr);
				return result.ToList<IOrder>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingCity.ToLower().Contains(shippingCity.ToLower()), cache, expr);
				return result.ToList<IOrder>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingZip(string shippingZip, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.Contains(shippingZip), cache, expr).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.ToLower().Contains(shippingZip.ToLower()), cache, expr).ToList<IOrder>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<IOrder>> SearchByShippingZipAsync(string shippingZip, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingZip.Contains(shippingZip), cache, expr);
				return result.ToList<IOrder>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingZip.ToLower().Contains(shippingZip.ToLower()), cache, expr);
				return result.ToList<IOrder>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual bool Add(IOrder entity)
		{
			var entityToSave = new Order(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.OrderId = entityToSave.OrderId;
			entity.CustomerId = entityToSave.CustomerId;
			entity.OrderDate = entityToSave.OrderDate;
			entity.DeliveryDate = entityToSave.DeliveryDate;
			entity.ShippingName = entityToSave.ShippingName;
			entity.ShippingAddress = entityToSave.ShippingAddress;
			entity.ShippingCity = entityToSave.ShippingCity;
			entity.ShippingZip = entityToSave.ShippingZip;
			
			return result;
		}
		
        /// <summary>
        /// Add the Order entity async to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IOrder entity)
		{
			var entityToSave = new Order(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.OrderId = entityToSave.OrderId;
			entity.CustomerId = entityToSave.CustomerId;
			entity.OrderDate = entityToSave.OrderDate;
			entity.DeliveryDate = entityToSave.DeliveryDate;
			entity.ShippingName = entityToSave.ShippingName;
			entity.ShippingAddress = entityToSave.ShippingAddress;
			entity.ShippingCity = entityToSave.ShippingCity;
			entity.ShippingZip = entityToSave.ShippingZip;
			
			return result;
		}

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOrder entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the Order entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IOrder entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOrder entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IOrder entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int orderId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Order>(o =>  o.OrderId == orderId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int orderId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Order>(cache, o =>  o.OrderId == orderId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Order, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<Order, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IOrder, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Order, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IOrder, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Order, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<IOrder> items)
		{
			this.UnitOfWork.BulkDelete<IOrder>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<IOrder> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<IOrder>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<IOrder> items)
		{
			this.UnitOfWork.BulkInsert<IOrder>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<IOrder> items)
		{
			await this.UnitOfWork.BulkInsertAsync<IOrder>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<IOrder> items)
		{
			this.UnitOfWork.BulkUpdate<IOrder>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<IOrder> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<IOrder>(items);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<Order, object>>[] Convert(params Expression<Func<IOrder, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Order, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Order, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
