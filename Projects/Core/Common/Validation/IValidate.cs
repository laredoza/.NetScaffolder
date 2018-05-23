// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IValidate.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Common.Validation
{
    #region Usings

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The Validate interface.
    /// </summary>
    public interface IValidate
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />
        ///     Errors returned
        /// </returns>
        List<Validation> Validate();

        #endregion
    }
}