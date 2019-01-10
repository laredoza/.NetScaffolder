﻿
// <copyright file="Country.g.cs" company="MIT">
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
	/// The CountryRepository class responsible for database functions in the Country table
	/// </summary>
	public partial class CountryRepository : UowRepository<Country> , ICountryRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CountryRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CountryRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for CountryRepository
        /// </summary>
		public CountryRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Country entities from the database using the composite primary keys
        /// </summary
        /// <param name="countryId">int</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>Country</returns>
		public virtual Country LoadByCountryId(int countryId, bool cache, params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == countryId, cache, expr);
		}
		
        /// <summary>
        /// Load Country entities async from the database using the composite primary keys
        /// </summary
        /// <param name="countryId">int</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>Country</returns>
		public virtual async Task<Country> LoadByCountryIdAsync(int countryId, bool cache, params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Country>(cache, o => o.CountryId == countryId, expr);
		}

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<Country></returns>
		public virtual IList<Country> LoadAll(bool cache, params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Country>(cache, expr).ToList<Country>();
		}
		
        /// <summary>
        /// Load all Country entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<Country></returns>
		public virtual async Task<IList<Country>> LoadAllAsync(bool cache, params Expression<Func<ICountry,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Country>(cache, expr);
			return result.ToList<Country>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<Country></returns>
		public virtual IList<Country> SearchByCountryName(string countryName, bool cache, bool caseSensitive = false, params Expression<Func<ICountry, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Country>(o => o.CountryName.Contains(countryName), cache, expr).ToList<Country>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Country>(o => o.CountryName.ToLower().Contains(countryName.ToLower()), cache, expr).ToList<Country>();
			}
		}
		
        /// <summary>
        /// Search for Country entities async in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<Country></returns>
		public virtual async Task<IList<Country>> SearchByCountryNameAsync(string countryName, bool cache, bool caseSensitive = false, params Expression<Func<ICountry, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Country>(o => o.CountryName.Contains(countryName), cache, expr);
				return result.ToList<Country>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Country>(o => o.CountryName.ToLower().Contains(countryName.ToLower()), cache, expr);
				return result.ToList<Country>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">Country</param>
        /// <returns>bool</returns>
		public virtual bool Add(Country entity)
		{
			this.UnitOfWork.Add(entity);
			return this.UnitOfWork.Save();
		}
		
        /// <summary>
        /// Add the Country entity async to the database.
        /// </summary>
        /// <param name="entity">Country</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(Country entity)
		{
			await this.UnitOfWork.AddAsync(entity);
			return await this.UnitOfWork.SaveAsync();
		}

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Country</param>
        /// <returns>bool</returns>
		public virtual bool Update(Country entity)
		{
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the Country entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Country</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(Country entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">Country</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Country entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="entity">Country</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(Country entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int countryId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Country>(o =>  o.CountryId == countryId , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int countryId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Country>(cache, o =>  o.CountryId == countryId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Country, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<ICountry, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<ICountry, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Country, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<ICountry, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Country, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<Country> items)
		{
			this.UnitOfWork.BulkDelete<ICountry>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<Country> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<Country>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<Country> items)
		{
			this.UnitOfWork.BulkInsert<Country>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Country> items)
		{
			await this.UnitOfWork.BulkInsertAsync<Country>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<Country> items)
		{
			this.UnitOfWork.BulkUpdate<Country>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<Country> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<Country>(items);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<Country, object>>[] Convert(params Expression<Func<ICountry, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Country, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Country, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
