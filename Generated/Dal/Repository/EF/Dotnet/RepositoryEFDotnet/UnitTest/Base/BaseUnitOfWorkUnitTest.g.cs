
// <copyright file="BaseUnitOfWorkUnitTest.g.cs.g.cs" company="MIT">
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

using Banking.Models.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System.Data.Entity;
using System.Linq;

namespace RepositoryEFDotnet.UnitTest
{
	[TestClass]
	public abstract partial class BaseUnitOfWorkUnitTests<TUow> : BaseUnitTest where TUow : DbContext, IUnitOfWork
	{
        #region Fields

        protected TUow Uow = null;

        #endregion

        #region Setup

        public abstract void SetupUow();

        #endregion

		#region Tests

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_CreateDbTest()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TUow>());
            Uow.Database.Initialize(true);
        }
		

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_BankAccount()
        {
            var entity = new BankAccount();
            PopulateBankAccount(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(1, entities.Count(), "BankAccount");
            Check_BankAccount(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_BankTransfers()
        {
            var entity = new BankTransfers();
            PopulateBankTransfers(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<BankTransfers>();
            Check_EntityCount(1, entities.Count(), "BankTransfers");
            Check_BankTransfers(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_Book()
        {
            var entity = new Book();
            PopulateBook(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Book>();
            Check_EntityCount(1, entities.Count(), "Book");
            Check_Book(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_Country()
        {
            var entity = new Country();
            PopulateCountry(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Country>();
            Check_EntityCount(1, entities.Count(), "Country");
            Check_Country(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_Customer()
        {
            var entity = new Customer();
            PopulateCustomer(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Customer>();
            Check_EntityCount(1, entities.Count(), "Customer");
            Check_Customer(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_Order()
        {
            var entity = new Order();
            PopulateOrder(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Order>();
            Check_EntityCount(1, entities.Count(), "Order");
            Check_Order(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_OrderDetails()
        {
            var entity = new OrderDetails();
            PopulateOrderDetails(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<OrderDetails>();
            Check_EntityCount(1, entities.Count(), "OrderDetails");
            Check_OrderDetails(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_Product()
        {
            var entity = new Product();
            PopulateProduct(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Product>();
            Check_EntityCount(1, entities.Count(), "Product");
            Check_Product(entity, entities.FirstOrDefault());
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_Add_Software()
        {
            var entity = new Software();
            PopulateSoftware(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Software>();
            Check_EntityCount(1, entities.Count(), "Software");
            Check_Software(entity, entities.FirstOrDefault());
        }

		#endregion
		
        #region Cleanup

        [TestCleanup]
        public void DisposeContext()
        {
            Uow?.Dispose();
        }

        #endregion
	}
}
