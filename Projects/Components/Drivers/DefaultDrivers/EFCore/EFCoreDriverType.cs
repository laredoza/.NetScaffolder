﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore
{
    #region Usings

    using System;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    /// The ef core driver type.
    /// </summary>
    [Export(typeof(IDriverType))]
    public class EFCoreDriverType : IDriverType
    {
        #region Public Properties

        /// <summary>
        /// The id.
        /// </summary>
        public Guid Id => new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4411");

        /// <summary>
        /// The name.
        /// </summary>
        public string Name => "Entity Framework Core";

        #endregion
    }
}