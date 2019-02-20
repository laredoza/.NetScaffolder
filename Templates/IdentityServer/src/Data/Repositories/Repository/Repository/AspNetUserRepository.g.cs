
// <copyright file="AspNetUser.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;

using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Repositories.Repository
{
	/// <summary>
	/// The AspNetUserRepository class responsible for database functions in the AspNetUser table
	/// </summary>
	public partial class AspNetUserRepository : UowRepository<AspNetUser> , IAspNetUserRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AspNetUserRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AspNetUserRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for AspNetUserRepository
        /// </summary>
		public AspNetUserRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load AspNetUser entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">Guid</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>AspNetUser</returns>
		public virtual AspNetUser LoadById(Guid id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<AspNetUser>(o => o.Id == id, cache, expr);
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">Guid</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>AspNetUser</returns>
		public virtual async Task<AspNetUser> LoadByIdAsync(Guid id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<AspNetUser>(cache, o => o.Id == id, expr);
		}

        /// <summary>
        /// Load AspNetUser entities from the database using the EmailConfirmed field
        /// </summary>
        /// <param name="emailConfirmed">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual IList<AspNetUser> LoadByEmailConfirmed(bool emailConfirmed, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUser>(o => o.EmailConfirmed == emailConfirmed, cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the EmailConfirmed field
        /// </summary>
        /// <param name="emailConfirmed">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadByEmailConfirmedAsync(bool emailConfirmed, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.EmailConfirmed == emailConfirmed,cache, expr);
			return result.ToList<AspNetUser>();
		}

        /// <summary>
        /// Load AspNetUser entities from the database using the PhoneNumberConfirmed field
        /// </summary>
        /// <param name="phoneNumberConfirmed">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual IList<AspNetUser> LoadByPhoneNumberConfirmed(bool phoneNumberConfirmed, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUser>(o => o.PhoneNumberConfirmed == phoneNumberConfirmed, cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the PhoneNumberConfirmed field
        /// </summary>
        /// <param name="phoneNumberConfirmed">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadByPhoneNumberConfirmedAsync(bool phoneNumberConfirmed, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.PhoneNumberConfirmed == phoneNumberConfirmed,cache, expr);
			return result.ToList<AspNetUser>();
		}

        /// <summary>
        /// Load AspNetUser entities from the database using the TwoFactorEnabled field
        /// </summary>
        /// <param name="twoFactorEnabled">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual IList<AspNetUser> LoadByTwoFactorEnabled(bool twoFactorEnabled, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUser>(o => o.TwoFactorEnabled == twoFactorEnabled, cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the TwoFactorEnabled field
        /// </summary>
        /// <param name="twoFactorEnabled">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadByTwoFactorEnabledAsync(bool twoFactorEnabled, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.TwoFactorEnabled == twoFactorEnabled,cache, expr);
			return result.ToList<AspNetUser>();
		}

        /// <summary>
        /// Load AspNetUser entities from the database using the LockoutEnd field
        /// </summary>
        /// <param name="lockoutEnd">Nullable<DateTimeOffset></param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual IList<AspNetUser> LoadByLockoutEnd(Nullable<DateTimeOffset> lockoutEnd, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUser>(o => o.LockoutEnd == lockoutEnd, cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the LockoutEnd field
        /// </summary>
        /// <param name="lockoutEnd">Nullable<DateTimeOffset></param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadByLockoutEndAsync(Nullable<DateTimeOffset> lockoutEnd, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.LockoutEnd == lockoutEnd,cache, expr);
			return result.ToList<AspNetUser>();
		}

        /// <summary>
        /// Load AspNetUser entities from the database using the LockoutEnabled field
        /// </summary>
        /// <param name="lockoutEnabled">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual IList<AspNetUser> LoadByLockoutEnabled(bool lockoutEnabled, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUser>(o => o.LockoutEnabled == lockoutEnabled, cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the LockoutEnabled field
        /// </summary>
        /// <param name="lockoutEnabled">bool</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadByLockoutEnabledAsync(bool lockoutEnabled, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.LockoutEnabled == lockoutEnabled,cache, expr);
			return result.ToList<AspNetUser>();
		}

        /// <summary>
        /// Load AspNetUser entities from the database using the AccessFailedCount field
        /// </summary>
        /// <param name="accessFailedCount">int</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual IList<AspNetUser> LoadByAccessFailedCount(int accessFailedCount, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<AspNetUser>(o => o.AccessFailedCount == accessFailedCount, cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the AccessFailedCount field
        /// </summary>
        /// <param name="accessFailedCount">int</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<IAspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadByAccessFailedCountAsync(int accessFailedCount, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.AccessFailedCount == accessFailedCount,cache, expr);
			return result.ToList<AspNetUser>();
		}

        /// <summary>
        /// Load all AspNetUser entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> LoadAll(bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<AspNetUser>(cache, expr).ToList<AspNetUser>();
		}
		
        /// <summary>
        /// Load all AspNetUser entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUser,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<AspNetUser>(cache, expr);
			return result.ToList<AspNetUser>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUser entities in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByUserName(string userName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.UserName.Contains(userName), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.UserName.ToLower().Contains(userName.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByUserNameAsync(string userName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.UserName.Contains(userName), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.UserName.ToLower().Contains(userName.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByNormalizedUserName(string normalizedUserName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.NormalizedUserName.Contains(normalizedUserName), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.NormalizedUserName.ToLower().Contains(normalizedUserName.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByNormalizedUserNameAsync(string normalizedUserName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.NormalizedUserName.Contains(normalizedUserName), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.NormalizedUserName.ToLower().Contains(normalizedUserName.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by Email
        /// </summary>
        /// <param name="email">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByEmail(string email, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.Email.Contains(email), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.Email.ToLower().Contains(email.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by Email
        /// </summary>
        /// <param name="email">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByEmailAsync(string email, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.Email.Contains(email), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.Email.ToLower().Contains(email.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByNormalizedEmail(string normalizedEmail, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.NormalizedEmail.Contains(normalizedEmail), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.NormalizedEmail.ToLower().Contains(normalizedEmail.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByNormalizedEmailAsync(string normalizedEmail, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.NormalizedEmail.Contains(normalizedEmail), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.NormalizedEmail.ToLower().Contains(normalizedEmail.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByPasswordHash(string passwordHash, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.PasswordHash.Contains(passwordHash), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.PasswordHash.ToLower().Contains(passwordHash.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByPasswordHashAsync(string passwordHash, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.PasswordHash.Contains(passwordHash), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.PasswordHash.ToLower().Contains(passwordHash.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchBySecurityStamp(string securityStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.SecurityStamp.Contains(securityStamp), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.SecurityStamp.ToLower().Contains(securityStamp.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchBySecurityStampAsync(string securityStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.SecurityStamp.Contains(securityStamp), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.SecurityStamp.ToLower().Contains(securityStamp.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByConcurrencyStamp(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.ConcurrencyStamp.Contains(concurrencyStamp), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.ConcurrencyStamp.ToLower().Contains(concurrencyStamp.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByConcurrencyStampAsync(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.ConcurrencyStamp.Contains(concurrencyStamp), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.ConcurrencyStamp.ToLower().Contains(concurrencyStamp.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

        /// <summary>
        /// Search for AspNetUser entities in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual IList<AspNetUser> SearchByPhoneNumber(string phoneNumber, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.PhoneNumber.Contains(phoneNumber), cache, expr).ToList<AspNetUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AspNetUser>(o => o.PhoneNumber.ToLower().Contains(phoneNumber.ToLower()), cache, expr).ToList<AspNetUser>();
			}
		}
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		public virtual async Task<IList<AspNetUser>> SearchByPhoneNumberAsync(string phoneNumber, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.PhoneNumber.Contains(phoneNumber), cache, expr);
				return result.ToList<AspNetUser>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<AspNetUser>(o => o.PhoneNumber.ToLower().Contains(phoneNumber.ToLower()), cache, expr);
				return result.ToList<AspNetUser>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUser entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		public virtual bool Add(AspNetUser entity)
		{
			var entityToSave = new AspNetUser(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.UserName = entityToSave.UserName;
			entity.NormalizedUserName = entityToSave.NormalizedUserName;
			entity.Email = entityToSave.Email;
			entity.NormalizedEmail = entityToSave.NormalizedEmail;
			entity.EmailConfirmed = entityToSave.EmailConfirmed;
			entity.PasswordHash = entityToSave.PasswordHash;
			entity.SecurityStamp = entityToSave.SecurityStamp;
			entity.ConcurrencyStamp = entityToSave.ConcurrencyStamp;
			entity.PhoneNumber = entityToSave.PhoneNumber;
			entity.PhoneNumberConfirmed = entityToSave.PhoneNumberConfirmed;
			entity.TwoFactorEnabled = entityToSave.TwoFactorEnabled;
			entity.LockoutEnd = entityToSave.LockoutEnd;
			entity.LockoutEnabled = entityToSave.LockoutEnabled;
			entity.AccessFailedCount = entityToSave.AccessFailedCount;
			
			return result;
		}
		
        /// <summary>
        /// Add the AspNetUser entity async to the database.
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(AspNetUser entity)
		{
            var entityToSave = new AspNetUser(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.UserName = entityToSave.UserName;
			entity.NormalizedUserName = entityToSave.NormalizedUserName;
			entity.Email = entityToSave.Email;
			entity.NormalizedEmail = entityToSave.NormalizedEmail;
			entity.EmailConfirmed = entityToSave.EmailConfirmed;
			entity.PasswordHash = entityToSave.PasswordHash;
			entity.SecurityStamp = entityToSave.SecurityStamp;
			entity.ConcurrencyStamp = entityToSave.ConcurrencyStamp;
			entity.PhoneNumber = entityToSave.PhoneNumber;
			entity.PhoneNumberConfirmed = entityToSave.PhoneNumberConfirmed;
			entity.TwoFactorEnabled = entityToSave.TwoFactorEnabled;
			entity.LockoutEnd = entityToSave.LockoutEnd;
			entity.LockoutEnabled = entityToSave.LockoutEnabled;
			entity.AccessFailedCount = entityToSave.AccessFailedCount;
			
			return result;
		}

        /// <summary>
        /// Update the AspNetUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		public virtual bool Update(AspNetUser entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUser>(o =>  o.Id == entity.Id , true);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUser entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.NormalizedUserName != entity.NormalizedUserName) { entityToUpdate.NormalizedUserName = entity.NormalizedUserName;doUpdate = true; }
			if (entityToUpdate.Email != entity.Email) { entityToUpdate.Email = entity.Email;doUpdate = true; }
			if (entityToUpdate.NormalizedEmail != entity.NormalizedEmail) { entityToUpdate.NormalizedEmail = entity.NormalizedEmail;doUpdate = true; }
			if (entityToUpdate.EmailConfirmed != entity.EmailConfirmed) { entityToUpdate.EmailConfirmed = entity.EmailConfirmed;doUpdate = true; }
			if (entityToUpdate.PasswordHash != entity.PasswordHash) { entityToUpdate.PasswordHash = entity.PasswordHash;doUpdate = true; }
			if (entityToUpdate.SecurityStamp != entity.SecurityStamp) { entityToUpdate.SecurityStamp = entity.SecurityStamp;doUpdate = true; }
			if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }
			if (entityToUpdate.PhoneNumber != entity.PhoneNumber) { entityToUpdate.PhoneNumber = entity.PhoneNumber;doUpdate = true; }
			if (entityToUpdate.PhoneNumberConfirmed != entity.PhoneNumberConfirmed) { entityToUpdate.PhoneNumberConfirmed = entity.PhoneNumberConfirmed;doUpdate = true; }
			if (entityToUpdate.TwoFactorEnabled != entity.TwoFactorEnabled) { entityToUpdate.TwoFactorEnabled = entity.TwoFactorEnabled;doUpdate = true; }
			if (entityToUpdate.LockoutEnd != entity.LockoutEnd) { entityToUpdate.LockoutEnd = entity.LockoutEnd;doUpdate = true; }
			if (entityToUpdate.LockoutEnabled != entity.LockoutEnabled) { entityToUpdate.LockoutEnabled = entity.LockoutEnabled;doUpdate = true; }
			if (entityToUpdate.AccessFailedCount != entity.AccessFailedCount) { entityToUpdate.AccessFailedCount = entity.AccessFailedCount;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Update the AspNetUser entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(AspNetUser entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUser>(true, o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AspNetUser entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.NormalizedUserName != entity.NormalizedUserName) { entityToUpdate.NormalizedUserName = entity.NormalizedUserName;doUpdate = true; }
			if (entityToUpdate.Email != entity.Email) { entityToUpdate.Email = entity.Email;doUpdate = true; }
			if (entityToUpdate.NormalizedEmail != entity.NormalizedEmail) { entityToUpdate.NormalizedEmail = entity.NormalizedEmail;doUpdate = true; }
			if (entityToUpdate.EmailConfirmed != entity.EmailConfirmed) { entityToUpdate.EmailConfirmed = entity.EmailConfirmed;doUpdate = true; }
			if (entityToUpdate.PasswordHash != entity.PasswordHash) { entityToUpdate.PasswordHash = entity.PasswordHash;doUpdate = true; }
			if (entityToUpdate.SecurityStamp != entity.SecurityStamp) { entityToUpdate.SecurityStamp = entity.SecurityStamp;doUpdate = true; }
			if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }
			if (entityToUpdate.PhoneNumber != entity.PhoneNumber) { entityToUpdate.PhoneNumber = entity.PhoneNumber;doUpdate = true; }
			if (entityToUpdate.PhoneNumberConfirmed != entity.PhoneNumberConfirmed) { entityToUpdate.PhoneNumberConfirmed = entity.PhoneNumberConfirmed;doUpdate = true; }
			if (entityToUpdate.TwoFactorEnabled != entity.TwoFactorEnabled) { entityToUpdate.TwoFactorEnabled = entity.TwoFactorEnabled;doUpdate = true; }
			if (entityToUpdate.LockoutEnd != entity.LockoutEnd) { entityToUpdate.LockoutEnd = entity.LockoutEnd;doUpdate = true; }
			if (entityToUpdate.LockoutEnabled != entity.LockoutEnabled) { entityToUpdate.LockoutEnabled = entity.LockoutEnabled;doUpdate = true; }
			if (entityToUpdate.AccessFailedCount != entity.AccessFailedCount) { entityToUpdate.AccessFailedCount = entity.AccessFailedCount;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		public virtual bool Delete(AspNetUser entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUser>(o =>  o.Id == entity.Id , true);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUser entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(AspNetUser entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUser>(true, o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUser entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}

		/// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public virtual bool Delete( Guid id, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AspNetUser>(o =>  o.Id == id , cache);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUser entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		/// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( Guid id, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUser>(cache, o =>  o.Id == id  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The AspNetUser entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<AspNetUser, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<IAspNetUser, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<IAspNetUser, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<AspNetUser, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUser, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<AspNetUser, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<AspNetUser> items)
		{
            List<AspNetUser> foundItems = new List<AspNetUser>();

		    foreach (var item in items)
		    {
                var foundEntity = this.UnitOfWork.FirstOrDefault<AspNetUser>(o => o.Id == item.Id , true);

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUser> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			this.UnitOfWork.BulkDelete<IAspNetUser>(foundItems);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<AspNetUser> items)
		{
            List<AspNetUser> foundItems = new List<AspNetUser>();

		    foreach (var item in items)
		    {
                var foundEntity = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUser>(true, o => o.Id == item.Id );

		        if (foundEntity == null)
		        {
		            throw new Exception("The AspNetUser> entity does not exist");
		        }

		        foundItems.Add(foundEntity);
		    }

			await this.UnitOfWork.BulkDeleteAsync<AspNetUser>(foundItems);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<AspNetUser> items)
		{
			this.UnitOfWork.BulkInsert<AspNetUser>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<AspNetUser> items)
		{
			await this.UnitOfWork.BulkInsertAsync<AspNetUser>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<AspNetUser> items)
		{
            List<AspNetUser> foundItems = new List<AspNetUser>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = this.UnitOfWork.FirstOrDefault<AspNetUser>(o =>  o.Id == entity.Id , true);
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUser entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			    if (entityToUpdate.NormalizedUserName != entity.NormalizedUserName) { entityToUpdate.NormalizedUserName = entity.NormalizedUserName;doUpdate = true; }
			    if (entityToUpdate.Email != entity.Email) { entityToUpdate.Email = entity.Email;doUpdate = true; }
			    if (entityToUpdate.NormalizedEmail != entity.NormalizedEmail) { entityToUpdate.NormalizedEmail = entity.NormalizedEmail;doUpdate = true; }
			    if (entityToUpdate.EmailConfirmed != entity.EmailConfirmed) { entityToUpdate.EmailConfirmed = entity.EmailConfirmed;doUpdate = true; }
			    if (entityToUpdate.PasswordHash != entity.PasswordHash) { entityToUpdate.PasswordHash = entity.PasswordHash;doUpdate = true; }
			    if (entityToUpdate.SecurityStamp != entity.SecurityStamp) { entityToUpdate.SecurityStamp = entity.SecurityStamp;doUpdate = true; }
			    if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }
			    if (entityToUpdate.PhoneNumber != entity.PhoneNumber) { entityToUpdate.PhoneNumber = entity.PhoneNumber;doUpdate = true; }
			    if (entityToUpdate.PhoneNumberConfirmed != entity.PhoneNumberConfirmed) { entityToUpdate.PhoneNumberConfirmed = entity.PhoneNumberConfirmed;doUpdate = true; }
			    if (entityToUpdate.TwoFactorEnabled != entity.TwoFactorEnabled) { entityToUpdate.TwoFactorEnabled = entity.TwoFactorEnabled;doUpdate = true; }
			    if (entityToUpdate.LockoutEnd != entity.LockoutEnd) { entityToUpdate.LockoutEnd = entity.LockoutEnd;doUpdate = true; }
			    if (entityToUpdate.LockoutEnabled != entity.LockoutEnabled) { entityToUpdate.LockoutEnabled = entity.LockoutEnabled;doUpdate = true; }
			    if (entityToUpdate.AccessFailedCount != entity.AccessFailedCount) { entityToUpdate.AccessFailedCount = entity.AccessFailedCount;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			this.UnitOfWork.BulkUpdate<AspNetUser>(foundItems);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<AspNetUser> items)
		{
            List<AspNetUser> foundItems = new List<AspNetUser>();

		    foreach (var entity in items)
		    {
                bool doUpdate = false;
			    var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<AspNetUser>(true, o =>  o.Id == entity.Id );
			
			    if (entityToUpdate == null)
			    {
				    throw new Exception("The AspNetUser entity does not exist");
			    }
			
			    // Optimisation: Flag if any field has changed
			    if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			    if (entityToUpdate.NormalizedUserName != entity.NormalizedUserName) { entityToUpdate.NormalizedUserName = entity.NormalizedUserName;doUpdate = true; }
			    if (entityToUpdate.Email != entity.Email) { entityToUpdate.Email = entity.Email;doUpdate = true; }
			    if (entityToUpdate.NormalizedEmail != entity.NormalizedEmail) { entityToUpdate.NormalizedEmail = entity.NormalizedEmail;doUpdate = true; }
			    if (entityToUpdate.EmailConfirmed != entity.EmailConfirmed) { entityToUpdate.EmailConfirmed = entity.EmailConfirmed;doUpdate = true; }
			    if (entityToUpdate.PasswordHash != entity.PasswordHash) { entityToUpdate.PasswordHash = entity.PasswordHash;doUpdate = true; }
			    if (entityToUpdate.SecurityStamp != entity.SecurityStamp) { entityToUpdate.SecurityStamp = entity.SecurityStamp;doUpdate = true; }
			    if (entityToUpdate.ConcurrencyStamp != entity.ConcurrencyStamp) { entityToUpdate.ConcurrencyStamp = entity.ConcurrencyStamp;doUpdate = true; }
			    if (entityToUpdate.PhoneNumber != entity.PhoneNumber) { entityToUpdate.PhoneNumber = entity.PhoneNumber;doUpdate = true; }
			    if (entityToUpdate.PhoneNumberConfirmed != entity.PhoneNumberConfirmed) { entityToUpdate.PhoneNumberConfirmed = entity.PhoneNumberConfirmed;doUpdate = true; }
			    if (entityToUpdate.TwoFactorEnabled != entity.TwoFactorEnabled) { entityToUpdate.TwoFactorEnabled = entity.TwoFactorEnabled;doUpdate = true; }
			    if (entityToUpdate.LockoutEnd != entity.LockoutEnd) { entityToUpdate.LockoutEnd = entity.LockoutEnd;doUpdate = true; }
			    if (entityToUpdate.LockoutEnabled != entity.LockoutEnabled) { entityToUpdate.LockoutEnabled = entity.LockoutEnabled;doUpdate = true; }
			    if (entityToUpdate.AccessFailedCount != entity.AccessFailedCount) { entityToUpdate.AccessFailedCount = entity.AccessFailedCount;doUpdate = true; }

			    // Optimisation: Only execute update if a field has changed
			    if (doUpdate)
			    {
				    foundItems.Add(entityToUpdate);
			    }
		    }

			await this.UnitOfWork.BulkUpdateAsync<AspNetUser>(foundItems);
		}

        #endregion

		#region Helpers
		
	    protected virtual Expression<Func<AspNetUser, object>>[] Convert(params Expression<Func<IAspNetUser, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<AspNetUser, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<AspNetUser, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
