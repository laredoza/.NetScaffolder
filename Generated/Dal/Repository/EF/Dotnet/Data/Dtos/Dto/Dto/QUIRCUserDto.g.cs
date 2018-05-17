
// <copyright file="QUIRCUserDto.g.cs" company="MIT">
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
	public partial class QUIRCUserDto : IQUIRCUser 
	{
		#region CTOR
		
		public QUIRCUserDto()
		{
			this.CedantUserLoadingLimit = new List <ICedantUserLoadingLimit>();
			this.Note = new List <INote>();
			this.NoteFollowUp = new List <INoteFollowUp>();
			this.QUIRCUserCedant = new List <IQUIRCUserCedant>();
		}
		
		public QUIRCUserDto(IQUIRCUser item, bool deep = false)
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
			this.CedantUserLoadingLimit = new List <ICedantUserLoadingLimit>();
			this.Note = new List <INote>();
			this.NoteFollowUp = new List <INoteFollowUp>();
			this.QUIRCUserCedant = new List <IQUIRCUserCedant>();

			if(deep)
			{
				if(item.CedantUserLoadingLimit != null)
				{
					foreach(var childItem in item.CedantUserLoadingLimit)
					{
						this.CedantUserLoadingLimit.Add(new CedantUserLoadingLimitDto(childItem, deep));
					}
				}
				if(item.Note != null)
				{
					foreach(var childItem in item.Note)
					{
						this.Note.Add(new NoteDto(childItem, deep));
					}
				}
				if(item.NoteFollowUp != null)
				{
					foreach(var childItem in item.NoteFollowUp)
					{
						this.NoteFollowUp.Add(new NoteFollowUpDto(childItem, deep));
					}
				}
				if(item.QUIRCUserCedant != null)
				{
					foreach(var childItem in item.QUIRCUserCedant)
					{
						this.QUIRCUserCedant.Add(new QUIRCUserCedantDto(childItem, deep));
					}
				}
                if(item.Cedant != null)
                {
				    this.Cedant = new CedantDto(item.Cedant, deep);
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
		
		public IList<ICedantUserLoadingLimit> CedantUserLoadingLimit { get; set; }
		public IList<INote> Note { get; set; }
		public IList<INoteFollowUp> NoteFollowUp { get; set; }
		public IList<IQUIRCUserCedant> QUIRCUserCedant { get; set; }

		#endregion
		
		#region Parent Relationships
		
		public ICedant Cedant { get; set; }
		
		#endregion
	}
}
