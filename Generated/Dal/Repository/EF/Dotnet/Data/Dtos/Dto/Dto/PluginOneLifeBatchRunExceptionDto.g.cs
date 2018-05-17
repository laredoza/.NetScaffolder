
// <copyright file="PluginOneLifeBatchRunExceptionDto.g.cs" company="MIT">
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

namespace Banking.Models.Dto
{
	public partial class PluginOneLifeBatchRunExceptionDto : IPluginOneLifeBatchRunException 
	{
		#region CTOR
		
		public PluginOneLifeBatchRunExceptionDto()
		{
		}
		
		public PluginOneLifeBatchRunExceptionDto(IPluginOneLifeBatchRunException item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.PluginOneLifeBatchRunPolicyId = item.PluginOneLifeBatchRunPolicyId;
			this.ProductName = item.ProductName;
			this.ProductResult = item.ProductResult;
			this.QUIRCProductName = item.QUIRCProductName;
			this.QUIRCProductResult = item.QUIRCProductResult;
			this.Message = item.Message;
			this.PolicyResult = item.PolicyResult;
			this.ProductLoading = item.ProductLoading;
			this.ProductReferences = item.ProductReferences;
			this.QUIRCPolicyResult = item.QUIRCPolicyResult;
			this.QUIRCProductLoading = item.QUIRCProductLoading;
			this.QUIRCProductReferences = item.QUIRCProductReferences;

			if(deep)
			{
                if(item.PluginOneLifeBatchRunPolicy != null)
                {
				    this.PluginOneLifeBatchRunPolicy = new PluginOneLifeBatchRunPolicyDto(item.PluginOneLifeBatchRunPolicy, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public Nullable<int> PluginOneLifeBatchRunPolicyId { get; set; }
		public string ProductName { get; set; }
		public string ProductResult { get; set; }
		public string QUIRCProductName { get; set; }
		public string QUIRCProductResult { get; set; }
		public string Message { get; set; }
		public string PolicyResult { get; set; }
		public string ProductLoading { get; set; }
		public string ProductReferences { get; set; }
		public string QUIRCPolicyResult { get; set; }
		public string QUIRCProductLoading { get; set; }
		public string QUIRCProductReferences { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IPluginOneLifeBatchRunPolicy PluginOneLifeBatchRunPolicy { get; set; }
		
		#endregion
	}
}
