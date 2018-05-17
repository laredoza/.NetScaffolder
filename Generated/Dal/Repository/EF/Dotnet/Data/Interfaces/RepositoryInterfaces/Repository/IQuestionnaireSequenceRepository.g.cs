
// <copyright file="QuestionnaireSequence.g.cs" company="MIT">
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
	/// The QuestionnaireSequenceRepository interface that defines database functions for the QuestionnaireSequence table
	/// </summary>
	public partial interface IQuestionnaireSequenceRepository : IRepository<IQuestionnaireSequence>
	{
		#region Load

        /// <summary>
        /// Load the QuestionnaireSequence entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaireSequence</returns>
		IQuestionnaireSequence LoadById(int id);

        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> LoadByUserName(string username);

        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the Seq field
        /// </summary>
        /// <param name="seq">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> LoadBySeq(Nullable<int> seq);

        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the ProfileVersionId field
        /// </summary>
        /// <param name="profileversionid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> LoadByProfileVersionId(Nullable<int> profileversionid);

        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the SequenceEntityId field
        /// </summary>
        /// <param name="sequenceentityid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> LoadBySequenceEntityId(Nullable<int> sequenceentityid);

        /// <summary>
        /// Load all QuestionnaireSequence entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QuestionnaireSequence entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		IList<IQuestionnaireSequence> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireSequence entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence</param>
        /// <returns>bool</returns>
		bool Save(IQuestionnaireSequence entity);
		
        /// <summary>
        /// Update the QuestionnaireSequence entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence</param>
        /// <returns>bool</returns>
		bool Update(IQuestionnaireSequence entity);
		
        /// <summary>
        /// Delete the QuestionnaireSequence entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionnaireSequence entity);
		
        /// <summary>
        /// Delete the QuestionnaireSequence entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
