using System.Collections.Generic;
using DotNetScaffolder.Domain.Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DotNetScaffolder.Domain.Core
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
        /// <param name="connectionstrings"></param>
        public void Load(IConfiguration configuration, List<string> connectionstrings)
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

            this.ConnectionStrings = new Dictionary<string, string>();

            foreach (string connectionstring in connectionstrings)
            {
                this.ConnectionStrings.Add(new KeyValuePair<string, string>(connectionstring, configuration.GetConnectionString(connectionstring)));
            }
        }

        #endregion
    }
}
