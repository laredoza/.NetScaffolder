
// <copyright file="BankTransfersDto.g.cs" company="MIT">
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
using RepositoryEFDotnet.Data.Interfaces;

namespace RepositoryEFDotnet.Data.Dto
{
	public partial class BankTransfersDto : IBankTransfers 
	{
		#region CTOR
		
		public BankTransfersDto()
		{
		}
		
		public BankTransfersDto(IBankTransfers item, bool deep = false)
		{
			if(item == null) return;
			
			this.BankTransferId = item.BankTransferId;
			this.FromBankAccountId = item.FromBankAccountId;
			this.ToBankAccountId = item.ToBankAccountId;
			this.Amount = item.Amount;
			this.TransferDate = item.TransferDate;
			this.BankAccountId = item.BankAccountId;

			if(deep)
			{
                if(item.BankAccount != null)
                {
				    this.BankAccount = new BankAccountDto(item.BankAccount, deep);
                }
                if(item.BankAccount1 != null)
                {
				    this.BankAccount1 = new BankAccountDto(item.BankAccount1, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int BankTransferId { get; set; }
		public int FromBankAccountId { get; set; }
		public int ToBankAccountId { get; set; }
		public decimal Amount { get; set; }
		public DateTime TransferDate { get; set; }
		public Nullable<int> BankAccountId { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IBankAccount BankAccount { get; set; }
		public IBankAccount BankAccount1 { get; set; }
		
		#endregion
	}
}
