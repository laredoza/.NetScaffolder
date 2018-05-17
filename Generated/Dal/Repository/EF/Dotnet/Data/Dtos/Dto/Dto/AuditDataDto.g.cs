
// <copyright file="AuditDataDto.g.cs" company="MIT">
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
	public partial class AuditDataDto : IAuditData 
	{
		#region CTOR
		
		public AuditDataDto()
		{
		}
		
		public AuditDataDto(IAuditData item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.PropertyName = item.PropertyName;
			this.PreviousValue = item.PreviousValue;
			this.NewValue = item.NewValue;
			this.AuditId = item.AuditId;

			if(deep)
			{
                if(item.Audit != null)
                {
				    this.Audit = new AuditDto(item.Audit, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public Guid Id { get; set; }
		public string PropertyName { get; set; }
		public string PreviousValue { get; set; }
		public string NewValue { get; set; }
		public Nullable<Guid> AuditId { get; set; }

		#endregion
		
		#region Child Relationships
		

		#endregion
		
		#region Parent Relationships
		
		public IAudit Audit { get; set; }
		
		#endregion
	}
}
