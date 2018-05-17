
// <copyright file="QuestionnaireProfileVersion.g.cs" company="MIT">
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
	/// The QuestionnaireProfileVersionRepository interface that defines database functions for the QuestionnaireProfileVersion table
	/// </summary>
	public partial interface IQuestionnaireProfileVersionRepository : IRepository<IQuestionnaireProfileVersion>
	{
		#region Load

        /// <summary>
        /// Load the QuestionnaireProfileVersion entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaireProfileVersion</returns>
		IQuestionnaireProfileVersion LoadById(int id);

        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadByUserName(string username);

        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the Version field
        /// </summary>
        /// <param name="version">string</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadByVersion(string version);

        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the GroupApplicantPropertyAnswers field
        /// </summary>
        /// <param name="groupapplicantpropertyanswers">Nullable<bool></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadByGroupApplicantPropertyAnswers(Nullable<bool> groupapplicantpropertyanswers);

        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the VersionLocked field
        /// </summary>
        /// <param name="versionlocked">Nullable<bool></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadByVersionLocked(Nullable<bool> versionlocked);

        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the QuestionnaireProfileId field
        /// </summary>
        /// <param name="questionnaireprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadByQuestionnaireProfileId(Nullable<int> questionnaireprofileid);

        /// <summary>
        /// Load all QuestionnaireProfileVersion entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QuestionnaireProfileVersion entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionnaireProfileVersion entities in the database by Version
        /// </summary>
        /// <param name="version">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		IList<IQuestionnaireProfileVersion> SearchByVersion(string version, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireProfileVersion entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireProfileVersion</param>
        /// <returns>bool</returns>
		bool Save(IQuestionnaireProfileVersion entity);
		
        /// <summary>
        /// Update the QuestionnaireProfileVersion entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireProfileVersion</param>
        /// <returns>bool</returns>
		bool Update(IQuestionnaireProfileVersion entity);
		
        /// <summary>
        /// Delete the QuestionnaireProfileVersion entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireProfileVersion</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionnaireProfileVersion entity);
		
        /// <summary>
        /// Delete the QuestionnaireProfileVersion entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
