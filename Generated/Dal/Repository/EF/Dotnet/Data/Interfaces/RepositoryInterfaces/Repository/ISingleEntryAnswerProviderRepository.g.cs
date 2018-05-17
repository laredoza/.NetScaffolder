
// <copyright file="SingleEntryAnswerProvider.g.cs" company="MIT">
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
	/// The SingleEntryAnswerProviderRepository interface that defines database functions for the SingleEntryAnswerProvider table
	/// </summary>
	public partial interface ISingleEntryAnswerProviderRepository : IRepository<ISingleEntryAnswerProvider>
	{
		#region Load

        /// <summary>
        /// Load the SingleEntryAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISingleEntryAnswerProvider</returns>
		ISingleEntryAnswerProvider LoadById(int id);

        /// <summary>
        /// Load SingleEntryAnswerProvider entities from the database using the WithValidation field
        /// </summary>
        /// <param name="withvalidation">Nullable<bool></param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		IList<ISingleEntryAnswerProvider> LoadByWithValidation(Nullable<bool> withvalidation);

        /// <summary>
        /// Load SingleEntryAnswerProvider entities from the database using the ValidationName field
        /// </summary>
        /// <param name="validationname">string</param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		IList<ISingleEntryAnswerProvider> LoadByValidationName(string validationname);

        /// <summary>
        /// Load SingleEntryAnswerProvider entities from the database using the OverrideAnswer field
        /// </summary>
        /// <param name="overrideanswer">Nullable<bool></param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		IList<ISingleEntryAnswerProvider> LoadByOverrideAnswer(Nullable<bool> overrideanswer);

        /// <summary>
        /// Load all SingleEntryAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		IList<ISingleEntryAnswerProvider> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SingleEntryAnswerProvider entities in the database by ValidationName
        /// </summary>
        /// <param name="validationname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		IList<ISingleEntryAnswerProvider> SearchByValidationName(string validationname, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SingleEntryAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">ISingleEntryAnswerProvider</param>
        /// <returns>bool</returns>
		bool Save(ISingleEntryAnswerProvider entity);
		
        /// <summary>
        /// Update the SingleEntryAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISingleEntryAnswerProvider</param>
        /// <returns>bool</returns>
		bool Update(ISingleEntryAnswerProvider entity);
		
        /// <summary>
        /// Delete the SingleEntryAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">ISingleEntryAnswerProvider</param>
        /// <returns>bool</returns>
		bool Delete(ISingleEntryAnswerProvider entity);
		
        /// <summary>
        /// Delete the SingleEntryAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
