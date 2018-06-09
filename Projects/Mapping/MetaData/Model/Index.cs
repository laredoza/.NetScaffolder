// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Index.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The index.
    /// </summary>
    public class Index : ICloneable
    {
        public Index()
        {
            this.Columns = new List<string>();
        }

        #region Public Properties

        /// <summary>
        ///     Gets or sets the index type.
        /// </summary>
        public string IndexType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is unique.
        /// </summary>
        public bool IsUnique { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        public List<string> Columns { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public object Clone()
        {
            Index result = new Index { IndexType = this.IndexType, IsUnique = this.IsUnique, Name = this.Name };

            foreach (var column in this.Columns)
            {
                result.Columns.Add(column);
            }

            return result;
        }

        #endregion
    }
}