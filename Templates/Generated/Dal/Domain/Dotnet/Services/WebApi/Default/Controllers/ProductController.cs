
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
	public partial class ProductController 
	{

        /// <summary>
        /// Configure Includes
        /// </summary>
	    public void ConfigureIncludes()
	    {
	        //this.LoadByProductProductIdAsyncIncludes = new Expression<Func<IProduct, object>>[]
	        //{
	        //    a => a.OrderDetails
	        //};
	    }

        #region Configure Load

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

        #endregion

        #region Configure Search
        
        /// <summary>
        /// Gets ProductSearchByProductDescriptionIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByProductDescriptionIncludes { get; set; }

        /// <summary>
        /// Gets ProductSearchByProductDescriptionIncludesAsync
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByProductDescriptionIncludesAsync { get; set; }


        /// <summary>
        /// Gets ProductSearchByUnitAmountIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByUnitAmountIncludes { get; set; }

        /// <summary>
        /// Gets ProductSearchByUnitAmountIncludesAsync
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByUnitAmountIncludesAsync { get; set; }


        /// <summary>
        /// Gets ProductSearchByPublisherIncludes
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByPublisherIncludes { get; set; }

        /// <summary>
        /// Gets ProductSearchByPublisherIncludesAsync
        /// </summary
        public Expression<Func<IProduct, object>>[] ProductSearchByPublisherIncludesAsync { get; set; }

		#endregion
    }
}

