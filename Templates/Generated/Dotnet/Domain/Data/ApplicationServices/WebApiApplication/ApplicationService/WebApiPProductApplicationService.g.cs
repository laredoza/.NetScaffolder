
//// <copyright file=".g.cs" company="MIT">
////  Copyright (c) 2019 MIT
//// </copyright>  

//// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
//// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
//// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
//// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
//// IN THE SOFTWARE.


//// *******************************************************************
////	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
////	USE A PARTIAL CLASS INSTEAD
//// *******************************************************************

//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Threading.Tasks;
//using DotNetScaffolder.Domain.Core.Interfaces;
//using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
//using DotNetScaffolder.Domain.Data.ApplicationService;
//using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
//using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;

//namespace DotNetScaffolder.Domain.Services.WebApi.Default.Controllers
//{
//    /// <summary>
//	/// The WebApiProduct ApplicationService 
//	/// </summary>
//	public partial class WebApiProductApplicationService 
//	{
//        public IWebApiSettings ApiSettings { get; set; }

//        public WebApiProductApplicationService (IWebApiSettings apiSettings) 
//        {
//            this.apiSettings = this.ApiSettings;
//        }

//        #region Load

//        /// <summary>
//        /// Load BankAccount entities from the database using the primary key
//        /// </summary
//        /// <param name="bankAccountId">int</param>
//        /// <param name="cache">Enables or disables caching</param>
//        /// <returns>BankAccountDto</returns>
//		public BankAccountDto LoadByBankAccountBankAccountId(int bankAccountId, bool cache)
//        {
//            if( this.LoadByBankAccountBankAccountIdIncludes == null)
//            {
//                this.LoadByBankAccountBankAccountIdIncludes = new Expression<Func<IBankAccount, object>>[]{};
//            }

//            var result = this.ProductApplicationService.LoadByBankAccountBankAccountId(bankAccountId, cache, this.LoadByBankAccountBankAccountIdIncludes);

//            if (result == null)
//            {
//                return NotFound();
//            }

//            return Ok(result);

//            CustomerDto result;

//            var apiUrl = $"{this.apiSettings.BasePath}/product/LoadByCustomerCustomerId/{customerId}/{cache}";

//            var client = new HttpClient();
//            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
//            var response = client.GetAsync(apiUrl).Result;

//            if (response.IsSuccessStatusCode)
//            {
//                var json = response.Content.ReadAsStringAsync().Result;
//                result = JsonConvert.DeserializeObject<CustomerDto>(json);
//            }
//            else
//            {
//                throw new Exception($"An error happened{response.StatusCode}");
//            }

//            return result;
//        }

//        /// <summary>
//        /// Load BankAccount Async entities from the database using the primary key
//        /// </summary
//        /// <param name="bankAccountId">int</param>
//        /// <param name="cache">Enables or disables caching</param>
//        /// <returns>BankAccountDto</returns>
//        [HttpGet("{bankAccountId}/{cache}")]
//        [Route("~/api/Product/LoadByBankAccountBankAccountIdAsync")]
//		public async Task<ActionResult<BankAccountDto>> LoadByBankAccountBankAccountIdAsync(int bankAccountId, bool cache)
//        {
//            if( this.LoadByBankAccountBankAccountIdAsyncIncludes == null)
//            {
//                this.LoadByBankAccountBankAccountIdAsyncIncludes = new Expression<Func<IBankAccount, object>>[]{};
//            }

//           var result = await this.ProductApplicationService.LoadByBankAccountBankAccountIdAsync(bankAccountId, cache, this.LoadByBankAccountBankAccountIdAsyncIncludes);
            
//            if (result == null)
//            {
//                return NotFound(result);
//            }

//            return Ok(result);
//        }

//        /// <summary>
//        /// Load all BankAccount entities from the database.
//        /// </summary>
//        /// <param name="cache">Enables or disables caching</param>
//        /// <returns>IList<BankAccountDto></returns>
//        [HttpGet("{cache}")]
//        [Route("~/api/Product/BankAccountLoadAll")]
//		public ActionResult<IList<BankAccountDto>> BankAccountLoadAll(bool cache)
//        {
//            if( this.BankAccountLoadAllIncludes == null)
//            {
//                this.BankAccountLoadAllIncludes = new Expression<Func<IBankAccount, object>>[]{};
//            }

//            var result = this.ProductApplicationService.BankAccountLoadAll(cache, this.BankAccountLoadAllIncludes);
            
//            if (result == null)
//            {
//                return NotFound(result);
//            }

//            return Ok(result);
//        }

