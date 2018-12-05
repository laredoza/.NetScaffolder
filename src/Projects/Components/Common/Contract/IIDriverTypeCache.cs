#region Usings

using System;
using System.Collections.Generic;
using DotNetScaffolder.Components.Drivers.DefaultDrivers;

#endregion

namespace DotNetScaffolder.Components.Common.Contract
{
    public interface IIDriverTypeCache
    {
        #region Public Properties

        Guid Driver { get; set; }

        /// <summary>
        ///     Name of cache
        /// </summary>
        string Name { get; set; }

        List<string> CacheNamespaces { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     Generate begin unit of work
        /// </summary>
        /// <returns></returns>
        string GenerateBeginUnitOfWork(CacheParameters parameter);

        #endregion
    }
}