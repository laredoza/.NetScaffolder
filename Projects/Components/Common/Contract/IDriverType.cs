// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    ///     The DriverType interface.
    /// </summary>
    public interface IDriverType
    {
        #region Public Properties

        /// <summary>
        /// Gets the id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        string Name { get; }

        #endregion
    }
}