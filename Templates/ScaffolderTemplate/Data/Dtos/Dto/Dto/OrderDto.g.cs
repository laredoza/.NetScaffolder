﻿
// <copyright file="OrderDto.g.cs" company="Dot Net Scaffolder">
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
	public partial class OrderDto : IOrder 
	{
		#region CTOR
		
		public OrderDto()
		{
			this.softwareprovider = new List <Isoftwareprovider>();
			this.OrderDetails = new List <IOrderDetails>();
		}
		
		public OrderDto(IOrder item, bool deep = false)
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
			this.softwareprovider = new List <Isoftwareprovider>();
			this.OrderDetails = new List <IOrderDetails>();

			if(deep)
			{
				if(item.softwareprovider != null)
				{
					foreach(var childItem in item.softwareprovider)
					{
						this.softwareprovider.Add(new softwareproviderDto(childItem, deep));
					}
				}
				if(item.OrderDetails != null)
				{
					foreach(var childItem in item.OrderDetails)
					{
						this.OrderDetails.Add(new OrderDetailsDto(childItem, deep));
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
		
		public int OrderId { get; set; }
		public Nullable<int> CustomerId { get; set; }
		public Nullable<DateTime> OrderDate { get; set; }
		public Nullable<DateTime> DeliveryDate { get; set; }
		public string ShippingName { get; set; }
		public string ShippingAddress { get; set; }
		public string ShippingCity { get; set; }
		public string ShippingZip { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<Isoftwareprovider> softwareprovider { get; set; }
		public IList<IOrderDetails> OrderDetails { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ICustomer Customer { get; set; }
		
		#endregion
	}
}