
// <copyright file="Customer.g.cs" company="MIT">
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
	public partial class CustomerRepository : ICustomerRepository
	{
		#region Private
		
		private IUnitOfWork UnitOfWork;
		
		#endregion
		
		#region CTOR
		
		public CustomerRepository(IUnitOfWork uow)
		{
			this.UnitOfWork = uow;
		}
		
		#endregion
		
		#region Load
		
		public ICustomer LoadByCustomerId(int customerid)
		{
			return this.UnitOfWork.FirstOrDefault(o => o.CustomerId == customerid);
		}
		
		public IList<ICustomer> LoadByCustomerCode(string customercode)
		{
			return this.UnitOfWork.AllMatching(o => o.CustomerCode == customercode);
		}
		
		public IList<ICustomer> LoadByCompanyName(string companyname)
		{
			return this.UnitOfWork.AllMatching(o => o.CompanyName == companyname);
		}
		
		public IList<ICustomer> LoadByContactName(string contactname)
		{
			return this.UnitOfWork.AllMatching(o => o.ContactName == contactname);
		}
		
		public IList<ICustomer> LoadByContactTitle(string contacttitle)
		{
			return this.UnitOfWork.AllMatching(o => o.ContactTitle == contacttitle);
		}
		
		public IList<ICustomer> LoadByAddress(string address)
		{
			return this.UnitOfWork.AllMatching(o => o.Address == address);
		}
		
		public IList<ICustomer> LoadByCity(string city)
		{
			return this.UnitOfWork.AllMatching(o => o.City == city);
		}
		
		public IList<ICustomer> LoadByPostalCode(string postalcode)
		{
			return this.UnitOfWork.AllMatching(o => o.PostalCode == postalcode);
		}
		
		public IList<ICustomer> LoadByTelephone(string telephone)
		{
			return this.UnitOfWork.AllMatching(o => o.Telephone == telephone);
		}
		
		public IList<ICustomer> LoadByFax(string fax)
		{
			return this.UnitOfWork.AllMatching(o => o.Fax == fax);
		}
		
		public IList<ICustomer> LoadByCountryId(int countryid)
		{
			return this.UnitOfWork.AllMatching(o => o.CountryId == countryid);
		}
		
		public IList<ICustomer> LoadByPhoto(string photo)
		{
			return this.UnitOfWork.AllMatching(o => o.Photo == photo);
		}
		
		public IList<ICustomer> LoadByIsEnabled(bool isenabled)
		{
			return this.UnitOfWork.AllMatching(o => o.IsEnabled == isenabled);
		}
		
		public IList<ICustomer> LoadAll()
		{
			return this.UnitOfWork.LoadAll();
		}
		
		#endregion

		#region Search
		
		public IList<ICustomer> SearchByCustomerCode(string customercode)
		{
			return this.UnitOfWork.AllMatching(o => o.CustomerCode.Contains(customercode));
		}
		
		public IList<ICustomer> SearchByCompanyName(string companyname)
		{
			return this.UnitOfWork.AllMatching(o => o.CompanyName.Contains(companyname));
		}
		
		public IList<ICustomer> SearchByContactName(string contactname)
		{
			return this.UnitOfWork.AllMatching(o => o.ContactName.Contains(contactname));
		}
		
		public IList<ICustomer> SearchByContactTitle(string contacttitle)
		{
			return this.UnitOfWork.AllMatching(o => o.ContactTitle.Contains(contacttitle));
		}
		
		public IList<ICustomer> SearchByAddress(string address)
		{
			return this.UnitOfWork.AllMatching(o => o.Address.Contains(address));
		}
		
		public IList<ICustomer> SearchByCity(string city)
		{
			return this.UnitOfWork.AllMatching(o => o.City.Contains(city));
		}
		
		public IList<ICustomer> SearchByPostalCode(string postalcode)
		{
			return this.UnitOfWork.AllMatching(o => o.PostalCode.Contains(postalcode));
		}
		
		public IList<ICustomer> SearchByTelephone(string telephone)
		{
			return this.UnitOfWork.AllMatching(o => o.Telephone.Contains(telephone));
		}
		
		public IList<ICustomer> SearchByFax(string fax)
		{
			return this.UnitOfWork.AllMatching(o => o.Fax.Contains(fax));
		}
		
		public IList<ICustomer> SearchByPhoto(string photo)
		{
			return this.UnitOfWork.AllMatching(o => o.Photo.Contains(photo));
		}
		
		#endregion
		
		#region CRUD
		
		public bool Save(ICustomer entity)
		{
			return false;
		}
		
		public bool Update(ICustomer entity)
		{
			return false;
		}

		public bool Delete(ICustomer entity)
		{
			return false;
		}

		public bool DeleteByCustomerId(int customerid)
		{
			return false;
		}
		
		#endregion
	}
}
