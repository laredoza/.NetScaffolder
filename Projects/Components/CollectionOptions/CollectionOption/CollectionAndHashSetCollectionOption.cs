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
        /// <summary>
        ///     The class name.
        /// </summary>
        public string ClassName => "HashSet";

        public string ClassNameInterface => "ICollection";
    }
}