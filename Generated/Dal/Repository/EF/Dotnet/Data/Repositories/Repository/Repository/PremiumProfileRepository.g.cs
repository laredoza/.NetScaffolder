
// <copyright file="PremiumProfile.g.cs" company="MIT">
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
	/// The PremiumProfileRepository class responsible for database functions in the PremiumProfile table
	/// </summary>
	public partial class PremiumProfileRepository : UowRepository<PremiumProfile> , IPremiumProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PremiumProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PremiumProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PremiumProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPremiumProfile</returns>
		public virtual IPremiumProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PremiumProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PremiumProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.Stamp == stamp).ToList<IPremiumProfile>();
		}
		
        /// <summary>
        /// Load PremiumProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.UserName == username).ToList<IPremiumProfile>();
		}
		
        /// <summary>
        /// Load PremiumProfile entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.Name == name).ToList<IPremiumProfile>();
		}
		
        /// <summary>
        /// Load PremiumProfile entities from the database using the ProductProfile field
        /// </summary>
        /// <param name="productprofile">Nullable<int></param>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> LoadByProductProfile(Nullable<int> productprofile)
		{
			return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.ProductProfile == productprofile).ToList<IPremiumProfile>();
		}
		
        /// <summary>
        /// Load all PremiumProfile entities from the database.
        /// </summary>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<PremiumProfile>().ToList<IPremiumProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PremiumProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPremiumProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.UserName.Contains(username)).ToList<IPremiumProfile>();
			}
		}
		
        /// <summary>
        /// Search for PremiumProfile entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremiumProfile></returns>
		public virtual IList<IPremiumProfile> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IPremiumProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PremiumProfile>(o => o.Name.Contains(name)).ToList<IPremiumProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PremiumProfile entity to the database.
        /// </summary>
        /// <param name="entity">IPremiumProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPremiumProfile entity)
		{
			var entityToSave = new PremiumProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PremiumProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPremiumProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPremiumProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PremiumProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PremiumProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.ProductProfile != entity.ProductProfile) { entityToUpdate.ProductProfile = entity.ProductProfile;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PremiumProfile entity from the database
        /// </summary>
        /// <param name="entity">IPremiumProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPremiumProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PremiumProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PremiumProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PremiumProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PremiumProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PremiumProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