//        /// <summary>
//        /// Load all BankAccount Async entities from the database.
//        /// </summary>
//        /// <param name="cache">Enables or disables caching</param>
//        /// <returns>IList<BankAccountDto></returns>
//        [HttpGet("{cache}")]
//        [Route("~/api/Product/BankAccountLoadAllAsync")]
//		public async Task<ActionResult<IList<BankAccountDto>>> BankAccountLoadAllAsync(bool cache)
//        {
//            if( this.BankAccountLoadAllAsyncIncludes == null)
//            {
//                this.BankAccountLoadAllAsyncIncludes = new Expression<Func<IBankAccount, object>>[]{};
//            }

//            var result = await this.ProductApplicationService.BankAccountLoadAllAsync(cache, this.BankAccountLoadAllAsyncIncludes);
            
//            if (result == null)
//            {
//                return NotFound(result);
//            }

//            return Ok(result);
//        }


//        #endregion

//        #region Search
                
//        /// <summary>
//        /// Search for BankAccount entities in the database by BankAccountNumber
//        /// </summary>
//        /// <param name="bankAccountNumber">string</param>
//		/// <param name="caseSensitive">bool</param>
//        /// <returns>IList<BankAccountDto></returns>
//        [HttpGet("{BankAccountNumber}/{caseSensitive}/{cache}")]
//        [Route("~/api/Product/BankAccountSearchByBankAccountNumber")]
//		public ActionResult<IList<BankAccountDto>> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive, bool cache)
//        {
//            if( this.BankAccountSearchByBankAccountNumberIncludes == null)
//            {
//                this.BankAccountSearchByBankAccountNumberIncludes = new Expression<Func<IBankAccount, object>>[]{};
//            }

//            var result = this.ProductApplicationService.BankAccountSearchByBankAccountNumber(bankAccountNumber,caseSensitive, cache, this.BankAccountSearchByBankAccountNumberIncludes);
            
//            if (result == null)
//            {
//                return NotFound(result);
//            }

//            return Ok(result);
//        }

//        /// <summary>
//        /// Search for BankAccount Async entities in the database by BankAccountNumber
//        /// </summary>
//        /// <param name="bankAccountNumber">string</param>
//		/// <param name="caseSensitive">bool</param>
//        /// <returns>IList<BankAccountDto></returns>
//        [HttpGet("{BankAccountNumber}/{caseSensitive}/{cache}")]
//        [Route("~/api/Product/BankAccountSearchByBankAccountNumberAsync")]
//        public async Task<ActionResult<IList<BankAccountDto>>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber, bool caseSensitive, bool cache)
//        {
//            if( this.BankAccountSearchByBankAccountNumberIncludesAsync == null)
//            {
//                this.BankAccountSearchByBankAccountNumberIncludesAsync = new Expression<Func<IBankAccount, object>>[]{};
//            }

//            var result = await this.ProductApplicationService.BankAccountSearchByBankAccountNumberAsync(bankAccountNumber,caseSensitive, cache, this.BankAccountSearchByBankAccountNumberIncludesAsync);
            
//            if (result == null)
//            {
//                return NotFound(result);
//            }

//            return Ok(result);
//        }

//		#endregion

//		#region Modifiers
		
//        /// <summary>
//        /// Add the BankAccount entity to the database.
//        /// </summary>
//        /// <param name="entity">BankAccountDto</param>
//        /// <returns>bool</returns>
//        [HttpPost("{entity}")]
//        [Route("~/api/Product/BankAccountAdd")]
//		public bool ProductAdd([FromBody] BankAccountDto entity)
//        {
//            return this.ProductApplicationService.BankAccountAdd(entity);
//        }

//        /// <summary>
//        /// Add the BankAccount entity async to the database.
//        /// </summary>
//        /// <param name="entity">BankAccountDto</param>
//        /// <returns>bool</returns>
//        [HttpPost("{entity}")]
//        [Route("~/api/Product/BankAccountAddAsync")]
//		public async Task<bool> BankAccountAddAsync([FromBody] BankAccountDto entity)
//        {
//            return await this.ProductApplicationService.BankAccountAddAsync(entity);
//        }

//        /// <summary>
//        /// Update the BankAccount entity in the database if any values have changed
//        /// </summary>
//        /// <param name="entity">BankAccountDto</param>
//        /// <returns>bool</returns>
//        [HttpPut("{entity}")]
//        [Route("~/api/Product/BankAccountUpdate")]
//		public bool BankAccountUpdate([FromBody] BankAccountDto entity)
//        {
//            return this.ProductApplicationService.BankAccountUpdate(entity);
//        }
		
//        /// <summary>
//        /// Update the BankAccount entity async in the database if any values have changed
//        /// </summary>
//        /// <param name="entity">BankAccountDto</param>
//        /// <returns>bool</returns>
//        [HttpPut("{entity}")]
//        [Route("~/api/Product/BankAccountUpdateAsync")]
//		public async Task<bool> BankAccountUpdateAsync([FromBody] BankAccountDto entity)
//        {
//            return await this.ProductApplicationService.BankAccountUpdateAsync(entity);
//        }

