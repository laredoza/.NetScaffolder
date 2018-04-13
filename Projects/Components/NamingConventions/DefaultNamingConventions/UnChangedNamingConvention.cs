// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnChangedNamingConvention.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.NamingConventions.DefaultNamingConventions
{
    #region Usings

    using System;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The title case naming convention.
    /// </summary>
    /// <example>securityview will be SecurityView</example>
    [Export(typeof(INamingConvention))]
    [ExportMetadata("NameMetaData", "UnChanged")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4412")]
    public class UnChangedNamingConvention : INamingConvention
    {
        #region Public methods and operators

        /// <summary>
        /// Apply naming convention.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string ApplyNamingConvention(string value)
        {
            return value;
        }

        #endregion
    }
}