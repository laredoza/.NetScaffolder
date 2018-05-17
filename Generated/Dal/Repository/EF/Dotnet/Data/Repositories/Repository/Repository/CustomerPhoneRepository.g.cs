
// <copyright file="CustomerPhone.g.cs" company="MIT">
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
	/// The CustomerPhoneRepository class responsible for database functions in the CustomerPhone table
	/// </summary>
	public partial class CustomerPhoneRepository : UowRepository<CustomerPhone> , ICustomerPhoneRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CustomerPhoneRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CustomerPhoneRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load CustomerPhone entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">int</param>
        /// <returns>IList<ICustomerPhone></returns>
		public virtual IList<ICustomerPhone> LoadByCustomerId(int customerid)
		{
			return this.UnitOfWork.AllMatching<CustomerPhone>(o => o.CustomerId == customerid).ToList<ICustomerPhone>();
		}
		
        /// <summary>
        /// Load CustomerPhone entities from the database using the PhoneId field
        /// </summary>
        /// <param name="phoneid">int</param>
        /// <returns>IList<ICustomerPhone></returns>
		public virtual IList<ICustomerPhone> LoadByPhoneId(int phoneid)
		{
			return this.UnitOfWork.AllMatching<CustomerPhone>(o => o.PhoneId == phoneid).ToList<ICustomerPhone>();
		}
		
        /// <summary>
        /// Load all CustomerPhone entities from the database.
        /// </summary>
        /// <returns>IList<ICustomerPhone></returns>
		public virtual IList<ICustomerPhone> LoadAll()
		{
			return this.UnitOfWork.GetAll<CustomerPhone>().ToList<ICustomerPhone>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CustomerPhone entity to the database.
        /// </summary>
        /// <param name="entity">ICustomerPhone</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICustomerPhone entity)
		{
			var entityToSave = new CustomerPhone(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
		
		#endregion
	}
}
