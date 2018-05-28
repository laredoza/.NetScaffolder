
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
using RepositoryEFDotnet.Core.Base;
using System.Linq;
using System.Collections.Generic;

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
        public void RunAll()
        {
			BankAccount_Add();
			//BankAccount_LoadAll();
			//BankAccount_Search();
			//BankAccount_Update();
			//BankAccount_Delete();
			CompositeKeyTest_Add();
			//CompositeKeyTest_LoadAll();
			//CompositeKeyTest_Search();
			//CompositeKeyTest_Update();
			//CompositeKeyTest_Delete();
			BankTransfers_Add();
			//BankTransfers_LoadAll();
			//BankTransfers_Search();
			//BankTransfers_Update();
			//BankTransfers_Delete();
			Book_Add();
			//Book_LoadAll();
			//Book_Search();
			//Book_Update();
			//Book_Delete();
			Country_Add();
			//Country_LoadAll();
			//Country_Search();
			//Country_Update();
			//Country_Delete();
			Customer_Add();
			//Customer_LoadAll();
			//Customer_Search();
			//Customer_Update();
			//Customer_Delete();
			Order_Add();
			//Order_LoadAll();
			//Order_Search();
			//Order_Update();
			//Order_Delete();
			OrderDetails_Add();
			//OrderDetails_LoadAll();
			//OrderDetails_Search();
			//OrderDetails_Update();
			//OrderDetails_Delete();
			Product_Add();
			//Product_LoadAll();
			//Product_Search();
			//Product_Update();
			//Product_Delete();
			Software_Add();
			//Software_LoadAll();
			//Software_Search();
			//Software_Update();
			//Software_Delete();
        }
		

        public void BankAccount_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankAccountRepository(Context);
            BaseRepositoryUnitTest_BankAccount_AddRange(repo, count, startSeed, expected);
        }

        public void CompositeKeyTest_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CompositeKeyTestRepository(Context);
            BaseRepositoryUnitTest_CompositeKeyTest_AddRange(repo, count, startSeed, expected);
        }

        public void BankTransfers_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankTransfersRepository(Context);
            BaseRepositoryUnitTest_BankTransfers_AddRange(repo, count, startSeed, expected);
        }

        public void Book_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BookRepository(Context);
            BaseRepositoryUnitTest_Book_AddRange(repo, count, startSeed, expected);
        }

        public void Country_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_AddRange(repo, count, startSeed, expected);
        }

        public void Customer_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_AddRange(repo, count, startSeed, expected);
        }

        public void Order_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderRepository(Context);
            BaseRepositoryUnitTest_Order_AddRange(repo, count, startSeed, expected);
        }

        public void OrderDetails_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderDetailsRepository(Context);
            BaseRepositoryUnitTest_OrderDetails_AddRange(repo, count, startSeed, expected);
        }

        public void Product_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new ProductRepository(Context);
            BaseRepositoryUnitTest_Product_AddRange(repo, count, startSeed, expected);
        }

        public void Software_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new SoftwareRepository(Context);
            BaseRepositoryUnitTest_Software_AddRange(repo, count, startSeed, expected);
        }

		#endregion
		
		#region Base Tests

        protected virtual void BaseRepositoryUnitTest_BankAccount_AddRange(IBankAccountRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<IBankAccount>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new BankAccountDto();
                PopulateBankAccount(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankAccount found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_BankAccount(list.FirstOrDefault(o => o.BankAccountId == id),items.FirstOrDefault(o => o.BankAccountId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_CompositeKeyTest_AddRange(ICompositeKeyTestRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<ICompositeKeyTest>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new CompositeKeyTestDto();
                PopulateCompositeKeyTest(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of CompositeKeyTest found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_CompositeKeyTest(list.FirstOrDefault(o => o.PrimaryCol1 == id),items.FirstOrDefault(o => o.PrimaryCol1 == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_BankTransfers_AddRange(IBankTransfersRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<IBankTransfers>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new BankTransfersDto();
                PopulateBankTransfers(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankTransfers found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_BankTransfers(list.FirstOrDefault(o => o.BankTransferId == id),items.FirstOrDefault(o => o.BankTransferId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_Book_AddRange(IBookRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<IBook>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new BookDto();
                PopulateBook(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Book found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_Book(list.FirstOrDefault(o => o.ProductId == id),items.FirstOrDefault(o => o.ProductId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_Country_AddRange(ICountryRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<ICountry>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new CountryDto();
                PopulateCountry(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Country found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_Country(list.FirstOrDefault(o => o.CountryId == id),items.FirstOrDefault(o => o.CountryId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_Customer_AddRange(ICustomerRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<ICustomer>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new CustomerDto();
                PopulateCustomer(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Customer found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_Customer(list.FirstOrDefault(o => o.CustomerId == id),items.FirstOrDefault(o => o.CustomerId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_Order_AddRange(IOrderRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<IOrder>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new OrderDto();
                PopulateOrder(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Order found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_Order(list.FirstOrDefault(o => o.OrderId == id),items.FirstOrDefault(o => o.OrderId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_OrderDetails_AddRange(IOrderDetailsRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<IOrderDetails>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new OrderDetailsDto();
                PopulateOrderDetails(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of OrderDetails found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_OrderDetails(list.FirstOrDefault(o => o.OrderDetailsId == id),items.FirstOrDefault(o => o.OrderDetailsId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_Product_AddRange(IProductRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<IProduct>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new ProductDto();
                PopulateProduct(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Product found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_Product(list.FirstOrDefault(o => o.ProductId == id),items.FirstOrDefault(o => o.ProductId == id));
			}
        }

        protected virtual void BaseRepositoryUnitTest_Software_AddRange(ISoftwareRepository repository, int count = 1, int startSeed = 1, int expected = 1)
        {		
            var list = new List<ISoftware>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var dto = new SoftwareDto();
                PopulateSoftware(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            Context.Commit();

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Software found");

            for (var index = 1; index <= count; index++)
			{
				int id = index + startSeed - 1;
                this.Check_Software(list.FirstOrDefault(o => o.ProductId == id),items.FirstOrDefault(o => o.ProductId == id));
			}
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
