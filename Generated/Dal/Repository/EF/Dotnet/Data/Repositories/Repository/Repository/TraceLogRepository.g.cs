
// <copyright file="TraceLog.g.cs" company="MIT">
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
	/// The TraceLogRepository class responsible for database functions in the TraceLog table
	/// </summary>
	public partial class TraceLogRepository : UowRepository<TraceLog> , ITraceLogRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for TraceLogRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public TraceLogRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the TraceLog entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ITraceLog</returns>
		public virtual ITraceLog LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<TraceLog>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load TraceLog entities from the database using the Category field
        /// </summary>
        /// <param name="category">string</param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> LoadByCategory(string category)
		{
			return this.UnitOfWork.AllMatching<TraceLog>(o => o.Category == category).ToList<ITraceLog>();
		}
		
        /// <summary>
        /// Load TraceLog entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> LoadByMessage(string message)
		{
			return this.UnitOfWork.AllMatching<TraceLog>(o => o.Message == message).ToList<ITraceLog>();
		}
		
        /// <summary>
        /// Load TraceLog entities from the database using the TimeStamp field
        /// </summary>
        /// <param name="timestamp">Nullable<DateTime></param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> LoadByTimeStamp(Nullable<DateTime> timestamp)
		{
			return this.UnitOfWork.AllMatching<TraceLog>(o => o.TimeStamp == timestamp).ToList<ITraceLog>();
		}
		
        /// <summary>
        /// Load TraceLog entities from the database using the StringStamp field
        /// </summary>
        /// <param name="stringstamp">string</param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> LoadByStringStamp(string stringstamp)
		{
			return this.UnitOfWork.AllMatching<TraceLog>(o => o.StringStamp == stringstamp).ToList<ITraceLog>();
		}
		
        /// <summary>
        /// Load all TraceLog entities from the database.
        /// </summary>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> LoadAll()
		{
			return this.UnitOfWork.GetAll<TraceLog>().ToList<ITraceLog>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for TraceLog entities in the database by Category
        /// </summary>
        /// <param name="category">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> SearchByCategory(string category, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<TraceLog>(o => o.Category.ToLower().Contains(category.ToLower())).ToList<ITraceLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<TraceLog>(o => o.Category.Contains(category)).ToList<ITraceLog>();
			}
		}
		
        /// <summary>
        /// Search for TraceLog entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> SearchByMessage(string message, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<TraceLog>(o => o.Message.ToLower().Contains(message.ToLower())).ToList<ITraceLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<TraceLog>(o => o.Message.Contains(message)).ToList<ITraceLog>();
			}
		}
		
        /// <summary>
        /// Search for TraceLog entities in the database by StringStamp
        /// </summary>
        /// <param name="stringstamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ITraceLog></returns>
		public virtual IList<ITraceLog> SearchByStringStamp(string stringstamp, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<TraceLog>(o => o.StringStamp.ToLower().Contains(stringstamp.ToLower())).ToList<ITraceLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<TraceLog>(o => o.StringStamp.Contains(stringstamp)).ToList<ITraceLog>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the TraceLog entity to the database.
        /// </summary>
        /// <param name="entity">ITraceLog</param>
        /// <returns>bool</returns>
		public virtual bool Save(ITraceLog entity)
		{
			var entityToSave = new TraceLog(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the TraceLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ITraceLog</param>
        /// <returns>bool</returns>
		public virtual bool Update(ITraceLog entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<TraceLog>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The TraceLog entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Category != entity.Category) { entityToUpdate.Category = entity.Category;doUpdate = true; }
			if (entityToUpdate.Message != entity.Message) { entityToUpdate.Message = entity.Message;doUpdate = true; }
			if (entityToUpdate.TimeStamp != entity.TimeStamp) { entityToUpdate.TimeStamp = entity.TimeStamp;doUpdate = true; }
			if (entityToUpdate.StringStamp != entity.StringStamp) { entityToUpdate.StringStamp = entity.StringStamp;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the TraceLog entity from the database
        /// </summary>
        /// <param name="entity">ITraceLog</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ITraceLog entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<TraceLog>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The TraceLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the TraceLog entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<TraceLog>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The TraceLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
