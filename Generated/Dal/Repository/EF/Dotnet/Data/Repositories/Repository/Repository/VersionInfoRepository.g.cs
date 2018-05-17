
// <copyright file="VersionInfo.g.cs" company="MIT">
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
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The VersionInfoRepository class responsible for database functions in the VersionInfo table
	/// </summary>
	public partial class VersionInfoRepository : UowRepository<VersionInfo> , IVersionInfoRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionInfoRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionInfoRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load VersionInfo entities from the database using the Version field
        /// </summary>
        /// <param name="version">long</param>
        /// <returns>IList<IVersionInfo></returns>
		public virtual IList<IVersionInfo> LoadByVersion(long version)
		{
			return this.UnitOfWork.AllMatching<VersionInfo>(o => o.Version == version).ToList<IVersionInfo>();
		}
		
        /// <summary>
        /// Load VersionInfo entities from the database using the AppliedOn field
        /// </summary>
        /// <param name="appliedon">Nullable<DateTime></param>
        /// <returns>IList<IVersionInfo></returns>
		public virtual IList<IVersionInfo> LoadByAppliedOn(Nullable<DateTime> appliedon)
		{
			return this.UnitOfWork.AllMatching<VersionInfo>(o => o.AppliedOn == appliedon).ToList<IVersionInfo>();
		}
		
        /// <summary>
        /// Load all VersionInfo entities from the database.
        /// </summary>
        /// <returns>IList<IVersionInfo></returns>
		public virtual IList<IVersionInfo> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionInfo>().ToList<IVersionInfo>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionInfo entity to the database.
        /// </summary>
        /// <param name="entity">IVersionInfo</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionInfo entity)
		{
			var entityToSave = new VersionInfo(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
		
		#endregion
	}
}
