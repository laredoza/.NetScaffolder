
// <copyright file="PluginOneLifePolicy.g.cs" company="MIT">
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
	/// The PluginOneLifePolicyRepository interface that defines database functions for the PluginOneLifePolicy table
	/// </summary>
	public partial interface IPluginOneLifePolicyRepository : IRepository<IPluginOneLifePolicy>
	{
		#region Load

        /// <summary>
        /// Load the PluginOneLifePolicy entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifePolicy</returns>
		IPluginOneLifePolicy LoadById(int id);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadByUserName(string username);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the PluginOneLifeCedantId field
        /// </summary>
        /// <param name="pluginonelifecedantid">int</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadByPluginOneLifeCedantId(int pluginonelifecedantid);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">int</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadByPolicyId(int policyid);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadByName(string name);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadBySurname(string surname);

        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the ExternalReference field
        /// </summary>
        /// <param name="externalreference">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadByExternalReference(string externalreference);

        /// <summary>
        /// Load all PluginOneLifePolicy entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> SearchBySurname(string surname, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by ExternalReference
        /// </summary>
        /// <param name="externalreference">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		IList<IPluginOneLifePolicy> SearchByExternalReference(string externalreference, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifePolicy entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifePolicy</param>
        /// <returns>bool</returns>
		bool Save(IPluginOneLifePolicy entity);
		
        /// <summary>
        /// Update the PluginOneLifePolicy entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifePolicy</param>
        /// <returns>bool</returns>
		bool Update(IPluginOneLifePolicy entity);
		
        /// <summary>
        /// Delete the PluginOneLifePolicy entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifePolicy</param>
        /// <returns>bool</returns>
		bool Delete(IPluginOneLifePolicy entity);
		
        /// <summary>
        /// Delete the PluginOneLifePolicy entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
