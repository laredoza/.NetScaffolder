// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplicationTableCollectionDifference.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Differences
{
    #region Usings

    using System.Collections.Generic;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The ApplicationTableCollectionDifference interface.
    /// </summary>
    public interface IApplicationTableCollectionDifference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the first extra tables.
        /// </summary>
        List<Table> FirstExtraTables { get; set; }

        /// <summary>
        ///     Gets or sets the first missing tables.
        /// </summary>
        List<Table> FirstMissingTables { get; set; }

        /// <summary>
        ///     Gets or sets the problem tables.
        /// </summary>
        List<ApplicationTableDifference> ProblemTables { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The compare table.
        /// </summary>
        /// <param name="first">
        /// The first.
        /// </param>
        /// <param name="second">
        /// The second.
        /// </param>
        /// <returns>
        /// The <see cref="ApplicationTableCollectionDifference"/>.
        /// </returns>
        ApplicationTableCollectionDifference CompareTables(List<Table> first, List<Table> second);

        #endregion
    }
}