// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowNHibernateInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NHibernate;
    using System.Threading.Tasks;
    using Banking.Models.Context.NHibernate;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;

    using NHibernate.Cfg;
    using NHibernate.Mapping;

    /// <summary>
    /// The uow n hibernate in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowNHibernateInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTest";

        private static Configuration Configuration = null;

        #endregion

        [ClassInitialize]
        public static void TestInit(TestContext tstContext)
        {
            Fluently.Configure().Database(MsSqliteConfiguration.Standard.InMemory())
                .Mappings(o => o.FluentMappings.AddFromAssemblyOf<Banking.Models.Context.Mappings.BankAccountMap>()).ExposeConfiguration(Remap).BuildConfiguration();
        }

        public static void Remap(Configuration cfg)
        {
            foreach (PersistentClass pc in cfg.ClassMappings)
            {
                if (pc.Table.Name.Contains("[") || pc.Table.Name.Contains("]") || 
                    pc.Table.Schema.Contains("[") || pc.Table.Schema.Contains("]"))
                {
                    //this is a table with schema
                    pc.Table.Name = pc.Table.Name.Replace("[", "").Replace("]", "");
                    pc.Table.Schema = pc.Table.Schema.Replace("[", "").Replace("]", "");
                }
            }

            Configuration = cfg;
        }

        #region Public Methods And Operators

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerFullContext(Configuration))
            {
                context.CreateSchema();
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        /// <summary>
        /// The run all async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new SqlServerFullContext(Configuration))
            {
                context.CreateSchema();
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}