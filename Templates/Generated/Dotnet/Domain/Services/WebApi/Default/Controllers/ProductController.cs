
// <copyright file=".g.cs" company="MIT">
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
using System.Linq.Expressions;
using DotNetScaffolder.Domain.Core.Interfaces;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Security;

namespace DotNetScaffolder.Domain.Services.WebApi.Default.Controllers
{
    /// <summary>
	/// The Product Controller
	/// </summary>
    //[DynamicClaimRequirement(ClaimTypes.All, "CanReadProductResource")]
    public partial class ProductController 
	{

	    /// <summary>
	    ///     Gets the unit ofwork.
	    /// </summary>
	    public IUnitOfWork UnitOfwork
	    {
	        get
	        {
	            return (IUnitOfWork)this.HttpContext?.Items["WebUnitOfWork"];
	        }
	    }

        /// <summary>
        /// Configure Includes
        /// </summary>
	    public void ConfigureIncludes()
	    {
            this.LoadByProductProductIdIncludes = new Expression<Func<IProduct, object>>[]
            {
                a => a.Book,
                a => a.Software
            };
        }

        #region Configure Load

        /// <summary>
        /// Gets LoadByBankAccountBankAccountIdIncludes
        /// </summary
        public Expression<Func<IBankAccount, object>>[] LoadByBankAccountBankAccountIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByBankAccountBankAccountIdAsyncIncludes
        /// </summary
        public Expression<Func<IBankAccount, object>>[] LoadByBankAccountBankAccountIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets BankAccountLoadAllIncludes
        /// </summary
        public Expression<Func<IBankAccount, object>>[] BankAccountLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets BankAccountLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<IBankAccount, object>>[] BankAccountLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByBankTransfersBankTransferIdIncludes
        /// </summary
        public Expression<Func<IBankTransfers, object>>[] LoadByBankTransfersBankTransferIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByBankTransfersBankTransferIdAsyncIncludes
        /// </summary
        public Expression<Func<IBankTransfers, object>>[] LoadByBankTransfersBankTransferIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets BankTransfersLoadAllIncludes
        /// </summary
        public Expression<Func<IBankTransfers, object>>[] BankTransfersLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets BankTransfersLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<IBankTransfers, object>>[] BankTransfersLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByBookProductIdIncludes
        /// </summary
        public Expression<Func<IBook, object>>[] LoadByBookProductIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByBookProductIdAsyncIncludes
        /// </summary
        public Expression<Func<IBook, object>>[] LoadByBookProductIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets BookLoadAllIncludes
        /// </summary
        public Expression<Func<IBook, object>>[] BookLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets BookLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<IBook, object>>[] BookLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByCountryCountryIdIncludes
        /// </summary
        public Expression<Func<ICountry, object>>[] LoadByCountryCountryIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByCountryCountryIdAsyncIncludes
        /// </summary
        public Expression<Func<ICountry, object>>[] LoadByCountryCountryIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets CountryLoadAllIncludes
        /// </summary
        public Expression<Func<ICountry, object>>[] CountryLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets CountryLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<ICountry, object>>[] CountryLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByCustomerCustomerIdIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] LoadByCustomerCustomerIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByCustomerCustomerIdAsyncIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] LoadByCustomerCustomerIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets CustomerLoadAllIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets CustomerLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByOrderOrderIdIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] LoadByOrderOrderIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByOrderOrderIdAsyncIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] LoadByOrderOrderIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets OrderLoadAllIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets OrderLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByOrderDetailsOrderDetailsIdIncludes
        /// </summary
        public Expression<Func<IOrderDetails, object>>[] LoadByOrderDetailsOrderDetailsIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByOrderDetailsOrderDetailsIdAsyncIncludes
        /// </summary
        public Expression<Func<IOrderDetails, object>>[] LoadByOrderDetailsOrderDetailsIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets OrderDetailsLoadAllIncludes
        /// </summary
        public Expression<Func<IOrderDetails, object>>[] OrderDetailsLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets OrderDetailsLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<IOrderDetails, object>>[] OrderDetailsLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadByProductProductIdIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] LoadByProductProductIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadByProductProductIdAsyncIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] LoadByProductProductIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets ProductLoadAllIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets ProductLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductLoadAllAsyncIncludes { get; set; }

        /// <summary>
        /// Gets LoadBySoftwareProductIdIncludes
        /// </summary
        public Expression<Func<ISoftware, object>>[] LoadBySoftwareProductIdIncludes { get; set; }

        /// <summary>
        /// Gets LoadBySoftwareProductIdAsyncIncludes
        /// </summary
        public Expression<Func<ISoftware, object>>[] LoadBySoftwareProductIdAsyncIncludes { get; set; }

        /// <summary>
        /// Gets SoftwareLoadAllIncludes
        /// </summary
        public Expression<Func<ISoftware, object>>[] SoftwareLoadAllIncludes { get; set; }

        /// <summary>
        /// Gets SoftwareLoadAllAsyncIncludes
        /// </summary
        public Expression<Func<ISoftware, object>>[] SoftwareLoadAllAsyncIncludes { get; set; }

        #endregion

        #region Configure Search
        
        /// <summary>
        /// Gets BankAccountSearchByBankAccountNumberIncludes
        /// </summary
        public Expression<Func<IBankAccount, object>>[] BankAccountSearchByBankAccountNumberIncludes { get; set; }

        /// <summary>
        /// Gets BankAccountSearchByBankAccountNumberIncludesAsync
        /// </summary
        public Expression<Func<IBankAccount, object>>[] BankAccountSearchByBankAccountNumberIncludesAsync { get; set; }


        /// <summary>
        /// Gets BookSearchByPublisherIncludes
        /// </summary
        public Expression<Func<IBook, object>>[] BookSearchByPublisherIncludes { get; set; }

        /// <summary>
        /// Gets BookSearchByPublisherIncludesAsync
        /// </summary
        public Expression<Func<IBook, object>>[] BookSearchByPublisherIncludesAsync { get; set; }


        /// <summary>
        /// Gets CountrySearchByCountryNameIncludes
        /// </summary
        public Expression<Func<ICountry, object>>[] CountrySearchByCountryNameIncludes { get; set; }

        /// <summary>
        /// Gets CountrySearchByCountryNameIncludesAsync
        /// </summary
        public Expression<Func<ICountry, object>>[] CountrySearchByCountryNameIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByCustomerCodeIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByCustomerCodeIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByCustomerCodeIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByCustomerCodeIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByCompanyNameIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByCompanyNameIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByCompanyNameIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByCompanyNameIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByContactNameIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByContactNameIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByContactNameIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByContactNameIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByContactTitleIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByContactTitleIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByContactTitleIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByContactTitleIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByAddressIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByAddressIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByAddressIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByAddressIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByCityIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByCityIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByCityIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByCityIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByPostalCodeIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByPostalCodeIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByPostalCodeIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByPostalCodeIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByTelephoneIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByTelephoneIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByTelephoneIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByTelephoneIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByFaxIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByFaxIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByFaxIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByFaxIncludesAsync { get; set; }


        /// <summary>
        /// Gets CustomerSearchByPhotoIncludes
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByPhotoIncludes { get; set; }

        /// <summary>
        /// Gets CustomerSearchByPhotoIncludesAsync
        /// </summary
        public Expression<Func<ICustomer, object>>[] CustomerSearchByPhotoIncludesAsync { get; set; }


        /// <summary>
        /// Gets OrderSearchByShippingNameIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingNameIncludes { get; set; }

        /// <summary>
        /// Gets OrderSearchByShippingNameIncludesAsync
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingNameIncludesAsync { get; set; }


        /// <summary>
        /// Gets OrderSearchByShippingAddressIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingAddressIncludes { get; set; }

        /// <summary>
        /// Gets OrderSearchByShippingAddressIncludesAsync
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingAddressIncludesAsync { get; set; }


        /// <summary>
        /// Gets OrderSearchByShippingCityIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingCityIncludes { get; set; }

        /// <summary>
        /// Gets OrderSearchByShippingCityIncludesAsync
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingCityIncludesAsync { get; set; }


        /// <summary>
        /// Gets OrderSearchByShippingZipIncludes
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingZipIncludes { get; set; }

        /// <summary>
        /// Gets OrderSearchByShippingZipIncludesAsync
        /// </summary
        public Expression<Func<IOrder, object>>[] OrderSearchByShippingZipIncludesAsync { get; set; }


        /// <summary>
        /// Gets ProductSearchByProductDescriptionIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByProductDescriptionIncludes { get; set; }

        /// <summary>
        /// Gets ProductSearchByProductDescriptionIncludesAsync
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByProductDescriptionIncludesAsync { get; set; }


        /// <summary>
        /// Gets SoftwareSearchByLicenseCodeIncludes
        /// </summary
        public Expression<Func<ISoftware, object>>[] SoftwareSearchByLicenseCodeIncludes { get; set; }

        /// <summary>
        /// Gets SoftwareSearchByLicenseCodeIncludesAsync
        /// </summary
        public Expression<Func<ISoftware, object>>[] SoftwareSearchByLicenseCodeIncludesAsync { get; set; }

		#endregion
    }
}

