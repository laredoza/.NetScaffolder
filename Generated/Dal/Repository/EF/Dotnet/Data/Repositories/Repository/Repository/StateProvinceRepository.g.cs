
// <copyright file="StateProvince.g.cs" company="MIT">
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
	/// The StateProvinceRepository class responsible for database functions in the StateProvince table
	/// </summary>
	public partial class StateProvinceRepository : UowRepository<StateProvince> , IStateProvinceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for StateProvinceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public StateProvinceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the StateProvince entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IStateProvince</returns>
		public virtual IStateProvince LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<StateProvince>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load StateProvince entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<StateProvince>(o => o.Stamp == stamp).ToList<IStateProvince>();
		}
		
        /// <summary>
        /// Load StateProvince entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<StateProvince>(o => o.UserName == username).ToList<IStateProvince>();
		}
		
        /// <summary>
        /// Load StateProvince entities from the database using the StateProvinceCode field
        /// </summary>
        /// <param name="stateprovincecode">string</param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadByStateProvinceCode(string stateprovincecode)
		{
			return this.UnitOfWork.AllMatching<StateProvince>(o => o.StateProvinceCode == stateprovincecode).ToList<IStateProvince>();
		}
		
        /// <summary>
        /// Load StateProvince entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<StateProvince>(o => o.Name == name).ToList<IStateProvince>();
		}
		
        /// <summary>
        /// Load StateProvince entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<StateProvince>(o => o.Status == status).ToList<IStateProvince>();
		}
		
        /// <summary>
        /// Load StateProvince entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadByCountryId(Nullable<int> countryid)
		{
			return this.UnitOfWork.AllMatching<StateProvince>(o => o.CountryId == countryid).ToList<IStateProvince>();
		}
		
        /// <summary>
        /// Load all StateProvince entities from the database.
        /// </summary>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> LoadAll()
		{
			return this.UnitOfWork.GetAll<StateProvince>().ToList<IStateProvince>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for StateProvince entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<StateProvince>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IStateProvince>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<StateProvince>(o => o.UserName.Contains(username)).ToList<IStateProvince>();
			}
		}
		
        /// <summary>
        /// Search for StateProvince entities in the database by StateProvinceCode
        /// </summary>
        /// <param name="stateprovincecode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> SearchByStateProvinceCode(string stateprovincecode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<StateProvince>(o => o.StateProvinceCode.ToLower().Contains(stateprovincecode.ToLower())).ToList<IStateProvince>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<StateProvince>(o => o.StateProvinceCode.Contains(stateprovincecode)).ToList<IStateProvince>();
			}
		}
		
        /// <summary>
        /// Search for StateProvince entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince></returns>
		public virtual IList<IStateProvince> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<StateProvince>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IStateProvince>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<StateProvince>(o => o.Name.Contains(name)).ToList<IStateProvince>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the StateProvince entity to the database.
        /// </summary>
        /// <param name="entity">IStateProvince</param>
        /// <returns>bool</returns>
		public virtual bool Save(IStateProvince entity)
		{
			var entityToSave = new StateProvince(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the StateProvince entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IStateProvince</param>
        /// <returns>bool</returns>
		public virtual bool Update(IStateProvince entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<StateProvince>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The StateProvince entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.StateProvinceCode != entity.StateProvinceCode) { entityToUpdate.StateProvinceCode = entity.StateProvinceCode;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.CountryId != entity.CountryId) { entityToUpdate.CountryId = entity.CountryId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the StateProvince entity from the database
        /// </summary>
        /// <param name="entity">IStateProvince</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IStateProvince entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<StateProvince>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The StateProvince entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the StateProvince entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<StateProvince>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The StateProvince entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
