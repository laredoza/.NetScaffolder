
// <copyright file="CustomerApplicantAttribute.g.cs" company="MIT">
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
	/// The CustomerApplicantAttributeRepository class responsible for database functions in the CustomerApplicantAttribute table
	/// </summary>
	public partial class CustomerApplicantAttributeRepository : UowRepository<CustomerApplicantAttribute> , ICustomerApplicantAttributeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CustomerApplicantAttributeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CustomerApplicantAttributeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CustomerApplicantAttribute entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICustomerApplicantAttribute</returns>
		public virtual ICustomerApplicantAttribute LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CustomerApplicantAttribute>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CustomerApplicantAttribute entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.Stamp == stamp).ToList<ICustomerApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CustomerApplicantAttribute entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.UserName == username).ToList<ICustomerApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CustomerApplicantAttribute entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> LoadByValue(string value)
		{
			return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.Value == value).ToList<ICustomerApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CustomerApplicantAttribute entities from the database using the ApplicantAttributeProfileId field
        /// </summary>
        /// <param name="applicantattributeprofileid">Nullable<int></param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> LoadByApplicantAttributeProfileId(Nullable<int> applicantattributeprofileid)
		{
			return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.ApplicantAttributeProfileId == applicantattributeprofileid).ToList<ICustomerApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CustomerApplicantAttribute entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">Nullable<int></param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> LoadByCustomerId(Nullable<int> customerid)
		{
			return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.CustomerId == customerid).ToList<ICustomerApplicantAttribute>();
		}
		
        /// <summary>
        /// Load all CustomerApplicantAttribute entities from the database.
        /// </summary>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> LoadAll()
		{
			return this.UnitOfWork.GetAll<CustomerApplicantAttribute>().ToList<ICustomerApplicantAttribute>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CustomerApplicantAttribute entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICustomerApplicantAttribute>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.UserName.Contains(username)).ToList<ICustomerApplicantAttribute>();
			}
		}
		
        /// <summary>
        /// Search for CustomerApplicantAttribute entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomerApplicantAttribute></returns>
		public virtual IList<ICustomerApplicantAttribute> SearchByValue(string value, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.Value.ToLower().Contains(value.ToLower())).ToList<ICustomerApplicantAttribute>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CustomerApplicantAttribute>(o => o.Value.Contains(value)).ToList<ICustomerApplicantAttribute>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CustomerApplicantAttribute entity to the database.
        /// </summary>
        /// <param name="entity">ICustomerApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICustomerApplicantAttribute entity)
		{
			var entityToSave = new CustomerApplicantAttribute(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CustomerApplicantAttribute entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomerApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICustomerApplicantAttribute entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CustomerApplicantAttribute>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CustomerApplicantAttribute entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }
			if (entityToUpdate.ApplicantAttributeProfileId != entity.ApplicantAttributeProfileId) { entityToUpdate.ApplicantAttributeProfileId = entity.ApplicantAttributeProfileId;doUpdate = true; }
			if (entityToUpdate.CustomerId != entity.CustomerId) { entityToUpdate.CustomerId = entity.CustomerId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CustomerApplicantAttribute entity from the database
        /// </summary>
        /// <param name="entity">ICustomerApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICustomerApplicantAttribute entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CustomerApplicantAttribute>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CustomerApplicantAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CustomerApplicantAttribute entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CustomerApplicantAttribute>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CustomerApplicantAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
