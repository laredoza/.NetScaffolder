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
    /// The application table collection difference.
    /// </summary>
    public class ApplicationTableCollectionDifference : IApplicationTableCollectionDifference
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the first extra tables.
        /// </summary>
        public List<Table> FirstExtraTables { get; set; }

        /// <summary>
        /// Gets or sets the first missing tables.
        /// </summary>
        public List<Table> FirstMissingTables { get; set; }

        /// <summary>
        /// Gets or sets the problem tables.
        /// </summary>
        public List<ApplicationTableDifference> ProblemTables { get; set; }

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
        public static ApplicationTableCollectionDifference CompareTableCollections(
            List<Table> first,
            List<Table> second)
        {
            var retval = new ApplicationTableCollectionDifference();

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
                    var diff = ApplicationTableDifference.CompareTableColumns(firstTable, secondTable);
                    if (diff != null)
                        retval.ProblemTables.Add(diff);
                }
            }

            return retval;
        }

        #endregion
    }
}