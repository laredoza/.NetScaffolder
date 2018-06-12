
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
using Banking.Models.Entity;
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
        protected virtual IList<IBankAccount> BaseRepositoryUnitTest_BankAccount_AddRange(IBankAccountRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<IBankAccount> BaseRepositoryUnitTest_BankAccount_Update(IBankAccountRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateBankAccount(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void BankAccount_Update(IUnitOfWork uow)
        {
            var repo = new BankAccountRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_BankAccount_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankAccount_CheckData(repo, list, list.Count());
        }
		
        public void BankAccount_LoadAll(IUnitOfWork uow)
        {
            var repo = new BankAccountRepository(uow);
			
            var list = uow.GetAll<BankAccount>().Cast<IBankAccount>().ToList();
			
			BaseRepositoryUnitTest_BankAccount_CheckData(repo, list, list.Count());
        }
		
        public void BankAccount_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IBankAccount>();
            var repo = new BankAccountRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByBankAccountId(item.BankAccountId));
			}
			
			BaseRepositoryUnitTest_BankAccount_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void BankAccount_SearchByBankAccountNumber(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new BankAccountRepository(uow);
			var list = new List<IBankAccount>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<BankAccount>(i => i.BankAccountNumber.Contains(search)).Cast<IBankAccount>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<BankAccount>(i => i.BankAccountNumber.ToLower().Contains(loweredSearch)).Cast<IBankAccount>().ToList();
			}
			
			var searchList = repo.SearchByBankAccountNumber(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No BankAccount found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of BankAccount found");

			foreach (var item in list)
			{
				this.Check_BankAccount(item, searchList.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_BankAccount_CheckData(IBankAccountRepository repository, IList<IBankAccount> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankAccount found");

			foreach (var item in list)
			{
				this.Check_BankAccount(item, items.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
		}
        protected virtual IList<IBankTransfers> BaseRepositoryUnitTest_BankTransfers_AddRange(IBankTransfersRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<IBankTransfers> BaseRepositoryUnitTest_BankTransfers_Update(IBankTransfersRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateBankTransfers(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void BankTransfers_Update(IUnitOfWork uow)
        {
            var repo = new BankTransfersRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_BankTransfers_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(repo, list, list.Count());
        }
		
        public void BankTransfers_LoadAll(IUnitOfWork uow)
        {
            var repo = new BankTransfersRepository(uow);
			
            var list = uow.GetAll<BankTransfers>().Cast<IBankTransfers>().ToList();
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(repo, list, list.Count());
        }
		
        public void BankTransfers_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IBankTransfers>();
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByBankTransferId(item.BankTransferId));
			}
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(repo, loadedList, loadedList.Count());
        }
		

		protected virtual void BaseRepositoryUnitTest_BankTransfers_CheckData(IBankTransfersRepository repository, IList<IBankTransfers> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankTransfers found");

			foreach (var item in list)
			{
				this.Check_BankTransfers(item, items.FirstOrDefault(o => o.BankTransferId == item.BankTransferId));
			}
		}
        protected virtual IList<IBook> BaseRepositoryUnitTest_Book_AddRange(IBookRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<IBook> BaseRepositoryUnitTest_Book_Update(IBookRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateBook(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void Book_Update(IUnitOfWork uow)
        {
            var repo = new BookRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Book_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Book_CheckData(repo, list, list.Count());
        }
		
        public void Book_LoadAll(IUnitOfWork uow)
        {
            var repo = new BookRepository(uow);
			
            var list = uow.GetAll<Book>().Cast<IBook>().ToList();
			
			BaseRepositoryUnitTest_Book_CheckData(repo, list, list.Count());
        }
		
        public void Book_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IBook>();
            var repo = new BookRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByProductId(item.ProductId));
			}
			
			BaseRepositoryUnitTest_Book_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void Book_SearchByPublisher(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new BookRepository(uow);
			var list = new List<IBook>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Book>(i => i.Publisher.Contains(search)).Cast<IBook>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Book>(i => i.Publisher.ToLower().Contains(loweredSearch)).Cast<IBook>().ToList();
			}
			
			var searchList = repo.SearchByPublisher(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Book found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Book found");

			foreach (var item in list)
			{
				this.Check_Book(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_Book_CheckData(IBookRepository repository, IList<IBook> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Book found");

			foreach (var item in list)
			{
				this.Check_Book(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
        protected virtual IList<ICountry> BaseRepositoryUnitTest_Country_AddRange(ICountryRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<ICountry> BaseRepositoryUnitTest_Country_Update(ICountryRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateCountry(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void Country_Update(IUnitOfWork uow)
        {
            var repo = new CountryRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Country_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Country_CheckData(repo, list, list.Count());
        }
		
        public void Country_LoadAll(IUnitOfWork uow)
        {
            var repo = new CountryRepository(uow);
			
            var list = uow.GetAll<Country>().Cast<ICountry>().ToList();
			
			BaseRepositoryUnitTest_Country_CheckData(repo, list, list.Count());
        }
		
        public void Country_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<ICountry>();
            var repo = new CountryRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByCountryId(item.CountryId));
			}
			
			BaseRepositoryUnitTest_Country_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void Country_SearchByCountryName(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CountryRepository(uow);
			var list = new List<ICountry>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Country>(i => i.CountryName.Contains(search)).Cast<ICountry>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Country>(i => i.CountryName.ToLower().Contains(loweredSearch)).Cast<ICountry>().ToList();
			}
			
			var searchList = repo.SearchByCountryName(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Country found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Country found");

			foreach (var item in list)
			{
				this.Check_Country(item, searchList.FirstOrDefault(o => o.CountryId == item.CountryId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_Country_CheckData(ICountryRepository repository, IList<ICountry> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Country found");

			foreach (var item in list)
			{
				this.Check_Country(item, items.FirstOrDefault(o => o.CountryId == item.CountryId));
			}
		}
        protected virtual IList<ICustomer> BaseRepositoryUnitTest_Customer_AddRange(ICustomerRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<ICustomer> BaseRepositoryUnitTest_Customer_Update(ICustomerRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateCustomer(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void Customer_Update(IUnitOfWork uow)
        {
            var repo = new CustomerRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Customer_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Customer_CheckData(repo, list, list.Count());
        }
		
        public void Customer_LoadAll(IUnitOfWork uow)
        {
            var repo = new CustomerRepository(uow);
			
            var list = uow.GetAll<Customer>().Cast<ICustomer>().ToList();
			
			BaseRepositoryUnitTest_Customer_CheckData(repo, list, list.Count());
        }
		
        public void Customer_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<ICustomer>();
            var repo = new CustomerRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByCustomerId(item.CustomerId));
			}
			
			BaseRepositoryUnitTest_Customer_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void Customer_SearchByCustomerCode(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.CustomerCode.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.CustomerCode.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByCustomerCode(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByCompanyName(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.CompanyName.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.CompanyName.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByCompanyName(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByContactName(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.ContactName.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.ContactName.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByContactName(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByContactTitle(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.ContactTitle.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.ContactTitle.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByContactTitle(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByAddress(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.Address.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.Address.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByAddress(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByCity(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.City.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.City.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByCity(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByPostalCode(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.PostalCode.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.PostalCode.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByPostalCode(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByTelephone(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.Telephone.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.Telephone.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByTelephone(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByFax(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.Fax.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.Fax.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByFax(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


        public void Customer_SearchByPhoto(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Customer>(i => i.Photo.Contains(search)).Cast<ICustomer>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Customer>(i => i.Photo.ToLower().Contains(loweredSearch)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByPhoto(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_Customer_CheckData(ICustomerRepository repository, IList<ICustomer> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, items.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
		}
        protected virtual IList<IOrder> BaseRepositoryUnitTest_Order_AddRange(IOrderRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<IOrder> BaseRepositoryUnitTest_Order_Update(IOrderRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateOrder(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void Order_Update(IUnitOfWork uow)
        {
            var repo = new OrderRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Order_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Order_CheckData(repo, list, list.Count());
        }
		
        public void Order_LoadAll(IUnitOfWork uow)
        {
            var repo = new OrderRepository(uow);
			
            var list = uow.GetAll<Order>().Cast<IOrder>().ToList();
			
			BaseRepositoryUnitTest_Order_CheckData(repo, list, list.Count());
        }
		
        public void Order_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IOrder>();
            var repo = new OrderRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByOrderId(item.OrderId));
			}
			
			BaseRepositoryUnitTest_Order_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void Order_SearchByShippingName(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Order>(i => i.ShippingName.Contains(search)).Cast<IOrder>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingName.ToLower().Contains(loweredSearch)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingName(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }


        public void Order_SearchByShippingAddress(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Order>(i => i.ShippingAddress.Contains(search)).Cast<IOrder>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingAddress.ToLower().Contains(loweredSearch)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingAddress(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }


        public void Order_SearchByShippingCity(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Order>(i => i.ShippingCity.Contains(search)).Cast<IOrder>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingCity.ToLower().Contains(loweredSearch)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingCity(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }


        public void Order_SearchByShippingZip(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Order>(i => i.ShippingZip.Contains(search)).Cast<IOrder>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingZip.ToLower().Contains(loweredSearch)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingZip(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_Order_CheckData(IOrderRepository repository, IList<IOrder> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, items.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
		}
        protected virtual IList<IOrderDetails> BaseRepositoryUnitTest_OrderDetails_AddRange(IOrderDetailsRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<IOrderDetails> BaseRepositoryUnitTest_OrderDetails_Update(IOrderDetailsRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateOrderDetails(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void OrderDetails_Update(IUnitOfWork uow)
        {
            var repo = new OrderDetailsRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_OrderDetails_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(repo, list, list.Count());
        }
		
        public void OrderDetails_LoadAll(IUnitOfWork uow)
        {
            var repo = new OrderDetailsRepository(uow);
			
            var list = uow.GetAll<OrderDetails>().Cast<IOrderDetails>().ToList();
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(repo, list, list.Count());
        }
		
        public void OrderDetails_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByOrderDetailsId(item.OrderDetailsId));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(repo, loadedList, loadedList.Count());
        }
		

		protected virtual void BaseRepositoryUnitTest_OrderDetails_CheckData(IOrderDetailsRepository repository, IList<IOrderDetails> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of OrderDetails found");

			foreach (var item in list)
			{
				this.Check_OrderDetails(item, items.FirstOrDefault(o => o.OrderDetailsId == item.OrderDetailsId));
			}
		}
        protected virtual IList<IProduct> BaseRepositoryUnitTest_Product_AddRange(IProductRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<IProduct> BaseRepositoryUnitTest_Product_Update(IProductRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateProduct(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void Product_Update(IUnitOfWork uow)
        {
            var repo = new ProductRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Product_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Product_CheckData(repo, list, list.Count());
        }
		
        public void Product_LoadAll(IUnitOfWork uow)
        {
            var repo = new ProductRepository(uow);
			
            var list = uow.GetAll<Product>().Cast<IProduct>().ToList();
			
			BaseRepositoryUnitTest_Product_CheckData(repo, list, list.Count());
        }
		
        public void Product_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IProduct>();
            var repo = new ProductRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByProductId(item.ProductId));
			}
			
			BaseRepositoryUnitTest_Product_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void Product_SearchByProductDescription(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new ProductRepository(uow);
			var list = new List<IProduct>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Product>(i => i.ProductDescription.Contains(search)).Cast<IProduct>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Product>(i => i.ProductDescription.ToLower().Contains(loweredSearch)).Cast<IProduct>().ToList();
			}
			
			var searchList = repo.SearchByProductDescription(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Product found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }


        public void Product_SearchByUnitAmount(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new ProductRepository(uow);
			var list = new List<IProduct>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Product>(i => i.UnitAmount.Contains(search)).Cast<IProduct>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Product>(i => i.UnitAmount.ToLower().Contains(loweredSearch)).Cast<IProduct>().ToList();
			}
			
			var searchList = repo.SearchByUnitAmount(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Product found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }


        public void Product_SearchByPublisher(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new ProductRepository(uow);
			var list = new List<IProduct>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Product>(i => i.Publisher.Contains(search)).Cast<IProduct>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Product>(i => i.Publisher.ToLower().Contains(loweredSearch)).Cast<IProduct>().ToList();
			}
			
			var searchList = repo.SearchByPublisher(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Product found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_Product_CheckData(IProductRepository repository, IList<IProduct> list, int expected)
		{
			var items = repository.LoadAll();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, items.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
        protected virtual IList<ISoftware> BaseRepositoryUnitTest_Software_AddRange(ISoftwareRepository repository, int count = 1, int startSeed = 1)
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
		
        protected virtual IList<ISoftware> BaseRepositoryUnitTest_Software_Update(ISoftwareRepository repository)
        {		
			var list = repository.LoadAll();
			foreach(var dto in list)
			{
				PopulateSoftware(dto, true);
				repository.Update(dto);
			}
			return list;
		}
		
        public void Software_Update(IUnitOfWork uow)
        {
            var repo = new SoftwareRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Software_Update(repo);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Software_CheckData(repo, list, list.Count());
        }
		
        public void Software_LoadAll(IUnitOfWork uow)
        {
            var repo = new SoftwareRepository(uow);
			
            var list = uow.GetAll<Software>().Cast<ISoftware>().ToList();
			
			BaseRepositoryUnitTest_Software_CheckData(repo, list, list.Count());
        }
		
        public void Software_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<ISoftware>();
            var repo = new SoftwareRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list)
			{
				loadedList.Add(repo.LoadByProductId(item.ProductId));
			}
			
			BaseRepositoryUnitTest_Software_CheckData(repo, loadedList, loadedList.Count());
        }
		

        public void Software_SearchByLicenseCode(IUnitOfWork uow, string search, bool caseSensitive = true)
        {
            var repo = new SoftwareRepository(uow);
			var list = new List<ISoftware>();
			
			if(caseSensitive)
			{
				list = uow.AllMatching<Software>(i => i.LicenseCode.Contains(search)).Cast<ISoftware>().ToList();
			}
			else
			{
				string loweredSearch = search.ToLower();
				list = uow.AllMatching<Software>(i => i.LicenseCode.ToLower().Contains(loweredSearch)).Cast<ISoftware>().ToList();
			}
			
			var searchList = repo.SearchByLicenseCode(search, caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Software found");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Software found");

			foreach (var item in list)
			{
				this.Check_Software(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }


		protected virtual void BaseRepositoryUnitTest_Software_CheckData(ISoftwareRepository repository, IList<ISoftware> list, int expected)
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
