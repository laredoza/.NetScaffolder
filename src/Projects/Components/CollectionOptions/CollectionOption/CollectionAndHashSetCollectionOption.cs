// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectionAndHashSetCollectionOption.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.CollectionOption
{
    #region Usings

    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The collection and hash set collection option.
    /// </summary>
    [Export(typeof(ICollectionOption))]
    [ExportMetadata("NameMetaData", "Collection")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class CollectionAndHashSetCollectionOption : ICollectionOption
    {
        #region Public Properties

        /// <summary>
        ///     The class name.
        /// </summary>
        public string ClassName => "HashSet";

        /// <summary>
        /// The class name interface.
        /// </summary>
        public string ClassNameInterface => "ICollection";

        #endregion
    }
}