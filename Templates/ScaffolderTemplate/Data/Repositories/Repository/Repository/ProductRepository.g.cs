
// <copyright file="Product.g.cs" company="Dot Net Scaffolder">
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
	/// The ProductRepository class responsible for database functions in the Product table
	/// </summary>
	public partial class ProductRepository : UowRepository<Product> , IProductRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Product entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IProduct</returns>
		public virtual IProduct LoadByProductId(int productId)
		{
			return this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == productId);
		}

        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadByUnitPrice(Nullable<decimal> unitPrice)
		{
			return this.UnitOfWork.AllMatching<Product>(o => o.UnitPrice == unitPrice).ToList<IProduct>();
		}

        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadByAmountInStock(Nullable<short> amountInStock)
		{
			return this.UnitOfWork.AllMatching<Product>(o => o.AmountInStock == amountInStock).ToList<IProduct>();
		}

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> LoadAll()
		{
			return this.UnitOfWork.GetAll<Product>().ToList<IProduct>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> SearchByProductDescription(string productDescription, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.Contains(productDescription)).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.ToLower().Contains(productDescription.ToLower())).ToList<IProduct>();
			}
		}

        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> SearchByUnitAmount(string unitAmount, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount.Contains(unitAmount)).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount.ToLower().Contains(unitAmount.ToLower())).ToList<IProduct>();
			}
		}

        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public virtual IList<IProduct> SearchByPublisher(string publisher, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.Publisher.Contains(publisher)).ToList<IProduct>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product>(o => o.Publisher.ToLower().Contains(publisher.ToLower())).ToList<IProduct>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProduct entity)
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
		
		#endregion
	}
}
