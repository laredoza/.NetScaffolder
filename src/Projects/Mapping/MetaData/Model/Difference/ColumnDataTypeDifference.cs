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
        ///     Gets or sets a value indicating whether column order is different.
        /// </summary>
        public bool ColumnOrderIsDifferent { get; set; }

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
        ///     Gets or sets a value indicating whether is required is different.
        /// </summary>
        public bool IsRequiredDifferent { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether length is different.
        /// </summary>
        public bool LengthIsDifferent { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether precision is different.
        /// </summary>
        public bool PrecisionIsDifferent { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether primary key is different.
        /// </summary>
        public bool PrimaryKeyIsDifferent { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether scale is different.
        /// </summary>
        public bool ScaleIsDifferent { get; set; }

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