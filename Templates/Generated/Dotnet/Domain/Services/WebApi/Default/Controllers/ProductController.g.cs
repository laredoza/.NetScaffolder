
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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading.Tasks;

using DotNetScaffolder.Domain.ApplicationService;
using DotNetScaffolder.Domain.Interfaces;

namespace DotNetScaffolder.Domain.Controllers
{
    /// <summary>
	/// The Product Controller
	/// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
	public partial class ProductController : BaseController
	{

        /// <summary>
        /// Gets or sets the Product ApplicationService 
        /// </summary>
        protected IProductApplicationService ProductApplicationService { get; set; }

        public ProductController (
                      IProductApplicationService productApplicationService
                                     )
        {
            this.ConfigureIncludes();
            this.ProductApplicationService = productApplicationService;
        }

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IBankAccount</returns>
        [HttpGet("{bankAccountId}/{cache}")]
		public ActionResult<IBankAccount> LoadByBankAccountBankAccountId(int bankAccountId, bool cache)
        {
            if( this.LoadByBankAccountBankAccountIdIncludes == null)
            {
                this.LoadByBankAccountBankAccountIdIncludes = new Expression<Func<IBankAccount, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByBankAccountBankAccountId(bankAccountId, cache, this.LoadByBankAccountBankAccountIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load BankAccount Async entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IBankAccount</returns>
        [HttpGet("{bankAccountId}/{cache}")]
		public async Task<ActionResult<IBankAccount>> LoadByBankAccountBankAccountIdAsync(int bankAccountId, bool cache)
        {
            if( this.LoadByBankAccountBankAccountIdAsyncIncludes == null)
            {
                this.LoadByBankAccountBankAccountIdAsyncIncludes = new Expression<Func<IBankAccount, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByBankAccountBankAccountIdAsync(bankAccountId, cache, this.LoadByBankAccountBankAccountIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IBankAccount></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<IBankAccount>> BankAccountLoadAll(bool cache)
        {
            if( this.BankAccountLoadAllIncludes == null)
            {
                this.BankAccountLoadAllIncludes = new Expression<Func<IBankAccount, object>>[]{};
            }

            var result = this.ProductApplicationService.BankAccountLoadAll(cache, this.BankAccountLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all BankAccount Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IBankAccount></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<IBankAccount>>> BankAccountLoadAllAsync(bool cache)
        {
            if( this.BankAccountLoadAllAsyncIncludes == null)
            {
                this.BankAccountLoadAllAsyncIncludes = new Expression<Func<IBankAccount, object>>[]{};
            }

            var result = await this.ProductApplicationService.BankAccountLoadAllAsync(cache, this.BankAccountLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load BankTransfers entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IBankTransfers</returns>
        [HttpGet("{bankTransferId}/{cache}")]
		public ActionResult<IBankTransfers> LoadByBankTransfersBankTransferId(int bankTransferId, bool cache)
        {
            if( this.LoadByBankTransfersBankTransferIdIncludes == null)
            {
                this.LoadByBankTransfersBankTransferIdIncludes = new Expression<Func<IBankTransfers, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByBankTransfersBankTransferId(bankTransferId, cache, this.LoadByBankTransfersBankTransferIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load BankTransfers Async entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IBankTransfers</returns>
        [HttpGet("{bankTransferId}/{cache}")]
		public async Task<ActionResult<IBankTransfers>> LoadByBankTransfersBankTransferIdAsync(int bankTransferId, bool cache)
        {
            if( this.LoadByBankTransfersBankTransferIdAsyncIncludes == null)
            {
                this.LoadByBankTransfersBankTransferIdAsyncIncludes = new Expression<Func<IBankTransfers, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByBankTransfersBankTransferIdAsync(bankTransferId, cache, this.LoadByBankTransfersBankTransferIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IBankTransfers></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<IBankTransfers>> BankTransfersLoadAll(bool cache)
        {
            if( this.BankTransfersLoadAllIncludes == null)
            {
                this.BankTransfersLoadAllIncludes = new Expression<Func<IBankTransfers, object>>[]{};
            }

            var result = this.ProductApplicationService.BankTransfersLoadAll(cache, this.BankTransfersLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all BankTransfers Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IBankTransfers></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<IBankTransfers>>> BankTransfersLoadAllAsync(bool cache)
        {
            if( this.BankTransfersLoadAllAsyncIncludes == null)
            {
                this.BankTransfersLoadAllAsyncIncludes = new Expression<Func<IBankTransfers, object>>[]{};
            }

            var result = await this.ProductApplicationService.BankTransfersLoadAllAsync(cache, this.BankTransfersLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load Book entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IBook</returns>
        [HttpGet("{productId}/{cache}")]
		public ActionResult<IBook> LoadByBookProductId(int productId, bool cache)
        {
            if( this.LoadByBookProductIdIncludes == null)
            {
                this.LoadByBookProductIdIncludes = new Expression<Func<IBook, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByBookProductId(productId, cache, this.LoadByBookProductIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load Book Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IBook</returns>
        [HttpGet("{productId}/{cache}")]
		public async Task<ActionResult<IBook>> LoadByBookProductIdAsync(int productId, bool cache)
        {
            if( this.LoadByBookProductIdAsyncIncludes == null)
            {
                this.LoadByBookProductIdAsyncIncludes = new Expression<Func<IBook, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByBookProductIdAsync(productId, cache, this.LoadByBookProductIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IBook></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<IBook>> BookLoadAll(bool cache)
        {
            if( this.BookLoadAllIncludes == null)
            {
                this.BookLoadAllIncludes = new Expression<Func<IBook, object>>[]{};
            }

            var result = this.ProductApplicationService.BookLoadAll(cache, this.BookLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Book Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IBook></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<IBook>>> BookLoadAllAsync(bool cache)
        {
            if( this.BookLoadAllAsyncIncludes == null)
            {
                this.BookLoadAllAsyncIncludes = new Expression<Func<IBook, object>>[]{};
            }

            var result = await this.ProductApplicationService.BookLoadAllAsync(cache, this.BookLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>ICountry</returns>
        [HttpGet("{countryId}/{cache}")]
		public ActionResult<ICountry> LoadByCountryCountryId(int countryId, bool cache)
        {
            if( this.LoadByCountryCountryIdIncludes == null)
            {
                this.LoadByCountryCountryIdIncludes = new Expression<Func<ICountry, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByCountryCountryId(countryId, cache, this.LoadByCountryCountryIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load Country Async entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>ICountry</returns>
        [HttpGet("{countryId}/{cache}")]
		public async Task<ActionResult<ICountry>> LoadByCountryCountryIdAsync(int countryId, bool cache)
        {
            if( this.LoadByCountryCountryIdAsyncIncludes == null)
            {
                this.LoadByCountryCountryIdAsyncIncludes = new Expression<Func<ICountry, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByCountryCountryIdAsync(countryId, cache, this.LoadByCountryCountryIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<ICountry></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<ICountry>> CountryLoadAll(bool cache)
        {
            if( this.CountryLoadAllIncludes == null)
            {
                this.CountryLoadAllIncludes = new Expression<Func<ICountry, object>>[]{};
            }

            var result = this.ProductApplicationService.CountryLoadAll(cache, this.CountryLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Country Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<ICountry></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<ICountry>>> CountryLoadAllAsync(bool cache)
        {
            if( this.CountryLoadAllAsyncIncludes == null)
            {
                this.CountryLoadAllAsyncIncludes = new Expression<Func<ICountry, object>>[]{};
            }

            var result = await this.ProductApplicationService.CountryLoadAllAsync(cache, this.CountryLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>ICustomer</returns>
        [HttpGet("{customerId}/{cache}")]
		public ActionResult<ICustomer> LoadByCustomerCustomerId(int customerId, bool cache)
        {
            if( this.LoadByCustomerCustomerIdIncludes == null)
            {
                this.LoadByCustomerCustomerIdIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByCustomerCustomerId(customerId, cache, this.LoadByCustomerCustomerIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>ICustomer</returns>
        [HttpGet("{customerId}/{cache}")]
		public async Task<ActionResult<ICustomer>> LoadByCustomerCustomerIdAsync(int customerId, bool cache)
        {
            if( this.LoadByCustomerCustomerIdAsyncIncludes == null)
            {
                this.LoadByCustomerCustomerIdAsyncIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByCustomerCustomerIdAsync(customerId, cache, this.LoadByCustomerCustomerIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<ICustomer>> CustomerLoadAll(bool cache)
        {
            if( this.CustomerLoadAllIncludes == null)
            {
                this.CustomerLoadAllIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerLoadAll(cache, this.CustomerLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<ICustomer>>> CustomerLoadAllAsync(bool cache)
        {
            if( this.CustomerLoadAllAsyncIncludes == null)
            {
                this.CustomerLoadAllAsyncIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerLoadAllAsync(cache, this.CustomerLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load Order entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IOrder</returns>
        [HttpGet("{orderId}/{cache}")]
		public ActionResult<IOrder> LoadByOrderOrderId(int orderId, bool cache)
        {
            if( this.LoadByOrderOrderIdIncludes == null)
            {
                this.LoadByOrderOrderIdIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByOrderOrderId(orderId, cache, this.LoadByOrderOrderIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load Order Async entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IOrder</returns>
        [HttpGet("{orderId}/{cache}")]
		public async Task<ActionResult<IOrder>> LoadByOrderOrderIdAsync(int orderId, bool cache)
        {
            if( this.LoadByOrderOrderIdAsyncIncludes == null)
            {
                this.LoadByOrderOrderIdAsyncIncludes = new Expression<Func<IOrder, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByOrderOrderIdAsync(orderId, cache, this.LoadByOrderOrderIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<IOrder>> OrderLoadAll(bool cache)
        {
            if( this.OrderLoadAllIncludes == null)
            {
                this.OrderLoadAllIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = this.ProductApplicationService.OrderLoadAll(cache, this.OrderLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Order Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<IOrder>>> OrderLoadAllAsync(bool cache)
        {
            if( this.OrderLoadAllAsyncIncludes == null)
            {
                this.OrderLoadAllAsyncIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = await this.ProductApplicationService.OrderLoadAllAsync(cache, this.OrderLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load OrderDetails entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IOrderDetails</returns>
        [HttpGet("{orderDetailsId}/{cache}")]
		public ActionResult<IOrderDetails> LoadByOrderDetailsOrderDetailsId(int orderDetailsId, bool cache)
        {
            if( this.LoadByOrderDetailsOrderDetailsIdIncludes == null)
            {
                this.LoadByOrderDetailsOrderDetailsIdIncludes = new Expression<Func<IOrderDetails, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByOrderDetailsOrderDetailsId(orderDetailsId, cache, this.LoadByOrderDetailsOrderDetailsIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load OrderDetails Async entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IOrderDetails</returns>
        [HttpGet("{orderDetailsId}/{cache}")]
		public async Task<ActionResult<IOrderDetails>> LoadByOrderDetailsOrderDetailsIdAsync(int orderDetailsId, bool cache)
        {
            if( this.LoadByOrderDetailsOrderDetailsIdAsyncIncludes == null)
            {
                this.LoadByOrderDetailsOrderDetailsIdAsyncIncludes = new Expression<Func<IOrderDetails, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByOrderDetailsOrderDetailsIdAsync(orderDetailsId, cache, this.LoadByOrderDetailsOrderDetailsIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IOrderDetails></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<IOrderDetails>> OrderDetailsLoadAll(bool cache)
        {
            if( this.OrderDetailsLoadAllIncludes == null)
            {
                this.OrderDetailsLoadAllIncludes = new Expression<Func<IOrderDetails, object>>[]{};
            }

            var result = this.ProductApplicationService.OrderDetailsLoadAll(cache, this.OrderDetailsLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all OrderDetails Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IOrderDetails></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<IOrderDetails>>> OrderDetailsLoadAllAsync(bool cache)
        {
            if( this.OrderDetailsLoadAllAsyncIncludes == null)
            {
                this.OrderDetailsLoadAllAsyncIncludes = new Expression<Func<IOrderDetails, object>>[]{};
            }

            var result = await this.ProductApplicationService.OrderDetailsLoadAllAsync(cache, this.OrderDetailsLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IProduct</returns>
        [HttpGet("{productId}/{cache}")]
		public ActionResult<IProduct> LoadByProductProductId(int productId, bool cache)
        {
            if( this.LoadByProductProductIdIncludes == null)
            {
                this.LoadByProductProductIdIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadByProductProductId(productId, cache, this.LoadByProductProductIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IProduct</returns>
        [HttpGet("{productId}/{cache}")]
		public async Task<ActionResult<IProduct>> LoadByProductProductIdAsync(int productId, bool cache)
        {
            if( this.LoadByProductProductIdAsyncIncludes == null)
            {
                this.LoadByProductProductIdAsyncIncludes = new Expression<Func<IProduct, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadByProductProductIdAsync(productId, cache, this.LoadByProductProductIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<IProduct>> ProductLoadAll(bool cache)
        {
            if( this.ProductLoadAllIncludes == null)
            {
                this.ProductLoadAllIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            var result = this.ProductApplicationService.ProductLoadAll(cache, this.ProductLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<IProduct>>> ProductLoadAllAsync(bool cache)
        {
            if( this.ProductLoadAllAsyncIncludes == null)
            {
                this.ProductLoadAllAsyncIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            var result = await this.ProductApplicationService.ProductLoadAllAsync(cache, this.ProductLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Load Software entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>ISoftware</returns>
        [HttpGet("{productId}/{cache}")]
		public ActionResult<ISoftware> LoadBySoftwareProductId(int productId, bool cache)
        {
            if( this.LoadBySoftwareProductIdIncludes == null)
            {
                this.LoadBySoftwareProductIdIncludes = new Expression<Func<ISoftware, object>>[]{};
            }

            var result = this.ProductApplicationService.LoadBySoftwareProductId(productId, cache, this.LoadBySoftwareProductIdIncludes);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Load Software Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>ISoftware</returns>
        [HttpGet("{productId}/{cache}")]
		public async Task<ActionResult<ISoftware>> LoadBySoftwareProductIdAsync(int productId, bool cache)
        {
            if( this.LoadBySoftwareProductIdAsyncIncludes == null)
            {
                this.LoadBySoftwareProductIdAsyncIncludes = new Expression<Func<ISoftware, object>>[]{};
            }

           var result = await this.ProductApplicationService.LoadBySoftwareProductIdAsync(productId, cache, this.LoadBySoftwareProductIdAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<ISoftware></returns>
        [HttpGet("{cache}")]
		public ActionResult<IList<ISoftware>> SoftwareLoadAll(bool cache)
        {
            if( this.SoftwareLoadAllIncludes == null)
            {
                this.SoftwareLoadAllIncludes = new Expression<Func<ISoftware, object>>[]{};
            }

            var result = this.ProductApplicationService.SoftwareLoadAll(cache, this.SoftwareLoadAllIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Load all Software Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<ISoftware></returns>
        [HttpGet("{cache}")]
		public async Task<ActionResult<IList<ISoftware>>> SoftwareLoadAllAsync(bool cache)
        {
            if( this.SoftwareLoadAllAsyncIncludes == null)
            {
                this.SoftwareLoadAllAsyncIncludes = new Expression<Func<ISoftware, object>>[]{};
            }

            var result = await this.ProductApplicationService.SoftwareLoadAllAsync(cache, this.SoftwareLoadAllAsyncIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        #endregion

        #region Search
                
        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
        [HttpGet("{bankAccountId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IBankAccount>> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive, bool cache)
        {
            if( this.BankAccountSearchByBankAccountNumberIncludes == null)
            {
                this.BankAccountSearchByBankAccountNumberIncludes = new Expression<Func<IBankAccount, object>>[]{};
            }

            var result = this.ProductApplicationService.BankAccountSearchByBankAccountNumber(bankAccountNumber,caseSensitive, cache, this.BankAccountSearchByBankAccountNumberIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for BankAccount Async entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
        [HttpGet("{bankAccountId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IBankAccount>>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber, bool caseSensitive, bool cache)
        {
            if( this.BankAccountSearchByBankAccountNumberIncludesAsync == null)
            {
                this.BankAccountSearchByBankAccountNumberIncludesAsync = new Expression<Func<IBankAccount, object>>[]{};
            }

            var result = await this.ProductApplicationService.BankAccountSearchByBankAccountNumberAsync(bankAccountNumber,caseSensitive, cache, this.BankAccountSearchByBankAccountNumberIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBook></returns>
        [HttpGet("{productId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IBook>> BookSearchByPublisher(string publisher, bool caseSensitive, bool cache)
        {
            if( this.BookSearchByPublisherIncludes == null)
            {
                this.BookSearchByPublisherIncludes = new Expression<Func<IBook, object>>[]{};
            }

            var result = this.ProductApplicationService.BookSearchByPublisher(publisher,caseSensitive, cache, this.BookSearchByPublisherIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Book Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBook></returns>
        [HttpGet("{productId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IBook>>> BookSearchByPublisherAsync(string publisher, bool caseSensitive, bool cache)
        {
            if( this.BookSearchByPublisherIncludesAsync == null)
            {
                this.BookSearchByPublisherIncludesAsync = new Expression<Func<IBook, object>>[]{};
            }

            var result = await this.ProductApplicationService.BookSearchByPublisherAsync(publisher,caseSensitive, cache, this.BookSearchByPublisherIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountry></returns>
        [HttpGet("{countryId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICountry>> CountrySearchByCountryName(string countryName, bool caseSensitive, bool cache)
        {
            if( this.CountrySearchByCountryNameIncludes == null)
            {
                this.CountrySearchByCountryNameIncludes = new Expression<Func<ICountry, object>>[]{};
            }

            var result = this.ProductApplicationService.CountrySearchByCountryName(countryName,caseSensitive, cache, this.CountrySearchByCountryNameIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Country Async entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountry></returns>
        [HttpGet("{countryId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICountry>>> CountrySearchByCountryNameAsync(string countryName, bool caseSensitive, bool cache)
        {
            if( this.CountrySearchByCountryNameIncludesAsync == null)
            {
                this.CountrySearchByCountryNameIncludesAsync = new Expression<Func<ICountry, object>>[]{};
            }

            var result = await this.ProductApplicationService.CountrySearchByCountryNameAsync(countryName,caseSensitive, cache, this.CountrySearchByCountryNameIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByCustomerCodeIncludes == null)
            {
                this.CustomerSearchByCustomerCodeIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByCustomerCode(customerCode,caseSensitive, cache, this.CustomerSearchByCustomerCodeIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByCustomerCodeIncludesAsync == null)
            {
                this.CustomerSearchByCustomerCodeIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByCustomerCodeAsync(customerCode,caseSensitive, cache, this.CustomerSearchByCustomerCodeIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByCompanyName(string companyName, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByCompanyNameIncludes == null)
            {
                this.CustomerSearchByCompanyNameIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByCompanyName(companyName,caseSensitive, cache, this.CustomerSearchByCompanyNameIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByCompanyNameAsync(string companyName, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByCompanyNameIncludesAsync == null)
            {
                this.CustomerSearchByCompanyNameIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByCompanyNameAsync(companyName,caseSensitive, cache, this.CustomerSearchByCompanyNameIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByContactName(string contactName, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByContactNameIncludes == null)
            {
                this.CustomerSearchByContactNameIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByContactName(contactName,caseSensitive, cache, this.CustomerSearchByContactNameIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByContactNameAsync(string contactName, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByContactNameIncludesAsync == null)
            {
                this.CustomerSearchByContactNameIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByContactNameAsync(contactName,caseSensitive, cache, this.CustomerSearchByContactNameIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByContactTitleIncludes == null)
            {
                this.CustomerSearchByContactTitleIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByContactTitle(contactTitle,caseSensitive, cache, this.CustomerSearchByContactTitleIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByContactTitleAsync(string contactTitle, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByContactTitleIncludesAsync == null)
            {
                this.CustomerSearchByContactTitleIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByContactTitleAsync(contactTitle,caseSensitive, cache, this.CustomerSearchByContactTitleIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByAddress(string address, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByAddressIncludes == null)
            {
                this.CustomerSearchByAddressIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByAddress(address,caseSensitive, cache, this.CustomerSearchByAddressIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByAddressAsync(string address, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByAddressIncludesAsync == null)
            {
                this.CustomerSearchByAddressIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByAddressAsync(address,caseSensitive, cache, this.CustomerSearchByAddressIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByCity(string city, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByCityIncludes == null)
            {
                this.CustomerSearchByCityIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByCity(city,caseSensitive, cache, this.CustomerSearchByCityIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByCityAsync(string city, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByCityIncludesAsync == null)
            {
                this.CustomerSearchByCityIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByCityAsync(city,caseSensitive, cache, this.CustomerSearchByCityIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByPostalCode(string postalCode, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByPostalCodeIncludes == null)
            {
                this.CustomerSearchByPostalCodeIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByPostalCode(postalCode,caseSensitive, cache, this.CustomerSearchByPostalCodeIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByPostalCodeAsync(string postalCode, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByPostalCodeIncludesAsync == null)
            {
                this.CustomerSearchByPostalCodeIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByPostalCodeAsync(postalCode,caseSensitive, cache, this.CustomerSearchByPostalCodeIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByTelephone(string telephone, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByTelephoneIncludes == null)
            {
                this.CustomerSearchByTelephoneIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByTelephone(telephone,caseSensitive, cache, this.CustomerSearchByTelephoneIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByTelephoneAsync(string telephone, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByTelephoneIncludesAsync == null)
            {
                this.CustomerSearchByTelephoneIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByTelephoneAsync(telephone,caseSensitive, cache, this.CustomerSearchByTelephoneIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByFax(string fax, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByFaxIncludes == null)
            {
                this.CustomerSearchByFaxIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByFax(fax,caseSensitive, cache, this.CustomerSearchByFaxIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByFaxAsync(string fax, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByFaxIncludesAsync == null)
            {
                this.CustomerSearchByFaxIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByFaxAsync(fax,caseSensitive, cache, this.CustomerSearchByFaxIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ICustomer>> CustomerSearchByPhoto(string photo, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByPhotoIncludes == null)
            {
                this.CustomerSearchByPhotoIncludes = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = this.ProductApplicationService.CustomerSearchByPhoto(photo,caseSensitive, cache, this.CustomerSearchByPhotoIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
        [HttpGet("{customerId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ICustomer>>> CustomerSearchByPhotoAsync(string photo, bool caseSensitive, bool cache)
        {
            if( this.CustomerSearchByPhotoIncludesAsync == null)
            {
                this.CustomerSearchByPhotoIncludesAsync = new Expression<Func<ICustomer, object>>[]{};
            }

            var result = await this.ProductApplicationService.CustomerSearchByPhotoAsync(photo,caseSensitive, cache, this.CustomerSearchByPhotoIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IOrder>> OrderSearchByShippingName(string shippingName, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingNameIncludes == null)
            {
                this.OrderSearchByShippingNameIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = this.ProductApplicationService.OrderSearchByShippingName(shippingName,caseSensitive, cache, this.OrderSearchByShippingNameIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IOrder>>> OrderSearchByShippingNameAsync(string shippingName, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingNameIncludesAsync == null)
            {
                this.OrderSearchByShippingNameIncludesAsync = new Expression<Func<IOrder, object>>[]{};
            }

            var result = await this.ProductApplicationService.OrderSearchByShippingNameAsync(shippingName,caseSensitive, cache, this.OrderSearchByShippingNameIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IOrder>> OrderSearchByShippingAddress(string shippingAddress, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingAddressIncludes == null)
            {
                this.OrderSearchByShippingAddressIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = this.ProductApplicationService.OrderSearchByShippingAddress(shippingAddress,caseSensitive, cache, this.OrderSearchByShippingAddressIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IOrder>>> OrderSearchByShippingAddressAsync(string shippingAddress, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingAddressIncludesAsync == null)
            {
                this.OrderSearchByShippingAddressIncludesAsync = new Expression<Func<IOrder, object>>[]{};
            }

            var result = await this.ProductApplicationService.OrderSearchByShippingAddressAsync(shippingAddress,caseSensitive, cache, this.OrderSearchByShippingAddressIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IOrder>> OrderSearchByShippingCity(string shippingCity, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingCityIncludes == null)
            {
                this.OrderSearchByShippingCityIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = this.ProductApplicationService.OrderSearchByShippingCity(shippingCity,caseSensitive, cache, this.OrderSearchByShippingCityIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IOrder>>> OrderSearchByShippingCityAsync(string shippingCity, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingCityIncludesAsync == null)
            {
                this.OrderSearchByShippingCityIncludesAsync = new Expression<Func<IOrder, object>>[]{};
            }

            var result = await this.ProductApplicationService.OrderSearchByShippingCityAsync(shippingCity,caseSensitive, cache, this.OrderSearchByShippingCityIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IOrder>> OrderSearchByShippingZip(string shippingZip, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingZipIncludes == null)
            {
                this.OrderSearchByShippingZipIncludes = new Expression<Func<IOrder, object>>[]{};
            }

            var result = this.ProductApplicationService.OrderSearchByShippingZip(shippingZip,caseSensitive, cache, this.OrderSearchByShippingZipIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
        [HttpGet("{orderId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IOrder>>> OrderSearchByShippingZipAsync(string shippingZip, bool caseSensitive, bool cache)
        {
            if( this.OrderSearchByShippingZipIncludesAsync == null)
            {
                this.OrderSearchByShippingZipIncludesAsync = new Expression<Func<IOrder, object>>[]{};
            }

            var result = await this.ProductApplicationService.OrderSearchByShippingZipAsync(shippingZip,caseSensitive, cache, this.OrderSearchByShippingZipIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet("{productId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<IProduct>> ProductSearchByProductDescription(string productDescription, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByProductDescriptionIncludes == null)
            {
                this.ProductSearchByProductDescriptionIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            var result = this.ProductApplicationService.ProductSearchByProductDescription(productDescription,caseSensitive, cache, this.ProductSearchByProductDescriptionIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Product Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet("{productId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<IProduct>>> ProductSearchByProductDescriptionAsync(string productDescription, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByProductDescriptionIncludesAsync == null)
            {
                this.ProductSearchByProductDescriptionIncludesAsync = new Expression<Func<IProduct, object>>[]{};
            }

            var result = await this.ProductApplicationService.ProductSearchByProductDescriptionAsync(productDescription,caseSensitive, cache, this.ProductSearchByProductDescriptionIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }


        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISoftware></returns>
        [HttpGet("{productId}/{caseSensitive}/{cache}")]
		public ActionResult<IList<ISoftware>> SoftwareSearchByLicenseCode(string licenseCode, bool caseSensitive, bool cache)
        {
            if( this.SoftwareSearchByLicenseCodeIncludes == null)
            {
                this.SoftwareSearchByLicenseCodeIncludes = new Expression<Func<ISoftware, object>>[]{};
            }

            var result = this.ProductApplicationService.SoftwareSearchByLicenseCode(licenseCode,caseSensitive, cache, this.SoftwareSearchByLicenseCodeIncludes);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Search for Software Async entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISoftware></returns>
        [HttpGet("{productId}/{caseSensitive}/{cache}")]
        public async Task<ActionResult<IList<ISoftware>>> SoftwareSearchByLicenseCodeAsync(string licenseCode, bool caseSensitive, bool cache)
        {
            if( this.SoftwareSearchByLicenseCodeIncludesAsync == null)
            {
                this.SoftwareSearchByLicenseCodeIncludesAsync = new Expression<Func<ISoftware, object>>[]{};
            }

            var result = await this.ProductApplicationService.SoftwareSearchByLicenseCodeAsync(licenseCode,caseSensitive, cache, this.SoftwareSearchByLicenseCodeIncludesAsync);
            
            if (result == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BankAccountAdd([FromBody] IBankAccount entity)
        {
            return this.ProductApplicationService.BankAccountUpdate(entity);
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BankAccountUpdate([FromBody] IBankAccount entity)
        {
            return this.ProductApplicationService.BankAccountUpdate(entity);
        }
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BankAccountDelete([FromBody] IBankAccount entity)
        {
            return this.ProductApplicationService.BankAccountDelete(entity);
        }

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{bankAccountId}/{cache}")]
		public bool BankAccountDelete( int bankAccountId, bool cache)
        {
            return this.ProductApplicationService.BankAccountDelete( bankAccountId, cache);
        }

		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BankTransfersAdd([FromBody] IBankTransfers entity)
        {
            return this.ProductApplicationService.BankTransfersUpdate(entity);
        }

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BankTransfersUpdate([FromBody] IBankTransfers entity)
        {
            return this.ProductApplicationService.BankTransfersUpdate(entity);
        }
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BankTransfersDelete([FromBody] IBankTransfers entity)
        {
            return this.ProductApplicationService.BankTransfersDelete(entity);
        }

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{bankTransferId}/{cache}")]
		public bool BankTransfersDelete( int bankTransferId, bool cache)
        {
            return this.ProductApplicationService.BankTransfersDelete( bankTransferId, cache);
        }

		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BookAdd([FromBody] IBook entity)
        {
            return this.ProductApplicationService.BookUpdate(entity);
        }

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BookUpdate([FromBody] IBook entity)
        {
            return this.ProductApplicationService.BookUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool BookDelete([FromBody] IBook entity)
        {
            return this.ProductApplicationService.BookDelete(entity);
        }

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
		public bool BookDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.BookDelete( productId, cache);
        }

		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool CountryAdd([FromBody] ICountry entity)
        {
            return this.ProductApplicationService.CountryUpdate(entity);
        }

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool CountryUpdate([FromBody] ICountry entity)
        {
            return this.ProductApplicationService.CountryUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool CountryDelete([FromBody] ICountry entity)
        {
            return this.ProductApplicationService.CountryDelete(entity);
        }

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{countryId}/{cache}")]
		public bool CountryDelete( int countryId, bool cache)
        {
            return this.ProductApplicationService.CountryDelete( countryId, cache);
        }

		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool CustomerAdd([FromBody] ICustomer entity)
        {
            return this.ProductApplicationService.CustomerUpdate(entity);
        }

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool CustomerUpdate([FromBody] ICustomer entity)
        {
            return this.ProductApplicationService.CustomerUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool CustomerDelete([FromBody] ICustomer entity)
        {
            return this.ProductApplicationService.CustomerDelete(entity);
        }

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{customerId}/{cache}")]
		public bool CustomerDelete( int customerId, bool cache)
        {
            return this.ProductApplicationService.CustomerDelete( customerId, cache);
        }

		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool OrderAdd([FromBody] IOrder entity)
        {
            return this.ProductApplicationService.OrderUpdate(entity);
        }

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool OrderUpdate([FromBody] IOrder entity)
        {
            return this.ProductApplicationService.OrderUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool OrderDelete([FromBody] IOrder entity)
        {
            return this.ProductApplicationService.OrderDelete(entity);
        }

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{orderId}/{cache}")]
		public bool OrderDelete( int orderId, bool cache)
        {
            return this.ProductApplicationService.OrderDelete( orderId, cache);
        }

		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool OrderDetailsAdd([FromBody] IOrderDetails entity)
        {
            return this.ProductApplicationService.OrderDetailsUpdate(entity);
        }

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool OrderDetailsUpdate([FromBody] IOrderDetails entity)
        {
            return this.ProductApplicationService.OrderDetailsUpdate(entity);
        }
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool OrderDetailsDelete([FromBody] IOrderDetails entity)
        {
            return this.ProductApplicationService.OrderDetailsDelete(entity);
        }

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{orderDetailsId}/{cache}")]
		public bool OrderDetailsDelete( int orderDetailsId, bool cache)
        {
            return this.ProductApplicationService.OrderDetailsDelete( orderDetailsId, cache);
        }

		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool ProductAdd([FromBody] IProduct entity)
        {
            return this.ProductApplicationService.ProductUpdate(entity);
        }

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool ProductUpdate([FromBody] IProduct entity)
        {
            return this.ProductApplicationService.ProductUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool ProductDelete([FromBody] IProduct entity)
        {
            return this.ProductApplicationService.ProductDelete(entity);
        }

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
		public bool ProductDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.ProductDelete( productId, cache);
        }

		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool SoftwareAdd([FromBody] ISoftware entity)
        {
            return this.ProductApplicationService.SoftwareUpdate(entity);
        }

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool SoftwareUpdate([FromBody] ISoftware entity)
        {
            return this.ProductApplicationService.SoftwareUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
        [HttpPost]
		public bool SoftwareDelete([FromBody] ISoftware entity)
        {
            return this.ProductApplicationService.SoftwareDelete(entity);
        }

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
		public bool SoftwareDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.SoftwareDelete( productId, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void BankAccountBulkDelete([FromBody] IEnumerable<IBankAccount> items)
		{
			this.ProductApplicationService.BankAccountBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task BankAccountBulkDeleteAsync([FromBody] IEnumerable<IBankAccount> items)
		{
			await this.ProductApplicationService.BankAccountBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  BankAccountBulkInsert([FromBody] IEnumerable<IBankAccount> items)
		{
			this.ProductApplicationService.BankAccountBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  BankAccountBulkInsertAsync([FromBody] IEnumerable<IBankAccount> items)
		{
			await this.ProductApplicationService.BankAccountBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void BankAccountBulkUpdate([FromBody] IEnumerable<IBankAccount> items)
		{
			this.ProductApplicationService.BankAccountBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task BankAccountBulkUpdateAsync([FromBody] IEnumerable<IBankAccount> items)
		{
			await this.ProductApplicationService.BankAccountBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void BankTransfersBulkDelete([FromBody] IEnumerable<IBankTransfers> items)
		{
			this.ProductApplicationService.BankTransfersBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task BankTransfersBulkDeleteAsync([FromBody] IEnumerable<IBankTransfers> items)
		{
			await this.ProductApplicationService.BankTransfersBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  BankTransfersBulkInsert([FromBody] IEnumerable<IBankTransfers> items)
		{
			this.ProductApplicationService.BankTransfersBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  BankTransfersBulkInsertAsync([FromBody] IEnumerable<IBankTransfers> items)
		{
			await this.ProductApplicationService.BankTransfersBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void BankTransfersBulkUpdate([FromBody] IEnumerable<IBankTransfers> items)
		{
			this.ProductApplicationService.BankTransfersBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task BankTransfersBulkUpdateAsync([FromBody] IEnumerable<IBankTransfers> items)
		{
			await this.ProductApplicationService.BankTransfersBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void BookBulkDelete([FromBody] IEnumerable<IBook> items)
		{
			this.ProductApplicationService.BookBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task BookBulkDeleteAsync([FromBody] IEnumerable<IBook> items)
		{
			await this.ProductApplicationService.BookBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  BookBulkInsert([FromBody] IEnumerable<IBook> items)
		{
			this.ProductApplicationService.BookBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  BookBulkInsertAsync([FromBody] IEnumerable<IBook> items)
		{
			await this.ProductApplicationService.BookBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void BookBulkUpdate([FromBody] IEnumerable<IBook> items)
		{
			this.ProductApplicationService.BookBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task BookBulkUpdateAsync([FromBody] IEnumerable<IBook> items)
		{
			await this.ProductApplicationService.BookBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void CountryBulkDelete([FromBody] IEnumerable<ICountry> items)
		{
			this.ProductApplicationService.CountryBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task CountryBulkDeleteAsync([FromBody] IEnumerable<ICountry> items)
		{
			await this.ProductApplicationService.CountryBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  CountryBulkInsert([FromBody] IEnumerable<ICountry> items)
		{
			this.ProductApplicationService.CountryBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  CountryBulkInsertAsync([FromBody] IEnumerable<ICountry> items)
		{
			await this.ProductApplicationService.CountryBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void CountryBulkUpdate([FromBody] IEnumerable<ICountry> items)
		{
			this.ProductApplicationService.CountryBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task CountryBulkUpdateAsync([FromBody] IEnumerable<ICountry> items)
		{
			await this.ProductApplicationService.CountryBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void CustomerBulkDelete([FromBody] IEnumerable<ICustomer> items)
		{
			this.ProductApplicationService.CustomerBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task CustomerBulkDeleteAsync([FromBody] IEnumerable<ICustomer> items)
		{
			await this.ProductApplicationService.CustomerBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  CustomerBulkInsert([FromBody] IEnumerable<ICustomer> items)
		{
			this.ProductApplicationService.CustomerBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  CustomerBulkInsertAsync([FromBody] IEnumerable<ICustomer> items)
		{
			await this.ProductApplicationService.CustomerBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void CustomerBulkUpdate([FromBody] IEnumerable<ICustomer> items)
		{
			this.ProductApplicationService.CustomerBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task CustomerBulkUpdateAsync([FromBody] IEnumerable<ICustomer> items)
		{
			await this.ProductApplicationService.CustomerBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void OrderBulkDelete([FromBody] IEnumerable<IOrder> items)
		{
			this.ProductApplicationService.OrderBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task OrderBulkDeleteAsync([FromBody] IEnumerable<IOrder> items)
		{
			await this.ProductApplicationService.OrderBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  OrderBulkInsert([FromBody] IEnumerable<IOrder> items)
		{
			this.ProductApplicationService.OrderBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  OrderBulkInsertAsync([FromBody] IEnumerable<IOrder> items)
		{
			await this.ProductApplicationService.OrderBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void OrderBulkUpdate([FromBody] IEnumerable<IOrder> items)
		{
			this.ProductApplicationService.OrderBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task OrderBulkUpdateAsync([FromBody] IEnumerable<IOrder> items)
		{
			await this.ProductApplicationService.OrderBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void OrderDetailsBulkDelete([FromBody] IEnumerable<IOrderDetails> items)
		{
			this.ProductApplicationService.OrderDetailsBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task OrderDetailsBulkDeleteAsync([FromBody] IEnumerable<IOrderDetails> items)
		{
			await this.ProductApplicationService.OrderDetailsBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  OrderDetailsBulkInsert([FromBody] IEnumerable<IOrderDetails> items)
		{
			this.ProductApplicationService.OrderDetailsBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  OrderDetailsBulkInsertAsync([FromBody] IEnumerable<IOrderDetails> items)
		{
			await this.ProductApplicationService.OrderDetailsBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void OrderDetailsBulkUpdate([FromBody] IEnumerable<IOrderDetails> items)
		{
			this.ProductApplicationService.OrderDetailsBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task OrderDetailsBulkUpdateAsync([FromBody] IEnumerable<IOrderDetails> items)
		{
			await this.ProductApplicationService.OrderDetailsBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void ProductBulkDelete([FromBody] IEnumerable<IProduct> items)
		{
			this.ProductApplicationService.ProductBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task ProductBulkDeleteAsync([FromBody] IEnumerable<IProduct> items)
		{
			await this.ProductApplicationService.ProductBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  ProductBulkInsert([FromBody] IEnumerable<IProduct> items)
		{
			this.ProductApplicationService.ProductBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  ProductBulkInsertAsync([FromBody] IEnumerable<IProduct> items)
		{
			await this.ProductApplicationService.ProductBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void ProductBulkUpdate([FromBody] IEnumerable<IProduct> items)
		{
			this.ProductApplicationService.ProductBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task ProductBulkUpdateAsync([FromBody] IEnumerable<IProduct> items)
		{
			await this.ProductApplicationService.ProductBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void SoftwareBulkDelete([FromBody] IEnumerable<ISoftware> items)
		{
			this.ProductApplicationService.SoftwareBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task SoftwareBulkDeleteAsync([FromBody] IEnumerable<ISoftware> items)
		{
			await this.ProductApplicationService.SoftwareBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        public void  SoftwareBulkInsert([FromBody] IEnumerable<ISoftware> items)
		{
			this.ProductApplicationService.SoftwareBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task  SoftwareBulkInsertAsync([FromBody] IEnumerable<ISoftware> items)
		{
			await this.ProductApplicationService.SoftwareBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost]
        public void SoftwareBulkUpdate([FromBody] IEnumerable<ISoftware> items)
		{
			this.ProductApplicationService.SoftwareBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task SoftwareBulkUpdateAsync([FromBody] IEnumerable<ISoftware> items)
		{
			await this.ProductApplicationService.SoftwareBulkUpdateAsync(items);
		}

        #endregion        
    }
}

