
// <copyright file="QUIRCUser.g.cs" company="MIT">
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
	public partial class QUIRCUser : IQUIRCUser 
	{
		#region CTOR
		
		public QUIRCUser()
		{
			this.CedantUserLoadingLimit = new List <CedantUserLoadingLimit>();
			this.Note = new List <Note>();
			this.NoteFollowUp = new List <NoteFollowUp>();
			this.QUIRCUserCedant = new List <QUIRCUserCedant>();
		}
		
		public QUIRCUser(IQUIRCUser item, bool deep = false)
		{
			if(item == null) return;
			
			this.Id = item.Id;
			this.Stamp = item.Stamp;
			this.UserName = item.UserName;
			this.LoginId = item.LoginId;
			this.PasswordHash = item.PasswordHash;
			this.PasswordSalt = item.PasswordSalt;
			this.EmailAddress = item.EmailAddress;
			this.FirstName = item.FirstName;
			this.Surname = item.Surname;
			this.Role = item.Role;
			this.Status = item.Status;
			this.SecurityQuestions = item.SecurityQuestions;
			this.CendantId = item.CendantId;
			this.CedantUserLoadingLimitId = item.CedantUserLoadingLimitId;
			this.LastLogin = item.LastLogin;
			this.LockoutEnabled = item.LockoutEnabled;
			this.TwoFactorEnabled = item.TwoFactorEnabled;
			this.AccessFailedCount = item.AccessFailedCount;
			this.LockoutEndDate = item.LockoutEndDate;
			this.PasswordResetToken = item.PasswordResetToken;
			this.EmailConfirmed = item.EmailConfirmed;
			this.CedantUserLoadingLimit = new List <CedantUserLoadingLimit>();
			this.Note = new List <Note>();
			this.NoteFollowUp = new List <NoteFollowUp>();
			this.QUIRCUserCedant = new List <QUIRCUserCedant>();

			if(deep)
			{
				if(item.CedantUserLoadingLimit != null)
				{
					foreach(var childItem in item.CedantUserLoadingLimit)
					{
						this.CedantUserLoadingLimit.Add(new CedantUserLoadingLimit(childItem, deep));
					}
				}
				if(item.Note != null)
				{
					foreach(var childItem in item.Note)
					{
						this.Note.Add(new Note(childItem, deep));
					}
				}
				if(item.NoteFollowUp != null)
				{
					foreach(var childItem in item.NoteFollowUp)
					{
						this.NoteFollowUp.Add(new NoteFollowUp(childItem, deep));
					}
				}
				if(item.QUIRCUserCedant != null)
				{
					foreach(var childItem in item.QUIRCUserCedant)
					{
						this.QUIRCUserCedant.Add(new QUIRCUserCedant(childItem, deep));
					}
				}
				if(item.Cedant != null)
                {
                    this.Cedant = new Cedant(item.Cedant, deep);
                }
			}
		}
		
		#endregion
		
		#region Fields
		
		public int Id { get; set; }
		public Nullable<DateTime> Stamp { get; set; }
		public string UserName { get; set; }
		public string LoginId { get; set; }
		public string PasswordHash { get; set; }
		public string PasswordSalt { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string Surname { get; set; }
		public Nullable<int> Role { get; set; }
		public Nullable<int> Status { get; set; }
		public string SecurityQuestions { get; set; }
		public Nullable<int> CendantId { get; set; }
		public Nullable<int> CedantUserLoadingLimitId { get; set; }
		public Nullable<DateTime> LastLogin { get; set; }
		public Nullable<bool> LockoutEnabled { get; set; }
		public Nullable<bool> TwoFactorEnabled { get; set; }
		public Nullable<int> AccessFailedCount { get; set; }
		public Nullable<DateTime> LockoutEndDate { get; set; }
		public Nullable<Guid> PasswordResetToken { get; set; }
		public Nullable<bool> EmailConfirmed { get; set; }

		#endregion
		
		#region Child Relationships
        
        public virtual IList<CedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }

        IList<ICedantUserLoadingLimit> IQUIRCUser.CedantUserLoadingLimit 
		{ 
			get
			{
				return (IList<ICedantUserLoadingLimit>)this.CedantUserLoadingLimit;
			}
			set
			{
				this.CedantUserLoadingLimit = (IList<CedantUserLoadingLimit>)value;
			}			
		}
        
        public virtual IList<Note> Note { get; set; }

        IList<INote> IQUIRCUser.Note 
		{ 
			get
			{
				return (IList<INote>)this.Note;
			}
			set
			{
				this.Note = (IList<Note>)value;
			}			
		}
        
        public virtual IList<NoteFollowUp> NoteFollowUp { get; set; }

        IList<INoteFollowUp> IQUIRCUser.NoteFollowUp 
		{ 
			get
			{
				return (IList<INoteFollowUp>)this.NoteFollowUp;
			}
			set
			{
				this.NoteFollowUp = (IList<NoteFollowUp>)value;
			}			
		}
        
        public virtual IList<QUIRCUserCedant> QUIRCUserCedant { get; set; }

        IList<IQUIRCUserCedant> IQUIRCUser.QUIRCUserCedant 
		{ 
			get
			{
				return (IList<IQUIRCUserCedant>)this.QUIRCUserCedant;
			}
			set
			{
				this.QUIRCUserCedant = (IList<QUIRCUserCedant>)value;
			}			
		}
		
		#endregion
		
		#region Parent Relationships

        public virtual Cedant Cedant { get; set; }

		ICedant IQUIRCUser.Cedant 
		{ 
			get
			{
				return this.Cedant;
			}
			set
			{
				this.Cedant = (Cedant)value;
			}
		}
		
		#endregion
	}
}
