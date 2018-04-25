// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICollectionOption.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    /// <summary>
    /// The CollectionOption interface.
    /// </summary>
    public interface ICollectionOption
    {
        #region Properties

        /// <summary>
        /// Gets the class name.
        /// </summary>
        string ClassName { get; }
        string ClassNameInterface { get; }

        #endregion
    }
}