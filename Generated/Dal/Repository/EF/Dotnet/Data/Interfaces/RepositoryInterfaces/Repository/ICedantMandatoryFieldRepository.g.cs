
// <copyright file="CedantMandatoryField.g.cs" company="MIT">
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
	/// The CedantMandatoryFieldRepository interface that defines database functions for the CedantMandatoryField table
	/// </summary>
	public partial interface ICedantMandatoryFieldRepository : IRepository<ICedantMandatoryField>
	{
		#region Load

        /// <summary>
        /// Load the CedantMandatoryField entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantMandatoryField</returns>
		ICedantMandatoryField LoadById(int id);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadByUserName(string username);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the MandatoryFieldName field
        /// </summary>
        /// <param name="mandatoryfieldname">string</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadByMandatoryFieldName(string mandatoryfieldname);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the Selected field
        /// </summary>
        /// <param name="selected">Nullable<bool></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadBySelected(Nullable<bool> selected);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the ValidateType field
        /// </summary>
        /// <param name="validatetype">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadByValidateType(Nullable<int> validatetype);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadByCedantId(Nullable<int> cedantid);

        /// <summary>
        /// Load CedantMandatoryField entities from the database using the MandatoryFieldId field
        /// </summary>
        /// <param name="mandatoryfieldid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadByMandatoryFieldId(Nullable<int> mandatoryfieldid);

        /// <summary>
        /// Load all CedantMandatoryField entities from the database.
        /// </summary>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CedantMandatoryField entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for CedantMandatoryField entities in the database by MandatoryFieldName
        /// </summary>
        /// <param name="mandatoryfieldname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		IList<ICedantMandatoryField> SearchByMandatoryFieldName(string mandatoryfieldname, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantMandatoryField entity to the database.
        /// </summary>
        /// <param name="entity">ICedantMandatoryField</param>
        /// <returns>bool</returns>
		bool Save(ICedantMandatoryField entity);
		
        /// <summary>
        /// Update the CedantMandatoryField entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantMandatoryField</param>
        /// <returns>bool</returns>
		bool Update(ICedantMandatoryField entity);
		
        /// <summary>
        /// Delete the CedantMandatoryField entity from the database
        /// </summary>
        /// <param name="entity">ICedantMandatoryField</param>
        /// <returns>bool</returns>
		bool Delete(ICedantMandatoryField entity);
		
        /// <summary>
        /// Delete the CedantMandatoryField entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
