// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndexType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    /// <summary>
    ///     The index type.
    /// </summary>
    public enum IndexType
    {
        /// <summary>
        /// The nonclustered.
        /// </summary>
        NonClustered = 0,

        /// <summary>
        /// The non clustered hash.
        /// </summary>
        NonClusteredHash = 1,

        /// <summary>
        /// The primary key.
        /// </summary>
        PrimaryKey = 2,

        /// <summary>
        /// The primary non clustered key.
        /// </summary>
        PrimaryNonClusteredKey = 3,

        /// <summary>
        /// The clustered.
        /// </summary>
        Clustered = 4,

        /// <summary>
        /// The xml.
        /// </summary>
        Xml = 5,

        Normal = 6,

        BTREE = 7
    }
}