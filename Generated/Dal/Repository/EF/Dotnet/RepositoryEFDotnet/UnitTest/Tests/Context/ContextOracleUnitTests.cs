//using Banking.Models.Context;
//using Banking.Models.Customers;
using Banking.Models.Accounts;
using Banking.Models.Context;
using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public class ContextOracleUnitTest : BaseContextUnitTests<OracleFullContext>
    {
        [TestInitialize]
        public override void SetupContext()
        {
            Context = new OracleFullContext(Effort.DbConnectionFactory.CreateTransient());
        }
    }
}
