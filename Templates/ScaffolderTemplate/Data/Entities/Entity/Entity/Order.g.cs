﻿
// <copyright file="Order.g.cs" company="Dot Net Scaffolder">
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

namespace Banking.Models.Entity
{
	public partial class Order : IOrder 
	{
		#region CTOR
		
		public Order()
		{
			this.softwareprovider = new List <softwareprovider>();
			this.OrderDetails = new List <OrderDetails>();
		}
		
		public Order(IOrder item, bool deep = false)
		{
			if(item == null) return;
			
			this.OrderId = item.OrderId;
			this.CustomerId = item.CustomerId;
			this.OrderDate = item.OrderDate;
			this.DeliveryDate = item.DeliveryDate;
			this.ShippingName = item.ShippingName;
			this.ShippingAddress = item.ShippingAddress;
			this.ShippingCity = item.ShippingCity;
			this.ShippingZip = item.ShippingZip;
			this.softwareprovider = new List <softwareprovider>();
			this.OrderDetails = new List <OrderDetails>();

			if(deep)
			{
				if(item.softwareprovider != null)
				{
					foreach(var childItem in item.softwareprovider)
					{
						this.softwareprovider.Add(new softwareprovider(childItem, deep));
					}
				}
				if(item.OrderDetails != null)
				{
					foreach(var childItem in item.OrderDetails)
					{
						this.OrderDetails.Add(new OrderDetails(childItem, deep));
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
		
		public virtual int OrderId { get; set; }
		public virtual Nullable<int> CustomerId { get; set; }
		public virtual Nullable<DateTime> OrderDate { get; set; }
		public virtual Nullable<DateTime> DeliveryDate { get; set; }
		public virtual string ShippingName { get; set; }
		public virtual string ShippingAddress { get; set; }
		public virtual string ShippingCity { get; set; }
		public virtual string ShippingZip { get; set; }

		#endregion

		#region Child Relationships
        
        public virtual IList<softwareprovider> softwareprovider { get; set; }
	
        IList<Isoftwareprovider> IOrder.softwareprovider 
		{ 
			get
			{
				return this.softwareprovider == null ? null : (IList<Isoftwareprovider>)this.softwareprovider;
			}
			set
			{
				if(value != this.softwareprovider)
				{
					if(value != null)
					{
						this.softwareprovider = (IList<softwareprovider>)value;
					}
					else
					{
						this.softwareprovider = null;
					}
				}
			}			
		}
        
        public virtual IList<OrderDetails> OrderDetails { get; set; }
	
        IList<IOrderDetails> IOrder.OrderDetails 
		{ 
			get
			{
				return this.OrderDetails == null ? null : (IList<IOrderDetails>)this.OrderDetails;
			}
			set
			{
				if(value != this.OrderDetails)
				{
					if(value != null)
					{
						this.OrderDetails = (IList<OrderDetails>)value;
					}
					else
					{
						this.OrderDetails = null;
					}
				}
			}			
		}

		#endregion

		#region Parent Relationships

        public virtual Customer Customer { get; set; }
		ICustomer IOrder.Customer 
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