// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataConfiguration.cs" company="Hannover Rei">
//   Copyright 2014. Hannover Re | Terms and Conditions | Legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace DotNetScaffolder.Domain.Core.Interfaces
{
    #region

    #endregion

    /// <summary>
    /// The DataConfiguration interface.
    /// </summary>
    public interface IDataConfiguration
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the connection strings.
        /// </summary>
        IDictionary<string, string> ConnectionStrings { get; set; }

        IDictionary<string, string> Settings { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        void Load(IConfiguration configuration);

        #endregion
    }
}