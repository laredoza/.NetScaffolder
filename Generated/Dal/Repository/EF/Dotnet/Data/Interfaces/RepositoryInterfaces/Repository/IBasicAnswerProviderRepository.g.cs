
// <copyright file="BasicAnswerProvider.g.cs" company="MIT">
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
	/// The BasicAnswerProviderRepository interface that defines database functions for the BasicAnswerProvider table
	/// </summary>
	public partial interface IBasicAnswerProviderRepository : IRepository<IBasicAnswerProvider>
	{
		#region Load

        /// <summary>
        /// Load the BasicAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IBasicAnswerProvider</returns>
		IBasicAnswerProvider LoadById(int id);

        /// <summary>
        /// Load BasicAnswerProvider entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		IList<IBasicAnswerProvider> LoadByValue(string value);

        /// <summary>
        /// Load BasicAnswerProvider entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		IList<IBasicAnswerProvider> LoadByText(string text);

        /// <summary>
        /// Load BasicAnswerProvider entities from the database using the OverrideAnswer field
        /// </summary>
        /// <param name="overrideanswer">Nullable<bool></param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		IList<IBasicAnswerProvider> LoadByOverrideAnswer(Nullable<bool> overrideanswer);

        /// <summary>
        /// Load all BasicAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<IBasicAnswerProvider></returns>
		IList<IBasicAnswerProvider> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for BasicAnswerProvider entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		IList<IBasicAnswerProvider> SearchByValue(string value, bool caseSensitive = false);

        /// <summary>
        /// Search for BasicAnswerProvider entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		IList<IBasicAnswerProvider> SearchByText(string text, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the BasicAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">IBasicAnswerProvider</param>
        /// <returns>bool</returns>
		bool Save(IBasicAnswerProvider entity);
		
        /// <summary>
        /// Update the BasicAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBasicAnswerProvider</param>
        /// <returns>bool</returns>
		bool Update(IBasicAnswerProvider entity);
		
        /// <summary>
        /// Delete the BasicAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">IBasicAnswerProvider</param>
        /// <returns>bool</returns>
		bool Delete(IBasicAnswerProvider entity);
		
        /// <summary>
        /// Delete the BasicAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
