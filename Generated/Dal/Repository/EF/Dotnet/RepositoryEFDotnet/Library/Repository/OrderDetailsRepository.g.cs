
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
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
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
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the OrderDetails entity from the database using the OrderDetailsId primary key
        /// </summary>
        /// <param name="orderdetailsid">int</param>
        /// <returns>IOrderDetails</returns>
		public IOrderDetails LoadByOrderDetailsId(int orderdetailsid)
		{
			return this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == orderdetailsid);
		}
		
        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> LoadByOrderId(int orderid)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.OrderId == orderid).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> LoadByProductId(int productid)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.ProductId == productid).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitprice">decimal</param>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> LoadByUnitPrice(decimal unitprice)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.UnitPrice == unitprice).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">short</param>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> LoadByAmount(short amount)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Amount == amount).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">float</param>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> LoadByDiscount(float discount)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Discount == discount).ToList<IOrderDetails>();
		}
		
        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> LoadAll()
		{
			return this.UnitOfWork.GetAll<OrderDetails>().ToList<IOrderDetails>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool Save(IOrderDetails entity)
		{
			var entityToSave = new OrderDetails(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool Update(IOrderDetails entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == entity.OrderDetailsId);
			
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
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool Delete(IOrderDetails entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == entity.OrderDetailsId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the OrderDetails entity from the database using the OrderDetailsId
        /// </summary>
        /// <param name="orderdetailsid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByOrderDetailsId(int orderdetailsid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == orderdetailsid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OrderDetails entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
