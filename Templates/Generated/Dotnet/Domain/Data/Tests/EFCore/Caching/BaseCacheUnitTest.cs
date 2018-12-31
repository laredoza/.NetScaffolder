using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Data.Entity;
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Data.Repository;

namespace DotNetScaffolder.Repository.UnitTests.EFCore.SqlServer
{
    [TestClass]
    public class BaseCacheUnitTest
    {
        protected static IServiceProvider Provider { get; set; }
        public IUnitOfWork UnitOfWork { get; set; }

        public void ProductTest()
        {
            IProductRepository productRepository = new ProductRepository(this.UnitOfWork);
            List<IProduct> products = productRepository.LoadAll(false).ToList();
            foreach (var product in products)
            {
                productRepository.Delete(product);
            }

            productRepository.Add(new Product
            {
                ProductDescription = "My Product", UnitPrice = 100, UnitAmount = "1", Publisher = "Publisher 1",
                AmountInStock = 10
            });

            products = productRepository.LoadAll(false).ToList();
            //products = productRepository.LoadAll(true).ToList();
            products[0].ProductDescription = "Updated Product";
            productRepository.Update(products[0]);
            products = productRepository.LoadAll(true).ToList();

        }
    }
}
