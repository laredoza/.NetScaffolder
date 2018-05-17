
// <copyright file="QuestionnaireSequence_Audit.g.cs" company="MIT">
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
	/// The QuestionnaireSequence_AuditRepository interface that defines database functions for the QuestionnaireSequence_Audit table
	/// </summary>
	public partial interface IQuestionnaireSequence_AuditRepository : IRepository<IQuestionnaireSequence_Audit>
	{
		#region Load

        /// <summary>
        /// Load the QuestionnaireSequence_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IQuestionnaireSequence_Audit</returns>
		IQuestionnaireSequence_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadById(int id);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the Seq field
        /// </summary>
        /// <param name="seq">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadBySeq(Nullable<int> seq);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the ProfileVersionId field
        /// </summary>
        /// <param name="profileversionid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadByProfileVersionId(Nullable<int> profileversionid);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the SequenceEntityId field
        /// </summary>
        /// <param name="sequenceentityid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadBySequenceEntityId(Nullable<int> sequenceentityid);

        /// <summary>
        /// Load QuestionnaireSequence_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all QuestionnaireSequence_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QuestionnaireSequence_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireSequence_Audit></returns>
		IList<IQuestionnaireSequence_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireSequence_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence_Audit</param>
        /// <returns>bool</returns>
		bool Save(IQuestionnaireSequence_Audit entity);
		
        /// <summary>
        /// Update the QuestionnaireSequence_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence_Audit</param>
        /// <returns>bool</returns>
		bool Update(IQuestionnaireSequence_Audit entity);
		
        /// <summary>
        /// Delete the QuestionnaireSequence_Audit entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IQuestionnaireSequence_Audit entity);
		
        /// <summary>
        /// Delete the QuestionnaireSequence_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
