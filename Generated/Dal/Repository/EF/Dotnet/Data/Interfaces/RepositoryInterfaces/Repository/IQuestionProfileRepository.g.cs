
// <copyright file="QuestionProfile.g.cs" company="MIT">
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
	/// The QuestionProfileRepository interface that defines database functions for the QuestionProfile table
	/// </summary>
	public partial interface IQuestionProfileRepository : IRepository<IQuestionProfile>
	{
		#region Load

        /// <summary>
        /// Load the QuestionProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionProfile</returns>
		IQuestionProfile LoadById(int id);

        /// <summary>
        /// Load QuestionProfile entities from the database using the Number field
        /// </summary>
        /// <param name="number">Nullable<int></param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByNumber(Nullable<int> number);

        /// <summary>
        /// Load QuestionProfile entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByTitle(string title);

        /// <summary>
        /// Load QuestionProfile entities from the database using the PlaintText field
        /// </summary>
        /// <param name="plainttext">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByPlaintText(string plainttext);

        /// <summary>
        /// Load QuestionProfile entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByText(string text);

        /// <summary>
        /// Load QuestionProfile entities from the database using the allowMultipleAnswers field
        /// </summary>
        /// <param name="allowmultipleanswers">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByallowMultipleAnswers(Nullable<bool> allowmultipleanswers);

        /// <summary>
        /// Load QuestionProfile entities from the database using the isVisibleAtStart field
        /// </summary>
        /// <param name="isvisibleatstart">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByisVisibleAtStart(Nullable<bool> isvisibleatstart);

        /// <summary>
        /// Load QuestionProfile entities from the database using the CopiedFromQuestionProfileTitle field
        /// </summary>
        /// <param name="copiedfromquestionprofiletitle">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByCopiedFromQuestionProfileTitle(string copiedfromquestionprofiletitle);

        /// <summary>
        /// Load QuestionProfile entities from the database using the PromptPlaintText field
        /// </summary>
        /// <param name="promptplainttext">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByPromptPlaintText(string promptplainttext);

        /// <summary>
        /// Load QuestionProfile entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByPromptText(string prompttext);

        /// <summary>
        /// Load QuestionProfile entities from the database using the PrePopulatedByService field
        /// </summary>
        /// <param name="prepopulatedbyservice">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByPrePopulatedByService(Nullable<bool> prepopulatedbyservice);

        /// <summary>
        /// Load QuestionProfile entities from the database using the SequenceId field
        /// </summary>
        /// <param name="sequenceid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadBySequenceId(Nullable<int> sequenceid);

        /// <summary>
        /// Load QuestionProfile entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByExternalReferenceId(string externalreferenceid);

        /// <summary>
        /// Load QuestionProfile entities from the database using the AnswerRequired field
        /// </summary>
        /// <param name="answerrequired">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByAnswerRequired(bool answerrequired);

        /// <summary>
        /// Load QuestionProfile entities from the database using the DoNotDisplay field
        /// </summary>
        /// <param name="donotdisplay">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadByDoNotDisplay(Nullable<bool> donotdisplay);

        /// <summary>
        /// Load all QuestionProfile entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QuestionProfile entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByTitle(string title, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionProfile entities in the database by PlaintText
        /// </summary>
        /// <param name="plainttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByPlaintText(string plainttext, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionProfile entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByText(string text, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionProfile entities in the database by CopiedFromQuestionProfileTitle
        /// </summary>
        /// <param name="copiedfromquestionprofiletitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByCopiedFromQuestionProfileTitle(string copiedfromquestionprofiletitle, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionProfile entities in the database by PromptPlaintText
        /// </summary>
        /// <param name="promptplainttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByPromptPlaintText(string promptplainttext, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionProfile entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByPromptText(string prompttext, bool caseSensitive = false);

        /// <summary>
        /// Search for QuestionProfile entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		IList<IQuestionProfile> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionProfile entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionProfile</param>
        /// <returns>bool</returns>
		bool Save(IQuestionProfile entity);
		
        /// <summary>
        /// Update the QuestionProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionProfile</param>
        /// <returns>bool</returns>
		bool Update(IQuestionProfile entity);
		
        /// <summary>
        /// Delete the QuestionProfile entity from the database
        /// </summary>
        /// <param name="entity">IQuestionProfile</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionProfile entity);
		
        /// <summary>
        /// Delete the QuestionProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
