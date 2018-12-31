using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RepositoryEFDotnet.Data.Context.EFCore;

namespace RepositoryEFDotnet.Data.Migrations.SqlServer.ContextDesigners
{
    /// <summary>
    /// The full context factory.
    /// </summary>
    public class FullContextFactory : IDesignTimeDbContextFactory<SqlServerFullContext>
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
        public SqlServerFullContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("RepoTestSqlServer");
            return new SqlServerFullContext(connectionString);
        }

        #endregion
    }
}