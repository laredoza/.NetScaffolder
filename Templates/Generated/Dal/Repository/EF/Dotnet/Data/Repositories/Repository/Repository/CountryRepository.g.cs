
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
using Banking.Models.Interfaces;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Repository
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
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Country entities from the database using the composite primary keys
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>ICountry</returns>
		public virtual ICountry LoadByCountryId(int countryId)
		{
			return this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == countryId);
		}

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <returns>IList<ICountry></returns>
		public virtual IList<ICountry> LoadAll()
		{
			return this.UnitOfWork.GetAll<Country>().ToList<ICountry>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountry></returns>
		public virtual IList<ICountry> SearchByCountryName(string countryName, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Country>(o => o.CountryName.Contains(countryName)).ToList<ICountry>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Country>(o => o.CountryName.ToLower().Contains(countryName.ToLower())).ToList<ICountry>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICountry entity)
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
		
		#endregion
	}
}
