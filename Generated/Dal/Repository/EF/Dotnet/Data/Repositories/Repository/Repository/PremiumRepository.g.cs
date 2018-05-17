
// <copyright file="Premium.g.cs" company="MIT">
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
	/// The PremiumRepository class responsible for database functions in the Premium table
	/// </summary>
	public partial class PremiumRepository : UowRepository<Premium> , IPremiumRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PremiumRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PremiumRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Premium entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPremium</returns>
		public virtual IPremium LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Premium>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Premium entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.Stamp == stamp).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.UserName == username).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the BasePremium field
        /// </summary>
        /// <param name="basepremium">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByBasePremium(Nullable<decimal> basepremium)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.BasePremium == basepremium).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the FinalPremium field
        /// </summary>
        /// <param name="finalpremium">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByFinalPremium(Nullable<decimal> finalpremium)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.FinalPremium == finalpremium).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the PercentageLoading field
        /// </summary>
        /// <param name="percentageloading">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByPercentageLoading(Nullable<decimal> percentageloading)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.PercentageLoading == percentageloading).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByPremiumProfileId(Nullable<int> premiumprofileid)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.PremiumProfileId == premiumprofileid).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.ProductId == productid).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the UserPremium field
        /// </summary>
        /// <param name="userpremium">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByUserPremium(Nullable<decimal> userpremium)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.UserPremium == userpremium).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByTypeOption(int typeoption)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.TypeOption == typeoption).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load Premium entities from the database using the UnitLoading field
        /// </summary>
        /// <param name="unitloading">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadByUnitLoading(Nullable<decimal> unitloading)
		{
			return this.UnitOfWork.AllMatching<Premium>(o => o.UnitLoading == unitloading).ToList<IPremium>();
		}
		
        /// <summary>
        /// Load all Premium entities from the database.
        /// </summary>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> LoadAll()
		{
			return this.UnitOfWork.GetAll<Premium>().ToList<IPremium>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Premium entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremium></returns>
		public virtual IList<IPremium> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Premium>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPremium>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Premium>(o => o.UserName.Contains(username)).ToList<IPremium>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Premium entity to the database.
        /// </summary>
        /// <param name="entity">IPremium</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPremium entity)
		{
			var entityToSave = new Premium(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Premium entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPremium</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPremium entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Premium>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Premium entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.BasePremium != entity.BasePremium) { entityToUpdate.BasePremium = entity.BasePremium;doUpdate = true; }
			if (entityToUpdate.FinalPremium != entity.FinalPremium) { entityToUpdate.FinalPremium = entity.FinalPremium;doUpdate = true; }
			if (entityToUpdate.PercentageLoading != entity.PercentageLoading) { entityToUpdate.PercentageLoading = entity.PercentageLoading;doUpdate = true; }
			if (entityToUpdate.PremiumProfileId != entity.PremiumProfileId) { entityToUpdate.PremiumProfileId = entity.PremiumProfileId;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.UserPremium != entity.UserPremium) { entityToUpdate.UserPremium = entity.UserPremium;doUpdate = true; }
			if (entityToUpdate.TypeOption != entity.TypeOption) { entityToUpdate.TypeOption = entity.TypeOption;doUpdate = true; }
			if (entityToUpdate.UnitLoading != entity.UnitLoading) { entityToUpdate.UnitLoading = entity.UnitLoading;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Premium entity from the database
        /// </summary>
        /// <param name="entity">IPremium</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPremium entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Premium>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Premium entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Premium entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Premium>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Premium entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
