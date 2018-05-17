
// <copyright file="Premium_Audit.g.cs" company="MIT">
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
	/// The Premium_AuditRepository interface that defines database functions for the Premium_Audit table
	/// </summary>
	public partial interface IPremium_AuditRepository : IRepository<IPremium_Audit>
	{
		#region Load

        /// <summary>
        /// Load the Premium_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IPremium_Audit</returns>
		IPremium_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load Premium_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadById(int id);

        /// <summary>
        /// Load Premium_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load Premium_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load Premium_Audit entities from the database using the BasePremium field
        /// </summary>
        /// <param name="basepremium">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByBasePremium(Nullable<decimal> basepremium);

        /// <summary>
        /// Load Premium_Audit entities from the database using the FinalPremium field
        /// </summary>
        /// <param name="finalpremium">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByFinalPremium(Nullable<decimal> finalpremium);

        /// <summary>
        /// Load Premium_Audit entities from the database using the PercentageLoading field
        /// </summary>
        /// <param name="percentageloading">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByPercentageLoading(Nullable<decimal> percentageloading);

        /// <summary>
        /// Load Premium_Audit entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByPremiumProfileId(Nullable<int> premiumprofileid);

        /// <summary>
        /// Load Premium_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByProductId(Nullable<int> productid);

        /// <summary>
        /// Load Premium_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load Premium_Audit entities from the database using the UnitLoading field
        /// </summary>
        /// <param name="unitloading">Nullable<decimal></param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadByUnitLoading(Nullable<decimal> unitloading);

        /// <summary>
        /// Load all Premium_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Premium_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremium_Audit></returns>
		IList<IPremium_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Premium_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IPremium_Audit</param>
        /// <returns>bool</returns>
		bool Save(IPremium_Audit entity);
		
        /// <summary>
        /// Update the Premium_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPremium_Audit</param>
        /// <returns>bool</returns>
		bool Update(IPremium_Audit entity);
		
        /// <summary>
        /// Delete the Premium_Audit entity from the database
        /// </summary>
        /// <param name="entity">IPremium_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IPremium_Audit entity);
		
        /// <summary>
        /// Delete the Premium_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
