
// <copyright file="VersionSection.g.cs" company="MIT">
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
	/// The VersionSectionRepository class responsible for database functions in the VersionSection table
	/// </summary>
	public partial class VersionSectionRepository : UowRepository<VersionSection> , IVersionSectionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionSectionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionSectionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VersionSection entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionSection</returns>
		public virtual IVersionSection LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<VersionSection>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load VersionSection entities from the database using the VersionLocked field
        /// </summary>
        /// <param name="versionlocked">Nullable<bool></param>
        /// <returns>IList<IVersionSection></returns>
		public virtual IList<IVersionSection> LoadByVersionLocked(Nullable<bool> versionlocked)
		{
			return this.UnitOfWork.AllMatching<VersionSection>(o => o.VersionLocked == versionlocked).ToList<IVersionSection>();
		}
		
        /// <summary>
        /// Load VersionSection entities from the database using the ProfileVersionId field
        /// </summary>
        /// <param name="profileversionid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		public virtual IList<IVersionSection> LoadByProfileVersionId(Nullable<int> profileversionid)
		{
			return this.UnitOfWork.AllMatching<VersionSection>(o => o.ProfileVersionId == profileversionid).ToList<IVersionSection>();
		}
		
        /// <summary>
        /// Load VersionSection entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		public virtual IList<IVersionSection> LoadBySectionProfileId(Nullable<int> sectionprofileid)
		{
			return this.UnitOfWork.AllMatching<VersionSection>(o => o.SectionProfileId == sectionprofileid).ToList<IVersionSection>();
		}
		
        /// <summary>
        /// Load VersionSection entities from the database using the ParentVersionSectionId field
        /// </summary>
        /// <param name="parentversionsectionid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		public virtual IList<IVersionSection> LoadByParentVersionSectionId(Nullable<int> parentversionsectionid)
		{
			return this.UnitOfWork.AllMatching<VersionSection>(o => o.ParentVersionSectionId == parentversionsectionid).ToList<IVersionSection>();
		}
		
        /// <summary>
        /// Load VersionSection entities from the database using the SequenceId field
        /// </summary>
        /// <param name="sequenceid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		public virtual IList<IVersionSection> LoadBySequenceId(Nullable<int> sequenceid)
		{
			return this.UnitOfWork.AllMatching<VersionSection>(o => o.SequenceId == sequenceid).ToList<IVersionSection>();
		}
		
        /// <summary>
        /// Load all VersionSection entities from the database.
        /// </summary>
        /// <returns>IList<IVersionSection></returns>
		public virtual IList<IVersionSection> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionSection>().ToList<IVersionSection>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionSection entity to the database.
        /// </summary>
        /// <param name="entity">IVersionSection</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionSection entity)
		{
			var entityToSave = new VersionSection(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VersionSection entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionSection</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVersionSection entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VersionSection>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VersionSection entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.VersionLocked != entity.VersionLocked) { entityToUpdate.VersionLocked = entity.VersionLocked;doUpdate = true; }
			if (entityToUpdate.ProfileVersionId != entity.ProfileVersionId) { entityToUpdate.ProfileVersionId = entity.ProfileVersionId;doUpdate = true; }
			if (entityToUpdate.SectionProfileId != entity.SectionProfileId) { entityToUpdate.SectionProfileId = entity.SectionProfileId;doUpdate = true; }
			if (entityToUpdate.ParentVersionSectionId != entity.ParentVersionSectionId) { entityToUpdate.ParentVersionSectionId = entity.ParentVersionSectionId;doUpdate = true; }
			if (entityToUpdate.SequenceId != entity.SequenceId) { entityToUpdate.SequenceId = entity.SequenceId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VersionSection entity from the database
        /// </summary>
        /// <param name="entity">IVersionSection</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVersionSection entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionSection>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionSection entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VersionSection entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionSection>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionSection entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
