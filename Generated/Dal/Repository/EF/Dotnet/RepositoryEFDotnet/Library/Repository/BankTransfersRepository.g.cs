
// <copyright file="BankTransfers.g.cs" company="MIT">
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
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The BankTransfersRepository class responsible for database functions in the BankTransfers table
	/// </summary>
	public partial class BankTransfersRepository : UowRepository<BankTransfers> , IBankTransfersRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BankTransfersRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BankTransfersRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the BankTransfers entity from the database using the BankTransferId primary key
        /// </summary>
        /// <param name="banktransferid">int</param>
        /// <returns>IBankTransfers</returns>
		public IBankTransfers LoadByBankTransferId(int banktransferid)
		{
			return this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == banktransferid);
		}
		
        /// <summary>
        /// Load BankTransfers entities from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="frombankaccountid">int</param>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> LoadByFromBankAccountId(int frombankaccountid)
		{
			return (IList<IBankTransfers>)this.UnitOfWork.AllMatching<BankTransfers>(o => o.FromBankAccountId == frombankaccountid);
		}
		
        /// <summary>
        /// Load BankTransfers entities from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="tobankaccountid">int</param>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> LoadByToBankAccountId(int tobankaccountid)
		{
			return (IList<IBankTransfers>)this.UnitOfWork.AllMatching<BankTransfers>(o => o.ToBankAccountId == tobankaccountid);
		}
		
        /// <summary>
        /// Load BankTransfers entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> LoadByAmount(decimal amount)
		{
			return (IList<IBankTransfers>)this.UnitOfWork.AllMatching<BankTransfers>(o => o.Amount == amount);
		}
		
        /// <summary>
        /// Load BankTransfers entities from the database using the TransferDate field
        /// </summary>
        /// <param name="transferdate">DateTime</param>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> LoadByTransferDate(DateTime transferdate)
		{
			return (IList<IBankTransfers>)this.UnitOfWork.AllMatching<BankTransfers>(o => o.TransferDate == transferdate);
		}
		
        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> LoadAll()
		{
			return (IList<IBankTransfers>)this.UnitOfWork.GetAll<BankTransfers>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool Save(IBankTransfers entity)
		{
			var entityToSave = new BankTransfers(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool Update(IBankTransfers entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == entity.BankTransferId);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.FromBankAccountId != entity.FromBankAccountId) { entityToUpdate.FromBankAccountId = entity.FromBankAccountId;doUpdate = true; }
			if (entityToUpdate.ToBankAccountId != entity.ToBankAccountId) { entityToUpdate.ToBankAccountId = entity.ToBankAccountId;doUpdate = true; }
			if (entityToUpdate.Amount != entity.Amount) { entityToUpdate.Amount = entity.Amount;doUpdate = true; }
			if (entityToUpdate.TransferDate != entity.TransferDate) { entityToUpdate.TransferDate = entity.TransferDate;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool Delete(IBankTransfers entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == entity.BankTransferId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the BankTransfers entity from the database using the BankTransferId
        /// </summary>
        /// <param name="banktransferid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByBankTransferId(int banktransferid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BankTransfers>(o => o.BankTransferId == banktransferid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BankTransfers entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
