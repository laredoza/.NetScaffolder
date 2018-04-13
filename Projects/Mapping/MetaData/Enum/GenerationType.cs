// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Enum
{
    /// <summary>
    ///     This enum specifies in what directory structure generation occurs
    /// </summary>
    public enum GenerationType
    {
        /// <summary>
        ///     Security    --> EF
        ///     --> Repository
        /// </summary>
        Domain,

        /// <summary>
        ///     EF          --> Security
        ///     Repository  --> Security
        /// </summary>
        Layer,

        /// <summary>
        ///     Each layer is generated in seperate projects
        /// </summary>
        SeperateProjects
    }
}