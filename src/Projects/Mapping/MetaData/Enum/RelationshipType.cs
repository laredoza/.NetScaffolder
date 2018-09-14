// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RelationshipType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Enum
{
    /// <summary>
    ///     The relationship type.
    /// </summary>
    public enum RelationshipType
    {
        /// <summary>
        ///     This describes an actual foreign key relationship from this table to another
        /// </summary>
        ForeignKey,

        /// <summary>
        ///     This describes another table's foreign key relationship to the current table.
        /// </summary>
        ForeignKeyChild
    }
}