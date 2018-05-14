﻿//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Repository;
    using System.Data.Common;

    [TestClass]
    public class RepositoryEF6MySqlUnitTest : BaseRepositoryUnitTest
    {
        #region Init

        [TestInitialize]
        public override void SetupDb()
        {
            Context = new MySqlFullContext(Effort.DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}