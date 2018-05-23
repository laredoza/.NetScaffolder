
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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.UnitTest
{
	[TestClass]
	public abstract partial class BaseUnitOfWorkUnitTests<TUow> : BaseUnitTest where TUow : IUnitOfWork
	{
        #region Fields

        protected static TUow Uow;

        #endregion

		#region Tests
		

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Add()
        {
            var entity = new BankAccount();
            PopulateBankAccount(entity, false, 1);

            Uow.Add(entity);
            Uow.Commit();

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entity, entities.FirstOrDefault());
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AddAsync()
        {
            var entity = new BankAccount();
            PopulateBankAccount(entity, false, 1);

            await Uow.AddAsync(entity);
            await Uow.CommitAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entity, entities.FirstOrDefault());
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Modify()
        {
			int id = 1;
            var entityToUpdate = Uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == id);
			Assert.IsNotNull(entityToUpdate, $"BankAccount could not be found for BankAccountId = {id}");
            PopulateBankAccount(entityToUpdate, true);

            Uow.Modify(entityToUpdate);
            Uow.Commit();

            var entities = Uow.AllMatching<BankAccount>(o => o.BankAccountId == id);
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entityToUpdate, entities.FirstOrDefault());
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_ModifyAsync()
        {
            var entity = new BankAccount();
            PopulateBankAccount(entity, true);

            await Uow.ModifyAsync(entity);
            await Uow.CommitAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entity, entities.FirstOrDefault());
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Remove()
        {
			BaseUnitOfWorkUnitTests_BankAccount_Add();
			
            var entity = Uow.FirstOrDefault<BankAccount>();
			
			Assert.IsNotNull(entity, "BankAccount not found to remove");
			
            Uow.Remove(entity);
            Uow.Commit();

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync()
        {
			await BaseUnitOfWorkUnitTests_BankAccount_AddAsync();
			
            var entity = Uow.FirstOrDefault<BankAccount>();
			
			Assert.IsNotNull(entity, "BankAccount not found to remove");
			
            await Uow.RemoveAsync(entity);
            await Uow.CommitAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_RemoveRange()
        {
			BaseUnitOfWorkUnitTests_BankAccount_AddRange();
			
            var entitiesToRemove = Uow.GetAll<BankAccount>();
			
            Uow.RemoveRange(entitiesToRemove);
            Uow.Commit();

            var removedEntities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, removedEntities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync()
        {
			await BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync();
			
            var entitiesToRemove = await Uow.GetAllAsync<BankAccount>();
			
            await Uow.RemoveRangeAsync(entitiesToRemove);
            await Uow.CommitAsync();

            var removedEntities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, removedEntities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Rollback()
        {		
            var entity = new BankAccount();
            PopulateBankAccount(entity);

            Uow.Add(entity);
            Uow.Rollback();
			Uow.Commit(); // Do a commit here to make sure rollback did what it was suppose to

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync()
        {		
            var entity = new BankAccount();
            PopulateBankAccount(entity);

            await Uow.AddAsync(entity);
            await Uow.RollbackAsync();
			await Uow.CommitAsync(); // Do a commit here to make sure rollback did what it was suppose to

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any()
        {
			BaseUnitOfWorkUnitTests_BankAccount_Add();

            bool hasAny = Uow.Any<BankAccount>();
            Assert.IsTrue(hasAny, "Could not find any BankAccount");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AnyAsync()
        {
			await BaseUnitOfWorkUnitTests_BankAccount_AddAsync();

            bool hasAny = await Uow.AnyAsync<BankAccount>();
            Assert.IsTrue(hasAny, "Could not find any BankAccount");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound()
        {
            bool hasAny = Uow.Any<BankAccount>();
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault()
        {
			BaseUnitOfWorkUnitTests_BankAccount_Add();

            var entity = Uow.FirstOrDefault<BankAccount>();
            Assert.IsNotNull(entity, "Could not find BankAccount");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync()
        {
			await BaseUnitOfWorkUnitTests_BankAccount_AddAsync();

            var entity = await Uow.FirstOrDefaultAsync<BankAccount>();
            Assert.IsNotNull(entity, "Could not find BankAccount");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound()
        {
            var entity = Uow.FirstOrDefault<BankAccount>();
            Assert.IsNull(entity, "Incorrectly found BankAccount");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter()
        {
            var entity = Uow.FirstOrDefault<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAll()
        {
			BaseUnitOfWorkUnitTests_BankAccount_AddRange();

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Get()
        {
            var entity = Uow.Get<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Get_NothingFound()
        {
            var entity = Uow.Get<BankAccount>(o=> o.BankAccountId == 999999);
			Assert.IsNull(entity, "Incorrect BankAccount found");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_GetAsync()
        {
            var entity = await Uow.GetAsync<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync()
        {
			await BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound()
        {
            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }

		#endregion
		
        #region Cleanup

        [ClassCleanup]
        public void ClassCleanup()
        {
            Uow?.Dispose();
        }

        #endregion
	}
}
