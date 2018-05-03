
// <copyright file="Book.g.cs" company="MIT">
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
	/// The BookRepository class responsible for database functions in the Book table
	/// </summary>
	public partial class BookRepository : UowRepository<Book> , IBookRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BookRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BookRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Book entity from the database using the ProductId primary key
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>IBook</returns>
		public IBook LoadByProductId(int productid)
		{
			return this.UnitOfWork.FirstOrDefault<Book>(o => o.ProductId == productid);
		}
		
        /// <summary>
        /// Load Book entities from the database using the Publisher field
        /// </summary>
        /// <param name="publisher">string</param>
        /// <returns>IList<IBook></returns>
		public IList<IBook> LoadByPublisher(string publisher)
		{
			return (IList<IBook>)this.UnitOfWork.AllMatching<Book>(o => o.Publisher == publisher);
		}
		
        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <returns>IList<IBook></returns>
		public IList<IBook> LoadAll()
		{
			return (IList<IBook>)this.UnitOfWork.GetAll<Book>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBook></returns>
		public IList<IBook> SearchByPublisher(string publisher, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<IBook>)this.UnitOfWork.AllMatching<Book>(o => o.Publisher.ToLower().Contains(publisher.ToLower())) 
						  : (IList<IBook>)this.UnitOfWork.AllMatching<Book>(o => o.Publisher.Contains(publisher));
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool Save(IBook entity)
		{
			var entityToSave = new Book(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool Update(IBook entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Book>(o => o.ProductId == entity.ProductId);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Publisher != entity.Publisher) { entityToUpdate.Publisher = entity.Publisher;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool Delete(IBook entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Book>(o => o.ProductId == entity.ProductId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Book entity from the database using the ProductId
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByProductId(int productid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Book>(o => o.ProductId == productid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
