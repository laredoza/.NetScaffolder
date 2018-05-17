
// <copyright file="Address_Audit.g.cs" company="MIT">
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
	/// The Address_AuditRepository class responsible for database functions in the Address_Audit table
	/// </summary>
	public partial class Address_AuditRepository : UowRepository<Address_Audit> , IAddress_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Address_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Address_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Address_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IAddress_Audit</returns>
		public virtual IAddress_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Address_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Id == id).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Stamp == stamp).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.UserName == username).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the Line1 field
        /// </summary>
        /// <param name="line1">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByLine1(string line1)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Line1 == line1).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the Line2 field
        /// </summary>
        /// <param name="line2">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByLine2(string line2)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Line2 == line2).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the Suburb field
        /// </summary>
        /// <param name="suburb">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadBySuburb(string suburb)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Suburb == suburb).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the City field
        /// </summary>
        /// <param name="city">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByCity(string city)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.City == city).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the PostalCode field
        /// </summary>
        /// <param name="postalcode">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByPostalCode(string postalcode)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.PostalCode == postalcode).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByType(Nullable<int> type)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Type == type).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the DefaultAddress field
        /// </summary>
        /// <param name="defaultaddress">Nullable<bool></param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByDefaultAddress(Nullable<bool> defaultaddress)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.DefaultAddress == defaultaddress).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the StateProvinceId field
        /// </summary>
        /// <param name="stateprovinceid">Nullable<int></param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByStateProvinceId(Nullable<int> stateprovinceid)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.StateProvinceId == stateprovinceid).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByCountryId(Nullable<int> countryid)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.CountryId == countryid).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load Address_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Address_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IAddress_Audit>();
		}
		
        /// <summary>
        /// Load all Address_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Address_Audit>().ToList<IAddress_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Address_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAddress_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.UserName.Contains(username)).ToList<IAddress_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Address_Audit entities in the database by Line1
        /// </summary>
        /// <param name="line1">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> SearchByLine1(string line1, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Line1.ToLower().Contains(line1.ToLower())).ToList<IAddress_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Line1.Contains(line1)).ToList<IAddress_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Address_Audit entities in the database by Line2
        /// </summary>
        /// <param name="line2">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> SearchByLine2(string line2, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Line2.ToLower().Contains(line2.ToLower())).ToList<IAddress_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Line2.Contains(line2)).ToList<IAddress_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Address_Audit entities in the database by Suburb
        /// </summary>
        /// <param name="suburb">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> SearchBySuburb(string suburb, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Suburb.ToLower().Contains(suburb.ToLower())).ToList<IAddress_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.Suburb.Contains(suburb)).ToList<IAddress_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Address_Audit entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> SearchByCity(string city, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.City.ToLower().Contains(city.ToLower())).ToList<IAddress_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.City.Contains(city)).ToList<IAddress_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Address_Audit entities in the database by PostalCode
        /// </summary>
        /// <param name="postalcode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		public virtual IList<IAddress_Audit> SearchByPostalCode(string postalcode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.PostalCode.ToLower().Contains(postalcode.ToLower())).ToList<IAddress_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Address_Audit>(o => o.PostalCode.Contains(postalcode)).ToList<IAddress_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Address_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAddress_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAddress_Audit entity)
		{
			var entityToSave = new Address_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Address_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAddress_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAddress_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Address_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Address_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
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
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Address_Audit entity from the database
        /// </summary>
        /// <param name="entity">IAddress_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAddress_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Address_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Address_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Address_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Address_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Address_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
