// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilePersistenceOptions.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    ///     The file persistance options.
    /// </summary>
    [Serializable]
    public class FilePersistenceOptions
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the path.
        /// </summary>
        public string Path { get; set; }

        #endregion
    }
}