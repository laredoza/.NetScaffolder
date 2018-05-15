﻿//using Banking.Models.Context;
//using Banking.Models.Customers;
using Banking.Models.Accounts;
using Banking.Models.Context;
using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public class UowEF6InMemoryOracleUnitTest : BaseUnitOfWorkUnitTests<OracleFullContext>
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            Uow = new OracleFullContext(Effort.DbConnectionFactory.CreateTransient());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Uow?.Dispose();
        }
    }
}