
// <copyright file="SectionDisclosure.g.cs" company="MIT">
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
	/// The SectionDisclosureRepository class responsible for database functions in the SectionDisclosure table
	/// </summary>
	public partial class SectionDisclosureRepository : UowRepository<SectionDisclosure> , ISectionDisclosureRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SectionDisclosureRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SectionDisclosureRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SectionDisclosure entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISectionDisclosure</returns>
		public virtual ISectionDisclosure LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SectionDisclosure>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SectionDisclosure entities from the database using the SectionId field
        /// </summary>
        /// <param name="sectionid">int</param>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadBySectionId(int sectionid)
		{
			return this.UnitOfWork.AllMatching<SectionDisclosure>(o => o.SectionId == sectionid).ToList<ISectionDisclosure>();
		}
		
        /// <summary>
        /// Load SectionDisclosure entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">int</param>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadBySetupTableDataId(int setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<SectionDisclosure>(o => o.SetupTableDataId == setuptabledataid).ToList<ISectionDisclosure>();
		}
		
        /// <summary>
        /// Load SectionDisclosure entities from the database using the AnswerOutcomeResultId field
        /// </summary>
        /// <param name="answeroutcomeresultid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadByAnswerOutcomeResultId(Nullable<int> answeroutcomeresultid)
		{
			return this.UnitOfWork.AllMatching<SectionDisclosure>(o => o.AnswerOutcomeResultId == answeroutcomeresultid).ToList<ISectionDisclosure>();
		}
		
        /// <summary>
        /// Load SectionDisclosure entities from the database using the ConditionOutcomeResultId field
        /// </summary>
        /// <param name="conditionoutcomeresultid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadByConditionOutcomeResultId(Nullable<int> conditionoutcomeresultid)
		{
			return this.UnitOfWork.AllMatching<SectionDisclosure>(o => o.ConditionOutcomeResultId == conditionoutcomeresultid).ToList<ISectionDisclosure>();
		}
		
        /// <summary>
        /// Load SectionDisclosure entities from the database using the VersionOutcomeResultId field
        /// </summary>
        /// <param name="versionoutcomeresultid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadByVersionOutcomeResultId(Nullable<int> versionoutcomeresultid)
		{
			return this.UnitOfWork.AllMatching<SectionDisclosure>(o => o.VersionOutcomeResultId == versionoutcomeresultid).ToList<ISectionDisclosure>();
		}
		
        /// <summary>
        /// Load SectionDisclosure entities from the database using the OutcomeGroupAttributeId field
        /// </summary>
        /// <param name="outcomegroupattributeid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadByOutcomeGroupAttributeId(Nullable<int> outcomegroupattributeid)
		{
			return this.UnitOfWork.AllMatching<SectionDisclosure>(o => o.OutcomeGroupAttributeId == outcomegroupattributeid).ToList<ISectionDisclosure>();
		}
		
        /// <summary>
        /// Load all SectionDisclosure entities from the database.
        /// </summary>
        /// <returns>IList<ISectionDisclosure></returns>
		public virtual IList<ISectionDisclosure> LoadAll()
		{
			return this.UnitOfWork.GetAll<SectionDisclosure>().ToList<ISectionDisclosure>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionDisclosure entity to the database.
        /// </summary>
        /// <param name="entity">ISectionDisclosure</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISectionDisclosure entity)
		{
			var entityToSave = new SectionDisclosure(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SectionDisclosure entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionDisclosure</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISectionDisclosure entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SectionDisclosure>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SectionDisclosure entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.SectionId != entity.SectionId) { entityToUpdate.SectionId = entity.SectionId;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
			if (entityToUpdate.AnswerOutcomeResultId != entity.AnswerOutcomeResultId) { entityToUpdate.AnswerOutcomeResultId = entity.AnswerOutcomeResultId;doUpdate = true; }
			if (entityToUpdate.ConditionOutcomeResultId != entity.ConditionOutcomeResultId) { entityToUpdate.ConditionOutcomeResultId = entity.ConditionOutcomeResultId;doUpdate = true; }
			if (entityToUpdate.VersionOutcomeResultId != entity.VersionOutcomeResultId) { entityToUpdate.VersionOutcomeResultId = entity.VersionOutcomeResultId;doUpdate = true; }
			if (entityToUpdate.OutcomeGroupAttributeId != entity.OutcomeGroupAttributeId) { entityToUpdate.OutcomeGroupAttributeId = entity.OutcomeGroupAttributeId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SectionDisclosure entity from the database
        /// </summary>
        /// <param name="entity">ISectionDisclosure</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISectionDisclosure entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionDisclosure>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionDisclosure entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SectionDisclosure entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionDisclosure>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionDisclosure entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
