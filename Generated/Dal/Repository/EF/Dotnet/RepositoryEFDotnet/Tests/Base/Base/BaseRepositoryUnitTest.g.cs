
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

namespace RepositoryEFDotnet.UnitTest.Base
{
	[TestClass]
	public abstract partial class BaseRepositoryUnitTest : BaseUnitTest
	{
		#region Public
		
		protected bool UseTransactions { get; set; } = true;
		
		#endregion
		
        #region Tests
		

        public void BankAccount_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankAccountRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_BankAccount_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankAccount_CheckData(repo, list, expected);
        }

        public void BankTransfers_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankTransfersRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_BankTransfers_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(repo, list, expected);
        }

        public void Book_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BookRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Book_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Book_CheckData(repo, list, expected);
        }

        public void Country_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CountryRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Country_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Country_CheckData(repo, list, expected);
        }

        public void Customer_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CustomerRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Customer_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Customer_CheckData(repo, list, expected);
        }

        public void Order_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Order_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Order_CheckData(repo, list, expected);
        }

        public void OrderDetails_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderDetailsRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_OrderDetails_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(repo, list, expected);
        }

        public void Product_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new ProductRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Product_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Product_CheckData(repo, list, expected);
        }

        public void Software_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new SoftwareRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Software_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Software_CheckData(repo, list, expected);
        }

		#endregion
		
		#region Base Tests
        protected virtual List<IBankAccount> BaseRepositoryUnitTest_BankAccount_AddRange(IBankAccountRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_BankAccount_CheckData(IBankAccountRepository repository, List<IBankAccount> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankAccount found");

			foreach (var item in list)
			{
				this.Check_BankAccount(item, items.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
		}
        protected virtual List<IBankTransfers> BaseRepositoryUnitTest_BankTransfers_AddRange(IBankTransfersRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_BankTransfers_CheckData(IBankTransfersRepository repository, List<IBankTransfers> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankTransfers found");

			foreach (var item in list)
			{
				this.Check_BankTransfers(item, items.FirstOrDefault(o => o.BankTransferId == item.BankTransferId));
			}
		}
        protected virtual List<IBook> BaseRepositoryUnitTest_Book_AddRange(IBookRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_Book_CheckData(IBookRepository repository, List<IBook> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Book found");

			foreach (var item in list)
			{
				this.Check_Book(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
        protected virtual List<ICountry> BaseRepositoryUnitTest_Country_AddRange(ICountryRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_Country_CheckData(ICountryRepository repository, List<ICountry> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Country found");

			foreach (var item in list)
			{
				this.Check_Country(item, items.FirstOrDefault(o => o.CountryId == item.CountryId));
			}
		}
        protected virtual List<ICustomer> BaseRepositoryUnitTest_Customer_AddRange(ICustomerRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_Customer_CheckData(ICustomerRepository repository, List<ICustomer> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, items.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
		}
        protected virtual List<IOrder> BaseRepositoryUnitTest_Order_AddRange(IOrderRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_Order_CheckData(IOrderRepository repository, List<IOrder> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, items.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
		}
        protected virtual List<IOrderDetails> BaseRepositoryUnitTest_OrderDetails_AddRange(IOrderDetailsRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_OrderDetails_CheckData(IOrderDetailsRepository repository, List<IOrderDetails> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of OrderDetails found");

			foreach (var item in list)
			{
				this.Check_OrderDetails(item, items.FirstOrDefault(o => o.OrderDetailsId == item.OrderDetailsId));
			}
		}
        protected virtual List<IProduct> BaseRepositoryUnitTest_Product_AddRange(IProductRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_Product_CheckData(IProductRepository repository, List<IProduct> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
        protected virtual List<ISoftware> BaseRepositoryUnitTest_Software_AddRange(ISoftwareRepository repository, int count = 1, int startSeed = 1)
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
			
			return list;
        }
		
		protected virtual void BaseRepositoryUnitTest_Software_CheckData(ISoftwareRepository repository, List<ISoftware> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Software found");

			foreach (var item in list)
			{
				this.Check_Software(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}

		#endregion
	}
}
