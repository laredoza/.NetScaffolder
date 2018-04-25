﻿
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
using RepositoryEFDotnet.Library;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The OrderRepository class responsible for database functions in the Order table
	/// </summary>
	public partial class OrderRepository : IOrderRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		/// <summary>
        /// The constructor for OrderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OrderRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Order entity from the database using the OrderId primary key
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>IOrder</returns>
		public IOrder LoadByOrderId(int orderid)
		{
			return this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == orderid);
		}
		
        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">int</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByCustomerId(int customerid)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.CustomerId == customerid);
		}
		
        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderdate">DateTime</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByOrderDate(DateTime orderdate)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.OrderDate == orderdate);
		}
		
        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliverydate">DateTime</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByDeliveryDate(DateTime deliverydate)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.DeliveryDate == deliverydate);
		}
		
        /// <summary>
        /// Load Order entities from the database using the ShippingName field
        /// </summary>
        /// <param name="shippingname">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByShippingName(string shippingname)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingName == shippingname);
		}
		
        /// <summary>
        /// Load Order entities from the database using the ShippingAddress field
        /// </summary>
        /// <param name="shippingaddress">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByShippingAddress(string shippingaddress)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress == shippingaddress);
		}
		
        /// <summary>
        /// Load Order entities from the database using the ShippingCity field
        /// </summary>
        /// <param name="shippingcity">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByShippingCity(string shippingcity)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity == shippingcity);
		}
		
        /// <summary>
        /// Load Order entities from the database using the ShippingZip field
        /// </summary>
        /// <param name="shippingzip">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadByShippingZip(string shippingzip)
		{
			return (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip == shippingzip);
		}
		
        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> LoadAll()
		{
			return (IList<IOrder>)this.UnitOfWork.LoadAll<Order>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingname">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> SearchByShippingName(string shippingname, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.ToLower().Contains(shippingname.ToLower())) 
						  : (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingName.Contains(shippingname));
		}
		
        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingaddress">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> SearchByShippingAddress(string shippingaddress, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.ToLower().Contains(shippingaddress.ToLower())) 
						  : (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingAddress.Contains(shippingaddress));
		}
		
        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingcity">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> SearchByShippingCity(string shippingcity, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.ToLower().Contains(shippingcity.ToLower())) 
						  : (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingCity.Contains(shippingcity));
		}
		
        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingzip">string</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> SearchByShippingZip(string shippingzip, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.ToLower().Contains(shippingzip.ToLower())) 
						  : (IList<IOrder>)this.UnitOfWork.AllMatching<Order>(o => o.ShippingZip.Contains(shippingzip));
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool Save(IOrder entity)
		{
			var entityToSave = new Order(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool Update(IOrder entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == entity.OrderId);
			
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
		public bool Delete(IOrder entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == entity.OrderId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Order entity from the database using the OrderId
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByOrderId(int orderid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Order>(o => o.OrderId == orderid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Order entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
