// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNoUnderScoreNamingConvention.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.NamingConventions.DefaultNamingConventions
{
    #region Usings

    using System;
    using System.ComponentModel.Composition;
    using System.Threading;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The title case no under score naming convention.
    /// </summary>
    [Export(typeof(INamingConvention))]
    [ExportMetadata("NameMetaData", "TitleCaseNoUnderScore")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class TitleCaseNoUnderScoreNamingConvention : INamingConvention
    {
        #region Public methods and operators

        /// <summary>
        /// Apply the naming convention.
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
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower()).Replace("_", string.Empty);
        }

        #endregion
    }
}