using Base.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.Configuration
{
    public class ForeignKeyConstraintNameFormatter : SqlServerMigrationSqlGenerator
    {
        protected override void Generate(AddForeignKeyOperation addForeignKeyOperation)
        {
            NameFormatting.CreateCustomForeignKeyName(addForeignKeyOperation);
            base.Generate(addForeignKeyOperation);
        }
    }
}
