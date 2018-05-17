
// <copyright file="AnswerConditionOutcomeResult_Audit.g.cs" company="MIT">
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
	/// The AnswerConditionOutcomeResult_AuditRepository interface that defines database functions for the AnswerConditionOutcomeResult_Audit table
	/// </summary>
	public partial interface IAnswerConditionOutcomeResult_AuditRepository : IRepository<IAnswerConditionOutcomeResult_Audit>
	{
		#region Load

        /// <summary>
        /// Load the AnswerConditionOutcomeResult_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IAnswerConditionOutcomeResult_Audit</returns>
		IAnswerConditionOutcomeResult_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load AnswerConditionOutcomeResult_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadById(int id);

        /// <summary>
        /// Load AnswerConditionOutcomeResult_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load AnswerConditionOutcomeResult_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load AnswerConditionOutcomeResult_Audit entities from the database using the AnswerId field
        /// </summary>
        /// <param name="answerid">Nullable<int></param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadByAnswerId(Nullable<int> answerid);

        /// <summary>
        /// Load AnswerConditionOutcomeResult_Audit entities from the database using the ConditionResultId field
        /// </summary>
        /// <param name="conditionresultid">Nullable<int></param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadByConditionResultId(Nullable<int> conditionresultid);

        /// <summary>
        /// Load AnswerConditionOutcomeResult_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all AnswerConditionOutcomeResult_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AnswerConditionOutcomeResult_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerConditionOutcomeResult_Audit></returns>
		IList<IAnswerConditionOutcomeResult_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerConditionOutcomeResult_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult_Audit</param>
        /// <returns>bool</returns>
		bool Save(IAnswerConditionOutcomeResult_Audit entity);
		
        /// <summary>
        /// Update the AnswerConditionOutcomeResult_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult_Audit</param>
        /// <returns>bool</returns>
		bool Update(IAnswerConditionOutcomeResult_Audit entity);
		
        /// <summary>
        /// Delete the AnswerConditionOutcomeResult_Audit entity from the database
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IAnswerConditionOutcomeResult_Audit entity);
		
        /// <summary>
        /// Delete the AnswerConditionOutcomeResult_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
