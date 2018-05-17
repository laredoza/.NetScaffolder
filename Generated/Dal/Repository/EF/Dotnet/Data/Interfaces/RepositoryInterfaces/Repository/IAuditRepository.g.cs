
// <copyright file="Audit.g.cs" company="MIT">
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
	/// The AuditRepository interface that defines database functions for the Audit table
	/// </summary>
	public partial interface IAuditRepository : IRepository<IAudit>
	{
		#region Load

        /// <summary>
        /// Load the Audit entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>IAudit</returns>
		IAudit LoadById(Guid id);

        /// <summary>
        /// Load Audit entities from the database using the Entity field
        /// </summary>
        /// <param name="entity">string</param>
        /// <returns>IList<IAudit></returns>
		IList<IAudit> LoadByEntity(string entity);

        /// <summary>
        /// Load Audit entities from the database using the EntityId field
        /// </summary>
        /// <param name="entityid">Nullable<int></param>
        /// <returns>IList<IAudit></returns>
		IList<IAudit> LoadByEntityId(Nullable<int> entityid);

        /// <summary>
        /// Load Audit entities from the database using the Action field
        /// </summary>
        /// <param name="action">Nullable<int></param>
        /// <returns>IList<IAudit></returns>
		IList<IAudit> LoadByAction(Nullable<int> action);

        /// <summary>
        /// Load Audit entities from the database using the AuditTransactionId field
        /// </summary>
        /// <param name="audittransactionid">Nullable<Guid></param>
        /// <returns>IList<IAudit></returns>
		IList<IAudit> LoadByAuditTransactionId(Nullable<Guid> audittransactionid);

        /// <summary>
        /// Load all Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAudit></returns>
		IList<IAudit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Audit entities in the database by Entity
        /// </summary>
        /// <param name="entity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAudit></returns>
		IList<IAudit> SearchByEntity(string entity, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAudit</param>
        /// <returns>bool</returns>
		bool Save(IAudit entity);
		
        /// <summary>
        /// Update the Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAudit</param>
        /// <returns>bool</returns>
		bool Update(IAudit entity);
		
        /// <summary>
        /// Delete the Audit entity from the database
        /// </summary>
        /// <param name="entity">IAudit</param>
        /// <returns>bool</returns>
		bool Delete(IAudit entity);
		
        /// <summary>
        /// Delete the Audit entity from the database using the Id
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		bool DeleteById(Guid id);

		#endregion
	}
}
