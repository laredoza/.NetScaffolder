using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Repository.UnitTests.Base
{
    using Banking.Models.Entity;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using FluentNHibernate.Data;

    using NHibernate;
    using NHibernate.Cfg;

    public class NHibernateSqlHelper<TEntity>
    {
        private static string conString = "RepoTest";

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory ?? (_sessionFactory = Fluently.Configure()
                                               .Database(MsSqlConfiguration.MsSql2012
                                                       .ConnectionString(c => c.FromConnectionStringWithKey(conString)).ShowSql())
                                               .Mappings(m => m.FluentMappings.Add<TEntity>())
                                               .BuildSessionFactory());
            }
        }

        public static ISession OpenSession( string conStringName)
        {
            conString = conStringName;
            return SessionFactory.OpenSession();
        }
    }
}
