﻿
// <copyright file="Software.g.cs" company="Dot Net Scaffolder">
//  Copyright (c) 2018 MIT License
// </copyright>  

 // Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in th
// e Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subj
// ect to the following conditions: The above copyright notice and this permission 
// notice shall be included in all copies or substantial portions of the Software. 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLI
// ED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR 
// A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYR
// IGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WIT
// H THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



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
	/// The SoftwareRepository class responsible for database functions in the Software table
	/// </summary>
	public partial class SoftwareRepository : UowRepository<Software> , ISoftwareRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SoftwareRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SoftwareRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Software entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>ISoftware</returns>
		public virtual ISoftware LoadByProductId(int productId)
		{
			return this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == productId);
		}

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <returns>IList<ISoftware></returns>
		public virtual IList<ISoftware> LoadAll()
		{
			return this.UnitOfWork.GetAll<Software>().ToList<ISoftware>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISoftware></returns>
		public virtual IList<ISoftware> SearchByLicenseCode(string licenseCode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.Contains(licenseCode)).ToList<ISoftware>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.ToLower().Contains(licenseCode.ToLower())).ToList<ISoftware>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISoftware entity)
		{
			var entityToSave = new Software(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.ProductId = entityToSave.ProductId;
			entity.LicenseCode = entityToSave.LicenseCode;
			
			return result;
		}

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISoftware entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == entity.ProductId );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.LicenseCode != entity.LicenseCode) { entityToUpdate.LicenseCode = entity.LicenseCode;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISoftware entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == entity.ProductId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int productId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Software>(o =>  o.ProductId == productId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}