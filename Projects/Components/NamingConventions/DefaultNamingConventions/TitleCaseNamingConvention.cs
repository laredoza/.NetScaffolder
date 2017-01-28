// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNamingConvention.cs" company="">
//   
// </copyright>
// <summary>
//   The title case naming convention.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.NamingConventions.DefaultNamingConventions
{
    #region Using

    using System;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    /// The title case naming convention.
    /// </summary>
    /// <example>securityview will be SecurityView</example>
    [Export(typeof(INamingConvention))]
    [ExportMetadata("NameMetaData", "TitleCase")]
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
                //case NamingConventionType.TitleCaseNoUnderScore:
                //    return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower()).Replace("_", "");
        }

        #endregion
    }
}