
// <copyright file="OutcomeResult.g.cs" company="MIT">
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
	/// The OutcomeResultRepository class responsible for database functions in the OutcomeResult table
	/// </summary>
	public partial class OutcomeResultRepository : UowRepository<OutcomeResult> , IOutcomeResultRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for OutcomeResultRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OutcomeResultRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the OutcomeResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IOutcomeResult</returns>
		public virtual IOutcomeResult LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<OutcomeResult>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.Stamp == stamp).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.UserName == username).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the HadEffect field
        /// </summary>
        /// <param name="hadeffect">Nullable<bool></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByHadEffect(Nullable<bool> hadeffect)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.HadEffect == hadeffect).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the EffectPercentageValue field
        /// </summary>
        /// <param name="effectpercentagevalue">Nullable<decimal></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByEffectPercentageValue(Nullable<decimal> effectpercentagevalue)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.EffectPercentageValue == effectpercentagevalue).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the EffectDescription field
        /// </summary>
        /// <param name="effectdescription">string</param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByEffectDescription(string effectdescription)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.EffectDescription == effectdescription).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the OutcomeId field
        /// </summary>
        /// <param name="outcomeid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByOutcomeId(Nullable<int> outcomeid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.OutcomeId == outcomeid).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the PremiumId field
        /// </summary>
        /// <param name="premiumid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByPremiumId(Nullable<int> premiumid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.PremiumId == premiumid).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.PolicyId == policyid).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.UserId == userid).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByTypeOption(int typeoption)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.TypeOption == typeoption).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load OutcomeResult entities from the database using the EffectUnitValue field
        /// </summary>
        /// <param name="effectunitvalue">Nullable<decimal></param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadByEffectUnitValue(Nullable<decimal> effectunitvalue)
		{
			return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.EffectUnitValue == effectunitvalue).ToList<IOutcomeResult>();
		}
		
        /// <summary>
        /// Load all OutcomeResult entities from the database.
        /// </summary>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> LoadAll()
		{
			return this.UnitOfWork.GetAll<OutcomeResult>().ToList<IOutcomeResult>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for OutcomeResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IOutcomeResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.UserName.Contains(username)).ToList<IOutcomeResult>();
			}
		}
		
        /// <summary>
        /// Search for OutcomeResult entities in the database by EffectDescription
        /// </summary>
        /// <param name="effectdescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeResult></returns>
		public virtual IList<IOutcomeResult> SearchByEffectDescription(string effectdescription, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.EffectDescription.ToLower().Contains(effectdescription.ToLower())).ToList<IOutcomeResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<OutcomeResult>(o => o.EffectDescription.Contains(effectdescription)).ToList<IOutcomeResult>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OutcomeResult entity to the database.
        /// </summary>
        /// <param name="entity">IOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Save(IOutcomeResult entity)
		{
			var entityToSave = new OutcomeResult(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the OutcomeResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOutcomeResult entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<OutcomeResult>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The OutcomeResult entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.HadEffect != entity.HadEffect) { entityToUpdate.HadEffect = entity.HadEffect;doUpdate = true; }
			if (entityToUpdate.EffectPercentageValue != entity.EffectPercentageValue) { entityToUpdate.EffectPercentageValue = entity.EffectPercentageValue;doUpdate = true; }
			if (entityToUpdate.EffectDescription != entity.EffectDescription) { entityToUpdate.EffectDescription = entity.EffectDescription;doUpdate = true; }
			if (entityToUpdate.OutcomeId != entity.OutcomeId) { entityToUpdate.OutcomeId = entity.OutcomeId;doUpdate = true; }
			if (entityToUpdate.PremiumId != entity.PremiumId) { entityToUpdate.PremiumId = entity.PremiumId;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.TypeOption != entity.TypeOption) { entityToUpdate.TypeOption = entity.TypeOption;doUpdate = true; }
			if (entityToUpdate.EffectUnitValue != entity.EffectUnitValue) { entityToUpdate.EffectUnitValue = entity.EffectUnitValue;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the OutcomeResult entity from the database
        /// </summary>
        /// <param name="entity">IOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOutcomeResult entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeResult>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the OutcomeResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeResult>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
