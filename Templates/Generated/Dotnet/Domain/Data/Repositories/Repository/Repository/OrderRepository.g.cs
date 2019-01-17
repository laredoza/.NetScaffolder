
// <copyright file="Order.g.cs" company="MIT">
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
	/// The OrderRepository class responsible for database functions in the Order table
	/// </summary>
	public partial class OrderRepository : UowRepository<Order> , IOrderRepository
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
        /// <returns>Order</returns>
		public virtual Order LoadByOrderId(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == orderId, cache, expr);
		}
		
        /// <summary>
        /// Load Order entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>Order</returns>
		public virtual async Task<Order> LoadByOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Order>(cache, o => o.OrderId == orderId, expr);
		}

        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">int</param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<Order> LoadByCustomerId(int customerId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Order>(o => o.CustomerId == customerId, cache, expr).ToList<Order>();
		}
		
        /// <summary>
        /// Load Order entities async from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">int</param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<Order>> LoadByCustomerIdAsync(int customerId, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.CustomerId == customerId,cache, expr);
			return result.ToList<Order>();
		}

        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<Order> LoadByOrderDate(Nullable<DateTime> orderDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Order>(o => o.OrderDate == orderDate, cache, expr).ToList<Order>();
		}
		
        /// <summary>
        /// Load Order entities async from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<Order>> LoadByOrderDateAsync(Nullable<DateTime> orderDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.OrderDate == orderDate,cache, expr);
			return result.ToList<Order>();
		}

        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<Order> LoadByDeliveryDate(Nullable<DateTime> deliveryDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Order>(o => o.DeliveryDate == deliveryDate, cache, expr).ToList<Order>();
		}
		
        /// <summary>
        /// Load Order entities async from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public virtual async Task<IList<Order>> LoadByDeliveryDateAsync(Nullable<DateTime> deliveryDate, bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.DeliveryDate == deliveryDate,cache, expr);
			return result.ToList<Order>();
		}

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual IList<Order> LoadAll(bool cache, params Expression<Func<IOrder, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Order>(cache, expr).ToList<Order>();
		}
		
        /// <summary>
        /// Load all Order entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual async Task<IList<Order>> LoadAllAsync(bool cache, params Expression<Func<IOrder,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Order>(cache, expr);
			return result.ToList<Order>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual IList<Order> SearchByShippingName(string shippingName, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.Contains(shippingName), cache, expr).ToList<Order>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.ToLower().Contains(shippingName.ToLower()), cache, expr).ToList<Order>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual async Task<IList<Order>> SearchByShippingNameAsync(string shippingName, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingName.Contains(shippingName), cache, expr);
				return result.ToList<Order>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingName.ToLower().Contains(shippingName.ToLower()), cache, expr);
				return result.ToList<Order>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual IList<Order> SearchByShippingAddress(string shippingAddress, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.Contains(shippingAddress), cache, expr).ToList<Order>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.ToLower().Contains(shippingAddress.ToLower()), cache, expr).ToList<Order>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual async Task<IList<Order>> SearchByShippingAddressAsync(string shippingAddress, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingAddress.Contains(shippingAddress), cache, expr);
				return result.ToList<Order>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingAddress.ToLower().Contains(shippingAddress.ToLower()), cache, expr);
				return result.ToList<Order>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual IList<Order> SearchByShippingCity(string shippingCity, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.Contains(shippingCity), cache, expr).ToList<Order>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.ToLower().Contains(shippingCity.ToLower()), cache, expr).ToList<Order>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual async Task<IList<Order>> SearchByShippingCityAsync(string shippingCity, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingCity.Contains(shippingCity), cache, expr);
				return result.ToList<Order>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingCity.ToLower().Contains(shippingCity.ToLower()), cache, expr);
				return result.ToList<Order>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual IList<Order> SearchByShippingZip(string shippingZip, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.Contains(shippingZip), cache, expr).ToList<Order>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.ToLower().Contains(shippingZip.ToLower()), cache, expr).ToList<Order>();
			}
		}
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		public virtual async Task<IList<Order>> SearchByShippingZipAsync(string shippingZip, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingZip.Contains(shippingZip), cache, expr);
				return result.ToList<Order>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Order>(o => o.ShippingZip.ToLower().Contains(shippingZip.ToLower()), cache, expr);
				return result.ToList<Order>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		public virtual bool Add(Order entity)
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
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(Order entity)
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
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		public virtual bool Update(Order entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Order>(o =>  o.OrderId == entity.OrderId , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CustomerId != entity.CustomerId) { entityToUpdate.CustomerId = entity.CustomerId;doUpdate = true; }
			if (entityToUpdate.OrderDate != entity.OrderDate) { entityToUpdate.OrderDate = entity.OrderDate;doUpdate = true; }
			if (entityToUpdate.DeliveryDate != entity.DeliveryDate) { entityToUpdate.DeliveryDate = entity.DeliveryDate;doUpdate = true; }
			if (entityToUpdate.ShippingName != entity.ShippingName) { entityToUpdate.ShippingName = entity.ShippingName;doUpdate = true; }
			if (entityToUpdate.ShippingAddress != entity.ShippingAddress) { entityToUpdate.ShippingAddress = entity.ShippingAddress;doUpdate = true; }
			if (entityToUpdate.ShippingCity != entity.ShippingCity) { entityToUpdate.ShippingCity = entity.ShippingCity;doUpdate = true; }
			if (entityToUpdate.ShippingZip != entity.ShippingZip) { entityToUpdate.ShippingZip = entity.ShippingZip;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the Order entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(Order entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Order>(true, o =>  o.OrderId == entity.OrderId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CustomerId != entity.CustomerId) { entityToUpdate.CustomerId = entity.CustomerId;doUpdate = true; }
			if (entityToUpdate.OrderDate != entity.OrderDate) { entityToUpdate.OrderDate = entity.OrderDate;doUpdate = true; }
			if (entityToUpdate.DeliveryDate != entity.DeliveryDate) { entityToUpdate.DeliveryDate = entity.DeliveryDate;doUpdate = true; }
			if (entityToUpdate.ShippingName != entity.ShippingName) { entityToUpdate.ShippingName = entity.ShippingName;doUpdate = true; }
			if (entityToUpdate.ShippingAddress != entity.ShippingAddress) { entityToUpdate.ShippingAddress = entity.ShippingAddress;doUpdate = true; }
			if (entityToUpdate.ShippingCity != entity.ShippingCity) { entityToUpdate.ShippingCity = entity.ShippingCity;doUpdate = true; }
			if (entityToUpdate.ShippingZip != entity.ShippingZip) { entityToUpdate.ShippingZip = entity.ShippingZip;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Order entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Order>(o =>  o.OrderId == entity.OrderId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(Order entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Order>(true, o =>  o.OrderId == entity.OrderId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
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
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IOrder, TResult>>(maxExpression.Body, maxExpression.Parameters));
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
        public void BulkDelete(IEnumerable<Order> items)
		{
			this.UnitOfWork.BulkDelete<IOrder>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<Order> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<Order>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<Order> items)
		{
			this.UnitOfWork.BulkInsert<Order>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Order> items)
		{
			await this.UnitOfWork.BulkInsertAsync<Order>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<Order> items)
		{
			this.UnitOfWork.BulkUpdate<Order>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<Order> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<Order>(items);
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
