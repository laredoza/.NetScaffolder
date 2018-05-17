
// <copyright file="Email.g.cs" company="MIT">
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
	/// The EmailRepository class responsible for database functions in the Email table
	/// </summary>
	public partial class EmailRepository : UowRepository<Email> , IEmailRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for EmailRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public EmailRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Email entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IEmail</returns>
		public virtual IEmail LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Email>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Email entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.Stamp == stamp).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.UserName == username).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the EmailFrom field
        /// </summary>
        /// <param name="emailfrom">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByEmailFrom(string emailfrom)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.EmailFrom == emailfrom).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the EmailTo field
        /// </summary>
        /// <param name="emailto">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByEmailTo(string emailto)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.EmailTo == emailto).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the EmailSubject field
        /// </summary>
        /// <param name="emailsubject">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByEmailSubject(string emailsubject)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.EmailSubject == emailsubject).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the EmailBody field
        /// </summary>
        /// <param name="emailbody">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByEmailBody(string emailbody)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.EmailBody == emailbody).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the ProcessedDate field
        /// </summary>
        /// <param name="processeddate">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByProcessedDate(string processeddate)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.ProcessedDate == processeddate).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.Status == status).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load Email entities from the database using the Information field
        /// </summary>
        /// <param name="information">string</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadByInformation(string information)
		{
			return this.UnitOfWork.AllMatching<Email>(o => o.Information == information).ToList<IEmail>();
		}
		
        /// <summary>
        /// Load all Email entities from the database.
        /// </summary>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> LoadAll()
		{
			return this.UnitOfWork.GetAll<Email>().ToList<IEmail>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Email entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.UserName.Contains(username)).ToList<IEmail>();
			}
		}
		
        /// <summary>
        /// Search for Email entities in the database by EmailFrom
        /// </summary>
        /// <param name="emailfrom">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByEmailFrom(string emailfrom, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailFrom.ToLower().Contains(emailfrom.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailFrom.Contains(emailfrom)).ToList<IEmail>();
			}
		}
		
        /// <summary>
        /// Search for Email entities in the database by EmailTo
        /// </summary>
        /// <param name="emailto">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByEmailTo(string emailto, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailTo.ToLower().Contains(emailto.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailTo.Contains(emailto)).ToList<IEmail>();
			}
		}
		
        /// <summary>
        /// Search for Email entities in the database by EmailSubject
        /// </summary>
        /// <param name="emailsubject">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByEmailSubject(string emailsubject, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailSubject.ToLower().Contains(emailsubject.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailSubject.Contains(emailsubject)).ToList<IEmail>();
			}
		}
		
        /// <summary>
        /// Search for Email entities in the database by EmailBody
        /// </summary>
        /// <param name="emailbody">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByEmailBody(string emailbody, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailBody.ToLower().Contains(emailbody.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.EmailBody.Contains(emailbody)).ToList<IEmail>();
			}
		}
		
        /// <summary>
        /// Search for Email entities in the database by ProcessedDate
        /// </summary>
        /// <param name="processeddate">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByProcessedDate(string processeddate, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.ProcessedDate.ToLower().Contains(processeddate.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.ProcessedDate.Contains(processeddate)).ToList<IEmail>();
			}
		}
		
        /// <summary>
        /// Search for Email entities in the database by Information
        /// </summary>
        /// <param name="information">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		public virtual IList<IEmail> SearchByInformation(string information, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.Information.ToLower().Contains(information.ToLower())).ToList<IEmail>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Email>(o => o.Information.Contains(information)).ToList<IEmail>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Email entity to the database.
        /// </summary>
        /// <param name="entity">IEmail</param>
        /// <returns>bool</returns>
		public virtual bool Save(IEmail entity)
		{
			var entityToSave = new Email(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Email entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IEmail</param>
        /// <returns>bool</returns>
		public virtual bool Update(IEmail entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Email>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Email entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.EmailFrom != entity.EmailFrom) { entityToUpdate.EmailFrom = entity.EmailFrom;doUpdate = true; }
			if (entityToUpdate.EmailTo != entity.EmailTo) { entityToUpdate.EmailTo = entity.EmailTo;doUpdate = true; }
			if (entityToUpdate.EmailSubject != entity.EmailSubject) { entityToUpdate.EmailSubject = entity.EmailSubject;doUpdate = true; }
			if (entityToUpdate.EmailBody != entity.EmailBody) { entityToUpdate.EmailBody = entity.EmailBody;doUpdate = true; }
			if (entityToUpdate.ProcessedDate != entity.ProcessedDate) { entityToUpdate.ProcessedDate = entity.ProcessedDate;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.Information != entity.Information) { entityToUpdate.Information = entity.Information;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Email entity from the database
        /// </summary>
        /// <param name="entity">IEmail</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IEmail entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Email>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Email entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Email entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Email>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Email entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
