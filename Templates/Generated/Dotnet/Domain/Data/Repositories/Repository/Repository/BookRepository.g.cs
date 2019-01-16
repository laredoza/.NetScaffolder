
// <copyright file="Book.g.cs" company="MIT">
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
        /// <returns>Book</returns>
		public virtual Book LoadByProductId(int productId, bool cache, params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Book>(o => o.ProductId == productId, cache, expr);
		}
		
        /// <summary>
        /// Load Book entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>Book</returns>
		public virtual async Task<Book> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Book>(cache, o => o.ProductId == productId, expr);
		}

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<Book></returns>
		public virtual IList<Book> LoadAll(bool cache, params Expression<Func<IBook, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Book>(cache, expr).ToList<Book>();
		}
		
        /// <summary>
        /// Load all Book entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<Book></returns>
		public virtual async Task<IList<Book>> LoadAllAsync(bool cache, params Expression<Func<IBook,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Book>(cache, expr);
			return result.ToList<Book>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<Book></returns>
		public virtual IList<Book> SearchByPublisher(string publisher, bool cache, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Book>(o => o.Publisher.Contains(publisher), cache, expr).ToList<Book>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Book>(o => o.Publisher.ToLower().Contains(publisher.ToLower()), cache, expr).ToList<Book>();
			}
		}
		
        /// <summary>
        /// Search for Book entities async in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<Book></returns>
		public virtual async Task<IList<Book>> SearchByPublisherAsync(string publisher, bool cache, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Book>(o => o.Publisher.Contains(publisher), cache, expr);
				return result.ToList<Book>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Book>(o => o.Publisher.ToLower().Contains(publisher.ToLower()), cache, expr);
				return result.ToList<Book>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">Book</param>
        /// <returns>bool</returns>
		public virtual bool Add(Book entity)
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
        /// <param name="entity">Book</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(Book entity)
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
        /// <param name="entity">Book</param>
        /// <returns>bool</returns>
		public virtual bool Update(Book entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Book>(o =>  o.ProductId == entity.ProductId , true);
			
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
        /// <param name="entity">Book</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(Book entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Book>(true, o =>  o.ProductId == entity.ProductId );
			
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
        /// <param name="entity">Book</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Book entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Book>(o =>  o.ProductId == entity.ProductId , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="entity">Book</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(Book entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Book>(true, o =>  o.ProductId == entity.ProductId );
			
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
		public virtual bool Delete( int productId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Book>(o =>  o.ProductId == productId , cache);
			
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
		public virtual async Task<bool> DeleteAsync( int productId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Book>(cache, o =>  o.ProductId == productId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Book entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Book, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IBook, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IBook, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Book, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IBook, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Book, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<Book> items)
		{
			this.UnitOfWork.BulkDelete<IBook>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<Book> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<Book>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<Book> items)
		{
			this.UnitOfWork.BulkInsert<Book>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Book> items)
		{
			await this.UnitOfWork.BulkInsertAsync<Book>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<Book> items)
		{
			this.UnitOfWork.BulkUpdate<Book>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<Book> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<Book>(items);
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
