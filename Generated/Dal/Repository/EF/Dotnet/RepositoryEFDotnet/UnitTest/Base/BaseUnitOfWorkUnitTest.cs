//using Banking.Models.Customers;
using Banking.Models.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.UnitTest
{
    public abstract partial class BaseUnitOfWorkUnitTests<TUow>
    {
        //[TestMethod]
        //public virtual void BaseUnitOfWorkUnitTests_BankAccount_RunAll()
        //{
        //    BaseUnitOfWorkUnitTests_BankAccount_Add();
        //    BaseUnitOfWorkUnitTests_BankAccount_Get();
        //    BaseUnitOfWorkUnitTests_BankAccount_AddRange();
        //}

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound()
        {
            var entity = Uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == 999);
            Assert.IsNull(entity, "Incorrect BankAccount found");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Max()
        {
            BankAccount_AddRange(3);
            var maxBalance = Uow.Max<BankAccount, decimal>(o=> o.Balance);
            Assert.AreEqual(103, maxBalance, "Incorrect max BankAccount.Balance");
        }

        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_MaxAsync()
        {
            BankAccount_AddRange(3);
            var maxBalance = await Uow.MaxAsync<BankAccount, decimal>(o => o.Balance);
            Assert.AreEqual(103, maxBalance, "Incorrect max BankAccount.Balance");
        }

        //[TestMethod]
        //public virtual void BaseUnitOfWorkUnitTests_BankAccount_ApplyCurrentValues()
        //{
        //    BaseUnitOfWorkUnitTests_BankAccount_Add();

        //    var entity = new BankAccount();
        //    PopulateBankAccount(entity, true);

        //    var originalEntity = Uow.FirstOrDefault<BankAccount>(o => o.BankAccountId == 1);

        //    Uow.ApplyCurrentValues(originalEntity, entity);
        //    Uow.SaveChanges();

        //    var entities = Uow.GetAll<BankAccount>();
        //    Check_EntityCount(1, entities.Count(), "Incorrect number of BankAccount found");
        //    Check_BankAccount(entity, entities.FirstOrDefault());
        //}

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter()
        {
            BankAccount_AddRange(3, 1);
            bool hasAny = Uow.Any<BankAccount>(o=> o.Balance == 103);
            Assert.IsTrue(hasAny, "Could not find any BankAccount with balance 103");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound()
        {
            bool hasAny = Uow.Any<BankAccount>(o => o.Balance == 999);
            Assert.IsFalse(hasAny, "Incorrectly found BankAccount with balance 99");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching()
        {
            BankAccount_AddRange(3);
            var result = Uow.AllMatching<BankAccount>(o => o.Balance > 101);
            Check_EntityCount(2, result.Count(), "Incorrect number of BankAccounts found for filter");
        }

        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync()
        {
            BankAccount_AddRange(3);
            var result = await Uow.AllMatchingAsync<BankAccount>(o => o.Balance > 101);
            Check_EntityCount(2, result.Count(), "Incorrect number of BankAccounts found for filter");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound()
        {
            var result = Uow.AllMatching<BankAccount>(o => o.Balance > 999);
            Check_EntityCount(0, result.Count(), "Incorrect number of BankAccounts found for filter");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankTransfers_FirstOrDefault_Includes()
        {
            BankAccount_AddRange(2);
            var bankTransfer = new BankTransfers();
            PopulateBankTransfers(bankTransfer);
            Uow.Add(bankTransfer);
            Uow.SaveChanges();

            var savedEntity = Uow.FirstOrDefault<BankTransfers>(null, new List<string> { "BankAccount" });
            Assert.IsNotNull(savedEntity, "Could not find BankTransfer");

            Assert.IsNotNull(savedEntity.BankAccountFrom, "Could not find BankTransfer.BankAccountFrom");
            Assert.AreEqual(bankTransfer.FromBankAccountId, savedEntity.BankAccountFrom.BankAccountId, "Incorrect BankTranfer.BankAccountFrom.BankAccountId");

            Assert.IsNotNull(savedEntity.BankAccountTo, "Could not find BankTransfer.BankAccountTo");
            Assert.AreEqual(bankTransfer.ToBankAccountId, savedEntity.BankAccountTo.BankAccountId, "Incorrect BankTranfer.BankAccountTo.BankAccountId");
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_AddRange()
        {
            BankAccount_AddRange(99, 2);
        }

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged()
        {
            int itemCount = 100;
            int pageSize = 5;
            int pageCount = Math.Abs(itemCount / pageSize);

            BankAccount_AddRange(itemCount);

            for (int pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                var entities = Uow.GetAllPaged<BankAccount>(pageIndex, pageSize, new List<string> { "BankAccountId" }).ToList();
                Check_EntityCount(pageSize, entities.Count(), "Incorrect number of BankAccount found");
                
                if(entities.Min(o=> o.BankAccountId) < ((pageIndex * pageSize) - (pageSize - 1)) || entities.Max(o=> o.BankAccountId) > (pageIndex * pageSize))
                {
                    Assert.Fail("Incorrect paging detected");
                }
            }
        }

        private void BankAccount_AddRange(int count, int startSeed = 1)
        {
            var list = new List<BankAccount>();

            for (int index = 1; index <= count; index++)
            {
                var entity = new BankAccount();
                PopulateBankAccount(entity, false, startSeed);
                list.Add(entity);
                startSeed++;
            }

            Uow.AddRange(list);
            Uow.SaveChanges();

            var entities = Uow.GetAll<BankAccount>();
            Check_EntityCount(count, entities.Count(), "Incorrect number of BankAccount found");

            for (int index = 1; index <= count; index++)
            {
                Check_BankAccount(list.FirstOrDefault(o => o.BankAccountId == index), entities.FirstOrDefault(o => o.BankAccountId == index));
            }
        }

        [TestMethod]
        public virtual async Task BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync()
        {
            var list = new List<BankAccount>();
            var entity1 = new BankAccount();
            var entity2 = new BankAccount();
            var entity3 = new BankAccount();

            PopulateBankAccount(entity1, false, 1);
            PopulateBankAccount(entity2, false, 2);
            PopulateBankAccount(entity3, false, 3);

            list.Add(entity1);
            list.Add(entity2);
            list.Add(entity3);

            await Uow.AddRangeAsync(list);
            await Uow.SaveChangesAsync();

            var entities = await Uow.GetAllAsync<BankAccount>();
            Check_EntityCount(3, entities.Count(), "Incorrect number of BankAccount found");

            Check_BankAccount(entity1, entities.FirstOrDefault(o => o.BankAccountId == 1));
            Check_BankAccount(entity2, entities.FirstOrDefault(o => o.BankAccountId == 2));
            Check_BankAccount(entity3, entities.FirstOrDefault(o => o.BankAccountId == 3));
        }
    }
}
