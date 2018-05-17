
// <copyright file="CountryProvince.g.cs" company="MIT">
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
	/// The CountryProvinceRepository class responsible for database functions in the CountryProvince table
	/// </summary>
	public partial class CountryProvinceRepository : UowRepository<CountryProvince> , ICountryProvinceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CountryProvinceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CountryProvinceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CountryProvince entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICountryProvince</returns>
		public virtual ICountryProvince LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CountryProvince>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CountryProvince entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Stamp == stamp).ToList<ICountryProvince>();
		}
		
        /// <summary>
        /// Load CountryProvince entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CountryProvince>(o => o.UserName == username).ToList<ICountryProvince>();
		}
		
        /// <summary>
        /// Load CountryProvince entities from the database using the Code field
        /// </summary>
        /// <param name="code">string</param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadByCode(string code)
		{
			return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Code == code).ToList<ICountryProvince>();
		}
		
        /// <summary>
        /// Load CountryProvince entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Name == name).ToList<ICountryProvince>();
		}
		
        /// <summary>
        /// Load CountryProvince entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Status == status).ToList<ICountryProvince>();
		}
		
        /// <summary>
        /// Load CountryProvince entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentid">Nullable<int></param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadByParentId(Nullable<int> parentid)
		{
			return this.UnitOfWork.AllMatching<CountryProvince>(o => o.ParentId == parentid).ToList<ICountryProvince>();
		}
		
        /// <summary>
        /// Load all CountryProvince entities from the database.
        /// </summary>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> LoadAll()
		{
			return this.UnitOfWork.GetAll<CountryProvince>().ToList<ICountryProvince>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CountryProvince entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CountryProvince>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICountryProvince>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CountryProvince>(o => o.UserName.Contains(username)).ToList<ICountryProvince>();
			}
		}
		
        /// <summary>
        /// Search for CountryProvince entities in the database by Code
        /// </summary>
        /// <param name="code">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> SearchByCode(string code, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Code.ToLower().Contains(code.ToLower())).ToList<ICountryProvince>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Code.Contains(code)).ToList<ICountryProvince>();
			}
		}
		
        /// <summary>
        /// Search for CountryProvince entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince></returns>
		public virtual IList<ICountryProvince> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<ICountryProvince>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CountryProvince>(o => o.Name.Contains(name)).ToList<ICountryProvince>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CountryProvince entity to the database.
        /// </summary>
        /// <param name="entity">ICountryProvince</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICountryProvince entity)
		{
			var entityToSave = new CountryProvince(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CountryProvince entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountryProvince</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICountryProvince entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CountryProvince>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CountryProvince entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Code != entity.Code) { entityToUpdate.Code = entity.Code;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.ParentId != entity.ParentId) { entityToUpdate.ParentId = entity.ParentId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CountryProvince entity from the database
        /// </summary>
        /// <param name="entity">ICountryProvince</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICountryProvince entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CountryProvince>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CountryProvince entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CountryProvince entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CountryProvince>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CountryProvince entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