//        /// <summary>
//        /// Delete the BankAccount entity from the database
//        /// </summary>
//        /// <param name="entity">BankAccountDto</param>
//        /// <returns>bool</returns>
//        [HttpDelete("{entity}")]
//        [Route("~/api/Product/BankAccountDelete")]
//		public bool BankAccountDelete([FromBody] BankAccountDto entity)
//        {
//            return this.ProductApplicationService.BankAccountDelete(entity);
//        }

//        /// <summary>
//        /// Delete the BankAccount entity async from the database
//        /// </summary>
//        /// <param name="entity">BankAccountDto</param>
//        /// <returns>bool</returns>
//        [HttpDelete("{entity}")]
//        [Route("~/api/Product/BankAccountDeleteAsync")]
//		public async Task<bool> BankAccountDeleteAsync([FromBody] BankAccountDto entity)
//        {
//            return await this.ProductApplicationService.BankAccountDeleteAsync(entity);
//        }

//		/// <summary>
//        /// Delete the BankAccount entity from the database
//        /// </summary>
//        /// <param name="bankAccountId">int</param>
//        /// <returns>bool</returns>
//        [HttpDelete("{bankAccountId}/{cache}")]
//        [Route("~/api/Product/BankAccountDeleteBybankAccountId")]
//		public bool BankAccountDeleteBybankAccountId( int bankAccountId, bool cache)
//        {
//            return this.ProductApplicationService.BankAccountDelete( bankAccountId, cache);
//        }

//        /// <summary>
//        /// Delete the BankAccount entity async from the database
//        /// </summary>
//        /// <param name="bankAccountId">int</param>
//        /// <returns>bool</returns>
//        [HttpDelete("{bankAccountId}/{cache}")]
//        [Route("~/api/Product/BankAccountDeleteBybankAccountIdAsync")]
//		public async Task<bool> BankAccountDeleteBybankAccountIdAsync( int bankAccountId, bool cache)
//        {
//            return await this.ProductApplicationService.BankAccountDeleteAsync( bankAccountId, cache);
//        }

//		#endregion

//		#region Bulk

//        /// <summary>
//        ///     Bulk delete entities
//        /// </summary>
//        /// <param name="items"></param>
//        [HttpPost("{items}")]
//        [Route("~/api/Product/BankAccountBulkDelete")]
//        public void BankAccountBulkDelete([FromBody] IEnumerable<BankAccountDto> items)
//		{
//			this.ProductApplicationService.BankAccountBulkDelete(items);
//		}

//        /// <summary>
//        ///     Bulk delete entities async
//        /// </summary>
//        /// <param name="items"></param>
//        /// <returns></returns>
//        [HttpPost("{items}")]
//        [Route("~/api/Product/BankAccountBulkDeleteAsync")]
//        public async Task BankAccountBulkDeleteAsync([FromBody] IEnumerable<BankAccountDto> items)
//		{
//			await this.ProductApplicationService.BankAccountBulkDeleteAsync(items);
//		}

//        /// <summary>
//        ///     Bulk insert entities
//        /// </summary>
//        /// <paramid name="items"></param>
//        [HttpPost]
//        [HttpPost("{items}")]
//        [Route("~/api/Product/BankAccountBulkInsert")]
//        public void  BankAccountBulkInsert([FromBody] IEnumerable<BankAccountDto> items)
//		{
//			this.ProductApplicationService.BankAccountBulkInsert(items);
//		}
        
//        /// <summary>
//        /// Bulk insert entities async
//        /// </summary>
//        /// <param name="items"></param>
//        /// <returns></returns>
//        [HttpPost("{items}")]
//        [Route("~/api/Product/BankAccountBulkInsertAsync")]
//        public async Task  BankAccountBulkInsertAsync([FromBody] IEnumerable<BankAccountDto> items)
//		{
//			await this.ProductApplicationService.BankAccountBulkInsertAsync(items);
//		}

//        /// <summary>
//        /// Bulk update entities 
//        /// </summary>
//        /// <param name="items"></param>
//        [HttpPost("{items}")]
//        [Route("~/api/Product/BankAccountBulkUpdate")]
//        public void BankAccountBulkUpdate([FromBody] IEnumerable<BankAccountDto> items)
//		{
//			this.ProductApplicationService.BankAccountBulkUpdate(items);
//		}

//        /// <summary>
//        /// Bulk update entities async
//        /// </summary>
//        /// <param name="items"></param>
//        /// <returns></returns>
//        [HttpPost("{items}")]
//        [Route("~/api/Product/BankAccountBulkupdateAsync")]
//        public async Task BankAccountBulkUpdateAsync([FromBody] IEnumerable<BankAccountDto> items)
//		{
//			await this.ProductApplicationService.BankAccountBulkUpdateAsync(items);
//		}

//        #endregion        
//    }
//}

