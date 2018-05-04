﻿using System;
using System.Data.Entity;
using Banking.Models.Accounts;
using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public abstract class BaseContextUnitTests
    {
        [TestMethod]
        public void BaseContextUnitTests_CreateDbTest<TContext>(TContext context) where TContext : DbContext
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TContext>());
            context.Database.Initialize(true);
        }
    }
}