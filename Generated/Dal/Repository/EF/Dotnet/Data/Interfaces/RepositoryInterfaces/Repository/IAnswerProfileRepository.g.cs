
// <copyright file="AnswerProfile.g.cs" company="MIT">
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
	/// The AnswerProfileRepository interface that defines database functions for the AnswerProfile table
	/// </summary>
	public partial interface IAnswerProfileRepository : IRepository<IAnswerProfile>
	{
		#region Load

        /// <summary>
        /// Load the AnswerProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerProfile</returns>
		IAnswerProfile LoadById(int id);

        /// <summary>
        /// Load AnswerProfile entities from the database using the DataType field
        /// </summary>
        /// <param name="datatype">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadByDataType(Nullable<int> datatype);

        /// <summary>
        /// Load AnswerProfile entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadByQuestionProfileId(Nullable<int> questionprofileid);

        /// <summary>
        /// Load AnswerProfile entities from the database using the AnswerProviderId field
        /// </summary>
        /// <param name="answerproviderid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadByAnswerProviderId(Nullable<int> answerproviderid);

        /// <summary>
        /// Load AnswerProfile entities from the database using the ApplicantAttributeId field
        /// </summary>
        /// <param name="applicantattributeid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadByApplicantAttributeId(Nullable<int> applicantattributeid);

        /// <summary>
        /// Load AnswerProfile entities from the database using the SequenceId field
        /// </summary>
        /// <param name="sequenceid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadBySequenceId(Nullable<int> sequenceid);

        /// <summary>
        /// Load AnswerProfile entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadByPromptText(string prompttext);

        /// <summary>
        /// Load all AnswerProfile entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AnswerProfile entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerProfile></returns>
		IList<IAnswerProfile> SearchByPromptText(string prompttext, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerProfile entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerProfile</param>
        /// <returns>bool</returns>
		bool Save(IAnswerProfile entity);
		
        /// <summary>
        /// Update the AnswerProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerProfile</param>
        /// <returns>bool</returns>
		bool Update(IAnswerProfile entity);
		
        /// <summary>
        /// Delete the AnswerProfile entity from the database
        /// </summary>
        /// <param name="entity">IAnswerProfile</param>
        /// <returns>bool</returns>
		bool Delete(IAnswerProfile entity);
		
        /// <summary>
        /// Delete the AnswerProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
