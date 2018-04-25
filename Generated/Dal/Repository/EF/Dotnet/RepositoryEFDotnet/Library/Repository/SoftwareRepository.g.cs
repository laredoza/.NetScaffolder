
// <copyright file="Software.g.cs" company="MIT">
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
	/// The SoftwareRepository class responsible for database functions in the Software table
	/// </summary>
	public partial class SoftwareRepository : ISoftwareRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		/// <summary>
        /// The constructor for SoftwareRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SoftwareRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Software entity from the database using the ProductId primary key
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>ISoftware</returns>
		public ISoftware LoadByProductId(int productid)
		{
			return this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == productid);
		}
		
        /// <summary>
        /// Load Software entities from the database using the LicenseCode field
        /// </summary>
        /// <param name="licensecode">string</param>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> LoadByLicenseCode(string licensecode)
		{
			return (IList<ISoftware>)this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode == licensecode);
		}
		
        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> LoadAll()
		{
			return (IList<ISoftware>)this.UnitOfWork.LoadAll<Software>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licensecode">string</param>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> SearchByLicenseCode(string licensecode, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ISoftware>)this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.ToLower().Contains(licensecode.ToLower())) 
						  : (IList<ISoftware>)this.UnitOfWork.AllMatching<Software>(o => o.LicenseCode.Contains(licensecode));
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool Save(ISoftware entity)
		{
			var entityToSave = new Software(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool Update(ISoftware entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == entity.ProductId);
			
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
		public bool Delete(ISoftware entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == entity.ProductId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Software entity from the database using the ProductId
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByProductId(int productid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Software>(o => o.ProductId == productid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Software entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
