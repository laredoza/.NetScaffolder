using Base.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgres.Configuration
{
    public class ForeignKeyConstraintNameFormatter : NpgsqlMigrationSqlGenerator
    {
        protected override void Convert(AddForeignKeyOperation addForeignKeyOperation)
        {
            NameFormatting.CreateCustomForeignKeyName(addForeignKeyOperation);
            base.Convert(addForeignKeyOperation);
        }
    }
}
