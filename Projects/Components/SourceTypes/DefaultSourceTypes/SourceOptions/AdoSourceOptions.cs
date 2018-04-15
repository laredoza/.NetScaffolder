// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdoSourceOptions.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions
{
    /// <summary>
    /// The ado source options.
    /// </summary>
    public class AdoSourceOptions
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdoSourceOptions"/> class.
        /// </summary>
        public AdoSourceOptions()
        {
            this.ProviderName = "System.Data.SqlClient";
            this.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=AutoNLayered";
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the provider name.
        /// </summary>
        public string ProviderName { get; set; }

        #endregion
    }
}