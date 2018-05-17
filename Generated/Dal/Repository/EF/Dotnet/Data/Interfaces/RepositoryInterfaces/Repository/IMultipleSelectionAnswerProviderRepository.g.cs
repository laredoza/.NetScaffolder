
// <copyright file="MultipleSelectionAnswerProvider.g.cs" company="MIT">
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
	/// The MultipleSelectionAnswerProviderRepository interface that defines database functions for the MultipleSelectionAnswerProvider table
	/// </summary>
	public partial interface IMultipleSelectionAnswerProviderRepository : IRepository<IMultipleSelectionAnswerProvider>
	{
		#region Load

        /// <summary>
        /// Load the MultipleSelectionAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IMultipleSelectionAnswerProvider</returns>
		IMultipleSelectionAnswerProvider LoadById(int id);

        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the SetupTableID field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		IList<IMultipleSelectionAnswerProvider> LoadBySetupTableID(Nullable<int> setuptableid);

        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the AutoComplete field
        /// </summary>
        /// <param name="autocomplete">Nullable<int></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		IList<IMultipleSelectionAnswerProvider> LoadByAutoComplete(Nullable<int> autocomplete);

        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the UseSynonyms field
        /// </summary>
        /// <param name="usesynonyms">Nullable<bool></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		IList<IMultipleSelectionAnswerProvider> LoadByUseSynonyms(Nullable<bool> usesynonyms);

        /// <summary>
        /// Load MultipleSelectionAnswerProvider entities from the database using the StartsWith field
        /// </summary>
        /// <param name="startswith">Nullable<bool></param>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		IList<IMultipleSelectionAnswerProvider> LoadByStartsWith(Nullable<bool> startswith);

        /// <summary>
        /// Load all MultipleSelectionAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<IMultipleSelectionAnswerProvider></returns>
		IList<IMultipleSelectionAnswerProvider> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the MultipleSelectionAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">IMultipleSelectionAnswerProvider</param>
        /// <returns>bool</returns>
		bool Save(IMultipleSelectionAnswerProvider entity);
		
        /// <summary>
        /// Update the MultipleSelectionAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IMultipleSelectionAnswerProvider</param>
        /// <returns>bool</returns>
		bool Update(IMultipleSelectionAnswerProvider entity);
		
        /// <summary>
        /// Delete the MultipleSelectionAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">IMultipleSelectionAnswerProvider</param>
        /// <returns>bool</returns>
		bool Delete(IMultipleSelectionAnswerProvider entity);
		
        /// <summary>
        /// Delete the MultipleSelectionAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
