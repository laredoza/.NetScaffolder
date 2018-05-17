
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
using Core.Base;
using Banking.Models.Interfaces;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The PluginOneLifeBatchRunPolicyRepository interface that defines database functions for the PluginOneLifeBatchRunPolicy table
	/// </summary>
	public partial interface IPluginOneLifeBatchRunPolicyRepository : IRepository<IPluginOneLifeBatchRunPolicy>
	{
		#region Load

        /// <summary>
        /// Load the PluginOneLifeBatchRunPolicy entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRunPolicy</returns>
		IPluginOneLifeBatchRunPolicy LoadById(int id);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByUserName(string username);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the PluginOneLifeBatchRunId field
        /// </summary>
        /// <param name="pluginonelifebatchrunid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByPluginOneLifeBatchRunId(Nullable<int> pluginonelifebatchrunid);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByPolicyId(Nullable<int> policyid);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Completed field
        /// </summary>
        /// <param name="completed">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByCompleted(Nullable<bool> completed);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the HasError field
        /// </summary>
        /// <param name="haserror">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByHasError(Nullable<bool> haserror);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByMessage(string message);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the XmlFile field
        /// </summary>
        /// <param name="xmlfile">byte[]</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByXmlFile(byte[] xmlfile);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByName(string name);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadBySurname(string surname);

        /// <summary>
        /// Load PluginOneLifeBatchRunPolicy entities from the database using the ExternalReference field
        /// </summary>
        /// <param name="externalreference">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadByExternalReference(string externalreference);

        /// <summary>
        /// Load all PluginOneLifeBatchRunPolicy entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> SearchByMessage(string message, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> SearchBySurname(string surname, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunPolicy entities in the database by ExternalReference
        /// </summary>
        /// <param name="externalreference">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunPolicy></returns>
		IList<IPluginOneLifeBatchRunPolicy> SearchByExternalReference(string externalreference, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRunPolicy entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunPolicy</param>
        /// <returns>bool</returns>
		bool Save(IPluginOneLifeBatchRunPolicy entity);
		
        /// <summary>
        /// Update the PluginOneLifeBatchRunPolicy entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunPolicy</param>
        /// <returns>bool</returns>
		bool Update(IPluginOneLifeBatchRunPolicy entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunPolicy entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunPolicy</param>
        /// <returns>bool</returns>
		bool Delete(IPluginOneLifeBatchRunPolicy entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunPolicy entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
