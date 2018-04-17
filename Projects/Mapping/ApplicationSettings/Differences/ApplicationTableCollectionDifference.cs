// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationTableCollectionDifference.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices.Differences
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The application table collection difference.
    /// </summary>
    public class ApplicationTableCollectionDifference : IApplicationTableCollectionDifference
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationTableCollectionDifference"/> class.
        /// </summary>
        /// <param name="applicationTableDifference">
        /// The application table difference.
        /// </param>
        public ApplicationTableCollectionDifference(IApplicationTableDifference applicationTableDifference)
        {
            this.ApplicationTableDifference = applicationTableDifference;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the application table difference.
        /// </summary>
        public IApplicationTableDifference ApplicationTableDifference { get; set; }

        /// <summary>
        ///     Gets or sets the first extra tables.
        /// </summary>
        public List<Table> FirstExtraTables { get; set; }

        /// <summary>
        ///     Gets or sets the first missing tables.
        /// </summary>
        public List<Table> FirstMissingTables { get; set; }

        /// <summary>
        ///     Gets or sets the problem tables.
        /// </summary>
        public List<ApplicationTableDifference> ProblemTables { get; set; }

        /// <summary>
        /// Gets or sets the refresh table.
        /// </summary>
        public List<Table> RefreshTable
        {
            get
            {
                List<Table> result = new List<Table>();

                foreach (ApplicationTableDifference applicationTableDifference in this.ProblemTables)
                {
                   result.Add(applicationTableDifference.ProblemTable); 
                }

                return result;
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The compare table collections.
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
        public ApplicationTableCollectionDifference CompareTables(List<Table> first, List<Table> second)
        {
            var retval = new ApplicationTableCollectionDifference(this.ApplicationTableDifference);

            // Compare List of Tables
            var firstTableNameList = new HashSet<string>(first.Select(t => t.TableName.ToUpper()));
            retval.FirstExtraTables = second.Where(s => !firstTableNameList.Contains(s.TableName.ToUpper())).ToList();

            var secondTableNameList = new HashSet<string>(second.Select(t => t.TableName.ToUpper()));
            retval.FirstMissingTables = first.Where(s => !secondTableNameList.Contains(s.TableName.ToUpper())).ToList();

            // Compare Columns in tables
            retval.ProblemTables = new List<ApplicationTableDifference>();
            var firstValidTables = first.Where(s => secondTableNameList.Contains(s.TableName.ToUpper())).ToList();
            foreach (var firstTable in firstValidTables)
            {
                var secondTable = second.FirstOrDefault(u => u.TableName.ToUpper() == firstTable.TableName.ToUpper());

                if (secondTable != null)
                {
                    var diff = this.ApplicationTableDifference.CompareTableColumns(firstTable, secondTable);
                    if (diff != null)
                        retval.ProblemTables.Add(diff);
                }
            }

            return retval;
        }

        #endregion
    }
}