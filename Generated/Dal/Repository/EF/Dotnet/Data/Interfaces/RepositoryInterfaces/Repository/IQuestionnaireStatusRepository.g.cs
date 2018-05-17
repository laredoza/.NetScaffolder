
// <copyright file="QuestionnaireStatus.g.cs" company="MIT">
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
	/// The QuestionnaireStatusRepository interface that defines database functions for the QuestionnaireStatus table
	/// </summary>
	public partial interface IQuestionnaireStatusRepository : IRepository<IQuestionnaireStatus>
	{
		#region Load

        /// <summary>
        /// Load the QuestionnaireStatus entity from the database using the QuestionnaireStatusID primary key
        /// </summary>
        /// <param name="questionnairestatusid">int</param>
        /// <returns>IQuestionnaireStatus</returns>
		IQuestionnaireStatus LoadByQuestionnaireStatusID(int questionnairestatusid);

        /// <summary>
        /// Load QuestionnaireStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IQuestionnaireStatus></returns>
		IList<IQuestionnaireStatus> LoadByDescription(string description);

        /// <summary>
        /// Load all QuestionnaireStatus entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireStatus></returns>
		IList<IQuestionnaireStatus> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QuestionnaireStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireStatus></returns>
		IList<IQuestionnaireStatus> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireStatus entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireStatus</param>
        /// <returns>bool</returns>
		bool Save(IQuestionnaireStatus entity);
		
        /// <summary>
        /// Update the QuestionnaireStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireStatus</param>
        /// <returns>bool</returns>
		bool Update(IQuestionnaireStatus entity);
		
        /// <summary>
        /// Delete the QuestionnaireStatus entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireStatus</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionnaireStatus entity);
		
        /// <summary>
        /// Delete the QuestionnaireStatus entity from the database using the QuestionnaireStatusID
        /// </summary>
        /// <param name="questionnairestatusid">int</param>
        /// <returns>bool</returns>
		bool DeleteByQuestionnaireStatusID(int questionnairestatusid);

		#endregion
	}
}
