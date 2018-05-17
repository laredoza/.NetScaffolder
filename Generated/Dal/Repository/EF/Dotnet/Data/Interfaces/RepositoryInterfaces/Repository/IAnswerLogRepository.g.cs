
// <copyright file="AnswerLog.g.cs" company="MIT">
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
	/// The AnswerLogRepository interface that defines database functions for the AnswerLog table
	/// </summary>
	public partial interface IAnswerLogRepository : IRepository<IAnswerLog>
	{
		#region Load

        /// <summary>
        /// Load the AnswerLog entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerLog</returns>
		IAnswerLog LoadById(int id);

        /// <summary>
        /// Load AnswerLog entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">int</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> LoadByQuestionnaireId(int questionnaireid);

        /// <summary>
        /// Load AnswerLog entities from the database using the QuestionId field
        /// </summary>
        /// <param name="questionid">int</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> LoadByQuestionId(int questionid);

        /// <summary>
        /// Load AnswerLog entities from the database using the Answer field
        /// </summary>
        /// <param name="answer">string</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> LoadByAnswer(string answer);

        /// <summary>
        /// Load AnswerLog entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load AnswerLog entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> LoadByUserName(string username);

        /// <summary>
        /// Load all AnswerLog entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AnswerLog entities in the database by Answer
        /// </summary>
        /// <param name="answer">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> SearchByAnswer(string answer, bool caseSensitive = false);

        /// <summary>
        /// Search for AnswerLog entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerLog></returns>
		IList<IAnswerLog> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerLog entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerLog</param>
        /// <returns>bool</returns>
		bool Save(IAnswerLog entity);
		
        /// <summary>
        /// Update the AnswerLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerLog</param>
        /// <returns>bool</returns>
		bool Update(IAnswerLog entity);
		
        /// <summary>
        /// Delete the AnswerLog entity from the database
        /// </summary>
        /// <param name="entity">IAnswerLog</param>
        /// <returns>bool</returns>
		bool Delete(IAnswerLog entity);
		
        /// <summary>
        /// Delete the AnswerLog entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
