
// <copyright file="Country.g.cs" company="MIT">
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
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Repository
{
	/// <summary>
	/// The CountryRepository class responsible for database functions in the Country table
	/// </summary>
	public partial class CountryRepository : UowRepository<ICountry> , ICountryRepository
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
        /// <returns>ICountry</returns>
		public virtual ICountry LoadByCountryId(int countryId, params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == countryId, expr);
		}
		
        /// <summary>
        /// Load Country entities async from the database using the composite primary keys
        /// </summary
        /// <param name="countryId">int</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>ICountry</returns>
		public virtual async Task<ICountry> LoadByCountryIdAsync(int countryId, params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Country>(o => o.CountryId == countryId, expr);
		}

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public virtual IList<ICountry> LoadAll(params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Country>(expr).ToList<ICountry>();
		}
		
        /// <summary>
        /// Load all Country entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public virtual async Task<IList<ICountry>> LoadAllAsync(params Expression<Func<ICountry, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Country>(expr);
			return result.ToList<ICountry>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public virtual IList<ICountry> SearchByCountryName(string countryName, bool caseSensitive = false, params Expression<Func<ICountry, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Country>(o => o.CountryName.Contains(countryName), expr).ToList<ICountry>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Country>(o => o.CountryName.ToLower().Contains(countryName.ToLower()), expr).ToList<ICountry>();
			}
		}
		
        /// <summary>
        /// Search for Country entities async in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public virtual async Task<IList<ICountry>> SearchByCountryNameAsync(string countryName, bool caseSensitive = false, params Expression<Func<ICountry, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Country>(o => o.CountryName.Contains(countryName), expr);
				return result.ToList<ICountry>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Country>(o => o.CountryName.ToLower().Contains(countryName.ToLower()), expr);
				return result.ToList<ICountry>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual bool Add(ICountry entity)
		{
			var entityToSave = new Country(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.CountryId = entityToSave.CountryId;
			entity.CountryName = entityToSave.CountryName;
			
			return result;
		}
		
        /// <summary>
        /// Add the Country entity async to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ICountry entity)
		{
			var entityToSave = new Country(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.CountryId = entityToSave.CountryId;
			entity.CountryName = entityToSave.CountryName;
			
			return result;
		}

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICountry entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Country>(o =>  o.CountryId == entity.CountryId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CountryName != entity.CountryName) { entityToUpdate.CountryName = entity.CountryName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the Country entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ICountry entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Country>(o =>  o.CountryId == entity.CountryId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CountryName != entity.CountryName) { entityToUpdate.CountryName = entity.CountryName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICountry entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Country>(o =>  o.CountryId == entity.CountryId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ICountry entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Country>(o =>  o.CountryId == entity.CountryId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int countryId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Country>(o =>  o.CountryId == countryId );
			
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
		public virtual async Task<bool> DeleteAsync( int countryId)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Country>(o =>  o.CountryId == countryId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<ICountry, TResult>> maxExpression)
		{
			return this.UnitOfWork.Max(Expression.Lambda<Func<Country, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression)
		{
			return await this.UnitOfWork.MaxAsync(Expression.Lambda<Func<Country, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<ICountry, TResult>> minExpression)
		{
			return this.UnitOfWork.Min(Expression.Lambda<Func<Country, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<ICountry, TResult>> minExpression)
		{
			return await this.UnitOfWork.MinAsync(Expression.Lambda<Func<Country, TResult>>(minExpression.Body, minExpression.Parameters));
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
