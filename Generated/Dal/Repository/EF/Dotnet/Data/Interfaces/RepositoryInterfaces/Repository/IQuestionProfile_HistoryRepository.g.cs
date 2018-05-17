
// <copyright file="QuestionProfile_History.g.cs" company="MIT">
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
	/// The QuestionProfile_HistoryRepository interface that defines database functions for the QuestionProfile_History table
	/// </summary>
	public partial interface IQuestionProfile_HistoryRepository : IRepository<IQuestionProfile_History>
	{
		#region Load

        /// <summary>
        /// Load the QuestionProfile_History entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionProfile_History</returns>
		IQuestionProfile_History LoadById(int id);

        /// <summary>
        /// Load QuestionProfile_History entities from the database using the OriginalQuestionProfileId field
        /// </summary>
        /// <param name="originalquestionprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> LoadByOriginalQuestionProfileId(Nullable<int> originalquestionprofileid);

        /// <summary>
        /// Load QuestionProfile_History entities from the database using the NewQuestionProfileId field
        /// </summary>
        /// <param name="newquestionprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> LoadByNewQuestionProfileId(Nullable<int> newquestionprofileid);

        /// <summary>
        /// Load QuestionProfile_History entities from the database using the NewQuestionnaireProfileId field
        /// </summary>
        /// <param name="newquestionnaireprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> LoadByNewQuestionnaireProfileId(Nullable<int> newquestionnaireprofileid);

        /// <summary>
        /// Load QuestionProfile_History entities from the database using the TimeStamp field
        /// </summary>
        /// <param name="timestamp">DateTime</param>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> LoadByTimeStamp(DateTime timestamp);

        /// <summary>
        /// Load QuestionProfile_History entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> LoadByUserName(string username);

        /// <summary>
        /// Load all QuestionProfile_History entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QuestionProfile_History entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile_History></returns>
		IList<IQuestionProfile_History> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionProfile_History entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionProfile_History</param>
        /// <returns>bool</returns>
		bool Save(IQuestionProfile_History entity);
		
        /// <summary>
        /// Update the QuestionProfile_History entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionProfile_History</param>
        /// <returns>bool</returns>
		bool Update(IQuestionProfile_History entity);
		
        /// <summary>
        /// Delete the QuestionProfile_History entity from the database
        /// </summary>
        /// <param name="entity">IQuestionProfile_History</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionProfile_History entity);
		
        /// <summary>
        /// Delete the QuestionProfile_History entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
