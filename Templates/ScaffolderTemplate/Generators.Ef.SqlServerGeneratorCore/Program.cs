using System;

namespace Generators.Ef.SqlServerGeneratorCore
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
