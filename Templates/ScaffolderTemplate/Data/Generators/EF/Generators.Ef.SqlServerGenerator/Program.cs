using Banking.Models.Context.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators.Ef.SqlServerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating SqlServer database...");
            try
            {
                using (SqlServerFullContext uow = new SqlServerFullContext("SardsSqlServer"))
                {
                    uow.Database.CreateIfNotExists();
                    Console.WriteLine("Creating SqlServer database...Completed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Creating SqlServer database...Failed");
                Console.WriteLine();
                Console.WriteLine($"Message: {ex.GetBaseException().Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }

            Console.ReadLine();
        }
    }
}
