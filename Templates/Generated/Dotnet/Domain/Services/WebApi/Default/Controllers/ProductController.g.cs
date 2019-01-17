
// <copyright file=".g.cs" company="MIT">
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
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;

namespace DotNetScaffolder.Domain.Services.WebApi.Default.Controllers
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
        /// <returns>BankAccountDto</returns>
        [HttpGet("{bankAccountId}/{cache}")]
        [Route("~/api/Product/LoadByBankAccountBankAccountId")]
		public ActionResult<BankAccountDto> LoadByBankAccountBankAccountId(int bankAccountId, bool cache)
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
        /// <returns>BankAccountDto</returns>
        [HttpGet("{bankAccountId}/{cache}")]
        [Route("~/api/Product/LoadByBankAccountBankAccountIdAsync")]
		public async Task<ActionResult<BankAccountDto>> LoadByBankAccountBankAccountIdAsync(int bankAccountId, bool cache)
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
        /// <returns>IList<BankAccountDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/BankAccountLoadAll")]
		public ActionResult<IList<BankAccountDto>> BankAccountLoadAll(bool cache)
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
        /// <returns>IList<BankAccountDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/BankAccountLoadAllAsync")]
		public async Task<ActionResult<IList<BankAccountDto>>> BankAccountLoadAllAsync(bool cache)
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
        /// <returns>BankTransfersDto</returns>
        [HttpGet("{bankTransferId}/{cache}")]
        [Route("~/api/Product/LoadByBankTransfersBankTransferId")]
		public ActionResult<BankTransfersDto> LoadByBankTransfersBankTransferId(int bankTransferId, bool cache)
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
        /// <returns>BankTransfersDto</returns>
        [HttpGet("{bankTransferId}/{cache}")]
        [Route("~/api/Product/LoadByBankTransfersBankTransferIdAsync")]
		public async Task<ActionResult<BankTransfersDto>> LoadByBankTransfersBankTransferIdAsync(int bankTransferId, bool cache)
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
        /// <returns>IList<BankTransfersDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/BankTransfersLoadAll")]
		public ActionResult<IList<BankTransfersDto>> BankTransfersLoadAll(bool cache)
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
        /// <returns>IList<BankTransfersDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/BankTransfersLoadAllAsync")]
		public async Task<ActionResult<IList<BankTransfersDto>>> BankTransfersLoadAllAsync(bool cache)
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
        /// <returns>BookDto</returns>
        [HttpGet("{productId}/{cache}")]
        [Route("~/api/Product/LoadByBookProductId")]
		public ActionResult<BookDto> LoadByBookProductId(int productId, bool cache)
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
        /// <returns>BookDto</returns>
        [HttpGet("{productId}/{cache}")]
        [Route("~/api/Product/LoadByBookProductIdAsync")]
		public async Task<ActionResult<BookDto>> LoadByBookProductIdAsync(int productId, bool cache)
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
        /// <returns>IList<BookDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/BookLoadAll")]
		public ActionResult<IList<BookDto>> BookLoadAll(bool cache)
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
        /// <returns>IList<BookDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/BookLoadAllAsync")]
		public async Task<ActionResult<IList<BookDto>>> BookLoadAllAsync(bool cache)
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
        /// <returns>CountryDto</returns>
        [HttpGet("{countryId}/{cache}")]
        [Route("~/api/Product/LoadByCountryCountryId")]
		public ActionResult<CountryDto> LoadByCountryCountryId(int countryId, bool cache)
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
        /// <returns>CountryDto</returns>
        [HttpGet("{countryId}/{cache}")]
        [Route("~/api/Product/LoadByCountryCountryIdAsync")]
		public async Task<ActionResult<CountryDto>> LoadByCountryCountryIdAsync(int countryId, bool cache)
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
        /// <returns>IList<CountryDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/CountryLoadAll")]
		public ActionResult<IList<CountryDto>> CountryLoadAll(bool cache)
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
        /// <returns>IList<CountryDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/CountryLoadAllAsync")]
		public async Task<ActionResult<IList<CountryDto>>> CountryLoadAllAsync(bool cache)
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
        /// <returns>CustomerDto</returns>
        [HttpGet("{customerId}/{cache}")]
        [Route("~/api/Product/LoadByCustomerCustomerId")]
		public ActionResult<CustomerDto> LoadByCustomerCustomerId(int customerId, bool cache)
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
        /// <returns>CustomerDto</returns>
        [HttpGet("{customerId}/{cache}")]
        [Route("~/api/Product/LoadByCustomerCustomerIdAsync")]
		public async Task<ActionResult<CustomerDto>> LoadByCustomerCustomerIdAsync(int customerId, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/CustomerLoadAll")]
		public ActionResult<IList<CustomerDto>> CustomerLoadAll(bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/CustomerLoadAllAsync")]
		public async Task<ActionResult<IList<CustomerDto>>> CustomerLoadAllAsync(bool cache)
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
        /// <returns>OrderDto</returns>
        [HttpGet("{orderId}/{cache}")]
        [Route("~/api/Product/LoadByOrderOrderId")]
		public ActionResult<OrderDto> LoadByOrderOrderId(int orderId, bool cache)
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
        /// <returns>OrderDto</returns>
        [HttpGet("{orderId}/{cache}")]
        [Route("~/api/Product/LoadByOrderOrderIdAsync")]
		public async Task<ActionResult<OrderDto>> LoadByOrderOrderIdAsync(int orderId, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/OrderLoadAll")]
		public ActionResult<IList<OrderDto>> OrderLoadAll(bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/OrderLoadAllAsync")]
		public async Task<ActionResult<IList<OrderDto>>> OrderLoadAllAsync(bool cache)
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
        /// <returns>OrderDetailsDto</returns>
        [HttpGet("{orderDetailsId}/{cache}")]
        [Route("~/api/Product/LoadByOrderDetailsOrderDetailsId")]
		public ActionResult<OrderDetailsDto> LoadByOrderDetailsOrderDetailsId(int orderDetailsId, bool cache)
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
        /// <returns>OrderDetailsDto</returns>
        [HttpGet("{orderDetailsId}/{cache}")]
        [Route("~/api/Product/LoadByOrderDetailsOrderDetailsIdAsync")]
		public async Task<ActionResult<OrderDetailsDto>> LoadByOrderDetailsOrderDetailsIdAsync(int orderDetailsId, bool cache)
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
        /// <returns>IList<OrderDetailsDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/OrderDetailsLoadAll")]
		public ActionResult<IList<OrderDetailsDto>> OrderDetailsLoadAll(bool cache)
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
        /// <returns>IList<OrderDetailsDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/OrderDetailsLoadAllAsync")]
		public async Task<ActionResult<IList<OrderDetailsDto>>> OrderDetailsLoadAllAsync(bool cache)
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
        /// <returns>ProductDto</returns>
        [HttpGet("{productId}/{cache}")]
        [Route("~/api/Product/LoadByProductProductId")]
		public ActionResult<ProductDto> LoadByProductProductId(int productId, bool cache)
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
        /// <returns>ProductDto</returns>
        [HttpGet("{productId}/{cache}")]
        [Route("~/api/Product/LoadByProductProductIdAsync")]
		public async Task<ActionResult<ProductDto>> LoadByProductProductIdAsync(int productId, bool cache)
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
        /// <returns>IList<ProductDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/ProductLoadAll")]
		public ActionResult<IList<ProductDto>> ProductLoadAll(bool cache)
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
        /// <returns>IList<ProductDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/ProductLoadAllAsync")]
		public async Task<ActionResult<IList<ProductDto>>> ProductLoadAllAsync(bool cache)
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
        /// <returns>SoftwareDto</returns>
        [HttpGet("{productId}/{cache}")]
        [Route("~/api/Product/LoadBySoftwareProductId")]
		public ActionResult<SoftwareDto> LoadBySoftwareProductId(int productId, bool cache)
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
        /// <returns>SoftwareDto</returns>
        [HttpGet("{productId}/{cache}")]
        [Route("~/api/Product/LoadBySoftwareProductIdAsync")]
		public async Task<ActionResult<SoftwareDto>> LoadBySoftwareProductIdAsync(int productId, bool cache)
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
        /// <returns>IList<SoftwareDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/SoftwareLoadAll")]
		public ActionResult<IList<SoftwareDto>> SoftwareLoadAll(bool cache)
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
        /// <returns>IList<SoftwareDto></returns>
        [HttpGet("{cache}")]
        [Route("~/api/Product/SoftwareLoadAllAsync")]
		public async Task<ActionResult<IList<SoftwareDto>>> SoftwareLoadAllAsync(bool cache)
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
        /// <returns>IList<BankAccountDto></returns>
        [HttpGet("{BankAccountNumber}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/BankAccountSearchByBankAccountNumber")]
		public ActionResult<IList<BankAccountDto>> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive, bool cache)
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
        /// <returns>IList<BankAccountDto></returns>
        [HttpGet("{BankAccountNumber}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/BankAccountSearchByBankAccountNumberAsync")]
        public async Task<ActionResult<IList<BankAccountDto>>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber, bool caseSensitive, bool cache)
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
        /// <returns>IList<BookDto></returns>
        [HttpGet("{Publisher}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/BookSearchByPublisher")]
		public ActionResult<IList<BookDto>> BookSearchByPublisher(string publisher, bool caseSensitive, bool cache)
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
        /// <returns>IList<BookDto></returns>
        [HttpGet("{Publisher}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/BookSearchByPublisherAsync")]
        public async Task<ActionResult<IList<BookDto>>> BookSearchByPublisherAsync(string publisher, bool caseSensitive, bool cache)
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
        /// <returns>IList<CountryDto></returns>
        [HttpGet("{CountryName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CountrySearchByCountryName")]
		public ActionResult<IList<CountryDto>> CountrySearchByCountryName(string countryName, bool caseSensitive, bool cache)
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
        /// <returns>IList<CountryDto></returns>
        [HttpGet("{CountryName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CountrySearchByCountryNameAsync")]
        public async Task<ActionResult<IList<CountryDto>>> CountrySearchByCountryNameAsync(string countryName, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{CustomerCode}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByCustomerCode")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{CustomerCode}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByCustomerCodeAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{CompanyName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByCompanyName")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByCompanyName(string companyName, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{CompanyName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByCompanyNameAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByCompanyNameAsync(string companyName, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{ContactName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByContactName")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByContactName(string contactName, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{ContactName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByContactNameAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByContactNameAsync(string contactName, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{ContactTitle}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByContactTitle")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{ContactTitle}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByContactTitleAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByContactTitleAsync(string contactTitle, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Address}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByAddress")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByAddress(string address, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Address}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByAddressAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByAddressAsync(string address, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{City}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByCity")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByCity(string city, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{City}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByCityAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByCityAsync(string city, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{PostalCode}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByPostalCode")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByPostalCode(string postalCode, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{PostalCode}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByPostalCodeAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByPostalCodeAsync(string postalCode, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Telephone}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByTelephone")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByTelephone(string telephone, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Telephone}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByTelephoneAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByTelephoneAsync(string telephone, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Fax}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByFax")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByFax(string fax, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Fax}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByFaxAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByFaxAsync(string fax, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Photo}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByPhoto")]
		public ActionResult<IList<CustomerDto>> CustomerSearchByPhoto(string photo, bool caseSensitive, bool cache)
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
        /// <returns>IList<CustomerDto></returns>
        [HttpGet("{Photo}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/CustomerSearchByPhotoAsync")]
        public async Task<ActionResult<IList<CustomerDto>>> CustomerSearchByPhotoAsync(string photo, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingName")]
		public ActionResult<IList<OrderDto>> OrderSearchByShippingName(string shippingName, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingName}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingNameAsync")]
        public async Task<ActionResult<IList<OrderDto>>> OrderSearchByShippingNameAsync(string shippingName, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingAddress}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingAddress")]
		public ActionResult<IList<OrderDto>> OrderSearchByShippingAddress(string shippingAddress, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingAddress}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingAddressAsync")]
        public async Task<ActionResult<IList<OrderDto>>> OrderSearchByShippingAddressAsync(string shippingAddress, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingCity}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingCity")]
		public ActionResult<IList<OrderDto>> OrderSearchByShippingCity(string shippingCity, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingCity}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingCityAsync")]
        public async Task<ActionResult<IList<OrderDto>>> OrderSearchByShippingCityAsync(string shippingCity, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingZip}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingZip")]
		public ActionResult<IList<OrderDto>> OrderSearchByShippingZip(string shippingZip, bool caseSensitive, bool cache)
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
        /// <returns>IList<OrderDto></returns>
        [HttpGet("{ShippingZip}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/OrderSearchByShippingZipAsync")]
        public async Task<ActionResult<IList<OrderDto>>> OrderSearchByShippingZipAsync(string shippingZip, bool caseSensitive, bool cache)
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
        /// <returns>IList<ProductDto></returns>
        [HttpGet("{ProductDescription}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/ProductSearchByProductDescription")]
		public ActionResult<IList<ProductDto>> ProductSearchByProductDescription(string productDescription, bool caseSensitive, bool cache)
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
        /// <returns>IList<ProductDto></returns>
        [HttpGet("{ProductDescription}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/ProductSearchByProductDescriptionAsync")]
        public async Task<ActionResult<IList<ProductDto>>> ProductSearchByProductDescriptionAsync(string productDescription, bool caseSensitive, bool cache)
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
        /// <returns>IList<SoftwareDto></returns>
        [HttpGet("{LicenseCode}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/SoftwareSearchByLicenseCode")]
		public ActionResult<IList<SoftwareDto>> SoftwareSearchByLicenseCode(string licenseCode, bool caseSensitive, bool cache)
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
        /// <returns>IList<SoftwareDto></returns>
        [HttpGet("{LicenseCode}/{caseSensitive}/{cache}")]
        [Route("~/api/Product/SoftwareSearchByLicenseCodeAsync")]
        public async Task<ActionResult<IList<SoftwareDto>>> SoftwareSearchByLicenseCodeAsync(string licenseCode, bool caseSensitive, bool cache)
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
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/BankAccountAdd")]
		public bool ProductAdd([FromBody] BankAccountDto entity)
        {
            return this.ProductApplicationService.BankAccountAdd(entity);
        }

        /// <summary>
        /// Add the BankAccount entity async to the database.
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/BankAccountAddAsync")]
		public async Task<bool> BankAccountAddAsync([FromBody] BankAccountDto entity)
        {
            return await this.ProductApplicationService.BankAccountAddAsync(entity);
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/BankAccountUpdate")]
		public bool BankAccountUpdate([FromBody] BankAccountDto entity)
        {
            return this.ProductApplicationService.BankAccountUpdate(entity);
        }
		
        /// <summary>
        /// Update the BankAccount entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/BankAccountUpdateAsync")]
		public async Task<bool> BankAccountUpdateAsync([FromBody] BankAccountDto entity)
        {
            return await this.ProductApplicationService.BankAccountUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/BankAccountDelete")]
		public bool BankAccountDelete([FromBody] BankAccountDto entity)
        {
            return this.ProductApplicationService.BankAccountDelete(entity);
        }

        /// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/BankAccountDeleteAsync")]
		public async Task<bool> BankAccountDeleteAsync([FromBody] BankAccountDto entity)
        {
            return await this.ProductApplicationService.BankAccountDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{bankAccountId}/{cache}")]
        [Route("~/api/Product/BankAccountDeleteBybankAccountId")]
		public bool BankAccountDelete( int bankAccountId, bool cache)
        {
            return this.ProductApplicationService.BankAccountDelete( bankAccountId, cache);
        }

        /// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{bankAccountId}/{cache}")]
        [Route("~/api/Product/BankAccountDeleteBybankAccountIdAsync")]
		public async Task<bool> BankAccountDeleteAsync( int bankAccountId, bool cache)
        {
            return await this.ProductApplicationService.BankAccountDeleteAsync( bankAccountId, cache);
        }

		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/BankTransfersAdd")]
		public bool ProductAdd([FromBody] BankTransfersDto entity)
        {
            return this.ProductApplicationService.BankTransfersAdd(entity);
        }

        /// <summary>
        /// Add the BankTransfers entity async to the database.
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/BankTransfersAddAsync")]
		public async Task<bool> BankTransfersAddAsync([FromBody] BankTransfersDto entity)
        {
            return await this.ProductApplicationService.BankTransfersAddAsync(entity);
        }

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/BankTransfersUpdate")]
		public bool BankTransfersUpdate([FromBody] BankTransfersDto entity)
        {
            return this.ProductApplicationService.BankTransfersUpdate(entity);
        }
		
        /// <summary>
        /// Update the BankTransfers entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/BankTransfersUpdateAsync")]
		public async Task<bool> BankTransfersUpdateAsync([FromBody] BankTransfersDto entity)
        {
            return await this.ProductApplicationService.BankTransfersUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/BankTransfersDelete")]
		public bool BankTransfersDelete([FromBody] BankTransfersDto entity)
        {
            return this.ProductApplicationService.BankTransfersDelete(entity);
        }

        /// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/BankTransfersDeleteAsync")]
		public async Task<bool> BankTransfersDeleteAsync([FromBody] BankTransfersDto entity)
        {
            return await this.ProductApplicationService.BankTransfersDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{bankTransferId}/{cache}")]
        [Route("~/api/Product/BankTransfersDeleteBybankTransferId")]
		public bool BankTransfersDelete( int bankTransferId, bool cache)
        {
            return this.ProductApplicationService.BankTransfersDelete( bankTransferId, cache);
        }

        /// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{bankTransferId}/{cache}")]
        [Route("~/api/Product/BankTransfersDeleteBybankTransferIdAsync")]
		public async Task<bool> BankTransfersDeleteAsync( int bankTransferId, bool cache)
        {
            return await this.ProductApplicationService.BankTransfersDeleteAsync( bankTransferId, cache);
        }

		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/BookAdd")]
		public bool ProductAdd([FromBody] BookDto entity)
        {
            return this.ProductApplicationService.BookAdd(entity);
        }

        /// <summary>
        /// Add the Book entity async to the database.
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/BookAddAsync")]
		public async Task<bool> BookAddAsync([FromBody] BookDto entity)
        {
            return await this.ProductApplicationService.BookAddAsync(entity);
        }

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/BookUpdate")]
		public bool BookUpdate([FromBody] BookDto entity)
        {
            return this.ProductApplicationService.BookUpdate(entity);
        }
		
        /// <summary>
        /// Update the Book entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/BookUpdateAsync")]
		public async Task<bool> BookUpdateAsync([FromBody] BookDto entity)
        {
            return await this.ProductApplicationService.BookUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/BookDelete")]
		public bool BookDelete([FromBody] BookDto entity)
        {
            return this.ProductApplicationService.BookDelete(entity);
        }

        /// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/BookDeleteAsync")]
		public async Task<bool> BookDeleteAsync([FromBody] BookDto entity)
        {
            return await this.ProductApplicationService.BookDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
        [Route("~/api/Product/BookDeleteByproductId")]
		public bool BookDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.BookDelete( productId, cache);
        }

        /// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
        [Route("~/api/Product/BookDeleteByproductIdAsync")]
		public async Task<bool> BookDeleteAsync( int productId, bool cache)
        {
            return await this.ProductApplicationService.BookDeleteAsync( productId, cache);
        }

		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/CountryAdd")]
		public bool ProductAdd([FromBody] CountryDto entity)
        {
            return this.ProductApplicationService.CountryAdd(entity);
        }

        /// <summary>
        /// Add the Country entity async to the database.
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/CountryAddAsync")]
		public async Task<bool> CountryAddAsync([FromBody] CountryDto entity)
        {
            return await this.ProductApplicationService.CountryAddAsync(entity);
        }

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/CountryUpdate")]
		public bool CountryUpdate([FromBody] CountryDto entity)
        {
            return this.ProductApplicationService.CountryUpdate(entity);
        }
		
        /// <summary>
        /// Update the Country entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/CountryUpdateAsync")]
		public async Task<bool> CountryUpdateAsync([FromBody] CountryDto entity)
        {
            return await this.ProductApplicationService.CountryUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/CountryDelete")]
		public bool CountryDelete([FromBody] CountryDto entity)
        {
            return this.ProductApplicationService.CountryDelete(entity);
        }

        /// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/CountryDeleteAsync")]
		public async Task<bool> CountryDeleteAsync([FromBody] CountryDto entity)
        {
            return await this.ProductApplicationService.CountryDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{countryId}/{cache}")]
        [Route("~/api/Product/CountryDeleteBycountryId")]
		public bool CountryDelete( int countryId, bool cache)
        {
            return this.ProductApplicationService.CountryDelete( countryId, cache);
        }

        /// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{countryId}/{cache}")]
        [Route("~/api/Product/CountryDeleteBycountryIdAsync")]
		public async Task<bool> CountryDeleteAsync( int countryId, bool cache)
        {
            return await this.ProductApplicationService.CountryDeleteAsync( countryId, cache);
        }

		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/CustomerAdd")]
		public bool ProductAdd([FromBody] CustomerDto entity)
        {
            return this.ProductApplicationService.CustomerAdd(entity);
        }

        /// <summary>
        /// Add the Customer entity async to the database.
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/CustomerAddAsync")]
		public async Task<bool> CustomerAddAsync([FromBody] CustomerDto entity)
        {
            return await this.ProductApplicationService.CustomerAddAsync(entity);
        }

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/CustomerUpdate")]
		public bool CustomerUpdate([FromBody] CustomerDto entity)
        {
            return this.ProductApplicationService.CustomerUpdate(entity);
        }
		
        /// <summary>
        /// Update the Customer entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/CustomerUpdateAsync")]
		public async Task<bool> CustomerUpdateAsync([FromBody] CustomerDto entity)
        {
            return await this.ProductApplicationService.CustomerUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/CustomerDelete")]
		public bool CustomerDelete([FromBody] CustomerDto entity)
        {
            return this.ProductApplicationService.CustomerDelete(entity);
        }

        /// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/CustomerDeleteAsync")]
		public async Task<bool> CustomerDeleteAsync([FromBody] CustomerDto entity)
        {
            return await this.ProductApplicationService.CustomerDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{customerId}/{cache}")]
        [Route("~/api/Product/CustomerDeleteBycustomerId")]
		public bool CustomerDelete( int customerId, bool cache)
        {
            return this.ProductApplicationService.CustomerDelete( customerId, cache);
        }

        /// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{customerId}/{cache}")]
        [Route("~/api/Product/CustomerDeleteBycustomerIdAsync")]
		public async Task<bool> CustomerDeleteAsync( int customerId, bool cache)
        {
            return await this.ProductApplicationService.CustomerDeleteAsync( customerId, cache);
        }

		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/OrderAdd")]
		public bool ProductAdd([FromBody] OrderDto entity)
        {
            return this.ProductApplicationService.OrderAdd(entity);
        }

        /// <summary>
        /// Add the Order entity async to the database.
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/OrderAddAsync")]
		public async Task<bool> OrderAddAsync([FromBody] OrderDto entity)
        {
            return await this.ProductApplicationService.OrderAddAsync(entity);
        }

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/OrderUpdate")]
		public bool OrderUpdate([FromBody] OrderDto entity)
        {
            return this.ProductApplicationService.OrderUpdate(entity);
        }
		
        /// <summary>
        /// Update the Order entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/OrderUpdateAsync")]
		public async Task<bool> OrderUpdateAsync([FromBody] OrderDto entity)
        {
            return await this.ProductApplicationService.OrderUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/OrderDelete")]
		public bool OrderDelete([FromBody] OrderDto entity)
        {
            return this.ProductApplicationService.OrderDelete(entity);
        }

        /// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/OrderDeleteAsync")]
		public async Task<bool> OrderDeleteAsync([FromBody] OrderDto entity)
        {
            return await this.ProductApplicationService.OrderDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{orderId}/{cache}")]
        [Route("~/api/Product/OrderDeleteByorderId")]
		public bool OrderDelete( int orderId, bool cache)
        {
            return this.ProductApplicationService.OrderDelete( orderId, cache);
        }

        /// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{orderId}/{cache}")]
        [Route("~/api/Product/OrderDeleteByorderIdAsync")]
		public async Task<bool> OrderDeleteAsync( int orderId, bool cache)
        {
            return await this.ProductApplicationService.OrderDeleteAsync( orderId, cache);
        }

		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/OrderDetailsAdd")]
		public bool ProductAdd([FromBody] OrderDetailsDto entity)
        {
            return this.ProductApplicationService.OrderDetailsAdd(entity);
        }

        /// <summary>
        /// Add the OrderDetails entity async to the database.
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/OrderDetailsAddAsync")]
		public async Task<bool> OrderDetailsAddAsync([FromBody] OrderDetailsDto entity)
        {
            return await this.ProductApplicationService.OrderDetailsAddAsync(entity);
        }

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/OrderDetailsUpdate")]
		public bool OrderDetailsUpdate([FromBody] OrderDetailsDto entity)
        {
            return this.ProductApplicationService.OrderDetailsUpdate(entity);
        }
		
        /// <summary>
        /// Update the OrderDetails entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/OrderDetailsUpdateAsync")]
		public async Task<bool> OrderDetailsUpdateAsync([FromBody] OrderDetailsDto entity)
        {
            return await this.ProductApplicationService.OrderDetailsUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/OrderDetailsDelete")]
		public bool OrderDetailsDelete([FromBody] OrderDetailsDto entity)
        {
            return this.ProductApplicationService.OrderDetailsDelete(entity);
        }

        /// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/OrderDetailsDeleteAsync")]
		public async Task<bool> OrderDetailsDeleteAsync([FromBody] OrderDetailsDto entity)
        {
            return await this.ProductApplicationService.OrderDetailsDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{orderDetailsId}/{cache}")]
        [Route("~/api/Product/OrderDetailsDeleteByorderDetailsId")]
		public bool OrderDetailsDelete( int orderDetailsId, bool cache)
        {
            return this.ProductApplicationService.OrderDetailsDelete( orderDetailsId, cache);
        }

        /// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{orderDetailsId}/{cache}")]
        [Route("~/api/Product/OrderDetailsDeleteByorderDetailsIdAsync")]
		public async Task<bool> OrderDetailsDeleteAsync( int orderDetailsId, bool cache)
        {
            return await this.ProductApplicationService.OrderDetailsDeleteAsync( orderDetailsId, cache);
        }

		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/ProductAdd")]
		public bool ProductAdd([FromBody] ProductDto entity)
        {
            return this.ProductApplicationService.ProductAdd(entity);
        }

        /// <summary>
        /// Add the Product entity async to the database.
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/ProductAddAsync")]
		public async Task<bool> ProductAddAsync([FromBody] ProductDto entity)
        {
            return await this.ProductApplicationService.ProductAddAsync(entity);
        }

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/ProductUpdate")]
		public bool ProductUpdate([FromBody] ProductDto entity)
        {
            return this.ProductApplicationService.ProductUpdate(entity);
        }
		
        /// <summary>
        /// Update the Product entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/ProductUpdateAsync")]
		public async Task<bool> ProductUpdateAsync([FromBody] ProductDto entity)
        {
            return await this.ProductApplicationService.ProductUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/ProductDelete")]
		public bool ProductDelete([FromBody] ProductDto entity)
        {
            return this.ProductApplicationService.ProductDelete(entity);
        }

        /// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/ProductDeleteAsync")]
		public async Task<bool> ProductDeleteAsync([FromBody] ProductDto entity)
        {
            return await this.ProductApplicationService.ProductDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
        [Route("~/api/Product/ProductDeleteByproductId")]
		public bool ProductDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.ProductDelete( productId, cache);
        }

        /// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
        [Route("~/api/Product/ProductDeleteByproductIdAsync")]
		public async Task<bool> ProductDeleteAsync( int productId, bool cache)
        {
            return await this.ProductApplicationService.ProductDeleteAsync( productId, cache);
        }

		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/SoftwareAdd")]
		public bool ProductAdd([FromBody] SoftwareDto entity)
        {
            return this.ProductApplicationService.SoftwareAdd(entity);
        }

        /// <summary>
        /// Add the Software entity async to the database.
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
        [HttpPost("{entity}")]
        [Route("~/api/Product/SoftwareAddAsync")]
		public async Task<bool> SoftwareAddAsync([FromBody] SoftwareDto entity)
        {
            return await this.ProductApplicationService.SoftwareAddAsync(entity);
        }

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/SoftwareUpdate")]
		public bool SoftwareUpdate([FromBody] SoftwareDto entity)
        {
            return this.ProductApplicationService.SoftwareUpdate(entity);
        }
		
        /// <summary>
        /// Update the Software entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
        [HttpPut("{entity}")]
        [Route("~/api/Product/SoftwareUpdateAsync")]
		public async Task<bool> SoftwareUpdateAsync([FromBody] SoftwareDto entity)
        {
            return await this.ProductApplicationService.SoftwareUpdateAsync(entity);
        }

        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/SoftwareDelete")]
		public bool SoftwareDelete([FromBody] SoftwareDto entity)
        {
            return this.ProductApplicationService.SoftwareDelete(entity);
        }

        /// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
        [HttpDelete("{entity}")]
        [Route("~/api/Product/SoftwareDeleteAsync")]
		public async Task<bool> SoftwareDeleteAsync([FromBody] SoftwareDto entity)
        {
            return await this.ProductApplicationService.SoftwareDeleteAsync(entity);
        }

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
        [Route("~/api/Product/SoftwareDeleteByproductId")]
		public bool SoftwareDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.SoftwareDelete( productId, cache);
        }

        /// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
        [HttpDelete("{productId}/{cache}")]
        [Route("~/api/Product/SoftwareDeleteByproductIdAsync")]
		public async Task<bool> SoftwareDeleteAsync( int productId, bool cache)
        {
            return await this.ProductApplicationService.SoftwareDeleteAsync( productId, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankAccountBulkDelete")]
        public void BankAccountBulkDelete([FromBody] IEnumerable<BankAccountDto> items)
		{
			this.ProductApplicationService.BankAccountBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankAccountBulkDeleteAsync")]
        public async Task BankAccountBulkDeleteAsync([FromBody] IEnumerable<BankAccountDto> items)
		{
			await this.ProductApplicationService.BankAccountBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/BankAccountBulkInsert")]
        public void  BankAccountBulkInsert([FromBody] IEnumerable<BankAccountDto> items)
		{
			this.ProductApplicationService.BankAccountBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankAccountBulkInsertAsync")]
        public async Task  BankAccountBulkInsertAsync([FromBody] IEnumerable<BankAccountDto> items)
		{
			await this.ProductApplicationService.BankAccountBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankAccountBulkUpdate")]
        public void BankAccountBulkUpdate([FromBody] IEnumerable<BankAccountDto> items)
		{
			this.ProductApplicationService.BankAccountBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankAccountBulkupdateAsync")]
        public async Task BankAccountBulkUpdateAsync([FromBody] IEnumerable<BankAccountDto> items)
		{
			await this.ProductApplicationService.BankAccountBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankTransfersBulkDelete")]
        public void BankTransfersBulkDelete([FromBody] IEnumerable<BankTransfersDto> items)
		{
			this.ProductApplicationService.BankTransfersBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankTransfersBulkDeleteAsync")]
        public async Task BankTransfersBulkDeleteAsync([FromBody] IEnumerable<BankTransfersDto> items)
		{
			await this.ProductApplicationService.BankTransfersBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/BankTransfersBulkInsert")]
        public void  BankTransfersBulkInsert([FromBody] IEnumerable<BankTransfersDto> items)
		{
			this.ProductApplicationService.BankTransfersBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankTransfersBulkInsertAsync")]
        public async Task  BankTransfersBulkInsertAsync([FromBody] IEnumerable<BankTransfersDto> items)
		{
			await this.ProductApplicationService.BankTransfersBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankTransfersBulkUpdate")]
        public void BankTransfersBulkUpdate([FromBody] IEnumerable<BankTransfersDto> items)
		{
			this.ProductApplicationService.BankTransfersBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BankTransfersBulkupdateAsync")]
        public async Task BankTransfersBulkUpdateAsync([FromBody] IEnumerable<BankTransfersDto> items)
		{
			await this.ProductApplicationService.BankTransfersBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/BookBulkDelete")]
        public void BookBulkDelete([FromBody] IEnumerable<BookDto> items)
		{
			this.ProductApplicationService.BookBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BookBulkDeleteAsync")]
        public async Task BookBulkDeleteAsync([FromBody] IEnumerable<BookDto> items)
		{
			await this.ProductApplicationService.BookBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/BookBulkInsert")]
        public void  BookBulkInsert([FromBody] IEnumerable<BookDto> items)
		{
			this.ProductApplicationService.BookBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BookBulkInsertAsync")]
        public async Task  BookBulkInsertAsync([FromBody] IEnumerable<BookDto> items)
		{
			await this.ProductApplicationService.BookBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/BookBulkUpdate")]
        public void BookBulkUpdate([FromBody] IEnumerable<BookDto> items)
		{
			this.ProductApplicationService.BookBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/BookBulkupdateAsync")]
        public async Task BookBulkUpdateAsync([FromBody] IEnumerable<BookDto> items)
		{
			await this.ProductApplicationService.BookBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/CountryBulkDelete")]
        public void CountryBulkDelete([FromBody] IEnumerable<CountryDto> items)
		{
			this.ProductApplicationService.CountryBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/CountryBulkDeleteAsync")]
        public async Task CountryBulkDeleteAsync([FromBody] IEnumerable<CountryDto> items)
		{
			await this.ProductApplicationService.CountryBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/CountryBulkInsert")]
        public void  CountryBulkInsert([FromBody] IEnumerable<CountryDto> items)
		{
			this.ProductApplicationService.CountryBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/CountryBulkInsertAsync")]
        public async Task  CountryBulkInsertAsync([FromBody] IEnumerable<CountryDto> items)
		{
			await this.ProductApplicationService.CountryBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/CountryBulkUpdate")]
        public void CountryBulkUpdate([FromBody] IEnumerable<CountryDto> items)
		{
			this.ProductApplicationService.CountryBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/CountryBulkupdateAsync")]
        public async Task CountryBulkUpdateAsync([FromBody] IEnumerable<CountryDto> items)
		{
			await this.ProductApplicationService.CountryBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/CustomerBulkDelete")]
        public void CustomerBulkDelete([FromBody] IEnumerable<CustomerDto> items)
		{
			this.ProductApplicationService.CustomerBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/CustomerBulkDeleteAsync")]
        public async Task CustomerBulkDeleteAsync([FromBody] IEnumerable<CustomerDto> items)
		{
			await this.ProductApplicationService.CustomerBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/CustomerBulkInsert")]
        public void  CustomerBulkInsert([FromBody] IEnumerable<CustomerDto> items)
		{
			this.ProductApplicationService.CustomerBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/CustomerBulkInsertAsync")]
        public async Task  CustomerBulkInsertAsync([FromBody] IEnumerable<CustomerDto> items)
		{
			await this.ProductApplicationService.CustomerBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/CustomerBulkUpdate")]
        public void CustomerBulkUpdate([FromBody] IEnumerable<CustomerDto> items)
		{
			this.ProductApplicationService.CustomerBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/CustomerBulkupdateAsync")]
        public async Task CustomerBulkUpdateAsync([FromBody] IEnumerable<CustomerDto> items)
		{
			await this.ProductApplicationService.CustomerBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderBulkDelete")]
        public void OrderBulkDelete([FromBody] IEnumerable<OrderDto> items)
		{
			this.ProductApplicationService.OrderBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderBulkDeleteAsync")]
        public async Task OrderBulkDeleteAsync([FromBody] IEnumerable<OrderDto> items)
		{
			await this.ProductApplicationService.OrderBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderBulkInsert")]
        public void  OrderBulkInsert([FromBody] IEnumerable<OrderDto> items)
		{
			this.ProductApplicationService.OrderBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderBulkInsertAsync")]
        public async Task  OrderBulkInsertAsync([FromBody] IEnumerable<OrderDto> items)
		{
			await this.ProductApplicationService.OrderBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderBulkUpdate")]
        public void OrderBulkUpdate([FromBody] IEnumerable<OrderDto> items)
		{
			this.ProductApplicationService.OrderBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderBulkupdateAsync")]
        public async Task OrderBulkUpdateAsync([FromBody] IEnumerable<OrderDto> items)
		{
			await this.ProductApplicationService.OrderBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderDetailsBulkDelete")]
        public void OrderDetailsBulkDelete([FromBody] IEnumerable<OrderDetailsDto> items)
		{
			this.ProductApplicationService.OrderDetailsBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderDetailsBulkDeleteAsync")]
        public async Task OrderDetailsBulkDeleteAsync([FromBody] IEnumerable<OrderDetailsDto> items)
		{
			await this.ProductApplicationService.OrderDetailsBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderDetailsBulkInsert")]
        public void  OrderDetailsBulkInsert([FromBody] IEnumerable<OrderDetailsDto> items)
		{
			this.ProductApplicationService.OrderDetailsBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderDetailsBulkInsertAsync")]
        public async Task  OrderDetailsBulkInsertAsync([FromBody] IEnumerable<OrderDetailsDto> items)
		{
			await this.ProductApplicationService.OrderDetailsBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderDetailsBulkUpdate")]
        public void OrderDetailsBulkUpdate([FromBody] IEnumerable<OrderDetailsDto> items)
		{
			this.ProductApplicationService.OrderDetailsBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/OrderDetailsBulkupdateAsync")]
        public async Task OrderDetailsBulkUpdateAsync([FromBody] IEnumerable<OrderDetailsDto> items)
		{
			await this.ProductApplicationService.OrderDetailsBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/ProductBulkDelete")]
        public void ProductBulkDelete([FromBody] IEnumerable<ProductDto> items)
		{
			this.ProductApplicationService.ProductBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/ProductBulkDeleteAsync")]
        public async Task ProductBulkDeleteAsync([FromBody] IEnumerable<ProductDto> items)
		{
			await this.ProductApplicationService.ProductBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/ProductBulkInsert")]
        public void  ProductBulkInsert([FromBody] IEnumerable<ProductDto> items)
		{
			this.ProductApplicationService.ProductBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/ProductBulkInsertAsync")]
        public async Task  ProductBulkInsertAsync([FromBody] IEnumerable<ProductDto> items)
		{
			await this.ProductApplicationService.ProductBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/ProductBulkUpdate")]
        public void ProductBulkUpdate([FromBody] IEnumerable<ProductDto> items)
		{
			this.ProductApplicationService.ProductBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/ProductBulkupdateAsync")]
        public async Task ProductBulkUpdateAsync([FromBody] IEnumerable<ProductDto> items)
		{
			await this.ProductApplicationService.ProductBulkUpdateAsync(items);
		}

        
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/SoftwareBulkDelete")]
        public void SoftwareBulkDelete([FromBody] IEnumerable<SoftwareDto> items)
		{
			this.ProductApplicationService.SoftwareBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/SoftwareBulkDeleteAsync")]
        public async Task SoftwareBulkDeleteAsync([FromBody] IEnumerable<SoftwareDto> items)
		{
			await this.ProductApplicationService.SoftwareBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <paramid name="items"></param>
        [HttpPost]
        [HttpPost("{items}")]
        [Route("~/api/Product/SoftwareBulkInsert")]
        public void  SoftwareBulkInsert([FromBody] IEnumerable<SoftwareDto> items)
		{
			this.ProductApplicationService.SoftwareBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/SoftwareBulkInsertAsync")]
        public async Task  SoftwareBulkInsertAsync([FromBody] IEnumerable<SoftwareDto> items)
		{
			await this.ProductApplicationService.SoftwareBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        [HttpPost("{items}")]
        [Route("~/api/Product/SoftwareBulkUpdate")]
        public void SoftwareBulkUpdate([FromBody] IEnumerable<SoftwareDto> items)
		{
			this.ProductApplicationService.SoftwareBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [HttpPost("{items}")]
        [Route("~/api/Product/SoftwareBulkupdateAsync")]
        public async Task SoftwareBulkUpdateAsync([FromBody] IEnumerable<SoftwareDto> items)
		{
			await this.ProductApplicationService.SoftwareBulkUpdateAsync(items);
		}

        #endregion        
    }
}

