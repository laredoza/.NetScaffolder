// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseUnitOfWorkUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Banking.Models.Entity;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The base unit of work unit tests.
    /// </summary>
    /// <typeparam name="TUow">
    /// </typeparam>
    public abstract partial class BaseUnitOfWorkUnitTests<TUow>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The base unit of work unit tests_ bank account_ add range.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AddRange()
        {
            var list = new List<BankAccount>();
            var entity1 = new BankAccount();
            var entity2 = new BankAccount();
            var entity3 = new BankAccount();

            this.PopulateBankAccount(entity1, false, 2);
            this.PopulateBankAccount(entity2, false, 3);
            this.PopulateBankAccount(entity3, false, 4);

            list.Add(entity1);
            list.Add(entity2);
            list.Add(entity3);

            Uow.AddRange(list);
            Uow.Commit();

            var entities = Uow.GetAll<BankAccount>().ToList();
            this.Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");

            this.Check_BankAccount(entity1, entities.FirstOrDefault(o => o.BankAccountId == 2));
            this.Check_BankAccount(entity2, entities.FirstOrDefault(o => o.BankAccountId == 3));
            this.Check_BankAccount(entity3, entities.FirstOrDefault(o => o.BankAccountId == 4));
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ add range async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync()
        {
            var list = new List<BankAccount>();
            var entity1 = new BankAccount();
            var entity2 = new BankAccount();
            var entity3 = new BankAccount();

            this.PopulateBankAccount(entity1, false, 2);
            this.PopulateBankAccount(entity2, false, 3);
            this.PopulateBankAccount(entity3, false, 4);

            list.Add(entity1);
            list.Add(entity2);
            list.Add(entity3);

            await Uow.AddRangeAsync(list);
            await Uow.CommitAsync();

            var entities = (await Uow.GetAllAsync<BankAccount>()).ToList();
            this.Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");

            this.Check_BankAccount(entity1, entities.FirstOrDefault(o => o.BankAccountId == 2));
            this.Check_BankAccount(entity2, entities.FirstOrDefault(o => o.BankAccountId == 3));
            this.Check_BankAccount(entity3, entities.FirstOrDefault(o => o.BankAccountId == 4));
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ all matching.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching()
        {
            var result = Uow.AllMatching<BankAccount>(o => o.Balance > 100);
            this.Check_EntityCount(3, result.Count(), "Incorrect number of BankAccounts found for filter");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ all matching_ nothing found.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound()
        {
            var result = Uow.AllMatching<BankAccount>(o => o.Balance > 999);
            this.Check_EntityCount(0, result.Count(), "Incorrect number of BankAccounts found for filter");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ all matching async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync()
        {
            var result = await Uow.AllMatchingAsync<BankAccount>(o => o.Balance > 100);
            this.Check_EntityCount(3, result.Count(), "Incorrect number of BankAccounts found for filter");
        }

        // [TestMethod]
        // public virtual void BaseUnitOfWorkUnitTests_BankAccount_ApplyCurrentValues()
        // {
        // BaseUnitOfWorkUnitTests_BankAccount_Add();

        // var entity = new BankAccount();
        // PopulateBankAccount(entity, true);

        // var originalEntity = Uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == 1);

        // Uow.ApplyCurrentValues(originalEntity, entity);
        // Uow.SaveChanges();

        // var entities = Uow.GetAll<BankAccount>();
        // Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
        // Check_BankAccount(entity, entities.FirstOrDefault());
        // }
        /// <summary>
        /// The base unit of work unit tests_ bank account_ any_ with filter.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter()
        {
            var hasAny = Uow.Any<BankAccount>(o => o.Balance == 101);
            Assert.IsTrue(hasAny, "Could not find any BankAccount with balance 101");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ any_ with filter_ nothing found.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound()
        {
            var hasAny = Uow.Any<BankAccount>(o => o.Balance == 999);
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount with balance 999");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ first or default_ with filter_ nothing found.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound()
        {
            var entity = Uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == 999);
            Assert.IsNull(entity, "Incorrect BankAccount found");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ get all paged.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged()
        {
            var itemCount = 100;
            var pageSize = 5;
            var pageCount = Math.Abs(itemCount / pageSize);

            for (var pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                var entities = Uow.GetAllPaged<BankAccount>(pageIndex, pageSize, new List<string> { "BankAccountId" })
                    .ToList();
                this.Check_EntityCount(pageSize, entities.Count(), "Incorrect number of BankAccount found");

                if (entities.Min(o => o.BankAccountId) < pageIndex * pageSize
                    || entities.Max(o => o.BankAccountId) > pageIndex * pageSize + (pageSize - 1))
                    Assert.Fail("Incorrect paging detected");
            }
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ max.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Max()
        {
            var maxBalance = Uow.Max<BankAccount, decimal>(o => o.Balance);
            Assert.AreEqual(204, maxBalance, "Incorrect max BankAccount.Balance");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ max async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_MaxAsync()
        {
            var maxBalance = await Uow.MaxAsync<BankAccount, decimal>(o => o.Balance);
            Assert.AreEqual(204, maxBalance, "Incorrect max BankAccount.Balance");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ run all.
        /// </summary>
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

            this.BaseUnitOfWorkUnitTests_BankAccount_Remove();
            this.BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound();
            this.BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound();
            this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound();
            this.BaseUnitOfWorkUnitTests_BankAccount_AddRange();
            this.BaseUnitOfWorkUnitTests_BankAccount_GetAll();

            this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching();
            this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound();

            this.BaseUnitOfWorkUnitTests_BankTransfers_FirstOrDefault_Includes();
            this.BaseUnitOfWorkUnitTests_BankTransfers_Remove();

            this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRange();
            this.BankAccount_AddRange(100, 5);
            this.BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged();
            this.BaseUnitOfWorkUnitTests_BankAccount_Max();
            this.BaseUnitOfWorkUnitTests_BankAccount_Rollback();
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ run all async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync()
        {
            await this.BaseUnitOfWorkUnitTests_BankAccount_AddAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_GetAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_AnyAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync();
            this.BankAccount_AddRange(100, 5);
            await this.BaseUnitOfWorkUnitTests_BankAccount_MaxAsync();
            await this.BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync();
        }

        /// <summary>
        /// The base unit of work unit tests_ bank transfers_ first or default_ includes.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankTransfers_FirstOrDefault_Includes()
        {
            var bankTransfer = new BankTransfers();
            this.PopulateBankTransfers(bankTransfer);
            Uow.Add(bankTransfer);
            Uow.Commit();

            var savedEntity = Uow.FirstOrDefault<BankTransfers>(null, new List<string> { "BankAccount" });
            Assert.IsNotNull(savedEntity, "Could not find BankTransfer");

            Assert.IsNotNull(savedEntity.BankAccountFrom, "Could not find BankTransfer.BankAccountFrom");
            Assert.AreEqual(
                bankTransfer.FromBankAccountId,
                savedEntity.BankAccountFrom.BankAccountId,
                "Incorrect BankTranfer.BankAccountFrom.BankAccountId");

            Assert.IsNotNull(savedEntity.BankAccountTo, "Could not find BankTransfer.BankAccountTo");
            Assert.AreEqual(
                bankTransfer.ToBankAccountId,
                savedEntity.BankAccountTo.BankAccountId,
                "Incorrect BankTranfer.BankAccountTo.BankAccountId");
        }

        /// <summary>
        /// The base unit of work unit tests_ bank transfers_ remove.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankTransfers_Remove()
        {
            var entity = Uow.FirstOrDefault<BankTransfers>();

            Assert.IsNotNull(entity, "BankTransfers not found to remove");

            Uow.Remove(entity);
            Uow.Commit();

            var entities = Uow.GetAll<BankTransfers>();
            this.Check_EntityCount(0, entities.Count(), "Incorrect number of BankTransfers found");
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The bank account_ add range.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        /// <param name="startSeed">
        /// The start seed.
        /// </param>
        private void BankAccount_AddRange(int count, int startSeed = 1)
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
                this.Check_BankAccount(
                    list.FirstOrDefault(o => o.BankAccountId == index + startSeed - 1),
                    entities.FirstOrDefault(o => o.BankAccountId == index + startSeed - 1));
        }

        #endregion
    }
}