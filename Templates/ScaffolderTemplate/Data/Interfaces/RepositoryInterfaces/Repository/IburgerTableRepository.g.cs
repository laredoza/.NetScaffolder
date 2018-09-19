
// <copyright file="burgerTable.g.cs" company="Dot Net Scaffolder">
//  Copyright (c) 2018 MIT License
// </copyright>  

 // Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in th
// e Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subj
// ect to the following conditions: The above copyright notice and this permission 
// notice shall be included in all copies or substantial portions of the Software. 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLI
// ED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR 
// A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYR
// IGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WIT
// H THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System;
using System.Collections.Generic;
using Banking.Models.Interfaces;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The burgerTableRepository interface that defines database functions for the burgerTable table
	/// </summary>
	public partial interface IburgerTableRepository : IRepository<IburgerTable>
	{
		#region Load

        /// <summary>
        /// Load burgerTable entities from the database using the composite primary keys
        /// </summary
        /// <param name="id1">int</param>
        /// <param name="id2">int</param>
        /// <returns>IburgerTable</returns>
		IburgerTable Load( int id1,  int id2);

        /// <summary>
        /// Load all burgerTable entities from the database.
        /// </summary>
        /// <returns>IList<IburgerTable></returns>
		IList<IburgerTable> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for burgerTable entities in the database by description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IburgerTable></returns>
		IList<IburgerTable> SearchBydescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the burgerTable entity to the database.
        /// </summary>
        /// <param name="entity">IburgerTable</param>
        /// <returns>bool</returns>
		bool Save(IburgerTable entity);

        /// <summary>
        /// Update the burgerTable entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IburgerTable</param>
        /// <returns>bool</returns>
		bool Update(IburgerTable entity);
		
        /// <summary>
        /// Delete the burgerTable entity from the database
        /// </summary>
        /// <param name="entity">IburgerTable</param>
        /// <returns>bool</returns>
		bool Delete(IburgerTable entity);

		/// <summary>
        /// Delete the burgerTable entity from the database
        /// </summary>
        /// <param name="id1">int</param>
        /// <param name="id2">int</param>
        /// <returns>bool</returns>
		bool Delete( int id1,  int id2);

		#endregion
	}
}
