using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class ContextEF6MySqlUnitTest : BaseContextUnitTests<MySqlFullContext>
    {
        protected ContextEF6MySqlUnitTest() 
            : base(new MySqlFullContext(Effort.DbConnectionFactory.CreateTransient()))
        {
        }
    }
}
