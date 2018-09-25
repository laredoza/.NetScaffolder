using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;

namespace Base.Helpers
{
    public static class NameFormatting
    {
        public static void CreateCustomForeignKeyName(AddForeignKeyOperation fk)
        {
            string fk_suffix = "FK";
            //string primaryKeyTable = StripTableNameFromSchema(addForeignKeyOperation.PrincipalTable);
            string foreignKeyTable = StripTableNameFromSchema(fk.DependentTable);

            string fkColumn = GetColumnNames(fk.DependentColumns);
            //string pkColumn = GetColumnNames(addForeignKeyOperation.PrincipalColumns);

            fk.Name = $"{foreignKeyTable}_{fkColumn}_{fk_suffix}";
        }

        private static string StripTableNameFromSchema(string name)
        {
            if (name.Contains("."))
            {
                name = name.Split('.')[1];
            }

            return name;
        }

        private static string GetColumnNames(IList<string> columns)
        {
            string name = string.Empty;
            foreach (var column in columns)
            {
                name += column;
            }

            return name;
        }
    }
}
