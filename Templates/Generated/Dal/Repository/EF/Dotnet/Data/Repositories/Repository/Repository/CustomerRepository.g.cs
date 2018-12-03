
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
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Repository
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
		public virtual ICustomer LoadByCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.FirstOrDefault<Customer>(o => o.CustomerId == customerId, cache, expr);
		}
		
        /// <summary>
        /// Load Customer entities async from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		public virtual async Task<ICustomer> LoadByCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return await this.UnitOfWork.FirstOrDefaultAsync<Customer>(cache, o => o.CustomerId == customerId, expr);
		}

        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadByCountryId(Nullable<int> countryId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Customer>(o => o.CountryId == countryId, cache, expr).ToList<ICustomer>();
		}
		
        /// <summary>
        /// Load Customer entities async from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> LoadByCountryIdAsync(Nullable<int> countryId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CountryId == countryId,cache, expr);
			return result.ToList<ICustomer>();
		}

        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadByIsEnabled(bool isEnabled, bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.AllMatching<Customer>(o => o.IsEnabled == isEnabled, cache, expr).ToList<ICustomer>();
		}
		
        /// <summary>
        /// Load Customer entities async from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> LoadByIsEnabledAsync(bool isEnabled, bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.IsEnabled == isEnabled,cache, expr);
			return result.ToList<ICustomer>();
		}

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual IList<ICustomer> LoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes)
		{
			var expr = this.Convert(includes);
			return this.UnitOfWork.GetAll<Customer>(cache, expr).ToList<ICustomer>();
		}
		
        /// <summary>
        /// Load all Customer entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> LoadAllAsync(bool cache, params Expression<Func<ICustomer,  object>>[] includes)
		{
			var expr = this.Convert(includes);
			var result = await this.UnitOfWork.GetAllAsync<Customer>(cache, expr);
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
		public virtual IList<ICustomer> SearchByCustomerCode(string customerCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.Contains(customerCode), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CustomerCode.ToLower().Contains(customerCode.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByCustomerCodeAsync(string customerCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CustomerCode.Contains(customerCode), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CustomerCode.ToLower().Contains(customerCode.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByCompanyName(string companyName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.Contains(companyName), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.CompanyName.ToLower().Contains(companyName.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByCompanyNameAsync(string companyName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CompanyName.Contains(companyName), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.CompanyName.ToLower().Contains(companyName.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByContactName(string contactName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.Contains(contactName), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactName.ToLower().Contains(contactName.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByContactNameAsync(string contactName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactName.Contains(contactName), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactName.ToLower().Contains(contactName.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByContactTitle(string contactTitle, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.Contains(contactTitle), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.ContactTitle.ToLower().Contains(contactTitle.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByContactTitleAsync(string contactTitle, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactTitle.Contains(contactTitle), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.ContactTitle.ToLower().Contains(contactTitle.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByAddress(string address, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Address.Contains(address), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Address.ToLower().Contains(address.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByAddressAsync(string address, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Address.Contains(address), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Address.ToLower().Contains(address.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByCity(string city, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.City.Contains(city), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.City.ToLower().Contains(city.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByCityAsync(string city, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.City.Contains(city), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.City.ToLower().Contains(city.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByPostalCode(string postalCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.Contains(postalCode), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.PostalCode.ToLower().Contains(postalCode.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByPostalCodeAsync(string postalCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.PostalCode.Contains(postalCode), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.PostalCode.ToLower().Contains(postalCode.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByTelephone(string telephone, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.Contains(telephone), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Telephone.ToLower().Contains(telephone.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByTelephoneAsync(string telephone, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Telephone.Contains(telephone), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Telephone.ToLower().Contains(telephone.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByFax(string fax, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Fax.Contains(fax), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Fax.ToLower().Contains(fax.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByFaxAsync(string fax, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Fax.Contains(fax), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Fax.ToLower().Contains(fax.ToLower()), cache, expr);
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
		public virtual IList<ICustomer> SearchByPhoto(string photo, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Photo.Contains(photo), cache, expr).ToList<ICustomer>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer>(o => o.Photo.ToLower().Contains(photo.ToLower()), cache, expr).ToList<ICustomer>();
			}
		}
		
        /// <summary>
        /// Search for Customer entities async in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public virtual async Task<IList<ICustomer>> SearchByPhotoAsync(string photo, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes)
		{		
			var expr = this.Convert(includes);
			if(caseSensitive) 
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Photo.Contains(photo), cache, expr);
				return result.ToList<ICustomer>();
			}
			else
			{
				var result = await this.UnitOfWork.AllMatchingAsync<Customer>(o => o.Photo.ToLower().Contains(photo.ToLower()), cache, expr);
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
			return this.UnitOfWork.Modify(entity);
		}
		
        /// <summary>
        /// Update the Customer entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> UpdateAsync(ICustomer entity)
		{
			return await this.UnitOfWork.ModifyAsync(entity);
		}
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICustomer entity)
		{		
			return this.UnitOfWork.Remove(entity);
		}
		
        /// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public virtual async Task<bool> DeleteAsync(ICustomer entity)
		{		
			return await this.UnitOfWork.RemoveAsync(entity);
		}

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int customerId, bool cache)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer>(o =>  o.CustomerId == customerId , cache);
			
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
		public virtual async Task<bool> DeleteAsync( int customerId, bool cache)
		{
			var entityToDelete = await this.UnitOfWork.FirstOrDefaultAsync<Customer>(cache, o =>  o.CustomerId == customerId  );
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer entity does not exist");
			}
			
			return await this.UnitOfWork.RemoveAsync(entityToDelete);
		}
		
		#endregion
		
		#region Aggregates
		
		public virtual TResult Max<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
		{
			return this.UnitOfWork.Max(cache, Expression.Lambda<Func<Customer, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
		{
			return await this.UnitOfWork.MaxAsync(cache, Expression.Lambda<Func<Customer, TResult>>(maxExpression.Body, maxExpression.Parameters));
		}
		
		public virtual TResult Min<TResult>(Expression<Func<ICustomer, TResult>> minExpression, bool cache)
		{
			return this.UnitOfWork.Min(cache, Expression.Lambda<Func<Customer, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		public virtual async Task<TResult> MinAsync<TResult>(Expression<Func<ICustomer, TResult>> minExpression, bool cache)
		{
			return await this.UnitOfWork.MinAsync(cache, Expression.Lambda<Func<Customer, TResult>>(minExpression.Body, minExpression.Parameters));
		}
		
		#endregion
		
		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkDelete(IEnumerable<ICustomer> items)
		{
			this.UnitOfWork.BulkDelete<ICustomer>(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkDeleteAsync(IEnumerable<ICustomer> items)
		{
			await this.UnitOfWork.BulkDeleteAsync<ICustomer>(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkInsert(IEnumerable<ICustomer> items)
		{
			this.UnitOfWork.BulkInsert<ICustomer>(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ICustomer> items)
		{
			await this.UnitOfWork.BulkInsertAsync<ICustomer>(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public void BulkUpdate(IEnumerable<ICustomer> items)
		{
			this.UnitOfWork.BulkUpdate<ICustomer>(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BulkUpdateAsync(IEnumerable<ICustomer> items)
		{
			await this.UnitOfWork.BulkUpdateAsync<ICustomer>(items);
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
