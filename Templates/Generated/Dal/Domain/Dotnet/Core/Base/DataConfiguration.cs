using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryEFDotnet.Core.Base
{
    /// <summary>
    /// The data configuration.
    /// </summary>
    public class DataConfiguration : IDataConfiguration
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the connection strings.
        /// </summary>
        public IDictionary<string, string> ConnectionStrings { get; set; }

        public IDictionary<string, string> Settings { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        public void Load(IConfiguration configuration)
        {
            this.Settings = new Dictionary<string, string>
            {
                { "ReCaptchaPublic", configuration.GetSection("ReCaptcha:PublicKey").Value },
                { "ReCaptchaPrivate", configuration.GetSection("ReCaptcha:PrivateKey").Value },
                { "RedisHost", configuration.GetSection("Redis:Host").Value },
                { "RedisPort", configuration.GetSection("Redis:Port").Value },
                { "RedisFlushDb", configuration.GetSection("Redis:FlushDb").Value },
                { "RedisDataCompression", configuration.GetSection("Redis:DataCompression").Value },
                { "RedisLoadBalancedServers", configuration.GetSection("Redis:LoadBalancedServers").Value },
            };

            this.ConnectionStrings = new Dictionary<string, string> { { "RepoTestSqlServer", configuration.GetConnectionString("RepoTestSqlServer") } };
        }

        #endregion
    }
}
