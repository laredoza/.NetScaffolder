
// <copyright file="AnswerConditionOutcomeResult.g.cs" company="MIT">
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
	/// The AnswerConditionOutcomeResultRepository interface that defines database functions for the AnswerConditionOutcomeResult table
	/// </summary>
	public partial interface IAnswerConditionOutcomeResultRepository : IRepository<IAnswerConditionOutcomeResult>
	{
		#region Load

        /// <summary>
        /// Load the AnswerConditionOutcomeResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerConditionOutcomeResult</returns>
		IAnswerConditionOutcomeResult LoadById(int id);

        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		IList<IAnswerConditionOutcomeResult> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		IList<IAnswerConditionOutcomeResult> LoadByUserName(string username);

        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the AnswerId field
        /// </summary>
        /// <param name="answerid">Nullable<int></param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		IList<IAnswerConditionOutcomeResult> LoadByAnswerId(Nullable<int> answerid);

        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the ConditionResultId field
        /// </summary>
        /// <param name="conditionresultid">Nullable<int></param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		IList<IAnswerConditionOutcomeResult> LoadByConditionResultId(Nullable<int> conditionresultid);

        /// <summary>
        /// Load all AnswerConditionOutcomeResult entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		IList<IAnswerConditionOutcomeResult> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AnswerConditionOutcomeResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		IList<IAnswerConditionOutcomeResult> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerConditionOutcomeResult entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult</param>
        /// <returns>bool</returns>
		bool Save(IAnswerConditionOutcomeResult entity);
		
        /// <summary>
        /// Update the AnswerConditionOutcomeResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult</param>
        /// <returns>bool</returns>
		bool Update(IAnswerConditionOutcomeResult entity);
		
        /// <summary>
        /// Delete the AnswerConditionOutcomeResult entity from the database
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult</param>
        /// <returns>bool</returns>
		bool Delete(IAnswerConditionOutcomeResult entity);
		
        /// <summary>
        /// Delete the AnswerConditionOutcomeResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
