
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
    using RepositoryEFDotnet.Core.Base;

    [TestClass]
	public abstract partial class BaseUnitOfWorkUnitTests<TUow> : BaseUnitTest where TUow : IUnitOfWork
	{
        #region Fields

        protected static TUow Uow;

        #endregion
		
		#region Tests
		

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_RunAll()
        {
			this.BaseUnitOfWorkUnitTests_BankAccount_Add();
            this.BaseUnitOfWorkUnitTests_BankAccount_Get();

            this.BaseUnitOfWorkUnitTests_BankAccount_Any();
            this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter();
            this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound();

            this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault();
            this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter();
            this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound();

			this.BaseUnitOfWorkUnitTests_BankAccount_Modify();
			
            this.BaseUnitOfWorkUnitTests_BankAccount_Remove();
            this.BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound();
            this.BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound();
            this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound();
            this.BaseUnitOfWorkUnitTests_BankAccount_AddRange(100, 5);
            this.BaseUnitOfWorkUnitTests_BankAccount_GetAll();

            this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching();
            this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound();

            this.BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged();
            this.BaseUnitOfWorkUnitTests_BankAccount_Max();
			this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRange();
            this.BaseUnitOfWorkUnitTests_BankAccount_Rollback();
        }
		
		[TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync()
        {
            await this.BaseUnitOfWorkUnitTests_BankAccount_AddAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_GetAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_AnyAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(100, 5);
            await this.BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_MaxAsync();
			await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync();
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged()
        {
            var itemCount = 100;
            var pageSize = 5;
            var pageCount = System.Math.Abs(itemCount / pageSize);

            for (var pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                var entities = Uow.GetAllPaged<BankAccount>(pageIndex, pageSize, new List<string> { "BankAccountId" }).ToList();
                this.Check_EntityCount(pageSize, entities.Count(), "Incorrect number of BankAccount found");

                if (entities.Min(o => o.BankAccountId) < pageIndex * pageSize || entities.Max(o => o.BankAccountId) > pageIndex * pageSize + (pageSize - 1))
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
        private void BaseUnitOfWorkUnitTests_BankAccount_AddRange(int count, int startSeed = 1)
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

            Uow.AddRange(list);
            Uow.Commit();

            var entities = Uow.GetAll<BankAccount>().ToList();
            this.Check_EntityCount(count, entities.Count(), "Incorrect number of BankAccount found");

            for (var index = 1; index <= count; index++)
			{
                this.Check_BankAccount(list.FirstOrDefault(o => o.BankAccountId == index + startSeed - 1),entities.FirstOrDefault(o => o.BankAccountId == index + startSeed - 1));
			}
        }
		
        private async Task BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(int count, int startSeed = 1)
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

            await Uow.AddRangeAsync(list);
            await Uow.CommitAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            this.Check_EntityCount(count, entities.Count(), "Incorrect number of BankAccount found");

            for (var index = 1; index <= count; index++)
			{
                this.Check_BankAccount(list.FirstOrDefault(o => o.BankAccountId == index + startSeed - 1),entities.FirstOrDefault(o => o.BankAccountId == index + startSeed - 1));
			}
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Add()
        {
			BaseUnitOfWorkUnitTests_BankAccount_AddRange(1, 1);
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AddAsync()
        {
			BaseUnitOfWorkUnitTests_BankAccount_AddRange(1, 1);
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Modify()
        {
			int id = 1;
            var entityToUpdate = Uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == id);
			Assert.IsNotNull(entityToUpdate, $"BankAccount could not be found for BankAccountId = {id}");
            PopulateBankAccount(entityToUpdate, true, 2);

            Uow.Modify(entityToUpdate);
            Uow.Commit();

            var entities = Uow.AllMatching<BankAccount>(o => o.BankAccountId == id);
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entityToUpdate, entities.FirstOrDefault());
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_ModifyAsync()
        {
            var entity = new BankAccount();
            PopulateBankAccount(entity, true, 2);

            await Uow.ModifyAsync(entity);
            await Uow.CommitAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
            Check_BankAccount(entity, entities.FirstOrDefault());
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Remove()
        {		
            var entity = Uow.FirstOrDefault<BankAccount>();
			
			Assert.IsNotNull(entity, "BankAccount not found to remove");
			
            Uow.Remove(entity);
            Uow.Commit();

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync()
        {			
            var entity = Uow.FirstOrDefault<BankAccount>();
			
			Assert.IsNotNull(entity, "BankAccount not found to remove");
			
            await Uow.RemoveAsync(entity);
            await Uow.CommitAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_RemoveRange()
        {			
            var entitiesToRemove = Uow.GetAll<BankAccount>();
			
            Uow.RemoveRange(entitiesToRemove);
            Uow.Commit();

            var removedEntities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, removedEntities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync()
        {			
            var entitiesToRemove = await Uow.GetAllAsync<BankAccount>();
			
            await Uow.RemoveRangeAsync(entitiesToRemove);
            await Uow.CommitAsync();

            var removedEntities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(0, removedEntities.Count(), "Incorrect number of BankAccount found");
        }
		
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
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any()
        {
            bool hasAny = Uow.Any<BankAccount>();
            Assert.IsTrue(hasAny, "Could not find any BankAccount");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AnyAsync()
        {
            bool hasAny = await Uow.AnyAsync<BankAccount>();
            Assert.IsTrue(hasAny, "Could not find any BankAccount");
        }

        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound()
        {
            bool hasAny = Uow.Any<BankAccount>();
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter()
        {
            bool hasAny = Uow.Any<BankAccount>(o => o.BankAccountId == 1);
            Assert.IsTrue(hasAny, "Could not find any BankAccount with BankAccountId 1");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound()
        {
            bool hasAny = Uow.Any<BankAccount>(o => o.BankAccountId == 999);
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount with BankAccountId 999");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault()
        {
            var entity = Uow.FirstOrDefault<BankAccount>();
            Assert.IsNotNull(entity, "Could not find BankAccount");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync()
        {
            var entity = await Uow.FirstOrDefaultAsync<BankAccount>();
            Assert.IsNotNull(entity, "Could not find BankAccount");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound()
        {
            var entity = Uow.FirstOrDefault<BankAccount>();
            Assert.IsNull(entity, "Incorrectly found BankAccount");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter()
        {
            var entity = Uow.FirstOrDefault<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound()
        {
            var entity = Uow.FirstOrDefault<BankAccount>(o=> o.BankAccountId == 999);
			Assert.IsNull(entity, "Incorrect BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAll()
        {
            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Get()
        {
            var entity = Uow.Get<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Get_NothingFound()
        {
            var entity = Uow.Get<BankAccount>(o=> o.BankAccountId == 999999);
			Assert.IsNull(entity, "Incorrect BankAccount found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_GetAsync()
        {
            var entity = await Uow.GetAsync<BankAccount>(o=> o.BankAccountId == 1);
            Assert.IsNotNull(entity, "Could not find BankAccount");
            Assert.AreEqual(1, entity.BankAccountId, "Incorrect BankAccount.BankAccountId found");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync()
        {
            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound()
        {
            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(0, entities.Count(), "Incorrect number of BankAccount found");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching()
        {
            var result = Uow.AllMatching<BankAccount>(o => o.BankAccountId > 50);
            this.Check_EntityCount(50, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync()
        {
            var result = await Uow.AllMatchingAsync<BankAccount>(o => o.BankAccountId > 50);
            this.Check_EntityCount(50, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound()
        {
            var result = Uow.AllMatching<BankAccount>(o => o.BankAccountId > 999);
            this.Check_EntityCount(0, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync_NothingFound()
        {
            var result = await Uow.AllMatchingAsync<BankAccount>(o => o.BankAccountId > 999);
            this.Check_EntityCount(0, result.Count(), "Incorrect number of BankAccount found for filter");
        }
		
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Max()
        {
            var maxBankAccountId = Uow.Max<BankAccount, decimal>(o => o.BankAccountId);
            Assert.AreEqual(204, maxBankAccountId, "Incorrect max BankAccount.BankAccountId");
        }
		
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_MaxAsync()
        {
            var maxBankAccountId = await Uow.MaxAsync<BankAccount, decimal>(o => o.BankAccountId);
            Assert.AreEqual(204, maxBankAccountId, "Incorrect max BankAccount.BankAccountId");
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
