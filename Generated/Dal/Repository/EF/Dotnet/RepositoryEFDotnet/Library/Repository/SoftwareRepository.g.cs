
// <copyright file="Software.g.cs" company="MIT">
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
using Banking.Models.Interfaces;

namespace Banking.Models.Repository
{
	public partial class SoftwareRepository : ISoftwareRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		public SoftwareRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
		public ISoftware LoadByProductId(int productid)
		{
			return this.UnitOfWork.FirstOrDefault(o => o.ProductId == productid);
		}
		
		public IList<ISoftware> LoadByLicenseCode(string licensecode)
		{
			return this.UnitOfWork.AllMatching(o => o.LicenseCode == licensecode);
		}
		
		public IList<ISoftware> LoadAll()
		{
			return this.UnitOfWork.LoadAll();
		}
		
		#endregion

		#region Search
		
		public IList<ISoftware> SearchByLicenseCode(string licensecode)
		{
			return this.UnitOfWork.AllMatching(o => o.LicenseCode.Contains(licensecode));
		}
		
		#endregion
		
		#region CRUD
		
		public bool Save(ISoftware entity)
		{
			return false;
		}
		
		public bool Update(ISoftware entity)
		{
			return false;
		}

		public bool Delete(ISoftware entity)
		{
			return false;
		}

		public bool DeleteByProductId(int productid)
		{
			return false;
		}
		
		#endregion
	}
}
