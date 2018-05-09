using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.Library.Config
{
    using System.Data.Entity;

    using Oracle.ManagedDataAccess.Client;

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
