
// <copyright file="Questionnaire.g.cs" company="MIT">
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
	/// The QuestionnaireRepository interface that defines database functions for the Questionnaire table
	/// </summary>
	public partial interface IQuestionnaireRepository : IRepository<IQuestionnaire>
	{
		#region Load

        /// <summary>
        /// Load the Questionnaire entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaire</returns>
		IQuestionnaire LoadById(int id);

        /// <summary>
        /// Load Questionnaire entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Questionnaire entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByUserName(string username);

        /// <summary>
        /// Load Questionnaire entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load Questionnaire entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid);

        /// <summary>
        /// Load Questionnaire entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByRemainingChanges(Nullable<int> remainingchanges);

        /// <summary>
        /// Load Questionnaire entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByPolicyId(Nullable<int> policyid);

        /// <summary>
        /// Load Questionnaire entities from the database using the Testing field
        /// </summary>
        /// <param name="testing">bool</param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadByTesting(bool testing);

        /// <summary>
        /// Load all Questionnaire entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Questionnaire entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaire></returns>
		IList<IQuestionnaire> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Questionnaire entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaire</param>
        /// <returns>bool</returns>
		bool Save(IQuestionnaire entity);
		
        /// <summary>
        /// Update the Questionnaire entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaire</param>
        /// <returns>bool</returns>
		bool Update(IQuestionnaire entity);
		
        /// <summary>
        /// Delete the Questionnaire entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaire</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionnaire entity);
		
        /// <summary>
        /// Delete the Questionnaire entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
