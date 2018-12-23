
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
    [Route("api/[controller]")]
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
            this.ProductApplicationService = productApplicationService;
        }

        #region Load

        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IProduct</returns>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
		public IProduct LoadByProductProductId(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.LoadByProductId(productId, cache, includes);
        }

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IProduct</returns>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
		public async Task<IProduct> LoadByProductProductIdAsync(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return await this.ProductRepository.LoadByProductIdAsync(productId, cache, includes);
        }

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductLoadAll(bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.LoadAll(cache, includes);
        }

        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public Task<IList<IProduct>> ProductLoadAllAsync(bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.LoadAllAsync(cache, includes);
        }


        #endregion
    }
}

