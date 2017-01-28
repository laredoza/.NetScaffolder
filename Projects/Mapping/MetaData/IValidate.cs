// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IValidate.cs" company="">
//   
// </copyright>
// <summary>
//   The Validate interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData
{
    #region Using

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The Validate interface.
    /// </summary>
    public interface IValidate
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        List<string> ValidationResult { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />
        ///     Errors returned
        /// </returns>
        List<string> Validate();

        #endregion
    }
}