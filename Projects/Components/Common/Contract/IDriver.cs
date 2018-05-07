// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    using System.Collections.Generic;

    /// <summary>
    /// The Driver interface.
    /// </summary>
    public interface IDriver
    {
        /// <summary>
        /// Gets the name spaces used to generate templates.
        /// </summary>
        List<string> NameSpaces { get; }

        /// <summary>
        /// Gets the prefix.
        /// </summary>
        string Prefix { get; }

        /// <summary>
        /// Gets the context attribute.
        /// </summary>
        string ContextAttribute { get; }
    }
}