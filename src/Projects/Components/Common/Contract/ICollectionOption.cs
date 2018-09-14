// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICollectionOption.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    /// <summary>
    ///     The CollectionOption interface.
    /// </summary>
    public interface ICollectionOption
    {
        #region Public Properties

        /// <summary>
        ///     Gets the class name.
        /// </summary>
        string ClassName { get; }

        /// <summary>
        /// Gets the class name interface.
        /// </summary>
        string ClassNameInterface { get; }

        #endregion
    }
}