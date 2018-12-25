﻿
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

using RepositoryEFDotnet.Data.ApplicationService;
using RepositoryEFDotnet.Data.Interfaces;

namespace RepositoryEFDotnet.Data.Controllers
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
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IProduct</returns>
        [HttpGet("{productId}/{cache}")]
		public IProduct LoadByProductProductId(int productId, bool cache)
        {
            if( this.LoadByProductProductIdIncludes == null)
            {
                this.LoadByProductProductIdIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return this.ProductApplicationService.LoadByProductProductId(productId, cache, this.LoadByProductProductIdIncludes);
        }

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IProduct</returns>
        [HttpGet("{productId}/{cache}")]
		public async Task<IProduct> LoadByProductProductIdAsync(int productId, bool cache)
        {
            if( this.LoadByProductProductIdAsyncIncludes == null)
            {
                this.LoadByProductProductIdAsyncIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return await this.ProductApplicationService.LoadByProductProductIdAsync(productId, cache, this.LoadByProductProductIdAsyncIncludes);
        }

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet("{cache}")]
		public IList<IProduct> ProductLoadAll(bool cache)
        {
            if( this.ProductLoadAllIncludes == null)
            {
                this.ProductLoadAllIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return this.ProductApplicationService.ProductLoadAll(cache, this.ProductLoadAllIncludes);
        }

        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="cache">Enables or disables caching</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet("{cache}")]
		public async Task<IList<IProduct>> ProductLoadAllAsync(bool cache)
        {
            if( this.ProductLoadAllAsyncIncludes == null)
            {
                this.ProductLoadAllAsyncIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return await this.ProductApplicationService.ProductLoadAllAsync(cache, this.ProductLoadAllAsyncIncludes);
        }


        #endregion

        #region Search
        
        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet]
		public IList<IProduct> ProductSearchByProductDescription(string productDescription, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByProductDescriptionIncludes == null)
            {
                this.ProductSearchByProductDescriptionIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return this.ProductApplicationService.ProductSearchByProductDescription(productDescription,caseSensitive, cache, this.ProductSearchByProductDescriptionIncludes);
        }

        /// <summary>
        /// Search for Product Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		[HttpGet]
        public async Task<IList<IProduct>> ProductSearchByProductDescriptionAsync(string productDescription, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByProductDescriptionIncludesAsync == null)
            {
                this.ProductSearchByProductDescriptionIncludesAsync = new Expression<Func<IProduct, object>>[]{};
            }

            return await this.ProductApplicationService.ProductSearchByProductDescriptionAsync(productDescription,caseSensitive, cache, this.ProductSearchByProductDescriptionIncludesAsync);
        }


        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet]
		public IList<IProduct> ProductSearchByUnitAmount(string unitAmount, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByUnitAmountIncludes == null)
            {
                this.ProductSearchByUnitAmountIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return this.ProductApplicationService.ProductSearchByUnitAmount(unitAmount,caseSensitive, cache, this.ProductSearchByUnitAmountIncludes);
        }

        /// <summary>
        /// Search for Product Async entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		[HttpGet]
        public async Task<IList<IProduct>> ProductSearchByUnitAmountAsync(string unitAmount, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByUnitAmountIncludesAsync == null)
            {
                this.ProductSearchByUnitAmountIncludesAsync = new Expression<Func<IProduct, object>>[]{};
            }

            return await this.ProductApplicationService.ProductSearchByUnitAmountAsync(unitAmount,caseSensitive, cache, this.ProductSearchByUnitAmountIncludesAsync);
        }


        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
        [HttpGet]
		public IList<IProduct> ProductSearchByPublisher(string publisher, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByPublisherIncludes == null)
            {
                this.ProductSearchByPublisherIncludes = new Expression<Func<IProduct, object>>[]{};
            }

            return this.ProductApplicationService.ProductSearchByPublisher(publisher,caseSensitive, cache, this.ProductSearchByPublisherIncludes);
        }

        /// <summary>
        /// Search for Product Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		[HttpGet]
        public async Task<IList<IProduct>> ProductSearchByPublisherAsync(string publisher, bool caseSensitive, bool cache)
        {
            if( this.ProductSearchByPublisherIncludesAsync == null)
            {
                this.ProductSearchByPublisherIncludesAsync = new Expression<Func<IProduct, object>>[]{};
            }

            return await this.ProductApplicationService.ProductSearchByPublisherAsync(publisher,caseSensitive, cache, this.ProductSearchByPublisherIncludesAsync);
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductAdd(IProduct entity)
        {
            return this.ProductApplicationService.ProductUpdate(entity);
        }

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductUpdate(IProduct entity)
        {
            return this.ProductApplicationService.ProductUpdate(entity);
        }
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductDelete(IProduct entity)
        {
            return this.ProductApplicationService.ProductDelete(entity);
        }

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool ProductDelete( int productId, bool cache)
        {
            return this.ProductApplicationService.ProductDelete( productId, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void ProductBulkDelete(IEnumerable<IProduct> items)
		{
			this.ProductApplicationService.ProductBulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ProductBulkDeleteAsync(IEnumerable<IProduct> items)
		{
			await this.ProductApplicationService.ProductBulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  ProductBulkInsert(IEnumerable<IProduct> items)
		{
			this.ProductApplicationService.ProductBulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ProductBulkInsertAsync(IEnumerable<IProduct> items)
		{
			await this.ProductApplicationService.ProductBulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void ProductBulkUpdate(IEnumerable<IProduct> items)
		{
			this.ProductApplicationService.ProductBulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ProductBulkUpdateAsync(IEnumerable<IProduct> items)
		{
			await this.ProductApplicationService.ProductBulkUpdateAsync(items);
		}

        #endregion        
    }
}
