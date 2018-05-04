
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
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The CustomerRepository class responsible for database functions in the Customer table
	/// </summary>
	public partial class CustomerRepository : UowRepository<Customer> , ICustomerRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CustomerRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CustomerRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Customer entity from the database using the CustomerId primary key
        /// </summary>
        /// <param name="customerid">int</param>
        /// <returns>ICustomer</returns>
		public ICustomer LoadByCustomerId(int customerid)
		{
			return this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == customerid);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the CustomerCode field
        /// </summary>
        /// <param name="customercode">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByCustomerCode(string customercode)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode == customercode);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the CompanyName field
        /// </summary>
        /// <param name="companyname">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByCompanyName(string companyname)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName == companyname);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the ContactName field
        /// </summary>
        /// <param name="contactname">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByContactName(string contactname)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.ContactName == contactname);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the ContactTitle field
        /// </summary>
        /// <param name="contacttitle">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByContactTitle(string contacttitle)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle == contacttitle);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the Address field
        /// </summary>
        /// <param name="address">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByAddress(string address)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Address == address);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the City field
        /// </summary>
        /// <param name="city">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByCity(string city)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.City == city);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the PostalCode field
        /// </summary>
        /// <param name="postalcode">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByPostalCode(string postalcode)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode == postalcode);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the Telephone field
        /// </summary>
        /// <param name="telephone">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByTelephone(string telephone)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Telephone == telephone);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the Fax field
        /// </summary>
        /// <param name="fax">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByFax(string fax)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Fax == fax);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">int</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByCountryId(int countryid)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CountryId == countryid);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the Photo field
        /// </summary>
        /// <param name="photo">string</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByPhoto(string photo)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Photo == photo);
		}
		
        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isenabled">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadByIsEnabled(bool isenabled)
		{
			return (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.IsEnabled == isenabled);
		}
		
        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> LoadAll()
		{
			return (IList<ICustomer>)this.UnitOfWork.GetAll<Customer>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customercode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByCustomerCode(string customercode, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.ToLower().Contains(customercode.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.Contains(customercode));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByCompanyName(string companyname, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.ToLower().Contains(companyname.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.Contains(companyname));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByContactName(string contactname, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.ToLower().Contains(contactname.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.Contains(contactname));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contacttitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByContactTitle(string contacttitle, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.ToLower().Contains(contacttitle.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.Contains(contacttitle));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByAddress(string address, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Address.ToLower().Contains(address.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Address.Contains(address));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByCity(string city, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.City.ToLower().Contains(city.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.City.Contains(city));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalcode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByPostalCode(string postalcode, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.ToLower().Contains(postalcode.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.Contains(postalcode));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByTelephone(string telephone, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.ToLower().Contains(telephone.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.Contains(telephone));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByFax(string fax, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Fax.ToLower().Contains(fax.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Fax.Contains(fax));
		}
		
        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> SearchByPhoto(string photo, bool caseSensitive = false)
		{
			return caseSensitive ? (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Photo.ToLower().Contains(photo.ToLower())) 
						  : (IList<ICustomer>)this.UnitOfWork.AllMatching<Customer>(o => o.Photo.Contains(photo));
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool Save(ICustomer entity)
		{
			var entityToSave = new Customer(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool Update(ICustomer entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == entity.CustomerId);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CustomerCode != entity.CustomerCode) { entityToUpdate.CustomerCode = entity.CustomerCode;doUpdate = true; }
			if (entityToUpdate.CompanyName != entity.CompanyName) { entityToUpdate.CompanyName = entity.CompanyName;doUpdate = true; }
			if (entityToUpdate.ContactName != entity.ContactName) { entityToUpdate.ContactName = entity.ContactName;doUpdate = true; }
			if (entityToUpdate.ContactTitle != entity.ContactTitle) { entityToUpdate.ContactTitle = entity.ContactTitle;doUpdate = true; }
			if (entityToUpdate.Address != entity.Address) { entityToUpdate.Address = entity.Address;doUpdate = true; }
			if (entityToUpdate.City != entity.City) { entityToUpdate.City = entity.City;doUpdate = true; }
			if (entityToUpdate.PostalCode != entity.PostalCode) { entityToUpdate.PostalCode = entity.PostalCode;doUpdate = true; }
			if (entityToUpdate.Telephone != entity.Telephone) { entityToUpdate.Telephone = entity.Telephone;doUpdate = true; }
			if (entityToUpdate.Fax != entity.Fax) { entityToUpdate.Fax = entity.Fax;doUpdate = true; }
			if (entityToUpdate.CountryId != entity.CountryId) { entityToUpdate.CountryId = entity.CountryId;doUpdate = true; }
			if (entityToUpdate.Photo != entity.Photo) { entityToUpdate.Photo = entity.Photo;doUpdate = true; }
			if (entityToUpdate.IsEnabled != entity.IsEnabled) { entityToUpdate.IsEnabled = entity.IsEnabled;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool Delete(ICustomer entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == entity.CustomerId);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Customer entity from the database using the CustomerId
        /// </summary>
        /// <param name="customerid">int</param>
        /// <returns>bool</returns>
		public bool DeleteByCustomerId(int customerid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == customerid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
