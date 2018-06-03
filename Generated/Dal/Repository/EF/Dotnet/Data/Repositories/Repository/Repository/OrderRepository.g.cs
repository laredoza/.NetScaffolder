
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
using RepositoryEFDotnet.Core.Base;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
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
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Order entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>IOrder</returns>
		public virtual IOrder LoadByOrderId(int orderId)
		{
			return this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == orderId);
		}

        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadByCustomerId(Nullable<int> customerId)
		{
			return this.UnitOfWork.AllMatching<Order>(o => o.CustomerId == customerId).ToList<IOrder>();
		}

        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadByOrderDate(Nullable<DateTime> orderDate)
		{
			return this.UnitOfWork.AllMatching<Order>(o => o.OrderDate == orderDate).ToList<IOrder>();
		}

        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadByDeliveryDate(Nullable<DateTime> deliveryDate)
		{
			return this.UnitOfWork.AllMatching<Order>(o => o.DeliveryDate == deliveryDate).ToList<IOrder>();
		}

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> LoadAll()
		{
			return this.UnitOfWork.GetAll<Order>().ToList<IOrder>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingName(string shippingName, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.Contains(shippingName)).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.ToLower().Contains(shippingName.ToLower())).ToList<IOrder>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingAddress(string shippingAddress, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.Contains(shippingAddress)).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.ToLower().Contains(shippingAddress.ToLower())).ToList<IOrder>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingCity(string shippingCity, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.Contains(shippingCity)).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.ToLower().Contains(shippingCity.ToLower())).ToList<IOrder>();
			}
		}

        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public virtual IList<IOrder> SearchByShippingZip(string shippingZip, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.Contains(shippingZip)).ToList<IOrder>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.ToLower().Contains(shippingZip.ToLower())).ToList<IOrder>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual bool Save(IOrder entity)
		{
			var entityToSave = new Order(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOrder entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Order>(o =>  o.OrderId == entity.OrderId );
			
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
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOrder entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Order>(o =>  o.OrderId == entity.OrderId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int orderId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Order>(o =>  o.OrderId == orderId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
