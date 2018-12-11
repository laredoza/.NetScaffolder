namespace Oracle.Config
{
    using System.Data.Entity;

    using Oracle.ManagedDataAccess.Client;

    using RepositoryEFDotnet.Library.Config;

        
    
    public class OracleDbConfiguration : DbConfiguration
    {
        public OracleDbConfiguration()
        {
            this.SetHistoryContext("Oracle.ManagedDataAccess.Client",
                (connection, defaultSchema) => new OracleHistory(connection, defaultSchema));

            this.SetProviderServices("Oracle.ManagedDataAccess.Client", Oracle.ManagedDataAccess.EntityFramework.EFOracleProviderServices.Instance);
            this.SetProviderFactory("Oracle.ManagedDataAccess.Client", new OracleClientFactory());
        }
    }
}
