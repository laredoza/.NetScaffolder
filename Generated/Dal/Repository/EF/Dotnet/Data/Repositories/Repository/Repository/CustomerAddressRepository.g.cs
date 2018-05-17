
// <copyright file="CustomerAddress.g.cs" company="MIT">
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
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The CustomerAddressRepository class responsible for database functions in the CustomerAddress table
	/// </summary>
	public partial class CustomerAddressRepository : UowRepository<CustomerAddress> , ICustomerAddressRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CustomerAddressRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CustomerAddressRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load CustomerAddress entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">int</param>
        /// <returns>IList<ICustomerAddress></returns>
		public virtual IList<ICustomerAddress> LoadByCustomerId(int customerid)
		{
			return this.UnitOfWork.AllMatching<CustomerAddress>(o => o.CustomerId == customerid).ToList<ICustomerAddress>();
		}
		
        /// <summary>
        /// Load CustomerAddress entities from the database using the AddressId field
        /// </summary>
        /// <param name="addressid">int</param>
        /// <returns>IList<ICustomerAddress></returns>
		public virtual IList<ICustomerAddress> LoadByAddressId(int addressid)
		{
			return this.UnitOfWork.AllMatching<CustomerAddress>(o => o.AddressId == addressid).ToList<ICustomerAddress>();
		}
		
        /// <summary>
        /// Load all CustomerAddress entities from the database.
        /// </summary>
        /// <returns>IList<ICustomerAddress></returns>
		public virtual IList<ICustomerAddress> LoadAll()
		{
			return this.UnitOfWork.GetAll<CustomerAddress>().ToList<ICustomerAddress>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CustomerAddress entity to the database.
        /// </summary>
        /// <param name="entity">ICustomerAddress</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICustomerAddress entity)
		{
			var entityToSave = new CustomerAddress(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
		
		#endregion
	}
}
