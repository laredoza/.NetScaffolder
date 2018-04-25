
// <copyright file="Order.g.cs" company="MIT">
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
	public partial class OrderRepository : IOrderRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		public OrderRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
		public IOrder LoadByOrderId(int orderid)
		{
			return this.UnitOfWork.FirstOrDefault(o => o.OrderId == orderid);
		}
		
		public IList<IOrder> LoadByCustomerId(int customerid)
		{
			return this.UnitOfWork.AllMatching(o => o.CustomerId == customerid);
		}
		
		public IList<IOrder> LoadByOrderDate(DateTime orderdate)
		{
			return this.UnitOfWork.AllMatching(o => o.OrderDate == orderdate);
		}
		
		public IList<IOrder> LoadByDeliveryDate(DateTime deliverydate)
		{
			return this.UnitOfWork.AllMatching(o => o.DeliveryDate == deliverydate);
		}
		
		public IList<IOrder> LoadByShippingName(string shippingname)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingName == shippingname);
		}
		
		public IList<IOrder> LoadByShippingAddress(string shippingaddress)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingAddress == shippingaddress);
		}
		
		public IList<IOrder> LoadByShippingCity(string shippingcity)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingCity == shippingcity);
		}
		
		public IList<IOrder> LoadByShippingZip(string shippingzip)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingZip == shippingzip);
		}
		
		public IList<IOrder> LoadAll()
		{
			return this.UnitOfWork.LoadAll();
		}
		
		#endregion

		#region Search
		
		public IList<IOrder> SearchByShippingName(string shippingname)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingName.Contains(shippingname));
		}
		
		public IList<IOrder> SearchByShippingAddress(string shippingaddress)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingAddress.Contains(shippingaddress));
		}
		
		public IList<IOrder> SearchByShippingCity(string shippingcity)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingCity.Contains(shippingcity));
		}
		
		public IList<IOrder> SearchByShippingZip(string shippingzip)
		{
			return this.UnitOfWork.AllMatching(o => o.ShippingZip.Contains(shippingzip));
		}
		
		#endregion
		
		#region CRUD
		
		public bool Save(IOrder entity)
		{
			return false;
		}
		
		public bool Update(IOrder entity)
		{
			return false;
		}

		public bool Delete(IOrder entity)
		{
			return false;
		}

		public bool DeleteByOrderId(int orderid)
		{
			return false;
		}
		
		#endregion
	}
}
