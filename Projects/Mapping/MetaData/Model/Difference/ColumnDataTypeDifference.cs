// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnDataTypeDifference.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model.Difference
{
    /// <summary>
    ///     The column data type difference.
    /// </summary>
    public class ColumnDataTypeDifference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the first column.
        /// </summary>
        public Column FirstColumn { get; set; }

        /// <summary>
        ///     Gets or sets the first column data type.
        /// </summary>
        public DomainDataType FirstColumnDataType { get; set; }

        /// <summary>
        ///     Gets or sets the first column name.
        /// </summary>
        public string FirstColumnName { get; set; }

        /// <summary>
        ///     Gets or sets the second column.
        /// </summary>
        public Column SecondColumn { get; set; }

        /// <summary>
        ///     Gets or sets the second column data type.
        /// </summary>
        public DomainDataType SecondColumnDataType { get; set; }

        #endregion
    }
}