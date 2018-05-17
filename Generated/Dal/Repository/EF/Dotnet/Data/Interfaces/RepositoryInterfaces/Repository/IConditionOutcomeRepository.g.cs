
// <copyright file="ConditionOutcome.g.cs" company="MIT">
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
	/// The ConditionOutcomeRepository interface that defines database functions for the ConditionOutcome table
	/// </summary>
	public partial interface IConditionOutcomeRepository : IRepository<IConditionOutcome>
	{
		#region Load

        /// <summary>
        /// Load the ConditionOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IConditionOutcome</returns>
		IConditionOutcome LoadById(int id);

        /// <summary>
        /// Load ConditionOutcome entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IConditionOutcome></returns>
		IList<IConditionOutcome> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load ConditionOutcome entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IConditionOutcome></returns>
		IList<IConditionOutcome> LoadByUserName(string username);

        /// <summary>
        /// Load ConditionOutcome entities from the database using the AnswerConditionId field
        /// </summary>
        /// <param name="answerconditionid">Nullable<int></param>
        /// <returns>IList<IConditionOutcome></returns>
		IList<IConditionOutcome> LoadByAnswerConditionId(Nullable<int> answerconditionid);

        /// <summary>
        /// Load ConditionOutcome entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<IConditionOutcome></returns>
		IList<IConditionOutcome> LoadByProviderId(Nullable<int> providerid);

        /// <summary>
        /// Load all ConditionOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IConditionOutcome></returns>
		IList<IConditionOutcome> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ConditionOutcome entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionOutcome></returns>
		IList<IConditionOutcome> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ConditionOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IConditionOutcome</param>
        /// <returns>bool</returns>
		bool Save(IConditionOutcome entity);
		
        /// <summary>
        /// Update the ConditionOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IConditionOutcome</param>
        /// <returns>bool</returns>
		bool Update(IConditionOutcome entity);
		
        /// <summary>
        /// Delete the ConditionOutcome entity from the database
        /// </summary>
        /// <param name="entity">IConditionOutcome</param>
        /// <returns>bool</returns>
		bool Delete(IConditionOutcome entity);
		
        /// <summary>
        /// Delete the ConditionOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
