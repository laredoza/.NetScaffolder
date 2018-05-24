// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    using DotNetScaffolder.Core.Common.Validation;
    #region Usings

    using System;

    #endregion

    /// <summary>
    ///     The DriverType interface.
    /// </summary>
    public interface IDriverType : IValidate
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
 
        void LoadConfig(object parameters);

        bool SaveConfig(object parameters);
    }
}