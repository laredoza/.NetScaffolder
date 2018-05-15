// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiplicityResult.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Multiplicity
{
    #region Usings

    using DotNetScaffolder.Mapping.MetaData.Enum;

    #endregion

    /// <summary>
    /// The multiplicity result.
    /// </summary>
    public class MultiplicityResult
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the multiplicity.
        /// </summary>
        public RelationshipMultiplicity Multiplicity { get; set; }

        /// <summary>
        /// Gets or sets the referenced multiplicity.
        /// </summary>
        public RelationshipMultiplicity ReferencedMultiplicity { get; set; }

        #endregion
    }
}