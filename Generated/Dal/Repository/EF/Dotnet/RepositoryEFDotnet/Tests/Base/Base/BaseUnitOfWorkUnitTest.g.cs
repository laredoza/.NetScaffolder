
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
using RepositoryEFDotnet.Core.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.UnitTest.Base
{
	[TestClass]
	public abstract partial class BaseUnitOfWorkUnitTests : BaseUnitTest
	{		
		#region Tests
		
        public abstract void RunAll();
		public abstract Task RunAllAsync();
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged(IUnitOfWork uow, int startId = 1)
        {
            var itemCount = 100;
            var pageSize = 5;
            var pageCount = System.Math.Abs(itemCount / pageSize);

            for (var pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                var entities = uow.GetAllPaged<BankAccount>(pageIndex, pageSize, new List<string> { "BankAccountId" }).ToList();
                this.Check_EntityCount(pageSize, entities.Count(), "Incorrect number of BankAccount found");

                if (entities.Min(o => o.BankAccountId) < startId + ((pageIndex * pageSize) - pageSize) || entities.Max(o => o.BankAccountId) > (startId * pageIndex) + (pageIndex * pageSize))
				{
					Assert.Fail("Incorrect paging detected");
				}
            }
        }

        /// <summary>
        /// The BankAccount add range.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        /// <param name="startSeed">
        /// The start seed.
        /// </param>
        protected void BaseUnitOfWorkUnitTests_BankAccount_AddRange(IUnitOfWork uow, int count, int startSeed = 1)
        {
            var list = new List<BankAccount>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var entity = new BankAccount();
                this.PopulateBankAccount(entity, false, seed);
                list.Add(entity);
                seed++;
            }

			uow.StartTransaction();
            uow.AddRange(list);
            uow.Commit();

            var entities = uow.GetAll<BankAccount>().ToList();
            this.Check_EntityCount(count, entities.Count(), "Incorrect number of BankAccount found");

            foreach(var item in list)
			{
                this.Check_BankAccount(item,entities.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
        }
		
        protected async Task BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(IUnitOfWork uow, int count, int startSeed = 1)
        {
            var list = new List<BankAccount>();
            var seed = startSeed;
            for (var index = 1; index <= count; index++)
            {
                var entity = new BankAccount();
                this.PopulateBankAccount(entity, false, seed);
                list.Add(entity);
                seed++;
            }

			uow.StartTransaction();
            await uow.AddRangeAsync(list);
            await uow.CommitAsync();

            var entities = await uow.GetAllAsync<BankAccount>();
            this.Check_EntityCount(count, entities.Count(), "Incorrect number of BankAccount found");

            foreach(var item in list)
			{
                this.Check_BankAccount(item,entities.FirstOrDefault(o => o.BankAccountId == item.BankAccountId));
			}
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Add(IUnitOfWork uow)
        {
			BaseUnitOfWorkUnitTests_BankAccount_AddRange(uow, 1, 1);
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AddAsync(IUnitOfWork uow)
        {
			await BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(uow, 1, 1);
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Modify(IUnitOfWork uow)
        {
			int id = 1;
            var entityToUpdate = uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == id);
			Assert.IsNotNull(entityToUpdate, $"BankAccount could not be found for BankAccountId = {id}");
            PopulateBankAccount(entityToUpdate, true, 2);

			uow.StartTransaction();
            uow.Modify(entityToUpdate);
            uow.Commit();

            var entities = uow.AllMatching<BankAccount>(o => o.BankAccountId == id);
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entityToUpdate, entities.FirstOrDefault());
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_ModifyAsync(IUnitOfWork uow)
        {
            var entity = new BankAccount();
            PopulateBankAccount(entity, true, 2);

			uow.StartTransaction();
            await uow.ModifyAsync(entity);
            await uow.CommitAsync();

            var entities = await uow.GetAllAsync<BankAccount>();
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entity, entities.FirstOrDefault());
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Remove(IUnitOfWork uow)
        {		
            var entity = uow.FirstOrDefault<BankAccount>();
			
			Assert.IsNotNull(entity, "BankAccount not found to remove");
			
			uow.StartTransaction();
            uow.Remove(entity);
            uow.Commit();

            var entities = uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync(IUnitOfWork uow)
        {			
            var entity = uow.FirstOrDefault<BankAccount>();
			
			Assert.IsNotNull(entity, "BankAccount not found to remove");
			
			uow.StartTransaction();
            await uow.RemoveAsync(entity);
            await uow.CommitAsync();

            var entities = await uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_RemoveRange(IUnitOfWork uow)
        {			
            var entitiesToRemove = uow.GetAll<BankAccount>();
			
			uow.StartTransaction();
            uow.RemoveRange(entitiesToRemove);
            uow.Commit();

            var removedEntities = uow.GetAll<BankAccount>();
            Check_EntityCount(0, removedEntities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync(IUnitOfWork uow)
        {			
            var entitiesToRemove = await uow.GetAllAsync<BankAccount>();
			
			uow.StartTransaction();
            await uow.RemoveRangeAsync(entitiesToRemove);
            await uow.CommitAsync();

            var removedEntities = await uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, removedEntities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Rollback(IUnitOfWork uow)
        {		
            var entity = new BankAccount();
            PopulateBankAccount(entity);

			uow.StartTransaction();
            uow.Add(entity);
            uow.Rollback();

            var entities = uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync(IUnitOfWork uow)
        {		
            var entity = new BankAccount();
            PopulateBankAccount(entity);

			uow.StartTransaction();
            await uow.AddAsync(entity);
            await uow.RollbackAsync();

            var entities = await uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any(IUnitOfWork uow)
        {
            bool hasAny = uow.Any<BankAccount>();
            Assert.IsTrue(hasAny, "Could not find any BankAccount");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AnyAsync(IUnitOfWork uow)
        {
            bool hasAny = await uow.AnyAsync<BankAccount>();
            Assert.IsTrue(hasAny, "Could not find any BankAccount");
        }

        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound(IUnitOfWork uow)
        {
            bool hasAny = uow.Any<BankAccount>();
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter(IUnitOfWork uow)
        {
            bool hasAny = uow.Any<BankAccount>(o => o.BankAccountId == 1);
            Assert.IsTrue(hasAny, "Could not find any BankAccount with BankAccountId 1");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound(IUnitOfWork uow)
        {
            bool hasAny = uow.Any<BankAccount>(o => o.BankAccountId == 999);
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount with BankAccountId 999");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault(IUnitOfWork uow)
        {
            var entity = uow.FirstOrDefault<BankAccount>();
            Assert.IsNotNull(entity, "Could not find BankAccount");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync(IUnitOfWork uow)
        {
            var entity = await uow.FirstOrDefaultAsync<BankAccount>();
            Assert.IsNotNull(entity, "Could not find BankAccount");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound(IUnitOfWork uow)
        {
            var entity = uow.FirstOrDefault<BankAccount>();
            Assert.IsNull(entity, "Incorrectly found BankAccount");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter(IUnitOfWork uow)
        {
            var entity = uow.FirstOrDefault<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound(IUnitOfWork uow)
        {
            var entity = uow.FirstOrDefault<BankAccount>(o=> o.BankAccountId == 999);
			Assert.IsNull(entity, "Incorrect BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAll(IUnitOfWork uow)
        {
            var entities = uow.GetAll<BankAccount>();
            Check_EntityCount(100, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Get(IUnitOfWork uow)
        {
            var entity = uow.Get<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Get_NothingFound(IUnitOfWork uow)
        {
            var entity = uow.Get<BankAccount>(o=> o.BankAccountId == 999999);
			Assert.IsNull(entity, "Incorrect BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_GetAsync(IUnitOfWork uow)
        {
            var entity = await uow.GetAsync<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync(IUnitOfWork uow)
        {
            var entities = await uow.GetAllAsync<BankAccount>();
            Check_EntityCount(100, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound(IUnitOfWork uow)
        {
            var entities = uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching(IUnitOfWork uow, int expected = 51)
        {
            var result = uow.AllMatching<BankAccount>(o => o.BankAccountId > 50);
            this.Check_EntityCount(expected, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync(IUnitOfWork uow, int expected = 51)
        {
            var result = await uow.AllMatchingAsync<BankAccount>(o => o.BankAccountId > 50);
            this.Check_EntityCount(expected, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound(IUnitOfWork uow)
        {
            var result = uow.AllMatching<BankAccount>(o => o.BankAccountId > 999);
            this.Check_EntityCount(0, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync_NothingFound(IUnitOfWork uow)
        {
            var result = await uow.AllMatchingAsync<BankAccount>(o => o.BankAccountId > 999);
            this.Check_EntityCount(0, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Max(IUnitOfWork uow, int expected = 101)
        {
            var maxBankAccountId = uow.Max<BankAccount, int>(o => o.BankAccountId);
            Assert.AreEqual(expected, maxBankAccountId, "Incorrect max BankAccount.BankAccountId");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_MaxAsync(IUnitOfWork uow, int expected = 101)
        {
            var maxBankAccountId = await uow.MaxAsync<BankAccount, int>(o => o.BankAccountId);
            Assert.AreEqual(expected, maxBankAccountId, "Incorrect max BankAccount.BankAccountId");
        }

		#endregion
	}
}
