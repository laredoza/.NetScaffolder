// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListAndListCollectionOption.cs" company="DotnetScaffolder">
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
    ///     The list and list collection option.
    /// </summary>
    [Export(typeof(ICollectionOption))]
    [ExportMetadata("NameMetaData", "List")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class ListAndListCollectionOption : ICollectionOption
    {
        /// <summary>
        ///     The class name.
        /// </summary>
        public string ClassName => "List";
    }
}