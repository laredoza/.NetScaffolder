
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Banking.Models.Interfaces;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The BookRepository class responsible for database functions in the Book table
	/// </summary>
	public partial class BookRepository : UowRepository<IBook> , IBookRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BookRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BookRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for BookRepository
        /// </summary>
		public BookRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Book entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		public virtual IBook LoadByProductId(int productId, params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Book>(o => o.ProductId == productId, expr);
		}
		
        /// <summary>
        /// Load Book entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		public virtual async Task<IBook> LoadByProductIdAsync(int productId, params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Book>(o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public virtual IList<IBook> LoadAll(params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Book>(expr).ToList<IBook>();
		}
		
        /// <summary>
        /// Load all Book entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public virtual async Task<IList<IBook>> LoadAllAsync(params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Book>(expr);
			return result.ToList<IBook>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public virtual IList<IBook> SearchByPublisher(string publisher, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Book>(o => o.Publisher.Contains(publisher), expr).ToList<IBook>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Book>(o => o.Publisher.ToLower().Contains(publisher.ToLower()), expr).ToList<IBook>();
			}
		}
		
        /// <summary>
        /// Search for Book entities async in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public virtual async Task<IList<IBook>> SearchByPublisherAsync(string publisher, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Book>(o => o.Publisher.Contains(publisher), expr);
				return result.ToList<IBook>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Book>(o => o.Publisher.ToLower().Contains(publisher.ToLower()), expr);
				return result.ToList<IBook>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public virtual bool Add(IBook entity)
		{
			var entityToSave = new Book(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.Publisher = entityToSave.Publisher;
			
			return result;
		}
		
        /// <summary>
        /// Add the Book entity async to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(IBook entity)
		{
			var entityToSave = new Book(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.Publisher = entityToSave.Publisher;
			
			return result;
		}

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public virtual bool Update(IBook entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Book>(o =>  o.ProductId == entity.ProductId );
			
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
        /// Update the Book entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(IBook entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Book>(o =>  o.ProductId == entity.ProductId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Publisher != entity.Publisher) { entityToUpdate.Publisher = entity.Publisher;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IBook entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Book>(o =>  o.ProductId == entity.ProductId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(IBook entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Book>(o =>  o.ProductId == entity.ProductId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int productId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Book>(o =>  o.ProductId == productId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int productId)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Book>(o =>  o.ProductId == productId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IBook, TResult>> maxExpression)
		{
			return this.UnitOfWork.Max(Expression.Lambda<Func<Book, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression)
		{
			return await this.UnitOfWork.MaxAsync(Expression.Lambda<Func<Book, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IBook, TResult>> minExpression)
		{
			return this.UnitOfWork.Min(Expression.Lambda<Func<Book, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IBook, TResult>> minExpression)
		{
			return await this.UnitOfWork.MinAsync(Expression.Lambda<Func<Book, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Helpers
		
	    protected virtual Expression<Func<Book, object>>[] Convert(params Expression<Func<IBook, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Book, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Book, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
