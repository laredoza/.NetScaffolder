
// <copyright file="Note.g.cs" company="MIT">
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
	public partial interface INote  
	{
		#region Fields
		
		int Id { get; set; }
		Nullable<DateTime> Stamp { get; set; }
		string UserName { get; set; }
		string Description { get; set; }
		Nullable<int> AllocatedToId { get; set; }
		Nullable<bool> ActionRequiredFlag { get; set; }
		Nullable<DateTime> FollowUpDate { get; set; }
		Nullable<int> LinkId { get; set; }
		Nullable<bool> CompletedFlag { get; set; }
		Nullable<int> UserId { get; set; }
		Nullable<int> NoteStatusId { get; set; }
		Nullable<int> NoteLinkTypeId { get; set; }

		#endregion
		
		#region Child Relationships
		
		IList<INoteFollowUp> NoteFollowUp { get; set; }

		#endregion
		
		#region Parent Relationships
		
		IQUIRCUser QUIRCUser { get; set; }
		INoteLinkType NoteLinkType { get; set; }
		INoteStatus NoteStatus { get; set; }
		
		#endregion
	}
}
