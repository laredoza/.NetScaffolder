using System.IO;
using DotNetScaffolder.Domain.Data.Contexts.EFCore.Postgres.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DotNetScaffolder.Domain.Migrations.EFCore.Postgres.ContextDesigners
{
    /// <summary>
    /// The full context factory.
    /// </summary>
    public class FullContextFactory : IDesignTimeDbContextFactory<PostgresFullContext>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The create db context.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <returns>
        /// </returns>
        public PostgresFullContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("RepoTestProgres");
            return new PostgresFullContext(connectionString);
        }

        #endregion
    }
}