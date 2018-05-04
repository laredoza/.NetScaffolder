// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationTableDifference.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Differences
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;

    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Model.Difference;

    #endregion

    /// <summary>
    ///     The table difference.
    /// </summary>
    public class ApplicationTableDifference : IApplicationTableDifference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the column data type diffs.
        /// </summary>
        public List<ColumnDataTypeDifference> ColumnDataTypeDiffs { get; set; }

        /// <summary>
        ///     Gets or sets the first extra columns.
        /// </summary>
        public List<Column> FirstExtraColumns { get; set; }

        /// <summary>
        ///     Gets or sets the first extra Relationships.
        /// </summary>
        public List<Relationship> FirstExtraRelationships { get; set; }

        /// <summary>
        ///     Gets or sets the first missing columns.
        /// </summary>
        public List<Column> FirstMissingColumns { get; set; }

        /// <summary>
        ///     Gets or sets the first missing Relationships.
        /// </summary>
        public List<Relationship> FirstMissingRelationships { get; set; }

        /// <summary>
        ///     Gets a value indicating whether has column data type diffs.
        /// </summary>
        public bool HasColumnDataTypeDiffs
        {
            get
            {
                return this.ColumnDataTypeDiffs != null && this.ColumnDataTypeDiffs.Count > 0;
            }
        }

        /// <summary>
        ///     Gets a value indicating whether has extra columns.
        /// </summary>
        public bool HasExtraColumns
        {
            get
            {
                return this.FirstExtraColumns != null && this.FirstExtraColumns.Count > 0;
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets a value indicating whether has extra Relationships.
        /// </summary>
        public bool HasExtraRelationships
        {
            get
            {
                return this.FirstExtraRelationships != null && this.FirstExtraRelationships.Count > 0;
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets a value indicating whether has missing columns.
        /// </summary>
        public bool HasMissingColumns
        {
            get
            {
                return this.FirstMissingColumns != null && this.FirstMissingColumns.Count > 0;
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets a value indicating whether has missing Relationships.
        /// </summary>
        public bool HasMissingRelationships
        {
            get
            {
                return this.FirstMissingRelationships != null && this.FirstMissingRelationships.Count > 0;
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     Gets a value indicating whether is broken.
        /// </summary>
        public bool IsBroken
        {
            get
            {
                return ((this.FirstMissingColumns.Count > 0) || (this.FirstExtraColumns.Count > 0)
                                                             || (this.FirstExtraRelationships.Count > 0)
                                                             || (this.FirstMissingRelationships.Count > 0))
                       || (this.ColumnDataTypeDiffs.Count > 0);
            }
        }

        /// <summary>
        ///     Gets or sets the problem table.
        /// </summary>
        public Table ProblemTable { get; set; }

        /// <summary>
        ///     Gets the problem table name.
        /// </summary>
        public string ProblemTableName
        {
            get
            {
                return this.ProblemTable.QualifiedTableName;
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The compare table columns.
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
        public ApplicationTableDifference CompareTableColumns(Table firstTable, Table secondTable)
        {
            var retval = new ApplicationTableDifference();

            var secondTableColumnNameList =
                new HashSet<string>(secondTable.Columns.Select(u => u.ColumnName.ToUpper()));
            retval.FirstExtraColumns = firstTable.Columns
                .Where(c => !secondTableColumnNameList.Contains(c.ColumnName.ToUpper())).ToList();

            var firstTableColumnNameList = new HashSet<string>(firstTable.Columns.Select(u => u.ColumnName.ToUpper()));
            retval.FirstMissingColumns = secondTable.Columns
                .Where(c => !firstTableColumnNameList.Contains(c.ColumnName.ToUpper())).ToList();

            var secondTableRelationshipTableNames =
                new HashSet<string>(secondTable.Relationships.Select(u => u.TableName.ToUpper()));
            retval.FirstExtraRelationships = firstTable.Relationships
                .Where(u => !secondTableRelationshipTableNames.Contains(u.TableName.ToUpper())).ToList();

            var firstTableRelationshipTableNames =
                new HashSet<string>(firstTable.Relationships.Select(u => u.TableName.ToUpper()));
            retval.FirstMissingRelationships = secondTable.Relationships
                .Where(u => !firstTableRelationshipTableNames.Contains(u.TableName.ToUpper())).ToList();

            retval.ColumnDataTypeDiffs = new List<ColumnDataTypeDifference>();
            foreach (var column in firstTable.Columns)
            {
                var secondColumn =
                    secondTable.Columns.FirstOrDefault(u => u.ColumnName.ToUpper() == column.ColumnName.ToUpper());
                if (secondColumn != null && column.DomainDataType != secondColumn.DomainDataType)
                    retval.ColumnDataTypeDiffs.Add(
                        new ColumnDataTypeDifference
                            {
                                FirstColumn = column,
                                SecondColumn = secondColumn,
                                FirstColumnName = column.ColumnName,
                                FirstColumnDataType = column.DomainDataType,
                                SecondColumnDataType = secondColumn.DomainDataType
                        });
            }

            if (retval.IsBroken)
            {
                retval.ProblemTable = firstTable;
                return retval;
            }

            return null;
        }

        #endregion
    }
}