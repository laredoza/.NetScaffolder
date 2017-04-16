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
        /// The import.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        DatabaseModel Import(object options);

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        /// The database type.
        /// </param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        DomainDataType MapDatabaseTypeToCSharp(string databaseType);

        #endregion
    }
}