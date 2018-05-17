
// <copyright file="Address.g.cs" company="MIT">
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
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The AddressRepository class responsible for database functions in the Address table
	/// </summary>
	public partial class AddressRepository : UowRepository<Address> , IAddressRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AddressRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AddressRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Address entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAddress</returns>
		public virtual IAddress LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Address>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Address entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.Stamp == stamp).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.UserName == username).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the Line1 field
        /// </summary>
        /// <param name="line1">string</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByLine1(string line1)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.Line1 == line1).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the Line2 field
        /// </summary>
        /// <param name="line2">string</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByLine2(string line2)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.Line2 == line2).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the Suburb field
        /// </summary>
        /// <param name="suburb">string</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadBySuburb(string suburb)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.Suburb == suburb).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the City field
        /// </summary>
        /// <param name="city">string</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByCity(string city)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.City == city).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the PostalCode field
        /// </summary>
        /// <param name="postalcode">string</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByPostalCode(string postalcode)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.PostalCode == postalcode).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByType(Nullable<int> type)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.Type == type).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the DefaultAddress field
        /// </summary>
        /// <param name="defaultaddress">Nullable<bool></param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByDefaultAddress(Nullable<bool> defaultaddress)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.DefaultAddress == defaultaddress).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the StateProvinceId field
        /// </summary>
        /// <param name="stateprovinceid">Nullable<int></param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByStateProvinceId(Nullable<int> stateprovinceid)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.StateProvinceId == stateprovinceid).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load Address entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadByCountryId(Nullable<int> countryid)
		{
			return this.UnitOfWork.AllMatching<Address>(o => o.CountryId == countryid).ToList<IAddress>();
		}
		
        /// <summary>
        /// Load all Address entities from the database.
        /// </summary>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> LoadAll()
		{
			return this.UnitOfWork.GetAll<Address>().ToList<IAddress>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Address entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAddress>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.UserName.Contains(username)).ToList<IAddress>();
			}
		}
		
        /// <summary>
        /// Search for Address entities in the database by Line1
        /// </summary>
        /// <param name="line1">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> SearchByLine1(string line1, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.Line1.ToLower().Contains(line1.ToLower())).ToList<IAddress>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.Line1.Contains(line1)).ToList<IAddress>();
			}
		}
		
        /// <summary>
        /// Search for Address entities in the database by Line2
        /// </summary>
        /// <param name="line2">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> SearchByLine2(string line2, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.Line2.ToLower().Contains(line2.ToLower())).ToList<IAddress>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.Line2.Contains(line2)).ToList<IAddress>();
			}
		}
		
        /// <summary>
        /// Search for Address entities in the database by Suburb
        /// </summary>
        /// <param name="suburb">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> SearchBySuburb(string suburb, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.Suburb.ToLower().Contains(suburb.ToLower())).ToList<IAddress>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.Suburb.Contains(suburb)).ToList<IAddress>();
			}
		}
		
        /// <summary>
        /// Search for Address entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> SearchByCity(string city, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.City.ToLower().Contains(city.ToLower())).ToList<IAddress>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.City.Contains(city)).ToList<IAddress>();
			}
		}
		
        /// <summary>
        /// Search for Address entities in the database by PostalCode
        /// </summary>
        /// <param name="postalcode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		public virtual IList<IAddress> SearchByPostalCode(string postalcode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.PostalCode.ToLower().Contains(postalcode.ToLower())).ToList<IAddress>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address>(o => o.PostalCode.Contains(postalcode)).ToList<IAddress>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Address entity to the database.
        /// </summary>
        /// <param name="entity">IAddress</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAddress entity)
		{
			var entityToSave = new Address(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Address entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAddress</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAddress entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Address>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Address entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Line1 != entity.Line1) { entityToUpdate.Line1 = entity.Line1;doUpdate = true; }
			if (entityToUpdate.Line2 != entity.Line2) { entityToUpdate.Line2 = entity.Line2;doUpdate = true; }
			if (entityToUpdate.Suburb != entity.Suburb) { entityToUpdate.Suburb = entity.Suburb;doUpdate = true; }
			if (entityToUpdate.City != entity.City) { entityToUpdate.City = entity.City;doUpdate = true; }
			if (entityToUpdate.PostalCode != entity.PostalCode) { entityToUpdate.PostalCode = entity.PostalCode;doUpdate = true; }
			if (entityToUpdate.Type != entity.Type) { entityToUpdate.Type = entity.Type;doUpdate = true; }
			if (entityToUpdate.DefaultAddress != entity.DefaultAddress) { entityToUpdate.DefaultAddress = entity.DefaultAddress;doUpdate = true; }
			if (entityToUpdate.StateProvinceId != entity.StateProvinceId) { entityToUpdate.StateProvinceId = entity.StateProvinceId;doUpdate = true; }
			if (entityToUpdate.CountryId != entity.CountryId) { entityToUpdate.CountryId = entity.CountryId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Address entity from the database
        /// </summary>
        /// <param name="entity">IAddress</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAddress entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Address>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Address entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Address entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Address>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Address entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
