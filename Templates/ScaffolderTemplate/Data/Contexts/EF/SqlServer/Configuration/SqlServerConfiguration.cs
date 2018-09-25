using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.Configuration
{
    public class SqlServerConfiguration : DbConfiguration
    {
        public SqlServerConfiguration()
        {
            var name = "System.Data.SqlClient";

            SetMigrationSqlGenerator(name, () => new ForeignKeyConstraintNameFormatter());
        }
    }
}
