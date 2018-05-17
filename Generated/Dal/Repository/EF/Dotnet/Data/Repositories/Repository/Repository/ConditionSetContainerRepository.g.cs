
// <copyright file="ConditionSetContainer.g.cs" company="MIT">
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
	/// The ConditionSetContainerRepository class responsible for database functions in the ConditionSetContainer table
	/// </summary>
	public partial class ConditionSetContainerRepository : UowRepository<ConditionSetContainer> , IConditionSetContainerRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ConditionSetContainerRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ConditionSetContainerRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ConditionSetContainer entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IConditionSetContainer</returns>
		public virtual IConditionSetContainer LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ConditionSetContainer>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ConditionSetContainer entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IConditionSetContainer></returns>
		public virtual IList<IConditionSetContainer> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.Stamp == stamp).ToList<IConditionSetContainer>();
		}
		
        /// <summary>
        /// Load ConditionSetContainer entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IConditionSetContainer></returns>
		public virtual IList<IConditionSetContainer> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.UserName == username).ToList<IConditionSetContainer>();
		}
		
        /// <summary>
        /// Load ConditionSetContainer entities from the database using the ConditionSetXml field
        /// </summary>
        /// <param name="conditionsetxml">string</param>
        /// <returns>IList<IConditionSetContainer></returns>
		public virtual IList<IConditionSetContainer> LoadByConditionSetXml(string conditionsetxml)
		{
			return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.ConditionSetXml == conditionsetxml).ToList<IConditionSetContainer>();
		}
		
        /// <summary>
        /// Load all ConditionSetContainer entities from the database.
        /// </summary>
        /// <returns>IList<IConditionSetContainer></returns>
		public virtual IList<IConditionSetContainer> LoadAll()
		{
			return this.UnitOfWork.GetAll<ConditionSetContainer>().ToList<IConditionSetContainer>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ConditionSetContainer entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionSetContainer></returns>
		public virtual IList<IConditionSetContainer> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IConditionSetContainer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.UserName.Contains(username)).ToList<IConditionSetContainer>();
			}
		}
		
        /// <summary>
        /// Search for ConditionSetContainer entities in the database by ConditionSetXml
        /// </summary>
        /// <param name="conditionsetxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionSetContainer></returns>
		public virtual IList<IConditionSetContainer> SearchByConditionSetXml(string conditionsetxml, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.ConditionSetXml.ToLower().Contains(conditionsetxml.ToLower())).ToList<IConditionSetContainer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionSetContainer>(o => o.ConditionSetXml.Contains(conditionsetxml)).ToList<IConditionSetContainer>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ConditionSetContainer entity to the database.
        /// </summary>
        /// <param name="entity">IConditionSetContainer</param>
        /// <returns>bool</returns>
		public virtual bool Save(IConditionSetContainer entity)
		{
			var entityToSave = new ConditionSetContainer(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ConditionSetContainer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IConditionSetContainer</param>
        /// <returns>bool</returns>
		public virtual bool Update(IConditionSetContainer entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ConditionSetContainer>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ConditionSetContainer entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.ConditionSetXml != entity.ConditionSetXml) { entityToUpdate.ConditionSetXml = entity.ConditionSetXml;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ConditionSetContainer entity from the database
        /// </summary>
        /// <param name="entity">IConditionSetContainer</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IConditionSetContainer entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionSetContainer>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionSetContainer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ConditionSetContainer entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionSetContainer>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionSetContainer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
