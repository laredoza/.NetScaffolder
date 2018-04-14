// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilePersistenceOptions.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project
{
    using System;

    /// <summary>
    ///     The file persistance options.
    /// </summary>
    [Serializable]
    public class FilePersistenceOptions
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the path.
        /// </summary>
        public string Path { get; set; }

        #endregion
    }
}