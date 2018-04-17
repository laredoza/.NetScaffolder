// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplicationTableDifference.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Differences
{
    #region Usings

    using System.Collections.Generic;

    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Model.Difference;

    #endregion

    /// <summary>
    ///     The ApplicationTableDifference interface.
    /// </summary>
    public interface IApplicationTableDifference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the column data type diffs.
        /// </summary>
        List<ColumnDataTypeDifference> ColumnDataTypeDiffs { get; set; }

        /// <summary>
        ///     Gets or sets the first extra columns.
        /// </summary>
        List<Column> FirstExtraColumns { get; set; }

        /// <summary>
        ///     Gets or sets the first extra relationships.
        /// </summary>
        List<Relationship> FirstExtraRelationships { get; set; }

        /// <summary>
        ///     Gets or sets the first missing columns.
        /// </summary>
        List<Column> FirstMissingColumns { get; set; }

        /// <summary>
        ///     Gets or sets the first missing relationships.
        /// </summary>
        List<Relationship> FirstMissingRelationships { get; set; }

        /// <summary>
        ///     Gets a value indicating whether has column data type diffs.
        /// </summary>
        bool HasColumnDataTypeDiffs { get; }

        /// <summary>
        ///     Gets a value indicating whether has extra columns.
        /// </summary>
        bool HasExtraColumns { get; }

        /// <summary>
        ///     Gets a value indicating whether has extra relationships.
        /// </summary>
        bool HasExtraRelationships { get; }

        /// <summary>
        ///     Gets a value indicating whether has missing columns.
        /// </summary>
        bool HasMissingColumns { get; }

        /// <summary>
        ///     Gets a value indicating whether has missing relationships.
        /// </summary>
        bool HasMissingRelationships { get; }

        /// <summary>
        ///     Gets a value indicating whether is broken.
        /// </summary>
        bool IsBroken { get; }

        /// <summary>
        ///     Gets or sets the problem table.
        /// </summary>
        Table ProblemTable { get; set; }

        /// <summary>
        ///     Gets the problem table name.
        /// </summary>
        string ProblemTableName { get; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// Compare table columns.
        /// </summary>
        /// <param name="firstTable">
        /// The first table.
        /// </param>
        /// <param name="secondTable">
        /// The second table.
        /// </param>
        /// <returns>
        /// The <see cref="ApplicationTableDifference"/>.
        /// </returns>
        ApplicationTableDifference CompareTableColumns(Table firstTable, Table secondTable);

        #endregion
    }
}