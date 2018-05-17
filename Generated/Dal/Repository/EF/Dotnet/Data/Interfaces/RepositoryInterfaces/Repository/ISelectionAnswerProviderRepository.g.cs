
// <copyright file="SelectionAnswerProvider.g.cs" company="MIT">
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
	/// The SelectionAnswerProviderRepository interface that defines database functions for the SelectionAnswerProvider table
	/// </summary>
	public partial interface ISelectionAnswerProviderRepository : IRepository<ISelectionAnswerProvider>
	{
		#region Load

        /// <summary>
        /// Load the SelectionAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISelectionAnswerProvider</returns>
		ISelectionAnswerProvider LoadById(int id);

        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the SetupTableId field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadBySetupTableId(Nullable<int> setuptableid);

        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the WithFilter field
        /// </summary>
        /// <param name="withfilter">Nullable<bool></param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadByWithFilter(Nullable<bool> withfilter);

        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the WithFilterValue field
        /// </summary>
        /// <param name="withfiltervalue">string</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadByWithFilterValue(string withfiltervalue);

        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the AutoComplete field
        /// </summary>
        /// <param name="autocomplete">bool</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadByAutoComplete(bool autocomplete);

        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the StartsWith field
        /// </summary>
        /// <param name="startswith">bool</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadByStartsWith(bool startswith);

        /// <summary>
        /// Load SelectionAnswerProvider entities from the database using the UseSynonyms field
        /// </summary>
        /// <param name="usesynonyms">Nullable<bool></param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadByUseSynonyms(Nullable<bool> usesynonyms);

        /// <summary>
        /// Load all SelectionAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SelectionAnswerProvider entities in the database by WithFilterValue
        /// </summary>
        /// <param name="withfiltervalue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISelectionAnswerProvider></returns>
		IList<ISelectionAnswerProvider> SearchByWithFilterValue(string withfiltervalue, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SelectionAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">ISelectionAnswerProvider</param>
        /// <returns>bool</returns>
		bool Save(ISelectionAnswerProvider entity);
		
        /// <summary>
        /// Update the SelectionAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISelectionAnswerProvider</param>
        /// <returns>bool</returns>
		bool Update(ISelectionAnswerProvider entity);
		
        /// <summary>
        /// Delete the SelectionAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">ISelectionAnswerProvider</param>
        /// <returns>bool</returns>
		bool Delete(ISelectionAnswerProvider entity);
		
        /// <summary>
        /// Delete the SelectionAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
