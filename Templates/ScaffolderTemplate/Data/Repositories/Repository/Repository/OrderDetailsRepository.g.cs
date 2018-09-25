﻿
// <copyright file="OrderDetails.g.cs" company="Dot Net Scaffolder">
//  Copyright (c) 2018 MIT License
// </copyright>  

 // Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in th
// e Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subj
// ect to the following conditions: The above copyright notice and this permission 
// notice shall be included in all copies or substantial portions of the Software. 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLI
// ED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR 
// A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYR
// IGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WIT
// H THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;

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
        /// Load OrderDetails entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <returns>IOrderDetails</returns>
		public virtual IOrderDetails LoadByOrderDetailsId(int orderDetailsId)
		{
			return this.UnitOfWork.FirstOrDefault<OrderDetails>(o => o.OrderDetailsId == orderDetailsId);
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByOrderId(int orderId)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.OrderId == orderId).ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByProductId(int productId)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.ProductId == productId).ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByUnitPrice(Nullable<decimal> unitPrice)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.UnitPrice == unitPrice).ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByAmount(Nullable<short> amount)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Amount == amount).ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadByDiscount(Nullable<float> discount)
		{
			return this.UnitOfWork.AllMatching<OrderDetails>(o => o.Discount == discount).ToList<IOrderDetails>();
		}

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <returns>IList<IOrderDetails></returns>
		public virtual IList<IOrderDetails> LoadAll()
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
		public virtual bool Save(IOrderDetails entity)
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
		
		#endregion
	}
}