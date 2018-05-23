// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObservableCollectionOption.cs" company="DotnetScaffolder">
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
    ///     The observable collection option.
    /// </summary>
    [Export(typeof(ICollectionOption))]
    [ExportMetadata("NameMetaData", "Observable")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4412")]
    public class ObservableCollectionOption : ICollectionOption
    {
        #region Public Properties

        /// <summary>
        ///     The class name.
        /// </summary>
        public string ClassName => "ObservableCollection";

        /// <summary>
        /// The class name interface.
        /// </summary>
        public string ClassNameInterface => "ICollection";

        #endregion
    }
}