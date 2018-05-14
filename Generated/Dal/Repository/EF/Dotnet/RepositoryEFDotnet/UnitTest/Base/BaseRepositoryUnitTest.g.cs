
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

        protected IUnitOfWork Context = null;

        #endregion

        #region SetupDb

        public abstract void SetupDb();

        #endregion

        #region Tests
		

        public void BankAccount_Add()
        {
            var repo = new BankAccountRepository(Context);
            BaseRepositoryUnitTest_Add_BankAccount(repo);
        }

        public void BankTransfers_Add()
        {
            var repo = new BankTransfersRepository(Context);
            BaseRepositoryUnitTest_Add_BankTransfers(repo);
        }

        public void Book_Add()
        {
            var repo = new BookRepository(Context);
            BaseRepositoryUnitTest_Add_Book(repo);
        }

        public void Country_Add()
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Add_Country(repo);
        }

        public void Customer_Add()
        {
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Add_Customer(repo);
        }

        public void Order_Add()
        {
            var repo = new OrderRepository(Context);
            BaseRepositoryUnitTest_Add_Order(repo);
        }

        public void OrderDetails_Add()
        {
            var repo = new OrderDetailsRepository(Context);
            BaseRepositoryUnitTest_Add_OrderDetails(repo);
        }

        public void Product_Add()
        {
            var repo = new ProductRepository(Context);
            BaseRepositoryUnitTest_Add_Product(repo);
        }

        public void Software_Add()
        {
            var repo = new SoftwareRepository(Context);
            BaseRepositoryUnitTest_Add_Software(repo);
        }

		#endregion
		
		#region Base Tests

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_BankAccount(IBankAccountRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_BankTransfers(IBankTransfersRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_Book(IBookRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_Country(ICountryRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_Customer(ICustomerRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_Order(IOrderRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_OrderDetails(IOrderDetailsRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_Product(IProductRepository repository)
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

        [TestMethod]
        public virtual void BaseRepositoryUnitTest_Add_Software(ISoftwareRepository repository)
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

        [TestCleanup]
        public virtual void DisposeDb()
        {
            Context?.Dispose();
        }

        #endregion
	}
}
