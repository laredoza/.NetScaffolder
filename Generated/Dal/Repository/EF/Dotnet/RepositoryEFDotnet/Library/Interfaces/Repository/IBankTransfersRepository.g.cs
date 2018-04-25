
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
using Banking.Models.Interfaces;

namespace Banking.Models.Interfaces
{
	public partial interface IBankTransfersRepository
	{
		#region Load
		
		IBankTransfers LoadByBankTransferId(int banktransferid);
		IList<IBankTransfers> LoadByFromBankAccountId(int frombankaccountid);
		IList<IBankTransfers> LoadByToBankAccountId(int tobankaccountid);
		IList<IBankTransfers> LoadByAmount(decimal amount);
		IList<IBankTransfers> LoadByTransferDate(DateTime transferdate);
		IList<IBankTransfers> LoadAll();
		
		#endregion

		#region Search
		

		#endregion
		
		#region Modifiers
		
		bool Save(IBankTransfers entity);
		bool Update(IBankTransfers entity);
		bool Delete(IBankTransfers entity);
		bool DeleteByBankTransferId(int banktransferid);

		#endregion
	}
}
