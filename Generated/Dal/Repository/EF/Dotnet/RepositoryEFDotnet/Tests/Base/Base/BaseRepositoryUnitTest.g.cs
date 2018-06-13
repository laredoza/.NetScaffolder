
// <copyright file="BaseRepositoryUnitTest.g.cs" company="MIT">
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
		
        protected void BankAccount_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankAccountRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_BankAccount_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, list, expected);
        }
		
		protected virtual void BankAccount_LoadTests(IUnitOfWork uow)
		{
			BankAccount_LoadAll(uow);
			BankAccount_LoadById(uow);
			BankAccount_LoadByBalance(uow);
			BankAccount_LoadByCustomerId(uow);
			BankAccount_LoadByLocked(uow);
		}
		
		protected virtual void BankAccount_SearchTests(IUnitOfWork uow)
		{
			BankAccount_SearchByBankAccountNumber(uow);
			BankAccount_SearchByBankAccountNumber(uow, false);
		}
		
        protected void BankAccount_Update(IUnitOfWork uow)
        {
            var repo = new BankAccountRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateBankAccount(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, list, list.Count());
        }
		
        protected void BankAccount_Delete(IUnitOfWork uow)
        {
            var repo = new BankAccountRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.BankAccountId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of BankAccount found");
        }
		
        private IList<IBankAccount> BaseRepositoryUnitTest_BankAccount_AddRange(IBankAccountRepository repository, int count = 1, int startSeed = 1)
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
		
        private void BankAccount_LoadAll(IUnitOfWork uow)
        {
            var repo = new BankAccountRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, list, list.Count());
        }
		
        private void BankAccount_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IBankAccount>();
            var repo = new BankAccountRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.BankAccountId).Distinct())
			{
				loadedList.Add(repo.LoadByBankAccountId(item));
			}
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void BankAccount_LoadByBalance(IUnitOfWork uow)
        {
			var loadedList = new List<IBankAccount>();
            var repo = new BankAccountRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.Balance).Distinct())
			{
				loadedList.AddRange(repo.LoadByBalance(item));
			}
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, loadedList, loadedList.Count());
        }

        private void BankAccount_LoadByCustomerId(IUnitOfWork uow)
        {
			var loadedList = new List<IBankAccount>();
            var repo = new BankAccountRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.CustomerId).Distinct())
			{
				loadedList.AddRange(repo.LoadByCustomerId(item));
			}
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, loadedList, loadedList.Count());
        }

        private void BankAccount_LoadByLocked(IUnitOfWork uow)
        {
			var loadedList = new List<IBankAccount>();
            var repo = new BankAccountRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.Locked).Distinct())
			{
				loadedList.AddRange(repo.LoadByLocked(item));
			}
			
			BaseRepositoryUnitTest_BankAccount_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void BankAccount_SearchByBankAccountNumber(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new BankAccountRepository(uow);
			var list = new List<IBankAccount>();
			var dto = new BankAccountDto();
			PopulateBankAccount(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.BankAccountNumber.Substring(0, 4);
				list = uow.AllMatching<BankAccount>(i => i.BankAccountNumber.Contains(searchTxt)).Cast<IBankAccount>().ToList();
			}
			else
			{
				string searchTxt = dto.BankAccountNumber.Substring(0, 4).ToLower();
				list = uow.AllMatching<BankAccount>(i => i.BankAccountNumber.ToLower().Contains(searchTxt)).Cast<IBankAccount>().ToList();
			}
			
			var searchList = repo.SearchByBankAccountNumber(dto.BankAccountNumber.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No BankAccount found using BankAccountNumber");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of BankAccount found");

			foreach (var item in list)
			{
				this.Check_BankAccount(item, searchList.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
        }

		private void BaseRepositoryUnitTest_BankAccount_CheckData(IUnitOfWork uow, IList<IBankAccount> list, int expected)
		{
			var items = uow.GetAll<BankAccount>().Cast<IBankAccount>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankAccount found");

			foreach (var item in items)
			{
				this.Check_BankAccount(item, list.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
		}
		
        protected void BankTransfers_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BankTransfersRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_BankTransfers_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, list, expected);
        }
		
		protected virtual void BankTransfers_LoadTests(IUnitOfWork uow)
		{
			BankTransfers_LoadAll(uow);
			BankTransfers_LoadById(uow);
			BankTransfers_LoadByFromBankAccountId(uow);
			BankTransfers_LoadByToBankAccountId(uow);
			BankTransfers_LoadByAmount(uow);
			BankTransfers_LoadByTransferDate(uow);
		}
		
		protected virtual void BankTransfers_SearchTests(IUnitOfWork uow)
		{
		}
		
        protected void BankTransfers_Update(IUnitOfWork uow)
        {
            var repo = new BankTransfersRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateBankTransfers(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, list, list.Count());
        }
		
        protected void BankTransfers_Delete(IUnitOfWork uow)
        {
            var repo = new BankTransfersRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.BankTransferId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of BankTransfers found");
        }
		
        private IList<IBankTransfers> BaseRepositoryUnitTest_BankTransfers_AddRange(IBankTransfersRepository repository, int count = 1, int startSeed = 1)
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
		
        private void BankTransfers_LoadAll(IUnitOfWork uow)
        {
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, list, list.Count());
        }
		
        private void BankTransfers_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IBankTransfers>();
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.BankTransferId).Distinct())
			{
				loadedList.Add(repo.LoadByBankTransferId(item));
			}
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void BankTransfers_LoadByFromBankAccountId(IUnitOfWork uow)
        {
			var loadedList = new List<IBankTransfers>();
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.FromBankAccountId).Distinct())
			{
				loadedList.AddRange(repo.LoadByFromBankAccountId(item));
			}
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, loadedList, loadedList.Count());
        }

        private void BankTransfers_LoadByToBankAccountId(IUnitOfWork uow)
        {
			var loadedList = new List<IBankTransfers>();
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.ToBankAccountId).Distinct())
			{
				loadedList.AddRange(repo.LoadByToBankAccountId(item));
			}
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, loadedList, loadedList.Count());
        }

        private void BankTransfers_LoadByAmount(IUnitOfWork uow)
        {
			var loadedList = new List<IBankTransfers>();
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.Amount).Distinct())
			{
				loadedList.AddRange(repo.LoadByAmount(item));
			}
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, loadedList, loadedList.Count());
        }

        private void BankTransfers_LoadByTransferDate(IUnitOfWork uow)
        {
			var loadedList = new List<IBankTransfers>();
            var repo = new BankTransfersRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.TransferDate).Distinct())
			{
				loadedList.AddRange(repo.LoadByTransferDate(item));
			}
			
			BaseRepositoryUnitTest_BankTransfers_CheckData(uow, loadedList, loadedList.Count());
        }
		

		private void BaseRepositoryUnitTest_BankTransfers_CheckData(IUnitOfWork uow, IList<IBankTransfers> list, int expected)
		{
			var items = uow.GetAll<BankTransfers>().Cast<IBankTransfers>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of BankTransfers found");

			foreach (var item in items)
			{
				this.Check_BankTransfers(item, list.FirstOrDefault(o => o.BankTransferId == item.BankTransferId));
			}
		}
		
        protected void Book_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new BookRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Book_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Book_CheckData(uow, list, expected);
        }
		
		protected virtual void Book_LoadTests(IUnitOfWork uow)
		{
			Book_LoadAll(uow);
			Book_LoadById(uow);
		}
		
		protected virtual void Book_SearchTests(IUnitOfWork uow)
		{
			Book_SearchByPublisher(uow);
			Book_SearchByPublisher(uow, false);
		}
		
        protected void Book_Update(IUnitOfWork uow)
        {
            var repo = new BookRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateBook(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Book_CheckData(uow, list, list.Count());
        }
		
        protected void Book_Delete(IUnitOfWork uow)
        {
            var repo = new BookRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of Book found");
        }
		
        private IList<IBook> BaseRepositoryUnitTest_Book_AddRange(IBookRepository repository, int count = 1, int startSeed = 1)
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
		
        private void Book_LoadAll(IUnitOfWork uow)
        {
            var repo = new BookRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_Book_CheckData(uow, list, list.Count());
        }
		
        private void Book_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IBook>();
            var repo = new BookRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				loadedList.Add(repo.LoadByProductId(item));
			}
			
			BaseRepositoryUnitTest_Book_CheckData(uow, loadedList, loadedList.Count());
        }
		
		

        private void Book_SearchByPublisher(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new BookRepository(uow);
			var list = new List<IBook>();
			var dto = new BookDto();
			PopulateBook(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.Publisher.Substring(0, 4);
				list = uow.AllMatching<Book>(i => i.Publisher.Contains(searchTxt)).Cast<IBook>().ToList();
			}
			else
			{
				string searchTxt = dto.Publisher.Substring(0, 4).ToLower();
				list = uow.AllMatching<Book>(i => i.Publisher.ToLower().Contains(searchTxt)).Cast<IBook>().ToList();
			}
			
			var searchList = repo.SearchByPublisher(dto.Publisher.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Book found using Publisher");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Book found");

			foreach (var item in list)
			{
				this.Check_Book(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }

		private void BaseRepositoryUnitTest_Book_CheckData(IUnitOfWork uow, IList<IBook> list, int expected)
		{
			var items = uow.GetAll<Book>().Cast<IBook>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Book found");

			foreach (var item in items)
			{
				this.Check_Book(item, list.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
		
        protected void Country_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CountryRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Country_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Country_CheckData(uow, list, expected);
        }
		
		protected virtual void Country_LoadTests(IUnitOfWork uow)
		{
			Country_LoadAll(uow);
			Country_LoadById(uow);
		}
		
		protected virtual void Country_SearchTests(IUnitOfWork uow)
		{
			Country_SearchByCountryName(uow);
			Country_SearchByCountryName(uow, false);
		}
		
        protected void Country_Update(IUnitOfWork uow)
        {
            var repo = new CountryRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateCountry(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Country_CheckData(uow, list, list.Count());
        }
		
        protected void Country_Delete(IUnitOfWork uow)
        {
            var repo = new CountryRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.CountryId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of Country found");
        }
		
        private IList<ICountry> BaseRepositoryUnitTest_Country_AddRange(ICountryRepository repository, int count = 1, int startSeed = 1)
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
		
        private void Country_LoadAll(IUnitOfWork uow)
        {
            var repo = new CountryRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_Country_CheckData(uow, list, list.Count());
        }
		
        private void Country_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<ICountry>();
            var repo = new CountryRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.CountryId).Distinct())
			{
				loadedList.Add(repo.LoadByCountryId(item));
			}
			
			BaseRepositoryUnitTest_Country_CheckData(uow, loadedList, loadedList.Count());
        }
		
		

        private void Country_SearchByCountryName(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CountryRepository(uow);
			var list = new List<ICountry>();
			var dto = new CountryDto();
			PopulateCountry(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.CountryName.Substring(0, 4);
				list = uow.AllMatching<Country>(i => i.CountryName.Contains(searchTxt)).Cast<ICountry>().ToList();
			}
			else
			{
				string searchTxt = dto.CountryName.Substring(0, 4).ToLower();
				list = uow.AllMatching<Country>(i => i.CountryName.ToLower().Contains(searchTxt)).Cast<ICountry>().ToList();
			}
			
			var searchList = repo.SearchByCountryName(dto.CountryName.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Country found using CountryName");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Country found");

			foreach (var item in list)
			{
				this.Check_Country(item, searchList.FirstOrDefault(o => o.CountryId == item.CountryId));
			}
        }

		private void BaseRepositoryUnitTest_Country_CheckData(IUnitOfWork uow, IList<ICountry> list, int expected)
		{
			var items = uow.GetAll<Country>().Cast<ICountry>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Country found");

			foreach (var item in items)
			{
				this.Check_Country(item, list.FirstOrDefault(o => o.CountryId == item.CountryId));
			}
		}
		
        protected void Customer_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new CustomerRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Customer_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Customer_CheckData(uow, list, expected);
        }
		
		protected virtual void Customer_LoadTests(IUnitOfWork uow)
		{
			Customer_LoadAll(uow);
			Customer_LoadById(uow);
			Customer_LoadByCountryId(uow);
			Customer_LoadByIsEnabled(uow);
		}
		
		protected virtual void Customer_SearchTests(IUnitOfWork uow)
		{
			Customer_SearchByCustomerCode(uow);
			Customer_SearchByCustomerCode(uow, false);
			Customer_SearchByCompanyName(uow);
			Customer_SearchByCompanyName(uow, false);
			Customer_SearchByContactName(uow);
			Customer_SearchByContactName(uow, false);
			Customer_SearchByContactTitle(uow);
			Customer_SearchByContactTitle(uow, false);
			Customer_SearchByAddress(uow);
			Customer_SearchByAddress(uow, false);
			Customer_SearchByCity(uow);
			Customer_SearchByCity(uow, false);
			Customer_SearchByPostalCode(uow);
			Customer_SearchByPostalCode(uow, false);
			Customer_SearchByTelephone(uow);
			Customer_SearchByTelephone(uow, false);
			Customer_SearchByFax(uow);
			Customer_SearchByFax(uow, false);
			Customer_SearchByPhoto(uow);
			Customer_SearchByPhoto(uow, false);
		}
		
        protected void Customer_Update(IUnitOfWork uow)
        {
            var repo = new CustomerRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateCustomer(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Customer_CheckData(uow, list, list.Count());
        }
		
        protected void Customer_Delete(IUnitOfWork uow)
        {
            var repo = new CustomerRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.CustomerId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of Customer found");
        }
		
        private IList<ICustomer> BaseRepositoryUnitTest_Customer_AddRange(ICustomerRepository repository, int count = 1, int startSeed = 1)
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
		
        private void Customer_LoadAll(IUnitOfWork uow)
        {
            var repo = new CustomerRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_Customer_CheckData(uow, list, list.Count());
        }
		
        private void Customer_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<ICustomer>();
            var repo = new CustomerRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.CustomerId).Distinct())
			{
				loadedList.Add(repo.LoadByCustomerId(item));
			}
			
			BaseRepositoryUnitTest_Customer_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void Customer_LoadByCountryId(IUnitOfWork uow)
        {
			var loadedList = new List<ICustomer>();
            var repo = new CustomerRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.CountryId).Distinct())
			{
				loadedList.AddRange(repo.LoadByCountryId(item));
			}
			
			BaseRepositoryUnitTest_Customer_CheckData(uow, loadedList, loadedList.Count());
        }

        private void Customer_LoadByIsEnabled(IUnitOfWork uow)
        {
			var loadedList = new List<ICustomer>();
            var repo = new CustomerRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.IsEnabled).Distinct())
			{
				loadedList.AddRange(repo.LoadByIsEnabled(item));
			}
			
			BaseRepositoryUnitTest_Customer_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void Customer_SearchByCustomerCode(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.CustomerCode.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.CustomerCode.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.CustomerCode.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.CustomerCode.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByCustomerCode(dto.CustomerCode.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using CustomerCode");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByCompanyName(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.CompanyName.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.CompanyName.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.CompanyName.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.CompanyName.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByCompanyName(dto.CompanyName.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using CompanyName");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByContactName(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ContactName.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.ContactName.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.ContactName.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.ContactName.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByContactName(dto.ContactName.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using ContactName");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByContactTitle(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ContactTitle.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.ContactTitle.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.ContactTitle.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.ContactTitle.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByContactTitle(dto.ContactTitle.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using ContactTitle");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByAddress(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.Address.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.Address.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.Address.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.Address.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByAddress(dto.Address.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using Address");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByCity(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.City.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.City.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.City.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.City.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByCity(dto.City.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using City");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByPostalCode(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.PostalCode.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.PostalCode.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.PostalCode.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.PostalCode.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByPostalCode(dto.PostalCode.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using PostalCode");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByTelephone(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.Telephone.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.Telephone.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.Telephone.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.Telephone.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByTelephone(dto.Telephone.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using Telephone");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByFax(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.Fax.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.Fax.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.Fax.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.Fax.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByFax(dto.Fax.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using Fax");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

        private void Customer_SearchByPhoto(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new CustomerRepository(uow);
			var list = new List<ICustomer>();
			var dto = new CustomerDto();
			PopulateCustomer(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.Photo.Substring(0, 4);
				list = uow.AllMatching<Customer>(i => i.Photo.Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			else
			{
				string searchTxt = dto.Photo.Substring(0, 4).ToLower();
				list = uow.AllMatching<Customer>(i => i.Photo.ToLower().Contains(searchTxt)).Cast<ICustomer>().ToList();
			}
			
			var searchList = repo.SearchByPhoto(dto.Photo.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Customer found using Photo");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Customer found");

			foreach (var item in list)
			{
				this.Check_Customer(item, searchList.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
        }

		private void BaseRepositoryUnitTest_Customer_CheckData(IUnitOfWork uow, IList<ICustomer> list, int expected)
		{
			var items = uow.GetAll<Customer>().Cast<ICustomer>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Customer found");

			foreach (var item in items)
			{
				this.Check_Customer(item, list.FirstOrDefault(o => o.CustomerId == item.CustomerId));
			}
		}
		
        protected void Order_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Order_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Order_CheckData(uow, list, expected);
        }
		
		protected virtual void Order_LoadTests(IUnitOfWork uow)
		{
			Order_LoadAll(uow);
			Order_LoadById(uow);
			Order_LoadByCustomerId(uow);
			Order_LoadByOrderDate(uow);
			Order_LoadByDeliveryDate(uow);
		}
		
		protected virtual void Order_SearchTests(IUnitOfWork uow)
		{
			Order_SearchByShippingName(uow);
			Order_SearchByShippingName(uow, false);
			Order_SearchByShippingAddress(uow);
			Order_SearchByShippingAddress(uow, false);
			Order_SearchByShippingCity(uow);
			Order_SearchByShippingCity(uow, false);
			Order_SearchByShippingZip(uow);
			Order_SearchByShippingZip(uow, false);
		}
		
        protected void Order_Update(IUnitOfWork uow)
        {
            var repo = new OrderRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateOrder(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Order_CheckData(uow, list, list.Count());
        }
		
        protected void Order_Delete(IUnitOfWork uow)
        {
            var repo = new OrderRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.OrderId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of Order found");
        }
		
        private IList<IOrder> BaseRepositoryUnitTest_Order_AddRange(IOrderRepository repository, int count = 1, int startSeed = 1)
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
		
        private void Order_LoadAll(IUnitOfWork uow)
        {
            var repo = new OrderRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_Order_CheckData(uow, list, list.Count());
        }
		
        private void Order_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IOrder>();
            var repo = new OrderRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.OrderId).Distinct())
			{
				loadedList.Add(repo.LoadByOrderId(item));
			}
			
			BaseRepositoryUnitTest_Order_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void Order_LoadByCustomerId(IUnitOfWork uow)
        {
			var loadedList = new List<IOrder>();
            var repo = new OrderRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.CustomerId).Distinct())
			{
				loadedList.AddRange(repo.LoadByCustomerId(item));
			}
			
			BaseRepositoryUnitTest_Order_CheckData(uow, loadedList, loadedList.Count());
        }

        private void Order_LoadByOrderDate(IUnitOfWork uow)
        {
			var loadedList = new List<IOrder>();
            var repo = new OrderRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.OrderDate).Distinct())
			{
				loadedList.AddRange(repo.LoadByOrderDate(item));
			}
			
			BaseRepositoryUnitTest_Order_CheckData(uow, loadedList, loadedList.Count());
        }

        private void Order_LoadByDeliveryDate(IUnitOfWork uow)
        {
			var loadedList = new List<IOrder>();
            var repo = new OrderRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.DeliveryDate).Distinct())
			{
				loadedList.AddRange(repo.LoadByDeliveryDate(item));
			}
			
			BaseRepositoryUnitTest_Order_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void Order_SearchByShippingName(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			var dto = new OrderDto();
			PopulateOrder(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ShippingName.Substring(0, 4);
				list = uow.AllMatching<Order>(i => i.ShippingName.Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			else
			{
				string searchTxt = dto.ShippingName.Substring(0, 4).ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingName.ToLower().Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingName(dto.ShippingName.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found using ShippingName");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }

        private void Order_SearchByShippingAddress(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			var dto = new OrderDto();
			PopulateOrder(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ShippingAddress.Substring(0, 4);
				list = uow.AllMatching<Order>(i => i.ShippingAddress.Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			else
			{
				string searchTxt = dto.ShippingAddress.Substring(0, 4).ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingAddress.ToLower().Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingAddress(dto.ShippingAddress.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found using ShippingAddress");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }

        private void Order_SearchByShippingCity(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			var dto = new OrderDto();
			PopulateOrder(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ShippingCity.Substring(0, 4);
				list = uow.AllMatching<Order>(i => i.ShippingCity.Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			else
			{
				string searchTxt = dto.ShippingCity.Substring(0, 4).ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingCity.ToLower().Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingCity(dto.ShippingCity.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found using ShippingCity");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }

        private void Order_SearchByShippingZip(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new OrderRepository(uow);
			var list = new List<IOrder>();
			var dto = new OrderDto();
			PopulateOrder(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ShippingZip.Substring(0, 4);
				list = uow.AllMatching<Order>(i => i.ShippingZip.Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			else
			{
				string searchTxt = dto.ShippingZip.Substring(0, 4).ToLower();
				list = uow.AllMatching<Order>(i => i.ShippingZip.ToLower().Contains(searchTxt)).Cast<IOrder>().ToList();
			}
			
			var searchList = repo.SearchByShippingZip(dto.ShippingZip.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Order found using ShippingZip");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Order found");

			foreach (var item in list)
			{
				this.Check_Order(item, searchList.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
        }

		private void BaseRepositoryUnitTest_Order_CheckData(IUnitOfWork uow, IList<IOrder> list, int expected)
		{
			var items = uow.GetAll<Order>().Cast<IOrder>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Order found");

			foreach (var item in items)
			{
				this.Check_Order(item, list.FirstOrDefault(o => o.OrderId == item.OrderId));
			}
		}
		
        protected void OrderDetails_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new OrderDetailsRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_OrderDetails_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, list, expected);
        }
		
		protected virtual void OrderDetails_LoadTests(IUnitOfWork uow)
		{
			OrderDetails_LoadAll(uow);
			OrderDetails_LoadById(uow);
			OrderDetails_LoadByOrderId(uow);
			OrderDetails_LoadByProductId(uow);
			OrderDetails_LoadByUnitPrice(uow);
			OrderDetails_LoadByAmount(uow);
			OrderDetails_LoadByDiscount(uow);
		}
		
		protected virtual void OrderDetails_SearchTests(IUnitOfWork uow)
		{
		}
		
        protected void OrderDetails_Update(IUnitOfWork uow)
        {
            var repo = new OrderDetailsRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateOrderDetails(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, list, list.Count());
        }
		
        protected void OrderDetails_Delete(IUnitOfWork uow)
        {
            var repo = new OrderDetailsRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.OrderDetailsId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of OrderDetails found");
        }
		
        private IList<IOrderDetails> BaseRepositoryUnitTest_OrderDetails_AddRange(IOrderDetailsRepository repository, int count = 1, int startSeed = 1)
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
		
        private void OrderDetails_LoadAll(IUnitOfWork uow)
        {
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, list, list.Count());
        }
		
        private void OrderDetails_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.OrderDetailsId).Distinct())
			{
				loadedList.Add(repo.LoadByOrderDetailsId(item));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void OrderDetails_LoadByOrderId(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.OrderId).Distinct())
			{
				loadedList.AddRange(repo.LoadByOrderId(item));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, loadedList, loadedList.Count());
        }

        private void OrderDetails_LoadByProductId(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				loadedList.AddRange(repo.LoadByProductId(item));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, loadedList, loadedList.Count());
        }

        private void OrderDetails_LoadByUnitPrice(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.UnitPrice).Distinct())
			{
				loadedList.AddRange(repo.LoadByUnitPrice(item));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, loadedList, loadedList.Count());
        }

        private void OrderDetails_LoadByAmount(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.Amount).Distinct())
			{
				loadedList.AddRange(repo.LoadByAmount(item));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, loadedList, loadedList.Count());
        }

        private void OrderDetails_LoadByDiscount(IUnitOfWork uow)
        {
			var loadedList = new List<IOrderDetails>();
            var repo = new OrderDetailsRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.Discount).Distinct())
			{
				loadedList.AddRange(repo.LoadByDiscount(item));
			}
			
			BaseRepositoryUnitTest_OrderDetails_CheckData(uow, loadedList, loadedList.Count());
        }
		

		private void BaseRepositoryUnitTest_OrderDetails_CheckData(IUnitOfWork uow, IList<IOrderDetails> list, int expected)
		{
			var items = uow.GetAll<OrderDetails>().Cast<IOrderDetails>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of OrderDetails found");

			foreach (var item in items)
			{
				this.Check_OrderDetails(item, list.FirstOrDefault(o => o.OrderDetailsId == item.OrderDetailsId));
			}
		}
		
        protected void Product_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new ProductRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Product_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Product_CheckData(uow, list, expected);
        }
		
		protected virtual void Product_LoadTests(IUnitOfWork uow)
		{
			Product_LoadAll(uow);
			Product_LoadById(uow);
			Product_LoadByUnitPrice(uow);
			Product_LoadByAmountInStock(uow);
		}
		
		protected virtual void Product_SearchTests(IUnitOfWork uow)
		{
			Product_SearchByProductDescription(uow);
			Product_SearchByProductDescription(uow, false);
			Product_SearchByUnitAmount(uow);
			Product_SearchByUnitAmount(uow, false);
			Product_SearchByPublisher(uow);
			Product_SearchByPublisher(uow, false);
		}
		
        protected void Product_Update(IUnitOfWork uow)
        {
            var repo = new ProductRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateProduct(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Product_CheckData(uow, list, list.Count());
        }
		
        protected void Product_Delete(IUnitOfWork uow)
        {
            var repo = new ProductRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of Product found");
        }
		
        private IList<IProduct> BaseRepositoryUnitTest_Product_AddRange(IProductRepository repository, int count = 1, int startSeed = 1)
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
		
        private void Product_LoadAll(IUnitOfWork uow)
        {
            var repo = new ProductRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_Product_CheckData(uow, list, list.Count());
        }
		
        private void Product_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<IProduct>();
            var repo = new ProductRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				loadedList.Add(repo.LoadByProductId(item));
			}
			
			BaseRepositoryUnitTest_Product_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void Product_LoadByUnitPrice(IUnitOfWork uow)
        {
			var loadedList = new List<IProduct>();
            var repo = new ProductRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.UnitPrice).Distinct())
			{
				loadedList.AddRange(repo.LoadByUnitPrice(item));
			}
			
			BaseRepositoryUnitTest_Product_CheckData(uow, loadedList, loadedList.Count());
        }

        private void Product_LoadByAmountInStock(IUnitOfWork uow)
        {
			var loadedList = new List<IProduct>();
            var repo = new ProductRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.AmountInStock).Distinct())
			{
				loadedList.AddRange(repo.LoadByAmountInStock(item));
			}
			
			BaseRepositoryUnitTest_Product_CheckData(uow, loadedList, loadedList.Count());
        }
		

        private void Product_SearchByProductDescription(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new ProductRepository(uow);
			var list = new List<IProduct>();
			var dto = new ProductDto();
			PopulateProduct(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.ProductDescription.Substring(0, 4);
				list = uow.AllMatching<Product>(i => i.ProductDescription.Contains(searchTxt)).Cast<IProduct>().ToList();
			}
			else
			{
				string searchTxt = dto.ProductDescription.Substring(0, 4).ToLower();
				list = uow.AllMatching<Product>(i => i.ProductDescription.ToLower().Contains(searchTxt)).Cast<IProduct>().ToList();
			}
			
			var searchList = repo.SearchByProductDescription(dto.ProductDescription.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Product found using ProductDescription");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }

        private void Product_SearchByUnitAmount(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new ProductRepository(uow);
			var list = new List<IProduct>();
			var dto = new ProductDto();
			PopulateProduct(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.UnitAmount.Substring(0, 4);
				list = uow.AllMatching<Product>(i => i.UnitAmount.Contains(searchTxt)).Cast<IProduct>().ToList();
			}
			else
			{
				string searchTxt = dto.UnitAmount.Substring(0, 4).ToLower();
				list = uow.AllMatching<Product>(i => i.UnitAmount.ToLower().Contains(searchTxt)).Cast<IProduct>().ToList();
			}
			
			var searchList = repo.SearchByUnitAmount(dto.UnitAmount.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Product found using UnitAmount");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }

        private void Product_SearchByPublisher(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new ProductRepository(uow);
			var list = new List<IProduct>();
			var dto = new ProductDto();
			PopulateProduct(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.Publisher.Substring(0, 4);
				list = uow.AllMatching<Product>(i => i.Publisher.Contains(searchTxt)).Cast<IProduct>().ToList();
			}
			else
			{
				string searchTxt = dto.Publisher.Substring(0, 4).ToLower();
				list = uow.AllMatching<Product>(i => i.Publisher.ToLower().Contains(searchTxt)).Cast<IProduct>().ToList();
			}
			
			var searchList = repo.SearchByPublisher(dto.Publisher.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Product found using Publisher");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Product found");

			foreach (var item in list)
			{
				this.Check_Product(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }

		private void BaseRepositoryUnitTest_Product_CheckData(IUnitOfWork uow, IList<IProduct> list, int expected)
		{
			var items = uow.GetAll<Product>().Cast<IProduct>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Product found");

			foreach (var item in items)
			{
				this.Check_Product(item, list.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
		
        protected void Software_Add(IUnitOfWork uow, int count = 1, int startSeed = 1, int expected = 1)
        {
            var repo = new SoftwareRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
            var list = BaseRepositoryUnitTest_Software_AddRange(repo, count, startSeed);
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Software_CheckData(uow, list, expected);
        }
		
		protected virtual void Software_LoadTests(IUnitOfWork uow)
		{
			Software_LoadAll(uow);
			Software_LoadById(uow);
		}
		
		protected virtual void Software_SearchTests(IUnitOfWork uow)
		{
			Software_SearchByLicenseCode(uow);
			Software_SearchByLicenseCode(uow, false);
		}
		
        protected void Software_Update(IUnitOfWork uow)
        {
            var repo = new SoftwareRepository(uow);
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			var list = repo.LoadAll().ToList();
			
			foreach(var dto in list)
			{
				PopulateSoftware(dto, true);
				repo.Update(dto);
			}
			
			uow.Commit();
			
			BaseRepositoryUnitTest_Software_CheckData(uow, list, list.Count());
        }
		
        protected void Software_Delete(IUnitOfWork uow)
        {
            var repo = new SoftwareRepository(uow);
            var list = repo.LoadAll().ToList();
			
			if(UseTransactions)
			{
				uow.StartTransaction();
			}
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				repo.Delete(item);
			}
			
			uow.Commit();
			
			list = repo.LoadAll().ToList();
			this.Check_EntityCount(0, list.Count(), "Incorrect number of Software found");
        }
		
        private IList<ISoftware> BaseRepositoryUnitTest_Software_AddRange(ISoftwareRepository repository, int count = 1, int startSeed = 1)
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
		
        private void Software_LoadAll(IUnitOfWork uow)
        {
            var repo = new SoftwareRepository(uow);
			
            var list = repo.LoadAll();
			
			BaseRepositoryUnitTest_Software_CheckData(uow, list, list.Count());
        }
		
        private void Software_LoadById(IUnitOfWork uow)
        {
			var loadedList = new List<ISoftware>();
            var repo = new SoftwareRepository(uow);
			
            var list = repo.LoadAll().ToList();
			
			foreach(var item in list.Select(o => o.ProductId).Distinct())
			{
				loadedList.Add(repo.LoadByProductId(item));
			}
			
			BaseRepositoryUnitTest_Software_CheckData(uow, loadedList, loadedList.Count());
        }
		
		

        private void Software_SearchByLicenseCode(IUnitOfWork uow, bool caseSensitive = true)
        {
            var repo = new SoftwareRepository(uow);
			var list = new List<ISoftware>();
			var dto = new SoftwareDto();
			PopulateSoftware(dto);
			
			if(caseSensitive)
			{
				string searchTxt = dto.LicenseCode.Substring(0, 4);
				list = uow.AllMatching<Software>(i => i.LicenseCode.Contains(searchTxt)).Cast<ISoftware>().ToList();
			}
			else
			{
				string searchTxt = dto.LicenseCode.Substring(0, 4).ToLower();
				list = uow.AllMatching<Software>(i => i.LicenseCode.ToLower().Contains(searchTxt)).Cast<ISoftware>().ToList();
			}
			
			var searchList = repo.SearchByLicenseCode(dto.LicenseCode.Substring(0, 4), caseSensitive);
			
			Assert.IsTrue(searchList.Count > 0, "No Software found using LicenseCode");
			
			this.Check_EntityCount(list.Count(), searchList.Count(), "Incorrect number of Software found");

			foreach (var item in list)
			{
				this.Check_Software(item, searchList.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
        }

		private void BaseRepositoryUnitTest_Software_CheckData(IUnitOfWork uow, IList<ISoftware> list, int expected)
		{
			var items = uow.GetAll<Software>().Cast<ISoftware>().ToList();
            this.Check_EntityCount(expected, items.Count(), "Incorrect number of Software found");

			foreach (var item in items)
			{
				this.Check_Software(item, list.FirstOrDefault(o => o.ProductId == item.ProductId));
			}
		}
		
		#endregion
	}
}
