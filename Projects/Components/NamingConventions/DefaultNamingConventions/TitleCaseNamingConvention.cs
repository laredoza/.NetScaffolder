// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNamingConvention.cs" company="DotnetScaffolder">
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
    [ExportMetadata("NameMetaData", "TitleCase")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class TitleCaseNamingConvention : INamingConvention
    {
        #region Public methods and operators

        /// <summary>
        /// The apply naming convention.
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
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }

        #endregion
    }
}