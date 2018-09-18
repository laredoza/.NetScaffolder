
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

namespace Banking.Models.Entity
{
	public partial class BankTransfers : IBankTransfers 
	{
		#region CTOR
		
		public BankTransfers()
		{
		}
		
		public BankTransfers(IBankTransfers item, bool deep = false)
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
                    this.BankAccount = new BankAccount(item.BankAccount, deep);
                }
				if(item.BankAccount1 != null)
                {
                    this.BankAccount1 = new BankAccount(item.BankAccount1, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int BankTransferId { get; set; }
		public virtual int FromBankAccountId { get; set; }
		public virtual int ToBankAccountId { get; set; }
		public virtual decimal Amount { get; set; }
		public virtual DateTime TransferDate { get; set; }
		public virtual Nullable<int> BankAccountId { get; set; }

		#endregion

		#region Parent Relationships

        public virtual BankAccount BankAccount { get; set; }
		IBankAccount IBankTransfers.BankAccount 
		{ 
			get
			{
				return this.BankAccount;
			}
			set
			{
				if(value != this.BankAccount)
				{
					if(value != null)
					{
						this.BankAccount = (BankAccount)value;
					}
					else
					{
						this.BankAccount = null;
					}
				}
			}
		}

        public virtual BankAccount BankAccount1 { get; set; }
		IBankAccount IBankTransfers.BankAccount1 
		{ 
			get
			{
				return this.BankAccount1;
			}
			set
			{
				if(value != this.BankAccount1)
				{
					if(value != null)
					{
						this.BankAccount1 = (BankAccount)value;
					}
					else
					{
						this.BankAccount1 = null;
					}
				}
			}
		}
		
		#endregion
	}
}
