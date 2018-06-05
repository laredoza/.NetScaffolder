// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The Driver interface.
    /// </summary>
    public interface IDriver
    {
        #region Public Properties

        /// <summary>
        ///     Gets the context attribute.
        /// </summary>
        string ContextAttribute { get; }

        /// <summary>
        ///     Gets a value indicating whether force schema to uppercase.
        /// </summary>
        bool ForceSchemaToUppercase { get; }

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        List<string> NameSpaces { get; }

        /// <summary>
        ///     Gets the parent folder.
        /// </summary>
        string ParentFolder { get; }

        /// <summary>
        ///     Gets the prefix.
        /// </summary>
        string Prefix { get; }

        /// <summary>
        /// Gets the driver type.
        /// </summary>
        IDriverType DriverType { get; }

        string ConfigurationClass { get; }

        string AsAlias(string name);

        #endregion
    }
}