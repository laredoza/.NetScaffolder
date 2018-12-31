using System;
using System.Configuration;
using DotNetScaffolder.Repository.UnitTests.EFCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Contexts.EFCore.Base;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Data.Context.EFCore;

namespace DotNetScaffolder.Repository.UnitTests.EFCore.Caching
{
    [TestClass]
    public class RedisMemoryUnitTest : BaseCacheUnitTest
    {
        private DbContextOptions<SqlServerFullContext> Options;

        [TestMethod]
        public void Init()
        {
            Provider = ConfigureServices.GetRedisCacheServiceProvider();
            EFSecondLevelCache.Core.EFServiceProvider.ApplicationServices = Provider;


            this.UnitOfWork =
            new SqlServerFullContext(ConfigurationManager.ConnectionStrings["RepoTest"].ConnectionString, Provider);

            //Options = new DbContextOptionsBuilder<SqlServerFullContext>().UseSqlServer(ConfigurationManager.ConnectionStrings["RepoTest"].ConnectionString).Options;
            //this.UnitOfWork = new SqlServerFullContext(Options);

            //using (var context = new SqlServerFullContext(Options))
            //{
            //    context.Database.EnsureDeleted();
            //    context.Database.EnsureCreated();
            //}

            this.ProductTest();

            this.UnitOfWork.Commit();
        }
    }
}
