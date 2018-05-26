
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
using RepositoryEFDotnet.Core.Base;
using System.Linq;
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
        /// Load Customer entities from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>ICustomer</returns>
		public virtual ICustomer LoadByCustomerId(int customerId)
		{
			return this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == customerId);
		}

        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadByCountryId(Nullable<int> countryId)
		{
			return this.UnitOfWork.AllMatching<Customer>(o => o.CountryId == countryId).ToList<ICustomer>();
		}

        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadByIsEnabled(bool isEnabled)
		{
			return this.UnitOfWork.AllMatching<Customer>(o => o.IsEnabled == isEnabled).ToList<ICustomer>();
		}

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadAll()
		{
			return this.UnitOfWork.GetAll<Customer>().ToList<ICustomer>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByCustomerCode(string customerCode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.Contains(customerCode)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.ToLower().Contains(customerCode.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByCompanyName(string companyName, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.Contains(companyName)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.ToLower().Contains(companyName.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByContactName(string contactName, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.Contains(contactName)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.ToLower().Contains(contactName.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByContactTitle(string contactTitle, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.Contains(contactTitle)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.ToLower().Contains(contactTitle.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByAddress(string address, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Address.Contains(address)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Address.ToLower().Contains(address.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByCity(string city, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.City.Contains(city)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.City.ToLower().Contains(city.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByPostalCode(string postalCode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.Contains(postalCode)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.ToLower().Contains(postalCode.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByTelephone(string telephone, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.Contains(telephone)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.ToLower().Contains(telephone.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByFax(string fax, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Fax.Contains(fax)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Fax.ToLower().Contains(fax.ToLower())).ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByPhoto(string photo, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Photo.Contains(photo)).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Photo.ToLower().Contains(photo.ToLower())).ToList<ICustomer>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICustomer entity)
		{
			var entityToSave = new Customer(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICustomer entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Customer>(o =>  o.CustomerId == entity.CustomerId );
			
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
		public virtual bool Delete(ICustomer entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer>(o =>  o.CustomerId == entity.CustomerId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int customerId)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer>(o =>  o.CustomerId == customerId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
