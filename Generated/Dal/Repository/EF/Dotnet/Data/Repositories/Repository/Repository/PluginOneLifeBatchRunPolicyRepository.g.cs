
// <copyright file="PluginOneLifeBatchRunPolicy.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunPolicyRepository class responsible for database functions in the PluginOneLifeBatchRunPolicy table
	/// </summary>
	public partial class PluginOneLifeBatchRunPolicyRepository : UowRepository<PluginOneLifeBatchRunPolicy> , IPluginOneLifeBatchRunPolicyRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifeBatchRunPolicyRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifeBatchRunPolicyRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifeBatchRunPolicy entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRunPolicy</returns>
		public virtual IPluginOneLifeBatchRunPolicy LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunPolicy>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Stamp == stamp).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.UserName == username).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the PluginOneLifeBatchRunId field
        /// </summary>
        /// <param name="pluginonelifebatchrunid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByPluginOneLifeBatchRunId(Nullable<int> pluginonelifebatchrunid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.PluginOneLifeBatchRunId == pluginonelifebatchrunid).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.PolicyId == policyid).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Completed field
        /// </summary>
        /// <param name="completed">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByCompleted(Nullable<bool> completed)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Completed == completed).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the HasError field
        /// </summary>
        /// <param name="haserror">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByHasError(Nullable<bool> haserror)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.HasError == haserror).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByMessage(string message)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Message == message).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the XmlFile field
        /// </summary>
        /// <param name="xmlfile">byte[]</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByXmlFile(byte[] xmlfile)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.XmlFile == xmlfile).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Name == name).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Surname == surname).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the ExternalReference field
        /// </summary>
        /// <param name="externalreference">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadByExternalReference(string externalreference)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.ExternalReference == externalreference).ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
        /// <summary>
        /// Load all PluginOneLifeBatchRunPolicy entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifeBatchRunPolicy>().ToList<IPluginOneLifeBatchRunPolicy>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifeBatchRunPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.UserName.Contains(username)).ToList<IPluginOneLifeBatchRunPolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> SearchByMessage(string message, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Message.ToLower().Contains(message.ToLower())).ToList<IPluginOneLifeBatchRunPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Message.Contains(message)).ToList<IPluginOneLifeBatchRunPolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IPluginOneLifeBatchRunPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Name.Contains(name)).ToList<IPluginOneLifeBatchRunPolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<IPluginOneLifeBatchRunPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.Surname.Contains(surname)).ToList<IPluginOneLifeBatchRunPolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by ExternalReference
        /// </summary>
        /// <param name="externalreference">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		public virtual IList<IPluginOneLifeBatchRunPolicy> SearchByExternalReference(string externalreference, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.ExternalReference.ToLower().Contains(externalreference.ToLower())).ToList<IPluginOneLifeBatchRunPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunPolicy>(o => o.ExternalReference.Contains(externalreference)).ToList<IPluginOneLifeBatchRunPolicy>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRunPolicy entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunPolicy</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifeBatchRunPolicy entity)
		{
			var entityToSave = new PluginOneLifeBatchRunPolicy(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifeBatchRunPolicy entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunPolicy</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifeBatchRunPolicy entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunPolicy>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifeBatchRunPolicy entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifeBatchRunId != entity.PluginOneLifeBatchRunId) { entityToUpdate.PluginOneLifeBatchRunId = entity.PluginOneLifeBatchRunId;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.Completed != entity.Completed) { entityToUpdate.Completed = entity.Completed;doUpdate = true; }
			if (entityToUpdate.HasError != entity.HasError) { entityToUpdate.HasError = entity.HasError;doUpdate = true; }
			if (entityToUpdate.Message != entity.Message) { entityToUpdate.Message = entity.Message;doUpdate = true; }
			if (entityToUpdate.XmlFile != entity.XmlFile) { entityToUpdate.XmlFile = entity.XmlFile;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Surname != entity.Surname) { entityToUpdate.Surname = entity.Surname;doUpdate = true; }
			if (entityToUpdate.ExternalReference != entity.ExternalReference) { entityToUpdate.ExternalReference = entity.ExternalReference;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunPolicy entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunPolicy</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifeBatchRunPolicy entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunPolicy>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRunPolicy entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunPolicy entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunPolicy>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRunPolicy entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
