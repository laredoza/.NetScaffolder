
// <copyright file="ConditionResultContainer.g.cs" company="MIT">
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
	/// The ConditionResultContainerRepository class responsible for database functions in the ConditionResultContainer table
	/// </summary>
	public partial class ConditionResultContainerRepository : UowRepository<ConditionResultContainer> , IConditionResultContainerRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ConditionResultContainerRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ConditionResultContainerRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ConditionResultContainer entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IConditionResultContainer</returns>
		public virtual IConditionResultContainer LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ConditionResultContainer>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ConditionResultContainer entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IConditionResultContainer></returns>
		public virtual IList<IConditionResultContainer> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.Stamp == stamp).ToList<IConditionResultContainer>();
		}
		
        /// <summary>
        /// Load ConditionResultContainer entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IConditionResultContainer></returns>
		public virtual IList<IConditionResultContainer> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.UserName == username).ToList<IConditionResultContainer>();
		}
		
        /// <summary>
        /// Load ConditionResultContainer entities from the database using the ConditionResultXml field
        /// </summary>
        /// <param name="conditionresultxml">string</param>
        /// <returns>IList<IConditionResultContainer></returns>
		public virtual IList<IConditionResultContainer> LoadByConditionResultXml(string conditionresultxml)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.ConditionResultXml == conditionresultxml).ToList<IConditionResultContainer>();
		}
		
        /// <summary>
        /// Load all ConditionResultContainer entities from the database.
        /// </summary>
        /// <returns>IList<IConditionResultContainer></returns>
		public virtual IList<IConditionResultContainer> LoadAll()
		{
			return this.UnitOfWork.GetAll<ConditionResultContainer>().ToList<IConditionResultContainer>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ConditionResultContainer entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionResultContainer></returns>
		public virtual IList<IConditionResultContainer> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IConditionResultContainer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.UserName.Contains(username)).ToList<IConditionResultContainer>();
			}
		}
		
        /// <summary>
        /// Search for ConditionResultContainer entities in the database by ConditionResultXml
        /// </summary>
        /// <param name="conditionresultxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionResultContainer></returns>
		public virtual IList<IConditionResultContainer> SearchByConditionResultXml(string conditionresultxml, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.ConditionResultXml.ToLower().Contains(conditionresultxml.ToLower())).ToList<IConditionResultContainer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer>(o => o.ConditionResultXml.Contains(conditionresultxml)).ToList<IConditionResultContainer>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ConditionResultContainer entity to the database.
        /// </summary>
        /// <param name="entity">IConditionResultContainer</param>
        /// <returns>bool</returns>
		public virtual bool Save(IConditionResultContainer entity)
		{
			var entityToSave = new ConditionResultContainer(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ConditionResultContainer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IConditionResultContainer</param>
        /// <returns>bool</returns>
		public virtual bool Update(IConditionResultContainer entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ConditionResultContainer>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ConditionResultContainer entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.ConditionResultXml != entity.ConditionResultXml) { entityToUpdate.ConditionResultXml = entity.ConditionResultXml;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ConditionResultContainer entity from the database
        /// </summary>
        /// <param name="entity">IConditionResultContainer</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IConditionResultContainer entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionResultContainer>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionResultContainer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ConditionResultContainer entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionResultContainer>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionResultContainer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
