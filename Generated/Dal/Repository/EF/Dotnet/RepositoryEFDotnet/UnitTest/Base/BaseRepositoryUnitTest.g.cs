
// <copyright file="BaseRepositoryUnitTest.g.cs.g.cs" company="MIT">
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

using Banking.Models.Dto;
using Banking.Models.Interfaces;
using Banking.Models.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System.Linq;

namespace RepositoryEFDotnet.UnitTest
{
	[TestClass]
	public abstract partial class BaseRepositoryUnitTest : BaseUnitTest
	{
        #region Privates

        protected static IUnitOfWork Context = null;

        #endregion

        #region Tests
		

		[TestMethod]
        public void BankAccount_Add()
        {
            var repo = new BankAccountRepository(Context);
            BaseRepositoryUnitTest_BankAccount_Add(repo);
        }

		[TestMethod]
        public void BankTransfers_Add()
        {
            var repo = new BankTransfersRepository(Context);
            BaseRepositoryUnitTest_BankTransfers_Add(repo);
        }

		[TestMethod]
        public void Book_Add()
        {
            var repo = new BookRepository(Context);
            BaseRepositoryUnitTest_Book_Add(repo);
        }

		[TestMethod]
        public void Country_Add()
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_Add(repo);
        }

		[TestMethod]
        public void Customer_Add()
        {
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_Add(repo);
        }

		[TestMethod]
        public void Order_Add()
        {
            var repo = new OrderRepository(Context);
            BaseRepositoryUnitTest_Order_Add(repo);
        }

		[TestMethod]
        public void OrderDetails_Add()
        {
            var repo = new OrderDetailsRepository(Context);
            BaseRepositoryUnitTest_OrderDetails_Add(repo);
        }

		[TestMethod]
        public void Product_Add()
        {
            var repo = new ProductRepository(Context);
            BaseRepositoryUnitTest_Product_Add(repo);
        }

		[TestMethod]
        public void Software_Add()
        {
            var repo = new SoftwareRepository(Context);
            BaseRepositoryUnitTest_Software_Add(repo);
        }

		#endregion
		
		#region Base Tests

        public virtual void BaseRepositoryUnitTest_BankAccount_Add(IBankAccountRepository repository)
        {
            var dto = new BankAccountDto();
            PopulateBankAccount(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "BankAccount");
            Check_BankAccount(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_BankTransfers_Add(IBankTransfersRepository repository)
        {
            var dto = new BankTransfersDto();
            PopulateBankTransfers(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "BankTransfers");
            Check_BankTransfers(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_Book_Add(IBookRepository repository)
        {
            var dto = new BookDto();
            PopulateBook(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Book");
            Check_Book(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_Country_Add(ICountryRepository repository)
        {
            var dto = new CountryDto();
            PopulateCountry(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Country");
            Check_Country(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_Customer_Add(ICustomerRepository repository)
        {
            var dto = new CustomerDto();
            PopulateCustomer(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Customer");
            Check_Customer(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_Order_Add(IOrderRepository repository)
        {
            var dto = new OrderDto();
            PopulateOrder(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Order");
            Check_Order(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_OrderDetails_Add(IOrderDetailsRepository repository)
        {
            var dto = new OrderDetailsDto();
            PopulateOrderDetails(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "OrderDetails");
            Check_OrderDetails(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_Product_Add(IProductRepository repository)
        {
            var dto = new ProductDto();
            PopulateProduct(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Product");
            Check_Product(dto, result.FirstOrDefault());
        }

        public virtual void BaseRepositoryUnitTest_Software_Add(ISoftwareRepository repository)
        {
            var dto = new SoftwareDto();
            PopulateSoftware(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Software");
            Check_Software(dto, result.FirstOrDefault());
        }

		#endregion
		
        #region Cleanup

        [ClassCleanup]
        public virtual void ClassCleanup()
        {
            Context?.Dispose();
        }

        #endregion
	}
}
