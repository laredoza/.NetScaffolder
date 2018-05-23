﻿
// <copyright file="ProductProfile_Audit.g.cs" company="MIT">
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
	/// The ProductProfile_AuditRepository interface that defines database functions for the ProductProfile_Audit table
	/// </summary>
	public partial interface IProductProfile_AuditRepository : IRepository<IProductProfile_Audit>
	{
		#region Load

        /// <summary>
        /// Load the ProductProfile_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IProductProfile_Audit</returns>
		IProductProfile_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load ProductProfile_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadById(int id);

        /// <summary>
        /// Load ProductProfile_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load ProductProfile_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load ProductProfile_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadByName(string name);

        /// <summary>
        /// Load ProductProfile_Audit entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadByDescription(string description);

        /// <summary>
        /// Load ProductProfile_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all ProductProfile_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ProductProfile_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for ProductProfile_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for ProductProfile_Audit entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile_Audit></returns>
		IList<IProductProfile_Audit> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductProfile_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IProductProfile_Audit</param>
        /// <returns>bool</returns>
		bool Save(IProductProfile_Audit entity);
		
        /// <summary>
        /// Update the ProductProfile_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductProfile_Audit</param>
        /// <returns>bool</returns>
		bool Update(IProductProfile_Audit entity);
		
        /// <summary>
        /// Delete the ProductProfile_Audit entity from the database
        /// </summary>
        /// <param name="entity">IProductProfile_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IProductProfile_Audit entity);
		
        /// <summary>
        /// Delete the ProductProfile_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}