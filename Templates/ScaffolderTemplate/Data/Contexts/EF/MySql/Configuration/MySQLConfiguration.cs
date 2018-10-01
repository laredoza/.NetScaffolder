using Banking.Models.Context.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.Configuration
{
    public class MySQLConfiguration : DbMigrationsConfiguration<MySqlFullContext>
    {
        public MySQLConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySQLMigrationGenerator());

        }


    }

    
}
