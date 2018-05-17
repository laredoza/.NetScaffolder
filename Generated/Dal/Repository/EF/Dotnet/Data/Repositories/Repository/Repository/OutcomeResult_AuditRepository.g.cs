
// <copyright file="OutcomeResult_Audit.g.cs" company="MIT">
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
	/// The OutcomeResult_AuditRepository class responsible for database functions in the OutcomeResult_Audit table
	/// </summary>
	public partial class OutcomeResult_AuditRepository : UowRepository<OutcomeResult_Audit> , IOutcomeResult_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for OutcomeResult_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OutcomeResult_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the OutcomeResult_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IOutcomeResult_Audit</returns>
		public virtual IOutcomeResult_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<OutcomeResult_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.Id == id).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.Stamp == stamp).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.UserName == username).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the HadEffect field
        /// </summary>
        /// <param name="hadeffect">Nullable<bool></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByHadEffect(Nullable<bool> hadeffect)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.HadEffect == hadeffect).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the EffectPercentageValue field
        /// </summary>
        /// <param name="effectpercentagevalue">Nullable<decimal></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByEffectPercentageValue(Nullable<decimal> effectpercentagevalue)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.EffectPercentageValue == effectpercentagevalue).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the EffectDescription field
        /// </summary>
        /// <param name="effectdescription">string</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByEffectDescription(string effectdescription)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.EffectDescription == effectdescription).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the OutcomeId field
        /// </summary>
        /// <param name="outcomeid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByOutcomeId(Nullable<int> outcomeid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.OutcomeId == outcomeid).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the PremiumId field
        /// </summary>
        /// <param name="premiumid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByPremiumId(Nullable<int> premiumid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.PremiumId == premiumid).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.PolicyId == policyid).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.UserId == userid).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeResult_Audit entities from the database using the EffectUnitValue field
        /// </summary>
        /// <param name="effectunitvalue">Nullable<decimal></param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadByEffectUnitValue(Nullable<decimal> effectunitvalue)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.EffectUnitValue == effectunitvalue).ToList<IOutcomeResult_Audit>();
		}
		
        /// <summary>
        /// Load all OutcomeResult_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<OutcomeResult_Audit>().ToList<IOutcomeResult_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for OutcomeResult_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IOutcomeResult_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.UserName.Contains(username)).ToList<IOutcomeResult_Audit>();
			}
		}
		
        /// <summary>
        /// Search for OutcomeResult_Audit entities in the database by EffectDescription
        /// </summary>
        /// <param name="effectdescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeResult_Audit></returns>
		public virtual IList<IOutcomeResult_Audit> SearchByEffectDescription(string effectdescription, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.EffectDescription.ToLower().Contains(effectdescription.ToLower())).ToList<IOutcomeResult_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<OutcomeResult_Audit>(o => o.EffectDescription.Contains(effectdescription)).ToList<IOutcomeResult_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OutcomeResult_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IOutcomeResult_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IOutcomeResult_Audit entity)
		{
			var entityToSave = new OutcomeResult_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the OutcomeResult_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOutcomeResult_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOutcomeResult_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<OutcomeResult_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The OutcomeResult_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.HadEffect != entity.HadEffect) { entityToUpdate.HadEffect = entity.HadEffect;doUpdate = true; }
			if (entityToUpdate.EffectPercentageValue != entity.EffectPercentageValue) { entityToUpdate.EffectPercentageValue = entity.EffectPercentageValue;doUpdate = true; }
			if (entityToUpdate.EffectDescription != entity.EffectDescription) { entityToUpdate.EffectDescription = entity.EffectDescription;doUpdate = true; }
			if (entityToUpdate.OutcomeId != entity.OutcomeId) { entityToUpdate.OutcomeId = entity.OutcomeId;doUpdate = true; }
			if (entityToUpdate.PremiumId != entity.PremiumId) { entityToUpdate.PremiumId = entity.PremiumId;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.EffectUnitValue != entity.EffectUnitValue) { entityToUpdate.EffectUnitValue = entity.EffectUnitValue;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the OutcomeResult_Audit entity from the database
        /// </summary>
        /// <param name="entity">IOutcomeResult_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOutcomeResult_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeResult_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeResult_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the OutcomeResult_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeResult_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeResult_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
