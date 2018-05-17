
// <copyright file="Question.g.cs" company="MIT">
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
	/// The QuestionRepository interface that defines database functions for the Question table
	/// </summary>
	public partial interface IQuestionRepository : IRepository<IQuestion>
	{
		#region Load

        /// <summary>
        /// Load the Question entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestion</returns>
		IQuestion LoadById(int id);

        /// <summary>
        /// Load Question entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Question entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByUserName(string username);

        /// <summary>
        /// Load Question entities from the database using the isAnswered field
        /// </summary>
        /// <param name="isanswered">Nullable<bool></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByisAnswered(Nullable<bool> isanswered);

        /// <summary>
        /// Load Question entities from the database using the isVisible field
        /// </summary>
        /// <param name="isvisible">Nullable<bool></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByisVisible(Nullable<bool> isvisible);

        /// <summary>
        /// Load Question entities from the database using the isFlagged field
        /// </summary>
        /// <param name="isflagged">Nullable<bool></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByisFlagged(Nullable<bool> isflagged);

        /// <summary>
        /// Load Question entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByQuestionProfileId(Nullable<int> questionprofileid);

        /// <summary>
        /// Load Question entities from the database using the SectionId field
        /// </summary>
        /// <param name="sectionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadBySectionId(Nullable<int> sectionid);

        /// <summary>
        /// Load Question entities from the database using the PreviousQuestionId field
        /// </summary>
        /// <param name="previousquestionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByPreviousQuestionId(Nullable<int> previousquestionid);

        /// <summary>
        /// Load Question entities from the database using the PopupStartedQuestionId field
        /// </summary>
        /// <param name="popupstartedquestionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByPopupStartedQuestionId(Nullable<int> popupstartedquestionid);

        /// <summary>
        /// Load Question entities from the database using the NextQuestionId field
        /// </summary>
        /// <param name="nextquestionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadByNextQuestionId(Nullable<int> nextquestionid);

        /// <summary>
        /// Load all Question entities from the database.
        /// </summary>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Question entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestion></returns>
		IList<IQuestion> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Question entity to the database.
        /// </summary>
        /// <param name="entity">IQuestion</param>
        /// <returns>bool</returns>
		bool Save(IQuestion entity);
		
        /// <summary>
        /// Update the Question entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestion</param>
        /// <returns>bool</returns>
		bool Update(IQuestion entity);
		
        /// <summary>
        /// Delete the Question entity from the database
        /// </summary>
        /// <param name="entity">IQuestion</param>
        /// <returns>bool</returns>
		bool Delete(IQuestion entity);
		
        /// <summary>
        /// Delete the Question entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
