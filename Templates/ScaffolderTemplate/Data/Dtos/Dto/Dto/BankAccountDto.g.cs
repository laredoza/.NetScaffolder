﻿
// <copyright file="BankAccountDto.g.cs" company="Dot Net Scaffolder">
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

namespace Banking.Models.Dto
{
	public partial class BankAccountDto : IBankAccount 
	{
		#region CTOR
		
		public BankAccountDto()
		{
			this.BankTransfers = new List <IBankTransfers>();
			this.BankTransfers1 = new List <IBankTransfers>();
		}
		
		public BankAccountDto(IBankAccount item, bool deep = false)
		{
			if(item == null) return;
			
			this.BankAccountId = item.BankAccountId;
			this.BankAccountNumber = item.BankAccountNumber;
			this.Balance = item.Balance;
			this.CustomerId = item.CustomerId;
			this.Locked = item.Locked;
			this.BankTransfers = new List <IBankTransfers>();
			this.BankTransfers1 = new List <IBankTransfers>();

			if(deep)
			{
				if(item.BankTransfers != null)
				{
					foreach(var childItem in item.BankTransfers)
					{
						this.BankTransfers.Add(new BankTransfersDto(childItem, deep));
					}
				}
				if(item.BankTransfers1 != null)
				{
					foreach(var childItem in item.BankTransfers1)
					{
						this.BankTransfers1.Add(new BankTransfersDto(childItem, deep));
					}
				}
                if(item.Customer != null)
                {
				    this.Customer = new CustomerDto(item.Customer, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public long BankAccountId { get; set; }
		public string BankAccountNumber { get; set; }
		public decimal Balance { get; set; }
		public Nullable<int> CustomerId { get; set; }
		public bool Locked { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IBankTransfers> BankTransfers { get; set; }
		public IList<IBankTransfers> BankTransfers1 { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ICustomer Customer { get; set; }
		
		#endregion
	}
}