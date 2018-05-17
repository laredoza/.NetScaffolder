
// <copyright file="Phone.g.cs" company="MIT">
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
	/// The PhoneRepository class responsible for database functions in the Phone table
	/// </summary>
	public partial class PhoneRepository : UowRepository<Phone> , IPhoneRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PhoneRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PhoneRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Phone entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPhone</returns>
		public virtual IPhone LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Phone>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Phone entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.Stamp == stamp).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.UserName == username).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the CountryCode field
        /// </summary>
        /// <param name="countrycode">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByCountryCode(Nullable<int> countrycode)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.CountryCode == countrycode).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the AreaCode field
        /// </summary>
        /// <param name="areacode">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByAreaCode(Nullable<int> areacode)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.AreaCode == areacode).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the Number field
        /// </summary>
        /// <param name="number">string</param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByNumber(string number)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.Number == number).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the Extension field
        /// </summary>
        /// <param name="extension">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByExtension(Nullable<int> extension)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.Extension == extension).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the FormattedNumber field
        /// </summary>
        /// <param name="formattednumber">string</param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByFormattedNumber(string formattednumber)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.FormattedNumber == formattednumber).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByType(Nullable<int> type)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.Type == type).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load Phone entities from the database using the DefaultPhone field
        /// </summary>
        /// <param name="defaultphone">Nullable<bool></param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadByDefaultPhone(Nullable<bool> defaultphone)
		{
			return this.UnitOfWork.AllMatching<Phone>(o => o.DefaultPhone == defaultphone).ToList<IPhone>();
		}
		
        /// <summary>
        /// Load all Phone entities from the database.
        /// </summary>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> LoadAll()
		{
			return this.UnitOfWork.GetAll<Phone>().ToList<IPhone>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Phone entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Phone>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPhone>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Phone>(o => o.UserName.Contains(username)).ToList<IPhone>();
			}
		}
		
        /// <summary>
        /// Search for Phone entities in the database by Number
        /// </summary>
        /// <param name="number">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> SearchByNumber(string number, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Phone>(o => o.Number.ToLower().Contains(number.ToLower())).ToList<IPhone>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Phone>(o => o.Number.Contains(number)).ToList<IPhone>();
			}
		}
		
        /// <summary>
        /// Search for Phone entities in the database by FormattedNumber
        /// </summary>
        /// <param name="formattednumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPhone></returns>
		public virtual IList<IPhone> SearchByFormattedNumber(string formattednumber, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Phone>(o => o.FormattedNumber.ToLower().Contains(formattednumber.ToLower())).ToList<IPhone>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Phone>(o => o.FormattedNumber.Contains(formattednumber)).ToList<IPhone>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Phone entity to the database.
        /// </summary>
        /// <param name="entity">IPhone</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPhone entity)
		{
			var entityToSave = new Phone(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Phone entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPhone</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPhone entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Phone>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Phone entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.CountryCode != entity.CountryCode) { entityToUpdate.CountryCode = entity.CountryCode;doUpdate = true; }
			if (entityToUpdate.AreaCode != entity.AreaCode) { entityToUpdate.AreaCode = entity.AreaCode;doUpdate = true; }
			if (entityToUpdate.Number != entity.Number) { entityToUpdate.Number = entity.Number;doUpdate = true; }
			if (entityToUpdate.Extension != entity.Extension) { entityToUpdate.Extension = entity.Extension;doUpdate = true; }
			if (entityToUpdate.FormattedNumber != entity.FormattedNumber) { entityToUpdate.FormattedNumber = entity.FormattedNumber;doUpdate = true; }
			if (entityToUpdate.Type != entity.Type) { entityToUpdate.Type = entity.Type;doUpdate = true; }
			if (entityToUpdate.DefaultPhone != entity.DefaultPhone) { entityToUpdate.DefaultPhone = entity.DefaultPhone;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Phone entity from the database
        /// </summary>
        /// <param name="entity">IPhone</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPhone entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Phone>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Phone entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Phone entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Phone>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Phone entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
