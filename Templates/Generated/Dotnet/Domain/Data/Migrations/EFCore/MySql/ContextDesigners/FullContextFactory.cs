using System.IO;
using DotNetScaffolder.Domain.Data.Contexts.EFCore.MySql.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DotNetScaffolder.Domain.Migrations.EFCore.MySql.ContextDesigners
{
    /// <summary>
    /// The full context factory.
    /// </summary>
    public class FullContextFactory : IDesignTimeDbContextFactory<MySqlFullContext>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The create db context.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <returns>
        /// The <see cref="SqlServerFullContext"/>.
        /// </returns>
        public MySqlFullContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("RepoTestMySql");
            return new MySqlFullContext(connectionString);
        }

        #endregion
    }
}