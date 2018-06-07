
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
        #region Privates

        protected static IUnitOfWork Context = null;

        #endregion

		#region Public
		
		protected bool UseTransactions { get; set; } = true;
		
		#endregion
		
        #region Tests

        [TestMethod]
        public void RunAll()
        {
			// Rollback Tests
			Country_Rollback();
			Customer_Rollback();
			Product_Rollback();
			BankAccount_Rollback();

			// Add tests
			Country_Add();
			Customer_Add(1,2,1);
			Product_Add(5, 2, 5);
			Book_Add(1, 2, 1);
			Software_Add(1, 3, 1);
			Order_Add(2, 1, 2);
			OrderDetails_Add(2, 1, 2);
			BankAccount_Add(2, 2, 2);
			BankTransfers_Add(1, 2, 1);
			
			// Dependent rollback tests
			Book_Rollback(1, 4, 1);
			Software_Rollback(1, 5, 1);
			Order_Rollback(1, 3, 2);
			OrderDetails_Rollback(1, 2, 2);
			BankTransfers_Rollback(1, 2, 1);
			

			//BankAccount_LoadAll();
			//BankAccount_Search();
			//BankAccount_Update();
			//BankAccount_Delete();

			//BankTransfers_LoadAll();
			//BankTransfers_Search();
			//BankTransfers_Update();
			//BankTransfers_Delete();

			//Book_LoadAll();
			//Book_Search();
			//Book_Update();
			//Book_Delete();

			//Country_LoadAll();
			//Country_Search();
			//Country_Update();
			//Country_Delete();

			//Customer_LoadAll();
			//Customer_Search();
			//Customer_Update();
			//Customer_Delete();

			//Order_LoadAll();
			//Order_Search();
			//Order_Update();
			//Order_Delete();

			//OrderDetails_LoadAll();
			//OrderDetails_Search();
			//OrderDetails_Update();
			//OrderDetails_Delete();

			//Product_LoadAll();
			//Product_Search();
			//Product_Update();
			//Product_Delete();

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
		
        public void BankAccount_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new BankAccountRepository(Context);
            BaseRepositoryUnitTest_BankAccount_AddRange(repo, count, startSeed, expected, true);
        }

        public void BankTransfers_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankTransfersRepository(Context);
            BaseRepositoryUnitTest_BankTransfers_AddRange(repo, count, startSeed, expected);
        }
		
        public void BankTransfers_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new BankTransfersRepository(Context);
            BaseRepositoryUnitTest_BankTransfers_AddRange(repo, count, startSeed, expected, true);
        }

        public void Book_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BookRepository(Context);
            BaseRepositoryUnitTest_Book_AddRange(repo, count, startSeed, expected);
        }
		
        public void Book_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new BookRepository(Context);
            BaseRepositoryUnitTest_Book_AddRange(repo, count, startSeed, expected, true);
        }

        public void Country_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_AddRange(repo, count, startSeed, expected);
        }
		
        public void Country_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_AddRange(repo, count, startSeed, expected, true);
        }

        public void Customer_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_AddRange(repo, count, startSeed, expected);
        }
		
        public void Customer_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_AddRange(repo, count, startSeed, expected, true);
        }

        public void Order_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderRepository(Context);
            BaseRepositoryUnitTest_Order_AddRange(repo, count, startSeed, expected);
        }
		
        public void Order_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new OrderRepository(Context);
            BaseRepositoryUnitTest_Order_AddRange(repo, count, startSeed, expected, true);
        }

        public void OrderDetails_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderDetailsRepository(Context);
            BaseRepositoryUnitTest_OrderDetails_AddRange(repo, count, startSeed, expected);
        }
		
        public void OrderDetails_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new OrderDetailsRepository(Context);
            BaseRepositoryUnitTest_OrderDetails_AddRange(repo, count, startSeed, expected, true);
        }

        public void Product_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new ProductRepository(Context);
            BaseRepositoryUnitTest_Product_AddRange(repo, count, startSeed, expected);
        }
		
        public void Product_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new ProductRepository(Context);
            BaseRepositoryUnitTest_Product_AddRange(repo, count, startSeed, expected, true);
        }

        public void Software_Add(int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new SoftwareRepository(Context);
            BaseRepositoryUnitTest_Software_AddRange(repo, count, startSeed, expected);
        }
		
        public void Software_Rollback(int count = 1, int startSeed = 1, int expected = 0)
        {
            var repo = new SoftwareRepository(Context);
            BaseRepositoryUnitTest_Software_AddRange(repo, count, startSeed, expected, true);
        }

		#endregion
		
		#region Base Tests

        protected virtual void BaseRepositoryUnitTest_BankAccount_AddRange(IBankAccountRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<IBankAccount>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new BankAccountDto();
                PopulateBankAccount(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankAccount found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_BankAccount(item, items.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_BankTransfers_AddRange(IBankTransfersRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<IBankTransfers>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new BankTransfersDto();
                PopulateBankTransfers(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankTransfers found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_BankTransfers(item, items.FirstOrDefault(o => o.BankTransferId == item.BankTransferId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_Book_AddRange(IBookRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<IBook>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new BookDto();
                PopulateBook(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Book found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_Book(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_Country_AddRange(ICountryRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<ICountry>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new CountryDto();
                PopulateCountry(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Country found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_Country(item, items.FirstOrDefault(o => o.CountryId == item.CountryId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_Customer_AddRange(ICustomerRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<ICustomer>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new CustomerDto();
                PopulateCustomer(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Customer found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_Customer(item, items.FirstOrDefault(o => o.CustomerId == item.CustomerId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_Order_AddRange(IOrderRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<IOrder>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new OrderDto();
                PopulateOrder(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Order found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_Order(item, items.FirstOrDefault(o => o.OrderId == item.OrderId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_OrderDetails_AddRange(IOrderDetailsRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<IOrderDetails>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new OrderDetailsDto();
                PopulateOrderDetails(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of OrderDetails found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_OrderDetails(item, items.FirstOrDefault(o => o.OrderDetailsId == item.OrderDetailsId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_Product_AddRange(IProductRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<IProduct>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new ProductDto();
                PopulateProduct(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Product found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_Product(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
				}
			}
        }

        protected virtual void BaseRepositoryUnitTest_Software_AddRange(ISoftwareRepository repository, int count = 1, int startSeed = 1, int expected = 1, bool rollback = false)
        {		
            var list = new List<ISoftware>();
            var seed = startSeed;
			
			if(UseTransactions)
			{
				Context.StartTransaction();
			}
			
            for (var index = 1; index <= count; index++)
            {
                var dto = new SoftwareDto();
                PopulateSoftware(dto, false, seed);
                list.Add(dto);
				repository.Save(dto);
                seed++;
            }

            if (!rollback)
            {
                Context.Commit();
            }
            else
            {
                Context.Rollback();
            }

            var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Software found");

			if(!rollback)
			{
				foreach (var item in list)
				{
					this.Check_Software(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
				}
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
