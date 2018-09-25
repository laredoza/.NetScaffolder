using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgres.Configuration
{
    public class PostgresConfiguration : DbConfiguration
    {
        public PostgresConfiguration()
        {
            var name = "Npgsql";

            SetProviderFactory(name, NpgsqlFactory.Instance);

            SetProviderServices(providerInvariantName: name,
                provider: NpgsqlServices.Instance);

            SetDefaultConnectionFactory(new NpgsqlConnectionFactory());

            SetMigrationSqlGenerator(name, () => new ForeignKeyConstraintNameFormatter());
        }


    }
}
