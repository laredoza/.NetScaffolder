
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
using RepositoryEFDotnet.Library;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The CountryRepository class responsible for database functions in the Country table
	/// </summary>
	public partial class CountryRepository : ICountryRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		/// <summary>
        /// The constructor for CountryRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CountryRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Country entity from the database using the CountryId primary key
        /// </summary>
        /// <param name="countryid">int</param>
        /// <returns>ICountry</returns>
		public ICountry LoadByCountryId(int countryid)
		{
			return this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == countryid);
		}
		
        /// <summary>
        /// Load Country entities from the database using the CountryName field
        /// </summary>
        /// <param name="countryname">string</param>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> LoadByCountryName(string countryname)
		{
			return (IList<ICountry>)this.UnitOfWork.AllMatching<Country>(o => o.CountryName == countryname);
		}
		
        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> LoadAll()
		{
			return (IList<ICountry>)this.UnitOfWork.LoadAll<Country>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryname">string</param>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> SearchByCountryName(string countryname, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICountry>)this.UnitOfWork.AllMatching<Country>(o => o.CountryName.ToLower().Contains(countryname.ToLower())) 
						  : (IList<ICountry>)this.UnitOfWork.AllMatching<Country>(o => o.CountryName.Contains(countryname));
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool Save(ICountry entity)
		{
			var entityToSave = new Country(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool Update(ICountry entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == entity.CountryId);
			
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
		public bool Delete(ICountry entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == entity.CountryId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Country entity from the database using the CountryId
        /// </summary>
        /// <param name="countryid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByCountryId(int countryid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Country>(o => o.CountryId == countryid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Country entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
