
// <copyright file="Doctor.g.cs" company="MIT">
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
	/// The DoctorRepository class responsible for database functions in the Doctor table
	/// </summary>
	public partial class DoctorRepository : UowRepository<Doctor> , IDoctorRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for DoctorRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public DoctorRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Doctor entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IDoctor</returns>
		public virtual IDoctor LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Doctor>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Doctor entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Doctor>(o => o.Stamp == stamp).ToList<IDoctor>();
		}
		
        /// <summary>
        /// Load Doctor entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Doctor>(o => o.UserName == username).ToList<IDoctor>();
		}
		
        /// <summary>
        /// Load Doctor entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<Doctor>(o => o.Surname == surname).ToList<IDoctor>();
		}
		
        /// <summary>
        /// Load Doctor entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadByFirstName(string firstname)
		{
			return this.UnitOfWork.AllMatching<Doctor>(o => o.FirstName == firstname).ToList<IDoctor>();
		}
		
        /// <summary>
        /// Load Doctor entities from the database using the AddressID field
        /// </summary>
        /// <param name="addressid">Nullable<int></param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadByAddressID(Nullable<int> addressid)
		{
			return this.UnitOfWork.AllMatching<Doctor>(o => o.AddressID == addressid).ToList<IDoctor>();
		}
		
        /// <summary>
        /// Load Doctor entities from the database using the PhoneId field
        /// </summary>
        /// <param name="phoneid">Nullable<int></param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadByPhoneId(Nullable<int> phoneid)
		{
			return this.UnitOfWork.AllMatching<Doctor>(o => o.PhoneId == phoneid).ToList<IDoctor>();
		}
		
        /// <summary>
        /// Load all Doctor entities from the database.
        /// </summary>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> LoadAll()
		{
			return this.UnitOfWork.GetAll<Doctor>().ToList<IDoctor>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Doctor entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Doctor>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IDoctor>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Doctor>(o => o.UserName.Contains(username)).ToList<IDoctor>();
			}
		}
		
        /// <summary>
        /// Search for Doctor entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Doctor>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<IDoctor>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Doctor>(o => o.Surname.Contains(surname)).ToList<IDoctor>();
			}
		}
		
        /// <summary>
        /// Search for Doctor entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor></returns>
		public virtual IList<IDoctor> SearchByFirstName(string firstname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Doctor>(o => o.FirstName.ToLower().Contains(firstname.ToLower())).ToList<IDoctor>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Doctor>(o => o.FirstName.Contains(firstname)).ToList<IDoctor>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Doctor entity to the database.
        /// </summary>
        /// <param name="entity">IDoctor</param>
        /// <returns>bool</returns>
		public virtual bool Save(IDoctor entity)
		{
			var entityToSave = new Doctor(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Doctor entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IDoctor</param>
        /// <returns>bool</returns>
		public virtual bool Update(IDoctor entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Doctor>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Doctor entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Surname != entity.Surname) { entityToUpdate.Surname = entity.Surname;doUpdate = true; }
			if (entityToUpdate.FirstName != entity.FirstName) { entityToUpdate.FirstName = entity.FirstName;doUpdate = true; }
			if (entityToUpdate.AddressID != entity.AddressID) { entityToUpdate.AddressID = entity.AddressID;doUpdate = true; }
			if (entityToUpdate.PhoneId != entity.PhoneId) { entityToUpdate.PhoneId = entity.PhoneId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Doctor entity from the database
        /// </summary>
        /// <param name="entity">IDoctor</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IDoctor entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Doctor>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Doctor entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Doctor entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Doctor>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Doctor entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
