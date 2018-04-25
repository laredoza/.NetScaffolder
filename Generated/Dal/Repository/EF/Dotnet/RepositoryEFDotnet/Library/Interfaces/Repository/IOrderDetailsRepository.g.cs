﻿
// <copyright file="OrderDetails.g.cs" company="MIT">
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
	public partial interface IOrderDetailsRepository
	{
		#region Load
		
		IOrderDetails LoadByOrderDetailsId(int orderdetailsid);
		IList<IOrderDetails> LoadByOrderId(int orderid);
		IList<IOrderDetails> LoadByProductId(int productid);
		IList<IOrderDetails> LoadByUnitPrice(decimal unitprice);
		IList<IOrderDetails> LoadByAmount(short amount);
		IList<IOrderDetails> LoadByDiscount(float discount);
		IList<IOrderDetails> LoadAll();
		
		#endregion

		#region Search
		

		#endregion
		
		#region Modifiers
		
		bool Save(IOrderDetails entity);
		bool Update(IOrderDetails entity);
		bool Delete(IOrderDetails entity);
		bool DeleteByOrderDetailsId(int orderdetailsid);

		#endregion
	}
}