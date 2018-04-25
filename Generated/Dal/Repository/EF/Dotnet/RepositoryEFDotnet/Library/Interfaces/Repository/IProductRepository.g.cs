
// <copyright file="Product.g.cs" company="MIT">
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
	public partial interface IProductRepository
	{
		#region Load
		
		IProduct LoadByProductId(int productid);
		IList<IProduct> LoadByProductDescription(string productdescription);
		IList<IProduct> LoadByUnitPrice(decimal unitprice);
		IList<IProduct> LoadByUnitAmount(string unitamount);
		IList<IProduct> LoadByPublisher(string publisher);
		IList<IProduct> LoadByAmountInStock(short amountinstock);
		IList<IProduct> LoadAll();
		
		#endregion

		#region Search
		
		IList<IProduct> SearchByProductDescription(string productdescription);
		IList<IProduct> SearchByUnitAmount(string unitamount);
		IList<IProduct> SearchByPublisher(string publisher);

		#endregion
		
		#region CRUD
		
		bool Save(IProduct entity);
		bool Update(IProduct entity);
		bool Delete(IProduct entity);
		bool DeleteByProductId(int productid);

		#endregion
	}
}
