// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LanguageOutputDetails.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.MetaData
{
    #region Usings

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The language output details.
    /// </summary>
    public class LanguageOutputDetails
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LanguageOutputDetails" /> class.
        /// </summary>
        public LanguageOutputDetails()
        {
            this.Templates = new List<string>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the language output.
        /// </summary>
        public Guid LanguageOutput { get; set; }

        /// <summary>
        ///     Gets or sets the output generator.
        /// </summary>
        public Guid OutputGenerator { get; set; }

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<string> Templates { get; set; }

        #endregion
    }
}