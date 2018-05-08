using System;
using System.Data.Entity;
using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using DotNetScaffolder.Test.Components.SourceTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using WindowsFormsApp1;

    using MySql.Data.MySqlClient;
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class ContextEF6MySqlUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            //using (var context = new SellRightContext())
            //{
            //    Database.SetInitializer(new DropCreateDatabaseAlways<SellRightContext>());
            //    context.Database.Initialize(true);
            //}

            using (var context = new AccountContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }

            //using (MySqlConnection connection =
            //    new MySqlConnection("server=localhost;userid=test;password=password;database=test"))
            //{
            //    // Open the connection in a try/catch block. 
            //    // Create and execute the DataReader, writing the result
            //    // set to the console window.
            //    try
            //    {
            //        connection.Open();

            //        // result = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        // Logger.Error($"Unable to connect to database:{ex.Message}");
            //    }
            //}
        }

        [TestMethod]
        public void ContextUnitTest_CustomerContext_CreateDb()
        {
            using (var context = new CustomerContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_FullContext_CreateDb()
        {
            using (var context = new FullContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
