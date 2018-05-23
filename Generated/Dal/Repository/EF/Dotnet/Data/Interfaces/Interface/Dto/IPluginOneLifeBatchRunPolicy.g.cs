﻿
// <copyright file="PluginOneLifeBatchRunPolicy.g.cs" company="MIT">
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

namespace Banking.Models.Interfaces
{
	public partial interface IPluginOneLifeBatchRunPolicy  
	{
		#region Fields
		
		int Id { get; set; }
		Nullable<DateTime> Stamp { get; set; }
		string UserName { get; set; }
		Nullable<int> PluginOneLifeBatchRunId { get; set; }
		Nullable<int> PolicyId { get; set; }
		Nullable<bool> Completed { get; set; }
		Nullable<bool> HasError { get; set; }
		string Message { get; set; }
		byte[] XmlFile { get; set; }
		string Name { get; set; }
		string Surname { get; set; }
		string ExternalReference { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<IPluginOneLifeBatchRunException> PluginOneLifeBatchRunException { get; set; }
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> PluginOneLifeBatchRunUnAnsweredQuestion { get; set; }

		#endregion
		
		#region Parent Relationships
		
		IPluginOneLifeBatchRun PluginOneLifeBatchRun { get; set; }
		
		#endregion
	}
}