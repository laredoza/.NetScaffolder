
// <copyright file="RunOnceOutcomeGroup.g.cs" company="MIT">
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
	/// The RunOnceOutcomeGroupRepository interface that defines database functions for the RunOnceOutcomeGroup table
	/// </summary>
	public partial interface IRunOnceOutcomeGroupRepository : IRepository<IRunOnceOutcomeGroup>
	{
		#region Load

        /// <summary>
        /// Load the RunOnceOutcomeGroup entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IRunOnceOutcomeGroup</returns>
		IRunOnceOutcomeGroup LoadById(int id);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadByUserName(string username);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadByQuestionnaireId(Nullable<int> questionnaireid);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadBySetupTableDataId(Nullable<int> setuptabledataid);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the OutcomeGroupId field
        /// </summary>
        /// <param name="outcomegroupid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadByOutcomeGroupId(Nullable<int> outcomegroupid);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the AnswerId field
        /// </summary>
        /// <param name="answerid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadByAnswerId(Nullable<int> answerid);

        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the RunOnceActiveFlag field
        /// </summary>
        /// <param name="runonceactiveflag">Nullable<bool></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadByRunOnceActiveFlag(Nullable<bool> runonceactiveflag);

        /// <summary>
        /// Load all RunOnceOutcomeGroup entities from the database.
        /// </summary>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for RunOnceOutcomeGroup entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		IList<IRunOnceOutcomeGroup> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the RunOnceOutcomeGroup entity to the database.
        /// </summary>
        /// <param name="entity">IRunOnceOutcomeGroup</param>
        /// <returns>bool</returns>
		bool Save(IRunOnceOutcomeGroup entity);
		
        /// <summary>
        /// Update the RunOnceOutcomeGroup entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IRunOnceOutcomeGroup</param>
        /// <returns>bool</returns>
		bool Update(IRunOnceOutcomeGroup entity);
		
        /// <summary>
        /// Delete the RunOnceOutcomeGroup entity from the database
        /// </summary>
        /// <param name="entity">IRunOnceOutcomeGroup</param>
        /// <returns>bool</returns>
		bool Delete(IRunOnceOutcomeGroup entity);
		
        /// <summary>
        /// Delete the RunOnceOutcomeGroup entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
