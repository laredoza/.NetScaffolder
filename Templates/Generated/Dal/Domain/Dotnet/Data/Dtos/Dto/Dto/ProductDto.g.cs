
// <copyright file="ProductDto.g.cs" company="MIT">
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
	public partial class ProductDto : IProduct 
	{
		#region CTOR
		
		public ProductDto()
		{
			this.OrderDetails = new List <IOrderDetails>();
		}
		
		public ProductDto(IProduct item, bool deep = false)
		{
			if(item == null) return;
			
			this.ProductId = item.ProductId;
			this.ProductDescription = item.ProductDescription;
			this.UnitPrice = item.UnitPrice;
			this.UnitAmount = item.UnitAmount;
			this.Publisher = item.Publisher;
			this.AmountInStock = item.AmountInStock;
			this.OrderDetails = new List <IOrderDetails>();

			if(deep)
			{
				if(item.OrderDetails != null)
				{
					foreach(var childItem in item.OrderDetails)
					{
						this.OrderDetails.Add(new OrderDetailsDto(childItem, deep));
					}
				}
				this.Software = new SoftwareDto(item.Software, deep);
                if(item.Book != null)
                {
				    this.Book = new BookDto(item.Book, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int ProductId { get; set; }
		public string ProductDescription { get; set; }
		public Nullable<decimal> UnitPrice { get; set; }
		public string UnitAmount { get; set; }
		public string Publisher { get; set; }
		public Nullable<short> AmountInStock { get; set; }

		#endregion
		
		#region Child Relationships
		
		public IList<IOrderDetails> OrderDetails { get; set; }
		public ISoftware Software { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public IBook Book { get; set; }
		
		#endregion
	}
}
