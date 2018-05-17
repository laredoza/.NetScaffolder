
// <copyright file="AuditData.g.cs" company="MIT">
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
	/// The AuditDataRepository interface that defines database functions for the AuditData table
	/// </summary>
	public partial interface IAuditDataRepository : IRepository<IAuditData>
	{
		#region Load

        /// <summary>
        /// Load the AuditData entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>IAuditData</returns>
		IAuditData LoadById(Guid id);

        /// <summary>
        /// Load AuditData entities from the database using the PropertyName field
        /// </summary>
        /// <param name="propertyname">string</param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> LoadByPropertyName(string propertyname);

        /// <summary>
        /// Load AuditData entities from the database using the PreviousValue field
        /// </summary>
        /// <param name="previousvalue">string</param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> LoadByPreviousValue(string previousvalue);

        /// <summary>
        /// Load AuditData entities from the database using the NewValue field
        /// </summary>
        /// <param name="newvalue">string</param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> LoadByNewValue(string newvalue);

        /// <summary>
        /// Load AuditData entities from the database using the AuditId field
        /// </summary>
        /// <param name="auditid">Nullable<Guid></param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> LoadByAuditId(Nullable<Guid> auditid);

        /// <summary>
        /// Load all AuditData entities from the database.
        /// </summary>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AuditData entities in the database by PropertyName
        /// </summary>
        /// <param name="propertyname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> SearchByPropertyName(string propertyname, bool caseSensitive = false);

        /// <summary>
        /// Search for AuditData entities in the database by PreviousValue
        /// </summary>
        /// <param name="previousvalue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> SearchByPreviousValue(string previousvalue, bool caseSensitive = false);

        /// <summary>
        /// Search for AuditData entities in the database by NewValue
        /// </summary>
        /// <param name="newvalue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditData></returns>
		IList<IAuditData> SearchByNewValue(string newvalue, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AuditData entity to the database.
        /// </summary>
        /// <param name="entity">IAuditData</param>
        /// <returns>bool</returns>
		bool Save(IAuditData entity);
		
        /// <summary>
        /// Update the AuditData entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAuditData</param>
        /// <returns>bool</returns>
		bool Update(IAuditData entity);
		
        /// <summary>
        /// Delete the AuditData entity from the database
        /// </summary>
        /// <param name="entity">IAuditData</param>
        /// <returns>bool</returns>
		bool Delete(IAuditData entity);
		
        /// <summary>
        /// Delete the AuditData entity from the database using the Id
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		bool DeleteById(Guid id);

		#endregion
	}
}
