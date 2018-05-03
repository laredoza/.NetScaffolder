
// <copyright file="Product.g.cs" company="MIT">
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
        /// Load the Product entity from the database using the ProductId primary key
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>IProduct</returns>
		public IProduct LoadByProductId(int productid)
		{
			return this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == productid);
		}
		
        /// <summary>
        /// Load Product entities from the database using the ProductDescription field
        /// </summary>
        /// <param name="productdescription">string</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> LoadByProductDescription(string productdescription)
		{
			return (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription == productdescription);
		}
		
        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitprice">decimal</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> LoadByUnitPrice(decimal unitprice)
		{
			return (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.UnitPrice == unitprice);
		}
		
        /// <summary>
        /// Load Product entities from the database using the UnitAmount field
        /// </summary>
        /// <param name="unitamount">string</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> LoadByUnitAmount(string unitamount)
		{
			return (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount == unitamount);
		}
		
        /// <summary>
        /// Load Product entities from the database using the Publisher field
        /// </summary>
        /// <param name="publisher">string</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> LoadByPublisher(string publisher)
		{
			return (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.Publisher == publisher);
		}
		
        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountinstock">short</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> LoadByAmountInStock(short amountinstock)
		{
			return (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.AmountInStock == amountinstock);
		}
		
        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> LoadAll()
		{
			return (IList<IProduct>)this.UnitOfWork.GetAll<Product>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productdescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> SearchByProductDescription(string productdescription, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.ToLower().Contains(productdescription.ToLower())) 
						  : (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.ProductDescription.Contains(productdescription));
		}
		
        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitamount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> SearchByUnitAmount(string unitamount, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount.ToLower().Contains(unitamount.ToLower())) 
						  : (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.UnitAmount.Contains(unitamount));
		}
		
        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> SearchByPublisher(string publisher, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.Publisher.ToLower().Contains(publisher.ToLower())) 
						  : (IList<IProduct>)this.UnitOfWork.AllMatching<Product>(o => o.Publisher.Contains(publisher));
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool Save(IProduct entity)
		{
			var entityToSave = new Product(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool Update(IProduct entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == entity.ProductId);
			
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
		public bool Delete(IProduct entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == entity.ProductId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Product entity from the database using the ProductId
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByProductId(int productid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product>(o => o.ProductId == productid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
