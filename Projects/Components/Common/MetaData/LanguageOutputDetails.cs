// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LanguageOutputDetails.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.MetaData
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// The language output details.
    /// </summary>
    public class LanguageOutputDetails
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the language output.
        /// </summary>
        public Guid LanguageOutput { get; set; }

        /// <summary>
        /// Gets or sets the template name.
        /// </summary>
        public string TemplateName { get; set; }

        #endregion
    }
}