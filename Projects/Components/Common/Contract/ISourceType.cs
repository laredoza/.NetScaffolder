// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISourceType.cs" company="">
//   
// </copyright>
// <summary>
//   The SourceType interface.
//   This is the source from which the data structure is imported.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Using

    using System.Collections.Generic;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The SourceType interface.
    ///     This is the source from which the data structure is imported.
    /// </summary>
    /// <example>Edmx, Sql Database, Data Modeller</example>
    public interface ISourceType
    {
        #region Public methods and operators

        /// <summary>
        ///     Import data structure.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        List<Table> Import();

        #endregion
    }
}