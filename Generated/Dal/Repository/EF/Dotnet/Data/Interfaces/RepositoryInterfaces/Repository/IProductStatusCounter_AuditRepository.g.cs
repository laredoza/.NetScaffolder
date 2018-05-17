
// <copyright file="ProductStatusCounter_Audit.g.cs" company="MIT">
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
	/// The ProductStatusCounter_AuditRepository interface that defines database functions for the ProductStatusCounter_Audit table
	/// </summary>
	public partial interface IProductStatusCounter_AuditRepository : IRepository<IProductStatusCounter_Audit>
	{
		#region Load

        /// <summary>
        /// Load the ProductStatusCounter_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IProductStatusCounter_Audit</returns>
		IProductStatusCounter_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadById(int id);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Counter field
        /// </summary>
        /// <param name="counter">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadByCounter(Nullable<int> counter);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadByProductId(Nullable<int> productid);

        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all ProductStatusCounter_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ProductStatusCounter_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		IList<IProductStatusCounter_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatusCounter_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatusCounter_Audit</param>
        /// <returns>bool</returns>
		bool Save(IProductStatusCounter_Audit entity);
		
        /// <summary>
        /// Update the ProductStatusCounter_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatusCounter_Audit</param>
        /// <returns>bool</returns>
		bool Update(IProductStatusCounter_Audit entity);
		
        /// <summary>
        /// Delete the ProductStatusCounter_Audit entity from the database
        /// </summary>
        /// <param name="entity">IProductStatusCounter_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IProductStatusCounter_Audit entity);
		
        /// <summary>
        /// Delete the ProductStatusCounter_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
