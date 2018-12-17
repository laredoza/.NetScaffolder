
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
using RepositoryEFDotnet.Data.Interfaces;

namespace RepositoryEFDotnet.Data.Entity
{
	public partial class BankAccount : IBankAccount 
	{
		#region CTOR
		
		public BankAccount()
		{
			this.BankTransfers = new List <BankTransfers>();
			this.BankTransfers1 = new List <BankTransfers>();
		}
		
		public BankAccount(IBankAccount item, bool deep = false)
		{
			if(item == null) return;
			
			this.BankAccountId = item.BankAccountId;
			this.BankAccountNumber = item.BankAccountNumber;
			this.Balance = item.Balance;
			this.CustomerId = item.CustomerId;
			this.Locked = item.Locked;
			this.BankTransfers = new List <BankTransfers>();
			this.BankTransfers1 = new List <BankTransfers>();

			if(deep)
			{
				if(item.BankTransfers != null)
				{
					foreach(var childItem in item.BankTransfers)
					{
						this.BankTransfers.Add(new BankTransfers(childItem, deep));
					}
				}
				if(item.BankTransfers1 != null)
				{
					foreach(var childItem in item.BankTransfers1)
					{
						this.BankTransfers1.Add(new BankTransfers(childItem, deep));
					}
				}
				if(item.Customer != null)
                {
                    this.Customer = new Customer(item.Customer, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public virtual int BankAccountId { get; set; }
		public virtual string BankAccountNumber { get; set; }
		public virtual decimal Balance { get; set; }
		public virtual Nullable<int> CustomerId { get; set; }
		public virtual bool Locked { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<BankTransfers> BankTransfers { get; set; }
	
        IList<IBankTransfers> IBankAccount.BankTransfers 
		{ 
			get
			{
				return this.BankTransfers == null ? null : (IList<IBankTransfers>)this.BankTransfers;
			}
			set
			{
				if(value != this.BankTransfers)
				{
					if(value != null)
					{
						this.BankTransfers = (IList<BankTransfers>)value;
					}
					else
					{
						this.BankTransfers = null;
					}
				}
			}			
		}
        
        public virtual IList<BankTransfers> BankTransfers1 { get; set; }
	
        IList<IBankTransfers> IBankAccount.BankTransfers1 
		{ 
			get
			{
				return this.BankTransfers1 == null ? null : (IList<IBankTransfers>)this.BankTransfers1;
			}
			set
			{
				if(value != this.BankTransfers1)
				{
					if(value != null)
					{
						this.BankTransfers1 = (IList<BankTransfers>)value;
					}
					else
					{
						this.BankTransfers1 = null;
					}
				}
			}			
		}

		#endregion

		#region Parent Relationships

        public virtual Customer Customer { get; set; }
		ICustomer IBankAccount.Customer 
		{ 
			get
			{
				return this.Customer;
			}
			set
			{
				if(value != this.Customer)
				{
					if(value != null)
					{
						this.Customer = (Customer)value;
					}
					else
					{
						this.Customer = null;
					}
				}
			}
		}
		
		#endregion
	}
}
