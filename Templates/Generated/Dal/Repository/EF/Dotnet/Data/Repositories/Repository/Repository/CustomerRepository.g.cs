
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
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Banking.Models.Interfaces;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The CustomerRepository class responsible for database functions in the Customer table
	/// </summary>
	public partial class CustomerRepository : UowRepository<ICustomer> , ICustomerRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CustomerRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CustomerRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		/// <summary>
        /// The constructor for CustomerRepository
        /// </summary>
		public CustomerRepository() {}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load Customer entities from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		public virtual ICustomer LoadByCustomerId(int customerId, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == customerId, expr);
		}
		
        /// <summary>
        /// Load Customer entities async from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		public virtual async Task<ICustomer> LoadByCustomerIdAsync(int customerId, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Customer>(o => o.CustomerId == customerId, expr);
		}

        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadByCountryId(Nullable<int> countryId, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Customer>(o => o.CountryId == countryId, expr).ToList<ICustomer>();
		}
		
        /// <summary>
        /// Load Customer entities async from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> LoadByCountryIdAsync(Nullable<int> countryId, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CountryId == countryId, expr);
			return result.ToList<ICustomer>();
		}

        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadByIsEnabled(bool isEnabled, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Customer>(o => o.IsEnabled == isEnabled, expr).ToList<ICustomer>();
		}
		
        /// <summary>
        /// Load Customer entities async from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> LoadByIsEnabledAsync(bool isEnabled, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.IsEnabled == isEnabled, expr);
			return result.ToList<ICustomer>();
		}

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadAll(params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Customer>(expr).ToList<ICustomer>();
		}
		
        /// <summary>
        /// Load all Customer entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> LoadAllAsync(params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Customer>(expr);
			return result.ToList<ICustomer>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByCustomerCode(string customerCode, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.Contains(customerCode), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.ToLower().Contains(customerCode.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByCustomerCodeAsync(string customerCode, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CustomerCode.Contains(customerCode), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CustomerCode.ToLower().Contains(customerCode.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByCompanyName(string companyName, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.Contains(companyName), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.ToLower().Contains(companyName.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByCompanyNameAsync(string companyName, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CompanyName.Contains(companyName), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CompanyName.ToLower().Contains(companyName.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByContactName(string contactName, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.Contains(contactName), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.ToLower().Contains(contactName.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByContactNameAsync(string contactName, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactName.Contains(contactName), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactName.ToLower().Contains(contactName.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByContactTitle(string contactTitle, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.Contains(contactTitle), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.ToLower().Contains(contactTitle.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByContactTitleAsync(string contactTitle, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactTitle.Contains(contactTitle), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactTitle.ToLower().Contains(contactTitle.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByAddress(string address, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Address.Contains(address), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Address.ToLower().Contains(address.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByAddressAsync(string address, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Address.Contains(address), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Address.ToLower().Contains(address.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByCity(string city, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.City.Contains(city), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.City.ToLower().Contains(city.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByCityAsync(string city, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.City.Contains(city), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.City.ToLower().Contains(city.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByPostalCode(string postalCode, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.Contains(postalCode), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.ToLower().Contains(postalCode.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByPostalCodeAsync(string postalCode, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.PostalCode.Contains(postalCode), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.PostalCode.ToLower().Contains(postalCode.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByTelephone(string telephone, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.Contains(telephone), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.ToLower().Contains(telephone.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByTelephoneAsync(string telephone, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Telephone.Contains(telephone), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Telephone.ToLower().Contains(telephone.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByFax(string fax, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Fax.Contains(fax), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Fax.ToLower().Contains(fax.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByFaxAsync(string fax, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Fax.Contains(fax), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Fax.ToLower().Contains(fax.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> SearchByPhoto(string photo, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Photo.Contains(photo), expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Photo.ToLower().Contains(photo.ToLower()), expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByPhotoAsync(string photo, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Photo.Contains(photo), expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Photo.ToLower().Contains(photo.ToLower()), expr);
				return result.ToList<ICustomer>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual bool Add(ICustomer entity)
		{
			var entityToSave = new Customer(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.CustomerId = entityToSave.CustomerId;
			entity.CustomerCode = entityToSave.CustomerCode;
			entity.CompanyName = entityToSave.CompanyName;
			entity.ContactName = entityToSave.ContactName;
			entity.ContactTitle = entityToSave.ContactTitle;
			entity.Address = entityToSave.Address;
			entity.City = entityToSave.City;
			entity.PostalCode = entityToSave.PostalCode;
			entity.Telephone = entityToSave.Telephone;
			entity.Fax = entityToSave.Fax;
			entity.CountryId = entityToSave.CountryId;
			entity.Photo = entityToSave.Photo;
			entity.IsEnabled = entityToSave.IsEnabled;
			
			return result;
		}
		
        /// <summary>
        /// Add the Customer entity async to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> AddAsync(ICustomer entity)
		{
			var entityToSave = new Customer(entity, false);
			await this.UnitOfWork.AddAsync(entityToSave);
			bool result = await this.UnitOfWork.SaveAsync();
			
			// Populate passed in entity with newly saved values
			entity.CustomerId = entityToSave.CustomerId;
			entity.CustomerCode = entityToSave.CustomerCode;
			entity.CompanyName = entityToSave.CompanyName;
			entity.ContactName = entityToSave.ContactName;
			entity.ContactTitle = entityToSave.ContactTitle;
			entity.Address = entityToSave.Address;
			entity.City = entityToSave.City;
			entity.PostalCode = entityToSave.PostalCode;
			entity.Telephone = entityToSave.Telephone;
			entity.Fax = entityToSave.Fax;
			entity.CountryId = entityToSave.CountryId;
			entity.Photo = entityToSave.Photo;
			entity.IsEnabled = entityToSave.IsEnabled;
			
			return result;
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
        /// Update the Customer entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ICustomer entity)
		{
			bool doUpdate = false;
			var entityToUpdate = await this.UnitOfWork.FirstOrDefaultAsync<Customer>(o =>  o.CustomerId == entity.CustomerId );
			
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
				return await this.UnitOfWork.ModifyAsync(entityToUpdate);
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
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ICustomer entity)
		{		
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Customer>(o =>  o.CustomerId == entity.CustomerId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
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
		
		/// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync( int customerId)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Customer>(o =>  o.CustomerId == customerId );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<ICustomer, TResult>> maxExpression)
		{
			return this.UnitOfWork.Max(Expression.Lambda<Func<Customer, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression)
		{
			return await this.UnitOfWork.MaxAsync(Expression.Lambda<Func<Customer, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<ICustomer, TResult>> minExpression)
		{
			return this.UnitOfWork.Min(Expression.Lambda<Func<Customer, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<ICustomer, TResult>> minExpression)
		{
			return await this.UnitOfWork.MinAsync(Expression.Lambda<Func<Customer, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Helpers
		
	    protected virtual Expression<Func<Customer, object>>[] Convert(params Expression<Func<ICustomer, object>>[] includes)
	    {
	        var expr = new List<Expression<Func<Customer, object>>>();
	        foreach (var exprItem in includes)
	        {
	            expr.Add(Expression.Lambda<Func<Customer, object>>(exprItem.Body, exprItem.Parameters));
	        }

	        return expr.ToArray();
	    }
		
		#endregion
	}
}
