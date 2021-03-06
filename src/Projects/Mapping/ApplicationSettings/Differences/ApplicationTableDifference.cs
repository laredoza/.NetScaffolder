﻿// --------------------------------------------------------------------------------------------------------------------
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
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationTableDifference"/> class.
        /// </summary>
        public ApplicationTableDifference()
        {
            this.ProblemIndexes = new List<Index>();
            this.FirstMissingRelationships = new List<Relationship>();
            this.FirstExtraRelationships = new List<Relationship>();
            this.UpdatedRelationships = new List<Relationship>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the column data type diffs.
        /// </summary>
        public List<ColumnDataTypeDifference> ColumnDataTypeDiffs { get; set; }

        /// <summary>
        ///     Gets or sets the extra indexes.
        /// </summary>
        public List<Index> ExtraIndexes { get; set; }

        /// <summary>
        ///     Gets or sets the first extra columns.
        /// </summary>
        public List<Column> FirstExtraColumns { get; set; }

        /// <summary>
        ///     Gets or sets the first extra Relationships.
        /// </summary>
        public List<Relationship> FirstExtraRelationships { get; set; }

        public List<Relationship> UpdatedRelationships { get; set; }

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
                return (this.FirstMissingColumns.Count > 0) || (this.FirstExtraColumns.Count > 0)
                                                             || (this.FirstExtraRelationships.Count > 0)
                                                             || (this.FirstMissingRelationships.Count > 0)
                                                             || (this.ColumnDataTypeDiffs.Count > 0)
                                                             || (this.ExtraIndexes.Count > 0)
                                                             || (this.MissingIndexes.Count > 0)
                                                             || (this.ProblemIndexes.Count > 0)
                                                             || (this.UpdatedRelationships.Count > 0);
            }
        }

        /// <summary>
        ///     Gets or sets the missing indexes.
        /// </summary>
        public List<Index> MissingIndexes { get; set; }

        /// <summary>
        ///     Gets or sets the problem indexes.
        /// </summary>
        public List<Index> ProblemIndexes { get; set; }

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
            this.ProblemIndexes = new List<Index>();

            var retval = new ApplicationTableDifference();

            // Extra Columns
            var secondTableColumnNameList =
                new HashSet<string>(secondTable.Columns.Select(u => u.ColumnName.ToUpper()));
            retval.FirstExtraColumns = firstTable.Columns
                .Where(c => !secondTableColumnNameList.Contains(c.ColumnName.ToUpper())).ToList();

            var firstTableColumnNameList = new HashSet<string>(firstTable.Columns.Select(u => u.ColumnName.ToUpper()));
            retval.FirstMissingColumns = secondTable.Columns
                .Where(c => !firstTableColumnNameList.Contains(c.ColumnName.ToUpper())).ToList();

            FindRelationshipDifferences(firstTable, secondTable, retval);

            RefreshIndexes(firstTable, secondTable, retval);

            retval.ColumnDataTypeDiffs = new List<ColumnDataTypeDifference>();
            foreach (var column in firstTable.Columns)
            {
                var secondColumn =
                    secondTable.Columns.FirstOrDefault(u => u.ColumnName.ToUpper() == column.ColumnName.ToUpper());
                if (secondColumn != null && (column.DomainDataType != secondColumn.DomainDataType
                                             || column.ColumnOrder != secondColumn.ColumnOrder
                                             || column.IsPrimaryKey != secondColumn.IsPrimaryKey
                                             || column.IsRequired != secondColumn.IsRequired
                                             || column.Length != secondColumn.Length
                                             || column.Precision != secondColumn.Precision
                                             || column.Scale != secondColumn.Scale
                                             || column.IsIdentity != secondColumn.IsIdentity
                                             || column.IdentityIncrement != secondColumn.IdentityIncrement
                                             || column.IdentitySeed != secondColumn.IdentitySeed

                                             ))
                    retval.ColumnDataTypeDiffs.Add(
                        new ColumnDataTypeDifference
                            {
                                FirstColumn = column,
                                SecondColumn = secondColumn,
                                FirstColumnName = column.ColumnName,
                                FirstColumnDataType = column.DomainDataType,
                                SecondColumnDataType = secondColumn.DomainDataType,
                                ColumnOrderIsDifferent =
                                    column.ColumnOrder != secondColumn.ColumnOrder,
                                PrimaryKeyIsDifferent =
                                    column.IsPrimaryKey != secondColumn.IsPrimaryKey,
                                IsRequiredDifferent =
                                    column.IsRequired != secondColumn.IsRequired,
                                LengthIsDifferent = column.Length != secondColumn.Length,
                                PrecisionIsDifferent =
                                    column.Precision != secondColumn.Precision,
                                ScaleIsDifferent = column.Scale != secondColumn.Scale,

                                //IsIdentity = column.IsIdentity != secondColumn.IsIdentity
                                //IdentityIncrement = column.IdentityIncrement != secondColumn.IdentityIncrement
                                //IdentitySeed = column.IdentitySeed != secondColumn.IdentitySeed
                        });
            }

            if (retval.IsBroken)
            {
                // retval.ProblemTable = firstTable;
                retval.ProblemTable = secondTable;
                return retval;
            }

            return null;
        }

        private static void FindRelationshipDifferences(Table firstTable, Table secondTable, ApplicationTableDifference retval)
        {
            // Relationships
            var secondTableRelationshipTableNames =
                new HashSet<string>(secondTable.Relationships.Select(u => u.ReferencedTableName.ToUpper()));
            retval.FirstExtraRelationships.AddRange(firstTable.Relationships
                .Where(u => !secondTableRelationshipTableNames.Contains(u.ReferencedTableName.ToUpper())).ToList());

            var firstTableRelationshipTableNames =
                new HashSet<string>(firstTable.Relationships.Select(u => u.ReferencedTableName.ToUpper()));
            retval.FirstMissingRelationships.AddRange(secondTable.Relationships
                .Where(u => !firstTableRelationshipTableNames.Contains(u.ReferencedTableName.ToUpper())).ToList());

            secondTableRelationshipTableNames =
                new HashSet<string>(secondTable.Relationships.Select(u => u.RelationshipName.ToUpper()));
            retval.FirstExtraRelationships.AddRange(firstTable.Relationships
                .Where(u => !secondTableRelationshipTableNames.Contains(u.RelationshipName.ToUpper())).ToList());

            firstTableRelationshipTableNames =
                new HashSet<string>(firstTable.Relationships.Select(u => u.RelationshipName.ToUpper()));
            retval.FirstMissingRelationships.AddRange(secondTable.Relationships
                .Where(u => !firstTableRelationshipTableNames.Contains(u.RelationshipName.ToUpper())).ToList());

            secondTableRelationshipTableNames =
                new HashSet<string>(secondTable.Relationships.Select(u => u.ColumnName.ToUpper()));
            retval.FirstExtraRelationships.AddRange(firstTable.Relationships
                .Where(u => !secondTableRelationshipTableNames.Contains(u.ColumnName.ToUpper())).ToList());

            firstTableRelationshipTableNames =
                new HashSet<string>(firstTable.Relationships.Select(u => u.ColumnName.ToUpper()));
            retval.FirstMissingRelationships.AddRange(secondTable.Relationships
                .Where(u => !firstTableRelationshipTableNames.Contains(u.ColumnName.ToUpper())).ToList());

            secondTableRelationshipTableNames =
                new HashSet<string>(secondTable.Relationships.Select(u => u.ReferencedColumnName.ToUpper()));
            retval.FirstExtraRelationships.AddRange(firstTable.Relationships
                .Where(u => !secondTableRelationshipTableNames.Contains(u.ReferencedColumnName.ToUpper())).ToList());

            firstTableRelationshipTableNames =
                new HashSet<string>(firstTable.Relationships.Select(u => u.ReferencedColumnName.ToUpper()));
            retval.FirstMissingRelationships.AddRange(secondTable.Relationships
                .Where(u => !firstTableRelationshipTableNames.Contains(u.ReferencedColumnName.ToUpper())).ToList());

            retval.FirstExtraRelationships.GroupBy(a => a.RelationshipName);
            retval.FirstMissingRelationships.GroupBy(a => a.RelationshipName);

            //Check for multiplicaity changes

            foreach (var firstTableRelationship in firstTable.Relationships)
            {
                //Checking on DependencyRelationShip as a self referencing table has both a parent and child relationship
                if (secondTable.Relationships.Any(r =>
                    r.RelationshipName == firstTableRelationship.RelationshipName && r.DependencyRelationShip == firstTableRelationship.DependencyRelationShip && (r.Multiplicity != firstTableRelationship.Multiplicity || r.ReferencedMultiplicity != firstTableRelationship.ReferencedMultiplicity)))
                {
                    var secondTableRelationships = secondTable.Relationships.Where(r =>
                        r.RelationshipName == firstTableRelationship.RelationshipName && firstTableRelationship.DependencyRelationShip == firstTableRelationship.DependencyRelationShip);

                    foreach (var secondTableRelationship in secondTableRelationships)
                    {
                        if (secondTableRelationship != null)
                        {
                            firstTableRelationship.Multiplicity = secondTableRelationship.Multiplicity;
                            firstTableRelationship.ReferencedMultiplicity = secondTableRelationship.ReferencedMultiplicity;
                            retval.UpdatedRelationships.Add(firstTableRelationship);
                        }
                    }

                    
                }
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The refresh indexes.
        /// </summary>
        /// <param name="firstTable">
        /// The first table.
        /// </param>
        /// <param name="secondTable">
        /// The second table.
        /// </param>
        /// <param name="retval">
        /// The retval.
        /// </param>
        private static void RefreshIndexes(Table firstTable, Table secondTable, ApplicationTableDifference retval)
        {
            // Indexes
            var secondTableIndexTableNames = new HashSet<string>(secondTable.Indexes.Select(u => u.Name.ToUpper()));
            retval.ExtraIndexes = firstTable.Indexes.Where(u => !secondTableIndexTableNames.Contains(u.Name.ToUpper()))
                .ToList();

            var firstTableIndexTableNames = new HashSet<string>(firstTable.Indexes.Select(u => u.Name.ToUpper()));
            retval.MissingIndexes = secondTable.Indexes
                .Where(u => !firstTableIndexTableNames.Contains(u.Name.ToUpper())).ToList();

            if (retval.ExtraIndexes.Count == 0 && retval.MissingIndexes.Count == 0)
            {
                foreach (Index index in firstTable.Indexes)
                {
                    Index secondIndex =
                        secondTable.Indexes.FirstOrDefault(i => i.Name.ToUpper() == index.Name.ToUpper());
                    if (secondIndex != null)
                    {
                        if (index.IsUnique != secondIndex.IsUnique || index.Name.ToUpper() != secondIndex.Name.ToUpper()
                                                                   || index.IndexType != secondIndex.IndexType)
                        {
                            retval.ProblemIndexes.Add(index);
                        }
                        else
                        {
                            var secondIndexColumnNames =
                                new HashSet<string>(secondIndex.Columns.Select(u => u.ToUpper()));
                            var extraIndexColumns = index.Columns
                                .Where(u => !secondIndexColumnNames.Contains(u.ToUpper())).ToList();
                            if (extraIndexColumns.Count > 0)
                            {
                                retval.ProblemIndexes.Add(index);
                            }
                            else
                            {
                                var firstIndexColumnNames = new HashSet<string>(index.Columns.Select(u => u.ToUpper()));
                                var missingIndexColumns = secondIndex.Columns
                                    .Where(u => !firstIndexColumnNames.Contains(u.ToUpper())).ToList();

                                if (missingIndexColumns.Count > 0)
                                {
                                    retval.ProblemIndexes.Add(index);
                                }
                                else
                                {
                                    foreach (string column in index.Columns)
                                    {
                                        var secondColumn =
                                            secondIndex.Columns.FirstOrDefault(c => c.ToUpper() == column.ToUpper());

                                        if (column.ToUpper() != secondColumn.ToUpper())
                                        {
                                            retval.ProblemIndexes.Add(index);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
 
        #endregion
    }
}