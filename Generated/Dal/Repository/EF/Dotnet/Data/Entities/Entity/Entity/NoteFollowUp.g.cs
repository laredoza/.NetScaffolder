﻿
// <copyright file="NoteFollowUp.g.cs" company="MIT">
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

namespace Banking.Models.Entity
{
	public partial class NoteFollowUp : INoteFollowUp 
	{
		#region CTOR
		
		public NoteFollowUp()
		{
		}
		
		public NoteFollowUp(INoteFollowUp item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.Description = item.Description;
			this.UserId = item.UserId;
			this.NoteId = item.NoteId;

			if(deep)
			{
				if(item.QUIRCUser != null)
                {
                    this.QUIRCUser = new QUIRCUser(item.QUIRCUser, deep);
                }
				if(item.Note != null)
                {
                    this.Note = new Note(item.Note, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string Description { get; set; }
		public Nullable<int> UserId { get; set; }
		public Nullable<int> NoteId { get; set; }

		#endregion
		
		#region Child Relationships
		
		#endregion
		
		#region Parent Relationships

        public virtual QUIRCUser QUIRCUser { get; set; }

		IQUIRCUser INoteFollowUp.QUIRCUser 
		{ 
			get
			{
				return this.QUIRCUser;
			}
			set
			{
				this.QUIRCUser = (QUIRCUser)value;
			}
		}

        public virtual Note Note { get; set; }

		INote INoteFollowUp.Note 
		{ 
			get
			{
				return this.Note;
			}
			set
			{
				this.Note = (Note)value;
			}
		}
		
		#endregion
	}
}
