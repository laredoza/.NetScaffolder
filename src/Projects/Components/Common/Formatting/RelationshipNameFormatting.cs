// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RelationshipNameFormatting.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    /// The relationship name formatting.
    /// </summary>
    public static class RelationshipNameFormatting
    {
        #region Public Methods And Operators

        /// <summary>
        /// The format name.
        /// </summary>
        /// <param name="tableName">
        /// The table name.
        /// </param>
        /// <param name="alias">
        /// The alias.
        /// </param>
        /// <param name="nc">
        /// The nc.
        /// </param>
        /// <param name="names">
        /// The names.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string FormatName(
            string tableName,
            string alias,
            INamingConvention nc = null,
            IEnumerable<string> names = null)
        {
            string formattedName = string.IsNullOrEmpty(alias) ? tableName : alias;

            if (names != null)
            {
                int index = 1;
                int checkCount = 1;
                string updatedName = formattedName;

                while (names.Count(o => o == updatedName) > checkCount)
                {
                    updatedName = $"{formattedName}{index}";
                    index++;
                    checkCount = 0;
                }

                formattedName = updatedName;
            }

            return nc != null ? nc.ApplyNamingConvention(formattedName) : formattedName;
        }

        #endregion
    }
}