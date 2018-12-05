#region Usings

using System;
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

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     Generate Instantiation text
        /// </summary>
        /// <returns></returns>
        string GenerateInstantiationText(CacheParameters parameter);

        #endregion
    }
}