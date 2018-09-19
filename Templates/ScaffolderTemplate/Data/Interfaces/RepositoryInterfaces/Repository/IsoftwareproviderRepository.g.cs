
// <copyright file="softwareprovider.g.cs" company="Dot Net Scaffolder">
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
	/// The softwareproviderRepository interface that defines database functions for the softwareprovider table
	/// </summary>
	public partial interface IsoftwareproviderRepository : IRepository<Isoftwareprovider>
	{
		#region Load

        /// <summary>
        /// Load softwareprovider entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">string</param>
        /// <returns>Isoftwareprovider</returns>
		Isoftwareprovider LoadByid(string id);

        /// <summary>
        /// Load softwareprovider entities from the database using the ProductIdDDB field
        /// </summary>
        /// <param name="productIdDDB">int</param>
        /// <returns>IList<Isoftwareprovider></returns>
		IList<Isoftwareprovider> LoadByProductIdDDB(int productIdDDB);

        /// <summary>
        /// Load all softwareprovider entities from the database.
        /// </summary>
        /// <returns>IList<Isoftwareprovider></returns>
		IList<Isoftwareprovider> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for softwareprovider entities in the database by name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<Isoftwareprovider></returns>
		IList<Isoftwareprovider> SearchByname(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for softwareprovider entities in the database by x1
        /// </summary>
        /// <param name="x1">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<Isoftwareprovider></returns>
		IList<Isoftwareprovider> SearchByx1(string x1, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the softwareprovider entity to the database.
        /// </summary>
        /// <param name="entity">Isoftwareprovider</param>
        /// <returns>bool</returns>
		bool Save(Isoftwareprovider entity);

        /// <summary>
        /// Update the softwareprovider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Isoftwareprovider</param>
        /// <returns>bool</returns>
		bool Update(Isoftwareprovider entity);
		
        /// <summary>
        /// Delete the softwareprovider entity from the database
        /// </summary>
        /// <param name="entity">Isoftwareprovider</param>
        /// <returns>bool</returns>
		bool Delete(Isoftwareprovider entity);

		/// <summary>
        /// Delete the softwareprovider entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		bool Delete( string id);

		#endregion
	}
}
