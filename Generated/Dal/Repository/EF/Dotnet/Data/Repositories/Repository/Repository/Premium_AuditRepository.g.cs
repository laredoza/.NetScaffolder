
// <copyright file="Premium_Audit.g.cs" company="MIT">
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
	/// The Premium_AuditRepository class responsible for database functions in the Premium_Audit table
	/// </summary>
	public partial class Premium_AuditRepository : UowRepository<Premium_Audit> , IPremium_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Premium_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Premium_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Premium_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IPremium_Audit</returns>
		public virtual IPremium_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Premium_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.Id == id).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.Stamp == stamp).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.UserName == username).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the BasePremium field
        /// </summary>
        /// <param name="basepremium">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByBasePremium(Nullable<decimal> basepremium)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.BasePremium == basepremium).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the FinalPremium field
        /// </summary>
        /// <param name="finalpremium">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByFinalPremium(Nullable<decimal> finalpremium)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.FinalPremium == finalpremium).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the PercentageLoading field
        /// </summary>
        /// <param name="percentageloading">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByPercentageLoading(Nullable<decimal> percentageloading)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.PercentageLoading == percentageloading).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByPremiumProfileId(Nullable<int> premiumprofileid)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.PremiumProfileId == premiumprofileid).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.ProductId == productid).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load Premium_Audit entities from the database using the UnitLoading field
        /// </summary>
        /// <param name="unitloading">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadByUnitLoading(Nullable<decimal> unitloading)
		{
			return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.UnitLoading == unitloading).ToList<IPremium_Audit>();
		}
		
        /// <summary>
        /// Load all Premium_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Premium_Audit>().ToList<IPremium_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Premium_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremium_Audit></returns>
		public virtual IList<IPremium_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPremium_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Premium_Audit>(o => o.UserName.Contains(username)).ToList<IPremium_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Premium_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IPremium_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPremium_Audit entity)
		{
			var entityToSave = new Premium_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Premium_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPremium_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPremium_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Premium_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Premium_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.BasePremium != entity.BasePremium) { entityToUpdate.BasePremium = entity.BasePremium;doUpdate = true; }
			if (entityToUpdate.FinalPremium != entity.FinalPremium) { entityToUpdate.FinalPremium = entity.FinalPremium;doUpdate = true; }
			if (entityToUpdate.PercentageLoading != entity.PercentageLoading) { entityToUpdate.PercentageLoading = entity.PercentageLoading;doUpdate = true; }
			if (entityToUpdate.PremiumProfileId != entity.PremiumProfileId) { entityToUpdate.PremiumProfileId = entity.PremiumProfileId;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.UnitLoading != entity.UnitLoading) { entityToUpdate.UnitLoading = entity.UnitLoading;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Premium_Audit entity from the database
        /// </summary>
        /// <param name="entity">IPremium_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPremium_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Premium_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Premium_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Premium_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Premium_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Premium_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
