
// <copyright file="VersionCondition.g.cs" company="MIT">
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
	/// The VersionConditionRepository interface that defines database functions for the VersionCondition table
	/// </summary>
	public partial interface IVersionConditionRepository : IRepository<IVersionCondition>
	{
		#region Load

        /// <summary>
        /// Load the VersionCondition entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionCondition</returns>
		IVersionCondition LoadById(int id);

        /// <summary>
        /// Load VersionCondition entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load VersionCondition entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadByUserName(string username);

        /// <summary>
        /// Load VersionCondition entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadByName(string name);

        /// <summary>
        /// Load VersionCondition entities from the database using the RunAtEnd field
        /// </summary>
        /// <param name="runatend">Nullable<bool></param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadByRunAtEnd(Nullable<bool> runatend);

        /// <summary>
        /// Load VersionCondition entities from the database using the QuestionnaireVersionId field
        /// </summary>
        /// <param name="questionnaireversionid">Nullable<int></param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadByQuestionnaireVersionId(Nullable<int> questionnaireversionid);

        /// <summary>
        /// Load VersionCondition entities from the database using the ConditionSetContainerId field
        /// </summary>
        /// <param name="conditionsetcontainerid">Nullable<int></param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadByConditionSetContainerId(Nullable<int> conditionsetcontainerid);

        /// <summary>
        /// Load VersionCondition entities from the database using the SequenceNumber field
        /// </summary>
        /// <param name="sequencenumber">Nullable<int></param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadBySequenceNumber(Nullable<int> sequencenumber);

        /// <summary>
        /// Load all VersionCondition entities from the database.
        /// </summary>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for VersionCondition entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for VersionCondition entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionCondition></returns>
		IList<IVersionCondition> SearchByName(string name, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionCondition entity to the database.
        /// </summary>
        /// <param name="entity">IVersionCondition</param>
        /// <returns>bool</returns>
		bool Save(IVersionCondition entity);
		
        /// <summary>
        /// Update the VersionCondition entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionCondition</param>
        /// <returns>bool</returns>
		bool Update(IVersionCondition entity);
		
        /// <summary>
        /// Delete the VersionCondition entity from the database
        /// </summary>
        /// <param name="entity">IVersionCondition</param>
        /// <returns>bool</returns>
		bool Delete(IVersionCondition entity);
		
        /// <summary>
        /// Delete the VersionCondition entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
