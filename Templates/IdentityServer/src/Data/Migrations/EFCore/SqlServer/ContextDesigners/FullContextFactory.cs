using System.IO;
using DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DotNetScaffolder.Domain.Migrations.EFCore.SqlServer.ContextDesigners
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

            var connectionString = configuration.GetConnectionString("IdentityServerEFCoreSqlServer");
            return new SqlServerFullContext(connectionString);
        }

        #endregion
    }
}