
// <copyright file="SetupTableData.g.cs" company="MIT">
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
	/// The SetupTableDataRepository class responsible for database functions in the SetupTableData table
	/// </summary>
	public partial class SetupTableDataRepository : UowRepository<SetupTableData> , ISetupTableDataRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SetupTableDataRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SetupTableDataRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SetupTableData entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISetupTableData</returns>
		public virtual ISetupTableData LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SetupTableData>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Stamp == stamp).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.UserName == username).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByTitle(string title)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Title == title).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Description == description).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the Code field
        /// </summary>
        /// <param name="code">string</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByCode(string code)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Code == code).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Status == status).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the Seq field
        /// </summary>
        /// <param name="seq">Nullable<int></param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadBySeq(Nullable<int> seq)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Seq == seq).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the SetupTableId field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadBySetupTableId(Nullable<int> setuptableid)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.SetupTableId == setuptableid).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentid">Nullable<int></param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByParentId(Nullable<int> parentid)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.ParentId == parentid).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load SetupTableData entities from the database using the FloatingIndex field
        /// </summary>
        /// <param name="floatingindex">Nullable<bool></param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadByFloatingIndex(Nullable<bool> floatingindex)
		{
			return this.UnitOfWork.AllMatching<SetupTableData>(o => o.FloatingIndex == floatingindex).ToList<ISetupTableData>();
		}
		
        /// <summary>
        /// Load all SetupTableData entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> LoadAll()
		{
			return this.UnitOfWork.GetAll<SetupTableData>().ToList<ISetupTableData>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SetupTableData entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISetupTableData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.UserName.Contains(username)).ToList<ISetupTableData>();
			}
		}
		
        /// <summary>
        /// Search for SetupTableData entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> SearchByTitle(string title, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Title.ToLower().Contains(title.ToLower())).ToList<ISetupTableData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Title.Contains(title)).ToList<ISetupTableData>();
			}
		}
		
        /// <summary>
        /// Search for SetupTableData entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<ISetupTableData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Description.Contains(description)).ToList<ISetupTableData>();
			}
		}
		
        /// <summary>
        /// Search for SetupTableData entities in the database by Code
        /// </summary>
        /// <param name="code">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData></returns>
		public virtual IList<ISetupTableData> SearchByCode(string code, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Code.ToLower().Contains(code.ToLower())).ToList<ISetupTableData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData>(o => o.Code.Contains(code)).ToList<ISetupTableData>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTableData entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTableData</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISetupTableData entity)
		{
			var entityToSave = new SetupTableData(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SetupTableData entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTableData</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISetupTableData entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SetupTableData>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SetupTableData entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Title != entity.Title) { entityToUpdate.Title = entity.Title;doUpdate = true; }
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.Code != entity.Code) { entityToUpdate.Code = entity.Code;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.Seq != entity.Seq) { entityToUpdate.Seq = entity.Seq;doUpdate = true; }
			if (entityToUpdate.SetupTableId != entity.SetupTableId) { entityToUpdate.SetupTableId = entity.SetupTableId;doUpdate = true; }
			if (entityToUpdate.ParentId != entity.ParentId) { entityToUpdate.ParentId = entity.ParentId;doUpdate = true; }
			if (entityToUpdate.FloatingIndex != entity.FloatingIndex) { entityToUpdate.FloatingIndex = entity.FloatingIndex;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SetupTableData entity from the database
        /// </summary>
        /// <param name="entity">ISetupTableData</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISetupTableData entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableData>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableData entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SetupTableData entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableData>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableData entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
