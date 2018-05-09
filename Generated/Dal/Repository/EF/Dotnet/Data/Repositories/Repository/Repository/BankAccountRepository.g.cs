
// <copyright file="BankAccount.g.cs" company="MIT">
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
	/// The BankAccountRepository class responsible for database functions in the BankAccount table
	/// </summary>
	public partial class BankAccountRepository : UowRepository<BankAccount> , IBankAccountRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BankAccountRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BankAccountRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the BankAccount entity from the database using the BankAccountId primary key
        /// </summary>
        /// <param name="bankaccountid">int</param>
        /// <returns>IBankAccount</returns>
		public virtual IBankAccount LoadByBankAccountId(int bankaccountid)
		{
			return this.UnitOfWork.FirstOrDefault<BankAccount>(o => o.BankAccountId == bankaccountid);
		}
		
        /// <summary>
        /// Load BankAccount entities from the database using the BankAccountNumber field
        /// </summary>
        /// <param name="bankaccountnumber">string</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByBankAccountNumber(string bankaccountnumber)
		{
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.BankAccountNumber == bankaccountnumber).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load BankAccount entities from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByBalance(decimal balance)
		{
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.Balance == balance).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load BankAccount entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">Nullable<int></param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByCustomerId(Nullable<int> customerid)
		{
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.CustomerId == customerid).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load BankAccount entities from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadByLocked(bool locked)
		{
			return this.UnitOfWork.AllMatching<BankAccount>(o => o.Locked == locked).ToList<IBankAccount>();
		}
		
        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> LoadAll()
		{
			return this.UnitOfWork.GetAll<BankAccount>().ToList<IBankAccount>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankaccountnumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
		public virtual IList<IBankAccount> SearchByBankAccountNumber(string bankaccountnumber, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<BankAccount>(o => o.BankAccountNumber.ToLower().Contains(bankaccountnumber.ToLower())).ToList<IBankAccount>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<BankAccount>(o => o.BankAccountNumber.Contains(bankaccountnumber)).ToList<IBankAccount>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool Save(IBankAccount entity)
		{
			var entityToSave = new BankAccount(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool Update(IBankAccount entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<BankAccount>(o => o.BankAccountId == entity.BankAccountId);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The BankAccount entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.BankAccountNumber != entity.BankAccountNumber) { entityToUpdate.BankAccountNumber = entity.BankAccountNumber;doUpdate = true; }
			if (entityToUpdate.Balance != entity.Balance) { entityToUpdate.Balance = entity.Balance;doUpdate = true; }
			if (entityToUpdate.CustomerId != entity.CustomerId) { entityToUpdate.CustomerId = entity.CustomerId;doUpdate = true; }
			if (entityToUpdate.Locked != entity.Locked) { entityToUpdate.Locked = entity.Locked;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IBankAccount entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankAccount>(o => o.BankAccountId == entity.BankAccountId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankAccount entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the BankAccount entity from the database using the BankAccountId
        /// </summary>
        /// <param name="bankaccountid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByBankAccountId(int bankaccountid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankAccount>(o => o.BankAccountId == bankaccountid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankAccount entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
