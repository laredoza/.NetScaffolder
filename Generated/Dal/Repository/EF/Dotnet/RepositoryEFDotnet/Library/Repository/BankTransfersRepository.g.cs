
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

namespace Banking.Models.Repository
{
	public partial class BankTransfersRepository : IBankTransfersRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		public BankTransfersRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
		public IBankTransfers LoadByBankTransferId(int banktransferid)
		{
			return this.UnitOfWork.FirstOrDefault(o => o.BankTransferId == banktransferid);
		}
		
		public IList<IBankTransfers> LoadByFromBankAccountId(int frombankaccountid)
		{
			return this.UnitOfWork.AllMatching(o => o.FromBankAccountId == frombankaccountid);
		}
		
		public IList<IBankTransfers> LoadByToBankAccountId(int tobankaccountid)
		{
			return this.UnitOfWork.AllMatching(o => o.ToBankAccountId == tobankaccountid);
		}
		
		public IList<IBankTransfers> LoadByAmount(decimal amount)
		{
			return this.UnitOfWork.AllMatching(o => o.Amount == amount);
		}
		
		public IList<IBankTransfers> LoadByTransferDate(DateTime transferdate)
		{
			return this.UnitOfWork.AllMatching(o => o.TransferDate == transferdate);
		}
		
		public IList<IBankTransfers> LoadAll()
		{
			return this.UnitOfWork.LoadAll();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region CRUD
		
		public bool Save(IBankTransfers entity)
		{
			return false;
		}
		
		public bool Update(IBankTransfers entity)
		{
			return false;
		}

		public bool Delete(IBankTransfers entity)
		{
			return false;
		}

		public bool DeleteByBankTransferId(int banktransferid)
		{
			return false;
		}
		
		#endregion
	}
}
