
// <copyright file="ApplicantAttributeProfile.g.cs" company="MIT">
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
	/// The ApplicantAttributeProfileRepository class responsible for database functions in the ApplicantAttributeProfile table
	/// </summary>
	public partial class ApplicantAttributeProfileRepository : UowRepository<ApplicantAttributeProfile> , IApplicantAttributeProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ApplicantAttributeProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ApplicantAttributeProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ApplicantAttributeProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IApplicantAttributeProfile</returns>
		public virtual IApplicantAttributeProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ApplicantAttributeProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.Stamp == stamp).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.UserName == username).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.Name == name).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByType(Nullable<int> type)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.Type == type).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the AlsoForCustomer field
        /// </summary>
        /// <param name="alsoforcustomer">Nullable<bool></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByAlsoForCustomer(Nullable<bool> alsoforcustomer)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.AlsoForCustomer == alsoforcustomer).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<bool></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByStatus(Nullable<bool> status)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.Status == status).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the DisplayOnReport field
        /// </summary>
        /// <param name="displayonreport">Nullable<bool></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadByDisplayOnReport(Nullable<bool> displayonreport)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.DisplayOnReport == displayonreport).ToList<IApplicantAttributeProfile>();
		}
		
        /// <summary>
        /// Load all ApplicantAttributeProfile entities from the database.
        /// </summary>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<ApplicantAttributeProfile>().ToList<IApplicantAttributeProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ApplicantAttributeProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IApplicantAttributeProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.UserName.Contains(username)).ToList<IApplicantAttributeProfile>();
			}
		}
		
        /// <summary>
        /// Search for ApplicantAttributeProfile entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		public virtual IList<IApplicantAttributeProfile> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IApplicantAttributeProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ApplicantAttributeProfile>(o => o.Name.Contains(name)).ToList<IApplicantAttributeProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ApplicantAttributeProfile entity to the database.
        /// </summary>
        /// <param name="entity">IApplicantAttributeProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(IApplicantAttributeProfile entity)
		{
			var entityToSave = new ApplicantAttributeProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ApplicantAttributeProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApplicantAttributeProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(IApplicantAttributeProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ApplicantAttributeProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ApplicantAttributeProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Type != entity.Type) { entityToUpdate.Type = entity.Type;doUpdate = true; }
			if (entityToUpdate.AlsoForCustomer != entity.AlsoForCustomer) { entityToUpdate.AlsoForCustomer = entity.AlsoForCustomer;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.DisplayOnReport != entity.DisplayOnReport) { entityToUpdate.DisplayOnReport = entity.DisplayOnReport;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ApplicantAttributeProfile entity from the database
        /// </summary>
        /// <param name="entity">IApplicantAttributeProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IApplicantAttributeProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ApplicantAttributeProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApplicantAttributeProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ApplicantAttributeProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ApplicantAttributeProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApplicantAttributeProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
