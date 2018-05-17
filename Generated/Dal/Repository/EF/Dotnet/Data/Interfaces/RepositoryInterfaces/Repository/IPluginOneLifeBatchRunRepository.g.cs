
// <copyright file="PluginOneLifeBatchRun.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunRepository interface that defines database functions for the PluginOneLifeBatchRun table
	/// </summary>
	public partial interface IPluginOneLifeBatchRunRepository : IRepository<IPluginOneLifeBatchRun>
	{
		#region Load

        /// <summary>
        /// Load the PluginOneLifeBatchRun entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRun</returns>
		IPluginOneLifeBatchRun LoadById(int id);

        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> LoadByUserName(string username);

        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the PluginOneLifeCedantId field
        /// </summary>
        /// <param name="pluginonelifecedantid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> LoadByPluginOneLifeCedantId(Nullable<int> pluginonelifecedantid);

        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the Completed field
        /// </summary>
        /// <param name="completed">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> LoadByCompleted(Nullable<bool> completed);

        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the HasError field
        /// </summary>
        /// <param name="haserror">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> LoadByHasError(Nullable<bool> haserror);

        /// <summary>
        /// Load all PluginOneLifeBatchRun entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PluginOneLifeBatchRun entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		IList<IPluginOneLifeBatchRun> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRun entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRun</param>
        /// <returns>bool</returns>
		bool Save(IPluginOneLifeBatchRun entity);
		
        /// <summary>
        /// Update the PluginOneLifeBatchRun entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRun</param>
        /// <returns>bool</returns>
		bool Update(IPluginOneLifeBatchRun entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRun entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRun</param>
        /// <returns>bool</returns>
		bool Delete(IPluginOneLifeBatchRun entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRun entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
