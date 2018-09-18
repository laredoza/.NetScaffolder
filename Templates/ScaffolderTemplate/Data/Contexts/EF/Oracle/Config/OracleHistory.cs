namespace RepositoryEFDotnet.Library.Config
{
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Migrations.History;
    using System.Data.SqlClient;

    /// <summary>
    /// The oracle history.
    /// </summary>
    public class OracleHistory : HistoryContext
    {
        private string UserId;

        public OracleHistory(DbConnection dbConnection, string defaultSchema)
            : base(dbConnection, defaultSchema)
        {
            var a = dbConnection;

            var builder = new SqlConnectionStringBuilder(dbConnection.ConnectionString);
            this.UserId = builder.UserID;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Override Schema name if you want the migration to be in another folder
            modelBuilder.Entity<HistoryRow>().ToTable("__MigrationHistory", this.UserId.ToUpper());
        }
    }
}