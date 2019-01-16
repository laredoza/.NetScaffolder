
// <copyright file="BankAccountDto.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using Newtonsoft.Json;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto
{
	public partial class BankAccountDto : IBankAccount 
	{
		#region CTOR
		
		public BankAccountDto()
		{
			this.BankTransfers = new List <IBankTransfers>();
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

			if(deep)
			{
				if(item.BankTransfers != null)
				{
					foreach(var childItem in item.BankTransfers)
					{
						this.BankTransfers.Add(new BankTransfersDto(childItem, deep));
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
		
		public int BankAccountId { get; set; }
		public string BankAccountNumber { get; set; }
		public decimal Balance { get; set; }
		public Nullable<int> CustomerId { get; set; }
		public bool Locked { get; set; }

		#endregion
		
		#region Child Relationships
		
        // [JsonConverter(typeof(ConcreteTypeConverter<BankTransfersDto>))]
		public IList<IBankTransfers> BankTransfers { get; set; }

		#endregion
		
		#region Parent Relationships
		
        [JsonConverter(typeof(ConcreteTypeConverter<CustomerDto>))]
		public ICustomer Customer { get; set; }
		
		#endregion
	}
}
