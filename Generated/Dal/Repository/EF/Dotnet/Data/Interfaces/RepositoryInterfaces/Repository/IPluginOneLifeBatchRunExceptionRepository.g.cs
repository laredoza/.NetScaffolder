
// <copyright file="PluginOneLifeBatchRunException.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunExceptionRepository interface that defines database functions for the PluginOneLifeBatchRunException table
	/// </summary>
	public partial interface IPluginOneLifeBatchRunExceptionRepository : IRepository<IPluginOneLifeBatchRunException>
	{
		#region Load

        /// <summary>
        /// Load the PluginOneLifeBatchRunException entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRunException</returns>
		IPluginOneLifeBatchRunException LoadById(int id);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByUserName(string username);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the PluginOneLifeBatchRunPolicyId field
        /// </summary>
        /// <param name="pluginonelifebatchrunpolicyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByPluginOneLifeBatchRunPolicyId(Nullable<int> pluginonelifebatchrunpolicyid);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductName field
        /// </summary>
        /// <param name="productname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByProductName(string productname);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductResult field
        /// </summary>
        /// <param name="productresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByProductResult(string productresult);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductName field
        /// </summary>
        /// <param name="quircproductname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductName(string quircproductname);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductResult field
        /// </summary>
        /// <param name="quircproductresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductResult(string quircproductresult);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByMessage(string message);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the PolicyResult field
        /// </summary>
        /// <param name="policyresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByPolicyResult(string policyresult);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductLoading field
        /// </summary>
        /// <param name="productloading">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByProductLoading(string productloading);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the ProductReferences field
        /// </summary>
        /// <param name="productreferences">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByProductReferences(string productreferences);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCPolicyResult field
        /// </summary>
        /// <param name="quircpolicyresult">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByQUIRCPolicyResult(string quircpolicyresult);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductLoading field
        /// </summary>
        /// <param name="quircproductloading">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductLoading(string quircproductloading);

        /// <summary>
        /// Load PluginOneLifeBatchRunException entities from the database using the QUIRCProductReferences field
        /// </summary>
        /// <param name="quircproductreferences">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadByQUIRCProductReferences(string quircproductreferences);

        /// <summary>
        /// Load all PluginOneLifeBatchRunException entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductName
        /// </summary>
        /// <param name="productname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByProductName(string productname, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductResult
        /// </summary>
        /// <param name="productresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByProductResult(string productresult, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductName
        /// </summary>
        /// <param name="quircproductname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductName(string quircproductname, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductResult
        /// </summary>
        /// <param name="quircproductresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductResult(string quircproductresult, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByMessage(string message, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by PolicyResult
        /// </summary>
        /// <param name="policyresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByPolicyResult(string policyresult, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductLoading
        /// </summary>
        /// <param name="productloading">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByProductLoading(string productloading, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by ProductReferences
        /// </summary>
        /// <param name="productreferences">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByProductReferences(string productreferences, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCPolicyResult
        /// </summary>
        /// <param name="quircpolicyresult">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByQUIRCPolicyResult(string quircpolicyresult, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductLoading
        /// </summary>
        /// <param name="quircproductloading">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductLoading(string quircproductloading, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunException entities in the database by QUIRCProductReferences
        /// </summary>
        /// <param name="quircproductreferences">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunException></returns>
		IList<IPluginOneLifeBatchRunException> SearchByQUIRCProductReferences(string quircproductreferences, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRunException entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunException</param>
        /// <returns>bool</returns>
		bool Save(IPluginOneLifeBatchRunException entity);
		
        /// <summary>
        /// Update the PluginOneLifeBatchRunException entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunException</param>
        /// <returns>bool</returns>
		bool Update(IPluginOneLifeBatchRunException entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunException entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunException</param>
        /// <returns>bool</returns>
		bool Delete(IPluginOneLifeBatchRunException entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunException entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
